using DAL_FIT_MIS_SeminarskiRad_3086;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT_MIS_SeminarskiRad_3086
{
    public partial class frm_PretragaKandidata : Form
    {
        DS_PretragaKandidata dSPretragaKandidata = new DS_PretragaKandidata();
        DataView dv_Original_Kursevi= new DataView();
        public frm_PretragaKandidata()
        {
            InitializeComponent();
        }
        private void frm_PretragaKandidata_Load(object sender, EventArgs e)
        {
            DA_Training.getTrainingType(dSPretragaKandidata.TrainingType);
            DA_Training.getTrainingSubType(dSPretragaKandidata.TrainingSubType, 0);
            DA_Training.getKurseviViewbyKurs(dSPretragaKandidata.view_Kursevi, 0);

            dv_Original_Kursevi.Table = dSPretragaKandidata.view_Kursevi.DefaultView.ToTable();

            DS_PretragaKandidata.TrainingTypeRow TT_Row=dSPretragaKandidata.TrainingType.NewTrainingTypeRow();
            TT_Row.TrainingTypeID = 0;
            TT_Row.Name = "Naziv kursa";
            dSPretragaKandidata.TrainingType.Rows.InsertAt(TT_Row, 0);

            cB_Kurs.DisplayMember = "Name";
            cB_Kurs.ValueMember = "TrainingTypeID";
            cB_Kurs.DataSource = dSPretragaKandidata.TrainingType;

            cB_Modul.DisplayMember = "Name";
            cB_Modul.ValueMember = "TrainingSubTypeID";
            cB_Modul.DataSource = dSPretragaKandidata.TrainingSubType;

            dGV_Kursevi.AutoGenerateColumns = false;
            dGV_Kursevi.DataSource = dSPretragaKandidata.view_Kursevi;
        }

        private void cB_Kurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cB_Kurs.SelectedIndex!=0)
            {
                int TrainingTypeID = (int)cB_Kurs.SelectedValue;
               
                    DA_Training.getKurseviViewbyKurs(dSPretragaKandidata.view_Kursevi, TrainingTypeID);
                    dGV_Kursevi.AutoGenerateColumns = false;
                    dGV_Kursevi.DataSource = dSPretragaKandidata.view_Kursevi;

                    DA_Training.getTrainingSubType(dSPretragaKandidata.TrainingSubType, TrainingTypeID);
                    cB_Modul.Enabled = true;

                    cB_Modul.SelectedIndex = 0;                             
            }
            else
            {
                dGV_Kursevi.DataSource = null;
                cB_Modul.Enabled = false;
                DA_Training.getTrainingSubType(dSPretragaKandidata.TrainingSubType,0);
                cB_Modul.DataSource = dSPretragaKandidata.TrainingSubType;
            }

            dGV_Grupe.DataSource = null;
            dGV_Kandidati.DataSource = null;
        }

        private void cB_Modul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_Modul.SelectedIndex != 0 && cB_Modul.SelectedValue!=null)
            {

            int TrainingTypeID = (int)cB_Kurs.SelectedValue,TrainingSubTypeID=(int)cB_Modul.SelectedValue;
           
                DA_Training.getKurseviViewbyKursAndModul(dSPretragaKandidata.view_Kursevi, TrainingTypeID, TrainingSubTypeID);
            
            }   
                dGV_Grupe.DataSource = null;
                dGV_Kandidati.DataSource = null;        
        }

        private void dGV_Kursevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int TrainingID = (int)dGV_Kursevi.SelectedRows[0].Cells["TrainingID"].Value;
            DA_Grupe.getTrainingGroup_by_Training(dSPretragaKandidata.TrainingGroup, TrainingID);

            dGV_Grupe.AutoGenerateColumns = false;
            dGV_Grupe.DataSource = dSPretragaKandidata.TrainingGroup;

            dGV_Kandidati.DataSource = null;
        }

        private void dGV_Grupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int trainingGroupID = (int)dGV_Grupe.SelectedRows[0].Cells["TrainingGroupID"].Value;
            DA_Kandidati.getParticipants_by_TrainingGroup(dSPretragaKandidata.view_Kandidat, trainingGroupID);

            dGV_Kandidati.AutoGenerateColumns = false;
            dGV_Kandidati.DataSource = dSPretragaKandidata.view_Kandidat;
        }

        private void btn_PodaciOKandidatu_Click(object sender, EventArgs e)
        {
            Reports.frm_oKandidatu oKandidatu = new Reports.frm_oKandidatu((int)dGV_Kandidati.SelectedRows[0].Cells["PersonID"].Value);
            oKandidatu.Show();
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            cB_Kurs.SelectedIndex = 0;
            dGV_Kursevi.DataSource = dv_Original_Kursevi;
        }

   

       
    }
}
