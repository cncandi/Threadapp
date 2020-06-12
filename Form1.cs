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
            for (int i = 0; i <= 50; i++)
            {
                bfg1.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                bfg2.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 50; i++)
            {
                bfg3.Value = i;
                Thread.Sleep(500); //paust 1 Sekunde
                Application.DoEvents(); // Events abarbeiten (damit das UI nicht einfriert)
            }
        }
    }
}
