using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class Computer
    {
        
        public Computer()
        {
            HardDrive hardDrive = new HardDrive();
            GPU gpu = new GPU();
            RAM ram = new RAM();
            CPU cpu = new CPU();
            Motherboard motherboard = new Motherboard("Lenovo",ram, cpu, hardDrive, gpu);
            motherboard.InstallApplication();


        }
    }
}
