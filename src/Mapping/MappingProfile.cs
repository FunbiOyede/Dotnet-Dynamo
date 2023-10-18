using System;
using Customer.API.Contracts;
using Customer.API.Model;
using AutoMapper;

namespace Customer.API.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
            CreateMap<CustomersDTO, CustomerModel>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth));
        }
    }
}

