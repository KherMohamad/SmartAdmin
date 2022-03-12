using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcedureGridUI
{
    public partial class FormularInregistrareAngajati : Form
    {
        public FormularInregistrareAngajati()
        {
            InitializeComponent();
        }

        

        private void butonInserareP_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            db.InsertPlata(Convert.ToInt32(idAngajat.Text), Convert.ToInt32(idTipPlata.Text), Convert.ToInt32(valoarePlata.Text),
                Convert.ToInt32(idValuta.Text), dataPlata_edit.Text);
            idAngajat.Clear();
            idTipPlata.Clear();
            valoarePlata.Clear();
            idValuta.Clear();
            dataPlata_edit.Refresh();
        }

        private void buttonInserareA_Click_1(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            db.InsertAngajat(nume.Text, prenume.Text, dataNasteriiDateEdit.Text, isManager.Text, Departament.Text);
            nume.Clear();
            prenume.Clear();
            dataNasteriiDateEdit.Refresh();
            isManager.Clear();
            Departament.Clear();
        }
    }
}
