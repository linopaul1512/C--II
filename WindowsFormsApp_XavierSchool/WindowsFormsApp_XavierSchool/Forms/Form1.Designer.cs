namespace WindowsFormsApp_XavierSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonStudentManager = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonReportStudents = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.buttonReportProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudentManager
            // 
            this.buttonStudentManager.Location = new System.Drawing.Point(14, 30);
            this.buttonStudentManager.Name = "buttonStudentManager";
            this.buttonStudentManager.Size = new System.Drawing.Size(136, 59);
            this.buttonStudentManager.TabIndex = 0;
            this.buttonStudentManager.Text = "Student\'s Manager";
            this.buttonStudentManager.UseVisualStyleBackColor = true;
            this.buttonStudentManager.Click += new System.EventHandler(this.buttonStudentManager_Click);
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Location = new System.Drawing.Point(14, 224);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(138, 59);
            this.buttonAddProject.TabIndex = 2;
            this.buttonAddProject.Text = "Project\'s Manager";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            this.buttonAddProject.Click += new System.EventHandler(this.buttonAddProject_Click);
            // 
            // buttonReportStudents
            // 
            this.buttonReportStudents.Location = new System.Drawing.Point(14, 289);
            this.buttonReportStudents.Name = "buttonReportStudents";
            this.buttonReportStudents.Size = new System.Drawing.Size(138, 59);
            this.buttonReportStudents.TabIndex = 4;
            this.buttonReportStudents.Text = "Report Students For Projects";
            this.buttonReportStudents.UseVisualStyleBackColor = true;
            this.buttonReportStudents.Click += new System.EventHandler(this.buttonReportStudents_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(14, 354);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(138, 59);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(14, 101);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(137, 47);
            this.buttonAssign.TabIndex = 7;
            this.buttonAssign.Text = "Assign Students To Projects";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // buttonReportProjects
            // 
            this.buttonReportProjects.Location = new System.Drawing.Point(14, 154);
            this.buttonReportProjects.Name = "buttonReportProjects";
            this.buttonReportProjects.Size = new System.Drawing.Size(136, 59);
            this.buttonReportProjects.TabIndex = 8;
            this.buttonReportProjects.Text = "Report Finished Projects";
            this.buttonReportProjects.UseVisualStyleBackColor = true;
            this.buttonReportProjects.Click += new System.EventHandler(this.buttonReportProjects_Click_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(170, 478);
            this.Controls.Add(this.buttonReportProjects);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReportStudents);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.buttonStudentManager);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudentManager;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonReportStudents;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Button buttonReportProjects;
    }
}

