using Inmobiliaria.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Inmobiliaria.Formularios
{
    
    public partial class FrmListadoClientes : Form
    {
        private readonly ReportViewer reporte;
        public FrmListadoClientes()
        {
            InitializeComponent();
            //instnciamos un visor de reportes
            reporte = new ReportViewer();
            //hacemos que ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            //abrimos el reporte utilizando la clase fileStream
            using var fs = new FileStream(@"..\..\..\Reportes\ReporteClientes.rdlc", FileMode.Open);
            //asignamos el archi a la propiedad local report del objeto report viewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //Buscamos los datos que va a graficar el reporte 
            using var db = new InmobiliariaContext();
            var clientes = db.Clientes.ToList();
            //asignamos lo datos a la propiedad data source de local report utilizando un objeto de ttipo report data source
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetListadoClientes", clientes));

            reporte.RefreshReport();
        }
    }
}
