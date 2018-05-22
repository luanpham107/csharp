using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExploreTheHouse
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        private string decoration;

        public RoomWithHidingPlace(string name, string decoration, string NameOfHidingPlace) 
            : base(name, decoration)
        {
            this.decoration = decoration;
            this.NameOfHidingPlace = NameOfHidingPlace;
        }

        public override string Description
        {
            get
            {
                return "You  see " + decoration + "." + "\r\n" 
                    + "Someone can hide in " + NameOfHidingPlace;
            }
        }

        public string NameOfHidingPlace { get; set; }
    }
}
