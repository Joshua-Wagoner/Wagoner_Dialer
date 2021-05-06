using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Dialer
{
    enum PhoneType
    {
        CELLPHONE = 2,
        HOMEPHONE = 1
    }

    class Phone
    {
        private PhoneType phoneType;
        private string number;
        private string companyName;

        public Phone(string number, string companyName, PhoneType phoneType)
        {
            this.number = number;
            this.companyName = companyName;
            this.phoneType = phoneType;
        }

        public PhoneType Type { get { return phoneType; } }
        public string Number { get { return number; } }
        public string Company { get { return companyName; } }

        public virtual string Dial()
        {
            return "Dialing phone number (XXX) XXX-XXXX.";
        }
    }
}
