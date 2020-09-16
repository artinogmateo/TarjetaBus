namespace Presentacion
{
    partial class Tarjeta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Persona = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarSaldo = new System.Windows.Forms.Button();
            this.btnPagarViaje = new System.Windows.Forms.Button();
            this.txtViaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionarSaldo = new System.Windows.Forms.Button();
            this.btnPasaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(674, 146);
            this.txtNroTarjeta.MaxLength = 4;
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(114, 20);
            this.txtNroTarjeta.TabIndex = 14;
            this.txtNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "N° Tarjeta:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(674, 111);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(114, 20);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nº Documento:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(693, 240);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(588, 240);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(564, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 35);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 42);
            this.label4.TabIndex = 24;
            this.label4.Text = "CARGUE LOS DATOS DE SU TARJETA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Persona
            // 
            this.bt_Persona.Location = new System.Drawing.Point(564, 337);
            this.bt_Persona.Name = "bt_Persona";
            this.bt_Persona.Size = new System.Drawing.Size(224, 85);
            this.bt_Persona.TabIndex = 25;
            this.bt_Persona.Text = "PERSONA USUARIO";
            this.bt_Persona.UseVisualStyleBackColor = true;
            this.bt_Persona.Click += new System.EventHandler(this.bt_Persona_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(238, 351);
            this.txtSaldo.MaxLength = 6;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(105, 20);
            this.txtSaldo.TabIndex = 27;
            this.txtSaldo.Text = "0";
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cargar Saldo: $";
            // 
            // btnCargarSaldo
            // 
            this.btnCargarSaldo.Location = new System.Drawing.Point(361, 337);
            this.btnCargarSaldo.Name = "btnCargarSaldo";
            this.btnCargarSaldo.Size = new System.Drawing.Size(102, 47);
            this.btnCargarSaldo.TabIndex = 28;
            this.btnCargarSaldo.Text = "Cargar Saldo";
            this.btnCargarSaldo.UseVisualStyleBackColor = true;
            this.btnCargarSaldo.Click += new System.EventHandler(this.btnCargarSaldo_Click);
            // 
            // btnPagarViaje
            // 
            this.btnPagarViaje.Location = new System.Drawing.Point(361, 399);
            this.btnPagarViaje.Name = "btnPagarViaje";
            this.btnPagarViaje.Size = new System.Drawing.Size(102, 39);
            this.btnPagarViaje.TabIndex = 29;
            this.btnPagarViaje.Text = "PAGAR VIAJE";
            this.btnPagarViaje.UseVisualStyleBackColor = true;
            this.btnPagarViaje.Click += new System.EventHandler(this.btnPagarViaje_Click);
            // 
            // txtViaje
            // 
            this.txtViaje.Location = new System.Drawing.Point(238, 410);
            this.txtViaje.MaxLength = 6;
            this.txtViaje.Name = "txtViaje";
            this.txtViaje.Size = new System.Drawing.Size(105, 20);
            this.txtViaje.TabIndex = 30;
            this.txtViaje.Text = "0";
            this.txtViaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtViaje_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Costo Pasaje: $";
            // 
            // btnSeleccionarSaldo
            // 
            this.btnSeleccionarSaldo.Location = new System.Drawing.Point(37, 337);
            this.btnSeleccionarSaldo.Name = "btnSeleccionarSaldo";
            this.btnSeleccionarSaldo.Size = new System.Drawing.Size(117, 47);
            this.btnSeleccionarSaldo.TabIndex = 32;
            this.btnSeleccionarSaldo.Text = "Seleccionar Saldo";
            this.btnSeleccionarSaldo.UseVisualStyleBackColor = true;
            this.btnSeleccionarSaldo.Click += new System.EventHandler(this.SeleccionarSaldo_Click);
            // 
            // btnPasaje
            // 
            this.btnPasaje.Location = new System.Drawing.Point(37, 401);
            this.btnPasaje.Name = "btnPasaje";
            this.btnPasaje.Size = new System.Drawing.Size(117, 37);
            this.btnPasaje.TabIndex = 33;
            this.btnPasaje.Text = "Seleccionar costo del Pasaje";
            this.btnPasaje.UseVisualStyleBackColor = true;
            this.btnPasaje.Click += new System.EventHandler(this.btnPasaje_Click_1);
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasaje);
            this.Controls.Add(this.btnSeleccionarSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtViaje);
            this.Controls.Add(this.btnPagarViaje);
            this.Controls.Add(this.btnCargarSaldo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Persona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNroTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tarjeta";
            this.Text = "FORMULARIO TARJETA USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Persona;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarSaldo;
        private System.Windows.Forms.Button btnPagarViaje;
        private System.Windows.Forms.TextBox txtViaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionarSaldo;
        private System.Windows.Forms.Button btnPasaje;
    }
}

