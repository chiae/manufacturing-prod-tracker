using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdTracker.Domain.ValueObject;

public record ScrapCount(int Value)
{
    public static ScrapCount From(int Value)
    {
        if(Value < 0)
        {
            throw new ArgumentException("Quantity cannot be negative.");

        }
        return new ScrapCount(Value);
    }
}
