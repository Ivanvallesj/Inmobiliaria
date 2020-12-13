using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Inmobiliaria.Formularios
{
    public partial class FrmCargarPropietario : Form
    {
        public int? IdEditar { get; set; }
        Propietario propietario = new Propietario();
        public FrmCargarPropietario()
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboEstadiCivil();
            CargarComboIva();

        }
        public FrmCargarPropietario(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboEstadiCivil();
            CargarComboIva();

            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                CargarDatosDelPropietario();
            }

        }

        private void CargarDatosDelPropietario()
        {
            using (var db = new InmobiliariaContext())
            {
                propietario = db.Propietario.Find(IdEditar);
                TxtNombre.Text = propietario.Nombre;
                TxtApellido.Text = propietario.Apellido;
                TxtDomicilio.Text = propietario.Domicilio;
                NumDni.Value = (decimal)propietario.Dni;
                NumCuil.Value = (decimal)propietario.Cuil;
                NumCuit.Value = (decimal)propietario.Cuit;
                DateTimeNacimiento.Value = propietario.FechaNacimiento;
                NumTelefono.Value = (decimal)propietario.Telefono;
                CboSexo.SelectedItem = propietario.Sexo;
                TxtEmail.Text = propietario.Email;
                CboEstadoCivil.SelectedItem = propietario.EstadoCivil;
                TxtLocalidad.Text = propietario.Localidad;
                CboIva.SelectedItem = propietario.CondicionIva;

            }
        }

        private void CargarComboIva()
        {
            CboIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
        }

        private void CargarComboEstadiCivil()
        {
            CboEstadoCivil.DataSource = Enum.GetValues(typeof(EstadoCivilEnum));
        }

        private void CargarComboSexo()
        {
            CboSexo.DataSource = Enum.GetValues(typeof(SexoEnum));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            using (var db = new InmobiliariaContext()){
                
                propietario.Nombre = TxtNombre.Text;
                propietario.Apellido = TxtApellido.Text;
                propietario.Domicilio = TxtDomicilio.Text;
                propietario.Dni = (int)NumDni.Value;
                propietario.Cuil = (double)NumCuil.Value;
                propietario.Cuit = (double)NumCuit.Value;
                propietario.FechaNacimiento = DateTimeNacimiento.Value.Date;
                propietario.Telefono = (double)NumTelefono.Value;
                propietario.Sexo = (SexoEnum)CboSexo.SelectedValue;
                propietario.Email = TxtEmail.Text;
                propietario.EstadoCivil = (EstadoCivilEnum)CboEstadoCivil.SelectedValue;
                propietario.Localidad = TxtLocalidad.Text;
                propietario.CondicionIva = (CondicionIvaEnum)CboIva.SelectedValue;

                //si el id del cliente a editar es nulo agregamos un nuevo cliente a la tabla
                if (IdEditar == null)
                    //lo agregamos a la base de datos
                    db.Propietario.Add(propietario);

                else //cofiguramos el almacenamiento de la modificacion si el id del cliente es distinto a nulo
                {
                    db.Entry(propietario).State = EntityState.Modified;
                }
                if (IdEditar == null)
                    MessageBox.Show("El cliente " + propietario.Nombre + propietario.Apellido + " se cargo con exito");

                else
                {
                    MessageBox.Show("El cliente " + propietario.Nombre + propietario.Apellido + " se modifico con exito");
                }


                db.SaveChanges();

            }
            this.Close();
        }
    }
}
