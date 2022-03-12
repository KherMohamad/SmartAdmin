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
    public partial class Statistici_Departamente : Form
    {
        public Statistici_Departamente()
        {
            InitializeComponent();
        }

        private void reincarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DBAccess db = new DBAccess();
            List <InfoDepartament> infoDepartamente = db.GetInfoDepartamente(dataInceput.Text, dataSfarsit.Text);
            dataGridView_dept.DataSource = infoDepartamente;
            chart1.DataSource = infoDepartamente;
            if (chart1.Series.IndexOf("venit") != -1)
            {
                chart1.Series.Add("venit").YValueMembers = "venit";
            }
            chart1.Series["venit"].XValueType = ChartValueType.Int32;
            chart1.Series["venit"].YValueType = ChartValueType.Int32;
            chart1.DataBind();


        }
    }
}
