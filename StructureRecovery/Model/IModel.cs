using System;
using System.Collections.Generic;
using System.Text;

namespace StructureRecovery.Model
{
    public interface IModel
    {
        Tree Calc(Dataset data);
    }
}
