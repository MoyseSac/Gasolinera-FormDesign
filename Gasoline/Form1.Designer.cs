namespace Gasoline
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.btnMenu = new System.Windows.Forms.PictureBox();
			this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlSistema = new System.Windows.Forms.Panel();
			this.btnSistema = new System.Windows.Forms.Button();
			this.pnlServicio = new System.Windows.Forms.Panel();
			this.btnServicio = new System.Windows.Forms.Button();
			this.pnlOffers = new System.Windows.Forms.FlowLayoutPanel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnOffers = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.pnlReportes = new System.Windows.Forms.Panel();
			this.btnReportes = new System.Windows.Forms.Button();
			this.transicionOfertas = new System.Windows.Forms.Timer(this.components);
			this.transcionMenu = new System.Windows.Forms.Timer(this.components);
			this.ofertadiesel = new System.Windows.Forms.Label();
			this.ofertasuper = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			this.panelMenu.SuspendLayout();
			this.pnlSistema.SuspendLayout();
			this.pnlServicio.SuspendLayout();
			this.pnlOffers.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.pnlReportes.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.nightControlBox1);
			this.panel1.Controls.Add(this.labelTitulo);
			this.panel1.Controls.Add(this.btnMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1022, 42);
			this.panel1.TabIndex = 0;
			// 
			// nightControlBox1
			// 
			this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nightControlBox1.DefaultLocation = true;
			this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.EnableMaximizeButton = true;
			this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.EnableMinimizeButton = true;
			this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.Location = new System.Drawing.Point(883, 0);
			this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.Name = "nightControlBox1";
			this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
			this.nightControlBox1.TabIndex = 1;
			// 
			// labelTitulo
			// 
			this.labelTitulo.AutoSize = true;
			this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.Location = new System.Drawing.Point(59, 11);
			this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(126, 23);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "Gasolinera | DK";
			// 
			// btnMenu
			// 
			this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
			this.btnMenu.Location = new System.Drawing.Point(7, 6);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(35, 32);
			this.btnMenu.TabIndex = 0;
			this.btnMenu.TabStop = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.panelMenu.Controls.Add(this.pnlSistema);
			this.panelMenu.Controls.Add(this.pnlServicio);
			this.panelMenu.Controls.Add(this.pnlOffers);
			this.panelMenu.Controls.Add(this.pnlReportes);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panelMenu.Location = new System.Drawing.Point(0, 42);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 500);
			this.panelMenu.TabIndex = 1;
			this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
			// 
			// pnlSistema
			// 
			this.pnlSistema.Controls.Add(this.btnSistema);
			this.pnlSistema.Location = new System.Drawing.Point(4, 4);
			this.pnlSistema.Margin = new System.Windows.Forms.Padding(4);
			this.pnlSistema.Name = "pnlSistema";
			this.pnlSistema.Size = new System.Drawing.Size(212, 69);
			this.pnlSistema.TabIndex = 4;
			// 
			// btnSistema
			// 
			this.btnSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.btnSistema.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSistema.ForeColor = System.Drawing.Color.White;
			this.btnSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSistema.Image")));
			this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSistema.Location = new System.Drawing.Point(-8, -26);
			this.btnSistema.Margin = new System.Windows.Forms.Padding(4);
			this.btnSistema.Name = "btnSistema";
			this.btnSistema.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.btnSistema.Size = new System.Drawing.Size(253, 112);
			this.btnSistema.TabIndex = 2;
			this.btnSistema.Text = "Sistema";
			this.btnSistema.UseVisualStyleBackColor = false;
			this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
			// 
			// pnlServicio
			// 
			this.pnlServicio.Controls.Add(this.btnServicio);
			this.pnlServicio.Location = new System.Drawing.Point(4, 81);
			this.pnlServicio.Margin = new System.Windows.Forms.Padding(4);
			this.pnlServicio.Name = "pnlServicio";
			this.pnlServicio.Size = new System.Drawing.Size(212, 69);
			this.pnlServicio.TabIndex = 3;
			// 
			// btnServicio
			// 
			this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.btnServicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServicio.ForeColor = System.Drawing.Color.White;
			this.btnServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnServicio.Image")));
			this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnServicio.Location = new System.Drawing.Point(-8, -26);
			this.btnServicio.Margin = new System.Windows.Forms.Padding(4);
			this.btnServicio.Name = "btnServicio";
			this.btnServicio.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.btnServicio.Size = new System.Drawing.Size(253, 112);
			this.btnServicio.TabIndex = 2;
			this.btnServicio.Text = "Servicio";
			this.btnServicio.UseVisualStyleBackColor = false;
			this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
			// 
			// pnlOffers
			// 
			this.pnlOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.pnlOffers.Controls.Add(this.panel6);
			this.pnlOffers.Controls.Add(this.panel5);
			this.pnlOffers.Controls.Add(this.panel7);
			this.pnlOffers.Location = new System.Drawing.Point(3, 157);
			this.pnlOffers.Name = "pnlOffers";
			this.pnlOffers.Size = new System.Drawing.Size(213, 74);
			this.pnlOffers.TabIndex = 6;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.btnOffers);
			this.panel6.Location = new System.Drawing.Point(4, 4);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(212, 69);
			this.panel6.TabIndex = 6;
			// 
			// btnOffers
			// 
			this.btnOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.btnOffers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOffers.ForeColor = System.Drawing.Color.White;
			this.btnOffers.Image = ((System.Drawing.Image)(resources.GetObject("btnOffers.Image")));
			this.btnOffers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOffers.Location = new System.Drawing.Point(-16, -29);
			this.btnOffers.Margin = new System.Windows.Forms.Padding(4);
			this.btnOffers.Name = "btnOffers";
			this.btnOffers.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.btnOffers.Size = new System.Drawing.Size(253, 112);
			this.btnOffers.TabIndex = 2;
			this.btnOffers.Text = "Ofertas";
			this.btnOffers.UseVisualStyleBackColor = false;
			this.btnOffers.Click += new System.EventHandler(this.btnOffers_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.ofertadiesel);
			this.panel5.Controls.Add(this.button4);
			this.panel5.Location = new System.Drawing.Point(4, 81);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(212, 69);
			this.panel5.TabIndex = 5;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(-16, -29);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.button4.Size = new System.Drawing.Size(253, 112);
			this.button4.TabIndex = 2;
			this.button4.Text = "Diesel";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.ofertasuper);
			this.panel7.Controls.Add(this.button6);
			this.panel7.Location = new System.Drawing.Point(4, 158);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(212, 69);
			this.panel7.TabIndex = 7;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.button6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(-16, -29);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.button6.Size = new System.Drawing.Size(253, 112);
			this.button6.TabIndex = 2;
			this.button6.Text = "Super";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// pnlReportes
			// 
			this.pnlReportes.Controls.Add(this.btnReportes);
			this.pnlReportes.Location = new System.Drawing.Point(4, 238);
			this.pnlReportes.Margin = new System.Windows.Forms.Padding(4);
			this.pnlReportes.Name = "pnlReportes";
			this.pnlReportes.Size = new System.Drawing.Size(212, 69);
			this.pnlReportes.TabIndex = 4;
			// 
			// btnReportes
			// 
			this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportes.ForeColor = System.Drawing.Color.White;
			this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
			this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReportes.Location = new System.Drawing.Point(-8, -26);
			this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.btnReportes.Size = new System.Drawing.Size(253, 112);
			this.btnReportes.TabIndex = 2;
			this.btnReportes.Text = "Reportes";
			this.btnReportes.UseVisualStyleBackColor = false;
			this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click_1);
			// 
			// transicionOfertas
			// 
			this.transicionOfertas.Interval = 10;
			this.transicionOfertas.Tick += new System.EventHandler(this.transicionOfertas_Tick);
			// 
			// transcionMenu
			// 
			this.transcionMenu.Interval = 10;
			this.transcionMenu.Tick += new System.EventHandler(this.transcionMenu_Tick);
			// 
			// ofertadiesel
			// 
			this.ofertadiesel.AutoSize = true;
			this.ofertadiesel.ForeColor = System.Drawing.Color.White;
			this.ofertadiesel.Location = new System.Drawing.Point(78, 48);
			this.ofertadiesel.Name = "ofertadiesel";
			this.ofertadiesel.Size = new System.Drawing.Size(0, 16);
			this.ofertadiesel.TabIndex = 3;
			// 
			// ofertasuper
			// 
			this.ofertasuper.AutoSize = true;
			this.ofertasuper.ForeColor = System.Drawing.Color.White;
			this.ofertasuper.Location = new System.Drawing.Point(66, 53);
			this.ofertasuper.Name = "ofertasuper";
			this.ofertasuper.Size = new System.Drawing.Size(0, 16);
			this.ofertasuper.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1022, 542);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			this.panelMenu.ResumeLayout(false);
			this.pnlSistema.ResumeLayout(false);
			this.pnlServicio.ResumeLayout(false);
			this.pnlOffers.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.pnlReportes.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label labelTitulo;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Panel pnlServicio;
        private System.Windows.Forms.Panel pnlSistema;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel pnlOffers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer transicionOfertas;
        private System.Windows.Forms.Timer transcionMenu;
		private System.Windows.Forms.Label ofertadiesel;
		private System.Windows.Forms.Label ofertasuper;
	}
}

