namespace ProcedureGridUI
{
    partial class Boredom_Button
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boredom_Button));
            this.roundButton1 = new ProcedureGridUI.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(189, 37);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(373, 354);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "PRESS";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // Boredom_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton1);
            this.Name = "Boredom_Button";
            this.Text = "Boredom_Button";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton roundButton1;
    }
}