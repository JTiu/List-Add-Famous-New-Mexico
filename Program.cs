using System;
using System.Collections.Generic;
using System.Linq;

// Let's play 'New Mexico Jeoparday! 
//Today' category: 'Famous People from New Mexico'! We will call a famous New Mexico Person an 'object'.
//We will give that 'Famous Person' (the 'object'), a 'Name', and an 'ID'. (Kinda like getting a photo ID for school or work, right?).
//Still don't get it? Just cut the code below, and go to the 'sandbox', paste ita and 'run'. Practice substituting variables, and learn as you go!
public class FamousPerson : IEquatable<FamousPerson>
{
    public string FamousPersonName { get; set; }

    public int FamousPersonId { get; set; }

    public override string ToString()
    {
        return "ID: " + FamousPersonId + "   Name: " + FamousPersonName;
    }

    public bool Equals(FamousPerson other)
    {
        if (other == null) return false;
        return (this.FamousPersonId.Equals(other.FamousPersonId));
    }
    // Should also override == and != operators.
}
public class OurListFamousNewMexicoPersons
{
    public static void Main()
    {
        // Create a list of parts.
        List<FamousPerson> NMpeople = new List<FamousPerson>();

        // Add names & info.
        Console.WriteLine("Famous New Mexico Persons");
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Carlos Condit(born 1984) – born in Albuquerque, UFC fighter", FamousPersonId = 1 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Bob Foster (born 1938) – born in Albuquerque, light-heavyweight boxer, world champion", FamousPersonId = 2 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Holly Holm (born 1981) – born in Albuquerque, boxer/mixed martial fighter", FamousPersonId = 3 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Diego Sanchez (born 1981) – born in Albuquerque, UFC fighter", FamousPersonId = 4 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Neil Patrick Harris (born 1973) – actor, How I Met Your Mother/Doogie Howser, M.D.", FamousPersonId = 5 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Andre Roberson (born 1991) – born in Las Cruces, NBA player", FamousPersonId = 6 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Johnny Tapia (1967 -2012 1991) – born in Albuquerque, boxer", FamousPersonId = 7 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Onawa Lynn Lacy (born June 10, 1982) – from Gamerco, Miss New Mexico USA 2006 title", FamousPersonId = 8 });

        Console.WriteLine();

        foreach (FamousPerson aFamousPerson in NMpeople)
        {
            Console.WriteLine(aFamousPerson);
        }
       
        //insert the remove method
        // This will remove person 3,

        NMpeople.Remove(new FamousPerson() { FamousPersonId = 3, FamousPersonName = "Holly Holm" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 4, FamousPersonName = "Diego Sanchez" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 5, FamousPersonName = "NPH" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 6, FamousPersonName = "AR" });


        //NMpeople.RemoveAt(3);
        //NMpeople.RemoveAt(4);

        Console.WriteLine("\nremove Holly Holm, Diego Sanchez\n");
        foreach (FamousPerson afamousPerson in NMpeople)
        {
            Console.WriteLine(afamousPerson);
        }
      
               
        Console.WriteLine("\ntCapacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Count: {0}", NMpeople.Count);
        NMpeople.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Count: {0}", NMpeople.Count);

        NMpeople.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Count: {0}", NMpeople.Count);

    }
}