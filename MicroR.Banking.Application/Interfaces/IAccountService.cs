using MicroR.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroR.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
