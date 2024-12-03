namespace GuiaLaboratorio2
{
    partial class FMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuPrincipal));
            this.btnInteresSimple = new System.Windows.Forms.Button();
            this.btnInteresCompuesto = new System.Windows.Forms.Button();
            this.btnAmortizaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInteresSimple
            // 
            this.btnInteresSimple.BackColor = System.Drawing.SystemColors.Control;
            this.btnInteresSimple.Location = new System.Drawing.Point(340, 137);
            this.btnInteresSimple.Margin = new System.Windows.Forms.Padding(2);
            this.btnInteresSimple.Name = "btnInteresSimple";
            this.btnInteresSimple.Size = new System.Drawing.Size(112, 37);
            this.btnInteresSimple.TabIndex = 0;
            this.btnInteresSimple.Text = "Interes Simple";
            this.btnInteresSimple.UseVisualStyleBackColor = false;
            this.btnInteresSimple.Click += new System.EventHandler(this.btnInteresSimple_Click);
            // 
            // btnInteresCompuesto
            // 
            this.btnInteresCompuesto.Location = new System.Drawing.Point(340, 217);
            this.btnInteresCompuesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnInteresCompuesto.Name = "btnInteresCompuesto";
            this.btnInteresCompuesto.Size = new System.Drawing.Size(112, 37);
            this.btnInteresCompuesto.TabIndex = 1;
            this.btnInteresCompuesto.Text = "Interes Compuesto";
            this.btnInteresCompuesto.UseVisualStyleBackColor = true;
            this.btnInteresCompuesto.Click += new System.EventHandler(this.btnInteresCompuesto_Click);
            // 
            // btnAmortizaciones
            // 
            this.btnAmortizaciones.Location = new System.Drawing.Point(340, 298);
            this.btnAmortizaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmortizaciones.Name = "btnAmortizaciones";
            this.btnAmortizaciones.Size = new System.Drawing.Size(112, 37);
            this.btnAmortizaciones.TabIndex = 2;
            this.btnAmortizaciones.Text = "Amortizaciones";
            this.btnAmortizaciones.UseVisualStyleBackColor = true;
            this.btnAmortizaciones.Click += new System.EventHandler(this.btnAmortizaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingenería Económica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 451);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "By Jhon Jesus, Julio Cesar, Ramiro y David Ali";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(468, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaLaboratorio2.Properties.Resources._05c104253cd8ed7261c0643a7b658e22;
            this.ClientSize = new System.Drawing.Size(764, 482);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmortizaciones);
            this.Controls.Add(this.btnInteresCompuesto);
            this.Controls.Add(this.btnInteresSimple);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMenuPrincipal";
            this.Load += new System.EventHandler(this.FMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInteresSimple;
        private System.Windows.Forms.Button btnInteresCompuesto;
        private System.Windows.Forms.Button btnAmortizaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}