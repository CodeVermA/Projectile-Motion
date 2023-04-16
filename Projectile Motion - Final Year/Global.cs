using System;

namespace Projectile_Motion___Final_Year
{
    static class Global
    {
        public static Random Random = new Random();
        public static User User = new User();

        public static void OpenHiddenForm(string formName)// To open Hidden Form
        {
            foreach (System.Windows.Forms.Form fm in System.Windows.Forms.Application.OpenForms)
            {
                if (fm.Name == formName)
                {
                    fm.Show();
                }
            }
        }
        public static void EnableForm(string formName)// to Activate deactivated forms
        {
            foreach (System.Windows.Forms.Form fm in System.Windows.Forms.Application.OpenForms)
            {
                if (fm.Name == formName && fm.Enabled == false)
                {
                    fm.Enabled = true;
                    fm.BringToFront();
                }
            }
        }
    }
}
