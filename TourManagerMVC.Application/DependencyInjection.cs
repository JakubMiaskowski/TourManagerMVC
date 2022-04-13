using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Application.Services;

namespace TourManagerMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<IVenueService, VenueService>();
            services.AddTransient<IConcertService, ConcertService>();
            services.AddTransient<ITourService, TourService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
        
    }
}
