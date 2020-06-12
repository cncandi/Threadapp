using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threadapp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            Abfragepunkt1(bfg1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abfragepunkt2(bfg2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abfragepunkt3(bfg3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thread für erste Abfrage
            Thread Thread_Erste,Thread_Zweite,Thread_Dritte;

        }

        public static void Erste_Abfrage(BunifuRadialGauge _bfg1)
        {
            if (_bfg1.InvokeRequired)
            {
                _bfg1.BeginInvoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i <= 50; i++)
                    {
                        _bfg1.Value = i;
                        Thread.Sleep(500); //paust 1 Sekunde

                    }
                });
            }
        }

        public static void Zweite_Abfrage()
        {
            for (int i = 0; i <= 50; i++)
            {

            }
        }

        public static void Dritte_Abfrage()
        {
            for (int i = 0; i <= 50; i++)
            {

            }
        }

        public static void Abfragepunkt1(BunifuRadialGauge _bfg1)
        {
            for (int i = 0; i <= 50; i++)
            {
                _bfg1.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }
        }
        public static void Abfragepunkt2(BunifuRadialGauge _bfg2)
        {
            for (int i = 0; i <= 50; i++)
            {
                _bfg2.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }
        }

        public static void Abfragepunkt3(BunifuRadialGauge _bfg3)
        {
            for (int i = 0; i <= 50; i++)
            {
                _bfg3.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
