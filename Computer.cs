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
            ram.totalGigabytes = 16.0;
            cpu.manufacturer = "Intel";
            cpu.name = "i7-9700";
            hardDrive.totalStorage = 1000.0;
            hardDrive.availableStorage = 950.0;
            gpu.manufacturer = "Nvidia";
            gpu.effectiveMemory = 16.0;


            Games games = new Games();
            motherboard.InstallApplication(app, hardDrive, ram, games, gpu);
        }
    }
}
