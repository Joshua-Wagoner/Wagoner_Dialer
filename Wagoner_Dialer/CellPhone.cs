using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string number, string companyName) : 
            base(number, companyName, PhoneType.CELLPHONE) {}

        public override string Dial()
        {
            return Company + " is being dialed using 1+" + Number + "...";
        }
    }
}
