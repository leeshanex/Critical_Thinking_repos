using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class Computer
    {
        public Applications app;
        public Computer()
        {
            HardDrive hardDrive = new HardDrive();
            GPU gpu = new GPU();
            RAM ram = new RAM();
            CPU cpu = new CPU();
  
            Motherboard motherboard = new Motherboard("Lenovo",ram, cpu, hardDrive, gpu);
            Games games = new Games();
            motherboard.InstallApplication(app, hardDrive, ram, games, gpu);
           


        }
    }
}
