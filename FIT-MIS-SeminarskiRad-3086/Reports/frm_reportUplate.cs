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
    public partial class frm_reportUplate : Form
    {
        DS_Uplate.view_UplateDataTable dt_uplate;
        string fName, lName, kurs,from, to;

        public frm_reportUplate(DS_Uplate.view_UplateDataTable dt_uplate,string fName,string lName,string from,string to,string kurs)
        {
            this.dt_uplate = dt_uplate;
            this.fName = fName;
            this.lName = lName;
            this.from = from;
            this.to = to;
            this.kurs = kurs;
            InitializeComponent();
        }

        private void frm_reportUplate_Load(object sender, EventArgs e)
        {
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            BindingSource bs=new BindingSource();
            DS_UplateBindingSource.DataSource=dt_uplate;
            ReportDataSource rds = new ReportDataSource("DS_Uplate", bs);
            //reportViewer.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_ListaUplata.rdlc";
            reportViewer.LocalReport.DataSources.Add(rds);
            
            reportViewer.LocalReport.SetParameters(new ReportParameter("fName", fName));
            reportViewer.LocalReport.SetParameters(new ReportParameter("lName", lName));
            reportViewer.LocalReport.SetParameters(new ReportParameter("from", from));
            reportViewer.LocalReport.SetParameters(new ReportParameter("to", to));
            reportViewer.LocalReport.SetParameters(new ReportParameter("kurs", kurs));
            this.reportViewer.RefreshReport();
        }
    }
}
