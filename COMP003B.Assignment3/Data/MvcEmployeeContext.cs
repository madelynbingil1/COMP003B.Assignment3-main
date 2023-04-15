using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment3.Models;

    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<COMP003B.Assignment3.Models.Employee> Employee { get; set; }
    }
