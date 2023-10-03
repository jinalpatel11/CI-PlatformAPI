using CIPlatform_Web_API.Infrastructure;
using CIPlatform_Web_API.Models.Request;
using CIPlatform_Web_API.Models;
using CIPlatform_Web_API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CIPlatform_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteeringController : ControllerBase
    {
        private readonly IVolunteeringTableRepository VolunteeringTableRepository;
        protected APIResponse _response;
        public VolunteeringController(IVolunteeringTableRepository VolunteeringTableRepository)
        {
            this.VolunteeringTableRepository = VolunteeringTableRepository;
            _response = new();
        }


        [HttpGet("{id:int}", Name = "GetVolunteering")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVolunteering(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villa = await VolunteeringTableRepository.GetVolunteeringDataById(id);
                if (villa == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = villa;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVolunteerings()
        {
            try
            {
                IEnumerable<VolunteeringTable> villaList;
                villaList = await VolunteeringTableRepository.GetVolunteeringData();
                _response.Result = villaList;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;

        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVolunteering([FromBody] VolunteeringRequestModel createDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

                VolunteeringTable villa = createDTO.ToEntity();

                villa = await VolunteeringTableRepository.AddVolunteeringData(villa);
                _response.Result = villa;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetVolunteering", new { id = villa.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVolunteering")]
        public async Task<ActionResult<APIResponse>> DeleteVolunteering(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var villa = await VolunteeringTableRepository.GetVolunteeringDataById(id);
                if (villa == null)
                {
                    return NotFound();
                }
                await VolunteeringTableRepository.DeleteVolunteeringData(villa);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("{id:int}", Name = "UpdateVolunteering")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVolunteering(int id, [FromBody] VolunteeringRequestModel updateDTO)
        {
            try
            {
                if (updateDTO == null)
                {
                    return BadRequest();
                }

                VolunteeringTable dbUser = await this.VolunteeringTableRepository.GetVolunteeringDataById(id);
                VolunteeringTable model = updateDTO.ToEntity();

                await VolunteeringTableRepository.UpdateVolunteeringData(dbUser, model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }


    }

}
