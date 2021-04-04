
namespace MAKI_Player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTimerFI = new System.Windows.Forms.Label();
            this.lblTimerIN = new System.Windows.Forms.Label();
            this.btnRetr = new System.Windows.Forms.Button();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnAdel = new System.Windows.Forms.Button();
            this.macTrackBar1Duracion = new XComponent.SliderBar.MACTrackBar();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproducirToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVolumen);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblTimerFI);
            this.panel1.Controls.Add(this.lblTimerIN);
            this.panel1.Controls.Add(this.btnRetr);
            this.panel1.Controls.Add(this.btnVolumen);
            this.panel1.Controls.Add(this.btnAdel);
            this.panel1.Controls.Add(this.macTrackBar1Duracion);
            this.panel1.Controls.Add(this.btnPlayPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 107);
            this.panel1.TabIndex = 1;
            // 
            // lblVolumen
            // 
            this.lblVolumen.BackColor = System.Drawing.Color.Transparent;
            this.lblVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.lblVolumen.IndentHeight = 6;
            this.lblVolumen.Location = new System.Drawing.Point(316, 23);
            this.lblVolumen.Maximum = 100;
            this.lblVolumen.Minimum = 0;
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.lblVolumen.Size = new System.Drawing.Size(28, 58);
            this.lblVolumen.TabIndex = 5;
            this.lblVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.lblVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.lblVolumen.TickHeight = 4;
            this.lblVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.lblVolumen.TrackerColor = System.Drawing.Color.Fuchsia;
            this.lblVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.lblVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.lblVolumen.TrackLineHeight = 3;
            this.lblVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.lblVolumen.Value = 0;
            this.lblVolumen.Visible = false;
            this.lblVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2Volumen_ValueChanged);
            this.lblVolumen.MouseLeave += new System.EventHandler(this.macTrackBar2Volumen_MouseLeave);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(350, 82);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(13, 13);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "0";
            // 
            // lblTimerFI
            // 
            this.lblTimerFI.AutoSize = true;
            this.lblTimerFI.Location = new System.Drawing.Point(380, 23);
            this.lblTimerFI.Name = "lblTimerFI";
            this.lblTimerFI.Size = new System.Drawing.Size(28, 13);
            this.lblTimerFI.TabIndex = 7;
            this.lblTimerFI.Text = "0:00";
            // 
            // lblTimerIN
            // 
            this.lblTimerIN.AutoSize = true;
            this.lblTimerIN.Location = new System.Drawing.Point(27, 23);
            this.lblTimerIN.Name = "lblTimerIN";
            this.lblTimerIN.Size = new System.Drawing.Size(28, 13);
            this.lblTimerIN.TabIndex = 6;
            this.lblTimerIN.Text = "0:00";
            // 
            // btnRetr
            // 
            this.btnRetr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetr.BackgroundImage")));
            this.btnRetr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetr.FlatAppearance.BorderSize = 0;
            this.btnRetr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetr.Location = new System.Drawing.Point(70, 42);
            this.btnRetr.Name = "btnRetr";
            this.btnRetr.Size = new System.Drawing.Size(66, 48);
            this.btnRetr.TabIndex = 1;
            this.btnRetr.UseVisualStyleBackColor = true;
            this.btnRetr.Click += new System.EventHandler(this.btnRetr_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.BackgroundImage = global::MAKI_Player.Properties.Resources.speaker_48px;
            this.btnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.Location = new System.Drawing.Point(318, 78);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(26, 21);
            this.btnVolumen.TabIndex = 3;
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnAdel
            // 
            this.btnAdel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdel.BackgroundImage")));
            this.btnAdel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdel.FlatAppearance.BorderSize = 0;
            this.btnAdel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdel.Location = new System.Drawing.Point(220, 42);
            this.btnAdel.Name = "btnAdel";
            this.btnAdel.Size = new System.Drawing.Size(66, 48);
            this.btnAdel.TabIndex = 2;
            this.btnAdel.UseVisualStyleBackColor = true;
            this.btnAdel.Click += new System.EventHandler(this.btnAdel_Click);
            // 
            // macTrackBar1Duracion
            // 
            this.macTrackBar1Duracion.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1Duracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1Duracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1Duracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1Duracion.IndentHeight = 6;
            this.macTrackBar1Duracion.Location = new System.Drawing.Point(3, 0);
            this.macTrackBar1Duracion.Maximum = 100;
            this.macTrackBar1Duracion.Minimum = 0;
            this.macTrackBar1Duracion.Name = "macTrackBar1Duracion";
            this.macTrackBar1Duracion.Size = new System.Drawing.Size(409, 28);
            this.macTrackBar1Duracion.TabIndex = 4;
            this.macTrackBar1Duracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1Duracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar1Duracion.TickHeight = 4;
            this.macTrackBar1Duracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1Duracion.TrackerColor = System.Drawing.Color.Fuchsia;
            this.macTrackBar1Duracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1Duracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.TrackLineHeight = 3;
            this.macTrackBar1Duracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.Value = 0;
            this.macTrackBar1Duracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1Duracion_ValueChanged);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.BackgroundImage")));
            this.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Location = new System.Drawing.Point(142, 38);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(72, 57);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click_1);
            // 
            // Media
            // 
            this.Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(0, 24);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(415, 278);
            this.Media.TabIndex = 2;
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 283);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 409);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MAKI Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimerFI;
        private System.Windows.Forms.Label lblTimerIN;
        private System.Windows.Forms.Button btnRetr;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnAdel;
        private XComponent.SliderBar.MACTrackBar lblVolumen;
        private XComponent.SliderBar.MACTrackBar macTrackBar1Duracion;
        private System.Windows.Forms.Button btnPlayPause;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Label lblTitulo;
    }
}

