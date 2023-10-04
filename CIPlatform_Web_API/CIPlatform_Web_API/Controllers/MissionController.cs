using CIPlatform_Web_API.Infrastructure;
using CIPlatform_Web_API.Models;
using CIPlatform_Web_API.Models.Request;
using CIPlatform_Web_API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CIPlatform_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionController : Controller
    {
        private readonly IMissionTableRepository missionTableRepository;
        protected APIResponse _response;
        public MissionController(IMissionTableRepository missionTableRepository)
        {
            this.missionTableRepository = missionTableRepository;
            _response = new();
        }


        [HttpGet("{id:int}", Name = "GetMission")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetMission(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var mission = await missionTableRepository.GetMissionTableById(id);
                if (mission == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = mission;
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
        public async Task<ActionResult<APIResponse>> GetMissions()
        {
            try
            {
                IEnumerable<Mission> missionTables;
                missionTables = await missionTableRepository.GetMissionTable();
                _response.Result = missionTables;
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
        public async Task<ActionResult<APIResponse>> CreatetMission([FromBody] MissionRequestModel createDTO)
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

                Mission mission = createDTO.ToEntity();

                mission = await missionTableRepository.AddMissionTable(mission);
                _response.Result = mission;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetMission", new { id = mission.Id }, _response);
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
        [HttpDelete("{id:int}", Name = "DeletetMission")]
        public async Task<ActionResult<APIResponse>> DeletetMission(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var villa = await missionTableRepository.GetMissionTableById(id);
                if (villa == null)
                {
                    return NotFound();
                }
                await missionTableRepository.DeleteMissionTable(villa);
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

        [HttpPut("{id:int}", Name = "UpdateMission")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateMission(int id, [FromBody] MissionRequestModel updateDTO)
        {
            try
            {
                if (updateDTO == null)
                {
                    return BadRequest();
                }

                Mission dbMission = await this.missionTableRepository.GetMissionTableById(id);
                Mission model = updateDTO.ToEntity();

                await missionTableRepository.UpdateMissionTable(dbMission, model);
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


        [HttpGet("showAllMissions")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetMissions(
    [FromQuery] string? theme,
    [FromQuery] string? skills,
    [FromQuery] string? search)
        {
            try
            {
                IEnumerable<Mission> missionTables;

                // Query the repository for missions based on filters and search terms
                missionTables = await missionTableRepository.FilterMissions(theme, skills, search);

                _response.Result = missionTables;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }


    }

}

