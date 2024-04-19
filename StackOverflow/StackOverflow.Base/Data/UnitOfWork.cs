using StackOverflow.Base.DataContext;
using StackOverflow.Base.Features.Questions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
      
        public UnitOfWork(ApplicationDbContext context) 
        { 
            _context = context;
        }

        private IQuestionRepository? _questionRepository;
        public IQuestionRepository QuestionRepository =>
            _questionRepository ?? new QuestionRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
