namespace Pharmacy.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public Task<bool> CompleteAsync();
}