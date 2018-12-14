using AutoMapper;
using mhetrika.core.Entities;
using Mhetrika.Web.ViewModels;
using System.Collections.Generic;

namespace Mhetrika.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Patient, PatientViewModel>();
            CreateMap<Address, AddressViewModel>();
            CreateMap<Doctor, DoctorViewModel>();
            CreateMap<List<Doctor>, List<DoctorListViewModel>>();
        }
    }
}
