using MicroR.MVC.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroR.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferdto);
    }
}
