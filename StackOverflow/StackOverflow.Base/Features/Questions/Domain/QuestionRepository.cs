using StackOverflow.Base.Data;
using StackOverflow.Base.DataContext;
using StackOverflow.Base.Features.Questions.Entities;
using StackOverflow.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Features.Questions.Domain
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext context) : base(context)
        { 
        
        }
     

    }
}
