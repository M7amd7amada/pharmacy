namespace Pharmacy.Domain.DTOs.ResponseDTOs;

public class DrugResponseDto
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int NumOfUnits { get; set; }
}