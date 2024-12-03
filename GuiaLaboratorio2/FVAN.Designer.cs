namespace GuiaLaboratorio2
{
    partial class FVAN
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
            this.txtbNaños = new System.Windows.Forms.TextBox();
            this.btnGenerartabla = new System.Windows.Forms.Button();
            this.dgvTablaFlujo = new System.Windows.Forms.DataGridView();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlujoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbInversion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbTasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbVAN = new System.Windows.Forms.TextBox();
            this.txtbTIR = new System.Windows.Forms.TextBox();
            this.btnVAN = new System.Windows.Forms.Button();
            this.btnTIR = new System.Windows.Forms.Button();
            this.btnPayback = new System.Windows.Forms.Button();
            this.txtbPayback = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFlujo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNaños
            // 
            this.txtbNaños.Location = new System.Drawing.Point(43, 61);
            this.txtbNaños.Name = "txtbNaños";
            this.txtbNaños.Size = new System.Drawing.Size(100, 20);
            this.txtbNaños.TabIndex = 0;
            // 
            // btnGenerartabla
            // 
            this.btnGenerartabla.Location = new System.Drawing.Point(172, 38);
            this.btnGenerartabla.Name = "btnGenerartabla";
            this.btnGenerartabla.Size = new System.Drawing.Size(76, 43);
            this.btnGenerartabla.TabIndex = 1;
            this.btnGenerartabla.Text = "Generar tabla";
            this.btnGenerartabla.UseVisualStyleBackColor = true;
            this.btnGenerartabla.Click += new System.EventHandler(this.btnGenerartabla_Click);
            // 
            // dgvTablaFlujo
            // 
            this.dgvTablaFlujo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaFlujo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.FlujoNeto});
            this.dgvTablaFlujo.Location = new System.Drawing.Point(30, 113);
            this.dgvTablaFlujo.Name = "dgvTablaFlujo";
            this.dgvTablaFlujo.Size = new System.Drawing.Size(245, 243);
            this.dgvTablaFlujo.TabIndex = 2;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // FlujoNeto
            // 
            this.FlujoNeto.HeaderText = "Flujo Neto";
            this.FlujoNeto.Name = "FlujoNeto";
            // 
            // txtbInversion
            // 
            this.txtbInversion.Location = new System.Drawing.Point(330, 62);
            this.txtbInversion.Name = "txtbInversion";
            this.txtbInversion.Size = new System.Drawing.Size(81, 20);
            this.txtbInversion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inversion Inicial";
            // 
            // txtbTasa
            // 
            this.txtbTasa.Location = new System.Drawing.Point(330, 145);
            this.txtbTasa.Name = "txtbTasa";
            this.txtbTasa.Size = new System.Drawing.Size(100, 20);
            this.txtbTasa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tasa de interes %";
            // 
            // txtbVAN
            // 
            this.txtbVAN.Location = new System.Drawing.Point(547, 96);
            this.txtbVAN.Name = "txtbVAN";
            this.txtbVAN.Size = new System.Drawing.Size(103, 20);
            this.txtbVAN.TabIndex = 7;
            // 
            // txtbTIR
            // 
            this.txtbTIR.Location = new System.Drawing.Point(550, 213);
            this.txtbTIR.Name = "txtbTIR";
            this.txtbTIR.Size = new System.Drawing.Size(100, 20);
            this.txtbTIR.TabIndex = 9;
            // 
            // btnVAN
            // 
            this.btnVAN.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVAN.Location = new System.Drawing.Point(536, 53);
            this.btnVAN.Name = "btnVAN";
            this.btnVAN.Size = new System.Drawing.Size(124, 34);
            this.btnVAN.TabIndex = 11;
            this.btnVAN.Text = "Hallar VAN";
            this.btnVAN.UseVisualStyleBackColor = false;
            this.btnVAN.Click += new System.EventHandler(this.btnVAN_Click);
            // 
            // btnTIR
            // 
            this.btnTIR.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTIR.Location = new System.Drawing.Point(547, 161);
            this.btnTIR.Name = "btnTIR";
            this.btnTIR.Size = new System.Drawing.Size(103, 34);
            this.btnTIR.TabIndex = 12;
            this.btnTIR.Text = "Hallar TIR";
            this.btnTIR.UseVisualStyleBackColor = false;
            this.btnTIR.Click += new System.EventHandler(this.btnTIR_Click_1);
            // 
            // btnPayback
            // 
            this.btnPayback.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPayback.Location = new System.Drawing.Point(536, 283);
            this.btnPayback.Name = "btnPayback";
            this.btnPayback.Size = new System.Drawing.Size(114, 33);
            this.btnPayback.TabIndex = 13;
            this.btnPayback.Text = "Hallar Payback";
            this.btnPayback.UseVisualStyleBackColor = false;
            this.btnPayback.Click += new System.EventHandler(this.btnPayback_Click);
            // 
            // txtbPayback
            // 
            this.txtbPayback.Location = new System.Drawing.Point(550, 322);
            this.txtbPayback.Name = "txtbPayback";
            this.txtbPayback.Size = new System.Drawing.Size(100, 20);
            this.txtbPayback.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Numero de años";
            // 
            // FVAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaLaboratorio2.Properties.Resources._05c104253cd8ed7261c0643a7b658e22;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbPayback);
            this.Controls.Add(this.btnPayback);
            this.Controls.Add(this.btnTIR);
            this.Controls.Add(this.btnVAN);
            this.Controls.Add(this.txtbTIR);
            this.Controls.Add(this.txtbVAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbTasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbInversion);
            this.Controls.Add(this.dgvTablaFlujo);
            this.Controls.Add(this.btnGenerartabla);
            this.Controls.Add(this.txtbNaños);
            this.Name = "FVAN";
            this.Text = "FVAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFlujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNaños;
        private System.Windows.Forms.Button btnGenerartabla;
        private System.Windows.Forms.DataGridView dgvTablaFlujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlujoNeto;
        private System.Windows.Forms.TextBox txtbInversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbTasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbVAN;
        private System.Windows.Forms.TextBox txtbTIR;
        private System.Windows.Forms.Button btnVAN;
        private System.Windows.Forms.Button btnTIR;
        private System.Windows.Forms.Button btnPayback;
        private System.Windows.Forms.TextBox txtbPayback;
        private System.Windows.Forms.Label label5;
    }
}