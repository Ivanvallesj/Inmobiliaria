using Inmobiliaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Inmobiliaria.Formularios
{
    public partial class FrmCompraAlquiler : Form
    {
        DetalleCompraAlquiler detalleCompraAlquiler = new DetalleCompraAlquiler();
        public FrmCompraAlquiler()
        {
            InitializeComponent();
            CargarComboTipoOperacion();
            CargarComboCliente();
            CargarComboPropiedad();
        }

        private void CargarComboPropiedad()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaPropiedades = from propiedades in db.Propiedades
                                        select new { id = propiedades.Id, Nombre = propiedades.Nombre };
                CboPropiedad.DataSource = listaPropiedades.ToList();
                CboPropiedad.DisplayMember = "Nombre";
                CboPropiedad.ValueMember = "id";


            }
        }

        private void CargarComboCliente()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaClientes = from clientes in db.Clientes
                                       select new { id = clientes.Id, Nombre = clientes.Apellido + " " + clientes.Nombre };
                CboCliente.DataSource = listaClientes.ToList();
                CboCliente.DisplayMember = "Nombre";
                CboCliente.ValueMember = "id";


            }
        }

        private void CargarComboTipoOperacion()
        {
            CboCompraAlquiler.DataSource = Enum.GetValues(typeof(TipoDetalleEnum));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new InmobiliariaContext())
            {
                detalleCompraAlquiler.TipoDetalle = (TipoDetalleEnum)CboCompraAlquiler.SelectedValue;
                detalleCompraAlquiler.IdPropiedad = CboPropiedad.SelectedIndex;
                detalleCompraAlquiler.IdCliente = CboCliente.SelectedIndex;
                detalleCompraAlquiler.FechaFin = DateTimeFechaFin.Value.Date;
                detalleCompraAlquiler.FechaFin = DateTimeFechaFin.Value.Date;
                detalleCompraAlquiler.PrecioAlquiler = (double)NumUpDownPresAlquiler.Value;
                detalleCompraAlquiler.PrecioVenta = (double)NumUpDownPresVenta.Value;

                db.DetalleCompraAlquilers.Add(detalleCompraAlquiler);
                db.SaveChanges();

                MessageBox.Show("La operacion se realizo con exito");

            }
            this.Close();
        }

        private void CboCompraAlquiler_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((TipoDetalleEnum)CboCompraAlquiler.SelectedValue == TipoDetalleEnum.Alquier)
                {
                    LblPreVenta.Visible = false;
                    NumUpDownPresVenta.Visible = false;
                    LblPreAlquiler.Visible = true;
                    NumUpDownPresAlquiler.Visible = true;
                    LblFechaFin.Visible = true;
                    DateTimeFechaFin.Visible = true;

                }
                else
                {
                    LblPreVenta.Visible = true;
                    NumUpDownPresVenta.Visible = true;
                    LblPreAlquiler.Visible = false;
                    NumUpDownPresAlquiler.Visible = false;
                    LblFechaFin.Visible = false;
                    DateTimeFechaFin.Visible = false;
                }
            }
            catch
            {

            }
            
        }
    }
}
