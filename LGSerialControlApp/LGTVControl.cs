using System;
using System.IO.Ports;
using System.Threading;

namespace LGSerialControlApp {
    public class LGTVControl {
        private readonly SerialPort sp;
        public int currentVol;
        public LGTVInput currentMainInput;
        private const string LGID = "01";


        public LGTVControl() {
            sp = new SerialPort
                     {
                         PortName = "COM1",
                         BaudRate = 9600,
                         Parity = Parity.None,
                         StopBits = StopBits.One,
                         DataBits = 8
                     };
            sp.NewLine = "\n";
            sp.ReadTimeout = 500;
            sp.Open();
        }

        #region Readers, to get current values from TV
        public void readAllCurrentValues()
        {
            this.readCurrentVolume();
            this.readCurrentMainInput();
        }

        public void readCurrentVolume() {
            string resp = sendLGCommand("kf", "FF");
            currentVol = parseLGResponseHexa(resp);
            Console.Out.WriteLine("currentVol: " + currentVol);
        }

        public void readCurrentMainInput() {
            string resp = sendLGCommand("xb", "FF");
            int currInp = parseLGResponseInt(resp);
            Console.Out.WriteLine("Current Input:" + currInp);
        }
        #endregion

        #region Response parsers, very horrible code, ack.

        private int parseLGResponseHexa(string resp) {
            String[] splitter = new string[1];
            splitter[0] = "OK";
            String[] partes = resp.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            String naco = partes[1];
            String num = naco.Substring(0, 2);
            int decAgain = int.Parse(num, System.Globalization.NumberStyles.HexNumber);
            return decAgain;
        }


        private int parseLGResponseInt(string resp)
        {
            String[] splitter = new string[1];
            splitter[0] = "OK";
            String[] partes = resp.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            String naco = partes[1];
            String num = naco.Substring(0, 2);
            int decAgain = int.Parse(num, System.Globalization.NumberStyles.Integer);
            return decAgain;
        }

        #endregion

        public void SetaVolume(int vol) {
            String resp = sendLGCommand("kf", vol.ToString("X"));
        }

        public string sendLGCommand(String command, String value) {
            string commandFull = string.Format("{0} {1} {2}", command, LGID, value);
            Console.Out.WriteLine("Command:" + commandFull.Trim());
            sp.WriteLine(commandFull);
            Thread.Sleep(50);
            string resp = sp.ReadLine();
            Console.Out.WriteLine("Response:" + resp.Trim());
            sp.DiscardInBuffer();
            sp.DiscardOutBuffer();
            Thread.Sleep(50);
            return resp;
        }

        public void Close() {
            sp.Close();
        }

    }

    public enum LGTVInput {
        
    }
}