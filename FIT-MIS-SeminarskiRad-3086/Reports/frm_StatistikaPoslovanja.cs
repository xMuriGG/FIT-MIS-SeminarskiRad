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
using Microsoft.Reporting.WinForms;

namespace FIT_MIS_SeminarskiRad_3086.Reports
{
    public partial class frm_StatistikaPoslovanja : Form
    {
        string yearMonthTab,yearDayTab,monthDayTab;
        DS_Uplate.statistika_Uplate_MatrixDataTable dt_Uplate=new DS_Uplate.statistika_Uplate_MatrixDataTable();
        DataTable dt_izvorniPodaci;
        public frm_StatistikaPoslovanja()
        {
            InitializeComponent();
        }

        private void frm_StatistikaPoslovanja_Load(object sender, EventArgs e)
        {
            DA_Uplate.getUplate_by_Year_statistika(dt_Uplate, 2000, DateTime.Today.Year);
            dt_izvorniPodaci = dt_Uplate.DefaultView.ToTable();            //tabela za filtriranje(jednom dobavljamo podatke iz baze)

            //YEAR TAB
            statistika_Uplate_MatrixDataTableBindingSource.DataSource = dt_Uplate;
            ReportDataSource rds = new ReportDataSource("DS_statistika_Uplate", statistika_Uplate_MatrixDataTableBindingSource);
            rV_Uplate_matrix.LocalReport.DataSources.Add(rds);
            rV_Uplate_Chart.LocalReport.DataSources.Add(rds);
            this.rV_Uplate_matrix.RefreshReport();
            this.rV_Uplate_Chart.RefreshReport();

            DataTable dt = dt_Uplate.DefaultView.ToTable(true, "Year"); // Distinct values;
            cB_From.DataSource = dt;
            cB_From.DisplayMember = "Year";
            cB_From.ValueMember = "Year";

            DataView dv = new DataView(dt);   // Pravim DataView da bih mogao sortirati tabelu
            dv.Sort = "Year DESC";            // Sortiranje           
            cB_To.DataSource = dv.ToTable();
            cB_To.DisplayMember = "Year";
            cB_To.ValueMember = "Year"; 

            //MONTH TAB                   
            cb_monthYears.DataSource = dv.ToTable();
            cb_monthYears.DisplayMember = "Year";
            cb_monthYears.ValueMember = "Year";
           
            yearMonthTab=Convert.ToInt32(cb_monthYears.SelectedValue).ToString();
            ReportDataSource rdsMonth = new ReportDataSource("DS_UplateMonths", DS_UplateMonth_BS);
            rv_MonthTab.LocalReport.DataSources.Add(rdsMonth);
            rv_MonthTab.LocalReport.SetParameters(new ReportParameter("SingleYear", yearMonthTab));

            cb_monthYears_SelectionChangeCommitted(null, null);
            
            //DAY TAB

            cB_Year_DayTab.DataSource = dv;
            cB_Year_DayTab.DisplayMember = "Year";
            cB_Year_DayTab.ValueMember = "Year";

            DataTable dtDay = dt_Uplate.DefaultView.ToTable(true, "Month");
            DataView dvDay = new DataView(dtDay);
            dvDay.Sort = "Month ASC";
            cB_Month_DayTab.DataSource = dvDay;
            cB_Month_DayTab.DisplayMember = "Month";
            cB_Month_DayTab.ValueMember = "Month";

            ReportDataSource rdsDay = new ReportDataSource("DS_Uplate_Day", DS_UplateBindingSource);
            rV_DayTab.LocalReport.DataSources.Add(rdsDay);
            yearDayTab = Convert.ToString(cB_Year_DayTab.SelectedValue);
            monthDayTab = Convert.ToString(cB_Month_DayTab.SelectedValue);
            rV_DayTab.LocalReport.SetParameters(new ReportParameter("SingleMonth", monthDayTab));
            rV_DayTab.LocalReport.SetParameters(new ReportParameter("SingleYear", yearDayTab));

            cB_Year_DayTab_SelectionChangeCommitted(null, null);
           
        }

        private void cB_To_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(cB_From.SelectedValue), to = Convert.ToInt32(cB_To.SelectedValue);

            if (from > to)
            {
                cB_From.SelectedIndex = 0;
                cB_To.SelectedIndex = 0;
                from = Convert.ToInt32(cB_From.SelectedValue);
                to = Convert.ToInt32(cB_To.SelectedValue);
            }

            DA_Uplate.getUplate_by_Year_statistika(dt_Uplate, from, to);
            this.rV_Uplate_matrix.RefreshReport();
            this.rV_Uplate_Chart.RefreshReport();
        }

        private void cB_From_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cB_To_SelectionChangeCommitted(null, null);      
        }

        private void cB_matrix_CheckedChanged(object sender, EventArgs e)
        {
            if(cB_matrix.Checked)
            {
                splitContainer.Panel1Collapsed = false;
            }
            else
            {
                splitContainer.Panel1Collapsed = true;
            }
        }

        private void cB_chart_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_chart.Checked)
            {
                splitContainer.Panel2Collapsed = false;
            }
            else
            {
                splitContainer.Panel2Collapsed = true;
            }
        }

        private void cb_monthYears_SelectionChangeCommitted(object sender, EventArgs e)
        {
            yearMonthTab=Convert.ToInt32(cb_monthYears.SelectedValue).ToString();
            DataView dv = new DataView(dt_izvorniPodaci);
            dv.RowFilter = "Year =" + yearMonthTab;
            rv_MonthTab.LocalReport.SetParameters(new ReportParameter("SingleYear", yearMonthTab));
            DS_UplateMonth_BS.DataSource = dv;

            this.rv_MonthTab.RefreshReport();
        }

        private void cB_Year_DayTab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            yearDayTab = Convert.ToString(cB_Year_DayTab.SelectedValue);
            monthDayTab = Convert.ToString(cB_Month_DayTab.SelectedValue);

            DataView dv = new DataView(dt_izvorniPodaci);
            dv.RowFilter = "Year =" + yearDayTab + "and Month =" + monthDayTab;
            DS_UplateBindingSource.DataSource = dv;
            rV_DayTab.LocalReport.SetParameters(new ReportParameter("SingleMonth", monthDayTab));
            rV_DayTab.LocalReport.SetParameters(new ReportParameter("SingleYear", yearDayTab));
            
            this.rV_DayTab.RefreshReport();         
        }

        private void cB_Month_DayTab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cB_Year_DayTab_SelectionChangeCommitted(null, null);
        }
   
    }
}
