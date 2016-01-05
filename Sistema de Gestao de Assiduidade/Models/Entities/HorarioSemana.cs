using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities
{

    /*
     * When we load this class, we will use Include("Dias")
     */ 
    public partial class HorarioSemana {

        public long Id { get; set; }
        
        public int Codigo { get; set; }
        public string Descricao { get; set; }
                
        public bool HasFeriados { get; set; }
        public bool HasHorasExtras { get; set; }

        public HorarioDia Domingo { get { return GetHorarioDia(HorarioDia.DOMINGO); } }
        public HorarioDia Segunda { get { return GetHorarioDia(HorarioDia.SEGUNDA); } }
        public HorarioDia Terca { get { return GetHorarioDia(HorarioDia.TERCA); } }
        public HorarioDia Quarta { get { return GetHorarioDia(HorarioDia.QUARTA); } }
        public HorarioDia Quinta { get { return GetHorarioDia(HorarioDia.QUINTA); } }
        public HorarioDia Sexta { get { return GetHorarioDia(HorarioDia.SEXTA); } }
        public HorarioDia Sabado { get { return GetHorarioDia(HorarioDia.SABADO); } }
        
        public virtual List<HorarioDia> Dias { get; set; }

        public int TotalHoras { get; set; }
        public int TotalMinutos { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public HorarioSemana() {
            this.Dias = new List<HorarioDia>();
        }

        public HorarioSemana This {
            get { return this; }
        }

        public HorarioDia GetHorarioDia(DateTime date) {

            switch (date.DayOfWeek) {
                case DayOfWeek.Sunday: return this.Domingo;
                case DayOfWeek.Monday: return this.Segunda;
                case DayOfWeek.Tuesday: return this.Terca;
                case DayOfWeek.Wednesday: return this.Quarta;
                case DayOfWeek.Thursday: return this.Quinta;
                case DayOfWeek.Friday: return this.Sexta;
                case DayOfWeek.Saturday: return this.Sabado;
            }

            return null;
        }

        private HorarioDia GetHorarioDia(int dayOfWeek) {
            foreach (HorarioDia dia in this.Dias) {
                if (dia.WeekDay == dayOfWeek) {
                    return dia;
                }
            }
            
            return null;
        }

        public override string ToString() {
            return this.Descricao;
        }

        public override bool Equals(object obj) {
            if (obj is HorarioSemana) {
                HorarioSemana o = (HorarioSemana)obj;
                return o.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
