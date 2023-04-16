using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_topicIntro : Form
    {
        public fm_topicIntro()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_topicIntro_Resize);// creates new event for Form resize
        }

        private void fm_topicIntro_Resize(object sender, EventArgs e)
        {
            setupUI();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            fm_menu.Create();
            this.Close();
        }

        public void setupUI()
        {
            richtxtbx_Explain.Location = new System.Drawing.Point(bt_exit.Location.X, bt_exit.Location.Y + bt_exit.Height + 10);
            richtxtbx_Explain.Size = new Size(this.Width - 40, this.Height - 90);
        }// set the location of richtext box

        public static void Create()
        {
            fm_topicIntro fm_TopicIntro = new fm_topicIntro();
            fm_TopicIntro.Show();
        }

        private void fm_topicIntro_Load(object sender, EventArgs e)
        {
            richtxtbx_Explain.LoadFile(@"Learn Topic.rtf");// load the file in richtext box
        }
    }
}
