using angularApp.DAL;
using angulerApp.BLL.Services.TicketReplys;
using angulerApp.BLL.Services.Tickets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace angulerApp.BLL
{
    public static class BLLRegistrationExtensions
    {
        public static void RegisterBLL(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            DALRegisterExtensions.RegisterDAL(services);
            services.AddAutoMapper(typeof(BLLRegistrationExtensions).Assembly);
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ITicketReplyService, TicketReplyService>();
        }
    }
}
