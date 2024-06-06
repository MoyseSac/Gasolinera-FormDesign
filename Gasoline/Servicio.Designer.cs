namespace Gasoline
{
    partial class Servicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicio));
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAmbas = new System.Windows.Forms.RadioButton();
			this.btnSuper = new System.Windows.Forms.RadioButton();
			this.btnDiesel = new System.Windows.Forms.RadioButton();
			this.Nombre = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cantGasolina = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblHora = new System.Windows.Forms.Label();
			this.Tiempo = new System.Windows.Forms.Timer(this.components);
			this.btnLLena = new System.Windows.Forms.RadioButton();
			this.btnPersonalizada = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnPagar = new ReaLTaiizor.Controls.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnCalculo = new ReaLTaiizor.Controls.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM10";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAmbas);
			this.groupBox1.Controls.Add(this.btnSuper);
			this.groupBox1.Controls.Add(this.btnDiesel);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(102)))));
			this.groupBox1.Location = new System.Drawing.Point(43, 166);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(201, 115);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo Gasolina";
			// 
			// btnAmbas
			// 
			this.btnAmbas.AutoSize = true;
			this.btnAmbas.ForeColor = System.Drawing.Color.White;
			this.btnAmbas.Location = new System.Drawing.Point(7, 77);
			this.btnAmbas.Name = "btnAmbas";
			this.btnAmbas.Size = new System.Drawing.Size(149, 27);
			this.btnAmbas.TabIndex = 15;
			this.btnAmbas.TabStop = true;
			this.btnAmbas.Text = "Ambas bombas";
			this.btnAmbas.UseVisualStyleBackColor = true;
			this.btnAmbas.CheckedChanged += new System.EventHandler(this.btnAmbas_CheckedChanged);
			// 
			// btnSuper
			// 
			this.btnSuper.AutoSize = true;
			this.btnSuper.ForeColor = System.Drawing.Color.White;
			this.btnSuper.Location = new System.Drawing.Point(7, 53);
			this.btnSuper.Name = "btnSuper";
			this.btnSuper.Size = new System.Drawing.Size(75, 27);
			this.btnSuper.TabIndex = 15;
			this.btnSuper.TabStop = true;
			this.btnSuper.Text = "Super";
			this.btnSuper.UseVisualStyleBackColor = true;
			this.btnSuper.CheckedChanged += new System.EventHandler(this.btnSuper_CheckedChanged);
			// 
			// btnDiesel
			// 
			this.btnDiesel.AutoSize = true;
			this.btnDiesel.ForeColor = System.Drawing.Color.White;
			this.btnDiesel.Location = new System.Drawing.Point(6, 29);
			this.btnDiesel.Name = "btnDiesel";
			this.btnDiesel.Size = new System.Drawing.Size(76, 27);
			this.btnDiesel.TabIndex = 15;
			this.btnDiesel.TabStop = true;
			this.btnDiesel.Text = "Diesel";
			this.btnDiesel.UseVisualStyleBackColor = true;
			this.btnDiesel.CheckedChanged += new System.EventHandler(this.btnDiesel_CheckedChanged);
			// 
			// Nombre
			// 
			this.Nombre.AutoSize = true;
			this.Nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(102)))));
			this.Nombre.Location = new System.Drawing.Point(45, 34);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(73, 23);
			this.Nombre.TabIndex = 11;
			this.Nombre.Text = "Nombre";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(43, 69);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(156, 27);
			this.txtName.TabIndex = 12;
			// 
			// cantGasolina
			// 
			this.cantGasolina.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cantGasolina.Location = new System.Drawing.Point(153, 50);
			this.cantGasolina.Name = "cantGasolina";
			this.cantGasolina.Size = new System.Drawing.Size(145, 27);
			this.cantGasolina.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(102)))));
			this.label1.Location = new System.Drawing.Point(332, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Nit";
			// 
			// txtNit
			// 
			this.txtNit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNit.Location = new System.Drawing.Point(336, 69);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(142, 27);
			this.txtNit.TabIndex = 16;
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.White;
			this.lblFecha.Location = new System.Drawing.Point(755, 9);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(33, 20);
			this.lblFecha.TabIndex = 17;
			this.lblFecha.Text = "----";
			// 
			// lblHora
			// 
			this.lblHora.AutoSize = true;
			this.lblHora.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblHora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.ForeColor = System.Drawing.Color.White;
			this.lblHora.Location = new System.Drawing.Point(761, 41);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(27, 20);
			this.lblHora.TabIndex = 18;
			this.lblHora.Text = "---";
			// 
			// Tiempo
			// 
			this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
			// 
			// btnLLena
			// 
			this.btnLLena.AutoSize = true;
			this.btnLLena.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLLena.ForeColor = System.Drawing.Color.White;
			this.btnLLena.Location = new System.Drawing.Point(6, 21);
			this.btnLLena.Name = "btnLLena";
			this.btnLLena.Size = new System.Drawing.Size(66, 24);
			this.btnLLena.TabIndex = 19;
			this.btnLLena.TabStop = true;
			this.btnLLena.Text = "Llena";
			this.btnLLena.UseVisualStyleBackColor = true;
			this.btnLLena.CheckedChanged += new System.EventHandler(this.btnLLena_CheckedChanged);
			// 
			// btnPersonalizada
			// 
			this.btnPersonalizada.AutoSize = true;
			this.btnPersonalizada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPersonalizada.ForeColor = System.Drawing.Color.White;
			this.btnPersonalizada.Location = new System.Drawing.Point(6, 51);
			this.btnPersonalizada.Name = "btnPersonalizada";
			this.btnPersonalizada.Size = new System.Drawing.Size(88, 24);
			this.btnPersonalizada.TabIndex = 20;
			this.btnPersonalizada.TabStop = true;
			this.btnPersonalizada.Text = "Prepago";
			this.btnPersonalizada.UseVisualStyleBackColor = true;
			this.btnPersonalizada.CheckedChanged += new System.EventHandler(this.btnPersonalizada_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnLLena);
			this.groupBox2.Controls.Add(this.btnPersonalizada);
			this.groupBox2.Controls.Add(this.cantGasolina);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(102)))));
			this.groupBox2.Location = new System.Drawing.Point(336, 170);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(322, 111);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cantidad gasolina";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(102)))));
			this.label2.Location = new System.Drawing.Point(40, 383);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Total :";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(96, 387);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(33, 20);
			this.lblTotal.TabIndex = 23;
			this.lblTotal.Text = "----";
			// 
			// btnPagar
			// 
			this.btnPagar.BackColor = System.Drawing.Color.Transparent;
			this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPagar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPagar.Image = null;
			this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPagar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnPagar.Location = new System.Drawing.Point(642, 383);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btnPagar.Size = new System.Drawing.Size(120, 40);
			this.btnPagar.TabIndex = 24;
			this.btnPagar.Text = "Pagar";
			this.btnPagar.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(717, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 19);
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Location = new System.Drawing.Point(1, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 35);
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// btnCalculo
			// 
			this.btnCalculo.BackColor = System.Drawing.Color.Transparent;
			this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalculo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnCalculo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalculo.Image = null;
			this.btnCalculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalculo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnCalculo.Location = new System.Drawing.Point(43, 326);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btnCalculo.Size = new System.Drawing.Size(201, 40);
			this.btnCalculo.TabIndex = 27;
			this.btnCalculo.Text = "Calcular precio";
			this.btnCalculo.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
			// 
			// Servicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCalculo);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblHora);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.txtNit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Servicio";
			this.Text = "  ";
			this.Load += new System.EventHandler(this.Servicio_load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox cantGasolina;
        private System.Windows.Forms.RadioButton btnAmbas;
        private System.Windows.Forms.RadioButton btnSuper;
        private System.Windows.Forms.RadioButton btnDiesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.RadioButton btnLLena;
        private System.Windows.Forms.RadioButton btnPersonalizada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private ReaLTaiizor.Controls.Button btnPagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
		private ReaLTaiizor.Controls.Button btnCalculo;
	}
}