
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
            this.BtnCargaCliente = new System.Windows.Forms.Button();
            this.BtnPropietarios = new System.Windows.Forms.Button();
            this.BtnPropiedades = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuVerEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuPropietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMnuPropiedades = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCargaCliente
            // 
            this.BtnCargaCliente.Location = new System.Drawing.Point(39, 135);
            this.BtnCargaCliente.Name = "BtnCargaCliente";
            this.BtnCargaCliente.Size = new System.Drawing.Size(137, 25);
            this.BtnCargaCliente.TabIndex = 0;
            this.BtnCargaCliente.Text = "Cargar Clientes";
            this.BtnCargaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargaCliente.UseVisualStyleBackColor = true;
            this.BtnCargaCliente.Click += new System.EventHandler(this.BtnCargaCliente_Click);
            // 
            // BtnPropietarios
            // 
            this.BtnPropietarios.Location = new System.Drawing.Point(39, 197);
            this.BtnPropietarios.Name = "BtnPropietarios";
            this.BtnPropietarios.Size = new System.Drawing.Size(137, 26);
            this.BtnPropietarios.TabIndex = 1;
            this.BtnPropietarios.Text = "Cargar Propietarios";
            this.BtnPropietarios.UseVisualStyleBackColor = true;
            this.BtnPropietarios.Click += new System.EventHandler(this.BtnPropietarios_Click);
            // 
            // BtnPropiedades
            // 
            this.BtnPropiedades.Location = new System.Drawing.Point(39, 262);
            this.BtnPropiedades.Name = "BtnPropiedades";
            this.BtnPropiedades.Size = new System.Drawing.Size(137, 26);
            this.BtnPropiedades.TabIndex = 2;
            this.BtnPropiedades.Text = "Cargar propiedades";
            this.BtnPropiedades.UseVisualStyleBackColor = true;
            this.BtnPropiedades.Click += new System.EventHandler(this.BtnPropiedades_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVerEditar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.MnuVerEditar.Size = new System.Drawing.Size(70, 20);
            this.MnuVerEditar.Text = "Ver/Editar";
            // 
            // SubMnuClientes
            // 
            this.SubMnuClientes.Name = "SubMnuClientes";
            this.SubMnuClientes.Size = new System.Drawing.Size(139, 22);
            this.SubMnuClientes.Text = "Clientes";
            this.SubMnuClientes.Click += new System.EventHandler(this.SubMnuClientes_Click);
            // 
            // SubMnuPropietarios
            // 
            this.SubMnuPropietarios.Name = "SubMnuPropietarios";
            this.SubMnuPropietarios.Size = new System.Drawing.Size(139, 22);
            this.SubMnuPropietarios.Text = "Porpietarios";
            this.SubMnuPropietarios.Click += new System.EventHandler(this.SubMnuPropietarios_Click);
            // 
            // SubMnuPropiedades
            // 
            this.SubMnuPropiedades.Name = "SubMnuPropiedades";
            this.SubMnuPropiedades.Size = new System.Drawing.Size(139, 22);
            this.SubMnuPropiedades.Text = "Propiedades";
            this.SubMnuPropiedades.Click += new System.EventHandler(this.SubMnuPropiedades_Click);
            // 
            // FrmMnuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPropiedades);
            this.Controls.Add(this.BtnPropietarios);
            this.Controls.Add(this.BtnCargaCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMnuPrincipal";
            this.ShowIcon = false;
            this.Text = "Inmobiliaria Julian Daniel";
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
    }
}

