
namespace Inmobiliaria.Formularios
{
    partial class FrmCargarCliente
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblCuilCuit = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblOpcional = new System.Windows.Forms.Label();
            this.LblLocalida = new System.Windows.Forms.Label();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtLocalidad = new System.Windows.Forms.TextBox();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblPrincipal = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumDni = new System.Windows.Forms.NumericUpDown();
            this.NumCuil = new System.Windows.Forms.NumericUpDown();
            this.NumTelefono = new System.Windows.Forms.NumericUpDown();
            this.DateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.CboIva = new System.Windows.Forms.ComboBox();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.LblCuit = new System.Windows.Forms.Label();
            this.NumCuit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCuil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCuit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LblNombre.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(56, 69);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(62, 23);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.Location = new System.Drawing.Point(56, 124);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(62, 23);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDireccion.Location = new System.Drawing.Point(56, 178);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(71, 23);
            this.LblDireccion.TabIndex = 2;
            this.LblDireccion.Text = "Domicilio";
            // 
            // LblCuilCuit
            // 
            this.LblCuilCuit.AutoSize = true;
            this.LblCuilCuit.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCuilCuit.Location = new System.Drawing.Point(53, 275);
            this.LblCuilCuit.Name = "LblCuilCuit";
            this.LblCuilCuit.Size = new System.Drawing.Size(35, 23);
            this.LblCuilCuit.TabIndex = 3;
            this.LblCuilCuit.Text = "Cuil";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.Location = new System.Drawing.Point(507, 189);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(116, 23);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email (opcional)";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDni.Location = new System.Drawing.Point(56, 230);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(32, 23);
            this.LblDni.TabIndex = 5;
            this.LblDni.Text = "Dni";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSexo.Location = new System.Drawing.Point(507, 135);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(111, 23);
            this.LblSexo.TabIndex = 6;
            this.LblSexo.Text = "Sexo (Opcional)";
            // 
            // LblOpcional
            // 
            this.LblOpcional.AutoSize = true;
            this.LblOpcional.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOpcional.Location = new System.Drawing.Point(507, 243);
            this.LblOpcional.Name = "LblOpcional";
            this.LblOpcional.Size = new System.Drawing.Size(151, 23);
            this.LblOpcional.TabIndex = 7;
            this.LblOpcional.Text = "Estado civil (opcional)";
            // 
            // LblLocalida
            // 
            this.LblLocalida.AutoSize = true;
            this.LblLocalida.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLocalida.Location = new System.Drawing.Point(507, 292);
            this.LblLocalida.Name = "LblLocalida";
            this.LblLocalida.Size = new System.Drawing.Size(70, 23);
            this.LblLocalida.TabIndex = 8;
            this.LblLocalida.Text = "Localidad";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblIva.Location = new System.Drawing.Point(501, 351);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(156, 23);
            this.LblIva.TabIndex = 9;
            this.LblIva.Text = "Condicion frente al IVA";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTelefono.Location = new System.Drawing.Point(507, 73);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(65, 23);
            this.LblTelefono.TabIndex = 10;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFechaNacimiento.Location = new System.Drawing.Point(53, 354);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(139, 23);
            this.LblFechaNacimiento.TabIndex = 11;
            this.LblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(201, 69);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(160, 23);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtLocalidad
            // 
            this.TxtLocalidad.Location = new System.Drawing.Point(663, 295);
            this.TxtLocalidad.Name = "TxtLocalidad";
            this.TxtLocalidad.Size = new System.Drawing.Size(121, 23);
            this.TxtLocalidad.TabIndex = 11;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(201, 178);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(160, 23);
            this.TxtDomicilio.TabIndex = 2;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(201, 124);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(160, 23);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(663, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 23);
            this.TxtEmail.TabIndex = 9;
            // 
            // LblPrincipal
            // 
            this.LblPrincipal.AutoSize = true;
            this.LblPrincipal.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblPrincipal.Location = new System.Drawing.Point(201, 9);
            this.LblPrincipal.Name = "LblPrincipal";
            this.LblPrincipal.Size = new System.Drawing.Size(302, 35);
            this.LblPrincipal.TabIndex = 18;
            this.LblPrincipal.Text = "Pantalla de carga de clientes";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Display", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(577, 392);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(94, 36);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Sitka Display", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(677, 392);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 36);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NumDni
            // 
            this.NumDni.Location = new System.Drawing.Point(201, 230);
            this.NumDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumDni.Name = "NumDni";
            this.NumDni.Size = new System.Drawing.Size(160, 23);
            this.NumDni.TabIndex = 3;
            // 
            // NumCuil
            // 
            this.NumCuil.Location = new System.Drawing.Point(201, 275);
            this.NumCuil.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NumCuil.Name = "NumCuil";
            this.NumCuil.Size = new System.Drawing.Size(160, 23);
            this.NumCuil.TabIndex = 4;
            // 
            // NumTelefono
            // 
            this.NumTelefono.Location = new System.Drawing.Point(663, 73);
            this.NumTelefono.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.Size = new System.Drawing.Size(121, 23);
            this.NumTelefono.TabIndex = 7;
            // 
            // DateTimeNacimiento
            // 
            this.DateTimeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeNacimiento.Location = new System.Drawing.Point(201, 354);
            this.DateTimeNacimiento.Name = "DateTimeNacimiento";
            this.DateTimeNacimiento.Size = new System.Drawing.Size(160, 23);
            this.DateTimeNacimiento.TabIndex = 6;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(663, 138);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(121, 23);
            this.CboSexo.TabIndex = 8;
            // 
            // CboIva
            // 
            this.CboIva.FormattingEnabled = true;
            this.CboIva.Location = new System.Drawing.Point(663, 354);
            this.CboIva.Name = "CboIva";
            this.CboIva.Size = new System.Drawing.Size(121, 23);
            this.CboIva.TabIndex = 12;
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Location = new System.Drawing.Point(663, 243);
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(121, 23);
            this.CboEstadoCivil.TabIndex = 10;
            // 
            // LblCuit
            // 
            this.LblCuit.AutoSize = true;
            this.LblCuit.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCuit.Location = new System.Drawing.Point(53, 313);
            this.LblCuit.Name = "LblCuit";
            this.LblCuit.Size = new System.Drawing.Size(36, 23);
            this.LblCuit.TabIndex = 28;
            this.LblCuit.Text = "Cuit";
            // 
            // NumCuit
            // 
            this.NumCuit.Location = new System.Drawing.Point(201, 313);
            this.NumCuit.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NumCuit.Name = "NumCuit";
            this.NumCuit.Size = new System.Drawing.Size(160, 23);
            this.NumCuit.TabIndex = 5;
            // 
            // FrmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumCuit);
            this.Controls.Add(this.LblCuit);
            this.Controls.Add(this.CboEstadoCivil);
            this.Controls.Add(this.CboIva);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.DateTimeNacimiento);
            this.Controls.Add(this.NumTelefono);
            this.Controls.Add(this.NumCuil);
            this.Controls.Add(this.NumDni);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblPrincipal);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtLocalidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.LblLocalida);
            this.Controls.Add(this.LblOpcional);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCuilCuit);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de carga de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.NumDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCuil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblCuilCuit;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblOpcional;
        private System.Windows.Forms.Label LblLocalida;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtLocalidad;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblPrincipal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumDni;
        private System.Windows.Forms.NumericUpDown NumCuil;
        private System.Windows.Forms.NumericUpDown NumTelefono;
        private System.Windows.Forms.DateTimePicker DateTimeNacimiento;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.ComboBox CboIva;
        private System.Windows.Forms.ComboBox CboEstadoCivil;
        private System.Windows.Forms.Label LblCuit;
        private System.Windows.Forms.NumericUpDown NumCuit;
    }
}