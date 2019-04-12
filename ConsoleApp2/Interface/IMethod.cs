using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interface
{
    interface IMethod
    {
        string GetAdrress();

        void GetName();

        int ConvertToInt(string accountNumber);
    }
}
