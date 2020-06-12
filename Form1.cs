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

        public int wartezeit = 120;

        public Form1()
        {
            InitializeComponent();

            Thread thread1 = new Thread(work1);
            Thread thread2 = new Thread(work2);
            Thread thread3 = new Thread(work3);

            //thread1.Priority= ThreadPriority.Highest;
            //thread2.Priority = ThreadPriority.Normal;
            //thread3.Priority = ThreadPriority.Lowest;


            // Start Stopped. 
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public async void work1()
        {
            for (int i = 0; i < 100; i++)
            {
                bfg1.Value = i;
                await Task.Factory.StartNew(() => Thread.Sleep(wartezeit));
            }
              
        }

        public async void work2()
        {
            for (int i = 0; i < 100; i++)
            {
                bfg2.Value = i;
                await Task.Factory.StartNew(() => Thread.Sleep(wartezeit));
            }
        }

        public async void work3()
        {
            for (int i = 0; i < 100; i++)
            {
                bfg3.Value = i;
                await Task.Factory.StartNew(() => Thread.Sleep(wartezeit));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Master Thread");
        }
    }
}
