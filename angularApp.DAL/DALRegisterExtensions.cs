using angularApp.DAL.Repositories.TicketReplys;
using angularApp.DAL.Repositories.Tickets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace angularApp.DAL
{
    public static class DALRegisterExtensions
    {
        public static void RegisterDAL(this IServiceCollection services)
        {
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketReplyRepository, TicketReplyRepository>();
        }
    }
}
