using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities {

    public partial class FuncionarioHorario  {

        public long Id { get; set; }
                
        public int Ordem { get; set; }
        public int Ano { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        
        public virtual Funcionario Funcionario { get; set; }
        public virtual HorarioSemana Horario { get; set; }
        public virtual PeriodoTempo Periodo { get; set; }


        //public int Ano { get; set; }        
        //public bool IsSemanal { get; set; }

        //public virtual SemanaAno PeriodoMensal { get; set; }
        //public virtual MesAno PeriodoSemanal { get; set; }
    }
}
