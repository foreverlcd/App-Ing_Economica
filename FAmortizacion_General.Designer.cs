﻿namespace GuiaLaboratorio2
{
    partial class FAmortizacion_General
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
            this.label_T_Variable = new System.Windows.Forms.Label();
            this.label_Variable = new System.Windows.Forms.Label();
            this.txbVariable = new System.Windows.Forms.TextBox();
            this.DGVAmortizacion = new System.Windows.Forms.DataGridView();
            this.chrtAmortizacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmortizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAmortizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Stencil", 7F);
            this.btnMostrar.Location = new System.Drawing.Point(81, 581);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(60, 32);
            this.btnMostrar.TabIndex = 38;
            this.btnMostrar.Text = "Mostrar Grafico";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Numero de Periodos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Frecuencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tasa de Interes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prestamo:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalir.Font = new System.Drawing.Font("Stencil", 8.4F);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Location = new System.Drawing.Point(715, 701);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 32);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Stencil", 8.4F);
            this.btnBorrar.Location = new System.Drawing.Point(81, 633);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 32);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAceptar.Font = new System.Drawing.Font("Stencil", 8F);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(81, 528);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 32);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbNroPeriodo
            // 
            this.txbNroPeriodo.Location = new System.Drawing.Point(74, 405);
            this.txbNroPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNroPeriodo.Name = "txbNroPeriodo";
            this.txbNroPeriodo.Size = new System.Drawing.Size(76, 20);
            this.txbNroPeriodo.TabIndex = 25;
            // 
            // txbFrecuencia
            // 
            this.txbFrecuencia.Location = new System.Drawing.Point(74, 333);
            this.txbFrecuencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFrecuencia.Name = "txbFrecuencia";
            this.txbFrecuencia.Size = new System.Drawing.Size(76, 20);
            this.txbFrecuencia.TabIndex = 24;
            // 
            // txbTiempo
            // 
            this.txbTiempo.Location = new System.Drawing.Point(74, 259);
            this.txbTiempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTiempo.Name = "txbTiempo";
            this.txbTiempo.Size = new System.Drawing.Size(76, 20);
            this.txbTiempo.TabIndex = 23;
            // 
            // txbTI
            // 
            this.txbTI.Location = new System.Drawing.Point(74, 187);
            this.txbTI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTI.Name = "txbTI";
            this.txbTI.Size = new System.Drawing.Size(76, 20);
            this.txbTI.TabIndex = 22;
            // 
            // txbPrestamo
            // 
            this.txbPrestamo.Location = new System.Drawing.Point(74, 105);
            this.txbPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrestamo.Name = "txbPrestamo";
            this.txbPrestamo.Size = new System.Drawing.Size(76, 20);
            this.txbPrestamo.TabIndex = 21;
            // 
            // label_T_Variable
            // 
            this.label_T_Variable.AutoSize = true;
            this.label_T_Variable.BackColor = System.Drawing.Color.Transparent;
            this.label_T_Variable.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T_Variable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_T_Variable.Location = new System.Drawing.Point(254, 29);
            this.label_T_Variable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_T_Variable.Name = "label_T_Variable";
            this.label_T_Variable.Size = new System.Drawing.Size(253, 29);
            this.label_T_Variable.TabIndex = 20;
            this.label_T_Variable.Text = "AMORTIZACÍON FRANCESA";
            // 
            // label_Variable
            // 
            this.label_Variable.AutoSize = true;
            this.label_Variable.BackColor = System.Drawing.Color.Transparent;
            this.label_Variable.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Variable.ForeColor = System.Drawing.Color.White;
            this.label_Variable.Location = new System.Drawing.Point(52, 448);
            this.label_Variable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Variable.Name = "label_Variable";
            this.label_Variable.Size = new System.Drawing.Size(97, 18);
            this.label_Variable.TabIndex = 41;
            this.label_Variable.Text = "Cuota Nivelada:";
            // 
            // txbVariable
            // 
            this.txbVariable.Location = new System.Drawing.Point(74, 482);
            this.txbVariable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbVariable.Name = "txbVariable";
            this.txbVariable.Size = new System.Drawing.Size(76, 20);
            this.txbVariable.TabIndex = 40;
            // 
            // DGVAmortizacion
            // 
            this.DGVAmortizacion.ColumnHeadersHeight = 29;
            this.DGVAmortizacion.Location = new System.Drawing.Point(242, 89);
            this.DGVAmortizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVAmortizacion.Name = "DGVAmortizacion";
            this.DGVAmortizacion.RowHeadersWidth = 51;
            this.DGVAmortizacion.Size = new System.Drawing.Size(470, 232);
            this.DGVAmortizacion.TabIndex = 0;
            // 
            // chrtAmortizacion
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAmortizacion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAmortizacion.Legends.Add(legend1);
            this.chrtAmortizacion.Location = new System.Drawing.Point(242, 348);
            this.chrtAmortizacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chrtAmortizacion.Name = "chrtAmortizacion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtAmortizacion.Series.Add(series1);
            this.chrtAmortizacion.Size = new System.Drawing.Size(470, 332);
            this.chrtAmortizacion.TabIndex = 42;
            this.chrtAmortizacion.Text = "chart1";
            this.chrtAmortizacion.Click += new System.EventHandler(this.chrtAmortizacion_Click);
            // 
            // FAmortizacion_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(817, 754);
            this.Controls.Add(this.chrtAmortizacion);
            this.Controls.Add(this.DGVAmortizacion);
            this.Controls.Add(this.label_Variable);
            this.Controls.Add(this.txbVariable);
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
            this.Controls.Add(this.label_T_Variable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FAmortizacion_General";
            this.Text = "FAmortizacion_Frances";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAmortizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAmortizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label_T_Variable;
        private System.Windows.Forms.Label label_Variable;
        private System.Windows.Forms.TextBox txbVariable;
        private System.Windows.Forms.DataGridView DGVAmortizacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAmortizacion;
    }
}