﻿namespace GuiaLaboratorio2
{
    partial class FSeleccionAmortizacion
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
            this.cmbTiposAmortizaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTiposAmortizaciones
            // 
            this.cmbTiposAmortizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposAmortizaciones.FormattingEnabled = true;
            this.cmbTiposAmortizaciones.Items.AddRange(new object[] {
            "Francesa",
            "Alemana",
            "Americano"});
            this.cmbTiposAmortizaciones.Location = new System.Drawing.Point(202, 40);
            this.cmbTiposAmortizaciones.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiposAmortizaciones.Name = "cmbTiposAmortizaciones";
            this.cmbTiposAmortizaciones.Size = new System.Drawing.Size(106, 24);
            this.cmbTiposAmortizaciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Amortizacion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(202, 82);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 25);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FSeleccionAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 127);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTiposAmortizaciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSeleccionAmortizacion";
            this.Text = "FSeleccionAmortizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTiposAmortizaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}