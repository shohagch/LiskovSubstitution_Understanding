using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_Understanding.Interface
{
    public interface IBank
    {
        public string BankName();
        public string BankOwner();
    }
}
