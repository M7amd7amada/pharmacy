using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Models;

public class Drug
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public decimal Price { get; set; }
}