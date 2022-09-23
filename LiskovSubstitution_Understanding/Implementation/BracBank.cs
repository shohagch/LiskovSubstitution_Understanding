using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_Understanding.Implementation
{
    public class BracBank : Bank
    {
        public override string BankName()
        {
          return "BRAC Bank Ltd";
        }
        public override string BankOwner()
        {
           return "Sir Fazle Hasan Abed KCMG";
        }
    }
}
