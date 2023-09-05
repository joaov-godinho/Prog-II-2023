using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;
using System.Xml.Linq;

namespace PSIUWeb.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            if( context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Pacients.Any())
            {
                context.Pacients.AddRange(
                    new Pacient
                    {
                        Name = "Maurício",
                        Birthdate = new DateTime(1984, 7, 5),
                        Race = Race.Pardo,
                        Height = 180,
                        Weight = 88
                    },
                    new Pacient
                    {
                    Name = "Marcos",
                        Birthdate = new DateTime(1987, 2, 28),
                        Race = Race.Pardo,
                        Height = 175,
                        Weight = 90
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
