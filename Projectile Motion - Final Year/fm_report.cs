using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_report : Form
    {
        public fm_report()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_report_SizeChanged);// creating new event when for size chnage
        }

        public void fm_report_SizeChanged(object sender, EventArgs e)
        {
            setupUI();
        }

        public static void Create()
        {
            fm_report fm_Report = new fm_report();
            fm_Report.Show();
        }// Create a new copy of this form

        public void setupUI()
        {
            lstbx_showReport.Location = new Point(bt_exit.Location.X, bt_exit.Location.Y + bt_exit.Height + 10);
            lstbx_showReport.Size = new Size(this.Width - 40, this.Height - 90);
        }// set the location of list box

        private void fm_report_Load(object sender, EventArgs e)
        {
            foreach(var item in Report.Load(Global.User.ID))// load all the reports in listbox
            {
                lstbx_showReport.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm_menu.Create();
            this.Close();
        }

    }
}
