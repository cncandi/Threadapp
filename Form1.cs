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

        Thread writeOne, writeTwo;

        private void writeGouge(BunifuRadialGauge bfg_neutral)
        {
            if (bfg1.InvokeRequired)
            {
                bfg1.BeginInvoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < 100; i++)
                    {
                        bfg_neutral.Value = i;
                        Thread.Sleep(1);
                        //Application.DoEvents();
                    }
                });
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    bfg_neutral.Value = i;
                    Thread.Sleep(1);
                    //Application.DoEvents();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeOne = new Thread(() => writeGouge(bfg1));
            writeTwo = new Thread(() => writeGouge(bfg2));

            writeOne.Start();
            writeTwo.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
