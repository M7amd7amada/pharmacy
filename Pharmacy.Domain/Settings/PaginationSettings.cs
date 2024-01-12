namespace Pharmacy.Domain.Settings;

public class PaginationSettings
{
    public int DefaultPageSize { get; set; }
    public int DefaultPage { get; set; }
    public bool IsDescending { get; set; }
}