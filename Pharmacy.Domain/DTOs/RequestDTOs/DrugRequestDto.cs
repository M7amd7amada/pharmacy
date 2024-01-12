using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.DTOs.RequestDTOs;

public class DrugRequestDto
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public decimal Price { get; set; } = 0;

    public int NumOfUnits { get; set; } = 1;
}