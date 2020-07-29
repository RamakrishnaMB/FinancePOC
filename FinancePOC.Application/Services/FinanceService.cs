using AutoMapper;
using AutoMapper.QueryableExtensions;

using Finance.Infra.Data2.ClassLibraryCore.DBModels;
using Finance.Infra.Data2.ClassLibraryCore.Interface;
using FinancePOC.Application.AutoMapper;
using FinancePOC.Application.Interfaces;
using FinancePOC.Application.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancePOC.Application.Services
{
    public class FinanceService : IFinanceService
    {
        //private IFinanceRepository _financeRepository;
        //private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;


        //added by rk
        public IRepository<Finances> _FinanceRepository;
        public FinanceService(IMapper automapper, IRepository<Finances> financeRepository)
        {
            //_financeRepository = financeRepository1;

            _autoMapper = AutoMapperConfiguration.mapper;
            _FinanceRepository = financeRepository;
        }



        public List<FinanceViewModel> GetFinances()
        {
            //return _FinanceRepository.GetFinances().ProjectTo<FinanceViewModel>(_autoMapper.ConfigurationProvider);

            var lstFinaces = _FinanceRepository.GetAll().ToList();
            return  _autoMapper.Map<List<FinanceViewModel>>(lstFinaces);
        }
    }
}
