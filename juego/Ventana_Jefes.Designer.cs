
namespace juego
{
    partial class Ventana_JefesES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_JefesES));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AnimacionBotones = new System.Windows.Forms.Timer(this.components);
            this.Transicionventana = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.plant = new AxWMPLib.AxWindowsMediaPlayer();
            this.buuh = new AxWMPLib.AxWindowsMediaPlayer();
            this.Bruja = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.punto = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxRespuestaDenominador = new System.Windows.Forms.TextBox();
            this.textoRespuesta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Respuesta = new System.Windows.Forms.Button();
            this.enemi = new System.Windows.Forms.PictureBox();
            this.PanelCorazones = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel2Problemas = new System.Windows.Forms.Panel();
            this.labelSegundooperador = new System.Windows.Forms.Label();
            this.labelPrimeroperador = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DenPan3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumPan3 = new System.Windows.Forms.Label();
            this.MuestraProblemas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumPan1 = new System.Windows.Forms.Label();
            this.DenPan1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DenPan2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumPan2 = new System.Windows.Forms.Label();
            this.AnimacionCambioImagen = new System.Windows.Forms.Timer(this.components);
            this.Planta = new System.Windows.Forms.Timer(this.components);
            this.Danny = new System.Windows.Forms.Timer(this.components);
            this.Witch = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buuh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bruja)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemi)).BeginInit();
            this.PanelCorazones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel2Problemas.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.Transicionventana.Tick += new System.EventHandler(this.CambioVen_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.plant);
            this.panel1.Controls.Add(this.buuh);
            this.panel1.Controls.Add(this.Bruja);
            this.panel1.Controls.Add(this.panelBotones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemi);
            this.panel1.Controls.Add(this.PanelCorazones);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.panel2Problemas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 784);
            this.panel1.TabIndex = 47;
            // 
            // plant
            // 
            this.plant.Enabled = true;
            this.plant.Location = new System.Drawing.Point(52, 772);
            this.plant.Name = "plant";
            this.plant.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("plant.OcxState")));
            this.plant.Size = new System.Drawing.Size(18, 23);
            this.plant.TabIndex = 57;
            // 
            // buuh
            // 
            this.buuh.Enabled = true;
            this.buuh.Location = new System.Drawing.Point(28, 772);
            this.buuh.Name = "buuh";
            this.buuh.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("buuh.OcxState")));
            this.buuh.Size = new System.Drawing.Size(18, 23);
            this.buuh.TabIndex = 56;
            // 
            // Bruja
            // 
            this.Bruja.Enabled = true;
            this.Bruja.Location = new System.Drawing.Point(4, 772);
            this.Bruja.Name = "Bruja";
            this.Bruja.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Bruja.OcxState")));
            this.Bruja.Size = new System.Drawing.Size(18, 23);
            this.Bruja.TabIndex = 55;
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
            this.panelBotones.Location = new System.Drawing.Point(205, 597);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(985, 176);
            this.panelBotones.TabIndex = 54;
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.Color.Transparent;
            this.punto.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.punto.FlatAppearance.BorderSize = 0;
            this.punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.punto.Location = new System.Drawing.Point(797, 74);
            this.punto.Margin = new System.Windows.Forms.Padding(4);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(117, 68);
            this.punto.TabIndex = 39;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.Color.Transparent;
            this.cero.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cero.FlatAppearance.BorderSize = 0;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cero.Location = new System.Drawing.Point(644, 110);
            this.cero.Margin = new System.Windows.Forms.Padding(4);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(117, 68);
            this.cero.TabIndex = 37;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // nuebe
            // 
            this.nuebe.BackColor = System.Drawing.Color.Transparent;
            this.nuebe.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.nuebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nuebe.FlatAppearance.BorderSize = 0;
            this.nuebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuebe.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuebe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nuebe.Location = new System.Drawing.Point(492, 110);
            this.nuebe.Margin = new System.Windows.Forms.Padding(4);
            this.nuebe.Name = "nuebe";
            this.nuebe.Size = new System.Drawing.Size(117, 68);
            this.nuebe.TabIndex = 36;
            this.nuebe.Text = "9";
            this.nuebe.UseVisualStyleBackColor = false;
            this.nuebe.Click += new System.EventHandler(this.Nueve_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.Transparent;
            this.ocho.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.ocho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ocho.FlatAppearance.BorderSize = 0;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ocho.Location = new System.Drawing.Point(335, 110);
            this.ocho.Margin = new System.Windows.Forms.Padding(4);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(117, 68);
            this.ocho.TabIndex = 35;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.Ocho_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.Transparent;
            this.siete.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.siete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siete.FlatAppearance.BorderSize = 0;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siete.Location = new System.Drawing.Point(184, 110);
            this.siete.Margin = new System.Windows.Forms.Padding(4);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(117, 68);
            this.siete.TabIndex = 34;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.Transparent;
            this.seis.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.seis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seis.FlatAppearance.BorderSize = 0;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seis.Location = new System.Drawing.Point(35, 110);
            this.seis.Margin = new System.Windows.Forms.Padding(4);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(117, 68);
            this.seis.TabIndex = 33;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.Transparent;
            this.cinco.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cinco.FlatAppearance.BorderSize = 0;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cinco.Location = new System.Drawing.Point(644, 34);
            this.cinco.Margin = new System.Windows.Forms.Padding(4);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(117, 68);
            this.cinco.TabIndex = 32;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.Color.Transparent;
            this.cuatro.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.cuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuatro.FlatAppearance.BorderSize = 0;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cuatro.Location = new System.Drawing.Point(492, 34);
            this.cuatro.Margin = new System.Windows.Forms.Padding(4);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(117, 68);
            this.cuatro.TabIndex = 31;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.Transparent;
            this.tres.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.tres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tres.FlatAppearance.BorderSize = 0;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tres.Location = new System.Drawing.Point(335, 34);
            this.tres.Margin = new System.Windows.Forms.Padding(4);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(117, 68);
            this.tres.TabIndex = 30;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.Color.Transparent;
            this.dos.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.dos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dos.FlatAppearance.BorderSize = 0;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dos.Location = new System.Drawing.Point(185, 34);
            this.dos.Margin = new System.Windows.Forms.Padding(4);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(117, 68);
            this.dos.TabIndex = 29;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.Color.Transparent;
            this.uno.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.uno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uno.FlatAppearance.BorderSize = 0;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uno.Location = new System.Drawing.Point(35, 34);
            this.uno.Margin = new System.Windows.Forms.Padding(4);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(117, 68);
            this.uno.TabIndex = 21;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TextboxRespuestaDenominador);
            this.panel2.Controls.Add(this.textoRespuesta);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Respuesta);
            this.panel2.Location = new System.Drawing.Point(431, 462);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 103);
            this.panel2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(173, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "____________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // TextboxRespuestaDenominador
            // 
            this.TextboxRespuestaDenominador.Enabled = false;
            this.TextboxRespuestaDenominador.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxRespuestaDenominador.Location = new System.Drawing.Point(177, 71);
            this.TextboxRespuestaDenominador.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxRespuestaDenominador.Name = "TextboxRespuestaDenominador";
            this.TextboxRespuestaDenominador.Size = new System.Drawing.Size(99, 19);
            this.TextboxRespuestaDenominador.TabIndex = 49;
            this.TextboxRespuestaDenominador.Visible = false;
            // 
            // textoRespuesta
            // 
            this.textoRespuesta.Enabled = false;
            this.textoRespuesta.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRespuesta.Location = new System.Drawing.Point(176, 10);
            this.textoRespuesta.Margin = new System.Windows.Forms.Padding(4);
            this.textoRespuesta.Name = "textoRespuesta";
            this.textoRespuesta.Size = new System.Drawing.Size(99, 19);
            this.textoRespuesta.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "cura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotonCura_Click);
            // 
            // Respuesta
            // 
            this.Respuesta.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Respuesta.Location = new System.Drawing.Point(317, 32);
            this.Respuesta.Margin = new System.Windows.Forms.Padding(4);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(148, 34);
            this.Respuesta.TabIndex = 45;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            this.Respuesta.Click += new System.EventHandler(this.BotonenviarRespuesta_Click);
            // 
            // enemi
            // 
            this.enemi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enemi.Location = new System.Drawing.Point(941, 426);
            this.enemi.Margin = new System.Windows.Forms.Padding(4);
            this.enemi.Name = "enemi";
            this.enemi.Size = new System.Drawing.Size(179, 171);
            this.enemi.TabIndex = 50;
            this.enemi.TabStop = false;
            // 
            // PanelCorazones
            // 
            this.PanelCorazones.Controls.Add(this.pictureBox4);
            this.PanelCorazones.Controls.Add(this.pictureBox5);
            this.PanelCorazones.Controls.Add(this.pictureBox6);
            this.PanelCorazones.Controls.Add(this.pictureBox1);
            this.PanelCorazones.Controls.Add(this.pictureBox2);
            this.PanelCorazones.Controls.Add(this.pictureBox3);
            this.PanelCorazones.Location = new System.Drawing.Point(15, 12);
            this.PanelCorazones.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCorazones.Name = "PanelCorazones";
            this.PanelCorazones.Size = new System.Drawing.Size(603, 92);
            this.PanelCorazones.TabIndex = 49;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(303, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 86);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(401, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(92, 86);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(501, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(92, 86);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(103, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 86);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(203, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 86);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.player.Location = new System.Drawing.Point(192, 426);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(195, 171);
            this.player.TabIndex = 51;
            this.player.TabStop = false;
            // 
            // panel2Problemas
            // 
            this.panel2Problemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2Problemas.Controls.Add(this.labelSegundooperador);
            this.panel2Problemas.Controls.Add(this.labelPrimeroperador);
            this.panel2Problemas.Controls.Add(this.panel5);
            this.panel2Problemas.Controls.Add(this.MuestraProblemas);
            this.panel2Problemas.Location = new System.Drawing.Point(424, 250);
            this.panel2Problemas.Margin = new System.Windows.Forms.Padding(4);
            this.panel2Problemas.Name = "panel2Problemas";
            this.panel2Problemas.Size = new System.Drawing.Size(472, 153);
            this.panel2Problemas.TabIndex = 53;
            // 
            // labelSegundooperador
            // 
            this.labelSegundooperador.AutoSize = true;
            this.labelSegundooperador.Location = new System.Drawing.Point(262, 86);
            this.labelSegundooperador.Name = "labelSegundooperador";
            this.labelSegundooperador.Size = new System.Drawing.Size(13, 17);
            this.labelSegundooperador.TabIndex = 13;
            this.labelSegundooperador.Text = "-";
            // 
            // labelPrimeroperador
            // 
            this.labelPrimeroperador.AutoSize = true;
            this.labelPrimeroperador.Location = new System.Drawing.Point(142, 86);
            this.labelPrimeroperador.Name = "labelPrimeroperador";
            this.labelPrimeroperador.Size = new System.Drawing.Size(16, 17);
            this.labelPrimeroperador.TabIndex = 12;
            this.labelPrimeroperador.Text = "+";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DenPan3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.NumPan3);
            this.panel5.Location = new System.Drawing.Point(290, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(73, 105);
            this.panel5.TabIndex = 11;
            // 
            // DenPan3
            // 
            this.DenPan3.AutoSize = true;
            this.DenPan3.Location = new System.Drawing.Point(17, 75);
            this.DenPan3.Name = "DenPan3";
            this.DenPan3.Size = new System.Drawing.Size(46, 17);
            this.DenPan3.TabIndex = 8;
            this.DenPan3.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "________";
            // 
            // NumPan3
            // 
            this.NumPan3.AutoSize = true;
            this.NumPan3.Location = new System.Drawing.Point(17, 17);
            this.NumPan3.Name = "NumPan3";
            this.NumPan3.Size = new System.Drawing.Size(46, 17);
            this.NumPan3.TabIndex = 6;
            this.NumPan3.Text = "label7";
            // 
            // MuestraProblemas
            // 
            this.MuestraProblemas.AutoSize = true;
            this.MuestraProblemas.Font = new System.Drawing.Font("Dogica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraProblemas.Location = new System.Drawing.Point(158, 65);
            this.MuestraProblemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MuestraProblemas.Name = "MuestraProblemas";
            this.MuestraProblemas.Size = new System.Drawing.Size(154, 24);
            this.MuestraProblemas.TabIndex = 0;
            this.MuestraProblemas.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NumPan1);
            this.panel4.Controls.Add(this.DenPan1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(53, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 105);
            this.panel4.TabIndex = 10;
            // 
            // NumPan1
            // 
            this.NumPan1.AutoSize = true;
            this.NumPan1.Location = new System.Drawing.Point(10, 19);
            this.NumPan1.Name = "NumPan1";
            this.NumPan1.Size = new System.Drawing.Size(70, 17);
            this.NumPan1.TabIndex = 3;
            this.NumPan1.Text = "NumPan1";
            // 
            // DenPan1
            // 
            this.DenPan1.AutoSize = true;
            this.DenPan1.Location = new System.Drawing.Point(10, 74);
            this.DenPan1.Name = "DenPan1";
            this.DenPan1.Size = new System.Drawing.Size(67, 17);
            this.DenPan1.TabIndex = 2;
            this.DenPan1.Text = "DenPan1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "________";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DenPan2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.NumPan2);
            this.panel3.Location = new System.Drawing.Point(172, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 105);
            this.panel3.TabIndex = 9;
            // 
            // DenPan2
            // 
            this.DenPan2.AutoSize = true;
            this.DenPan2.Location = new System.Drawing.Point(19, 72);
            this.DenPan2.Name = "DenPan2";
            this.DenPan2.Size = new System.Drawing.Size(46, 17);
            this.DenPan2.TabIndex = 5;
            this.DenPan2.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "________";
            // 
            // NumPan2
            // 
            this.NumPan2.AutoSize = true;
            this.NumPan2.Location = new System.Drawing.Point(19, 20);
            this.NumPan2.Name = "NumPan2";
            this.NumPan2.Size = new System.Drawing.Size(46, 17);
            this.NumPan2.TabIndex = 3;
            this.NumPan2.Text = "label4";
            // 
            // Planta
            // 
            this.Planta.Interval = 379800;
            this.Planta.Tick += new System.EventHandler(this.Planta_Tick);
            // 
            // Danny
            // 
            this.Danny.Interval = 214800;
            this.Danny.Tick += new System.EventHandler(this.Danny_Tick);
            // 
            // Witch
            // 
            this.Witch.Interval = 196800;
            this.Witch.Tick += new System.EventHandler(this.Witch_Tick);
            // 
            // Ventana_JefesES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 789);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventana_JefesES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_Jefes";
            this.Load += new System.EventHandler(this.Ventana_JefesES_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buuh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bruja)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemi)).EndInit();
            this.PanelCorazones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel2Problemas.ResumeLayout(false);
            this.panel2Problemas.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer AnimacionBotones;
        private System.Windows.Forms.Timer Transicionventana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxRespuestaDenominador;
        private System.Windows.Forms.TextBox textoRespuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Respuesta;
        private System.Windows.Forms.PictureBox enemi;
        private System.Windows.Forms.Panel PanelCorazones;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel2Problemas;
        private System.Windows.Forms.Label MuestraProblemas;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button punto;
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
        private System.Windows.Forms.Timer AnimacionCambioImagen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label DenPan3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NumPan3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label NumPan1;
        private System.Windows.Forms.Label DenPan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DenPan2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumPan2;
        private System.Windows.Forms.Label labelSegundooperador;
        private System.Windows.Forms.Label labelPrimeroperador;
        private System.Windows.Forms.Timer Boss1;
        private System.Windows.Forms.Timer Boss2;
        private System.Windows.Forms.Timer Boss3;
        private System.Windows.Forms.Timer Planta;
        private System.Windows.Forms.Timer Danny;
        private System.Windows.Forms.Timer Witch;
        public AxWMPLib.AxWindowsMediaPlayer plant;
        public AxWMPLib.AxWindowsMediaPlayer buuh;
        public AxWMPLib.AxWindowsMediaPlayer Bruja;
    }
}