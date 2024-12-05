namespace WindowsFormsApp_XavierSchool
{
    partial class FormProjectList
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
            this.dataGridViewProjectList = new System.Windows.Forms.DataGridView();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaxStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjectList
            // 
            this.dataGridViewProjectList.AllowUserToAddRows = false;
            this.dataGridViewProjectList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnName,
            this.ColumnMaxStudents,
            this.ColumnSD,
            this.ColumnCD,
            this.ColumnStatus});
            this.dataGridViewProjectList.Location = new System.Drawing.Point(267, 126);
            this.dataGridViewProjectList.Name = "dataGridViewProjectList";
            this.dataGridViewProjectList.Size = new System.Drawing.Size(636, 500);
            this.dataGridViewProjectList.TabIndex = 0;
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Code";
            this.ColumnCode.Name = "ColumnCode";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnMaxStudents
            // 
            this.ColumnMaxStudents.HeaderText = "Max Students";
            this.ColumnMaxStudents.Name = "ColumnMaxStudents";
            // 
            // ColumnSD
            // 
            this.ColumnSD.HeaderText = "Starting Date";
            this.ColumnSD.Name = "ColumnSD";
            // 
            // ColumnCD
            // 
            this.ColumnCD.HeaderText = "Closing Date";
            this.ColumnCD.Name = "ColumnCD";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(390, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(343, 19);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search";
            // 
            // FormProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_XavierSchool.Properties.Resources._1366_2000;
            this.ClientSize = new System.Drawing.Size(1166, 700);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewProjectList);
            this.Name = "FormProjectList";
            this.Text = "Project\'s List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjectList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaxStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
    }
}