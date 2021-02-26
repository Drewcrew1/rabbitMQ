using MicroR.Banking.Application.Interfaces;
using MicroR.Banking.Domain.Interfaces;
using MicroR.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
