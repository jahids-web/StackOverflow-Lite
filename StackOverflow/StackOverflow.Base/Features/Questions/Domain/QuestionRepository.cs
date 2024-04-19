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
    public class QuestionRepository : IQuestionRepository
    {

        private readonly ApplicationDbContext _context;
        public QuestionRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

      
        public async Task<Question> Insert(Question model)
        {
            await _context.Questions.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
