﻿using System;
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
        public void InstallApplication(Applications app)
        {
            Storage.ApplicationsInHardDrive = new List<Applications>();
            if (TemporaryMemory.totalGigabytes > app.RequiredRam && Storage.AvailableStorage > app.RequiredStorage)
            {
                Storage.ApplicationsInHardDrive.Add(app);
            }
            else
            {
                Console.WriteLine("Not enough memory space");
            }
        }
        public void ProcessInstall (Applications app, HardDrive hardDrive, RAM ram)
        {
            
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {

        }
    }
}
