namespace ProjectEstudent.View
{
    partial class FormReportAsignatures
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
            this.dataGridViewAsignature = new System.Windows.Forms.DataGridView();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAsignature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCodeStudent = new System.Windows.Forms.TextBox();
            this.labelstuasig = new System.Windows.Forms.Label();
            this.buttoncalculate = new System.Windows.Forms.Button();
            this.textBoxasigstudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignature)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAsignature
            // 
            this.dataGridViewAsignature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnAsignature});
            this.dataGridViewAsignature.Location = new System.Drawing.Point(240, 84);
            this.dataGridViewAsignature.Name = "dataGridViewAsignature";
            this.dataGridViewAsignature.Size = new System.Drawing.Size(241, 254);
            this.dataGridViewAsignature.TabIndex = 0;
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Code Asignature";
            this.ColumnCode.Name = "ColumnCode";
            // 
            // ColumnAsignature
            // 
            this.ColumnAsignature.HeaderText = "Asignature";
            this.ColumnAsignature.Name = "ColumnAsignature";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(240, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 21);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCodeStudent
            // 
            this.textBoxCodeStudent.Location = new System.Drawing.Point(366, 42);
            this.textBoxCodeStudent.Name = "textBoxCodeStudent";
            this.textBoxCodeStudent.Size = new System.Drawing.Size(115, 20);
            this.textBoxCodeStudent.TabIndex = 3;
            this.textBoxCodeStudent.Text = "ID student";
            // 
            // labelstuasig
            // 
            this.labelstuasig.AutoSize = true;
            this.labelstuasig.Location = new System.Drawing.Point(39, 357);
            this.labelstuasig.Name = "labelstuasig";
            this.labelstuasig.Size = new System.Drawing.Size(134, 13);
            this.labelstuasig.TabIndex = 5;
            this.labelstuasig.Text = "Subject with more students";
            // 
            // buttoncalculate
            // 
            this.buttoncalculate.Location = new System.Drawing.Point(208, 353);
            this.buttoncalculate.Name = "buttoncalculate";
            this.buttoncalculate.Size = new System.Drawing.Size(98, 21);
            this.buttoncalculate.TabIndex = 6;
            this.buttoncalculate.Text = "Calculate";
            this.buttoncalculate.UseVisualStyleBackColor = true;
            this.buttoncalculate.Click += new System.EventHandler(this.buttoncalculate_Click);
            // 
            // textBoxasigstudent
            // 
            this.textBoxasigstudent.Location = new System.Drawing.Point(42, 384);
            this.textBoxasigstudent.Name = "textBoxasigstudent";
            this.textBoxasigstudent.Size = new System.Drawing.Size(151, 20);
            this.textBoxasigstudent.TabIndex = 7;
            // 
            // FormReportAsignatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxasigstudent);
            this.Controls.Add(this.buttoncalculate);
            this.Controls.Add(this.labelstuasig);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxCodeStudent);
            this.Controls.Add(this.dataGridViewAsignature);
            this.Name = "FormReportAsignatures";
            this.Text = "FormReportAsignatures";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAsignature;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCodeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsignature;
        private System.Windows.Forms.Label labelstuasig;
        private System.Windows.Forms.Button buttoncalculate;
        private System.Windows.Forms.TextBox textBoxasigstudent;
    }
}