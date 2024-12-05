namespace WindowsFormsApp_XavierSchool
{
    partial class FormStudentManagers
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
            this.groupBoxStudentsData = new System.Windows.Forms.GroupBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonConsult = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAdmissionDate = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAD = new System.Windows.Forms.DateTimePicker();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.groupBoxStudentsData.SuspendLayout();
            this.groupBoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentsData
            // 
            this.groupBoxStudentsData.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStudentsData.Controls.Add(this.checkBoxEnabled);
            this.groupBoxStudentsData.Controls.Add(this.buttonClean);
            this.groupBoxStudentsData.Controls.Add(this.buttonConsult);
            this.groupBoxStudentsData.Controls.Add(this.buttonList);
            this.groupBoxStudentsData.Controls.Add(this.buttonSearch);
            this.groupBoxStudentsData.Controls.Add(this.buttonModify);
            this.groupBoxStudentsData.Controls.Add(this.buttonSave);
            this.groupBoxStudentsData.Controls.Add(this.labelAdmissionDate);
            this.groupBoxStudentsData.Controls.Add(this.labelBirthDate);
            this.groupBoxStudentsData.Controls.Add(this.labelAddress);
            this.groupBoxStudentsData.Controls.Add(this.labelPhoneNumber);
            this.groupBoxStudentsData.Controls.Add(this.labelID);
            this.groupBoxStudentsData.Controls.Add(this.labelLastName);
            this.groupBoxStudentsData.Controls.Add(this.labelName);
            this.groupBoxStudentsData.Controls.Add(this.labelCode);
            this.groupBoxStudentsData.Controls.Add(this.dateTimePickerBD);
            this.groupBoxStudentsData.Controls.Add(this.groupBoxSex);
            this.groupBoxStudentsData.Controls.Add(this.dateTimePickerAD);
            this.groupBoxStudentsData.Controls.Add(this.textBoxID);
            this.groupBoxStudentsData.Controls.Add(this.textBoxAddress);
            this.groupBoxStudentsData.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxStudentsData.Controls.Add(this.textBoxLastName);
            this.groupBoxStudentsData.Controls.Add(this.textBoxName);
            this.groupBoxStudentsData.Controls.Add(this.textBoxCode);
            this.groupBoxStudentsData.Location = new System.Drawing.Point(34, 24);
            this.groupBoxStudentsData.Name = "groupBoxStudentsData";
            this.groupBoxStudentsData.Size = new System.Drawing.Size(403, 245);
            this.groupBoxStudentsData.TabIndex = 0;
            this.groupBoxStudentsData.TabStop = false;
            this.groupBoxStudentsData.Text = "Student\'s Data";
            this.groupBoxStudentsData.Enter += new System.EventHandler(this.groupBoxStudentsData_Enter);
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(220, 159);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(151, 17);
            this.checkBoxEnabled.TabIndex = 23;
            this.checkBoxEnabled.Text = "Enable Search and Modify";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(301, 188);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 22;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonConsult
            // 
            this.buttonConsult.Location = new System.Drawing.Point(301, 159);
            this.buttonConsult.Name = "buttonConsult";
            this.buttonConsult.Size = new System.Drawing.Size(75, 23);
            this.buttonConsult.TabIndex = 21;
            this.buttonConsult.Text = "Consult";
            this.buttonConsult.UseVisualStyleBackColor = true;
            this.buttonConsult.Click += new System.EventHandler(this.buttonConsult_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(301, 130);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 20;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(220, 130);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(220, 101);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 18;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(301, 101);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.AutoSize = true;
            this.labelAdmissionDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdmissionDate.Location = new System.Drawing.Point(28, 211);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(80, 13);
            this.labelAdmissionDate.TabIndex = 16;
            this.labelAdmissionDate.Text = "Admission Date";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBirthDate.Location = new System.Drawing.Point(54, 185);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(54, 13);
            this.labelBirthDate.TabIndex = 15;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddress.Location = new System.Drawing.Point(63, 159);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "Address";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 133);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 13;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelID.Location = new System.Drawing.Point(91, 107);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "ID";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLastName.Location = new System.Drawing.Point(50, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(73, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCode.Location = new System.Drawing.Point(76, 29);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Code";
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(114, 182);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerBD.TabIndex = 8;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxSex.Location = new System.Drawing.Point(220, 26);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(100, 69);
            this.groupBoxSex.TabIndex = 7;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sex";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAD
            // 
            this.dateTimePickerAD.Location = new System.Drawing.Point(114, 208);
            this.dateTimePickerAD.Name = "dateTimePickerAD";
            this.dateTimePickerAD.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAD.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(114, 104);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(114, 156);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(114, 130);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(114, 78);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Location = new System.Drawing.Point(114, 26);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
            // 
            // FormStudentManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_XavierSchool.Properties.Resources.rFsFmxwHKvLKRTtQZCbjkR;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.groupBoxStudentsData);
            this.Name = "FormStudentManagers";
            this.Text = "Student\'s Manager";
            this.groupBoxStudentsData.ResumeLayout(false);
            this.groupBoxStudentsData.PerformLayout();
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentsData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerAD;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelAdmissionDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonConsult;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
    }
}