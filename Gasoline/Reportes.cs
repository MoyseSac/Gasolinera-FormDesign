using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasoline
{
    public partial class Reportes : Form
    {
        List<Usuario> reporte = new List<Usuario>();
        List<Usuario> cierreList = new List<Usuario>();
        List<Usuario> prepagoList = new List<Usuario>();
        List<Usuario> llenadoList = new List<Usuario>();
        
        public Reportes()
        {
            InitializeComponent();
        }


        private void Reportes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Leerusuarios();
        }

        public void Leerusuarios()
        {
            reporte.Clear();
            string fileName = "Usuarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {

                Usuario usuario = new Usuario();
                usuario.Fecha=reader.ReadLine(); 
                usuario.Hora=reader.ReadLine();
                usuario.Nombre = reader.ReadLine();
                usuario.Nit = reader.ReadLine();
                usuario.CantGas = reader.ReadLine();
                usuario.TipoGas = reader.ReadLine();
                usuario.Tipollenado = reader.ReadLine();
                reporte.Add(usuario);
            }
            reader.Close();
        }

        public void CargarCierre()
        {
            Leerusuarios();
            cierreList.Clear();


            foreach (var usuario in reporte)
            {
                Usuario reporte = new Usuario
                {
                    Fecha = usuario.Fecha,
                    Hora = usuario.Hora,
                    Nombre = usuario.Nombre,
                    Nit = usuario.Nit,
                    CantGas = usuario.CantGas,
                    TipoGas = usuario.TipoGas,
                    Tipollenado = usuario.Tipollenado,
                };
                cierreList.Add(reporte);
                
            }

            dataCierre.DataSource = null;
            dataCierre.DataSource = cierreList;
            dataCierre.Refresh();

        }

        public void CargarPrepago()
        {
            Leerusuarios();
            string busqueda = "Prepago";

            var prepagos = reporte.Where(v => v.Tipollenado == busqueda);

            prepagoList.Clear();

            foreach (var usuario in prepagos)
            {
                Usuario reporte = new Usuario
                {
                    Fecha = usuario.Fecha,
                    Hora = usuario.Hora,
                    Nombre = usuario.Nombre,
                    Nit = usuario.Nit,
                    CantGas = usuario.CantGas,
                    TipoGas = usuario.TipoGas,
                    Tipollenado = usuario.Tipollenado,
                };
                prepagoList.Add(reporte);
            }

            dataPrepago.DataSource = null;
            dataPrepago.DataSource = prepagoList;
            dataPrepago.Refresh();

        }
        
        public void CargarLlenado()
        {
            Leerusuarios();
            string busqueda = "Lleno";

            var llenados = reporte.Where(v => v.Tipollenado == busqueda);

            llenadoList.Clear();

            foreach (var usuario in llenados)
            {
                Usuario reporte = new Usuario
                {
                    Fecha = usuario.Fecha,
                    Hora = usuario.Hora,
                    Nombre = usuario.Nombre,
                    Nit = usuario.Nit,
                    TipoGas = usuario.TipoGas,
                    CantGas = usuario.CantGas,
                    Tipollenado = usuario.Tipollenado,
                };
                llenadoList.Add(reporte);
            }

            dataLlenado.DataSource = null;
            dataLlenado.DataSource = llenadoList;
            dataLlenado.Refresh();

        }



        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            CargarCierre();
            CargarLlenado();
            CargarPrepago();
            consumosBombas();
        }

        private void consumosBombas() {
            int contDiesel = 0, contSuper = 0;
            try {
                string[] lineas = File.ReadAllLines("Usuarios.txt");

                for (int i = 5; i < lineas.Length; i += 7) {
                    string cuartaLinea = lineas[i];
                    if (cuartaLinea.Equals("Diesel", StringComparison.OrdinalIgnoreCase))
                    {
                        contDiesel++;
                    }
                    else if (cuartaLinea.Equals("Super", StringComparison.OrdinalIgnoreCase))
                    {
                        contSuper++;
                    }


                }
                txtUso(contDiesel, contSuper);
            }
            catch (Exception e) {
                Console.WriteLine("Error al leer el archivo:");
                Console.WriteLine(e.Message);
            }
        }

        private void txtUso(int contDiesel, int contSuper)
        {
            if (contDiesel > contSuper)
            {
                lblMasUsado.Text = $"Bomba más usada: Diesel ({contDiesel})";
                lblMenosUsado.Text = $"Bomba menos usada: Super ({contSuper})";
            }
            else if (contSuper> contDiesel)
            {
                lblMasUsado.Text = $"Bomba más usada: Super ({contSuper})";
                lblMenosUsado.Text = $"Bomba menos usada: Diesel ({contDiesel})";
            }
            else {
                lblMasUsado.Text = $"Ambas bombas usadas igualmente ({contDiesel})";
            }
        }


    }
}
