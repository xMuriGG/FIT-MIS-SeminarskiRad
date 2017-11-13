using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class Connection
    {
        public static SqlConnection GetOpenConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.MIS_CentarZaEdukacijuConnectionString);
            cn.Open();
            return cn;
        }
    }
}
