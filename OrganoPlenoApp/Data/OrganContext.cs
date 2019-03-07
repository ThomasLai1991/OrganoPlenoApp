using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;

namespace OrganoPlenoApp.Models
{
    public class OrganContext : DbContext
    {
        //using the base class constructor
        public OrganContext(DbContextOptions<OrganContext> options) : base(options)
        {

        }

        //referenced entities will be included automatically by EF, for instance, <Specification> will be included,
        //because <Pipes> references <Specification>
        public DbSet<Organ> Organ { get; set; }
        public DbSet<Models.Console> Console { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Pipe> Pipe { get; set; }


    }
}
