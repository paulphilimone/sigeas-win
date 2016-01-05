using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mz.betainteractive.sigeas.Models.Entities {
    public class PeriodoTempo {
        public static string DIARIO = "Diário(a)";
        public static string SEMANAL = "Semanal";
        public static string MENSAL = "Mensal";
        public static string TRIMESTRAL = "Trimestral";
        public static string SEMESTRAL = "Semestral";
        public static string ANUAL = "Anual";

        public int Id { get; set; }
        public string Descricao { get; set; }

        //Methods
        public override string ToString() {
            return this.Descricao;
        }

        public override bool Equals(object obj) {
            if (obj is PeriodoTempo) {
                PeriodoTempo cast = (PeriodoTempo)obj;
                return this.Id == cast.Id;
            }

            return false;
        }

        public override int GetHashCode() {
            return 0;
        }

        public PeriodoTempo This {
            get { return this; }
        }
    }
}
