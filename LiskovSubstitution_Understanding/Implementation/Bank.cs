using LiskovSubstitution_Understanding.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_Understanding.Implementation
{
    public abstract class Bank : IBank
    {
        public virtual string BankName()
        {
            return "Defaut Bank Name!";
        }
        public abstract string BankOwner();
    }
}
