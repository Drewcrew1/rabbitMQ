using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroR.MVC.Models.Dto
{
    public class TransferDto
    {
        public decimal TransferAmount { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
    }
}
