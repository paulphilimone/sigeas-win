using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mz.betainteractive.sisga.model.ca{
    public class SDoor  {
        public Door DB;
        /*
        public int Id;
        public string Name;
        public int DoorType;
        */
        /*
        public SDoor(int id, string name, int type) {
            this.Id = id;
            this.Name = name;
            this.DoorType = type;
        }*/

        public SDoor(Door door) {
            this.DB = door;
            /*
            this.Id = door.ID;
            this.Name = door.Name;
            this.DoorType = door.DoorType;*/
        }

        public override bool Equals(object obj) {
            
            if (!(obj is SDoor)) {
                return true;
            }

            if (((SDoor)obj).DB.ID != this.DB.ID){ //|| d.Name != this.Name || d.DoorType != this.DoorType) {
                return false;
            }

            return true;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}
