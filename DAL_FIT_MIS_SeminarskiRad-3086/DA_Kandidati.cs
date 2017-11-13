using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class DA_Kandidati
    {
        public static void getParticipants_by_TrainingGroup(DS_PretragaKandidata.view_KandidatDataTable dt_Kandidati,int TrainingGroupID)
        {
            dt_Kandidati.Clear();
            using (SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_Kandidati_u_Grupi", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TrainingGroupID", TrainingGroupID);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_Kandidati);
            }
        }

        public static void getKandidat_by_personID(DS_PretragaKandidata.view_KandidatDataTable dt_Kandidati,int personID)
        {
            dt_Kandidati.Clear();
            using (SqlConnection cn = Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("select * from view_Kandidati where PersonID="+ personID.ToString(), cn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_Kandidati);
            }

        }

        public static void getBrojeveTelefona_by_personID(DS_PretragaKandidata.view_BrojTelefonaDataTable dtBrojeviTelefona,int personID)
        {
            dtBrojeviTelefona.Clear();

            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("select * from view_BrojTelefona where PersonID=" + personID.ToString(), cn);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dtBrojeviTelefona);
            }
        }
        public static void getAdrese_by_personID(DS_PretragaKandidata.AddressDataTable dtAdrese,int personID)
        {
            dtAdrese.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("select * from Address where PersonID=" + personID.ToString(), cn);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dtAdrese);
            }
        }
    }
}
