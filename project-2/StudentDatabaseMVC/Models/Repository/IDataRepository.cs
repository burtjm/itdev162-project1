using System.Collections.Generic;

namespace StudentDatabaseMVC.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(Student student, TEntity entity);
        void Delete(Student student);
    }
}