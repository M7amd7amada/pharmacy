namespace Pharmacy.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public IDrugRepository Drugs { get; }

    public Task<bool> CompleteAsync();
}