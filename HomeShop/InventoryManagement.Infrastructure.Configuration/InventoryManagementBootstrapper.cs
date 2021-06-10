using InventoryManagement.Domain.InventoryAgg;
using InventoryManagement.Infrastructure.EFCore.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Application.Contract.Inventory;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Application;

namespace InventoryManagement.Infrastructure.Configuration
{
   public class InventoryManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IInventoryRepository, InventoryRepository>();
            services.AddTransient<IInventoryApplication, InventoryApplication>();
            services.AddDbContext<InventoryContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
