namespace ProjectBrainstormRental.View
{
    partial class FormRental
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
            this.textBoxNumberofHour = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelNumberofHour = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelRental = new System.Windows.Forms.Label();
            this.buttonSearchBrainEnhancers = new System.Windows.Forms.Button();
            this.buttonsearchClient = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.labelNameClient = new System.Windows.Forms.Label();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.labelPriceperHour = new System.Windows.Forms.Label();
            this.textBoxPriceperHour = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumberofHour
            // 
            this.textBoxNumberofHour.Location = new System.Drawing.Point(492, 234);
            this.textBoxNumberofHour.Name = "textBoxNumberofHour";
            this.textBoxNumberofHour.Size = new System.Drawing.Size(215, 20);
            this.textBoxNumberofHour.TabIndex = 17;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(492, 158);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(215, 20);
            this.textBoxSerialNumber.TabIndex = 16;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(492, 83);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(215, 20);
            this.textBoxID.TabIndex = 15;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(492, 51);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(215, 20);
            this.textBoxCode.TabIndex = 14;
            // 
            // labelNumberofHour
            // 
            this.labelNumberofHour.AutoSize = true;
            this.labelNumberofHour.Location = new System.Drawing.Point(57, 234);
            this.labelNumberofHour.Name = "labelNumberofHour";
            this.labelNumberofHour.Size = new System.Drawing.Size(82, 13);
            this.labelNumberofHour.TabIndex = 13;
            this.labelNumberofHour.Text = "Number of Hour";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(57, 165);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.labelSerialNumber.TabIndex = 12;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(57, 90);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = "ID";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(57, 58);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 10;
            this.labelCode.Text = "Code";
            // 
            // labelRental
            // 
            this.labelRental.AutoSize = true;
            this.labelRental.Location = new System.Drawing.Point(346, 20);
            this.labelRental.Name = "labelRental";
            this.labelRental.Size = new System.Drawing.Size(38, 13);
            this.labelRental.TabIndex = 9;
            this.labelRental.Text = "Rental";
            // 
            // buttonSearchBrainEnhancers
            // 
            this.buttonSearchBrainEnhancers.Location = new System.Drawing.Point(217, 360);
            this.buttonSearchBrainEnhancers.Name = "buttonSearchBrainEnhancers";
            this.buttonSearchBrainEnhancers.Size = new System.Drawing.Size(114, 43);
            this.buttonSearchBrainEnhancers.TabIndex = 32;
            this.buttonSearchBrainEnhancers.Text = "Search Brain Enhancers";
            this.buttonSearchBrainEnhancers.UseVisualStyleBackColor = true;
            this.buttonSearchBrainEnhancers.Click += new System.EventHandler(this.buttonSearchBrainEnhancers_Click);
            // 
            // buttonsearchClient
            // 
            this.buttonsearchClient.Location = new System.Drawing.Point(497, 298);
            this.buttonsearchClient.Name = "buttonsearchClient";
            this.buttonsearchClient.Size = new System.Drawing.Size(114, 43);
            this.buttonsearchClient.TabIndex = 30;
            this.buttonsearchClient.Text = "Search Client";
            this.buttonsearchClient.UseVisualStyleBackColor = true;
            this.buttonsearchClient.Click += new System.EventHandler(this.buttonsearchClient_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(306, 298);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 29;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(126, 298);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 28;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Location = new System.Drawing.Point(57, 127);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(63, 13);
            this.labelNameClient.TabIndex = 33;
            this.labelNameClient.Text = "Name client";
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(492, 120);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(215, 20);
            this.textBoxNameClient.TabIndex = 34;
            // 
            // labelPriceperHour
            // 
            this.labelPriceperHour.AutoSize = true;
            this.labelPriceperHour.Location = new System.Drawing.Point(57, 198);
            this.labelPriceperHour.Name = "labelPriceperHour";
            this.labelPriceperHour.Size = new System.Drawing.Size(73, 13);
            this.labelPriceperHour.TabIndex = 35;
            this.labelPriceperHour.Text = "Price per hour";
            // 
            // textBoxPriceperHour
            // 
            this.textBoxPriceperHour.Location = new System.Drawing.Point(492, 198);
            this.textBoxPriceperHour.Name = "textBoxPriceperHour";
            this.textBoxPriceperHour.Size = new System.Drawing.Size(215, 20);
            this.textBoxPriceperHour.TabIndex = 36;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(57, 274);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 37;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(492, 267);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(215, 20);
            this.textBoxTotal.TabIndex = 38;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(416, 360);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(114, 43);
            this.buttonCalculate.TabIndex = 39;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // FormRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxPriceperHour);
            this.Controls.Add(this.labelPriceperHour);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.labelNameClient);
            this.Controls.Add(this.buttonSearchBrainEnhancers);
            this.Controls.Add(this.buttonsearchClient);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.textBoxNumberofHour);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelNumberofHour);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelRental);
            this.Name = "FormRental";
            this.Text = "Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberofHour;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelNumberofHour;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelRental;
        private System.Windows.Forms.Button buttonSearchBrainEnhancers;
        private System.Windows.Forms.Button buttonsearchClient;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.Label labelPriceperHour;
        private System.Windows.Forms.TextBox textBoxPriceperHour;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonCalculate;
    }
}