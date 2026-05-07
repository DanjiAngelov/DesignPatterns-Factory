using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Singleton
{
    public class StatisticsManager
    {
        private static StatisticsManager instance;

        private StatisticsManager() { }

        public static StatisticsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatisticsManager();
                return instance;
            }
        }

        public double TotalRevenue { get; set; }
    }
}
