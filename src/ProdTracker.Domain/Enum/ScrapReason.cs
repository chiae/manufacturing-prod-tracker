using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdTracker.Domain.Enum;

public enum ScrapReason
{
    None,
    Damaged,
    IncorrectAssembly,
    MissingComponent,
    Other
}
