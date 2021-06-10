
namespace juego
{
    partial class Ventana_Jefes
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
            this.tres = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxRespuestaDenominador = new System.Windows.Forms.TextBox();
            this.textoRespuesta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Respuesta = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.enemi = new System.Windows.Forms.PictureBox();
            this.PanelCorazones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cero = new System.Windows.Forms.Button();
            this.nuebe = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.dos = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.punto = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2Problemas = new System.Windows.Forms.Panel();
            this.MuestraProblemas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AnimacionBotones = new System.Windows.Forms.Timer(this.components);
            this.Transicionventana = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemi)).BeginInit();
            this.PanelCorazones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2Problemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.SystemColors.Control;
            this.tres.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.tres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tres.FlatAppearance.BorderSize = 0;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tres.Location = new System.Drawing.Point(251, 10);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(88, 55);
            this.tres.TabIndex = 30;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.SystemColors.Control;
            this.uno.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.uno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uno.FlatAppearance.BorderSize = 0;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uno.Location = new System.Drawing.Point(26, 10);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(88, 55);
            this.uno.TabIndex = 21;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextboxRespuestaDenominador);
            this.panel1.Controls.Add(this.textoRespuesta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Respuesta);
            this.panel1.Location = new System.Drawing.Point(231, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 84);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "____________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // TextboxRespuestaDenominador
            // 
            this.TextboxRespuestaDenominador.Enabled = false;
            this.TextboxRespuestaDenominador.Location = new System.Drawing.Point(133, 58);
            this.TextboxRespuestaDenominador.Name = "TextboxRespuestaDenominador";
            this.TextboxRespuestaDenominador.Size = new System.Drawing.Size(75, 20);
            this.TextboxRespuestaDenominador.TabIndex = 49;
            this.TextboxRespuestaDenominador.Visible = false;
            // 
            // textoRespuesta
            // 
            this.textoRespuesta.Enabled = false;
            this.textoRespuesta.Location = new System.Drawing.Point(132, 8);
            this.textoRespuesta.Name = "textoRespuesta";
            this.textoRespuesta.Size = new System.Drawing.Size(75, 20);
            this.textoRespuesta.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 46;
            this.button1.Text = "cura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotonCura_Click);
            // 
            // Respuesta
            // 
            this.Respuesta.Location = new System.Drawing.Point(251, 29);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(75, 23);
            this.Respuesta.TabIndex = 45;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            this.Respuesta.Click += new System.EventHandler(this.BotonenviarRespuesta_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.SystemColors.Control;
            this.seis.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.seis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seis.FlatAppearance.BorderSize = 0;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seis.Location = new System.Drawing.Point(26, 89);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(88, 55);
            this.seis.TabIndex = 33;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.SystemColors.Control;
            this.cinco.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cinco.FlatAppearance.BorderSize = 0;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cinco.Location = new System.Drawing.Point(483, 10);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(88, 55);
            this.cinco.TabIndex = 32;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.SystemColors.Control;
            this.cuatro.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuatro.FlatAppearance.BorderSize = 0;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cuatro.Location = new System.Drawing.Point(369, 10);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(88, 55);
            this.cuatro.TabIndex = 31;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // enemi
            // 
            this.enemi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enemi.Location = new System.Drawing.Point(591, 113);
            this.enemi.Name = "enemi";
            this.enemi.Size = new System.Drawing.Size(134, 139);
            this.enemi.TabIndex = 41;
            this.enemi.TabStop = false;
            // 
            // PanelCorazones
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PanelCorazones, 2);
            this.PanelCorazones.Controls.Add(this.pictureBox4);
            this.PanelCorazones.Controls.Add(this.pictureBox5);
            this.PanelCorazones.Controls.Add(this.pictureBox6);
            this.PanelCorazones.Controls.Add(this.pictureBox1);
            this.PanelCorazones.Controls.Add(this.pictureBox2);
            this.PanelCorazones.Controls.Add(this.pictureBox3);
            this.PanelCorazones.Location = new System.Drawing.Point(3, 3);
            this.PanelCorazones.Name = "PanelCorazones";
            this.PanelCorazones.Size = new System.Drawing.Size(452, 75);
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
            // cero
            // 
            this.cero.BackColor = System.Drawing.SystemColors.Control;
            this.cero.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cero.FlatAppearance.BorderSize = 0;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cero.Location = new System.Drawing.Point(483, 89);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(88, 55);
            this.cero.TabIndex = 37;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // nuebe
            // 
            this.nuebe.BackColor = System.Drawing.SystemColors.Control;
            this.nuebe.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.nuebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nuebe.FlatAppearance.BorderSize = 0;
            this.nuebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuebe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nuebe.Location = new System.Drawing.Point(369, 89);
            this.nuebe.Name = "nuebe";
            this.nuebe.Size = new System.Drawing.Size(88, 55);
            this.nuebe.TabIndex = 36;
            this.nuebe.Text = "9";
            this.nuebe.UseVisualStyleBackColor = false;
            this.nuebe.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.SystemColors.Control;
            this.ocho.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.ocho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ocho.FlatAppearance.BorderSize = 0;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ocho.Location = new System.Drawing.Point(251, 89);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(88, 55);
            this.ocho.TabIndex = 35;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.Ocho_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.SystemColors.Control;
            this.siete.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.siete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siete.FlatAppearance.BorderSize = 0;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siete.Location = new System.Drawing.Point(138, 89);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(88, 55);
            this.siete.TabIndex = 34;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.player.Location = new System.Drawing.Point(79, 113);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(146, 139);
            this.player.TabIndex = 42;
            this.player.TabStop = false;
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.SystemColors.Control;
            this.dos.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.dos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dos.FlatAppearance.BorderSize = 0;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dos.Location = new System.Drawing.Point(138, 10);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(88, 55);
            this.dos.TabIndex = 29;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.punto);
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
            this.panelBotones.Location = new System.Drawing.Point(97, 423);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(738, 143);
            this.panelBotones.TabIndex = 46;
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.SystemColors.Control;
            this.punto.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.punto.FlatAppearance.BorderSize = 0;
            this.punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.punto.Location = new System.Drawing.Point(598, 48);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(88, 55);
            this.punto.TabIndex = 39;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.67533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.06926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25541F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.enemi, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanelCorazones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.player, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2Problemas, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.21229F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.53073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.97765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 358);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // panel2Problemas
            // 
            this.panel2Problemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2Problemas.Controls.Add(this.MuestraProblemas);
            this.panel2Problemas.Location = new System.Drawing.Point(231, 120);
            this.panel2Problemas.Name = "panel2Problemas";
            this.panel2Problemas.Size = new System.Drawing.Size(354, 124);
            this.panel2Problemas.TabIndex = 48;
            // 
            // MuestraProblemas
            // 
            this.MuestraProblemas.AutoSize = true;
            this.MuestraProblemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraProblemas.Location = new System.Drawing.Point(148, 55);
            this.MuestraProblemas.Name = "MuestraProblemas";
            this.MuestraProblemas.Size = new System.Drawing.Size(60, 24);
            this.MuestraProblemas.TabIndex = 0;
            this.MuestraProblemas.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // AnimacionBotones
            // 
            this.AnimacionBotones.Interval = 50;
            this.AnimacionBotones.Tick += new System.EventHandler(this.FinAnimacion_Tick);
            // 
            // Transicionventana
            // 
            this.Transicionventana.Interval = 1500;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(227, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 70);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(301, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 70);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(376, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(69, 70);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // Ventana_Jefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 568);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Ventana_Jefes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_Jefes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemi)).EndInit();
            this.PanelCorazones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2Problemas.ResumeLayout(false);
            this.panel2Problemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textoRespuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Respuesta;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.PictureBox enemi;
        private System.Windows.Forms.Panel PanelCorazones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button nuebe;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxRespuestaDenominador;
        private System.Windows.Forms.Panel panel2Problemas;
        private System.Windows.Forms.Label MuestraProblemas;
        private System.Windows.Forms.Timer AnimacionBotones;
        private System.Windows.Forms.Timer Transicionventana;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}