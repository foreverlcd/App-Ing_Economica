namespace GuiaLaboratorio2
{
    partial class FAmortizacion_Alemana
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtAmortizacion_Francesa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DGVAmortizacionFrancesa = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCuota = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbNroPeriodo = new System.Windows.Forms.TextBox();
            this.txbFrecuencia = new System.Windows.Forms.TextBox();
            this.txbTiempo = new System.Windows.Forms.TextBox();
            this.txbTI = new System.Windows.Forms.TextBox();
            this.txbPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAmortizacion_Francesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmortizacionFrancesa)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtAmortizacion_Francesa
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAmortizacion_Francesa.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAmortizacion_Francesa.Legends.Add(legend1);
            this.chrtAmortizacion_Francesa.Location = new System.Drawing.Point(221, 353);
            this.chrtAmortizacion_Francesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chrtAmortizacion_Francesa.Name = "chrtAmortizacion_Francesa";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtAmortizacion_Francesa.Series.Add(series1);
            this.chrtAmortizacion_Francesa.Size = new System.Drawing.Size(470, 332);
            this.chrtAmortizacion_Francesa.TabIndex = 61;
            this.chrtAmortizacion_Francesa.Text = "chart1";
            // 
            // DGVAmortizacionFrancesa
            // 
            this.DGVAmortizacionFrancesa.ColumnHeadersHeight = 29;
            this.DGVAmortizacionFrancesa.Location = new System.Drawing.Point(221, 93);
            this.DGVAmortizacionFrancesa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVAmortizacionFrancesa.Name = "DGVAmortizacionFrancesa";
            this.DGVAmortizacionFrancesa.RowHeadersWidth = 51;
            this.DGVAmortizacionFrancesa.Size = new System.Drawing.Size(470, 232);
            this.DGVAmortizacionFrancesa.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Cuota Nivelada:";
            // 
            // txbCuota
            // 
            this.txbCuota.Location = new System.Drawing.Point(54, 487);
            this.txbCuota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCuota.Name = "txbCuota";
            this.txbCuota.Size = new System.Drawing.Size(76, 20);
            this.txbCuota.TabIndex = 59;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Stencil", 7F);
            this.btnMostrar.Location = new System.Drawing.Point(61, 586);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(60, 32);
            this.btnMostrar.TabIndex = 58;
            this.btnMostrar.Text = "Mostrar Grafico";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 376);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Numero de Periodos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Frecuencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tasa de Interes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Prestamo:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalir.Font = new System.Drawing.Font("Stencil", 8.4F);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Location = new System.Drawing.Point(694, 706);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 32);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Stencil", 8.4F);
            this.btnBorrar.Location = new System.Drawing.Point(61, 638);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 32);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAceptar.Font = new System.Drawing.Font("Stencil", 8F);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(61, 533);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 32);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbNroPeriodo
            // 
            this.txbNroPeriodo.Location = new System.Drawing.Point(54, 410);
            this.txbNroPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNroPeriodo.Name = "txbNroPeriodo";
            this.txbNroPeriodo.Size = new System.Drawing.Size(76, 20);
            this.txbNroPeriodo.TabIndex = 49;
            // 
            // txbFrecuencia
            // 
            this.txbFrecuencia.Location = new System.Drawing.Point(54, 338);
            this.txbFrecuencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFrecuencia.Name = "txbFrecuencia";
            this.txbFrecuencia.Size = new System.Drawing.Size(76, 20);
            this.txbFrecuencia.TabIndex = 48;
            // 
            // txbTiempo
            // 
            this.txbTiempo.Location = new System.Drawing.Point(54, 264);
            this.txbTiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTiempo.Name = "txbTiempo";
            this.txbTiempo.Size = new System.Drawing.Size(76, 20);
            this.txbTiempo.TabIndex = 47;
            // 
            // txbTI
            // 
            this.txbTI.Location = new System.Drawing.Point(54, 192);
            this.txbTI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTI.Name = "txbTI";
            this.txbTI.Size = new System.Drawing.Size(76, 20);
            this.txbTI.TabIndex = 46;
            // 
            // txbPrestamo
            // 
            this.txbPrestamo.Location = new System.Drawing.Point(54, 110);
            this.txbPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrestamo.Name = "txbPrestamo";
            this.txbPrestamo.Size = new System.Drawing.Size(76, 20);
            this.txbPrestamo.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(233, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "AMORTIZACÍON FRANCESA";
            // 
            // FAmortizacion_Alemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 772);
            this.Controls.Add(this.chrtAmortizacion_Francesa);
            this.Controls.Add(this.DGVAmortizacionFrancesa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCuota);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbNroPeriodo);
            this.Controls.Add(this.txbFrecuencia);
            this.Controls.Add(this.txbTiempo);
            this.Controls.Add(this.txbTI);
            this.Controls.Add(this.txbPrestamo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FAmortizacion_Alemana";
            this.Text = "FAmortizacion_Alemana";
            ((System.ComponentModel.ISupportInitialize)(this.chrtAmortizacion_Francesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmortizacionFrancesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAmortizacion_Francesa;
        private System.Windows.Forms.DataGridView DGVAmortizacionFrancesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCuota;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbNroPeriodo;
        private System.Windows.Forms.TextBox txbFrecuencia;
        private System.Windows.Forms.TextBox txbTiempo;
        private System.Windows.Forms.TextBox txbTI;
        private System.Windows.Forms.TextBox txbPrestamo;
        private System.Windows.Forms.Label label1;
    }
}