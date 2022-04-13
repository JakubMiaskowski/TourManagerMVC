using Microsoft.Extensions.DependencyInjection;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Infrastructure.Repositories;

namespace TourManagerMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IVenueRepository, VenueRepository>();
            services.AddTransient<IConcertRepository, ConcertRepository>();
            services.AddTransient<ITourRepository, TourRepository>();

            return services;
        }
    }
}
