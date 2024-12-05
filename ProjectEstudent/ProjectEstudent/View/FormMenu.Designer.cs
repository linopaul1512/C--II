namespace ProjectEstudent.View
{
    partial class FormMenu
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
            this.buttonReport = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFormReportAsignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonReport.Location = new System.Drawing.Point(459, 188);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(114, 43);
            this.buttonReport.TabIndex = 49;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(291, 76);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(183, 44);
            this.labelWelcome.TabIndex = 48;
            this.labelWelcome.Text = "Welcome";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.Location = new System.Drawing.Point(317, 279);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 43);
            this.buttonClose.TabIndex = 47;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFormReportAsignature
            // 
            this.buttonFormReportAsignature.BackColor = System.Drawing.Color.Orange;
            this.buttonFormReportAsignature.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFormReportAsignature.Location = new System.Drawing.Point(172, 188);
            this.buttonFormReportAsignature.Name = "buttonFormReportAsignature";
            this.buttonFormReportAsignature.Size = new System.Drawing.Size(114, 43);
            this.buttonFormReportAsignature.TabIndex = 46;
            this.buttonFormReportAsignature.Text = "Report Asignature";
            this.buttonFormReportAsignature.UseVisualStyleBackColor = false;
            this.buttonFormReportAsignature.Click += new System.EventHandler(this.buttonFormReportAsignature_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFormReportAsignature);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFormReportAsignature;
    }
}