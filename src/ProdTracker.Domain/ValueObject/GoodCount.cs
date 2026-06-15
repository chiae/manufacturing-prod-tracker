using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ProdTracker.Domain.ValueObject;

public record GoodCount(int Value)
{
    public static GoodCount From(int Value)
    {
       if(Value < 0)
        {
            throw new ArgumentException("Quantity cannot be negative.");
        }
       return new GoodCount(Value);
    }
   
}
