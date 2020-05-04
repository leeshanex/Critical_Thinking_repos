using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    abstract class Applications
    {
        public string applicationName;
        public string applicationType;
        public double requiredRAM;
        public double requiredStorage;
        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messaging service";
            requiredRAM = 4.0;
            requiredStorage = 0.512;
        }
    }
}
