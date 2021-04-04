using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAKI_Player
{
    public partial class Form1 : Form
    {

        int vl = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        private string ruta = "";


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblNum.Text = (lblVolumen.Value = Media.settings.volume = vl).ToString();
            this.Media.uiMode = "none";
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            lblVolumen.Visible = true;
        }

        private void macTrackBar2Volumen_MouseLeave(object sender, EventArgs e)
        {
            lblVolumen.Visible = false;
        }

       private void btnPlayPause_Click_1(object sender, EventArgs e)
       {
           if (play == 1)
           {
             AbrirMusica();
             play = 2;
           }
           else if (play == 2)
           {
           Media.Ctlcontrols.pause();
           tmSlider.Stop();

           btnPlayPause.BackgroundImage = Properties.Resources.resume_48px;
           play = 3;
           }
           else if (play == 3)
           {
           Media.Ctlcontrols.play();
           tmSlider.Start();

           btnPlayPause.BackgroundImage = Properties.Resources.pause_48px;
           play = 2;
           }
       }

        public void AbrirMusica()
        {
            try
            {
                Media.URL = @"" + ruta;
                Media.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                macTrackBar1Duracion.Enabled = true;

                btnPlayPause.BackgroundImage = Properties.Resources.pause_48px;
            }
            catch
            {

            }
        }

        private void macTrackBar1Duracion_ValueChanged(object sender, decimal value)
        {
            macTrackBar1Duracion.Maximum = (int)Media.currentMedia.duration;

            if (macTrackBar1Duracion.Value == (int)Media.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                Media.Ctlcontrols.currentPosition = macTrackBar1Duracion.Value;

            }

        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                macTrackBar1Duracion.Value = (int)Media.Ctlcontrols.currentPosition;
                lblTimerIN.Text = Media.Ctlcontrols.currentPositionString;
                lblTimerFI.Text = Media.currentMedia.durationString;
            }
            catch
            {

            }
        }

        private void btnRetr_Click(object sender, EventArgs e)
        {
            if ((macTrackBar1Duracion.Value = macTrackBar1Duracion.Value - 15) < 0)
            {
                macTrackBar1Duracion.Value = 0;
            }
            else
            {
                macTrackBar1Duracion.Value = macTrackBar1Duracion.Value - 15;
            }
        }

        public void AbrirArchivo() // 
        {

            archivo.Filter = "Archivo files|*.mp3;*.mp4;*";
            DialogResult dres1 = archivo.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            ruta = archivo.FileName;
            lblTitulo.Text = archivo.SafeFileName;


        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();

                if (ruta != "")
                {
                    play = 2;
                    AbrirMusica();

                }
                else
                {

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void macTrackBar2Volumen_ValueChanged(object sender, decimal value)
        {
            Media.settings.volume = lblVolumen.Value;

            lblNum.Text = Media.settings.volume.ToString();
        }

        private void btnAdel_Click(object sender, EventArgs e)
        {
            macTrackBar1Duracion.Value = macTrackBar1Duracion.Value + 10;
        }

        
    }
  }

   