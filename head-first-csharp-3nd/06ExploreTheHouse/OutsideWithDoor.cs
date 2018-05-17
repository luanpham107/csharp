using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExploreTheHouse
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string description) 
            : base(name, hot)
        {
            this.DoorDesciption = description;
        }
        public string DoorDesciption { get; private set; }        

        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + "You see " + DoorDesciption + ".";
            }
        }
    }
}
