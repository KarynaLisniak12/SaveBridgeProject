using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.BuildingConstructionType;
using System;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    public class BuildingConstructionTypeController : Controller
    {
        private readonly IBuildingConstructionTypeService _service;

        public BuildingConstructionTypeController(IBuildingConstructionTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateBuildingTypeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateBuildingTypeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Update(model);
            return Ok();
        }
    }
}