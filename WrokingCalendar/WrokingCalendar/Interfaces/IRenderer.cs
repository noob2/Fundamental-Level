﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrokingCalendar.Interfaces
{
    public interface IRenderer
    {
        void WriteLine(string message);
        void Clear();
    }
}
