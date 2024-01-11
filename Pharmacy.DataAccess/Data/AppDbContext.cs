using Microsoft.EntityFrameworkCore;

namespace Pharmacy.DataAccess.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

}