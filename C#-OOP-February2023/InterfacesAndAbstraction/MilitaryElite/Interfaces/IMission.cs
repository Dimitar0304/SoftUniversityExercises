﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    public  interface IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }
        void CompleteMission();
    }
}
