
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ene = new System.Windows.Forms.PictureBox();
            this.PanelCorazones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pla = new System.Windows.Forms.PictureBox();
            this.textoRespuesta = new System.Windows.Forms.TextBox();
            this.Respuesta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.cero = new System.Windows.Forms.Button();
            this.nuebe = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ene)).BeginInit();
            this.PanelCorazones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 455F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ene, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanelCorazones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pla, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 364);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // ene
            // 
            this.ene.Location = new System.Drawing.Point(755, 160);
            this.ene.Name = "ene";
            this.ene.Size = new System.Drawing.Size(134, 139);
            this.ene.TabIndex = 41;
            this.ene.TabStop = false;
            // 
            // PanelCorazones
            // 
            this.PanelCorazones.Controls.Add(this.pictureBox1);
            this.PanelCorazones.Controls.Add(this.pictureBox2);
            this.PanelCorazones.Controls.Add(this.pictureBox3);
            this.PanelCorazones.Location = new System.Drawing.Point(3, 3);
            this.PanelCorazones.Name = "PanelCorazones";
            this.PanelCorazones.Size = new System.Drawing.Size(224, 81);
            this.PanelCorazones.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(77, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 70);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(152, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 70);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pla
            // 
            this.pla.Location = new System.Drawing.Point(3, 160);
            this.pla.Name = "pla";
            this.pla.Size = new System.Drawing.Size(146, 139);
            this.pla.TabIndex = 42;
            this.pla.TabStop = false;
            // 
            // textoRespuesta
            // 
            this.textoRespuesta.Enabled = false;
            this.textoRespuesta.Location = new System.Drawing.Point(88, 16);
            this.textoRespuesta.Name = "textoRespuesta";
            this.textoRespuesta.Size = new System.Drawing.Size(100, 20);
            this.textoRespuesta.TabIndex = 44;
            // 
            // Respuesta
            // 
            this.Respuesta.Location = new System.Drawing.Point(220, 11);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(75, 23);
            this.Respuesta.TabIndex = 45;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 46;
            this.button1.Text = "cura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.cero);
            this.panelBotones.Controls.Add(this.nuebe);
            this.panelBotones.Controls.Add(this.ocho);
            this.panelBotones.Controls.Add(this.siete);
            this.panelBotones.Controls.Add(this.seis);
            this.panelBotones.Controls.Add(this.cinco);
            this.panelBotones.Controls.Add(this.cuatro);
            this.panelBotones.Controls.Add(this.tres);
            this.panelBotones.Controls.Add(this.dos);
            this.panelBotones.Controls.Add(this.uno);
            this.panelBotones.Location = new System.Drawing.Point(12, 382);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(579, 153);
            this.panelBotones.TabIndex = 44;
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.SystemColors.Control;
            this.cero.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cero.Location = new System.Drawing.Point(483, 89);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(88, 55);
            this.cero.TabIndex = 37;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            // 
            // nuebe
            // 
            this.nuebe.BackColor = System.Drawing.SystemColors.Control;
            this.nuebe.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.nuebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nuebe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nuebe.Location = new System.Drawing.Point(369, 89);
            this.nuebe.Name = "nuebe";
            this.nuebe.Size = new System.Drawing.Size(88, 55);
            this.nuebe.TabIndex = 36;
            this.nuebe.Text = "9";
            this.nuebe.UseVisualStyleBackColor = false;
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.SystemColors.Control;
            this.ocho.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.ocho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ocho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ocho.Location = new System.Drawing.Point(251, 89);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(88, 55);
            this.ocho.TabIndex = 35;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.SystemColors.Control;
            this.siete.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.siete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siete.Location = new System.Drawing.Point(138, 89);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(88, 55);
            this.siete.TabIndex = 34;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.SystemColors.Control;
            this.seis.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.seis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seis.Location = new System.Drawing.Point(26, 89);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(88, 55);
            this.seis.TabIndex = 33;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.SystemColors.Control;
            this.cinco.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cinco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cinco.Location = new System.Drawing.Point(483, 10);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(88, 55);
            this.cinco.TabIndex = 32;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.SystemColors.Control;
            this.cuatro.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuatro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cuatro.Location = new System.Drawing.Point(369, 10);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(88, 55);
            this.cuatro.TabIndex = 31;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.SystemColors.Control;
            this.tres.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.tres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tres.Location = new System.Drawing.Point(251, 10);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(88, 55);
            this.tres.TabIndex = 30;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.SystemColors.Control;
            this.dos.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.dos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dos.Location = new System.Drawing.Point(138, 10);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(88, 55);
            this.dos.TabIndex = 29;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.SystemColors.Control;
            this.uno.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.uno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uno.Location = new System.Drawing.Point(26, 10);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(88, 55);
            this.uno.TabIndex = 21;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textoRespuesta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Respuesta);
            this.panel1.Location = new System.Drawing.Point(300, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 44);
            this.panel1.TabIndex = 45;
            // 
            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 547);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VentanaJuego";
            this.Text = "VentanaJuego";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ene)).EndInit();
            this.PanelCorazones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pla)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textoRespuesta;
        private System.Windows.Forms.Button Respuesta;
        private System.Windows.Forms.PictureBox ene;
        private System.Windows.Forms.Panel PanelCorazones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button nuebe;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Panel panel1;
    }
}