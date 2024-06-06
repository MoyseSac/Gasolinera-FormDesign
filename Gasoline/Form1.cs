using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasoline
{
    public partial class Form1 : Form
    {
        Sistema sistema;
        Reportes reportes;
        Servicio servicio;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Despliegue de ofertas
        bool expandMenu = false; 
        private void transicionOfertas_Tick(object sender, EventArgs e)
        {
            if (expandMenu == false)
            {
                pnlOffers.Height += 10;
                if (pnlOffers.Height>=224)
                {
                    transicionOfertas.Stop();
                    expandMenu = true;
                }
            }else
            {
                pnlOffers.Height -= 10;
                if (pnlOffers.Height <= 70)
                {
                    transicionOfertas.Stop();
                    expandMenu = false;
                }
            }
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            transicionOfertas.Start();
            ofertadiesel.Text = "30% de descuento";
			ofertasuper.Text = "15% de descuento";

		}

        //Despligue menu principal 
        bool sideMenduExpand= true;

        private void transcionMenu_Tick(object sender, EventArgs e)
        {
            if (sideMenduExpand)
            {
                panelMenu.Width -= 5;
                if(panelMenu.Width <= 70)
                {
                    sideMenduExpand = false;
                    transcionMenu.Stop();

                }

            }
            else
            {
                panelMenu.Width += 5;
                if (panelMenu.Width >= 200)
                {
                    sideMenduExpand = true;
                    transcionMenu.Stop();

                    pnlOffers.Width = panelMenu.Width;
                    pnlReportes.Width = panelMenu.Width;
                    pnlSistema.Width = panelMenu.Width;
                    pnlServicio.Width = panelMenu.Width;
                    
                }
            }
        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            transcionMenu.Start();
        }

        //Cambio de formularios en el principal 

        private void btnSistema_Click(object sender, EventArgs e)
        {
            if (sistema == null)
            {
                sistema = new Sistema();
                sistema.FormClosed += Sistema_Closed;
                sistema.MdiParent = this;
                sistema.Dock= DockStyle.Fill;
                sistema.Show();
            }
            else
            {
                sistema.Activate();
            }
        }
        private void Sistema_Closed(object sender, FormClosedEventArgs e )
        {
            sistema = null;    
        }
        private void btnServicio_Click(object sender, EventArgs e)
        {
            if (servicio == null)
            {
                servicio = new Servicio();
                servicio.FormClosed += Servicio_Closed;
                servicio.MdiParent = this;
                servicio.Dock = DockStyle.Fill;
                servicio.Show();
            }
            else
            {
                servicio.Activate();
            }
        }
        private void Servicio_Closed(object sender, FormClosedEventArgs e)
        {
            sistema = null;
        }

        private void Reportes_Closed(object sender, FormClosedEventArgs e)
        {
            reportes = null;
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            if (reportes == null)
            {
                reportes = new Reportes();
                reportes.FormClosed += Reportes_Closed;
                reportes.MdiParent = this;
                reportes.Dock = DockStyle.Fill;
                reportes.Show();
            }
            else
            {
                reportes.Activate();
            }
        }

		private void button4_Click(object sender, EventArgs e)
		{
            
		}

		private void panelMenu_Paint(object sender, PaintEventArgs e)
		{

		}
	}
    
}
