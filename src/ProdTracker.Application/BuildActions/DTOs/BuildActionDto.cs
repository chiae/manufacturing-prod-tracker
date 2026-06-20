using ProdTracker.Domain.Enum;

public sealed record BuildActionDto(
    Guid Id,
    int GoodCount,
    int Scrapcount,
    ScrapReason Reason,
    DateTime Timestamp);
