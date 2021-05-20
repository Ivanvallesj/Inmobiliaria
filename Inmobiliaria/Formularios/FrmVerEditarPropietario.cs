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
    public partial class FrmVerEditarPropietario : Form
    {
        public FrmVerEditarPropietario()
        {
            InitializeComponent();
            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            using (var db = new InmobiliariaContext())
            {
                var MostrarPropietarios = from propietario in db.Propietario
                                      select new
                                      {
                                          Id = propietario.Id,
                                          Nombre = propietario.Apellido + "" + propietario.Nombre,
                                          Dni = propietario.Dni,
                                          Telefono = propietario.Telefono,
                                          Localidad = propietario.Localidad,
                                          Domicilio = propietario.Domicilio
                                      };
                DataGrid.DataSource = MostrarPropietarios.ToList();
                 
            }
        }

        private void ActualizarGrilla(string TextoBuscar)
        {
            using (var db = new InmobiliariaContext())
            {
                var MostrarPropietarios = from propietario in db.Propietario
                                          select new
                                          {
                                              Id = propietario.Id,
                                              Nombre = propietario.Apellido + "" + propietario.Nombre,
                                              Dni = propietario.Dni,
                                              Telefono = propietario.Telefono,
                                              Localidad = propietario.Localidad,
                                              Domicilio = propietario.Domicilio
                                          };
                DataGrid.DataSource = MostrarPropietarios.Where(t => t.Nombre.Contains(TextoBuscar) || t.Dni.ToString().Contains(TextoBuscar)).ToList();

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frmCargarPropietario = new FrmCargarPropietario();
            frmCargarPropietario.ShowDialog();
            ActualizarGrilla();
            DataGrid.CurrentCell = DataGrid.Rows[DataGrid.RowCount - 1].Cells[0];
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // creamos la variable para saber el id del propietario que tenemos seleccionado 
            var idSeleccionado = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());
            var filaAeditar = DataGrid.CurrentRow.Index;
            //Abrimos el formulario para la edicion del propietario seleccionado
            var frmCargarPropietario = new FrmCargarPropietario(idSeleccionado);
            frmCargarPropietario.ShowDialog();

            ActualizarGrilla();

            DataGrid.CurrentCell = DataGrid.Rows[filaAeditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del cliente seleccionado en la grilla 
            //guardamos en la variable el id del cliente 

            var IdPropietarioSeleccionado = int.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());

            //guardamos en la variable el nombre del cliente 
            var NombrePropietarioSeleccionado = DataGrid.CurrentRow.Cells[1].Value.ToString();

            //Pregunta si realmente desea eliminar al cliente seleccionado

            DialogResult respuesta = MessageBox.Show($"Esta seguro que desea eliminar al cliente {NombrePropietarioSeleccionado}?", "Eliminar propietario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si instanciamos al objeto db context y elimnamos al cliente a travez del id seleccionado

            if (respuesta == DialogResult.Yes)
            {
                using (var db = new InmobiliariaContext())
                {
                    var propietario = db.Propietario.Find(IdPropietarioSeleccionado);
                    db.Propietario.Remove(propietario);
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
