using MicroR.Banking.Data.Context;
using MicroR.Banking.Domain.Interfaces;
using MicroR.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;
        
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
