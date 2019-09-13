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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.lbldespliegue = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuerza
            // 
            this.txtFuerza.BackColor = System.Drawing.Color.Cornsilk;
            this.txtFuerza.Location = new System.Drawing.Point(274, 202);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(54, 20);
            this.txtFuerza.TabIndex = 1;
            this.txtFuerza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFuerza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // txtMasa
            // 
            this.txtMasa.BackColor = System.Drawing.Color.Cornsilk;
            this.txtMasa.Location = new System.Drawing.Point(274, 311);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(64, 20);
            this.txtMasa.TabIndex = 4;
            this.txtMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_B_KeyPress);
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.BackColor = System.Drawing.Color.White;
            this.buttoncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncalcular.Location = new System.Drawing.Point(529, 113);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(129, 74);
            this.buttoncalcular.TabIndex = 9;
            this.buttoncalcular.Text = "Calcular aceleración";
            this.buttoncalcular.UseVisualStyleBackColor = false;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // lbldespliegue
            // 
            this.lbldespliegue.AutoSize = true;
            this.lbldespliegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldespliegue.Location = new System.Drawing.Point(529, 209);
            this.lbldespliegue.Name = "lbldespliegue";
            this.lbldespliegue.Size = new System.Drawing.Size(52, 18);
            this.lbldespliegue.TabIndex = 10;
            this.lbldespliegue.Text = "label3";
            this.lbldespliegue.Click += new System.EventHandler(this.lbldespliegue_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.White;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(664, 113);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(97, 71);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Red;
            this.buttonsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(691, 371);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(97, 67);
            this.buttonsalir.TabIndex = 12;
            this.buttonsalir.Text = "X";
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 86);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ejercicio de segunda ley de Newton. Ingrese los valores de la fuerza aplicada de " +
    "la caja y la masa de la caja.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.lbldespliegue);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtFuerza);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Física";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.Label lbldespliegue;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

