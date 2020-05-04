using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class Motherboard
    {
        public string Manufacturer;
        public RAM temporaryMemory;
        public CPU processor;
        public HardDrive storage;
        public GPU graphics;
        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;

        }
        public void InstallApplication(Applications app, HardDrive hardDrive, RAM ram, Games games, GPU gpu)
        {
            storage.ApplicationsInHardDrive = new List<Applications>();
            if (temporaryMemory.totalGigabytes > app.requiredRAM && storage.availableStorage > app.requiredStorage)
            {
                processor.CheckRequirements(app, hardDrive, ram, games, gpu);
                storage.ApplicationsInHardDrive.Add(app);
            }
            else
            {
                Console.WriteLine("Memory storage full");
            }
        }

      


    }
}
