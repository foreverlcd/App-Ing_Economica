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
            this.txtbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbA.Location = new System.Drawing.Point(46, 107);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(118, 24);
            this.txtbA.TabIndex = 0;
            // 
            // txtbi
            // 
            this.txtbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbi.Location = new System.Drawing.Point(46, 171);
            this.txtbi.Name = "txtbi";
            this.txtbi.Size = new System.Drawing.Size(118, 24);
            this.txtbi.TabIndex = 1;
            // 
            // txtbn
            // 
            this.txtbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbn.Location = new System.Drawing.Point(46, 235);
            this.txtbn.Name = "txtbn";
            this.txtbn.Size = new System.Drawing.Size(118, 24);
            this.txtbn.TabIndex = 2;
            // 
            // txtbg
            // 
            this.txtbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbg.Location = new System.Drawing.Point(46, 322);
            this.txtbg.Name = "txtbg";
            this.txtbg.Size = new System.Drawing.Size(118, 24);
            this.txtbg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor de la primera cuota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tasa de interes %";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero de pagos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constante en que aumenta ";
            // 
            // btnVCP
            // 
            this.btnVCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVCP.Location = new System.Drawing.Point(33, 36);
            this.btnVCP.Name = "btnVCP";
            this.btnVCP.Size = new System.Drawing.Size(176, 48);
            this.btnVCP.TabIndex = 10;
            this.btnVCP.Text = "Valor Presente Creciente";
            this.btnVCP.UseVisualStyleBackColor = true;
            this.btnVCP.Click += new System.EventHandler(this.btnVCP_Click);
            // 
            // btnVPD
            // 
            this.btnVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVPD.Location = new System.Drawing.Point(33, 32);
            this.btnVPD.Name = "btnVPD";
            this.btnVPD.Size = new System.Drawing.Size(176, 46);
            this.btnVPD.TabIndex = 11;
            this.btnVPD.Text = "Valor Presente Decreciente";
            this.btnVPD.UseVisualStyleBackColor = true;
            this.btnVPD.Click += new System.EventHandler(this.btnVPD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "o disminuye cada cuota";
            // 
            // btnCalcncuotaCrec
            // 
            this.btnCalcncuotaCrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcncuotaCrec.Location = new System.Drawing.Point(33, 86);
            this.btnCalcncuotaCrec.Name = "btnCalcncuotaCrec";
            this.btnCalcncuotaCrec.Size = new System.Drawing.Size(176, 38);
            this.btnCalcncuotaCrec.TabIndex = 13;
            this.btnCalcncuotaCrec.Text = "Calucular n-esima cuota";
            this.btnCalcncuotaCrec.UseVisualStyleBackColor = true;
            this.btnCalcncuotaCrec.Click += new System.EventHandler(this.btnCalcncuotaCrec_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calcular n-esima cuota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbVPC
            // 
            this.txtbVPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVPC.Location = new System.Drawing.Point(234, 48);
            this.txtbVPC.Name = "txtbVPC";
            this.txtbVPC.Size = new System.Drawing.Size(100, 22);
            this.txtbVPC.TabIndex = 15;
            // 
            // txtbVPD
            // 
            this.txtbVPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVPD.Location = new System.Drawing.Point(234, 33);
            this.txtbVPD.Name = "txtbVPD";
            this.txtbVPD.Size = new System.Drawing.Size(100, 22);
            this.txtbVPD.TabIndex = 16;
            // 
            // txtbCNCDn
            // 
            this.txtbCNCDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCNCDn.Location = new System.Drawing.Point(63, 139);
            this.txtbCNCDn.Name = "txtbCNCDn";
            this.txtbCNCDn.Size = new System.Drawing.Size(100, 22);
            this.txtbCNCDn.TabIndex = 17;
            // 
            // txtbCNCCn
            // 
            this.txtbCNCCn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCNCCn.Location = new System.Drawing.Point(63, 147);
            this.txtbCNCCn.Name = "txtbCNCCn";
            this.txtbCNCCn.Size = new System.Drawing.Size(100, 22);
            this.txtbCNCCn.TabIndex = 18;
            // 
            // txtbNCC
            // 
            this.txtbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNCC.Location = new System.Drawing.Point(234, 95);
            this.txtbNCC.Name = "txtbNCC";
            this.txtbNCC.Size = new System.Drawing.Size(100, 22);
            this.txtbNCC.TabIndex = 19;
            // 
            // txtbNCD
            // 
            this.txtbNCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNCD.Location = new System.Drawing.Point(234, 96);
            this.txtbNCD.Name = "txtbNCD";
            this.txtbNCD.Size = new System.Drawing.Size(100, 22);
            this.txtbNCD.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "n:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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