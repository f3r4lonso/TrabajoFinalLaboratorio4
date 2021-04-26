using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionABM
{
    public static class sqlConection
    {
        public static DataTable GetTable(string qry) {

            //string constring = @"Data Source=FERPC\MORRYBD;Initial Catalog=OrdenesDB;Persist Security Info=True;User ID=FerPC";
            //  string constring = @"Data Source=DESKTOP-SD5V702\SQLEXPRES;Initial Catalog=OrdenesDB;Persist Security Info=True;User ID=sa;Password=fer123";
            string constring = @"Data Source=DESKTOP-0IICMIO\SQLEXPRESS;Initial Catalog=OrdenesDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }

        }

        public static void ExercuteQry(string qry)
        {
            //string constring = @"Data Source=FERPC\MORRYBD;Initial Catalog=OrdenesDB;Persist Security Info=True;User ID=FerPC";
            string constring = @"Data Source=DESKTOP-0IICMIO\SQLEXPRESS;Initial Catalog=OrdenesDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

            // string constring = @"Data Source=MORRYNB-PC\MSSQLSERVER1;Initial Catalog=OrdenesDB;Persist Security Info=True;User ID=sa;Password=fer123";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    con.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlCommand query = con.CreateCommand();

                    query.CommandType = CommandType.Text;

                    query.CommandText = qry;

                    query.ExecuteNonQuery();

                }
            }
        }
    }
}
