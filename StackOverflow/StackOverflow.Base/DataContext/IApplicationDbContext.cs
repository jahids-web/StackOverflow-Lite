using StackOverflow.Base.Features.Questions.Entities;
using System.Data.Entity;

namespace StackOverflow.Base.DataContext
{
    public interface IApplicationDbContext
    {
        public DbSet<Question> Questions { get; set; }
    }
}
