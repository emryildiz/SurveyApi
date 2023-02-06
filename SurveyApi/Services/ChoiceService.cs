using SurveyApi.Common.Entities;
using SurveyApi.DbOperations;

namespace SurveyApi.Services
{
    public class ChoiceService : GenericRepository<Choise>
    {
        public ChoiceService(SurveyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
