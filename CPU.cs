using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class CPU
    {
        public string manufacturer;
        public string name;
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            double takeMemorySpace;
            takeMemorySpace = hardDrive.availableStorage - app.requiredStorage;


        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool availableMemorySpace = false;
                if ((app.requiredRAM < ram.totalGigabytes) && (app.requiredStorage < hardDrive.availableStorage))
                {
                    ProcessInstall(app, hardDrive, ram);
                    availableMemorySpace = true;
                }
                else
                {
                    Console.WriteLine("Memory is full");
                }
            return availableMemorySpace;
        }
        public bool CheckGraphicsRequirementsForGame(Applications app, HardDrive hardDrive, Games games, GPU gpu, RAM ram)
        {
            bool meetsSystemGraphicsRequirements = false;
            if (app == games)
            {
                if( gpu.effectiveMemory > games.requiredEffectiveMemory)
                {
                    CheckRequirements(app, hardDrive, ram);
                    meetsSystemGraphicsRequirements = true;
                }
                else
                {
                    Console.WriteLine("System does not meet the required effective memory");
                }
            }
            else
            {
                
            }
            return meetsSystemGraphicsRequirements;
        }
    }
    
 
}
