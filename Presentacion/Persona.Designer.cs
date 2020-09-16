namespace Presentacion
{
    partial class Persona
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.btn_Tarjeta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExisteTarjeta = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(129, 91);
            this.txtNombre.MaxLength = 28;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(129, 115);
            this.txtApellido.MaxLength = 28;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDocumento
            // 
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumento.Location = new System.Drawing.Point(129, 164);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtCUIL
            // 
            this.txtCUIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCUIL.Location = new System.Drawing.Point(129, 188);
            this.txtCUIL.MaxLength = 11;
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(100, 20);
            this.txtCUIL.TabIndex = 5;
            this.txtCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIL_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(129, 236);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 42);
            this.label4.TabIndex = 25;
            this.label4.Text = "CARGUE SUS DATOS DE USUARIO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "N° de Documento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "CUIL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Edad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tipo Documento:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(129, 212);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 33;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI (Documento Nacional de Identidad)",
            "LE (Libreta de Enrrolamiento)",
            "LC (Libreta Civica)"});
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Items.AddRange(new object[] {
            "DNI (Documento Nacional de Identidad)",
            "LE    (Libreta de Enrrolamiento)",
            "LC    (Libreta Civica)"});
            this.cmbDocumento.Location = new System.Drawing.Point(129, 139);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(100, 21);
            this.cmbDocumento.TabIndex = 34;
            // 
            // btn_Tarjeta
            // 
            this.btn_Tarjeta.Location = new System.Drawing.Point(15, 402);
            this.btn_Tarjeta.Name = "btn_Tarjeta";
            this.btn_Tarjeta.Size = new System.Drawing.Size(224, 35);
            this.btn_Tarjeta.TabIndex = 38;
            this.btn_Tarjeta.Text = "DATOS TARJETA";
            this.btn_Tarjeta.UseVisualStyleBackColor = true;
            this.btn_Tarjeta.Click += new System.EventHandler(this.btn_Tarjeta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(143, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(38, 327);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(14, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 35);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExisteTarjeta
            // 
            this.btnExisteTarjeta.Location = new System.Drawing.Point(15, 372);
            this.btnExisteTarjeta.Name = "btnExisteTarjeta";
            this.btnExisteTarjeta.Size = new System.Drawing.Size(224, 24);
            this.btnExisteTarjeta.TabIndex = 39;
            this.btnExisteTarjeta.Text = "Verificar Tarjetas";
            this.btnExisteTarjeta.UseVisualStyleBackColor = true;
            this.btnExisteTarjeta.Click += new System.EventHandler(this.btnExisteTarjeta_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(266, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(727, 166);
            this.dataGridView2.TabIndex = 40;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 447);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExisteTarjeta);
            this.Controls.Add(this.btn_Tarjeta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Persona";
            this.Text = "FORMULARIO PERSONA USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Button btn_Tarjeta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExisteTarjeta;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}