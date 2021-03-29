using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidlyApp.Dtos;
using VidlyApp.Models;

namespace VidlyApp.App_Start
{
    public class MappingProfile : Profile
    { 
        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customers>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            Mapper.CreateMap<CustomerDto, Customers>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
        

    }
}