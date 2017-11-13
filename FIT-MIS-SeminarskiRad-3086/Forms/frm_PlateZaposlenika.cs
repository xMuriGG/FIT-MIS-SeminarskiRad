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
    public partial class frm_PlateZaposlenika : Form
    {
        DS_Zaposlenici ds_Zaposlenici = new DS_Zaposlenici();
        public frm_PlateZaposlenika()
        {
            InitializeComponent();
        }

        private void frm_PlateZaposlenika_Load(object sender, EventArgs e)
        {
            DA_Zaposlenici.getZaposlenike(ds_Zaposlenici.view_Zaposlenici);

            dGV_Zaposlenici.AutoGenerateColumns = false;
            dGV_Zaposlenici.DataSource = ds_Zaposlenici.view_Zaposlenici;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_fName.TextLength>0 || txt_lName.TextLength>0)
            {
                DA_Zaposlenici.getZaposlenike_by_fNameAndlName(ds_Zaposlenici.view_Zaposlenici, txt_fName.Text, txt_lName.Text);
                dGV_Zaposlenici.DataSource = ds_Zaposlenici.view_Zaposlenici;
            }
        }
        
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            frm_PlateZaposlenika_Load(null, null);

            dGV_Plate.DataSource = null;
            ds_Zaposlenici.EmployeePayHistory.Clear();
            enable_buttons(false);
            dTP_From.Value = new DateTime(2000, 1, 1);
            dTP_To.Value = DateTime.Today;

            txt_fName.Clear();
            txt_lName.Clear();
        }

        private void dGV_Zaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DS_Zaposlenici.EmployeePayHistoryDataTable dt_EmployeePayHistory = ds_Zaposlenici.EmployeePayHistory;
            DA_Zaposlenici.getPlate_by_EmployeeID(dt_EmployeePayHistory, (int)dGV_Zaposlenici.SelectedRows[0].Cells["EmployeeID"].Value);

            dGV_Plate.AutoGenerateColumns = false;
            dGV_Plate.DataSource = dt_EmployeePayHistory;
            if(dt_EmployeePayHistory.Count>1)
            {
                enable_buttons(true);
            }
            else
            {
                enable_buttons(true);
            }
           
        }

        private void btn_DateSearch_Click(object sender, EventArgs e)
        {
            DA_Zaposlenici.getPlate_by_EmployeeIDAndDate(ds_Zaposlenici.EmployeePayHistory, (int)dGV_Zaposlenici.SelectedRows[0].Cells["EmployeeID"].Value, dTP_From.Value, dTP_To.Value);
            dGV_Plate.DataSource = ds_Zaposlenici.EmployeePayHistory;
        }

        private void btn_DateClear_Click(object sender, EventArgs e)
        {
            DS_Zaposlenici.EmployeePayHistoryDataTable dt_EmployeePayHistory = ds_Zaposlenici.EmployeePayHistory;

            DA_Zaposlenici.getPlate_by_EmployeeID(dt_EmployeePayHistory, (int)dGV_Zaposlenici.SelectedRows[0].Cells["EmployeeID"].Value);
            dGV_Plate.DataSource = dt_EmployeePayHistory;
                     
            dTP_From.Value = new DateTime(2000, 1, 1);
            dTP_To.Value = DateTime.Today;
        }

       public void enable_buttons(bool enable)
        {
            dTP_From.Enabled = enable;
            dTP_To.Enabled = enable;
            btn_DateSearch.Enabled = enable;
            btn_DateClear.Enabled = enable;
            dGV_Plate.Enabled = enable;

        }

       private void btn_report_Click(object sender, EventArgs e)
       {
           int at = dGV_Zaposlenici.SelectedRows[0].Index;

           Reports.frm_plateZaposlenika isplate = new Reports.frm_plateZaposlenika(ds_Zaposlenici.view_Zaposlenici.ElementAt(at), ds_Zaposlenici.EmployeePayHistory,dTP_From.Value,dTP_To.Value);
           isplate.Show();
       }
    }
}
