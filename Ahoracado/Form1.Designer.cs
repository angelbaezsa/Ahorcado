namespace Ahoracado
{
    partial class frmAhorcado
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
        /// 



        private void InitializeComponent()
        {
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.lblAhorcado = new System.Windows.Forms.Label();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.flLetras = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // picAhorcado
            // 
            this.picAhorcado.Image = global::Ahoracado.Properties.Resources.ahorcado1;
            this.picAhorcado.Location = new System.Drawing.Point(504, 81);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(284, 325);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 26;
            this.picAhorcado.TabStop = false;
            this.picAhorcado.Click += new System.EventHandler(this.picAhorcado_Click);
            // 
            // lblAhorcado
            // 
            this.lblAhorcado.AutoSize = true;
            this.lblAhorcado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorcado.Location = new System.Drawing.Point(327, 22);
            this.lblAhorcado.Name = "lblAhorcado";
            this.lblAhorcado.Size = new System.Drawing.Size(101, 25);
            this.lblAhorcado.TabIndex = 0;
            this.lblAhorcado.Text = "Ahorcado";
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(30, 122);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(465, 83);
            this.flPalabra.TabIndex = 27;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(602, 40);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(138, 38);
            this.lblMensaje.TabIndex = 28;
            this.lblMensaje.Text = "Perdiste!";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(46, 384);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(149, 52);
            this.btnJugar.TabIndex = 29;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.frmAhorcado_Load);
            // 
            // flLetras
            // 
            this.flLetras.Location = new System.Drawing.Point(12, 230);
            this.flLetras.Name = "flLetras";
            this.flLetras.Size = new System.Drawing.Size(486, 148);
            this.flLetras.TabIndex = 1;
            this.flLetras.Paint += new System.Windows.Forms.PaintEventHandler(this.flLetras_Paint);
            // 
            // frmAhorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.flLetras);
            this.Controls.Add(this.lblAhorcado);
            this.Controls.Add(this.picAhorcado);
            this.Name = "frmAhorcado";
            this.Text = "Ahorcado";
            this.Load += new System.EventHandler(this.frmAhorcado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.Label lblAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.FlowLayoutPanel flLetras;
    }
}

