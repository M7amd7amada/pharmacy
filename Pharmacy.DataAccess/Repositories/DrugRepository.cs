using AutoMapper;
using Microsoft.Extensions.Options;
using Pharmacy.DataAccess.Data;
using Pharmacy.Domain.DTOs.RequestDTOs;
using Pharmacy.Domain.DTOs.ResponseDTOs;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Settings;

namespace Pharmacy.DataAccess.Repositories;

public class DrugRepository : RepositoryBase<Drug, DrugRequestDto, DrugResponseDto>, IDrugRepository
{
    public DrugRepository(
        AppDbContext context,
        IMapper mapper,
        IOptions<AppSettings> appSettings) : base(context, mapper, appSettings)
    {
    }
}