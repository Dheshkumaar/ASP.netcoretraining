using API_Training_WFM.Abstractions;
using API_Training_WFM.Helper;
using API_Training_WFM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Training_WFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftlocksController : ControllerBase
    {
        private readonly ISoftlocksService _softlocksService;

        public SoftlocksController(ISoftlocksService softlocksService)
        {
            _softlocksService = softlocksService;
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllSoftlocks")]
        public IActionResult GetallSoftlocks()
        {
            try
            {
                var result = _softlocksService.GetSoftlocks();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred " + ex.Message.ToString());
            }

        }

        [Authorize]
        [HttpGet]
        [Route("GetSoftLocksById")]
        public ActionResult GetSoftLocksById(int lockid)
        {
            try
            {
                var softlock = _softlocksService.GetSoftlocksbyid(lockid);
                return Ok(softlock);
            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred " + ex.Message.ToString());
            }
        }

        [Authorize]
        [HttpPost]
        [Route("InsertSoftlocks")]
        public IActionResult InsertSoftlocks(Softlocks softlocks)
        {
            try
            {
                var result = _softlocksService.AddSoftlocks(softlocks);
                if (result)
                    return new JsonResult(new { message = "Inserted Successfully" }) { StatusCode = StatusCodes.Status200OK };
                else
                    return new JsonResult(new { message = "Failed to insert a record" }) { StatusCode = StatusCodes.Status500InternalServerError };

            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred " + ex.Message.ToString());
            }

        }

        [Authorize]
        [HttpPut]
        [Route("UpdateSoftlocks")]
        public IActionResult UpdateSoftlocks(Softlocks softlocks)
        {
            try
            {
                var result = _softlocksService.UpdateSoftlocks(softlocks);
                if (result)
                    return new JsonResult(new { message = "Updated Successfully" }) { StatusCode = StatusCodes.Status200OK };
                else
                    return new JsonResult(new { message = "No record Found" }) { StatusCode = StatusCodes.Status204NoContent };

            }
            catch (Exception ex)
            {
                return BadRequest("Exception occurred " + ex.Message.ToString());
            }

        }
    }
}
