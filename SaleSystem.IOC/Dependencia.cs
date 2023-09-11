using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaleSystem.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SaleSystem.DAL.Interfaces;
//using SaleSystem.DAL.Implementacion;
//using SaleSystem.BLL.Interfaces;
//using SaleSystem.BLL.Implementacion;

namespace SaleSystem.IOC
{
    public static class Dependencia
    {
        public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
