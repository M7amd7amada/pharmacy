using AutoMapper;

using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Settings;

using Microsoft.Extensions.Options;

namespace Pharmacy.DataAccess.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context, IMapper mapper, IOptions<AppSettings> appSettings)
    {
        _context = context;
    }

    public async Task<bool> CompleteAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async void Dispose()
    {
        await _context.DisposeAsync();
    }
}