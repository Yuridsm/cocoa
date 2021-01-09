﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cocoa.Interfaces;
namespace cocoa.Services
{
    public class RenderSingletonService : IRenderSingleton
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}
