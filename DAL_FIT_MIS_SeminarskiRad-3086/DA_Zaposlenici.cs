using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class DA_Zaposlenici
    {
        public static void getZaposlenike(DS_Zaposlenici.view_ZaposleniciDataTable dt_Zaposlenici)
        {
            using (SqlConnection cn=Connection.GetOpenConnection())
            {
                DS_ZaposleniciTableAdapters.view_ZaposleniciTableAdapter adapter = new DS_ZaposleniciTableAdapters.view_ZaposleniciTableAdapter();
                adapter.Fill(dt_Zaposlenici);
            }
        }
        public static void getZaposlenike_by_fNameAndlName(DS_Zaposlenici.view_ZaposleniciDataTable dt_Zaposlenici,string fName,string lName)
        {
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                dt_Zaposlenici.Clear();
                SqlCommand com = new SqlCommand("usp_Zaposlenici_by_fNameAndlName", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@FirstName", fName);
                com.Parameters.AddWithValue("@LastName", lName);

                SqlDataAdapter adapter = new SqlDataAdapter(com);

                adapter.Fill(dt_Zaposlenici);
            }
        }
        public static void getPlate_by_EmployeeID(DS_Zaposlenici.EmployeePayHistoryDataTable dt_Plate,int employeeID)
        {
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                dt_Plate.Clear();
                SqlCommand com = new SqlCommand("usp_getPlate_by_Employee", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@EmployeeID", employeeID);
                

                SqlDataAdapter adapter = new SqlDataAdapter(com);

                adapter.Fill(dt_Plate);
            }
        }
        public static void getPlate_by_EmployeeIDAndDate(DS_Zaposlenici.EmployeePayHistoryDataTable dt_Plate, int employeeID,DateTime from,DateTime to)
        {
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                dt_Plate.Clear();
                SqlCommand com = new SqlCommand("usp_getPlate_by_EmployeeAndDate", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@EmployeeID", employeeID);
                com.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = from;
                com.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = to;

                SqlDataAdapter adapter = new SqlDataAdapter(com);

                adapter.Fill(dt_Plate);
            }
        }
    }
}
