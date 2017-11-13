using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT_MIS_SeminarskiRad_3086.Forms;
namespace FIT_MIS_SeminarskiRad_3086
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PretragaKandidata pretraga = new frm_PretragaKandidata();
            pretraga.WindowState = FormWindowState.Maximized;
            pretraga.MdiParent = this;
            pretraga.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Uplate uplate = new frm_Uplate();
            uplate.WindowState = FormWindowState.Maximized;
            uplate.MdiParent = this;
            uplate.Show();
        }

        private void plateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PlateZaposlenika plate = new frm_PlateZaposlenika();
            plate.WindowState = FormWindowState.Maximized;
            plate.MdiParent = this;
            plate.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_PretragaCertifikata certifikati = new frm_PretragaCertifikata();
            certifikati.WindowState = FormWindowState.Maximized;
            certifikati.MdiParent = this;
            certifikati.Show();
            
        }

        private void uplateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports.frm_StatistikaPoslovanja stat=new Reports.frm_StatistikaPoslovanja();
            stat.WindowState = FormWindowState.Maximized;
            stat.MdiParent = this;
            stat.Show();
        }
    }
}
