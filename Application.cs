﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class Application
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRam;
        public double RequiredStorage;
        public Application()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRam = 4.0;
            RequiredStorage = 0.512;
        }
    }
}