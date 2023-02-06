using Microsoft.EntityFrameworkCore;
using SurveyApi.Common.Entities;

namespace SurveyApi.DbOperations
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        private readonly SurveyDbContext dbContext;

        public GenericRepository(SurveyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(TEntity entity)
        {
            await this.dbContext.Set<TEntity>()
                .AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            TEntity entity = await this.GetById(id);

            this.dbContext.Set<TEntity>().Remove(entity);
            await this.dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>()
                .AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await this.dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(int id, TEntity entity)
        {
            this.dbContext.Set<TEntity>().Update(entity);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
