using MediatR;

using ProdTracker.Domain.Enum;
using ProdTracker.Domain.ValueObject;

namespace ProdTracker.Application.Commands.AddBuildAction;

public sealed record GetBuildActionQuery(
    Guid ProductionOrderId,
    Guid BuildActionId
) : IRequest<BuildActionDto>;
