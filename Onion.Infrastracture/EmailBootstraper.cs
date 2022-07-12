using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Onion.Application;
using Onion.Application.Contract.Email;
using Onion.Infrastracture.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Infrastracture
{
    public class EmailBootstraper 
    {
        public static void Configure(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IEmailApplication , EmailApplication>();
            services.AddDbContext<OnionContext>(options => options.UseSqlServer(connectionString)); 
        }
    }
}
