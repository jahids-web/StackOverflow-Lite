using StackOverflow.Base.Features.Questions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Data
{
    public interface IUnitOfWork
    {
       public IQuestionRepository QuestionRepository { get; }

       Task<bool> SaveChangesAsync();
    }
}
