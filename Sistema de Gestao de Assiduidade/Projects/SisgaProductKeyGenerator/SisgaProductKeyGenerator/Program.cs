using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using mz.betainteractive.sigeas.bpkgenerator.Views;

namespace mz.betainteractive.sigeas.bpkgenerator {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGenerateKey());
            /*
            // A - B 
            //250-251=255
            //Se o resultado for negativo
            //256-(A-B)
            byte sum = Sum(250, 251);
            byte sub = Sub(250, 251);

            Console.WriteLine("250+251 = " + sum);
            Console.WriteLine("250-251 = " + sub);
            Console.WriteLine("Convert");
            Console.WriteLine(sum + "-251 = " + Sub(sum, 251));
            Console.WriteLine(sub + "+251 = " + Sum(sub, 251));
            Console.WriteLine();
            Console.WriteLine("255-"+ (255 ^ 255));
            Console.WriteLine("204-"+ (204 ^ 255));
            Console.WriteLine();
            EncryptTest();*/
        }

        
        private static void EncryptTest() {
            Random ra = new Random();

            string SN = "0113331130016";        //Serial Number
            string CD = "2011-03-30 16:51:39";  //Creation Date
            string Key = SN + CD;
            string BetaKey = "$BSGEKv1%";//Beta Sisga Enkript v1.0
            int LenSN = SN.Length;
            int LenCD = CD.Length;
            int random = ra.Next(256);

            string encbase = BetaKey + LenSN + "&" + LenCD + "&" + random + "?";            
            string enckey = ""; //Encrypted String
            string encripted = "";

            char[] keychars = Key.ToCharArray();

            for (int pos = 0; pos < keychars.Length; pos++) {
                char chr = keychars[pos];
                byte chb = (byte)chr;

                //inverter bits, i - inverted               
                byte chbi = (byte)(chb ^ 255);
                char chri = (char)chbi;
                                
                byte n = chbi;
                
                char en1 = (char)Sum(n, random + pos);
                char en2 = (char)Sub(n, random + pos);
                string encr = en1+""+en2;
                enckey += encr;

                Console.WriteLine(chr + " <-> " + chb + " to " + encr + " <-> " + (byte)en1 + "," + (byte)en2);
            }

            encripted = encbase + enckey;

            Console.WriteLine("Normal key   : "+Key);
            Console.WriteLine("Encrypted key: "+encripted);
            Console.WriteLine();
            Desyncript();

        }

        static void Desyncript() {

            string BetaKey = "$BSGEKv1%";
            string encripted = "$BSGEKv1%13&19&226?±í±ë²ê±ç²æ³å¶æ·å¶âºä»ã»á·Û¼Þ¿ß¿ÝÀÜÅßÃÛÁ×ÈÜÃÕÇ×ØæÈÔÄÎÁÉÇÍÌÐÄÆÌÌÇÅ";
            //Get encbase
            string encbase = encripted.Remove(encripted.IndexOf('?'));
            string enckey = encripted.Substring(encripted.IndexOf('?')+1);
            string Key = "";

            Console.WriteLine("encbase: "+encbase);
            Console.WriteLine("enckey : "+enckey);

            string[] snum = encbase.Replace(BetaKey, "").Split('&');

            int LenSN = Convert.ToInt32(snum[0]);
            int LenCD = Convert.ToInt32(snum[1]);
            int random = Convert.ToInt32(snum[2]);

            Console.WriteLine("LenSN  = "+LenSN);
            Console.WriteLine("LenCD  = " +LenCD);
            Console.WriteLine("random = " +random);

            char[] keychars = enckey.ToCharArray();

            //pos+=2, porque a chave encriptada é 2xMaior
            //Cada caracter equivale a dois caracteres
            //e só preciso o 1º caracter, ignoramos o 2º

            for (int pos = 0, p=0; pos < keychars.Length; pos+=2,p++) {
                char en1 = keychars[pos];
                char en2 = keychars[pos+1];//ignoramos
                //As somas, queremos "n":
                //char en1 = (char)Sum(n, random + pos);
                //char en2 = (char)Sub(n, random + pos);
                byte n = Sub((byte)en1, random + p);
                //Invertemos n, com um XOR
                byte chbi = (byte)(n ^ 255);

                char chr = (char)chbi;

                Console.WriteLine(en1+" to "+chr);
                Key += chr;
            }

            string SN = Key.Substring(0,LenSN);        //Serial Number
            string CD = Key.Substring(SN.Length);

            Console.WriteLine();
            Console.WriteLine("Encrypted: " + encripted);
            Console.WriteLine("Key: "+Key);
            Console.WriteLine("SN: "+SN);
            Console.WriteLine("CD: "+CD);
        }
        
        static byte Sum(byte number, int add) {
            return (byte) ((number + (add % 256)) % 256);
        }

        static byte Sub(byte number, int add) {
            byte n = (byte)((number - (add % 256)) % 256);
            if (n < 0) {
                return (byte)(256 + n);
            } else {
                return n;
            }            
        }
    }
}
