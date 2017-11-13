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

namespace FIT_MIS_SeminarskiRad_3086
{
    public partial class frm_Uplate : Form
    {
        DS_Uplate ds_uplate = new DS_Uplate();
        DS_Uplate.view_UplateDataTable customList;
        public frm_Uplate()
        {
            InitializeComponent();
        }

        private void frm_Uplate_Load(object sender, EventArgs e)
        {
            DA_Uplate.getUplate(ds_uplate.view_Uplate);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = ds_uplate.view_Uplate;
           
            using(DS_PretragaKandidata ds_Kurs=new DS_PretragaKandidata()) //Punjenje comboboxa
            {
                DA_Training.getTrainingType(ds_Kurs.TrainingType);
                DS_PretragaKandidata.TrainingTypeRow TTRow= ds_Kurs.TrainingType.NewTrainingTypeRow();
                TTRow.Name = "Izaberi kurs";
                TTRow.TrainingTypeID = 0;
                ds_Kurs.TrainingType.Rows.InsertAt(TTRow, 0);

                cB_Kursevi.ValueMember = "TrainingTypeID";
                cB_Kursevi.DisplayMember = "Name";
                cB_Kursevi.DataSource = ds_Kurs.TrainingType;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cB_Kursevi.SelectedIndex<1)
            {
                if (txt_fName.TextLength > 0 || txt_lName.TextLength > 0 || (dTP_From.Value!=new DateTime(2000,1,1) || dTP_To.Value !=DateTime.Today))
                {
                    DA_Uplate.getUplate_by_NameAndDate(ds_uplate.view_Uplate, txt_fName.Text, txt_lName.Text, dTP_From.Value, dTP_To.Value);
                    dataGridView.DataSource = ds_uplate.view_Uplate;
                } 
                else
                {
                    DA_Uplate.getUplate(ds_uplate.view_Uplate);
                    dataGridView.DataSource = ds_uplate.view_Uplate; 
                }            
            }
            else
            {
                DA_Uplate.getUplate_by_NameAndDateAndTrainingType(ds_uplate.view_Uplate, txt_fName.Text, txt_lName.Text, dTP_From.Value, dTP_To.Value,(int)cB_Kursevi.SelectedValue);
                dataGridView.DataSource = ds_uplate.view_Uplate;
            }
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            txt_fName.Clear();
            txt_lName.Clear();
            dTP_From.Value = new DateTime(2000,1,1);
            dTP_To.Value = DateTime.Now;
            cB_Kursevi.SelectedIndex = 0;
            btn_search_Click(null, null);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Reports.frm_reportUplate frm_uplateReport = new Reports.frm_reportUplate(ds_uplate.view_Uplate,
                txt_fName.Text,txt_lName.Text,dTP_From.Value.ToShortDateString(),dTP_To.Value.ToShortDateString(),cB_Kursevi.Text);
            frm_uplateReport.Show();        
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex!=-1)
            {
                int personID = (int)dataGridView.Rows[e.RowIndex].Cells["PersonID"].Value;

                Reports.frm_oKandidatu oKandidatu = new Reports.frm_oKandidatu(personID);             
                oKandidatu.Show();       
            }
        }

        private void btn_newCustomList_Click(object sender, EventArgs e)
        {
            customList = new DS_Uplate.view_UplateDataTable();
            gB_customList.Visible = true;
        }

        private void btn_addToCustomList_Click(object sender, EventArgs e)
        {
            int items = ds_uplate.view_Uplate.Count;
            for (int i = 0; i < items; i++)
            {
                DS_Uplate.view_UplateRow r = (DS_Uplate.view_UplateRow)ds_uplate.view_Uplate.Rows[i];
                customList.Addview_UplateRow(r.TrainingID, r.Kurs, r.TrainingSubTypeID, r.Name, r.TrainingID, r.PaymentID, r.ParticipantID, r.Amount
                    , r.Notes, r.PaymentState, r.CheckGiven, r.PaymentDate, r.FirstName, r.LastName, r.Email);
            }
            lbl_items.Text = (Convert.ToInt32(lbl_items.Text) + items).ToString();
        }

        private void btn_reviewCustomList_Click(object sender, EventArgs e)
        {
            Reports.frm_reportUplate frm_uplateReport = new Reports.frm_reportUplate(customList,"", "", "No filter", "No filter", "Izaberi kurs");
            frm_uplateReport.Show();
        }

        private void btn_removeCustomList_Click(object sender, EventArgs e)
        {
            customList.Clear();
            lbl_items.Text = "0";
            gB_customList.Visible = false;
        }

        private void cB_Kursevi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_search_Click(null, null);
        }
    }
}
