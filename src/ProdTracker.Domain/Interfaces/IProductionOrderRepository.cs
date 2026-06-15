using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProdTracker.Domain.Entities;

namespace ProdTracker.Domain.Interfaces;

public interface IProductionOrderRepository
{
    Task<ProductionOrder?> GetByIdAsync(Guid id);
    Task AddAsync(ProductionOrder order);
    Task SaveChangesAsync();
}
