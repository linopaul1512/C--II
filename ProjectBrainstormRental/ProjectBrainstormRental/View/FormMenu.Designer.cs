namespace ProjectBrainstormRental.View
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
            this.buttonFormClient = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFromRental = new System.Windows.Forms.Button();
            this.buttonformBrainEnhancers = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormClient
            // 
            this.buttonFormClient.BackColor = System.Drawing.Color.Orange;
            this.buttonFormClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFormClient.Location = new System.Drawing.Point(218, 139);
            this.buttonFormClient.Name = "buttonFormClient";
            this.buttonFormClient.Size = new System.Drawing.Size(114, 43);
            this.buttonFormClient.TabIndex = 33;
            this.buttonFormClient.Text = "Client";
            this.buttonFormClient.UseVisualStyleBackColor = false;
            this.buttonFormClient.Click += new System.EventHandler(this.buttonFormClient_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.Location = new System.Drawing.Point(426, 230);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 43);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFromRental
            // 
            this.buttonFromRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonFromRental.Location = new System.Drawing.Point(142, 230);
            this.buttonFromRental.Name = "buttonFromRental";
            this.buttonFromRental.Size = new System.Drawing.Size(114, 43);
            this.buttonFromRental.TabIndex = 35;
            this.buttonFromRental.Text = "Rental";
            this.buttonFromRental.UseVisualStyleBackColor = false;
            this.buttonFromRental.Click += new System.EventHandler(this.buttonFromRental_Click);
            // 
            // buttonformBrainEnhancers
            // 
            this.buttonformBrainEnhancers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonformBrainEnhancers.Location = new System.Drawing.Point(370, 139);
            this.buttonformBrainEnhancers.Name = "buttonformBrainEnhancers";
            this.buttonformBrainEnhancers.Size = new System.Drawing.Size(114, 43);
            this.buttonformBrainEnhancers.TabIndex = 34;
            this.buttonformBrainEnhancers.Text = "Brain Enhancers";
            this.buttonformBrainEnhancers.UseVisualStyleBackColor = false;
            this.buttonformBrainEnhancers.Click += new System.EventHandler(this.buttonformBrainEnhancers_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(280, 44);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(183, 44);
            this.labelWelcome.TabIndex = 38;
            this.labelWelcome.Text = "Welcome";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReport.Location = new System.Drawing.Point(288, 307);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(114, 43);
            this.buttonReport.TabIndex = 39;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonFromRental);
            this.Controls.Add(this.buttonformBrainEnhancers);
            this.Controls.Add(this.buttonFormClient);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFormClient;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFromRental;
        private System.Windows.Forms.Button buttonformBrainEnhancers;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonReport;
    }
}