using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroR.Banking.Application.Interfaces;
using MicroR.Banking.Application.Models;
using MicroR.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroR.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountSerivce)
        {
            _accountService = accountSerivce;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }

       
    }
}
