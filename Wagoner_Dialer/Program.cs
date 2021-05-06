using System;
// Joshua Wagoner
// IT112
// NOTES: The class name already implies what type of phone you are creating,
//        so I already defined what type of phone it was in the subclass
//        constructors. I  never knew that the child class overrided method
//        from the parent class could be called if the child made it different.
// BEHAVIORS NOT IMPLIMENTED AND WHY: All Behaviors Implimented.
namespace Wagoner_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[10];

            phones[0] = new HomePhone("(360) 985-5063", "CompuTest");
            phones[1] = new CellPhone("(603) 532-4123", "Curtis Manufacturing");
            phones[2] = new HomePhone("(800) 876-2524", "Data Functions");
            phones[3] = new HomePhone("(708) 397-3330", "Donnay Repair");
            phones[4] = new HomePhone("(360) 434-3894", "ErgoNomic Inc");
            phones[5] = new HomePhone("(800) 969-4374", "ErgoSource");
            phones[6] = new CellPhone("(800) 874-8527", "Fox Bay Industries");
            phones[7] = new CellPhone("(800) 545-6254", "Glare-Guard");
            phones[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists");
            phones[9] = new CellPhone("(714) 472-4409", "Komfort Support");

            foreach(Phone phone in phones)
            {
                Console.WriteLine(phone.Dial());
            }

            Console.Read();
        }
    }
}
