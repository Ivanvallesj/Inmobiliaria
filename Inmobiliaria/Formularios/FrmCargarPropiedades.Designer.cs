
namespace Inmobiliaria.Formularios
{
    partial class FrmCargarPropiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarPropiedades));
            this.LblPrincipal = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblPropietario = new System.Windows.Forms.Label();
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.CheckBoxDisponibilidad = new System.Windows.Forms.CheckBox();
            this.CboPropietarios = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.numericUpDownValorPropiedad = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValorPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrincipal
            // 
            this.LblPrincipal.AutoSize = true;
            this.LblPrincipal.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblPrincipal.Location = new System.Drawing.Point(185, 19);
            this.LblPrincipal.Name = "LblPrincipal";
            this.LblPrincipal.Size = new System.Drawing.Size(349, 35);
            this.LblPrincipal.TabIndex = 21;
            this.LblPrincipal.Text = "Pantalla de carga de propiedades";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(185, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(120, 23);
            this.TxtNombre.TabIndex = 19;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(40, 94);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(62, 23);
            this.LblNombre.TabIndex = 20;
            this.LblNombre.Text = "Nombre";
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblUbicacion.Location = new System.Drawing.Point(40, 165);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(71, 23);
            this.LblUbicacion.TabIndex = 22;
            this.LblUbicacion.Text = "Ubicacion";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(185, 165);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(120, 23);
            this.TxtUbicacion.TabIndex = 23;
            // 
            // LblPropietario
            // 
            this.LblPropietario.AutoSize = true;
            this.LblPropietario.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPropietario.Location = new System.Drawing.Point(40, 364);
            this.LblPropietario.Name = "LblPropietario";
            this.LblPropietario.Size = new System.Drawing.Size(81, 23);
            this.LblPropietario.TabIndex = 24;
            this.LblPropietario.Text = "Propietario";
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDisponibilidad.Location = new System.Drawing.Point(40, 301);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(101, 23);
            this.LblDisponibilidad.TabIndex = 25;
            this.LblDisponibilidad.Text = "Disponibilidad";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblValor.Location = new System.Drawing.Point(40, 233);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(47, 23);
            this.LblValor.TabIndex = 26;
            this.LblValor.Text = "Valor ";
            // 
            // CheckBoxDisponibilidad
            // 
            this.CheckBoxDisponibilidad.AutoSize = true;
            this.CheckBoxDisponibilidad.Location = new System.Drawing.Point(185, 306);
            this.CheckBoxDisponibilidad.Name = "CheckBoxDisponibilidad";
            this.CheckBoxDisponibilidad.Size = new System.Drawing.Size(82, 19);
            this.CheckBoxDisponibilidad.TabIndex = 30;
            this.CheckBoxDisponibilidad.Text = "Disponible";
            this.CheckBoxDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // CboPropietarios
            // 
            this.CboPropietarios.FormattingEnabled = true;
            this.CboPropietarios.Location = new System.Drawing.Point(185, 364);
            this.CboPropietarios.Name = "CboPropietarios";
            this.CboPropietarios.Size = new System.Drawing.Size(121, 23);
            this.CboPropietarios.TabIndex = 31;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(458, 285);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(149, 39);
            this.BtnGuardar.TabIndex = 32;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(458, 364);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(149, 39);
            this.BtnCancelar.TabIndex = 33;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // numericUpDownValorPropiedad
            // 
            this.numericUpDownValorPropiedad.Location = new System.Drawing.Point(185, 233);
            this.numericUpDownValorPropiedad.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownValorPropiedad.Name = "numericUpDownValorPropiedad";
            this.numericUpDownValorPropiedad.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownValorPropiedad.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 162);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCargarPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownValorPropiedad);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboPropietarios);
            this.Controls.Add(this.CheckBoxDisponibilidad);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblDisponibilidad);
            this.Controls.Add(this.LblPropietario);
            this.Controls.Add(this.TxtUbicacion);
            this.Controls.Add(this.LblUbicacion);
            this.Controls.Add(this.LblPrincipal);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarPropiedades";
            this.ShowIcon = false;
            this.Text = "Carga de propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValorPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrincipal;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblPropietario;
        private System.Windows.Forms.Label LblDisponibilidad;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.CheckBox CheckBoxDisponibilidad;
        private System.Windows.Forms.ComboBox CboPropietarios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown numericUpDownValorPropiedad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}