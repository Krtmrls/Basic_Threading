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

namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
            btnRun.Click += btnRun_Click;   // wires the button, so don't double-click it
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            lblStatus.Text = "-Before starting thread-";

       
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

           
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End of Thread-";
        }
    }
}
        
    