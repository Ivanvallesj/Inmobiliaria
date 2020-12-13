using Inmobiliaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Formularios
{
    public partial class FrmCargarPropiedades : Form
    {
        public int? IdEditar { get; set; }
        Propiedades propiedades = new Propiedades();
        public FrmCargarPropiedades()

        {
            
            InitializeComponent();
            CargarComboPropietario();

            
        }
        public FrmCargarPropiedades(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboPropietario();

            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                CargarDatosDeLaPropiedad();
            }

        }

        private void CargarDatosDeLaPropiedad()
        {
            using (var db = new InmobiliariaContext())
            {
                propiedades = db.Propiedades.Find(IdEditar);
                TxtNombre.Text = propiedades.Nombre;
                TxtUbicacion.Text = propiedades.Ubicacion;
                numericUpDownValorPropiedad.Value = (decimal)propiedades.Valor;
                CheckBoxDisponibilidad.Checked = propiedades.Disponibilidad;
                CboPropietarios.SelectedValue = propiedades.PropietarioId;

            }
        }

        private void CargarComboPropietario()
        {
            using (var db = new InmobiliariaContext())
            {
                var listaPropietarios = from propietario in db.Propietario
                                        select new { id = propietario.Id, Nombre = propietario.Apellido + " " + propietario.Nombre };
                CboPropietarios.DataSource = listaPropietarios.ToList();
                CboPropietarios.DisplayMember = "Nombre";
                CboPropietarios.ValueMember = "id";


            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new InmobiliariaContext())
            {

                propiedades.Nombre = TxtNombre.Text;
                propiedades.Ubicacion = TxtUbicacion.Text;
                propiedades.Valor = (double)numericUpDownValorPropiedad.Value;
                propiedades.Disponibilidad = CheckBoxDisponibilidad.Checked;
                propiedades.PropietarioId = (int)CboPropietarios.SelectedValue;


                //si el id del cliente a editar es nulo agregamos un nuevo cliente a la tabla
                if (IdEditar == null)
                    //lo agregamos a la base de datos
                    db.Propiedades.Add(propiedades);

                else //cofiguramos el almacenamiento de la modificacion si el id del cliente es distinto a nulo
                {
                    db.Entry(propiedades).State = EntityState.Modified;
                }
                if (IdEditar == null)
                    MessageBox.Show("La propiedad " + propiedades.Nombre + " se cargo con exito");

                else
                {
                    MessageBox.Show("La propiedad " + propiedades.Nombre + " se modifico con exito");
                }


                db.SaveChanges();
                


            }
            this.Close();
        }
    }
}
