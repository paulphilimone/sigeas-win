/*
 * Backup para a versão que controlará as portas(portas de departamentos entradas e saidas)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mz.betainteractive.sisga.utilities;
using mz.betainteractive.sisga.model.ca;
using System.Globalization;

namespace mz.betainteractive.sisga {
    public partial class Funcionario {

        #region Attendance Stuff
        //Usuarios tem clocks organizados pela data
        //int porta, Dictionary<string, List<UserClock>>

        /*Will be used in other versions who control doors*/
        public Dictionary<Door, Dictionary<DateTime, List<UserClock>>> Clocks;
        //public Dictionary<DateTime, List<UserClock> Clocks;

        partial void OnCreated() {
            this.Clocks = new Dictionary<Door, Dictionary<DateTime, List<UserClock>>>(new EqualityComparerObjectAtt<Door>());
        }

        public List<UserClock> GetClocks() {
            List<UserClock> list = new List<UserClock>();

            foreach(var dcls in this.Clocks.Values){
                foreach (var lcs in dcls.Values) {
                    list.AddRange(lcs);
                }
            }

            return list;
        }

        public List<UserClock> GetValidClocks() {
            List<UserClock> list = new List<UserClock>();

            foreach (var dcls in this.Clocks.Values) {
                foreach (var lcs in dcls.Values) {
                    foreach (UserClock uc in lcs){
                        if (uc.Result == "OK") {
                            list.Add(uc);
                        }                        
                    }                    
                }
            }

            return list;
        }

        public List<UserClock> GetValidClocks(DateTime date) {
            
            List<UserClock> list = new List<UserClock>();

            DateTime dia = date.Date;

            foreach (var dcls in this.Clocks.Values) {
                foreach (var lcs in dcls.Values) {
                    foreach (UserClock uc in lcs) {
                        if (uc.Result == "OK") {
                            list.Add(uc);
                        }
                    }
                }
            }

            return list;
        }

        public void DownloadUserClocks() {
            this.Clocks.Clear();

            List<UserClock> uclocks = Download.FindAllUserClock(this);
            
            foreach (UserClock uclock in uclocks) {
                
                Door door = uclock.GetDoor();
                DateTime dt = uclock.DateAndTime.Value.Date; //Only Date not with Time

                //dt is like "01/01/2012"

                Dictionary<DateTime, List<UserClock>> dluc = null;

                if (this.Clocks.ContainsKey(door)) {
                    Clocks.TryGetValue(door, out dluc);
                } else {
                    dluc = new Dictionary<DateTime, List<UserClock>>();
                    Clocks.Add(door, dluc);
                }

                /*
                 * This list must be ordered by Time;
                 * This feature is handled on Download.FindAllUserClock(this)
                 */
                List<UserClock> luc = null;

                if (dluc.ContainsKey(dt)) {
                    dluc.TryGetValue(dt, out luc);
                    luc.Add(uclock);
                } else {
                    luc = new List<UserClock>();
                    luc.Add(uclock);
                    dluc.Add(dt, luc);
                }
            }

        }
                
        #endregion

        //Default Methods
        public override string ToString() {
            return this.Nome+" "+this.Apelido;
        }

        public override bool Equals(object obj) {
            if (obj is Funcionario) {
                Funcionario e = (Funcionario)obj;
                return e.ID == this.ID;
            }
            return false;
        }

        public override int GetHashCode() {
            return 0;//base.GetHashCode();
        }
    }
}
