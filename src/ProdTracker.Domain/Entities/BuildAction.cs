using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProdTracker.Domain.Enum;
using ProdTracker.Domain.ValueObject;

namespace ProdTracker.Domain.Entities;

public class BuildAction
{
    public Guid Id { get; private set; }
    public GoodCount GoodCount { get; private set;  }
    public ScrapCount ScrapCount { get; private set;  }
    public ScrapReason Reason { get; private set; }
    public DateTime TimeStamp { get; private set; }


    public BuildAction(GoodCount good, ScrapCount scrap, ScrapReason reason)
    {
        Id = new Guid();
        GoodCount = good;
        ScrapCount = scrap;
        Reason = reason;
        TimeStamp = DateTime.Now;  
    }

}
