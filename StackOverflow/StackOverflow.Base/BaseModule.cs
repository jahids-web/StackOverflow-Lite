using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackOverflow.Base.Data;
using StackOverflow.Base.DataContext;
using StackOverflow.Base.Features.Questions.Domain;
using StackOverflow.Base.Services;

namespace StackOverflow.Base
{
    public class BaseModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public BaseModule(string connectionString,
            string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<QuestionRepository>().As<IQuestionRepository>()
                .InstancePerLifetimeScope(); 
            
            builder.RegisterType<QuestionService>().As<IQuestionService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }

        public static void Dependency(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IQuestionService, QuestionService>();

        }

    }
}
