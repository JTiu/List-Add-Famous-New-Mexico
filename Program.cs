using System;
using System.Collections.Generic;

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

        // Add parts to the list.
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Carlos Condit(born 1984) – born in Albuquerque, UFC fighter", FamousPersonId = 1 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Bob Foster (born 1938) – born in Albuquerque, light-heavyweight boxer, world champion", FamousPersonId = 2 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Holly Holm (born 1981) – born in Albuquerque, boxer/mixed martial fighter", FamousPersonId = 3 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Diego Sanchez (born 1981) – born in Albuquerque, UFC fighter", FamousPersonId = 4 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Neil Patrick Harris (born 1973) – actor, How I Met Your Mother/Doogie Howser, M.D.", FamousPersonId = 5 });
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Andre Roberson (born 1991) – born in Las Cruces, NBA player", FamousPersonId = 6 });

        Console.WriteLine();

        foreach (FamousPerson aFamousPerson in NMpeople)
        {
            Console.WriteLine(aFamousPerson);
        }
    }
}