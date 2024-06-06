using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Gasoline
{
    
    public partial class Servicio : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public Servicio()
        {
            InitializeComponent();
            serialPort1.Open();
        }
        string tipoGas;
        bool llena = false;
        string cantGas;
        string llenado;
        

        private void Servicio_load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            cantGasolina.Enabled = false;
            Tiempo.Interval = 1000;
            Tiempo.Tick += Tiempo_Tick;
            Tiempo.Start();
        }


        string mensaje;
        int valorGas = 0;
        double calculoGas=0;
        private void btnDiesel_CheckedChanged(object sender, EventArgs e)
        {
            if (!llena)
            {
                mensaje = "D" + cantGasolina.Text;
                cantGas = cantGasolina.Text;
            }
            else
            {
                mensaje = "D" + 50;
                cantGas = "50";


            }
            serialPort1.Write(mensaje);
            tipoGas = "Diesel";
        }

        private void btnSuper_CheckedChanged(object sender, EventArgs e)
        {
            if (!llena)
            {
                mensaje = "S" + cantGasolina.Text;
                cantGas = cantGasolina.Text;
            }
            else
            {
                mensaje = "S" + 50;
                cantGas = "50"; 
            }
            serialPort1.Write(mensaje);
            tipoGas = "Super";
        }

        private void btnAmbas_CheckedChanged(object sender, EventArgs e)
        {


            if (!llena)
            {
                mensaje = "A" + cantGasolina.Text;
                cantGas = cantGasolina.Text;

            }
            else
            {
                mensaje = "A" + 50;
                cantGas = "100"; 
            }
            serialPort1.Write(mensaje);
            tipoGas = "Ambas";
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:s");
        }

        private void btnPersonalizada_CheckedChanged(object sender, EventArgs e)
        {
            cantGasolina.Enabled = true;
            llena = false;
            llenado = "Prepago";
        }

        private void btnLLena_CheckedChanged(object sender, EventArgs e)
        {
            llena = true; 
            cantGasolina.Enabled = false;
            llenado = "Lleno";
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {

            Usuario temporal = new Usuario();
            temporal.Fecha = DateTime.Now.ToShortDateString();
            temporal.Hora = DateTime.Now.ToString("HH:mm:ss");
            temporal.Nombre = txtName.Text;
            temporal.Nit=txtNit.Text;
            temporal.CantGas = cantGasolina.Text;
            temporal.TipoGas = tipoGas;
            temporal.Tipollenado = llenado;
            usuarios.Add(temporal);

            // Guardar los datos en el archivo
            IngresarDatos(temporal);
            guardarDatos();

            limpiarForm();

        }

        private void IngresarDatos(Usuario nuevoUsuario)
        {
            // Guarda el nuevo abastecimiento en el archivo
            using (FileStream stream = new FileStream("Usuarios.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(nuevoUsuario.Fecha);
                    writer.WriteLine(nuevoUsuario.Hora);
                    writer.WriteLine(nuevoUsuario.Nombre);
                    writer.WriteLine(nuevoUsuario.Nit);
                    writer.WriteLine(nuevoUsuario.CantGas);
                    writer.WriteLine(nuevoUsuario.TipoGas);
                    writer.WriteLine(nuevoUsuario.Tipollenado);
                }
            }
        }

        private void guardarDatos()
        {
            try
            {
                string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                string archivo = "Datos.json";
                File.WriteAllText(archivo, json);
                MessageBox.Show("Datos guardados correctamente en formato JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos en JSON: {ex.Message}");
            }
        }

        private void limpiarForm() {

            txtName.Text = string.Empty;
            txtNit.Text = string.Empty;
            cantGasolina.Text = string.Empty;
            btnAmbas.Checked = false; 
            btnDiesel.Checked = false;
            btnLLena.Checked = false;
            btnPersonalizada.Checked=false;


        }

		private void btnCalculo_Click(object sender, EventArgs e)
		{
            if (btnDiesel.Checked = true && llena == false) {
                int valorGas = int.Parse(cantGasolina.Text);
                int total = valorGas * 15;
                lblTotal.Text = total.ToString();
            } else if (btnSuper.Checked = true && llena == false) {
				int valorGas = int.Parse(cantGasolina.Text);
				int total = valorGas * 10;
				lblTotal.Text = total.ToString();
			}else if (btnSuper.Checked = true && llena == true) {

				lblTotal.Text = "300";
			}else if (btnDiesel.Checked = true && llena == true) {

				lblTotal.Text = "400";
			}
		}
	}
}
