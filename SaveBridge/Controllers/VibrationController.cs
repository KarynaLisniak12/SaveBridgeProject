using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaveBridge.BusinessLogic.Services.Interfaces;
using SaveBridge.ViewModels.Vibration;

namespace SaveBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VibrationController : ControllerBase
    {
        private readonly IVibrationService _service;

        public VibrationController(IVibrationService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Vibration records by Building Construction id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vibration records of specific Building Construction</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        public IActionResult GetByBuildingConstructionId(Guid id)
        {
            var result = _service.GetByBuildingConstructionId(id);
            return Ok(result);
        }

        /// <summary>
        /// Create new Vibration Record
        /// </summary>
        /// <param name="model"></param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        [HttpPost]
        public IActionResult Post([FromBody] CreateVibrationViewModel model)
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