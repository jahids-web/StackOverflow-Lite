using StackOverflow.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Data
{
    public interface IRepositoryBase<T> where T : class 
    {
        Task InsertAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);
        Task<T> GetQuestionByIdAsync(Expression<Func<T, bool>> exception);
        Task<bool> SaveCompletedAsync();
    }
}
