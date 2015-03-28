using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;

namespace SerialSequencer
{
    class Worker
    {
        public SerialPort port;
        public byte[] sendbytes;
        public int delay;
        public volatile bool stopping = false;

        public Worker(String portname, int Baudrate)
        {
            port = new SerialPort(); 
            port.PortName = portname;
            port.BaudRate = Baudrate;
        }

        public void doWork()
        {
            if(port.IsOpen)
            {
                port.Close();
            }
            port.Open();
            while (!stopping)
            {

                port.Write(sendbytes,0,sendbytes.Length);


                System.Threading.Thread.Sleep(delay);
            }
            port.Close();
        }
        public void Stop()
        {
            stopping = true;
        }
    }
}
