using Volo.Abp.Domain.Entities;

namespace WebApp.SingleLayer.Entities;

public class TodoItem
    : BasicAggregateRoot<Guid>
{
    public string Text { get; set; } = string.Empty;
}
