using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.Domain.Models;

public class Drug
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }
    public int NumOfUnits { get; set; }
}