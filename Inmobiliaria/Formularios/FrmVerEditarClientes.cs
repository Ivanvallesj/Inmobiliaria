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
    public partial class FrmVerEditarClientes : Form
    {
        public FrmVerEditarClientes()
        {
            InitializeComponent();
            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            using (var db = new InmobiliariaContext())
            {
                var MostrarClientes = from cliente in db.Clientes
                                      select new
                                      {
                                          Id = cliente.Id,
                                          Nombre = cliente.Apellido + "" + cliente.Nombre,
                                          Dni = cliente.Dni,
                                          Telefono = cliente.Telefono,
                                          Localidad = cliente.Localidad,
                                          Domicilio = cliente.Domicilio

                                      };
                DataGrid.DataSource = MostrarClientes.ToList();
                
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCargarCliente = new FrmCargarCliente();
            frmCargarCliente.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // creamos la variable para saber el id del cliente que tenemos seleccionado 
            var idSeleccionado = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());
            var filaAeditar = DataGrid.CurrentRow.Index;
            //Abrimos el formulario para la edicion del cliente seleccionado
            var frmCargarCliente = new FrmCargarCliente(idSeleccionado);
            frmCargarCliente.ShowDialog();

            ActualizarGrilla();

            DataGrid.CurrentCell = DataGrid.Rows[filaAeditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del cliente seleccionado en la grilla 
            //guardamos en la variable el id del cliente 

            var IdClienteSeleccionado = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());

            //guardamos en la variable el nombre del cliente 
            var NombreClienteSeleccionado = DataGrid.CurrentRow.Cells[1].Value.ToString();

            //Pregunta si realmente desea eliminar al cliente seleccionado

            DialogResult respuesta = MessageBox.Show($"Esta seguro que desea eliminar al cliente {NombreClienteSeleccionado}?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si instanciamos al objeto db context y elimnamos al cliente a travez del id seleccionado

            if (respuesta == DialogResult.Yes)
            {
                using (var db = new InmobiliariaContext())
                {
                    var cliente = db.Clientes.Find(IdClienteSeleccionado);
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }
    }
}
