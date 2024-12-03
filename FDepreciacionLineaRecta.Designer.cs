namespace GuiaLaboratorio2
{
    partial class FDepreciacionLineaRecta
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
            this.txtbCosto = new System.Windows.Forms.TextBox();
            this.txtbValorRescate = new System.Windows.Forms.TextBox();
            this.txtbVidaUtil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDepreciacion = new System.Windows.Forms.Button();
            this.txtbDepre = new System.Windows.Forms.TextBox();
            this.txtbValorFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbCosto
            // 
            this.txtbCosto.Location = new System.Drawing.Point(66, 91);
            this.txtbCosto.Name = "txtbCosto";
            this.txtbCosto.Size = new System.Drawing.Size(106, 20);
            this.txtbCosto.TabIndex = 0;
            // 
            // txtbValorRescate
            // 
            this.txtbValorRescate.Location = new System.Drawing.Point(66, 184);
            this.txtbValorRescate.Name = "txtbValorRescate";
            this.txtbValorRescate.Size = new System.Drawing.Size(103, 20);
            this.txtbValorRescate.TabIndex = 1;
            // 
            // txtbVidaUtil
            // 
            this.txtbVidaUtil.Location = new System.Drawing.Point(72, 269);
            this.txtbVidaUtil.Name = "txtbVidaUtil";
            this.txtbVidaUtil.Size = new System.Drawing.Size(104, 20);
            this.txtbVidaUtil.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costo Activo Fijo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de Rescate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vida Util";
            // 
            // btnDepreciacion
            // 
            this.btnDepreciacion.Location = new System.Drawing.Point(344, 155);
            this.btnDepreciacion.Name = "btnDepreciacion";
            this.btnDepreciacion.Size = new System.Drawing.Size(134, 49);
            this.btnDepreciacion.TabIndex = 6;
            this.btnDepreciacion.Text = "Depreciacion";
            this.btnDepreciacion.UseVisualStyleBackColor = true;
            this.btnDepreciacion.Click += new System.EventHandler(this.btnDepreciacion_Click);
            // 
            // txtbDepre
            // 
            this.txtbDepre.Location = new System.Drawing.Point(527, 108);
            this.txtbDepre.Name = "txtbDepre";
            this.txtbDepre.Size = new System.Drawing.Size(100, 20);
            this.txtbDepre.TabIndex = 7;
            // 
            // txtbValorFinal
            // 
            this.txtbValorFinal.Location = new System.Drawing.Point(527, 246);
            this.txtbValorFinal.Name = "txtbValorFinal";
            this.txtbValorFinal.Size = new System.Drawing.Size(100, 20);
            this.txtbValorFinal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Depreciacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Final";
            // 
            // FDepreciacionLineaRecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaLaboratorio2.Properties.Resources._05c104253cd8ed7261c0643a7b658e22;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbValorFinal);
            this.Controls.Add(this.txtbDepre);
            this.Controls.Add(this.btnDepreciacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbVidaUtil);
            this.Controls.Add(this.txtbValorRescate);
            this.Controls.Add(this.txtbCosto);
            this.Name = "FDepreciacionLineaRecta";
            this.Text = "FDepreciacionLineaRecta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbCosto;
        private System.Windows.Forms.TextBox txtbValorRescate;
        private System.Windows.Forms.TextBox txtbVidaUtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepreciacion;
        private System.Windows.Forms.TextBox txtbDepre;
        private System.Windows.Forms.TextBox txtbValorFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}