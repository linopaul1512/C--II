namespace WindowsFormsApp_XavierSchool
{
    partial class FormProjectManager
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMaxStudents = new System.Windows.Forms.TextBox();
            this.dateTimePickerSD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCD = new System.Windows.Forms.DateTimePicker();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMaxStudents = new System.Windows.Forms.Label();
            this.labelSD = new System.Windows.Forms.Label();
            this.labelCD = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.groupBoxProjectData = new System.Windows.Forms.GroupBox();
            this.checkBoxFinish = new System.Windows.Forms.CheckBox();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.groupBoxProjectData.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(86, 40);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(86, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMaxStudents
            // 
            this.textBoxMaxStudents.Location = new System.Drawing.Point(86, 92);
            this.textBoxMaxStudents.Name = "textBoxMaxStudents";
            this.textBoxMaxStudents.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxStudents.TabIndex = 2;
            // 
            // dateTimePickerSD
            // 
            this.dateTimePickerSD.Location = new System.Drawing.Point(86, 118);
            this.dateTimePickerSD.Name = "dateTimePickerSD";
            this.dateTimePickerSD.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerSD.TabIndex = 3;
            // 
            // dateTimePickerCD
            // 
            this.dateTimePickerCD.Location = new System.Drawing.Point(86, 144);
            this.dateTimePickerCD.Name = "dateTimePickerCD";
            this.dateTimePickerCD.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerCD.TabIndex = 4;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCode.Location = new System.Drawing.Point(48, 43);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Code";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(48, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelMaxStudents
            // 
            this.labelMaxStudents.AutoSize = true;
            this.labelMaxStudents.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxStudents.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMaxStudents.Location = new System.Drawing.Point(8, 95);
            this.labelMaxStudents.Name = "labelMaxStudents";
            this.labelMaxStudents.Size = new System.Drawing.Size(72, 13);
            this.labelMaxStudents.TabIndex = 7;
            this.labelMaxStudents.Text = "Max Students";
            // 
            // labelSD
            // 
            this.labelSD.AutoSize = true;
            this.labelSD.BackColor = System.Drawing.Color.Transparent;
            this.labelSD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSD.Location = new System.Drawing.Point(11, 121);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(69, 13);
            this.labelSD.TabIndex = 8;
            this.labelSD.Text = "Starting Date";
            // 
            // labelCD
            // 
            this.labelCD.AutoSize = true;
            this.labelCD.BackColor = System.Drawing.Color.Transparent;
            this.labelCD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCD.Location = new System.Drawing.Point(13, 147);
            this.labelCD.Name = "labelCD";
            this.labelCD.Size = new System.Drawing.Size(67, 13);
            this.labelCD.TabIndex = 9;
            this.labelCD.Text = "Closing Date";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonSave.Location = new System.Drawing.Point(192, 40);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonList.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonList.Location = new System.Drawing.Point(192, 69);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 11;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click_1);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClean.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonClean.Location = new System.Drawing.Point(192, 98);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 12;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModify.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonModify.Location = new System.Drawing.Point(192, 127);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 13;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonSearch.Location = new System.Drawing.Point(192, 156);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.Black;
            this.buttonFinish.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonFinish.Location = new System.Drawing.Point(192, 185);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 15;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // groupBoxProjectData
            // 
            this.groupBoxProjectData.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProjectData.Controls.Add(this.checkBoxFinish);
            this.groupBoxProjectData.Controls.Add(this.checkBoxEnable);
            this.groupBoxProjectData.Controls.Add(this.textBoxMaxStudents);
            this.groupBoxProjectData.Controls.Add(this.buttonFinish);
            this.groupBoxProjectData.Controls.Add(this.textBoxCode);
            this.groupBoxProjectData.Controls.Add(this.buttonSearch);
            this.groupBoxProjectData.Controls.Add(this.textBoxName);
            this.groupBoxProjectData.Controls.Add(this.buttonModify);
            this.groupBoxProjectData.Controls.Add(this.dateTimePickerSD);
            this.groupBoxProjectData.Controls.Add(this.buttonClean);
            this.groupBoxProjectData.Controls.Add(this.dateTimePickerCD);
            this.groupBoxProjectData.Controls.Add(this.buttonList);
            this.groupBoxProjectData.Controls.Add(this.labelCode);
            this.groupBoxProjectData.Controls.Add(this.buttonSave);
            this.groupBoxProjectData.Controls.Add(this.labelName);
            this.groupBoxProjectData.Controls.Add(this.labelCD);
            this.groupBoxProjectData.Controls.Add(this.labelMaxStudents);
            this.groupBoxProjectData.Controls.Add(this.labelSD);
            this.groupBoxProjectData.Location = new System.Drawing.Point(143, 109);
            this.groupBoxProjectData.Name = "groupBoxProjectData";
            this.groupBoxProjectData.Size = new System.Drawing.Size(325, 280);
            this.groupBoxProjectData.TabIndex = 16;
            this.groupBoxProjectData.TabStop = false;
            this.groupBoxProjectData.Text = "Project\'s Data";
            // 
            // checkBoxFinish
            // 
            this.checkBoxFinish.AutoSize = true;
            this.checkBoxFinish.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFinish.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxFinish.Location = new System.Drawing.Point(34, 193);
            this.checkBoxFinish.Name = "checkBoxFinish";
            this.checkBoxFinish.Size = new System.Drawing.Size(99, 17);
            this.checkBoxFinish.TabIndex = 17;
            this.checkBoxFinish.Text = "Finish A Project";
            this.checkBoxFinish.UseVisualStyleBackColor = false;
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEnable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxEnable.Location = new System.Drawing.Point(34, 170);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(152, 17);
            this.checkBoxEnable.TabIndex = 16;
            this.checkBoxEnable.Text = "Enable Search And Modify";
            this.checkBoxEnable.UseVisualStyleBackColor = false;
            this.checkBoxEnable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_XavierSchool.Properties.Resources.X_Men_Clasificacion_de_todos_los_villanos_de_las_peliculas_de;
            this.ClientSize = new System.Drawing.Size(645, 516);
            this.Controls.Add(this.groupBoxProjectData);
            this.Name = "FormProjectManager";
            this.Text = "Project\'s Manager";
            this.groupBoxProjectData.ResumeLayout(false);
            this.groupBoxProjectData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMaxStudents;
        private System.Windows.Forms.DateTimePicker dateTimePickerSD;
        private System.Windows.Forms.DateTimePicker dateTimePickerCD;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMaxStudents;
        private System.Windows.Forms.Label labelSD;
        private System.Windows.Forms.Label labelCD;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.GroupBox groupBoxProjectData;
        private System.Windows.Forms.CheckBox checkBoxFinish;
        private System.Windows.Forms.CheckBox checkBoxEnable;
    }
}