using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pharmacy.Domain.DTOs.RequestDTOs;
using Pharmacy.Domain.DTOs.ResponseDTOs;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Settings;

namespace Pharmacy.WebUI.Controllers;

[Route("[controller]")]
public class DrugsController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDrugRepository _drugs;
    private readonly AppSettings _settings;
    private readonly PaginationSettings _pagination;

    public DrugsController(IUnitOfWork unitOfWork, IOptions<AppSettings> settings)
    {
        _unitOfWork = unitOfWork;
        _drugs = _unitOfWork.Drugs;
        _settings = settings.Value;
        _pagination = _settings.Pagination!;
    }

    public async Task<IActionResult> Index()
    {
        var drugsList = await _drugs.GetAllAsync(
            _pagination.DefaultPage,
            _pagination.DefaultPageSize,
            p => p.Id,
            _pagination.IsDescending);

        return View(drugsList);
    }

    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Delete(DrugRequestDto request)
    {
        DrugResponseDto deletedDrug = await _drugs.DeleteAsync(request);
        if (await _unitOfWork.CompleteAsync())
        {
            return RedirectToAction(nameof(Index));
        }
        return View();
    }

    [HttpGet]
    public IActionResult Edit()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Edit(DrugRequestDto request)
    {
        DrugResponseDto updatedDrug = await _drugs.UpdateAsync(request);
        if (await _unitOfWork.CompleteAsync())
        {
            return RedirectToAction(nameof(Index));
        }
        return View();
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(DrugRequestDto request)
    {
        DrugResponseDto addedDrug = await _drugs.InsertAsync(request);

        if (await _unitOfWork.CompleteAsync())
        {
            return RedirectToAction(nameof(Index));
        }
        return View();
    }
}