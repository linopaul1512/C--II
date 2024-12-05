
namespace EjercicioDebug2
{
    partial class FormListadoFlores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxListado = new System.Windows.Forms.GroupBox();
            this.dataGridViewFlores = new System.Windows.Forms.DataGridView();
            this.groupBoxAgregar = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPetalos = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOlor = new System.Windows.Forms.ComboBox();
            this.textBoxTemporada = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlores)).BeginInit();
            this.groupBoxAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPetalos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListado
            // 
            this.groupBoxListado.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxListado.Controls.Add(this.dataGridViewFlores);
            this.groupBoxListado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxListado.Location = new System.Drawing.Point(21, 18);
            this.groupBoxListado.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxListado.Name = "groupBoxListado";
            this.groupBoxListado.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxListado.Size = new System.Drawing.Size(506, 419);
            this.groupBoxListado.TabIndex = 0;
            this.groupBoxListado.TabStop = false;
            this.groupBoxListado.Text = "Flores";
            // 
            // dataGridViewFlores
            // 
            this.dataGridViewFlores.AllowUserToAddRows = false;
            this.dataGridViewFlores.AllowUserToDeleteRows = false;
            this.dataGridViewFlores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFlores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlores.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewFlores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlores.Location = new System.Drawing.Point(8, 33);
            this.dataGridViewFlores.Name = "dataGridViewFlores";
            this.dataGridViewFlores.ReadOnly = true;
            this.dataGridViewFlores.RowTemplate.Height = 25;
            this.dataGridViewFlores.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewFlores.Size = new System.Drawing.Size(490, 378);
            this.dataGridViewFlores.TabIndex = 0;
            this.dataGridViewFlores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlores_CellClick);
            // 
            // groupBoxAgregar
            // 
            this.groupBoxAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.groupBoxAgregar.Controls.Add(this.buttonEliminar);
            this.groupBoxAgregar.Controls.Add(this.buttonAtras);
            this.groupBoxAgregar.Controls.Add(this.buttonModificar);
            this.groupBoxAgregar.Controls.Add(this.buttonGuardar);
            this.groupBoxAgregar.Controls.Add(this.label5);
            this.groupBoxAgregar.Controls.Add(this.label4);
            this.groupBoxAgregar.Controls.Add(this.label3);
            this.groupBoxAgregar.Controls.Add(this.label2);
            this.groupBoxAgregar.Controls.Add(this.label1);
            this.groupBoxAgregar.Controls.Add(this.numericUpDownPetalos);
            this.groupBoxAgregar.Controls.Add(this.comboBoxOlor);
            this.groupBoxAgregar.Controls.Add(this.textBoxTemporada);
            this.groupBoxAgregar.Controls.Add(this.textBoxCodigo);
            this.groupBoxAgregar.Controls.Add(this.textBoxNombre);
            this.groupBoxAgregar.Location = new System.Drawing.Point(547, 18);
            this.groupBoxAgregar.Name = "groupBoxAgregar";
            this.groupBoxAgregar.Size = new System.Drawing.Size(314, 503);
            this.groupBoxAgregar.TabIndex = 1;
            this.groupBoxAgregar.TabStop = false;
            this.groupBoxAgregar.Text = "Agregar";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Salmon;
            this.buttonEliminar.Location = new System.Drawing.Point(89, 365);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(99, 46);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.Salmon;
            this.buttonAtras.Location = new System.Drawing.Point(7, 365);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(71, 46);
            this.buttonAtras.TabIndex = 14;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonatras_Click_1);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Salmon;
            this.buttonModificar.Location = new System.Drawing.Point(81, 436);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(113, 50);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonmodificar_Click_1);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Salmon;
            this.buttonGuardar.Location = new System.Drawing.Point(194, 365);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(113, 46);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Olor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temporada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "# Pétalos:";
            // 
            // numericUpDownPetalos
            // 
            this.numericUpDownPetalos.Location = new System.Drawing.Point(12, 306);
            this.numericUpDownPetalos.Name = "numericUpDownPetalos";
            this.numericUpDownPetalos.Size = new System.Drawing.Size(296, 32);
            this.numericUpDownPetalos.TabIndex = 4;
            // 
            // comboBoxOlor
            // 
            this.comboBoxOlor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOlor.FormattingEnabled = true;
            this.comboBoxOlor.Items.AddRange(new object[] {
            "Frutal",
            "Primaveral",
            "Miel",
            "Abejas",
            "Rocío matutino"});
            this.comboBoxOlor.Location = new System.Drawing.Point(12, 244);
            this.comboBoxOlor.Name = "comboBoxOlor";
            this.comboBoxOlor.Size = new System.Drawing.Size(296, 31);
            this.comboBoxOlor.TabIndex = 3;
            // 
            // textBoxTemporada
            // 
            this.textBoxTemporada.Location = new System.Drawing.Point(12, 181);
            this.textBoxTemporada.Name = "textBoxTemporada";
            this.textBoxTemporada.Size = new System.Drawing.Size(296, 32);
            this.textBoxTemporada.TabIndex = 2;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 56);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(296, 32);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 117);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(296, 32);
            this.textBoxNombre.TabIndex = 0;
            // 
            // FormListadoFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(873, 533);
            this.Controls.Add(this.groupBoxAgregar);
            this.Controls.Add(this.groupBoxListado);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormListadoFlores";
            this.Text = "Listado de Flores";
            this.Load += new System.EventHandler(this.FormListadoFlores_Load);
            this.groupBoxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlores)).EndInit();
            this.groupBoxAgregar.ResumeLayout(false);
            this.groupBoxAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPetalos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListado;
        private System.Windows.Forms.DataGridView dataGridViewFlores;
        private System.Windows.Forms.GroupBox groupBoxAgregar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxTemporada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPetalos;
        private System.Windows.Forms.ComboBox comboBoxOlor;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

