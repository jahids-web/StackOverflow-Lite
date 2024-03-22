using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace StackOverflow.Base.DataContext
{
    public class ApplicationDbContext(DbContextOptions options) : base(Options)
    {

    }
}
