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
    public partial class FrmCargarCliente : Form
    {
        public int? IdEditar { get; set; }
        Cliente cliente = new Cliente();
        public FrmCargarCliente()
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboEstadiCivil();
            CargarComboIva();

        }
        public FrmCargarCliente(int idSeleccionado)
        {
            InitializeComponent();
            CargarComboSexo();
            CargarComboEstadiCivil();
            CargarComboIva();

            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                CargarDatosDelCliente();
            }

        }

        private void CargarDatosDelCliente()
        {
            using (var db = new InmobiliariaContext())
            {
                cliente = db.Clientes.Find(IdEditar);
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                TxtDomicilio.Text = cliente.Domicilio;
                NumDni.Value = cliente.Dni;
                NumCuil.Value = (decimal)cliente.Cuil;
                NumCuit.Value = (decimal)cliente.Cuit;
                DateTimeNacimiento.Value = cliente.FechaNacimiento;
                NumTelefono.Value = (decimal)cliente.Telefono;
                CboSexo.SelectedItem = cliente.Sexo;
                TxtEmail.Text = cliente.Email;
                CboEstadoCivil.SelectedItem = cliente.EstadoCivil;
                TxtLocalidad.Text = cliente.Localidad;
                CboIva.SelectedItem = cliente.CondicionIva;
 
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
                
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = TxtApellido.Text;
                cliente.Domicilio = TxtDomicilio.Text;
                cliente.Dni = (int)NumDni.Value;
                cliente.Cuil = (double)NumCuil.Value;
                cliente.Cuit = (double)NumCuit.Value;
                cliente.FechaNacimiento = DateTimeNacimiento.Value.Date;
                cliente.Telefono = (double)NumTelefono.Value;
                cliente.Sexo = (SexoEnum)CboSexo.SelectedValue;
                cliente.Email = TxtEmail.Text;
                cliente.EstadoCivil = (EstadoCivilEnum)CboEstadoCivil.SelectedValue;
                cliente.Localidad = TxtLocalidad.Text;
                cliente.CondicionIva = (CondicionIvaEnum)CboIva.SelectedValue;
                

                //si el id del cliente a editar es nulo agregamos un nuevo cliente a la tabla
                if (IdEditar == null)
                    //lo agregamos a la base de datos
                    db.Clientes.Add(cliente);

                else //cofiguramos el almacenamiento de la modificacion si el id del cliente es distinto a nulo
                {
                    db.Entry(cliente).State = EntityState.Modified;
                }
                if (IdEditar == null)
                    MessageBox.Show("El cliente " + cliente.Nombre + cliente.Apellido + " se cargo con exito");

                else 
                {
                    MessageBox.Show("El cliente " + cliente.Nombre + cliente.Apellido + " se modifico con exito");
                }


                db.SaveChanges();
               


            }
            this.Close();
        }
    }
}
