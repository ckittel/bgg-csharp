using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using BoardGameGeek.Api.ClientModels;
using BoardGameGeek.Api.ServerModels;

namespace BoardGameGeek.Api.ClientModels
{
    /// <summary>
    /// 
    /// </summary>
    internal static class ServerToClientModelMaps
    {
        private class EmptyStringToNullStringFormatter : ValueFormatter<string>
        {
            protected override string FormatValueCore(string value)
            {
                return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
            }
        }

        static ServerToClientModelMaps()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullDestinationValues = true;
                cfg.ForSourceType<string>().AddFormatter<EmptyStringToNullStringFormatter>();

                cfg.CreateMap<User, ExternalGamingAccounts>()
                    .ForMember(dest => dest.PlayStationNetworkAccount, opt => opt.MapFrom(src => src.psnaccount));
                cfg.CreateMap<User, Account>()
                    .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom(src => src.avatarlink.value))
                    .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.stateorprovince.value))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.name))
                    .ForMember(dest => dest.WebsiteUrl, opt => opt.MapFrom(src => src.webaddress.value))
                    .ForMember(dest => dest.TraderRating, opt => opt.MapFrom(src => src.traderating.value))
                    .ForMember(dest => dest.ExternalGamingAccounts, opt => opt.MapFrom(src => src));
            });


            Mapper.AssertConfigurationIsValid();
        }

        public static void RunMe()
        {
            
        }
    }
}
