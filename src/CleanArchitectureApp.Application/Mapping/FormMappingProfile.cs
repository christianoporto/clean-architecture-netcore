using AutoMapper;
using CleanArchitectureApp.Application.Dtos;
using CleanArchitectureApp.Application.Features.Forms.Commands.CreateForm;
using CleanArchitectureApp.Domain.Entities;

namespace CleanArchitectureApp.Application.Mapping
{
    public class FormMappingProfile : Profile
    {
        public FormMappingProfile()
        {
            CreateMap<FormDto, Form>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<CreateFormCommand, Form>()
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name));
        }
    }
}
