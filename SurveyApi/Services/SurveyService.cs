using SurveyApi.Common.Dtos;
using SurveyApi.Common.Entities;
using SurveyApi.DbOperations;

namespace SurveyApi.Services
{
    public class SurveyService : GenericRepository<Survey>
    {
        public SurveyService(SurveyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
