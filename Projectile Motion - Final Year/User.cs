using System;
using System.Data;

namespace Projectile_Motion___Final_Year
{
    public class User
    {
        private Database database;
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int ID { get; private set; }
        public bool LoggedIn { get; private set; }

        public int Points;
        public double MarksGot;
        public double TotoalMarks;

        public User()
        {
            database = new Database();
        }

        public double CalculateMarksPercentage()
        {
            return Math.Round(MarksGot / TotoalMarks* 100, 2);
        }//Calculate the percentage of marks

        public bool Add(string firstname, string lastname, string username, string password)
        {
            //check if user already exits 
            bool newUser = false;
            DataTable dt = database.Get_User(firstname, lastname);
            if(dt.Rows.Count == 0)
            {
                database.Add_User(firstname, lastname, username, password);
                newUser = true;
            }

            return newUser;
        }
        public bool Login(string username, string password)
        {
            //Check if user exists
            DataTable dt = database.Get_UserDetails(username, password);
            if(dt.Rows.Count > 0 && dt.Rows[0][3].ToString() == username && dt.Rows[0][4].ToString() == password)
            {
                EnterDetails(dt);
                LoggedIn = true;
            }

            return LoggedIn;
        }
        private void EnterDetails(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                Firstname = row["Firstname"].ToString();
                Lastname = row["Lastname"].ToString();
                Username = row["Username"].ToString();
                Password = row["Password"].ToString();
                ID = Convert.ToInt32(row["Id"].ToString());
                Points = Convert.ToInt32(row["Points"].ToString());
                MarksGot = Convert.ToInt32(row["Marks Earned"].ToString());
                TotoalMarks = Convert.ToInt32(row["Total Marks"].ToString());
            }
        }// enter details about user
        public void Delete()
        {
            database.Delete_User(ID);
        }// Delete this user
        public void ChangePassword(string newPass)
        {
            database.Update_UserPassword(newPass, ID);
            Password = newPass;
        }// chang eold password with new password
        public void AddReport(int points, string fromWhere, DateTime date)
        {
            database.InsertInto_Report(ID,points, fromWhere, date);
        }// Add new report

        public void UpdatePoints()
        {
            database.Update_UserPoints(this);
        }//update points

        public void ClearData()
        {
            Points = 0;
            MarksGot = 0;
            TotoalMarks = 0;
            database.Delete_Report(ID);
            database.Update_UserPoints(this);
            database.Delete_QuestionByUserID(ID);
        }// Clear user data
    }
}
