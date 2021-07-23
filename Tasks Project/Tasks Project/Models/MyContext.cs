using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasks_Project.Models.Data;

namespace Tasks_Project.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Step> Steps {get; set;}
        public DbSet<LittleStep> LittleSteps { get; set; }
    }
}
