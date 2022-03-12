namespace ProcedureGridUI
{
    partial class Statistici_Departamente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistici_Departamente));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView_dept = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataInceput = new System.Windows.Forms.DateTimePicker();
            this.dataSfarsit = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip_Dept = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reincarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dept)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_dept
            // 
            this.dataGridView_dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_dept.Location = new System.Drawing.Point(0, 101);
            this.dataGridView_dept.Name = "dataGridView_dept";
            this.dataGridView_dept.RowHeadersWidth = 51;
            this.dataGridView_dept.RowTemplate.Height = 24;
            this.dataGridView_dept.Size = new System.Drawing.Size(291, 368);
            this.dataGridView_dept.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dataSfarsit);
            this.panel1.Controls.Add(this.dataInceput);
            this.panel1.Controls.Add(this.dataGridView_dept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 469);
            this.panel1.TabIndex = 1;
            // 
            // dataInceput
            // 
            this.dataInceput.Location = new System.Drawing.Point(3, 25);
            this.dataInceput.Name = "dataInceput";
            this.dataInceput.Size = new System.Drawing.Size(116, 22);
            this.dataInceput.TabIndex = 1;
            // 
            // dataSfarsit
            // 
            this.dataSfarsit.Location = new System.Drawing.Point(140, 25);
            this.dataSfarsit.Name = "dataSfarsit";
            this.dataSfarsit.Size = new System.Drawing.Size(137, 22);
            this.dataSfarsit.TabIndex = 2;
            // 
            // contextMenuStrip_Dept
            // 
            this.contextMenuStrip_Dept.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Dept.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reincarcaToolStripMenuItem});
            this.contextMenuStrip_Dept.Name = "contextMenuStrip_Dept";
            this.contextMenuStrip_Dept.Size = new System.Drawing.Size(143, 28);
            // 
            // reincarcaToolStripMenuItem
            // 
            this.reincarcaToolStripMenuItem.Name = "reincarcaToolStripMenuItem";
            this.reincarcaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.reincarcaToolStripMenuItem.Text = "Reincarca";
            this.reincarcaToolStripMenuItem.Click += new System.EventHandler(this.reincarcaToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chart1.BackImage = "C:\\Users\\Mohamad\\Desktop\\Facultate\\BD2\\background_departament.jpg";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(346, 25);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(796, 401);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Statistici_Departamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1167, 469);
            this.ContextMenuStrip = this.contextMenuStrip_Dept;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Statistici_Departamente";
            this.Text = "Statistici_Departamente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dept)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip_Dept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dataSfarsit;
        private System.Windows.Forms.DateTimePicker dataInceput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Dept;
        private System.Windows.Forms.ToolStripMenuItem reincarcaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}