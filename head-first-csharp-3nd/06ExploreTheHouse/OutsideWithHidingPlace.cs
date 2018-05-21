using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExploreTheHouse
{
    class OutsideWithHidingPlace : Location, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string NameOfHidingPlace) 
            : base(name)
        {
            this.Name = name;
            this.hot = hot;
            this.NameOfHidingPlace = NameOfHidingPlace;
        }

        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                    newDescription += " It's very hot.";
                return newDescription;
            }
        }

        public string NameOfHidingPlace { get; set; }

        private bool hot;
    }
}
