using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcedureGridUI
{
    public partial class Dashboard : Form
    {
        List<InfoAngajat> infoAngajati;
        public Dashboard()
        {
            InitializeComponent();
           

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GridProcedura.DataSource = infoAngajati;

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void DataInceput_TextChanged(object sender, EventArgs e)
        {

        }

        private void butonCautare_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            int idParam;
            if (IDAngajat.Text == "")
            {
                idParam = -1;

            } else
            {
                idParam = Convert.ToInt32(IDAngajat.Text);
            }
            infoAngajati = db.GetInfoAngajati(idParam, dataInceput_edit.Text, dataFinal_edit.Text);
            GridProcedura.DataSource = infoAngajati;
            
        }

        private void adaugaAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularInregistrareAngajati form = new FormularInregistrareAngajati();
            form.Show();
        }
    }
}
