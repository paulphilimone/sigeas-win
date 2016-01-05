using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mz.betainteractive.sigeas.model.basic {
    public class Hora {
        public int Horas;
        public int Minutos;

        public Hora() { 
        }

        public Hora(int h, int m) {
            this.Horas = h;
            this.Minutos = m;
        }

        public static Hora Create(int h, int m) {
            return new Hora(h, m);
        }

        public static Hora GetFromText(string horas) {
            Hora hour = null;

            string[] sp = horas.Split(':');

            int h = 0;
            int m = 0;

            try {
                h = Convert.ToInt32(sp[0]);
                m = Convert.ToInt32(sp[1]);
                hour = new Hora(h, m);
            } catch (Exception ex) {
                hour = new Hora();
            }
            
            return hour;
        }

        public void Add(Hora hora) {
            int mins = this.Minutos+hora.Minutos;
            int hors = mins / 60;
            this.Horas += hora.Horas + hors;            
            this.Minutos = (mins) % 60;
        }

        public static Hora SumAll(params Hora[] horas) {
            Hora hour = new Hora();

            foreach (Hora h in horas) {
                hour.Add(h);
            }             

            return hour;
        }

        public override string ToString() {
            string formated = "";
            string h = "0"+Horas;
            string m = "0"+Minutos;

            if (Horas >= 10) {
                h = Horas.ToString();
            }
            if (Minutos >= 10) {
                m = Minutos.ToString();
            }
            formated = h + ":" + m;

            return formated;
        }
    }
}
