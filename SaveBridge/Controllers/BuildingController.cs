using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.BuildingConstruction;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingConstructionService _service;

        public BuildingController(IBuildingConstructionService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get All Building Constructions
        /// </summary>
        /// <returns>All Building Constructions</returns>
        /// <response code="200">Success</response>
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Get Building Constructions by City
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Building Constructions in specific city</returns>
        /// <response code="200">Success</response>
        [HttpGet("getByCityId/{id}")]
        public IActionResult GetByCityId(Guid id)
        {
            var result = _service.GetByCityId(id);
            return Ok(result);
        }

        /// <summary>
        /// Create new Building Construction
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreateBuildingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }

        /// <summary>
        /// Delete a specific Building Construction
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
        public IActionResult Put([FromBody] UpdateBuildingViewModel model)
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