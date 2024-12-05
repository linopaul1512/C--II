namespace ProjectBrainstormRental.View
{
    partial class FormReport
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
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodeRental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberofHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrainEnchancers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnCodeRental,
            this.ColumnNumberofHour,
            this.ColumnBrainEnchancers,
            this.ColumnTotal});
            this.dataGridViewReport.Location = new System.Drawing.Point(58, 115);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(637, 223);
            this.dataGridViewReport.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnCodeRental
            // 
            this.ColumnCodeRental.HeaderText = "Code Rental";
            this.ColumnCodeRental.Name = "ColumnCodeRental";
            // 
            // ColumnNumberofHour
            // 
            this.ColumnNumberofHour.HeaderText = "Number of Hour";
            this.ColumnNumberofHour.Name = "ColumnNumberofHour";
            // 
            // ColumnBrainEnchancers
            // 
            this.ColumnBrainEnchancers.HeaderText = "Brain Enhancers";
            this.ColumnBrainEnchancers.Name = "ColumnBrainEnchancers";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "FormReport";
            this.Text = "FormReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeRental;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberofHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrainEnchancers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
    }
}