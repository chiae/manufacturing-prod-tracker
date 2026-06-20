using MediatR;

using ProdTracker.Application.Commands.AddBuildAction;
using ProdTracker.Domain.Entities;
using ProdTracker.Domain.Enum;
using ProdTracker.Domain.Interfaces;
using ProdTracker.Domain.ValueObject;

namespace ProdTracker.Application.BuildActions.GetBuildAction;

public class GetBuildActionQueryHandler : IRequestHandler<GetBuildActionQuery, BuildActionDto>
{
    private readonly IProductionOrderRepository _repo;
    public GetBuildActionQueryHandler(IProductionOrderRepository repo)
    {
        _repo = repo;
    }

    public async Task<BuildActionDto> Handle(GetBuildActionQuery request, CancellationToken cancellationToken)
    {
        // load BuildAction from repo

        ProductionOrder productionOrder = await _repo.GetByIdAsync(request.ProductionOrderId, cancellationToken);

        if(productionOrder is null)
        {
            throw new Exception("Production order not found");
        }
        BuildAction buildAction = productionOrder.BuildActions.FirstOrDefault(x => x.Id == request.BuildActionId);

        if (buildAction is null)
        {
            throw new Exception("Build action not found");
        }
        return new BuildActionDto(
        buildAction.Id,
        buildAction.GoodCount.Value,
        buildAction.ScrapCount.Value,
        buildAction.Reason,
        buildAction.TimeStamp
    );
    }
}

