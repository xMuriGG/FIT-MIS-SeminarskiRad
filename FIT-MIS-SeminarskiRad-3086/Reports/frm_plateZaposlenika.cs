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
    public partial class frm_plateZaposlenika : Form
    {
        DS_Zaposlenici.view_ZaposleniciRow row;
        DS_Zaposlenici.EmployeePayHistoryDataTable dt_payHistory;
        DateTime dateFrom, dateTo;

        public frm_plateZaposlenika(DS_Zaposlenici.view_ZaposleniciRow row,DS_Zaposlenici.EmployeePayHistoryDataTable dt_payHistory,DateTime dateFrom,DateTime dateTo)
        {
            this.row = row;
            this.dt_payHistory = dt_payHistory;

            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

            InitializeComponent();
        }

        private void frm_plateZaposlenika_Load(object sender, EventArgs e)
        {         
            view_ZaposleniciRowBindingSource.DataSource = row;
            EmployeePayHistoryDataTableBindingSource.DataSource = dt_payHistory;

            ReportDataSource rds1 = new ReportDataSource("DS_Zaposlenik", view_ZaposleniciRowBindingSource);
            ReportDataSource rds2 = new ReportDataSource("DS_Isplate", EmployeePayHistoryDataTableBindingSource);

            reportViewer1.LocalReport.DataSources.Add(rds1);
            reportViewer1.LocalReport.DataSources.Add(rds2);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("dateFrom", dateFrom.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("dateTo", dateTo.ToShortDateString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
