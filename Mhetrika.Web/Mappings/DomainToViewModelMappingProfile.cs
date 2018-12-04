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
        }
    }
}
