using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Dialer
{
    class HomePhone : Phone
    {
        public HomePhone(string number, string companyName) : 
            base(number, companyName, PhoneType.HOMEPHONE) {}

        public override string Dial()
        {
            return Company + " is being dialed using " + Number + "...";
        }
    }
}
