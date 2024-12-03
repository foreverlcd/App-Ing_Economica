namespace GuiaLaboratorio2
{
    partial class FGradienteAritmetico
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
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbi = new System.Windows.Forms.TextBox();
            this.txtbn = new System.Windows.Forms.TextBox();
            this.txtbg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVCP = new System.Windows.Forms.Button();
            this.btnVPD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcncuotaCrec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbVPC = new System.Windows.Forms.TextBox();
            this.txtbVPD = new System.Windows.Forms.TextBox();
            this.txtbCNCDn = new System.Windows.Forms.TextBox();
            this.txtbCNCCn = new System.Windows.Forms.TextBox();
            this.txtbNCC = new System.Windows.Forms.TextBox();
            this.txtbNCD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbA
            // 
            this.txtbA.Location = new System.Drawing.Point(48, 115);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(118, 20);
            this.txtbA.TabIndex = 0;
            // 
            // txtbi
            // 
            this.txtbi.Location = new System.Drawing.Point(48, 172);
            this.txtbi.Name = "txtbi";
            this.txtbi.Size = new System.Drawing.Size(118, 20);
            this.txtbi.TabIndex = 1;
            // 
            // txtbn
            // 
            this.txtbn.Location = new System.Drawing.Point(48, 228);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(118, 20);
            this.txtbn.TabIndex = 2;
            // 
            // txtbg
            // 
            this.txtbg.Location = new System.Drawing.Point(48, 296);
            this.txtbg.Name = "txtbg";
            this.txtbg.Size = new System.Drawing.Size(118, 20);
            this.txtbg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor de la primera cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tasa de interes %";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero de pagos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constante en que aumenta ";
            // 
            // btnVCP
            // 
            this.btnVCP.Location = new System.Drawing.Point(28, 36);
            this.btnVCP.Name = "btnVCP";
            this.btnVCP.Size = new System.Drawing.Size(181, 42);
            this.btnVCP.TabIndex = 10;
            this.btnVCP.Text = "Valor Presente Creciente";
            this.btnVCP.UseVisualStyleBackColor = true;
            this.btnVCP.Click += new System.EventHandler(this.btnVCP_Click);
            // 
            // btnVPD
            // 
            this.btnVPD.Location = new System.Drawing.Point(28, 19);
            this.btnVPD.Name = "btnVPD";
            this.btnVPD.Size = new System.Drawing.Size(175, 46);
            this.btnVPD.TabIndex = 11;
            this.btnVPD.Text = "Valor Presente Decreciente";
            this.btnVPD.UseVisualStyleBackColor = true;
            this.btnVPD.Click += new System.EventHandler(this.btnVPD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "o disminuye cada cuota";
            // 
            // btnCalcncuotaCrec
            // 
            this.btnCalcncuotaCrec.Location = new System.Drawing.Point(33, 86);
            this.btnCalcncuotaCrec.Name = "btnCalcncuotaCrec";
            this.btnCalcncuotaCrec.Size = new System.Drawing.Size(157, 38);
            this.btnCalcncuotaCrec.TabIndex = 13;
            this.btnCalcncuotaCrec.Text = "Calucular n-esima cuota";
            this.btnCalcncuotaCrec.UseVisualStyleBackColor = true;
            this.btnCalcncuotaCrec.Click += new System.EventHandler(this.btnCalcncuotaCrec_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calcular n-esima cuota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbVPC
            // 
            this.txtbVPC.Location = new System.Drawing.Point(231, 48);
            this.txtbVPC.Name = "txtbVPC";
            this.txtbVPC.Size = new System.Drawing.Size(103, 20);
            this.txtbVPC.TabIndex = 15;
            // 
            // txtbVPD
            // 
            this.txtbVPD.Location = new System.Drawing.Point(234, 33);
            this.txtbVPD.Name = "txtbVPD";
            this.txtbVPD.Size = new System.Drawing.Size(100, 20);
            this.txtbVPD.TabIndex = 16;
            // 
            // txtbCNCDn
            // 
            this.txtbCNCDn.Location = new System.Drawing.Point(63, 139);
            this.txtbCNCDn.Name = "txtbCNCDn";
            this.txtbCNCDn.Size = new System.Drawing.Size(100, 20);
            this.txtbCNCDn.TabIndex = 17;
            // 
            // txtbCNCCn
            // 
            this.txtbCNCCn.Location = new System.Drawing.Point(63, 147);
            this.txtbCNCCn.Name = "txtbCNCCn";
            this.txtbCNCCn.Size = new System.Drawing.Size(100, 20);
            this.txtbCNCCn.TabIndex = 18;
            // 
            // txtbNCC
            // 
            this.txtbNCC.Location = new System.Drawing.Point(234, 95);
            this.txtbNCC.Name = "txtbNCC";
            this.txtbNCC.Size = new System.Drawing.Size(100, 20);
            this.txtbNCC.TabIndex = 19;
            // 
            // txtbNCD
            // 
            this.txtbNCD.Location = new System.Drawing.Point(234, 96);
            this.txtbNCD.Name = "txtbNCD";
            this.txtbNCD.Size = new System.Drawing.Size(100, 20);
            this.txtbNCD.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "n:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "n:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbNCC);
            this.groupBox1.Controls.Add(this.txtbCNCCn);
            this.groupBox1.Controls.Add(this.txtbVPC);
            this.groupBox1.Controls.Add(this.btnCalcncuotaCrec);
            this.groupBox1.Controls.Add(this.btnVCP);
            this.groupBox1.Location = new System.Drawing.Point(294, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 195);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRADIENTE CRECIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbNCD);
            this.groupBox2.Controls.Add(this.txtbCNCDn);
            this.groupBox2.Controls.Add(this.txtbVPD);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnVPD);
            this.groupBox2.Location = new System.Drawing.Point(294, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 183);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRADIENTE DECRECIENTE";
            // 
            // FGradienteAritmetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaLaboratorio2.Properties.Resources._05c104253cd8ed7261c0643a7b658e22;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbg);
            this.Controls.Add(this.txtbn);
            this.Controls.Add(this.txtbi);
            this.Controls.Add(this.txtbA);
            this.Name = "FGradienteAritmetico";
            this.Text = "FGradienteAritmetico";
            this.Load += new System.EventHandler(this.FGradienteAritmetico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbi;
        private System.Windows.Forms.TextBox txtbn;
        private System.Windows.Forms.TextBox txtbg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVCP;
        private System.Windows.Forms.Button btnVPD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcncuotaCrec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbVPC;
        private System.Windows.Forms.TextBox txtbVPD;
        private System.Windows.Forms.TextBox txtbCNCDn;
        private System.Windows.Forms.TextBox txtbCNCCn;
        private System.Windows.Forms.TextBox txtbNCC;
        private System.Windows.Forms.TextBox txtbNCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}