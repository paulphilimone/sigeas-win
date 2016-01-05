using System;
using System.Collections.Generic;

namespace mz.betainteractive.sigeas.Models.Entities {

    public partial class DoorType {

        public static String GENERAL_ACCESS_CONTROL = "Controle de Acesso Geral <Livro de Ponto>";   //Usado para calculos de asseduidade
        public static String PRIVATE_ACCESS_CONTROL = "Controle de Acesso Privado <Departamentos>"; //Departamento (Modulo 2)
        
                
        public long Id { get; set; }        
        public string Nome { get; set; }
        public string Descricao { get; set; }


        public override string ToString() {
            return this.Nome;
        }

        public override bool Equals(object obj) {
            if (obj is DoorType) {
                DoorType o = (DoorType)obj;
                return o.Id == this.Id;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
