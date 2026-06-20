using MediatR;

using ProdTracker.Domain.Enum;
using ProdTracker.Domain.ValueObject;

namespace ProdTracker.Application.Commands.AddBuildAction;

public sealed record AddBuildActionCommand(
    Guid ProductionOrderId,
    GoodCount GCount,
    ScrapCount SCount,
    ScrapReason Reason
) : IRequest<BuildActionDto>;
