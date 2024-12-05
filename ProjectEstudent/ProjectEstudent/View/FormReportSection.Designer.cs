namespace ProjectEstudent.View
{
    partial class FormReportSection
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
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.ColumnCodeSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantityStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCodeAsignature = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodeSection,
            this.ColumnQuantityStudents});
            this.dataGridViewReport.Location = new System.Drawing.Point(276, 98);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(235, 288);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // ColumnCodeSection
            // 
            this.ColumnCodeSection.HeaderText = "Code Section";
            this.ColumnCodeSection.Name = "ColumnCodeSection";
            // 
            // ColumnQuantityStudents
            // 
            this.ColumnQuantityStudents.HeaderText = "Quantity of students";
            this.ColumnQuantityStudents.Name = "ColumnQuantityStudents";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(276, 44);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 21);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxCodeAsignature
            // 
            this.textBoxCodeAsignature.Location = new System.Drawing.Point(396, 44);
            this.textBoxCodeAsignature.Name = "textBoxCodeAsignature";
            this.textBoxCodeAsignature.Size = new System.Drawing.Size(115, 20);
            this.textBoxCodeAsignature.TabIndex = 5;
            this.textBoxCodeAsignature.Text = "Code Asignature";
            // 
            // FormReportSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxCodeAsignature);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "FormReportSection";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantityStudents;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCodeAsignature;
    }
}