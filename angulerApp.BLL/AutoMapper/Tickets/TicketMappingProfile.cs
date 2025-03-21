using angulerApp.BLL.DTO.Ticket;
using AutoMapper;
using Infrastructure.Models;

namespace angulerApp.BLL.AutoMapper.Tickets
{
    public class TicketMappingProfile : Profile
    {
        public TicketMappingProfile()
        {
            CreateMap<Ticket, TicketForListPageDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.Title ?? ""))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.TicketType.Title ?? ""))
                .ReverseMap();

            CreateMap<Ticket, EditCreateTicketDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.StatusId))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.TicketTypeId))
                .ForMember(dest => dest.UrgentLvl, opt => opt.MapFrom(src => src.PriorityId))
                .ForMember(dest => dest.Module, opt => opt.MapFrom(src => src.ApplicationName))
                .ForMember(
                    dest => dest.InstalledEnvironment,
                    opt => opt.MapFrom(src => src.InstalledEnvironmentId)
                );

            CreateMap<EditCreateTicketDto, Ticket>()
                .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => (Int32)src.Status))
                .ForMember(dest => dest.TicketTypeId, opt => opt.MapFrom(src => (Int32)src.Type))
                .ForMember(dest => dest.PriorityId, opt => opt.MapFrom(src => (Int32)src.UrgentLvl))
                .ForMember(dest => dest.ApplicationName, opt => opt.MapFrom(src => src.Module))
                .ForMember(
                    dest => dest.InstalledEnvironmentId,
                    opt => opt.MapFrom(src => (Int32)src.InstalledEnvironment)
                )
                .ForMember(dest => dest.InstalledEnvironment, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.TicketType, opt => opt.Ignore());
        }
    }
}
