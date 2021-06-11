
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaJuego));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Musica = new AxWMPLib.AxWindowsMediaPlayer();
            this.time_music = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MF2 = new System.Windows.Forms.Timer(this.components);
            this.OverM = new AxWMPLib.AxWindowsMediaPlayer();
            this.Animacionbotones = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DenPan2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumPan2 = new System.Windows.Forms.Label();
            this.DenPan1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumPan1 = new System.Windows.Forms.Label();
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


            this.panel4Fraccion5 = new System.Windows.Forms.Panel();
            this.panel3Fraccion1 = new System.Windows.Forms.Panel();

            this.labelSegundooperador = new System.Windows.Forms.Label();
            this.labelPrimeroperador = new System.Windows.Forms.Label();
            this.panel5Fraccion3 = new System.Windows.Forms.Panel();
            this.DenPan3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumPan3 = new System.Windows.Forms.Label();
            this.MuestraProblemas = new System.Windows.Forms.Label();

            
            

            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SeleccionNumDem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverM)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel4Fraccion5.SuspendLayout();
            this.panel3Fraccion1.SuspendLayout();
            this.panel5Fraccion3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.TransicionEnemigo_tick);
            // 
            // Musica
            // 
            this.Musica.Enabled = true;
            this.Musica.Location = new System.Drawing.Point(0, 674);
            this.Musica.Margin = new System.Windows.Forms.Padding(2);
            this.Musica.Name = "Musica";
            this.Musica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Musica.OcxState")));
            this.Musica.Size = new System.Drawing.Size(15, 23);
            this.Musica.TabIndex = 46;
            this.Musica.Visible = false;
            // 
            // time_music
            // 
            this.time_music.Enabled = true;
            this.time_music.Interval = 17000;
            this.time_music.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(857, 548);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 47;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MF2
            // 
            this.MF2.Interval = 29000;
            this.MF2.Tick += new System.EventHandler(this.MF2_Tick);
            // 
            // OverM
            // 
            this.OverM.Enabled = true;
            this.OverM.Location = new System.Drawing.Point(21, 674);
            this.OverM.Margin = new System.Windows.Forms.Padding(2);
            this.OverM.Name = "OverM";
            this.OverM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("OverM.OcxState")));
            this.OverM.Size = new System.Drawing.Size(16, 23);
            this.OverM.TabIndex = 48;
            this.OverM.Visible = false;
            // 
            // Animacionbotones
            // 
            this.Animacionbotones.Interval = 50;
            this.Animacionbotones.Tick += new System.EventHandler(this.FinAnimacion_tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelBotones);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.enemi);
            this.panel1.Controls.Add(this.PanelCorazones);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.panel2Problemas);
            this.panel1.Location = new System.Drawing.Point(0, 0);

            this.panel1.Margin = new System.Windows.Forms.Padding(4);


            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 637);
            this.panel1.TabIndex = 49;
            // 
            // DenPan2
            // 
            this.DenPan2.AutoSize = true;
            this.DenPan2.Location = new System.Drawing.Point(12, 61);
            this.DenPan2.Name = "DenPan2";
            this.DenPan2.Size = new System.Drawing.Size(41, 13);
            this.DenPan2.TabIndex = 59;
            this.DenPan2.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "________";
            // 
            // NumPan2
            // 
            this.NumPan2.AutoSize = true;
            this.NumPan2.Location = new System.Drawing.Point(12, 14);
            this.NumPan2.Name = "NumPan2";
            this.NumPan2.Size = new System.Drawing.Size(35, 13);
            this.NumPan2.TabIndex = 57;
            this.NumPan2.Text = "label7";
            // 
            // DenPan1
            // 
            this.DenPan1.AutoSize = true;
            this.DenPan1.Location = new System.Drawing.Point(12, 61);
            this.DenPan1.Name = "DenPan1";
            this.DenPan1.Size = new System.Drawing.Size(35, 13);
            this.DenPan1.TabIndex = 56;
            this.DenPan1.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "________";
            // 
            // NumPan1
            // 
            this.NumPan1.AutoSize = true;
            this.NumPan1.Location = new System.Drawing.Point(12, 15);
            this.NumPan1.Name = "NumPan1";
            this.NumPan1.Size = new System.Drawing.Size(35, 13);
            this.NumPan1.TabIndex = 54;
            this.NumPan1.Text = "label3";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.SeleccionNumDem);
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

            this.panelBotones.Location = new System.Drawing.Point(62, 485);


            this.panelBotones.Location = new System.Drawing.Point(205, 597);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);

            this.panelBotones.Location = new System.Drawing.Point(154, 485);


            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(831, 149);
            this.panelBotones.TabIndex = 53;
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

            this.punto.Location = new System.Drawing.Point(732, 62);


            this.punto.Location = new System.Drawing.Point(840, 74);
            this.punto.Margin = new System.Windows.Forms.Padding(4);

            this.punto.Location = new System.Drawing.Point(630, 60);


            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(88, 55);
            this.punto.TabIndex = 38;
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
            this.cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.ForeColor = System.Drawing.SystemColors.ControlText;

            this.cero.Location = new System.Drawing.Point(622, 94);


            this.cero.Location = new System.Drawing.Point(693, 113);
            this.cero.Margin = new System.Windows.Forms.Padding(4);

            this.cero.Location = new System.Drawing.Point(520, 92);


            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(88, 55);
            this.cero.TabIndex = 37;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // nuebe
            // 
            this.nuebe.BackColor = System.Drawing.Color.Transparent;
            this.nuebe.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.nuebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nuebe.FlatAppearance.BorderSize = 0;
            this.nuebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuebe.ForeColor = System.Drawing.SystemColors.ControlText;

            this.nuebe.Location = new System.Drawing.Point(494, 91);


            this.nuebe.Location = new System.Drawing.Point(523, 110);
            this.nuebe.Margin = new System.Windows.Forms.Padding(4);

            this.nuebe.Location = new System.Drawing.Point(392, 89);


            this.nuebe.Name = "nuebe";
            this.nuebe.Size = new System.Drawing.Size(88, 55);
            this.nuebe.TabIndex = 36;
            this.nuebe.Text = "9";
            this.nuebe.UseVisualStyleBackColor = false;
            this.nuebe.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.Transparent;
            this.ocho.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.ocho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ocho.FlatAppearance.BorderSize = 0;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.ForeColor = System.Drawing.SystemColors.ControlText;

            this.ocho.Location = new System.Drawing.Point(361, 94);


            this.ocho.Location = new System.Drawing.Point(345, 113);
            this.ocho.Margin = new System.Windows.Forms.Padding(4);

            this.ocho.Location = new System.Drawing.Point(259, 92);


            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(88, 55);
            this.ocho.TabIndex = 35;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.Transparent;
            this.siete.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.siete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siete.FlatAppearance.BorderSize = 0;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.ForeColor = System.Drawing.SystemColors.ControlText;

            this.siete.Location = new System.Drawing.Point(245, 97);


            this.siete.Location = new System.Drawing.Point(191, 117);
            this.siete.Margin = new System.Windows.Forms.Padding(4);

            this.siete.Location = new System.Drawing.Point(143, 95);


            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(88, 55);
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
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.ForeColor = System.Drawing.SystemColors.ControlText;

            this.seis.Location = new System.Drawing.Point(128, 97);


            this.seis.Location = new System.Drawing.Point(35, 117);
            this.seis.Margin = new System.Windows.Forms.Padding(4);

            this.seis.Location = new System.Drawing.Point(26, 95);


            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(88, 55);
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
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.ForeColor = System.Drawing.SystemColors.ControlText;

            this.cinco.Location = new System.Drawing.Point(622, 22);


            this.cinco.Location = new System.Drawing.Point(693, 25);
            this.cinco.Margin = new System.Windows.Forms.Padding(4);

            this.cinco.Location = new System.Drawing.Point(520, 20);


            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(88, 55);
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
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.ForeColor = System.Drawing.SystemColors.ControlText;

            this.cuatro.Location = new System.Drawing.Point(494, 22);


            this.cuatro.Location = new System.Drawing.Point(523, 25);
            this.cuatro.Margin = new System.Windows.Forms.Padding(4);

            this.cuatro.Location = new System.Drawing.Point(392, 20);


            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(88, 55);
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
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.ForeColor = System.Drawing.SystemColors.ControlText;

            this.tres.Location = new System.Drawing.Point(361, 22);


            this.tres.Location = new System.Drawing.Point(345, 25);
            this.tres.Margin = new System.Windows.Forms.Padding(4);

            this.tres.Location = new System.Drawing.Point(259, 20);


            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(88, 55);
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
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.ForeColor = System.Drawing.SystemColors.ControlText;

            this.dos.Location = new System.Drawing.Point(245, 22);


            this.dos.Location = new System.Drawing.Point(191, 25);
            this.dos.Margin = new System.Windows.Forms.Padding(4);

            this.dos.Location = new System.Drawing.Point(143, 20);


            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(88, 55);
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
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.ForeColor = System.Drawing.SystemColors.ControlText;

            this.uno.Location = new System.Drawing.Point(128, 22);


            this.uno.Location = new System.Drawing.Point(35, 25);
            this.uno.Margin = new System.Windows.Forms.Padding(4);

            this.uno.Location = new System.Drawing.Point(26, 20);


            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(88, 55);
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

            this.panel2.Location = new System.Drawing.Point(323, 375);

            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 79);
            this.panel2.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(130, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 48;
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

            this.TextboxRespuestaDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxRespuestaDenominador.Location = new System.Drawing.Point(133, 58);

            this.TextboxRespuestaDenominador.Name = "TextboxRespuestaDenominador";
            this.TextboxRespuestaDenominador.Size = new System.Drawing.Size(75, 19);
            this.TextboxRespuestaDenominador.TabIndex = 47;
            this.TextboxRespuestaDenominador.Visible = false;
            // 
            // textoRespuesta
            // 
            this.textoRespuesta.Enabled = false;

            this.textoRespuesta.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRespuesta.Location = new System.Drawing.Point(177, 4);
            this.textoRespuesta.Margin = new System.Windows.Forms.Padding(4);

            this.textoRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRespuesta.Location = new System.Drawing.Point(133, 3);

            this.textoRespuesta.Name = "textoRespuesta";
            this.textoRespuesta.Size = new System.Drawing.Size(75, 19);
            this.textoRespuesta.TabIndex = 44;
            // 
            // button1
            // 

            this.button1.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);

            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

            this.Respuesta.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta.Location = new System.Drawing.Point(322, 32);
            this.Respuesta.Margin = new System.Windows.Forms.Padding(4);

            this.Respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta.Location = new System.Drawing.Point(242, 26);

            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(107, 28);
            this.Respuesta.TabIndex = 45;
            this.Respuesta.Text = "Respuesta";
            this.Respuesta.UseVisualStyleBackColor = true;
            this.Respuesta.Click += new System.EventHandler(this.BotonenviarRespuesta_Click);
            // 
            // enemi
            // 
            this.enemi.Anchor = System.Windows.Forms.AnchorStyles.Left;

            this.enemi.Location = new System.Drawing.Point(944, 426);
            this.enemi.Margin = new System.Windows.Forms.Padding(4);
            this.enemi.Name = "enemi";
            this.enemi.Size = new System.Drawing.Size(179, 162);

            this.enemi.Location = new System.Drawing.Point(708, 301);
            this.enemi.Name = "enemi";
            this.enemi.Size = new System.Drawing.Size(202, 177);

            this.enemi.TabIndex = 49;
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

            this.PanelCorazones.Location = new System.Drawing.Point(15, 14);
            this.PanelCorazones.Margin = new System.Windows.Forms.Padding(4);

            this.PanelCorazones.Location = new System.Drawing.Point(11, 11);

            this.PanelCorazones.Name = "PanelCorazones";
            this.PanelCorazones.Size = new System.Drawing.Size(451, 77);
            this.PanelCorazones.TabIndex = 48;
            // 
            // pictureBox4
            // 

            this.pictureBox4.Location = new System.Drawing.Point(300, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox4.Location = new System.Drawing.Point(225, 3);

            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 70);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 

            this.pictureBox5.Location = new System.Drawing.Point(399, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox5.Location = new System.Drawing.Point(299, 3);

            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 70);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 

            this.pictureBox6.Location = new System.Drawing.Point(499, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox6.Location = new System.Drawing.Point(374, 3);

            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(69, 70);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox1.Location = new System.Drawing.Point(3, 3);

            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 

            this.pictureBox2.Location = new System.Drawing.Point(103, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox2.Location = new System.Drawing.Point(77, 3);

            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 70);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 

            this.pictureBox3.Location = new System.Drawing.Point(203, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);

            this.pictureBox3.Location = new System.Drawing.Point(152, 3);

            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 70);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.Right;

            this.player.Location = new System.Drawing.Point(205, 426);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(195, 162);

            this.player.Location = new System.Drawing.Point(110, 301);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(190, 177);

            this.player.TabIndex = 50;
            this.player.TabStop = false;
            // 
            // panel2Problemas
            // 
            this.panel2Problemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2Problemas.BackColor = System.Drawing.Color.Transparent;
            this.panel2Problemas.Controls.Add(this.panel4Fraccion5);
            this.panel2Problemas.Controls.Add(this.panel3Fraccion1);
            this.panel2Problemas.Controls.Add(this.labelSegundooperador);
            this.panel2Problemas.Controls.Add(this.labelPrimeroperador);
            this.panel2Problemas.Controls.Add(this.panel5Fraccion3);
            this.panel2Problemas.Controls.Add(this.MuestraProblemas);

            this.panel2Problemas.Location = new System.Drawing.Point(431, 250);
            this.panel2Problemas.Margin = new System.Windows.Forms.Padding(4);
            this.panel2Problemas.Name = "panel2Problemas";
            this.panel2Problemas.Size = new System.Drawing.Size(465, 162);
            this.panel2Problemas.TabIndex = 52;
            // 

            this.panel2Problemas.Location = new System.Drawing.Point(323, 163);
            this.panel2Problemas.Name = "panel2Problemas";
            this.panel2Problemas.Size = new System.Drawing.Size(419, 132);
            this.panel2Problemas.TabIndex = 52;
            // 
            // panel4Fraccion5
            // 
            this.panel4Fraccion5.Controls.Add(this.DenPan2);
            this.panel4Fraccion5.Controls.Add(this.NumPan2);
            this.panel4Fraccion5.Controls.Add(this.label9);
            this.panel4Fraccion5.Location = new System.Drawing.Point(118, 28);
            this.panel4Fraccion5.Name = "panel4Fraccion5";
            this.panel4Fraccion5.Size = new System.Drawing.Size(60, 89);
            this.panel4Fraccion5.TabIndex = 54;
            this.panel4Fraccion5.Visible = false;
            // 
            // panel3Fraccion1
            // 
            this.panel3Fraccion1.Controls.Add(this.NumPan1);
            this.panel3Fraccion1.Controls.Add(this.label4);
            this.panel3Fraccion1.Controls.Add(this.DenPan1);
            this.panel3Fraccion1.Location = new System.Drawing.Point(25, 28);
            this.panel3Fraccion1.Name = "panel3Fraccion1";
            this.panel3Fraccion1.Size = new System.Drawing.Size(60, 89);
            this.panel3Fraccion1.TabIndex = 54;
            this.panel3Fraccion1.Visible = false;
            // 

            // labelSegundooperador
            // 
            this.labelSegundooperador.AutoSize = true;
            this.labelSegundooperador.Location = new System.Drawing.Point(198, 67);
            this.labelSegundooperador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSegundooperador.Name = "labelSegundooperador";
            this.labelSegundooperador.Size = new System.Drawing.Size(13, 17);
            this.labelSegundooperador.TabIndex = 18;
            this.labelSegundooperador.Text = "-";
            // 
            // labelPrimeroperador
            // 
            this.labelPrimeroperador.AutoSize = true;
            this.labelPrimeroperador.Location = new System.Drawing.Point(90, 67);
            this.labelPrimeroperador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrimeroperador.Name = "labelPrimeroperador";
            this.labelPrimeroperador.Size = new System.Drawing.Size(16, 17);
            this.labelPrimeroperador.TabIndex = 17;
            this.labelPrimeroperador.Text = "+";
            // 
            // panel5Fraccion3
            // 
            this.panel5Fraccion3.Controls.Add(this.DenPan3);
            this.panel5Fraccion3.Controls.Add(this.label8);
            this.panel5Fraccion3.Controls.Add(this.NumPan3);
            this.panel5Fraccion3.Location = new System.Drawing.Point(223, 28);
            this.panel5Fraccion3.Margin = new System.Windows.Forms.Padding(2);
            this.panel5Fraccion3.Name = "panel5Fraccion3";
            this.panel5Fraccion3.Size = new System.Drawing.Size(60, 89);
            this.panel5Fraccion3.TabIndex = 16;
            this.panel5Fraccion3.Visible = false;
            // 
            // DenPan3
            // 
            this.DenPan3.AutoSize = true;
            this.DenPan3.Location = new System.Drawing.Point(13, 61);
            this.DenPan3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DenPan3.Name = "DenPan3";
            this.DenPan3.Size = new System.Drawing.Size(46, 17);
            this.DenPan3.TabIndex = 8;
            this.DenPan3.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "________";
            // 
            // NumPan3
            // 
            this.NumPan3.AutoSize = true;
            this.NumPan3.Location = new System.Drawing.Point(13, 14);
            this.NumPan3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumPan3.Name = "NumPan3";
            this.NumPan3.Size = new System.Drawing.Size(46, 17);
            this.NumPan3.TabIndex = 6;
            this.NumPan3.Text = "label7";
            // 
            // MuestraProblemas

            // 
            this.MuestraProblemas.AutoSize = true;
            this.MuestraProblemas.Font = new System.Drawing.Font("Dogica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraProblemas.Location = new System.Drawing.Point(155, 72);
            this.MuestraProblemas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MuestraProblemas.Name = "MuestraProblemas";
            this.MuestraProblemas.Size = new System.Drawing.Size(154, 24);
            this.MuestraProblemas.TabIndex = 0;
            this.MuestraProblemas.Text = "label2";
           
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
            this.MuestraProblemas.AutoSize = true;
            this.MuestraProblemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraProblemas.Location = new System.Drawing.Point(333, 56);
            this.MuestraProblemas.Name = "MuestraProblemas";
            this.MuestraProblemas.Size = new System.Drawing.Size(60, 24);
            this.MuestraProblemas.TabIndex = 0;
            this.MuestraProblemas.Text = "label2";

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

            // SeleccionNumDem
            // 
            this.SeleccionNumDem.BackColor = System.Drawing.Color.Transparent;
            this.SeleccionNumDem.BackgroundImage = global::juego.Properties.Resources.Boton2;
            this.SeleccionNumDem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SeleccionNumDem.Enabled = false;
            this.SeleccionNumDem.FlatAppearance.BorderSize = 0;
            this.SeleccionNumDem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeleccionNumDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionNumDem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeleccionNumDem.Location = new System.Drawing.Point(7, 53);
            this.SeleccionNumDem.Name = "SeleccionNumDem";
            this.SeleccionNumDem.Size = new System.Drawing.Size(88, 55);
            this.SeleccionNumDem.TabIndex = 54;
            this.SeleccionNumDem.Text = "⇵";
            this.SeleccionNumDem.UseVisualStyleBackColor = false;
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



            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OverM);
            this.Controls.Add(this.Musica);
            this.Controls.Add(this.trackBar1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;

            this.Margin = new System.Windows.Forms.Padding(4);


            this.Name = "VentanaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaJuego";
            this.Load += new System.EventHandler(this.VentanaJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverM)).EndInit();
            this.panel1.ResumeLayout(false);
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
            this.panel4Fraccion5.ResumeLayout(false);
            this.panel4Fraccion5.PerformLayout();
            this.panel3Fraccion1.ResumeLayout(false);
            this.panel3Fraccion1.PerformLayout();
            this.panel5Fraccion3.ResumeLayout(false);
            this.panel5Fraccion3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer Musica;
        private System.Windows.Forms.Timer time_music;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer OverM;
        private System.Windows.Forms.Timer Animacionbotones;
        public System.Windows.Forms.Timer MF2;
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
        private System.Windows.Forms.Label labelSegundooperador;
        private System.Windows.Forms.Label labelPrimeroperador;
        private System.Windows.Forms.Panel panel5Fraccion3;
        private System.Windows.Forms.Label DenPan3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NumPan3;
        
        
        
        private System.Windows.Forms.Label label2;
        
        
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.Panel panel3Fraccion1;
        private System.Windows.Forms.Panel panel4Fraccion5;
        private System.Windows.Forms.Label DenPan2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NumPan2;
        private System.Windows.Forms.Label DenPan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NumPan1;
        private System.Windows.Forms.Button SeleccionNumDem;
    }
}