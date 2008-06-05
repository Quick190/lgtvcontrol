using System;
using System.Globalization;
using System.IO.Ports;
using System.Threading;

namespace LGSerialControlApp {
    public class LGTVControl {
        private const string LGID = "01";
        private readonly SerialPort sp;
        public LGTVInput currentMainInput;
        public int currentVol;


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

        public void readAllCurrentValues() {
            readCurrentVolume();
            readCurrentMainInput();
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
            switch (currInp) {
                case 23:
                    currentMainInput = LGTVInput.AV1;
                    break;
                case 1:
                    currentMainInput = LGTVInput.TVCable;
                    break;
                case 90:
                    currentMainInput = LGTVInput.HDMIDVI1;
                    break;
            }
            Console.Out.WriteLine("CurrInputEnum:" + currentMainInput);
        }

        #endregion

        #region Response parsers, very horrible code, ack.

        private int parseLGResponseHexa(string resp) {
            var splitter = new string[1];
            splitter[0] = "OK";
            String[] partes = resp.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            String naco = partes[1];
            String num = naco.Substring(0, 2);
            int decAgain = int.Parse(num, NumberStyles.HexNumber);
            return decAgain;
        }


        private int parseLGResponseInt(string resp) {
            var splitter = new string[1];
            splitter[0] = "OK";
            String[] partes = resp.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            String naco = partes[1];
            String num = naco.Substring(0, 2);
            int decAgain = int.Parse(num, NumberStyles.Integer);
            return decAgain;
        }

        #endregion

        public void SetaVolume(int vol) {
            Console.Out.WriteLine("*** Setting volume: " + vol);
            String resp = sendLGCommand("kf", padValueForLGHex(vol));
        }

        public string sendLGCommand(String command, String value) {
            string commandFull = string.Format("{0} {1} {2}", command, LGID, value);
            Console.Out.WriteLine("Command:" + commandFull.Trim());
            sp.WriteLine(commandFull);
            Thread.Sleep(50);
            string resp = "";
            try {
                resp = sp.ReadLine();
                Console.Out.WriteLine("Response:" + resp.Trim());
            }
            catch (Exception) {
                Console.Out.WriteLine("Response timed OUT!");
            }
            sp.DiscardInBuffer();
            sp.DiscardOutBuffer();
            Thread.Sleep(50);
            return resp;
        }

        public void Close() {
            sp.Close();
        }

        public void setMainInputSource(LGTVInput input) {
            Console.Out.WriteLine("**** Setting Main input to " + input);
            String resp = sendLGCommand("xb", padValueForLGInt(Convert.ToInt32(input)));
        }

        public void setVolumeMuted(bool muted) {
            Console.Out.WriteLine("*** Setting muted: " + muted);
            string resp = sendLGCommand("ke", muted ? "0" : "1");
        }

        #region Helpers for sending values to TV

        private static String padValueForLGInt(int value) {
            if (value > 9) return value.ToString();
            return "0" + value;
        }

        private static String padValueForLGHex(int value) {
            string hexpart = value.ToString("X");
            if (hexpart.Length > 1) return hexpart;
            return "0" + hexpart;
        }

        #endregion

        public void setPower(bool tp) {
            Console.Out.WriteLine("**** Setting power to " + tp);
            string resp = sendLGCommand("ka", tp ? "1" : "0");
        }
    }

    public enum LGTVInput {
        TVCable = 10,
        AV1 = 20,
        HDMIDVI1 = 90,
    }
}