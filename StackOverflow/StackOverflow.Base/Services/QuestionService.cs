using Azure.Core;
using StackOverflow.Base.Data;
using StackOverflow.Base.Features.Questions.Entities;
using StackOverflow.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> InsertFEAsync(InsertQuestionVM model)
        {
            try
            {
                Question data = new Question();
                data.QuestionTitle = model.QuestionTitle;
                data.QuestionBody = model.QuestionBody;

                await _unitOfWork.QuestionRepository.InsertAsync(data);

                if (await _unitOfWork.SaveChangesAsync())
                {
                    return true;
                }
                return false;
            }
            catch (Exception exception)
            {
                throw new InvalidOperationException(exception.Message, exception);
            }
        }

        public Task<string> UpdateFEAsync(InsertQuestionVM model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InsertQuestionVM>> GetAllFEAsync()
        {
            throw new NotImplementedException();
        }

        public Task<InsertQuestionVM> GetQuestionByFEIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteFEAsync(long id)
        {
            throw new NotImplementedException();
        }

    }
}
