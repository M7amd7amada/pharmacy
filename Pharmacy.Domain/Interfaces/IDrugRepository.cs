using Pharmacy.Domain.DTOs.RequestDTOs;
using Pharmacy.Domain.DTOs.ResponseDTOs;
using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Interfaces;

public interface IDrugRepository : IRepositoryBase<Drug, DrugRequestDto, DrugResponseDto>
{

}