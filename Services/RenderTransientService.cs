﻿using cocoa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cocoa.Services
{
    public class RenderTransientService : IRenderTransient
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}
