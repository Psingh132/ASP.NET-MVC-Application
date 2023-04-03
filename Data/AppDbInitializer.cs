using MovieRental.Models;

namespace MovieRental.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //reference to the AppDbContext i.e the file that we use to send data to database or get data
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        { }
                    }
                        );

                }

                if (!context.Actors.Any())
                {

                }

                if (!context.Producers.Any())
                {

                }

                if (!context.Movies.Any())
                {

                }

                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
