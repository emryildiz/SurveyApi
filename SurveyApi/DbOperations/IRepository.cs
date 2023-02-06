﻿using SurveyApi.Common.Entities;

namespace SurveyApi.DbOperations
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task Add(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(int id);
    }
}
