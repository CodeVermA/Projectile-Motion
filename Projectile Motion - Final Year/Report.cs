using System;
using System.Data;
using System.Collections.Generic;

namespace Projectile_Motion___Final_Year
{
    static class Report
    {
        static public List<string> Load(int userID)// gets all the report where user id matches and load it in list box
        {
            List<string> report = new List<string>();
            DataTable dataTable = new Database().Get_Table("Report");

            foreach (DataRow row in dataTable.Rows)
            {
                if ((int)(row["User ID"]) == userID)
                {
                    DateTime date = Convert.ToDateTime(row["Date"]);

                    report.Add($"Earned {row["Points"].ToString()} points from {row["From Where"].ToString()} on {date.ToShortDateString()}");
                }
            }

            return report;
        }
    }
}
