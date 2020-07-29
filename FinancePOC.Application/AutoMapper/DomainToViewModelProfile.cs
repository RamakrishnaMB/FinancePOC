using AutoMapper;
using Finance.Infra.Data2.ClassLibraryCore.DBModels;
using FinancePOC.Application.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;

namespace FinancePOC.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            // CreateMap<Finances, FinanceViewModel>();
            CreateMap<Finances, FinanceViewModel>();
            CreateMap<FinanceViewModel, Finances>();
        }
    }
}
