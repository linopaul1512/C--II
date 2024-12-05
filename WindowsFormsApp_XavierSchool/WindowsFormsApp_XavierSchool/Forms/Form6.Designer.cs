namespace WindowsFormsApp_XavierSchool
{
    partial class FormReportStudents
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
            this.richTextBoxStudentsReport = new System.Windows.Forms.RichTextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxStudentsReport
            // 
            this.richTextBoxStudentsReport.BackColor = System.Drawing.Color.DarkRed;
            this.richTextBoxStudentsReport.Enabled = false;
            this.richTextBoxStudentsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStudentsReport.Location = new System.Drawing.Point(54, 347);
            this.richTextBoxStudentsReport.Name = "richTextBoxStudentsReport";
            this.richTextBoxStudentsReport.Size = new System.Drawing.Size(180, 115);
            this.richTextBoxStudentsReport.TabIndex = 0;
            this.richTextBoxStudentsReport.Text = "";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(12, 289);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(273, 42);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total Students";
            // 
            // FormReportStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_XavierSchool.Properties.Resources.FEEFMS43PRCNHF4KKAQYWKAWZ4;
            this.ClientSize = new System.Drawing.Size(290, 474);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.richTextBoxStudentsReport);
            this.Name = "FormReportStudents";
            this.Text = "Report Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStudentsReport;
        private System.Windows.Forms.Label labelTotal;
    }
}