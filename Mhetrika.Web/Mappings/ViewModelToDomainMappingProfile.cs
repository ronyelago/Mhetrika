﻿using AutoMapper;
using mhetrika.core.Entities;
using Mhetrika.Web.ViewModels;
using System.Collections.Generic;

namespace Mhetrika.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PatientViewModel, Patient>()
                .ForMember(m => m.Address, opt => opt.MapFrom(v => v.AddressViewModel));

            CreateMap<AddressViewModel, Address>();
            CreateMap<DoctorViewModel, Doctor>();
            CreateMap<List<DoctorListViewModel>, List<Doctor>>();
        }
    }
}
