using MediatR;

using ProdTracker.Domain.Entities;
using ProdTracker.Domain.Interfaces;
using ProdTracker.Domain.ValueObject;
using ProdTracker.Domain.Enum;

namespace ProdTracker.Application.Commands.AddBuildAction;

public sealed class AddBuildActionCommandHandler :
    IRequestHandler<AddBuildActionCommand, BuildActionDto>
{
    private readonly IProductionOrderRepository _repository;

    public AddBuildActionCommandHandler(IProductionOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<BuildActionDto> Handle(AddBuildActionCommand command, CancellationToken ct)
    {
        var order = await _repository.GetByIdAsync(command.ProductionOrderId, ct);

        if (order is null)
        {
            throw new Exception("Order not found");
        }
            

        var action = new BuildAction(
            command.GCount,
            command.SCount,
            command.Reason
        );

        order.AddBuildAction(action);

        await _repository.SaveChangesAsync();

        return new BuildActionDto(
            action.Id,
            action.GoodCount.Value,
            action.ScrapCount.Value,
            action.Reason,
            action.TimeStamp
        );


    }
}
