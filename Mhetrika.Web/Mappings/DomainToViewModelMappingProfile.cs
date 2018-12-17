using AutoMapper;
using mhetrika.core.Entities;
using Mhetrika.Web.ViewModels;

namespace Mhetrika.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Patient, PatientViewModel>();

            CreateMap<Address, AddressViewModel>();

            CreateMap<Doctor, DoctorViewModel>();

            CreateMap<Doctor, DoctorListViewModel>();

            CreateMap<Laboratory, NewLaboratoryViewModel>();

            CreateMap<Laboratory, LaboratoryListViewModel>();

            CreateMap<Laboratory, EditLaboratoryViewModel>()
                .ForMember(m => m.AddressViewModel, opt => opt.MapFrom(d => d.Address));
        }
    }
}
