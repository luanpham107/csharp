using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagement
{
    class NectarStinger : Worker, INectarCollector
    {
            
        public NectarStinger(string[] a) : base(string[] jobsICanDo)
        {
            
        }
        
        public int AlertLevel { get; }
        public int StingerLength { get; set; }
        public bool LookForEnemies()
        {
            return false;
        }
        public int SharpenStinger(int legnth)
        {
            return 0;
        }

        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }
    }
}
