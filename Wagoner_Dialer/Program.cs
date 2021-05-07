using System;
// Joshua Wagoner
// IT112
// NOTES: Nothing to see here.
// BEHAVIORS NOT IMPLIMENTED AND WHY: All Behaviors Implimented.
namespace Wagoner_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[10];

            phones[0] = new HomePhone("(360) 985-5063", "CompuTest", PhoneType.HOMEPHONE);
            phones[1] = new CellPhone("(603) 532-4123", "Curtis Manufacturing", PhoneType.CELLPHONE);
            phones[2] = new HomePhone("(800) 876-2524", "Data Functions", PhoneType.HOMEPHONE);
            phones[3] = new HomePhone("(708) 397-3330", "Donnay Repair", PhoneType.HOMEPHONE);
            phones[4] = new HomePhone("(360) 434-3894", "ErgoNomic Inc", PhoneType.HOMEPHONE);
            phones[5] = new HomePhone("(800) 969-4374", "ErgoSource", PhoneType.HOMEPHONE);
            phones[6] = new CellPhone("(800) 874-8527", "Fox Bay Industries", PhoneType.CELLPHONE);
            phones[7] = new CellPhone("(800) 545-6254", "Glare-Guard", PhoneType.CELLPHONE);
            phones[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists", PhoneType.CELLPHONE);
            phones[9] = new CellPhone("(714) 472-4409", "Komfort Support", PhoneType.CELLPHONE);

            foreach(Phone phone in phones)
            {
                Console.WriteLine(phone.Dial());
            }

            Console.Read();
        }
    }
}
