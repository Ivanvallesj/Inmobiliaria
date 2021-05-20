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
    public partial class FrmVerEditarPropiedad : Form
    {
        public FrmVerEditarPropiedad()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            using (var db = new InmobiliariaContext())
            {
                var MostrarPropiedades = from propiedades in db.Propiedades
                                         select new
                                         {
                                             Id = propiedades.Id,
                                             Nombre = propiedades.Nombre,
                                             Ubicacion = propiedades.Ubicacion,
                                             Valor = propiedades.Valor,
                                             Disponibilidad = propiedades.Disponibilidad,
                                             Porpietario = propiedades.Propietario.Apellido + propiedades.Propietario.Nombre
                                         };
                DataGrid.DataSource = MostrarPropiedades.ToList();

            }
        }

        private void ActualizarGrilla(string TextoBuscar)
        {
            using (var db = new InmobiliariaContext())
            {
                var MostrarClientes = from propiedades in db.Propiedades
                                      select new
                                      {
                                          Id = propiedades.Id,
                                          Nombre = propiedades.Nombre,
                                          Ubicacion = propiedades.Ubicacion,
                                          Valor = propiedades.Valor,
                                          Disponibilidad = propiedades.Disponibilidad,
                                          Porpietario = propiedades.Propietario.Apellido + propiedades.Propietario.Nombre

                                      };
                DataGrid.DataSource = MostrarClientes.Where(t => t.Nombre.Contains(TextoBuscar)).ToList();


            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCargarPropiedad = new FrmCargarPropiedades();
            frmCargarPropiedad.ShowDialog();
            ActualizarGrilla();
            DataGrid.CurrentCell = DataGrid.Rows[DataGrid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // creamos la variable para saber el id del cliente que tenemos seleccionado 
            var idSeleccionado = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());
            var filaAeditar = DataGrid.CurrentRow.Index;
            //Abrimos el formulario para la edicion del cliente seleccionado
            var frmCargarPropiedad = new FrmCargarPropiedades(idSeleccionado);
            frmCargarPropiedad.ShowDialog();

            ActualizarGrilla();

            DataGrid.CurrentCell = DataGrid.Rows[filaAeditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del cliente seleccionado en la grilla 
            //guardamos en la variable el id del cliente 

            var IdPropiedadSeleccionada = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());

            //guardamos en la variable el nombre del cliente 
            var NombrePropiedadSeleccionada = DataGrid.CurrentRow.Cells[1].Value.ToString();

            //Pregunta si realmente desea eliminar al cliente seleccionado

            DialogResult respuesta = MessageBox.Show($"Esta seguro que desea eliminar la propiedad {NombrePropiedadSeleccionada}?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si instanciamos al objeto db context y elimnamos al cliente a travez del id seleccionado

            if (respuesta == DialogResult.Yes)
            {
                using (var db = new InmobiliariaContext())
                {
                    var propiedades = db.Propiedades.Find(IdPropiedadSeleccionada);
                    db.Propiedades.Remove(propiedades);
                    db.SaveChanges();
                }
                ActualizarGrilla();
            }
        }

        private void TextBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(TextBoxBuscador.Text);
        }
    }
}
