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
    public partial class frm_oKandidatu : Form
    {
        int personID;
        public frm_oKandidatu(int personID)
        {
            this.personID = personID;
            InitializeComponent();
        }

        private void frm_oKandidatu_Load(object sender, EventArgs e)
        {

            DS_PretragaKandidata.view_KandidatDataTable dt_Kandidat = new DS_PretragaKandidata.view_KandidatDataTable();
            DS_PretragaKandidata.view_BrojTelefonaDataTable dt_BrojeviTelefona=new DS_PretragaKandidata.view_BrojTelefonaDataTable();
            DS_PretragaKandidata.AddressDataTable dt_Adrese=new DS_PretragaKandidata.AddressDataTable();
            DS_GrupeKursevi.PohadjaniKurseviDataTable dt_Kursevi = new DS_GrupeKursevi.PohadjaniKurseviDataTable();

            DA_Kandidati.getKandidat_by_personID(dt_Kandidat, personID); 
            DA_Kandidati.getBrojeveTelefona_by_personID(dt_BrojeviTelefona, personID);
            DA_Kandidati.getAdrese_by_personID(dt_Adrese,personID);
            DA_Grupe.getPohadjanjeKurseve_by_ParticipantID(dt_Kursevi, personID);

            DS_PretragaKandidata.view_KandidatRow row = dt_Kandidat.ElementAt(0);

            BindingSource bs1 = new BindingSource();
            BindingSource bs2 = new BindingSource();
            BindingSource bs3 = new BindingSource();
            BindingSource bs4 = new BindingSource();

            bs1.DataSource = row;
            bs2.DataSource = dt_BrojeviTelefona;
            bs3.DataSource = dt_Adrese;
            bs4.DataSource = dt_Kursevi;

            ReportDataSource rds1 = new ReportDataSource("DSPodaciOKandidatu", bs1);
            ReportDataSource rds2 = new ReportDataSource("DSBrojTelefona", bs2);
            ReportDataSource rds3 = new ReportDataSource("DSAdresa", bs3);
            ReportDataSource rds4 = new ReportDataSource("DSPohadjaniKursevi", bs4);

            reportViewer.LocalReport.ReportEmbeddedResource = "FIT_MIS_SeminarskiRad_3086.Reports.report_oKandidatu.rdlc";
            reportViewer.LocalReport.DataSources.Add(rds1);
            reportViewer.LocalReport.DataSources.Add(rds2);
            reportViewer.LocalReport.DataSources.Add(rds3);
            reportViewer.LocalReport.DataSources.Add(rds4);

            this.reportViewer.RefreshReport();
        }
    }
}
