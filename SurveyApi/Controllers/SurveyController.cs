using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApi.Common.Dtos;
using SurveyApi.Common.Entities;
using SurveyApi.Services;

namespace SurveyApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly  SurveyService surveyService;
        private readonly  IMapper mapper;

        public SurveyController(SurveyService surveyService, IMapper mapper)
        {
            this.surveyService = surveyService;
            this.mapper = mapper;
        }

        [HttpGet("GetById")]
        public async Task<SurveyDto> GetSurveyById(int id)
        {
            return this.mapper.Map<SurveyDto>(await this.surveyService.GetById(id));
        }

        [HttpGet("GetAll")]
        public IEnumerable<SurveyDto> GetSurveys()
        {
            return this.mapper.Map<List<SurveyDto>>(this.surveyService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddSurvey([FromBody]SurveyCreateDto surveyDto)
        {
            try
            {
                Survey survey = this.mapper.Map<Survey>(surveyDto);

                survey.CreatedDate = DateTime.Now;

                await this.surveyService.Add(survey);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            try
            {
                await this.surveyService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO : Exceptionları belirleyip özel kontroller ekle

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserById(int id, [FromBody]SurveyCreateDto surveyDto)
        {
            try
            {
                Survey survey = this.mapper.Map<Survey>(surveyDto);

                await this.surveyService.Update(id, survey);

                return Ok();
            }
            catch (Exception ex)
            {
                //TODO : Exceptionları belirleyip özel kontroller ekle

                return BadRequest(ex.Message);
            }
        }
    }
}
