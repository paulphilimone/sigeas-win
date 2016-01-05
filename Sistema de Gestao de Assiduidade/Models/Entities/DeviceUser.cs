using System;
using System.Collections.Generic;

namespace  mz.betainteractive.sigeas.Models.Entities {

    public partial class DeviceUser {
        public int Id { get; set; }
        public int EnrollNumber { get; set; }        
        public string CardNumber { get; set; }

        public virtual Device Device { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        public DeviceUser() {
            this.EnrollNumber = 0;
        }
    }

}
