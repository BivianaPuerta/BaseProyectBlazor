﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProyectBlazor.Client
{
    public class ServicesSingleton
    {
        public int Value {get; set;}
    }

    public class ServicesTransient
    {
        public int Value { get; set; }
    }
}
