using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Formularios;

namespace Inmobiliaria
{
    public partial class FrmMnuPrincipal : Form
    {
        public FrmMnuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCargaCliente_Click(object sender, EventArgs e)
        {
            var frmCargarCliente = new FrmCargarCliente();
            frmCargarCliente.ShowDialog();
        }

        private void BtnPropietarios_Click(object sender, EventArgs e)
        {
            var frmCargarPropietarios = new FrmCargarPropietario();
            frmCargarPropietarios.ShowDialog();
        }

        private void BtnPropiedades_Click(object sender, EventArgs e)
        {
            var frmCargarPorpiedades = new FrmCargarPropiedades();
            frmCargarPorpiedades.ShowDialog();
        }

        private void SubMnuClientes_Click(object sender, EventArgs e)
        {
            var frmVerEditarCliente = new FrmVerEditarClientes();
            frmVerEditarCliente.ShowDialog();
        }

        private void SubMnuPropietarios_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropietario = new FrmVerEditarPropietario();
            frmVerEditarPropietario.ShowDialog();
        }

        private void SubMnuPropiedades_Click(object sender, EventArgs e)
        {
            var frmVerEditarPropiedades = new FrmVerEditarPropiedad();
            frmVerEditarPropiedades.ShowDialog();
        }

        private void SubMnuListClientes_Click(object sender, EventArgs e)
        {
            var frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void MnuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlquilerVenta_Click(object sender, EventArgs e)
        {
            var frmCompraAalquiler = new FrmCompraAlquiler();
            frmCompraAalquiler.ShowDialog();
        }
    }
}
