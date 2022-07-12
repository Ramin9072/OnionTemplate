
using _0_Framework._0_Framework.Domain.Domain;
using _0_Framework.BaseResultState;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application;
using Onion.Application.Contract.AtricaleCategory;
using Onion.Domain.AtricleAgg;
using Onion.Infrastracture.EFCore;
using Onion.Infrastracture.EFCore.Repository;

namespace Onion.Infrastracture
{
    public class ArticleCategoryBootstraper
    {
        public static void Configure(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IResultDetails, ResultDetails>();
            services.AddTransient<IBaseWorkFlowRepository, BaseWorkFlowRepository>();

            services.AddDbContext<OnionContext>(p => p.UseSqlServer(connectionString));
        }
    }
}