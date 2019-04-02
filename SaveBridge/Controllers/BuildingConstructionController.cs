using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.BuildingConstruction;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    public class BuildingConstructionController : Controller
    {
        private readonly IBuildingConstructionService _service;

        public BuildingConstructionController(IBuildingConstructionService service)
        {
            _service = service;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateBuildingConstruction model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.CreateBuildingConstruction(model);
            return Ok();
        }
    }
}