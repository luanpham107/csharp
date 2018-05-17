using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExploreTheHouse
{
    class Outside : Location
    {

        public Outside(string name, bool hot) : base(name)
        {
            this.Name = name;
            this.hot = hot;
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
        private bool hot;
    }
}
