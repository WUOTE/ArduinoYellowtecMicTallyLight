using System;
using System.IO.Ports;

namespace mic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.Handshake = Handshake.None;
            port.RtsEnable = true;

            for (int i = 0; i < args.Length; i++)
            {
                string flag = args.GetValue(i).ToString();
                {
                    if (flag == "--off")
                    {
                        port.Open();
                        port.WriteLine("off");
                        port.Close();
                    }
                    else if (flag == "--hot")
                    {
                        port.Open();
                        port.WriteLine("hot");
                        port.Close();
                    }
                    else if (flag == "--idle")
                    {
                        port.Open();
                        port.WriteLine("idle");
                        port.Close();
                    }
                    else if (flag == string.Empty)
                    {
                        port.Open();
                        port.WriteLine("off");
                        port.Close();
                    }
                }
            }
            port.Close();
            Environment.Exit(0);
        }
    }
}