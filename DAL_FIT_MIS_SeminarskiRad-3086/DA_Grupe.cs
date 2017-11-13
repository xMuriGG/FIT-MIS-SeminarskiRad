using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
    public class DA_Grupe
    {
        public static void getTrainingGroup_by_Training(DS_PretragaKandidata.TrainingGroupDataTable dt_TrainingGropu,int TrainingID)
        {
            dt_TrainingGropu.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_getTrainingGroup_by_Training", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TrainingID", TrainingID);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt_TrainingGropu);
            }
        }
        public static void getPohadjanjeKurseve_by_ParticipantID(DS_GrupeKursevi.PohadjaniKurseviDataTable dtKursevi,int participantID)
        {
            dtKursevi.Clear();
            using(SqlConnection cn=Connection.GetOpenConnection())
            {
                SqlCommand com = new SqlCommand("usp_PohadjaniKursevi_by_ParticipantID", cn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ParticipantID", participantID);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dtKursevi);
            }
        }
    }
}
