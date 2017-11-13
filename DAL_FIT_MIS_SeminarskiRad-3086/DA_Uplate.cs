using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class DA_Uplate
    {
        public static void getUplate(DS_Uplate.view_UplateDataTable dt_Uplate)
        {
            dt_Uplate.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                DS_UplateTableAdapters.view_UplateTableAdapter adapter = new DS_UplateTableAdapters.view_UplateTableAdapter();
                adapter.Fill(dt_Uplate);
            }
        }
        public static void getUplate_by_NameAndDate(DS_Uplate.view_UplateDataTable dt_Uplate,string fName,string lName,DateTime from,DateTime to)
        {
            dt_Uplate.Clear();
            using (SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_Uplate_by_NameAndDate", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fName;
                com.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lName;
                com.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = from;
                com.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = to;

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_Uplate);
            }
        }
        public static void getUplate_by_NameAndDateAndTrainingType(DS_Uplate.view_UplateDataTable dt_Uplate, string fName, string lName, DateTime from, DateTime to,int TrainingTypeID)
        {
            dt_Uplate.Clear();
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_Uplate_by_NameAndDateAndTrainingType", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = fName;
                com.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lName;
                com.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = from;
                com.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = to;
                com.Parameters.Add("@TrainingTypeID", SqlDbType.Int).Value = TrainingTypeID;

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_Uplate);
            }
        }

        public static void getUplate_by_Year_statistika(DS_Uplate.statistika_Uplate_MatrixDataTable dt_Uplate, int From = 2000, int To = 0)
        {
            if (To ==0)
                To = DateTime.Today.Year;

            dt_Uplate.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_statistikaUplate_matrix", cn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("From", From);
                com.Parameters.AddWithValue("To", To);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_Uplate);
            }
        }
    }
}
