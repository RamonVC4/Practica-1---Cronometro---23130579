using System.Diagnostics;

namespace Practica_1___Cronometro___23130579
{
    public partial class Form1 : Form
    {
        private int sec = 0, min = 0, hora = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrTemporizador.Enabled = true;
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hora++;
                }

            }
            lblCronometro.Text = $"{hora:D2}:{min:D2}:{sec:D2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            sec = 0;
            min = 0;
            hora = 0;
            lblCronometro.Text = "00:00:00";

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrTemporizador.Enabled = false;
        }
    }
}
