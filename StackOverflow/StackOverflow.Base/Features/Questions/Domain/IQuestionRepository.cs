using StackOverflow.Base.Features.Questions.Entities;
using StackOverflow.Base.Features.Questions.ViewModels;

namespace StackOverflow.Base.Features.Questions.Domain
{
    public interface IQuestionRepository
    {
        public Task<Question> Insert(Question model);
    }
}
