using APBD4.Models;
using APBD4.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VisitController : ControllerBase
{
    private readonly VisitService _visitService;

    public VisitController(VisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpGet("animal/{animalId}")]
    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId) =>
        _visitService.GetVisitsByAnimalId(animalId);

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        _visitService.AddVisit(visit);
        return Ok();
    }
}