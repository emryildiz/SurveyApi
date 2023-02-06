using SurveyApi.Common.Entities;
using SurveyApi.DbOperations;

namespace SurveyApi.Services
{
    public class UserService : GenericRepository<User>
    {
        public UserService(SurveyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
