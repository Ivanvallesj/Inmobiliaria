
namespace Inmobiliaria
{
    partial class FrmMnuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMnuPrincipal));
            this.BtnCargaCliente = new System.Windows.Forms.Button();
            this.BtnPropietarios = new System.Windows.Forms.Button();
            this.BtnPropiedades = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuVerEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuPropietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuPropiedades = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListado = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuListClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAlquilerVenta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCargaCliente
            // 
            this.BtnCargaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCargaCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCargaCliente.Location = new System.Drawing.Point(602, 77);
            this.BtnCargaCliente.Name = "BtnCargaCliente";
            this.BtnCargaCliente.Size = new System.Drawing.Size(173, 58);
            this.BtnCargaCliente.TabIndex = 0;
            this.BtnCargaCliente.Text = "Cargar Clientes";
            this.BtnCargaCliente.UseVisualStyleBackColor = true;
            this.BtnCargaCliente.Click += new System.EventHandler(this.BtnCargaCliente_Click);
            // 
            // BtnPropietarios
            // 
            this.BtnPropietarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPropietarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPropietarios.Location = new System.Drawing.Point(602, 141);
            this.BtnPropietarios.Name = "BtnPropietarios";
            this.BtnPropietarios.Size = new System.Drawing.Size(173, 58);
            this.BtnPropietarios.TabIndex = 1;
            this.BtnPropietarios.Text = "Cargar Propietarios";
            this.BtnPropietarios.UseVisualStyleBackColor = true;
            this.BtnPropietarios.Click += new System.EventHandler(this.BtnPropietarios_Click);
            // 
            // BtnPropiedades
            // 
            this.BtnPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPropiedades.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPropiedades.Location = new System.Drawing.Point(602, 205);
            this.BtnPropiedades.Name = "BtnPropiedades";
            this.BtnPropiedades.Size = new System.Drawing.Size(173, 58);
            this.BtnPropiedades.TabIndex = 2;
            this.BtnPropiedades.Text = "Cargar propiedades";
            this.BtnPropiedades.UseVisualStyleBackColor = true;
            this.BtnPropiedades.Click += new System.EventHandler(this.BtnPropiedades_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVerEditar,
            this.MnuListado,
            this.MnuItemSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuVerEditar
            // 
            this.MnuVerEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnuClientes,
            this.SubMnuPropietarios,
            this.SubMnuPropiedades});
            this.MnuVerEditar.Name = "MnuVerEditar";
            this.MnuVerEditar.Size = new System.Drawing.Size(90, 23);
            this.MnuVerEditar.Text = "Ver/Editar";
            // 
            // SubMnuClientes
            // 
            this.SubMnuClientes.Name = "SubMnuClientes";
            this.SubMnuClientes.Size = new System.Drawing.Size(160, 24);
            this.SubMnuClientes.Text = "Clientes";
            this.SubMnuClientes.Click += new System.EventHandler(this.SubMnuClientes_Click);
            // 
            // SubMnuPropietarios
            // 
            this.SubMnuPropietarios.Name = "SubMnuPropietarios";
            this.SubMnuPropietarios.Size = new System.Drawing.Size(160, 24);
            this.SubMnuPropietarios.Text = "Porpietarios";
            this.SubMnuPropietarios.Click += new System.EventHandler(this.SubMnuPropietarios_Click);
            // 
            // SubMnuPropiedades
            // 
            this.SubMnuPropiedades.Name = "SubMnuPropiedades";
            this.SubMnuPropiedades.Size = new System.Drawing.Size(160, 24);
            this.SubMnuPropiedades.Text = "Propiedades";
            this.SubMnuPropiedades.Click += new System.EventHandler(this.SubMnuPropiedades_Click);
            // 
            // MnuListado
            // 
            this.MnuListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMnuListClientes});
            this.MnuListado.Name = "MnuListado";
            this.MnuListado.Size = new System.Drawing.Size(71, 23);
            this.MnuListado.Text = "Listado";
            // 
            // SubMnuListClientes
            // 
            this.SubMnuListClientes.Name = "SubMnuListClientes";
            this.SubMnuListClientes.Size = new System.Drawing.Size(133, 24);
            this.SubMnuListClientes.Text = "Clientes";
            this.SubMnuListClientes.Click += new System.EventHandler(this.SubMnuListClientes_Click);
            // 
            // MnuItemSalir
            // 
            this.MnuItemSalir.Name = "MnuItemSalir";
            this.MnuItemSalir.Size = new System.Drawing.Size(54, 23);
            this.MnuItemSalir.Text = "Salir";
            this.MnuItemSalir.Click += new System.EventHandler(this.MnuItemSalir_Click);
            // 
            // BtnAlquilerVenta
            // 
            this.BtnAlquilerVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlquilerVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlquilerVenta.Location = new System.Drawing.Point(602, 309);
            this.BtnAlquilerVenta.Name = "BtnAlquilerVenta";
            this.BtnAlquilerVenta.Size = new System.Drawing.Size(172, 75);
            this.BtnAlquilerVenta.TabIndex = 4;
            this.BtnAlquilerVenta.Text = "Venta o Alquiler";
            this.BtnAlquilerVenta.UseVisualStyleBackColor = true;
            this.BtnAlquilerVenta.Click += new System.EventHandler(this.BtnAlquilerVenta_Click);
            // 
            // FrmMnuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAlquilerVenta);
            this.Controls.Add(this.BtnPropiedades);
            this.Controls.Add(this.BtnPropietarios);
            this.Controls.Add(this.BtnCargaCliente);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMnuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria Julian Daniel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargaCliente;
        private System.Windows.Forms.Button BtnPropietarios;
        private System.Windows.Forms.Button BtnPropiedades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuVerEditar;
        private System.Windows.Forms.ToolStripMenuItem SubMnuClientes;
        private System.Windows.Forms.ToolStripMenuItem SubMnuPropietarios;
        private System.Windows.Forms.ToolStripMenuItem SubMnuPropiedades;
        private System.Windows.Forms.ToolStripMenuItem MnuListado;
        private System.Windows.Forms.ToolStripMenuItem SubMnuListClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuItemSalir;
        private System.Windows.Forms.Button BtnAlquilerVenta;
    }
}

