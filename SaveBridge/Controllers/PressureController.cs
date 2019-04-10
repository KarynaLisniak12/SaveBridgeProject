using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.Pressure;
using System;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PressureController : ControllerBase
    {
        private readonly IPressureService _service;

        public PressureController(IPressureService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Pressure records by Building Construction id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Pressure records of specific Building Construction</returns>
        /// <response code="200">Success</response>
        [HttpGet("getByBuildingId/{id}")]
        public IActionResult GetByBuildingId(Guid id)
        {
            var result = _service.GetByBuildingConstructionId(id);
            return Ok(result);
        }

        /// <summary>
        /// Create new Pressure Record
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreatePressureViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }
    }
}