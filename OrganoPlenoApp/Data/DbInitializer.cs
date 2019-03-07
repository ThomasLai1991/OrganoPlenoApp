using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganoPlenoApp.Models;
using OrganoPlenoApp.Models.PipeEnumProperties;

namespace OrganoPlenoApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrganContext context)
        {

            //context.Database.Migrate();

            if (context.Organ.Any())
            {
                return;
            }
            // CREATE ORGANS
            var organs = new Organ[]
            {
                new  Organ{ Name ="Town Hall Organ"},
            };
            foreach (var organ in organs)
            {
                context.Organ.Add(organ);
            }
            context.SaveChanges();


            //CREATE DIVISIONS
            var divisions = new Division[]
            {
                new Division{ Name="Great",OrganID=organs.Single(o=>o.Name=="Town Hall Organ").ID},
                new Division{Name="Swell",OrganID=organs.Single(o=>o.Name=="Town Hall Organ").ID},
                new Division{Name="Pedal",OrganID=organs.Single(o=>o.Name=="Town Hall Organ").ID}
            };
            foreach (var dv in divisions)
            {
                context.Division.Add(dv);
            }
            context.SaveChanges();

            //CREATE PIPES
            var greatPipes = new Pipe[]
            {
                new Pipe {ID=1161,Name="Open Diapason",Category=Category.Principle,Specification=Specification.Sixteen,Material=Material.Metal,Price=1000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Great").ID},
                new Pipe {ID=1162,Name="Stopped Diapason",Category=Category.Principle,Specification=Specification.Sixteen,Material=Material.Wood,Price=1500,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Great").ID},
                new Pipe {ID=3041,Name="Wald Flute",Category=Category.Flute,Specification=Specification.Four,Material=Material.Wood,Price=2000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Great").ID},
                new Pipe {ID=4161,Name="Trumpet",Category=Category.Principle,Specification=Specification.Sixteen,Material=Material.Metal,Price=15000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Great").ID},
            };

            foreach (var gp in greatPipes)
            {
                context.Pipe.Add(gp);
            }
            context.SaveChanges();

            var swellPipes = new Pipe[]
{
                new Pipe {ID=3162,Name="Bourdon",Category=Category.Flute,Specification=Specification.Sixteen,Material=Material.Metal,Price=10000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Swell").ID},
                new Pipe {ID=2081,Name="Violin Diapason",Category=Category.String,Specification=Specification.Eight,Material=Material.Wood,Price=1500,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Swell").ID},
                new Pipe {ID=1043,Name="Principle",Category=Category.Principle,Specification=Specification.Four,Material=Material.Wood,Price=2000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Swell").ID},
                new Pipe {ID=4042,Name="Nazard",Category=Category.Reed,Specification=Specification.Four,Material=Material.Metal,Price=15000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Swell").ID},
};

            foreach (var sp in swellPipes)
            {
                context.Pipe.Add(sp);
            }
            context.SaveChanges();

            var pedalPipes = new Pipe[]
{
                new Pipe {ID=3163,Name="Bourdon",Category=Category.Flute,Specification=Specification.Sixteen,Material=Material.Metal,Price=10000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Pedal").ID},
                new Pipe {ID=1084,Name="Principle",Category=Category.Principle,Specification=Specification.Eight,Material=Material.Wood,Price=2000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Pedal").ID},
                new Pipe {ID=5051,Name="Mixture",Category=Category.Mixture,Specification=Specification.FiveRanks,Material=Material.Wood,Price=2000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Pedal").ID},
                new Pipe {ID=4163,Name="Posaune",Category=Category.Reed,Specification=Specification.Sixteen,Material=Material.Metal,Price=15000,Year=2001,DivisionID=divisions.Single(dv=>dv.Name=="Pedal").ID},
};

            foreach (var pp in pedalPipes)
            {
                context.Pipe.Add(pp);
            }
            context.SaveChanges();







        }
    }
}
