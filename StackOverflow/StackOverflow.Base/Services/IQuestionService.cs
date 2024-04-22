using StackOverflow.Base.Features.Questions.Entities;
using StackOverflow.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Services
{
    public interface IQuestionService
    {
        public Task<bool> InsertFEAsync(InsertQuestionVM model);
        public Task<string> UpdateFEAsync(InsertQuestionVM model);
        public Task<long> DeleteFEAsync(long id);
        public Task<IEnumerable<InsertQuestionVM>> GetAllFEAsync();
        public Task<InsertQuestionVM> GetQuestionByFEIdAsync(long id);
    }
}
