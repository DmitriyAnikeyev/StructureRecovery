using System;
using System.Collections.Generic;
using System.Text;

namespace StructureRecovery
{
    [Flags]
    public enum Operation
    {
        Plus = 1,
        Multiply = 2,
        Undefined = 4,
    }
}
