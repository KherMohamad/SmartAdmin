namespace ProcedureGridUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IDAngajat = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.dataInceputLabel = new System.Windows.Forms.Label();
            this.dataFinalLabel = new System.Windows.Forms.Label();
            this.butonCautare = new System.Windows.Forms.Button();
            this.dataInceput_edit = new System.Windows.Forms.DateTimePicker();
            this.dataFinal_edit = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridProcedura = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaAngajatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcedura)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDAngajat
            // 
            this.IDAngajat.Location = new System.Drawing.Point(97, 21);
            this.IDAngajat.Name = "IDAngajat";
            this.IDAngajat.Size = new System.Drawing.Size(77, 22);
            this.IDAngajat.TabIndex = 2;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Navy;
            this.IDLabel.Location = new System.Drawing.Point(12, 21);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(73, 17);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID Angajat";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // dataInceputLabel
            // 
            this.dataInceputLabel.AutoSize = true;
            this.dataInceputLabel.BackColor = System.Drawing.Color.Navy;
            this.dataInceputLabel.Location = new System.Drawing.Point(3, 64);
            this.dataInceputLabel.Name = "dataInceputLabel";
            this.dataInceputLabel.Size = new System.Drawing.Size(88, 17);
            this.dataInceputLabel.TabIndex = 5;
            this.dataInceputLabel.Text = "Data Inceput";
            // 
            // dataFinalLabel
            // 
            this.dataFinalLabel.AutoSize = true;
            this.dataFinalLabel.BackColor = System.Drawing.Color.Navy;
            this.dataFinalLabel.Location = new System.Drawing.Point(326, 66);
            this.dataFinalLabel.Name = "dataFinalLabel";
            this.dataFinalLabel.Size = new System.Drawing.Size(72, 17);
            this.dataFinalLabel.TabIndex = 6;
            this.dataFinalLabel.Text = "Data Final";
            // 
            // butonCautare
            // 
            this.butonCautare.BackColor = System.Drawing.Color.Gold;
            this.butonCautare.Location = new System.Drawing.Point(30, 105);
            this.butonCautare.Name = "butonCautare";
            this.butonCautare.Size = new System.Drawing.Size(125, 56);
            this.butonCautare.TabIndex = 7;
            this.butonCautare.Text = "cauta";
            this.butonCautare.UseVisualStyleBackColor = false;
            this.butonCautare.Click += new System.EventHandler(this.butonCautare_Click);
            // 
            // dataInceput_edit
            // 
            this.dataInceput_edit.Location = new System.Drawing.Point(97, 61);
            this.dataInceput_edit.Name = "dataInceput_edit";
            this.dataInceput_edit.Size = new System.Drawing.Size(203, 22);
            this.dataInceput_edit.TabIndex = 8;
            // 
            // dataFinal_edit
            // 
            this.dataFinal_edit.Location = new System.Drawing.Point(419, 64);
            this.dataFinal_edit.Name = "dataFinal_edit";
            this.dataFinal_edit.Size = new System.Drawing.Size(200, 22);
            this.dataFinal_edit.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.GridProcedura);
            this.panel1.Location = new System.Drawing.Point(30, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 302);
            this.panel1.TabIndex = 10;
            // 
            // GridProcedura
            // 
            this.GridProcedura.AllowUserToOrderColumns = true;
            this.GridProcedura.BackgroundColor = System.Drawing.Color.White;
            this.GridProcedura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridProcedura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcedura.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridProcedura.Location = new System.Drawing.Point(0, 0);
            this.GridProcedura.Name = "GridProcedura";
            this.GridProcedura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProcedura.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProcedura.RowHeadersWidth = 51;
            this.GridProcedura.RowTemplate.Height = 24;
            this.GridProcedura.Size = new System.Drawing.Size(876, 279);
            this.GridProcedura.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaAngajatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 28);
            // 
            // adaugaAngajatToolStripMenuItem
            // 
            this.adaugaAngajatToolStripMenuItem.Name = "adaugaAngajatToolStripMenuItem";
            this.adaugaAngajatToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.adaugaAngajatToolStripMenuItem.Text = "Adauga angajat";
            this.adaugaAngajatToolStripMenuItem.Click += new System.EventHandler(this.adaugaAngajatToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 500);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataFinal_edit);
            this.Controls.Add(this.dataInceput_edit);
            this.Controls.Add(this.butonCautare);
            this.Controls.Add(this.dataFinalLabel);
            this.Controls.Add(this.dataInceputLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDAngajat);
            this.Name = "Dashboard";
            this.Text = "ProcedureForm";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProcedura)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDAngajat;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label dataInceputLabel;
        private System.Windows.Forms.Label dataFinalLabel;
        private System.Windows.Forms.Button butonCautare;
        private System.Windows.Forms.DateTimePicker dataInceput_edit;
        private System.Windows.Forms.DateTimePicker dataFinal_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridProcedura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaAngajatToolStripMenuItem;
    }
}

