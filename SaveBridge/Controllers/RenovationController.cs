using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.Renovation;
using System;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenovationController : ControllerBase
    {
        private readonly IRenovationService _service;

        public RenovationController(IRenovationService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Renovations by Building Construction id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Renovations of specific Building Construction</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        public IActionResult GetByBuildingConstructionId(Guid id)
        {
            var result = _service.GetByBuildingConstructionId(id);
            return Ok(result);
        }

        /// <summary>
        /// Create new Renovation
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreateRenovationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }

        /// <summary>
        /// Update a specific Renovation
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPut]
        public IActionResult Put([FromBody] UpdateRenovationViewModel model)
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