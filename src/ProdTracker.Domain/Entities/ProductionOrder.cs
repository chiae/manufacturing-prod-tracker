using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdTracker.Domain.Entities;

public class ProductionOrder
{
    public Guid Id { get; private set; }
    public string OrderNumber { get; private set;  }
    public List<BuildAction> BuildActions { get; private set; } = new();

    public int TotalGood => BuildActions.Sum(x => x.GoodCount.Value);
    public int TotalScrap =>BuildActions.Sum(x=>x.ScrapCount.Value);

    public ProductionOrder(string  orderNumber)
    {
        Id = new Guid();
        OrderNumber = orderNumber;
    }

    public void AddBuildAction(BuildAction buildAction)
    {
        BuildActions.Add(buildAction);
    }
 

}

