namespace Física
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMasagrua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasacaja = new System.Windows.Forms.TextBox();
            this.txtA_B = new System.Windows.Forms.TextBox();
            this.txtd1 = new System.Windows.Forms.TextBox();
            this.txtd2 = new System.Windows.Forms.TextBox();
            this.txtd3 = new System.Windows.Forms.TextBox();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.lbldespliegue = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Física.Properties.Resources.multicambio_grua_caja_basculante_02__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMasagrua
            // 
            this.txtMasagrua.BackColor = System.Drawing.Color.Yellow;
            this.txtMasagrua.Location = new System.Drawing.Point(234, 172);
            this.txtMasagrua.Name = "txtMasagrua";
            this.txtMasagrua.Size = new System.Drawing.Size(100, 20);
            this.txtMasagrua.TabIndex = 1;
            this.txtMasagrua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasagrua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMasacaja
            // 
            this.txtMasacaja.BackColor = System.Drawing.Color.Yellow;
            this.txtMasacaja.Location = new System.Drawing.Point(367, 118);
            this.txtMasacaja.Name = "txtMasacaja";
            this.txtMasacaja.Size = new System.Drawing.Size(100, 20);
            this.txtMasacaja.TabIndex = 4;
            this.txtMasacaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasacaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // txtA_B
            // 
            this.txtA_B.BackColor = System.Drawing.Color.Yellow;
            this.txtA_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_B.Location = new System.Drawing.Point(146, 248);
            this.txtA_B.Multiline = true;
            this.txtA_B.Name = "txtA_B";
            this.txtA_B.Size = new System.Drawing.Size(29, 48);
            this.txtA_B.TabIndex = 5;
            this.txtA_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // txtd1
            // 
            this.txtd1.BackColor = System.Drawing.Color.Yellow;
            this.txtd1.Location = new System.Drawing.Point(181, 276);
            this.txtd1.Name = "txtd1";
            this.txtd1.Size = new System.Drawing.Size(128, 20);
            this.txtd1.TabIndex = 6;
            this.txtd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // txtd2
            // 
            this.txtd2.BackColor = System.Drawing.Color.Yellow;
            this.txtd2.Location = new System.Drawing.Point(306, 276);
            this.txtd2.Name = "txtd2";
            this.txtd2.Size = new System.Drawing.Size(128, 20);
            this.txtd2.TabIndex = 7;
            this.txtd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // txtd3
            // 
            this.txtd3.BackColor = System.Drawing.Color.Yellow;
            this.txtd3.Location = new System.Drawing.Point(181, 302);
            this.txtd3.Name = "txtd3";
            this.txtd3.Size = new System.Drawing.Size(253, 20);
            this.txtd3.TabIndex = 8;
            this.txtd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtd3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.BackColor = System.Drawing.Color.Yellow;
            this.buttoncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncalcular.Location = new System.Drawing.Point(529, 12);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(100, 67);
            this.buttoncalcular.TabIndex = 9;
            this.buttoncalcular.Text = "Calcular RA y RB";
            this.buttoncalcular.UseVisualStyleBackColor = false;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // lbldespliegue
            // 
            this.lbldespliegue.AutoSize = true;
            this.lbldespliegue.Location = new System.Drawing.Point(529, 85);
            this.lbldespliegue.Name = "lbldespliegue";
            this.lbldespliegue.Size = new System.Drawing.Size(35, 13);
            this.lbldespliegue.TabIndex = 10;
            this.lbldespliegue.Text = "label3";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(532, 146);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(97, 67);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Yellow;
            this.buttonsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(691, 371);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(97, 67);
            this.buttonsalir.TabIndex = 12;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.lbldespliegue);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.txtd3);
            this.Controls.Add(this.txtd2);
            this.Controls.Add(this.txtd1);
            this.Controls.Add(this.txtA_B);
            this.Controls.Add(this.txtMasacaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasagrua);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Física";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMasagrua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasacaja;
        private System.Windows.Forms.TextBox txtA_B;
        private System.Windows.Forms.TextBox txtd1;
        private System.Windows.Forms.TextBox txtd2;
        private System.Windows.Forms.TextBox txtd3;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.Label lbldespliegue;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonsalir;
    }
}

