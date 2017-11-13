using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_FIT_MIS_SeminarskiRad_3086
{
   public class DA_Training
    {
       public static void getTrainingType(DS_PretragaKandidata.TrainingTypeDataTable dt_TT)
       {
           dt_TT.Clear();
           using(SqlConnection cn= Connection.GetOpenConnection())
           {
               DS_PretragaKandidataTableAdapters.TrainingTypeTableAdapter adapter = new DS_PretragaKandidataTableAdapters.TrainingTypeTableAdapter();
               adapter.Fill(dt_TT);
           }
       }
       public static void getTrainingSubType(DS_PretragaKandidata.TrainingSubTypeDataTable dt_TST,int TrainingTypeID)
       {
           dt_TST.Clear();
           DS_PretragaKandidata.TrainingSubTypeRow TST_Row = dt_TST.NewTrainingSubTypeRow();
           TST_Row.TrainingSubTypeID = 0;
           TST_Row.Name = "Naziv modula";
           dt_TST.Rows.InsertAt(TST_Row, 0);

           using(SqlConnection cn=Connection.GetOpenConnection())
           {
               SqlCommand com = new SqlCommand("Select * from TrainingSubType where TrainingTypeID=" + TrainingTypeID.ToString(),cn);
               SqlDataAdapter adapter = new SqlDataAdapter(com);
               adapter.Fill(dt_TST);
           }
       }
       public static void getKurseviViewbyKurs(DS_PretragaKandidata.view_KurseviDataTable dt_kursevi,int TrainingTypeID=0)
       {
           dt_kursevi.Clear();
           using(SqlConnection cn=Connection.GetOpenConnection())
           {
               string TTID=TrainingTypeID.ToString();
               SqlCommand com = new SqlCommand();
               com.Connection=cn;
               if(TrainingTypeID!=0)
                   com.CommandText="select * from view_Kursevi where TrainingTypeID="+TTID;
               else
                   com.CommandText = "select * from view_Kursevi";

               SqlDataAdapter adapter = new SqlDataAdapter(com);
               adapter.Fill(dt_kursevi);
           }
       }
       public static void getKurseviViewbyKursAndModul(DS_PretragaKandidata.view_KurseviDataTable dt_kursevi, int TrainingTypeID = 0,int TrainingSubTypeID=0)
       {
           dt_kursevi.Clear();
           using (SqlConnection cn = Connection.GetOpenConnection())
           {
               SqlCommand com = new SqlCommand("usp_getKursevi", cn);
               com.CommandType = System.Data.CommandType.StoredProcedure;

               com.Parameters.AddWithValue("@TrainingTypeID", TrainingTypeID);
               com.Parameters.AddWithValue("@TrainingSubTypeID", TrainingSubTypeID);

               SqlDataAdapter adapter = new SqlDataAdapter(com);
               adapter.Fill(dt_kursevi);
           }
       }

    }
}
