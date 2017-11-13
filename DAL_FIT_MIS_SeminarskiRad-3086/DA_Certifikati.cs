using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class DA_Certifikati
    {
        public static void get_Certificates(DS_Certifikati.view_CertifikatiDataTable dtCertifikati)
        {
            dtCertifikati.Clear();
            using (SqlConnection cn =Connection.GetOpenConnection())
            {
                DS_CertifikatiTableAdapters.view_CertifikatiTableAdapter adapter = new DS_CertifikatiTableAdapters.view_CertifikatiTableAdapter();
                adapter.Fill(dtCertifikati);
            }
        }

        public static void get_Certificates_with_filter(DS_Certifikati.view_CertifikatiDataTable dtCertifikati,string fName,string lName,int trainingTypeID)
        {
            dtCertifikati.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_Certifikati_filter", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@fName", fName);
                com.Parameters.AddWithValue("@lName", lName);
                com.Parameters.AddWithValue("@trainingTypeID", trainingTypeID);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dtCertifikati);
            }
        }
        public static void get_Certificates_by_name(DS_Certifikati.view_CertifikatiDataTable dtCertifikati, string fName, string lName)
        {
            dtCertifikati.Clear();
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_Certifikati_by_name", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@fName", fName);
                com.Parameters.AddWithValue("@lName", lName);
                
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dtCertifikati);
            }
        }
    }
}
