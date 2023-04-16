using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_SimulationInformation : Form
    {
        private Label lbl_Formulas;
        public List<double> objectFallenAt;// list to store knon values of displacement
        public bool valuesCalculated = false;
        internal Simulation simulation;

        public fm_SimulationInformation()
        {
            InitializeComponent();
            objectFallenAt = new List<double>();    
        }

        private void bt_CalculateValues_Click(object sender, EventArgs e)
        {
            if(!valuesCalculated)
            {
                double u = srlBar_InitialVelocity.Value;
                double initialHeight = srlBar_InitialHeight.Value;
                double angle = srlBar_Angle.Value;

                simulation = new Simulation(u, angle, initialHeight);
                valuesCalculated = true;

                simulation.CalculateValues();
               
                objectFallenAt.Add(Math.Round(simulation.Displacement,2));
            }
            updateInfoLabels();
        }// Calculate the values if not calculated


        private void bt_ShowFormulas_Click(object sender, EventArgs e)
        {

            if (bt_ShowFormulas.Text == "SHOW USED FORMULAS")
            {
                showFromulaLabel();
                bt_ShowFormulas.Text = "HIDE";
            }
            else
            {
                bt_ShowFormulas.Text = "SHOW USED FORMULAS";
                lbl_Formulas.Dispose();
            }
        }
        //Display sthe formula used
    private void showFromulaLabel()
    {
        lbl_Formulas = new Label();

        lbl_Formulas.Text = new Simulation().ShowFormulas();
        this.Controls.Add(lbl_Formulas);
        lbl_Formulas.AutoSize = true;
            lbl_Formulas.Font = new Font(lbl_Displacement.Font.Name, 10, FontStyle.Regular);
        lbl_Formulas.Location = new Point(bt_ShowFormulas.Location.X, bt_ShowFormulas.Location.Y + bt_ShowFormulas.Height + 5);

        lbl_Formulas.Show();
    }

        private void updateInfoLabels()// displays the caculated values
        {
            lbl_MaxHeight.Text = $"MAX HEIGHT REACHED: {Math.Round(simulation.Height, 2)}m";
            lbl_Displacement.Text = $"DISPLACEMENT: {Math.Round(simulation.Displacement, 2)}m";
            lbl_TimeTaken.Text = $"TIME TAKEN: {Math.Round(simulation.Time, 2)}s";
            lbl_TimeToMaxHeight.Text = $"TIME TAKEN TO REACH MAX HEIGHT: {Math.Round(simulation.TimeToMaxHeight, 2)}s";
        }

        private void srlBar_InitialVelocity_Scroll(object sender, ScrollEventArgs e)
        {
            valuesCalculated = false;
            lbl_InitialVelocityNum.Text = $"{srlBar_InitialVelocity.Value.ToString()} m/s";
        }

        private void srlBar_Angle_Scroll(object sender, ScrollEventArgs e)
        {
            valuesCalculated = false;
            lbl_AngleNum.Text = $"{srlBar_Angle.Value.ToString()}°";
        }

        private void srlBar_InitialHeight_Scroll(object sender, ScrollEventArgs e)
        {
            valuesCalculated = false;
            lbl_InitialHeightNum.Text = $"{srlBar_InitialHeight.Value.ToString()} m";
        }

        private void srlBar_Scale_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_InitialVelocityNum.Text = srlBar_InitialVelocity.Value.ToString();
        }

        
    }
}
