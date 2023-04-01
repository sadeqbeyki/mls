using AppFramework.Domain;

namespace OLS.Domain.Entities.Entities.SleepAgg;

public class Sleep : BaseEntity
{
    public string DayName { get; set; } = string.Empty;
    public int Day { get; set; }
    public int Duration { get; set; }
    public bool Fragmented { get; set; }
    public int Fragment { get; set; }
    public bool Drink { get; set; }
    public string Description { get; set; } = string.Empty;
}
