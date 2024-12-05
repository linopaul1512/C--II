namespace WindowsFormsApp_Pets.Views
{
    partial class FormGift
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
            this.groupBoxGift = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateGift = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDescriptionGift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdGift = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxGift.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGift
            // 
            this.groupBoxGift.Controls.Add(this.dateTimePickerDateGift);
            this.groupBoxGift.Controls.Add(this.labelDate);
            this.groupBoxGift.Controls.Add(this.textBoxDescriptionGift);
            this.groupBoxGift.Controls.Add(this.label1);
            this.groupBoxGift.Controls.Add(this.textBoxIdGift);
            this.groupBoxGift.Controls.Add(this.labelId);
            this.groupBoxGift.Location = new System.Drawing.Point(9, 2);
            this.groupBoxGift.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGift.Name = "groupBoxGift";
            this.groupBoxGift.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGift.Size = new System.Drawing.Size(313, 136);
            this.groupBoxGift.TabIndex = 0;
            this.groupBoxGift.TabStop = false;
            this.groupBoxGift.Text = "Madrigal Family";
            // 
            // dateTimePickerDateGift
            // 
            this.dateTimePickerDateGift.Location = new System.Drawing.Point(85, 73);
            this.dateTimePickerDateGift.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateGift.Name = "dateTimePickerDateGift";
            this.dateTimePickerDateGift.Size = new System.Drawing.Size(205, 20);
            this.dateTimePickerDateGift.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(51, 73);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date:";
            // 
            // textBoxDescriptionGift
            // 
            this.textBoxDescriptionGift.Location = new System.Drawing.Point(85, 50);
            this.textBoxDescriptionGift.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescriptionGift.Name = "textBoxDescriptionGift";
            this.textBoxDescriptionGift.Size = new System.Drawing.Size(76, 20);
            this.textBoxDescriptionGift.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description:";
            // 
            // textBoxIdGift
            // 
            this.textBoxIdGift.Location = new System.Drawing.Point(85, 28);
            this.textBoxIdGift.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdGift.Name = "textBoxIdGift";
            this.textBoxIdGift.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdGift.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(64, 32);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonSearch);
            this.groupBoxActions.Controls.Add(this.buttonModify);
            this.groupBoxActions.Controls.Add(this.buttonDelete);
            this.groupBoxActions.Controls.Add(this.buttonClean);
            this.groupBoxActions.Controls.Add(this.buttonInclude);
            this.groupBoxActions.Location = new System.Drawing.Point(338, 10);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxActions.Size = new System.Drawing.Size(89, 137);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(15, 44);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(56, 19);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(15, 67);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(56, 19);
            this.buttonClean.TabIndex = 1;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(15, 20);
            this.buttonInclude.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(56, 19);
            this.buttonInclude.TabIndex = 0;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(15, 90);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(56, 19);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(15, 113);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(56, 19);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 158);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxGift);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGift";
            this.Text = "Gift";
            this.groupBoxGift.ResumeLayout(false);
            this.groupBoxGift.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxGift;
        public System.Windows.Forms.DateTimePicker dateTimePickerDateGift;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.TextBox textBoxDescriptionGift;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxIdGift;
        public System.Windows.Forms.Label labelId;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.GroupBox groupBoxActions;
        public System.Windows.Forms.Button buttonClean;
        public System.Windows.Forms.Button buttonInclude;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.Button buttonModify;
    }
}