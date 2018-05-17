using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagement
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int legnth);
    }

    interface INectarCollector : IStingPatrol
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
