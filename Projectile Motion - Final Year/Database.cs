using System;
using System.Data.SqlClient;
using System.Data;

namespace Projectile_Motion___Final_Year
{
    class Database
    {
        private string connectionString;
        private SqlConnection Connection;

        public Database()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vasuv\OneDrive\Desktop\Projectile Motion - Final Year\Projectile Motion - Final Year\Database.mdf;Integrated Security=True;Connect Timeout=30";
            Connection = new SqlConnection(connectionString);
        }
        
        public DataTable Get_UserDetails(string username, string password)// for if the first and last name already exists
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [Users] WHERE [Username] = @username AND [Password] = @password";

            Connection.Open();

            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Get_User(string firstname, string lastname)// to check is username and password exists 
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [Users] WHERE [Firstname] = @Firstname AND [Lastname] = @Lastname";

            Connection.Open();

            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@Firstname", firstname);
            cmd.Parameters.AddWithValue("@Lastname", lastname);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Get_Table(string tableName)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM [{tableName}]";

            Connection.Open();

            SqlCommand cmd = new SqlCommand(query, Connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }// gets the whole table
        public DataTable Get_Questions(int userID)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM [Questions] INNER JOIN [QuestionIntroduction] ON [QuestionIntroduction].IntroductionID = [Questions].IntroductionID AND [QuestionIntroduction].UserID = @UserID" ;

            Connection.Open();

            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@UserID", userID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }// get all the question where userID matches

        public void Update_UserPassword(string password, int userID)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Users] SET [Password] = @Passowrd WHERE [ID]=@ID", Connection);

            cmd.Parameters.AddWithValue("@Passowrd", password);
            cmd.Parameters.AddWithValue("@ID", userID);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }// update Password Coloum where user id matches
        public void Update_UserPoints(User user)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Users] SET [Points] = @Points, [Marks Earned] = @MarksEarned, [Total Marks] = @TotalMarks WHERE [ID]=@ID", Connection);

            cmd.Parameters.AddWithValue("@Points", user.Points);
            cmd.Parameters.AddWithValue("@MarksEarned", user.MarksGot);
            cmd.Parameters.AddWithValue("@TotalMarks", user.TotoalMarks);
            cmd.Parameters.AddWithValue("@ID", user.ID);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }// update user points

        public void Add_User(string firstname, string lastname, string username, string password)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Users] ([Firstname],[Lastname],[Username],[Password])  VALUES(@Firstname, @Lastname, @Username, @Password)", Connection);

            cmd.Parameters.AddWithValue("@Firstname", firstname);
            cmd.Parameters.AddWithValue("@Lastname", lastname);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }// add new user
        public void InsertInto_Report(int userId, int points, string fromWhere, DateTime date)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO [Report] ([User ID],[Points],[From Where],[Date]) VALUES (@UserID, @Points, @Where, @Date)", Connection);

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Points", points);
            cmd.Parameters.AddWithValue("@Where", fromWhere);
            cmd.Parameters.AddWithValue("@Date", date);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }//add new report
        public int InsertInto_QuestionIntro(int userId, string intro)
        {
            int addedID;

            SqlCommand cmd = new SqlCommand("INSERT INTO [QuestionIntroduction] ([Introduction],[UserID]) output INSERTED.IntroductionID VALUES(@Introduction, @UserId)", Connection);

            cmd.Parameters.AddWithValue("@Introduction", intro);
            cmd.Parameters.AddWithValue("@UserId", userId);

            Connection.Open();
            addedID = (int)cmd.ExecuteScalar();
            Connection.Close();

            return addedID;
        }//add new Question Introduction
        public void Insert_Question(int introId, int marks, string question)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Questions] ([IntroductionID],[Question],[Marks]) VALUES(@IntroID, @Question, @Marks)", Connection);

            cmd.Parameters.AddWithValue("@IntroID", introId);
            cmd.Parameters.AddWithValue("@Question", question);
            cmd.Parameters.AddWithValue("@Marks", marks);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }// Insert the Questions

        public void Delete_User(int userID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Users] WHERE [ID]=" + userID, Connection);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }// Delete the user
        public void Delete_Report(int userId)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Report] WHERE [User ID] = @UserId", Connection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void Delete_Question(int introductionID)
        {
            // Delete the Introduction
            SqlCommand cmd = new SqlCommand("DELETE FROM [QuestionIntroduction] WHERE IntroductionID = @IntroductionID;", Connection);
            cmd.Parameters.AddWithValue("@IntroductionID", introductionID);

            Connection.Open();
            cmd.ExecuteScalar();

            // delete the question where user ID matches
            cmd = new SqlCommand("DELETE FROM [Questions] WHERE IntroductionID = @IntroductionID;", Connection);
            cmd.Parameters.AddWithValue("@IntroductionID", introductionID);

            cmd.ExecuteScalar();
            Connection.Close();
        }// Delete Question
        public void Delete_QuestionByUserID(int userID)
        {
            Connection.Open();

            //get all the IntroductionID where user ID matches
            SqlCommand cmd = new SqlCommand("SELECT IntroductionID FROM [QuestionIntroduction] WHERE UserID = @UserID", Connection);
            cmd.Parameters.AddWithValue("@UserID", userID);

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable Ids = new DataTable();
            sqlData.Fill(Ids);

            //deletes all Introductions where User ID matches
            cmd = new SqlCommand("DELETE FROM [QuestionIntroduction] WHERE UserID = @UserID;", Connection);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.ExecuteScalar();
           
            sqlData.Dispose();

            cmd = new SqlCommand("DELETE FROM [Questions] WHERE IntroductionID = @IntroductionID;", Connection);

            // to delete all the question where introductionID matches from the IDs got previouly
            for (int x = 0; x < Ids.Rows.Count; x++)
            {
                cmd.Parameters.AddWithValue($"@IntroductionID", (int)Ids.Rows[x][0]);
                cmd.ExecuteScalar();
            }
            
            Connection.Close();
        }

    }
}