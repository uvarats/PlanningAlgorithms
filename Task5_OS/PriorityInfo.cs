using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_OS
{
    public class PriorityInfo
    {
        private static PriorityInfo _instance;
        private int processCount;
        private int prioritiesCount;
        public static PriorityInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PriorityInfo();
                }
                return _instance;
            }
        }
        private PriorityInfo() { }
        public int ProcessCount
        {
            get
            {
                return processCount;
            }
            set
            {
                if (value < 2)
                {
                    processCount = 2;
                } else
                if (value > 10)
                {
                    processCount = 10;
                } else
                {
                    processCount = value;
                }
            }
        }
        public int PrioritiesCount
        {
            get
            {
                return prioritiesCount;
            }
            set
            {
                if (value < 3)
                {
                    prioritiesCount = 3;
                }
                else
                if (value > 10)
                {
                    prioritiesCount = 10;
                }
                else
                {
                    prioritiesCount = value;
                }
            }
        }
    }
}
