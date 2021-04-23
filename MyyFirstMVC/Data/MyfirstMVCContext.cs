using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyfirstMVC.Models;

namespace MyfirstMVC.Data
{
    public class MyfirstMVCContext : DbContext
    {
        public MyfirstMVCContext (DbContextOptions<MyfirstMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyfirstMVC.Models.ShippingModel> ShippingModel { get; set; }
    }
}
