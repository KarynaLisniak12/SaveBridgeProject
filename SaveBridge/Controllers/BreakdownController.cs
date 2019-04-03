using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.Breakdown;
using System;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakdownController : ControllerBase
    {
        private readonly IBreakdownService _service;

        public BreakdownController(IBreakdownService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Breakdowns by Building Construction id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Breakdowns of specific Building Construction</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        public IActionResult GetByBuildingConstructionId(Guid id)
        {
            var result = _service.GetByBuildingConstructionId(id);
            return Ok(result);
        }

        /// <summary>
        /// Create new Breakdown
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreateBreakdownViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _service.Create(model);
            return Ok();
        }

        /// <summary>
        /// Update a specific Breakdown
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPut]
        public IActionResult Put([FromBody] UpdateBreakdownViewModel model)
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