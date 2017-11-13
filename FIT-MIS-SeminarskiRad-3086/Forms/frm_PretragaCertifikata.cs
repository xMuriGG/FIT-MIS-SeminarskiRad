using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_FIT_MIS_SeminarskiRad_3086;

namespace FIT_MIS_SeminarskiRad_3086.Forms
{
    public partial class frm_PretragaCertifikata : Form
    {
        DS_Certifikati dsCertifikati = new DS_Certifikati();
        DS_PretragaKandidata.TrainingTypeDataTable dt_TT=new DS_PretragaKandidata.TrainingTypeDataTable();

        public frm_PretragaCertifikata()
        {
            InitializeComponent();
        }

        private void frm_PretragaCertifikata_Load(object sender, EventArgs e)
        {
            DA_Certifikati.get_Certificates(dsCertifikati.view_Certifikati);

            DA_Training.getTrainingType(dt_TT);
            DS_PretragaKandidata.TrainingTypeRow row = dt_TT.NewTrainingTypeRow();
            row.TrainingTypeID = 0;
            row.Name = "Naziv kursa";
            dt_TT.Rows.InsertAt(row, 0);

            dGV_Certifikati.AutoGenerateColumns = false;
            dGV_Certifikati.DataSource = dsCertifikati.view_Certifikati;

            cB_Kurs.DisplayMember = "Name";
            cB_Kurs.ValueMember = "TrainingTypeID";
            cB_Kurs.DataSource = dt_TT;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            int trainingTypeID=(int)cB_Kurs.SelectedValue;
            if (trainingTypeID != 0)
            {
                DA_Certifikati.get_Certificates_with_filter(dsCertifikati.view_Certifikati, txt_fName.Text, txt_lName.Text, trainingTypeID);
                dGV_Certifikati.DataSource = dsCertifikati.view_Certifikati;
            }
            else if (txt_fName.TextLength > 0 || txt_lName.TextLength > 0)
                DA_Certifikati.get_Certificates_by_name(dsCertifikati.view_Certifikati, txt_fName.Text, txt_lName.Text);
            else
                DA_Certifikati.get_Certificates(dsCertifikati.view_Certifikati);
        }
        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            cB_Kurs.SelectedIndex=0;
            txt_fName.Clear();
            txt_lName.Clear();
            DA_Certifikati.get_Certificates(dsCertifikati.view_Certifikati);
        }

        private void dGV_Certifikati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGV_Certifikati.Columns[e.ColumnIndex] is  DataGridViewImageColumn && e.RowIndex !=-1)
            {
                Reports.frm_printanjeCertifikata print = new Reports.frm_printanjeCertifikata(dsCertifikati.view_Certifikati.ElementAt(e.RowIndex));
                print.Show();
            }
        }

        private void cB_Kurs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_filter_Click(null, null);
        }



    }
}
