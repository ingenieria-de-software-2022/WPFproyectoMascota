using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFproyectoMascota
{
    public partial class Form1 : Form
    {
        int life;

        public Form1()
        {
            InitializeComponent();
            life = 100;
            progressBar1.Value = life;
            substractLife();
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayedTime.Text = DateTime.Now.ToString("hh:mm:ss:f-dd/MM/yyyy");

            doActivities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione una actividad y elija la hora de realización,\nen caso de que la vida de la mascota llegue a 0 habrá perdido");
        }

        private async void substractLife()
        {
            await Task.Delay(8000);

            while (life > 0)
            {
                life -= 10;
                label1.Text = "Vida: " + life + "/100";
                progressBar1.Value = life;
                await Task.Delay(8000);
            }
        }

        private void doActivities()
        {
            if (displayedTime.Text == textBoxTime.Text)
            {
                if (eat.Checked)
                {
                    listBox1.Items.Add("Tamachi comió y acaba de recuperar vida\n");
                    life += 15;
                }
                if (stroll.Checked)
                {
                    listBox1.Items.Add("Tamachi es feliz de pasear contigo\n");
                    life += 10;
                }
                if (watchTv.Checked)
                {
                    listBox1.Items.Add("A Tamachi también le gusta ese programa\n");
                }
                if (play.Checked)
                {
                    listBox1.Items.Add("Tamachi esta más feliz por jugar\n");
                    life += 10;
                }
                if (break1.Checked)
                {
                    listBox1.Items.Add("Tamachi esta descansando después de jugar\n");
                    life += 10;
                }
                if (sleep1.Checked)
                {
                    listBox1.Items.Add("Tamachi se ha ido a dormir\n");
                    life += 10;
                }
                if (bath.Checked)
                {
                    listBox1.Items.Add("Tamachi ya necesitaba ir al baño, ahora es tu turno de limpiar\n");
                }
                if (heal.Checked)
                {
                    listBox1.Items.Add("Tamachi se acaba de curar y se siente mejor\n");
                    life += 10;
                }
                if (acariciar.Checked)
                {
                    listBox1.Items.Add("Tamachi esta feliz de ser acariciado\n");
                    life += 10;
                }
                if (talk.Checked)
                {
                    listBox1.Items.Add("Tamachi dice: \"Socorro Jesús, me siento mal\"\n");;
                }
            }
        }
    }
}
