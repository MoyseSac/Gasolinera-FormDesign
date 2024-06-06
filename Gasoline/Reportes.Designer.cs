namespace Gasoline
{
    partial class Reportes
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
			this.dataCierre = new System.Windows.Forms.DataGridView();
			this.dataPrepago = new System.Windows.Forms.DataGridView();
			this.dataLlenado = new System.Windows.Forms.DataGridView();
			this.btnMostrar = new ReaLTaiizor.Controls.NightButton();
			this.lblMasUsado = new System.Windows.Forms.Label();
			this.lblMenosUsado = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataCierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPrepago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLlenado)).BeginInit();
			this.SuspendLayout();
			// 
			// dataCierre
			// 
			this.dataCierre.BackgroundColor = System.Drawing.Color.White;
			this.dataCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataCierre.Location = new System.Drawing.Point(63, 44);
			this.dataCierre.Name = "dataCierre";
			this.dataCierre.RowHeadersWidth = 51;
			this.dataCierre.RowTemplate.Height = 24;
			this.dataCierre.Size = new System.Drawing.Size(608, 150);
			this.dataCierre.TabIndex = 0;
			// 
			// dataPrepago
			// 
			this.dataPrepago.BackgroundColor = System.Drawing.Color.White;
			this.dataPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrepago.Location = new System.Drawing.Point(754, 44);
			this.dataPrepago.Name = "dataPrepago";
			this.dataPrepago.RowHeadersWidth = 51;
			this.dataPrepago.RowTemplate.Height = 24;
			this.dataPrepago.Size = new System.Drawing.Size(528, 150);
			this.dataPrepago.TabIndex = 1;
			// 
			// dataLlenado
			// 
			this.dataLlenado.BackgroundColor = System.Drawing.Color.White;
			this.dataLlenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataLlenado.Location = new System.Drawing.Point(63, 262);
			this.dataLlenado.Name = "dataLlenado";
			this.dataLlenado.RowHeadersWidth = 51;
			this.dataLlenado.RowTemplate.Height = 24;
			this.dataLlenado.Size = new System.Drawing.Size(608, 150);
			this.dataLlenado.TabIndex = 2;
			// 
			// btnMostrar
			// 
			this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
			this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMostrar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
			this.btnMostrar.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
			this.btnMostrar.HoverForeColor = System.Drawing.Color.White;
			this.btnMostrar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			this.btnMostrar.Location = new System.Drawing.Point(760, 365);
			this.btnMostrar.MinimumSize = new System.Drawing.Size(144, 47);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
			this.btnMostrar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			this.btnMostrar.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
			this.btnMostrar.PressedForeColor = System.Drawing.Color.White;
			this.btnMostrar.Radius = 20;
			this.btnMostrar.Size = new System.Drawing.Size(144, 47);
			this.btnMostrar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			this.btnMostrar.TabIndex = 3;
			this.btnMostrar.Text = "Reportes";
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// lblMasUsado
			// 
			this.lblMasUsado.AutoSize = true;
			this.lblMasUsado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMasUsado.ForeColor = System.Drawing.Color.White;
			this.lblMasUsado.Location = new System.Drawing.Point(750, 262);
			this.lblMasUsado.Name = "lblMasUsado";
			this.lblMasUsado.Size = new System.Drawing.Size(0, 23);
			this.lblMasUsado.TabIndex = 4;
			// 
			// lblMenosUsado
			// 
			this.lblMenosUsado.AutoSize = true;
			this.lblMenosUsado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenosUsado.ForeColor = System.Drawing.Color.White;
			this.lblMenosUsado.Location = new System.Drawing.Point(755, 300);
			this.lblMenosUsado.Name = "lblMenosUsado";
			this.lblMenosUsado.Size = new System.Drawing.Size(0, 23);
			this.lblMenosUsado.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(63, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Reporte de servicio de tanque lleno";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(66, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Reporte de servicio usados";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(756, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Reporte de servicio prepago";
			// 
			// Reportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(1332, 698);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblMenosUsado);
			this.Controls.Add(this.lblMasUsado);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.dataLlenado);
			this.Controls.Add(this.dataPrepago);
			this.Controls.Add(this.dataCierre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Reportes";
			this.Text = "Reportes";
			this.Load += new System.EventHandler(this.Reportes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataCierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPrepago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLlenado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCierre;
        private System.Windows.Forms.DataGridView dataPrepago;
        private System.Windows.Forms.DataGridView dataLlenado;
        private ReaLTaiizor.Controls.NightButton btnMostrar;
        private System.Windows.Forms.Label lblMasUsado;
        private System.Windows.Forms.Label lblMenosUsado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}