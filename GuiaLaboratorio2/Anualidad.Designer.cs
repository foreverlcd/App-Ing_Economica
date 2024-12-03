namespace GuiaLaboratorio2
{
    partial class Anualidad
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbRenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBPeriodo = new System.Windows.Forms.TextBox();
            this.txtBTasa = new System.Windows.Forms.TextBox();
            this.comboBoxPeriodoPagos = new System.Windows.Forms.ComboBox();
            this.btnValorF = new System.Windows.Forms.Button();
            this.btnValorP = new System.Windows.Forms.Button();
            this.txtbValorFuturo = new System.Windows.Forms.TextBox();
            this.txtBoxValorPresente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(44, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Renta";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txtbRenta
            // 
            this.txtbRenta.Location = new System.Drawing.Point(47, 63);
            this.txtbRenta.Name = "txtbRenta";
            this.txtbRenta.Size = new System.Drawing.Size(93, 20);
            this.txtbRenta.TabIndex = 1;
            this.txtbRenta.TextChanged += new System.EventHandler(this.txtbRenta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duracion (Años)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasa interes % (Anual)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBPeriodo
            // 
            this.txtBPeriodo.Location = new System.Drawing.Point(47, 117);
            this.txtBPeriodo.Name = "txtBPeriodo";
            this.txtBPeriodo.Size = new System.Drawing.Size(125, 20);
            this.txtBPeriodo.TabIndex = 4;
            this.txtBPeriodo.TextChanged += new System.EventHandler(this.txtBPeriodo_TextChanged);
            // 
            // txtBTasa
            // 
            this.txtBTasa.Location = new System.Drawing.Point(50, 251);
            this.txtBTasa.Name = "txtBTasa";
            this.txtBTasa.Size = new System.Drawing.Size(132, 20);
            this.txtBTasa.TabIndex = 5;
            // 
            // comboBoxPeriodoPagos
            // 
            this.comboBoxPeriodoPagos.FormattingEnabled = true;
            this.comboBoxPeriodoPagos.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Trimestral",
            "Semestral"});
            this.comboBoxPeriodoPagos.Location = new System.Drawing.Point(47, 176);
            this.comboBoxPeriodoPagos.Name = "comboBoxPeriodoPagos";
            this.comboBoxPeriodoPagos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodoPagos.TabIndex = 6;
            this.comboBoxPeriodoPagos.Text = "Periodo de Pagos";
            this.comboBoxPeriodoPagos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriodoPagos_SelectedIndexChanged);
            // 
            // btnValorF
            // 
            this.btnValorF.Location = new System.Drawing.Point(332, 67);
            this.btnValorF.Name = "btnValorF";
            this.btnValorF.Size = new System.Drawing.Size(159, 69);
            this.btnValorF.TabIndex = 7;
            this.btnValorF.Text = "Valor Futuro";
            this.btnValorF.UseVisualStyleBackColor = true;
            this.btnValorF.Click += new System.EventHandler(this.btnValorF_Click);
            // 
            // btnValorP
            // 
            this.btnValorP.Location = new System.Drawing.Point(332, 233);
            this.btnValorP.Name = "btnValorP";
            this.btnValorP.Size = new System.Drawing.Size(159, 72);
            this.btnValorP.TabIndex = 8;
            this.btnValorP.Text = "Valor Presente";
            this.btnValorP.UseVisualStyleBackColor = true;
            this.btnValorP.Click += new System.EventHandler(this.btnValorP_Click);
            // 
            // txtbValorFuturo
            // 
            this.txtbValorFuturo.Enabled = false;
            this.txtbValorFuturo.Location = new System.Drawing.Point(563, 88);
            this.txtbValorFuturo.Name = "txtbValorFuturo";
            this.txtbValorFuturo.Size = new System.Drawing.Size(119, 20);
            this.txtbValorFuturo.TabIndex = 9;
            this.txtbValorFuturo.TextChanged += new System.EventHandler(this.txtbValorFuturo_TextChanged);
            // 
            // txtBoxValorPresente
            // 
            this.txtBoxValorPresente.Enabled = false;
            this.txtBoxValorPresente.Location = new System.Drawing.Point(557, 254);
            this.txtBoxValorPresente.Name = "txtBoxValorPresente";
            this.txtBoxValorPresente.Size = new System.Drawing.Size(138, 20);
            this.txtBoxValorPresente.TabIndex = 10;
            this.txtBoxValorPresente.TextChanged += new System.EventHandler(this.txtBoxValorPresente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor Presente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor Futuro";
            // 
            // Anualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaLaboratorio2.Properties.Resources._05c104253cd8ed7261c0643a7b658e22;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxValorPresente);
            this.Controls.Add(this.txtbValorFuturo);
            this.Controls.Add(this.btnValorP);
            this.Controls.Add(this.btnValorF);
            this.Controls.Add(this.comboBoxPeriodoPagos);
            this.Controls.Add(this.txtBTasa);
            this.Controls.Add(this.txtBPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbRenta);
            this.Controls.Add(this.lbl1);
            this.Name = "Anualidad";
            this.Text = "Anualidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbRenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBPeriodo;
        private System.Windows.Forms.TextBox txtBTasa;
        private System.Windows.Forms.ComboBox comboBoxPeriodoPagos;
        private System.Windows.Forms.Button btnValorF;
        private System.Windows.Forms.Button btnValorP;
        private System.Windows.Forms.TextBox txtbValorFuturo;
        private System.Windows.Forms.TextBox txtBoxValorPresente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}