using AppFramework.Application;
using OLS.Domain.Entities.Entities.SleepAgg;

namespace OLS.Domain.Contracts.SleepContracts;

public interface ISleepRepository : IBaseRepository<long, Sleep>
{
}