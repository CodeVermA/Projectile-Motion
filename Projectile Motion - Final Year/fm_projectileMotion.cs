using System;
using System.Drawing;
using System.Windows.Forms;

//↑  ↓
namespace Projectile_Motion___Final_Year
{
    public partial class fm_projectileMotion : Form
    {
        private Board board;
        private int graphScale = 6, cordinatesScale = 1, lastDrawnGraphScale;
        private double targetLocation;
        private fm_SimulationInformation fm_SimulationData;

        public fm_projectileMotion()
        {
            InitializeComponent();
            initializeFormSimulationData();
            board = new Board(picBox_Graph);
            this.Shown += new EventHandler(fm_projectileMotion_Shown);
            this.SizeChanged += new EventHandler(fm_projectileMotion_Resize);
        }
        
        private void fm_projectileMotion_Shown(object sender, EventArgs e)
        {
            fm_SimulationData.BringToFront();
        }

        private void initializeFormSimulationData()// initialize Simulation Data Form
        {
            fm_SimulationData = new fm_SimulationInformation();
            fm_SimulationData.Location = new Point(5, 5);
            fm_SimulationData.Show();
        }

        public static void Create()//Create a copy of this Form
        {
            fm_projectileMotion fm_ProjectileMotion = new fm_projectileMotion();
            fm_ProjectileMotion.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_menu.Create();
        }

        private void fm_projectileMotion_Resize(object sender, EventArgs e)
        {
            setupUI();
            lastDrawnGraphScale = 0;
        }

        void setupUI()
        {
            picBox_Graph.Size = new Size(this.Width - (int)(picBox_Graph.Location.X * 1.5) , this.Height - picBox_Graph.Location.Y - lbl_XLabel.Height - 47);
            board.ResetPictureBox(picBox_Graph);

            lbl_YLabel.Location = new Point(5, picBox_Graph.Location.Y + picBox_Graph.Height / 2);
            lbl_XLabel.Location = new Point(picBox_Graph.Location.X + picBox_Graph.Width / 2, this.Height - lbl_XLabel.Height - 45);

            picBox_Graph.Location = new Point(lbl_YLabel.Location.X + lbl_YLabel.Width + 5, chkbx_Target.Location.Y + chkbx_Target.Height + 5);
        }
        private void fm_projectileMotion_Load(object sender, EventArgs e)
        {
            txtbx_Target.Hide();
            lbl_M.Hide();
            updatePointsLbl();
            txtbx_Target.Location = new Point(chkbx_Target.Location.X + chkbx_Target.Width + 5, chkbx_Target.Location.Y);
            lbl_M.Location = new Point(txtbx_Target.Location.X + txtbx_Target.Width + 2, txtbx_Target.Location.Y + txtbx_Target.Height / 4);
        }

        private void updatePointsLbl()// update Points
        {
            lbl_Points.Text = $"POINTS: {Global.User.Points}";
        }

        private void bt_Simulate_Click(object sender, EventArgs e)
        {
            if(graphScale != lastDrawnGraphScale
                )// Draw new Graph if scale Changes
            {
                board.DrawGraph(graphScale,picBox_Graph.Width , picBox_Graph.Height);
                lastDrawnGraphScale = graphScale;
            }

            if (!fm_SimulationData.valuesCalculated)
            {
                double u = fm_SimulationData.srlBar_InitialVelocity.Value;
                double initialHeight = fm_SimulationData.srlBar_InitialHeight.Value;
                double angle = fm_SimulationData.srlBar_Angle.Value;

                fm_SimulationData.simulation = new Simulation(u, angle, initialHeight);
                fm_SimulationData.simulation.CalculateValues();// calculate all the values

                fm_SimulationData.valuesCalculated = true;
            }

            targetLocation = (chkbx_Target.Checked && txtbx_Target.Text.Trim() != "") ? Convert.ToDouble(txtbx_Target.Text) : -1;// set target location

            if (fm_SimulationData.objectFallenAt.Contains(Math.Round(targetLocation,2)) && chkbx_Target.Checked)
            {
                MessageBox.Show("CAN NOT USE THE KNOWN DISPLACEMENT");
            }
            else if(!fm_SimulationData.objectFallenAt.Contains(Math.Round(targetLocation, 2)) && chkbx_Target.Checked)
            {
                checkForPoints(targetLocation);// Check for if target hits and points to user profile
            }

            fm_SimulationData.simulation.CalculateCordinates(); // Calculate the cordinates to draw curve

            scaleCordinates();// sca;e Corrdinates according to scale
            flipYValues(picBox_Graph.Height - 5);//flips Y values

            board.DrawCurve(fm_SimulationData.simulation.Coordinates);

            PointF point = fm_SimulationData.simulation.Coordinates[fm_SimulationData.simulation.Coordinates.Length - 1];
            board.FillCircle(point.X, point.Y);
        }

        private void checkForPoints(double targetLocation)
        {
            int points = 0;
            double s = Math.Round(fm_SimulationData.simulation.Displacement, 1);
            targetLocation = Math.Round(targetLocation, 1);

            if (s == targetLocation)//excat values
            {
                Global.User.Points += 2;
                points = 2;
                fm_SimulationData.objectFallenAt.Add(Math.Round(fm_SimulationData.simulation.Displacement, 2));
            }
            else if(targetLocation >= s - 0.5 && targetLocation <= s + 0.5)// in between range
            {
                Global.User.Points++;
                points = 1;
                fm_SimulationData.objectFallenAt.Add(Math.Round(fm_SimulationData.simulation.Displacement, 2));
            }
            if (Global.User.LoggedIn)
            {
                Global.User.AddReport(points, "Simulation", DateTime.Now);
                Global.User.UpdatePoints();// update user points
            }
            updatePointsLbl();
        }
        private void flipYValues(int maxYValue)
        {
            for(int x = 0; x < fm_SimulationData.simulation.Coordinates.Length; x++)
            {
                fm_SimulationData.simulation.Coordinates[x].Y = maxYValue - fm_SimulationData.simulation.Coordinates[x].Y;
            }
        } //Flip y coordinates
        private void scaleCordinates()
        {
            for(int x = 0; x < fm_SimulationData.simulation.Coordinates.Length; x++)
            {
                fm_SimulationData.simulation.Coordinates[x].X *= cordinatesScale;
                fm_SimulationData.simulation.Coordinates[x].Y *= cordinatesScale;
            }
        }

        private void chkbx_Target_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Target.Checked)
            {
                txtbx_Target.Show();
                lbl_M.Show();
            }
            else
            {
                txtbx_Target.Hide();
                lbl_M.Hide();
            }
        }

        private void lbl_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graph and Points Size will increase by selected factor");
        }

        private void bt_ClearScreen_Click(object sender, EventArgs e)
        {
            board.Clear();
            lastDrawnGraphScale = 0;
        }//Clears the board

        private void srlBar_Scale_Scroll(object sender, ScrollEventArgs e)
        {
            graphScale = srlBar_Scale.Value;
            cordinatesScale = srlBar_Scale.Value - srlBar_Scale.Minimum;
            lbl_ScaleNum.Text = $"X{srlBar_Scale.Value.ToString()}";
            lbl_Help.Location = new Point(lbl_ScaleNum.Location.X + lbl_ScaleNum.Width + 5, lbl_Help.Location.Y);
        }
    }
}
