using FinancePOC.Application.Interfaces;
using FinancePOC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FinancePOC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinanceController : ControllerBase
    {
        private readonly IFinanceService financeService;

        //private readonly IFinanceService _financeService;

        //public FinanceController(IFinanceService financeService)
        //{
        //    _financeService = financeService;
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] FinanceViewModel financeViewModel)
        //{
        //    _financeService.Create(financeViewModel);

        //    return Ok(financeViewModel);
        //}

        //  private readonly FinanceDBContext _context;

        public FinanceController(IFinanceService financeService )
        {
            this.financeService = financeService;
            //_context = context;
        }


        //Get : /Finance
        [HttpGet]
        public IActionResult GetFinances()
        {
            //var financeDetail = await _context.Finances.ToListAsync();
            //if (financeDetail == null)
            //{
            //    return NotFound();
            //}
            //return financeDetail;


           var financeDetail = this.financeService.GetFinances();
            if (financeDetail == null)
            {
                return NotFound();
            }
            return StatusCode((int)HttpStatusCode.OK, financeDetail);
        }
    }
}
