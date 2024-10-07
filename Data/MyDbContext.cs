using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PruebaNET_JuanPabloGomezBustamante.Data
{
    public class MyDbContext : DbContext
    {
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}