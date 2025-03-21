using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using angulerApp.BLL.DTO.TicketReply;
using AutoMapper;
using Infrastructure.Models;

namespace angulerApp.BLL.AutoMapper.Replies
{
    internal class TicketRepliesMappingProfile : Profile
    {
        public TicketRepliesMappingProfile()
        {
            CreateMap<TicketReplyDto, TicketReply>()
                .ForMember(dest => dest.Tid, opt => opt.MapFrom(src => src.TickedId))
                .ForMember(dest => dest.Reply, opt => opt.MapFrom(src => src.ReplyText))
                .ForMember(dest => dest.ReplyDate, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<TicketReply, TicketReplyForListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ReplyId))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Reply))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.ReplyDate));
        }
    }
}
