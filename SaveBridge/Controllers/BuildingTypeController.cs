using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.BuildingConstructionType;
using System;
using Microsoft.AspNetCore.Authorization;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BuildingTypeController : ControllerBase
    {
        private readonly IBuildingConstructionTypeService _service;

        public BuildingTypeController(IBuildingConstructionTypeService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all Building Construction types
        /// </summary>
        /// <returns>All Building Construction Types</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Create new Building Construction type
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
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

        /// <summary>
        /// Delete a specific Building Construction type
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }

        /// <summary>
        /// Update a specific Building Construction type
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
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