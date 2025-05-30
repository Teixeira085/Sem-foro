using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form1 : Form
    {
        private int estadoAtual = 0;
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

        }
        private int tempo = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tempo = 0;

            vermelhoPbx.Visible = true;
            amareloPbx.Visible = true;
            verdePbx.Visible = true;

            timer2.Interval = 1000; // 1 segundo
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempo++;

            if (tempo == 3)
            {
                vermelhoPbx.Visible = false;
            }
            else if (tempo == 5)
            {
                amareloPbx.Visible = false;
            }
            else if (tempo == 8)
            {
                verdePbx.Visible = false;
                timer2.Stop(); // Para o timer
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer2.Stop();   // Pausa o timer
            tempo = 0;       // Reinicia o contador

            // Torna todos os semáforos visíveis novamente
            vermelhoPbx.Visible = true;
            amareloPbx.Visible = true;
            verdePbx.Visible = true;

        }
    }
}











