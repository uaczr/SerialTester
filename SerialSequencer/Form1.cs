using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace SerialSequencer
{
    public partial class Form1 : Form
    {
        SerialPort port;
        Thread work;
        Worker worker;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();

            Rate.Items.Add(9600);
            Rate.Items.Add(19200);
            Rate.Items.Add(38400);
            Rate.Items.Add(57600);
            Rate.Items.Add(76800);
            Rate.Items.Add(96000);
            Rate.Items.Add(115200);
            Rate.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ports.Items.Clear();
            String[] portnames = SerialPort.GetPortNames();
            if (portnames.Length == 0)
            {
                Ports.Items.Add("No Ports");
                
            }
            else
            {
                for (int i = 0; i < portnames.Length; i++)
                {
                    Ports.Items.Add(portnames[i]);
                }
            }
            Ports.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            worker = new Worker(Ports.Text, Convert.ToInt32(Rate.Text));
        }

        private void Ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            byte[] sendbytes = new byte[Convert.ToInt32(mLength.Text)];

            if(Byte1.Text != "" )
            {
                sendbytes[0] = Convert.ToByte(Byte1.Text);
            }
            if (Byte2.Text != "" )
            {
                sendbytes[1] = Convert.ToByte(Byte2.Text);
            }
            if (Byte3.Text != "" )
            {
                sendbytes[2] = Convert.ToByte(Byte3.Text);
            }
            if (Byte4.Text != "")
            {
                sendbytes[3] = Convert.ToByte(Byte4.Text);
            }
            if (Byte5.Text != "" )
            {
                sendbytes[4] = Convert.ToByte(Byte5.Text);
            }
            if (Byte6.Text != "" )
            {
                sendbytes[5] = Convert.ToByte(Byte6.Text);
            }
            if (Byte7.Text != "")
            {
                sendbytes[6] = Convert.ToByte(Byte7.Text);
            }



            worker.delay = Convert.ToInt32(Delay.Text);
            worker.sendbytes = sendbytes;
            if(work != null)
            {
                work.Abort();
                worker.port.Close();
            }
            work = new Thread(worker.doWork);
            work.Start();

            
            
        }
        

        private void Stopper_Click(object sender, EventArgs e)
        {
            worker.stopping = true;
            work.Abort();
            worker.port.Close();
        }

        
    }
}
