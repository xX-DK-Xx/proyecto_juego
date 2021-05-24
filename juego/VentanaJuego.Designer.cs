
namespace juego
{
    partial class VentanaJuego
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ene = new System.Windows.Forms.PictureBox();
            this.pla = new System.Windows.Forms.PictureBox();
            this.tex = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.Respuesta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelCorazones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelCorazones.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "cura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ene
            // 
            this.ene.Location = new System.Drawing.Point(550, 135);
            this.ene.Name = "ene";
            this.ene.Size = new System.Drawing.Size(134, 145);
            this.ene.TabIndex = 18;
            this.ene.TabStop = false;
            // 
            // pla
            // 
            this.pla.Location = new System.Drawing.Point(290, 135);
            this.pla.Name = "pla";
            this.pla.Size = new System.Drawing.Size(134, 145);
            this.pla.TabIndex = 17;
            this.pla.TabStop = false;
            // 
            // tex
            // 
            this.tex.Location = new System.Drawing.Point(384, 335);
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(100, 20);
            this.tex.TabIndex = 11;
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(529, 342);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(35, 13);
            this.texto.TabIndex = 12;
            this.texto.Text = "label1";
            // 
            // Respuesta
            // 
            this.Respuesta.Location = new System.Drawing.Point(451, 388);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(75, 23);
            this.Respuesta.TabIndex = 16;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            this.Respuesta.Click += new System.EventHandler(this.Respuesta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(152, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 70);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(77, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 70);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PanelCorazones
            // 
            this.PanelCorazones.Controls.Add(this.pictureBox1);
            this.PanelCorazones.Controls.Add(this.pictureBox2);
            this.PanelCorazones.Controls.Add(this.pictureBox3);
            this.PanelCorazones.Location = new System.Drawing.Point(38, 12);
            this.PanelCorazones.Name = "PanelCorazones";
            this.PanelCorazones.Size = new System.Drawing.Size(224, 81);
            this.PanelCorazones.TabIndex = 20;
            // 
            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelCorazones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ene);
            this.Controls.Add(this.pla);
            this.Controls.Add(this.tex);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.Respuesta);
            this.Name = "VentanaJuego";
            this.Text = "VentanaJuego";
            ((System.ComponentModel.ISupportInitialize)(this.ene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelCorazones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ene;
        private System.Windows.Forms.PictureBox pla;
        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button Respuesta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelCorazones;
    }
}