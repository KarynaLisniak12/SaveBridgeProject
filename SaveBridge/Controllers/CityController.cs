using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.City;
using System;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _service;

        public CityController(ICityService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all Cities
        /// </summary>
        /// <returns>All Cities</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Create new City
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreateCityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }

        /// <summary>
        /// Delete a specific City
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}