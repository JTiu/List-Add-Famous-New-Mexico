using List__Add__Famous_New_Mexico;
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
        Console.WriteLine("\npublic override to string");
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
       

        List<FamousPerson> NMpeople = new List<FamousPerson>();

        // Add names & info.
        Console.WriteLine("Famous New Mexico Athletes & Actors");
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Carlos Condit (born 1984) – born in Albuquerque, UFC fighter", FamousPersonId = 1 });
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
        Console.ReadLine();
        Console.Clear();
        //insert the remove method
        // This will remove person 3,

        NMpeople.Remove(new FamousPerson() { FamousPersonId = 3, FamousPersonName = "Holly Holm" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 4, FamousPersonName = "Diego Sanchez" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 5, FamousPersonName = "NPH" });
        NMpeople.Remove(new FamousPerson() { FamousPersonId = 6, FamousPersonName = "AR" });


        //NMpeople.RemoveAt(3);
        //NMpeople.RemoveAt(4);

        Console.WriteLine("\nRemove an object from an instance of my class with C# Remove():\n\nRemove Holly Holm, Diego Sanchez, N. P. Harris, Andre Roberson, then print remainder\n");
        foreach (FamousPerson afamousPerson in NMpeople)
        {
            Console.WriteLine(afamousPerson);
        }
      
        Console.WriteLine("\nCheck tCapacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Check Count: {0}", NMpeople.Count);
        NMpeople.TrimExcess();
        Console.WriteLine("\nTrimExcess()");
        Console.WriteLine("Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Count: {0}", NMpeople.Count);

        NMpeople.Clear();
        Console.WriteLine("\nClear()");
        Console.WriteLine("Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("Count: {0}", NMpeople.Count);
        Console.WriteLine("\n+++++++++++++++++++++++Next indexing a string collection+++++++++++++++++++++++++");
        Console.ReadLine();
        Console.Clear();
       
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "C. Condit(born 1984), Albuquerque, UFC fighter";
        stringCollection[1] = "B. Foster (born 1938), Albuquerque, light-heavyweight boxer, world champion";
        stringCollection[2] = "H. Holm (born 1981), Albuquerque, boxer/mixed martial fighter";
        stringCollection[3] = "D. Sanchez (born 1981), in Albuquerque, UFC fighter";
        stringCollection[4] = "N. Patrick Harris (born 1973), actor: How I Met Your Mother/Doogie Howser, M.D.";
        stringCollection[5] = "A. Roberson (born 1991), Las Cruces, NBA player";
        stringCollection[6] = "J. Tapia (1967 - 2012 1991), Albuquerque, boxer";
        stringCollection[7] = "O. Lynn Lacy (born June 10, 1982), Gamerco, Miss New Mexico USA 2006 title";

        Console.WriteLine($"Show entire string index:  \n\n" +
            $"index[0]:  { stringCollection[0]} \nindex[1]:  { stringCollection[1]}\nindex[2]:  { stringCollection[2]}\nindex[3]:  { stringCollection[3]}\nindex[4]:  { stringCollection[4]}\nindex[5]:  { stringCollection[5]}\nindex[6]:  { stringCollection[6]}\nindex[7]:  { stringCollection[7]}");
        Console.WriteLine($"\nprint string index at [3] {stringCollection[3]}");
        
        Console.WriteLine("\n+++++++++++++++++++++++++++++++++Now indexing an int collection++++++++++++++++++++++++++++++++++++++++");
        
        Console.ReadLine();
        Console.Clear();
        var intCollection = new SampleCollection<int>();
        intCollection[0] = 000; 
        intCollection[1] = 111;
        intCollection[2] = 222;
        intCollection[3] = 333;
        Console.WriteLine($"Show entire int index:  \n\n" +
            $"index[0]:  { intCollection[0]} \nindex[1]:  { intCollection[1]}\nindex[2]:  { intCollection[2]}\nindex[3]:  { intCollection[3]}");

        Console.WriteLine($"\nprint index at [3] {intCollection[3]}");
        Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++OverLoad+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        OurListFamousNewMexicoPersons ourListFamousNewMexicoPersons = new OurListFamousNewMexicoPersons();
        OurListFamousNewMexicoPersons obj = ourListFamousNewMexicoPersons;
        obj.add(33, 66);

        obj.add($"C. Condit(born 1984), Albuquerque, UFC fighter", "\nJ. Tapia (1967 - 2012 1991), Albuquerque, boxer");
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadLine();
        Console.ReadKey();
    }
    public void add(int a, int b)
    {
        Console.WriteLine($"adding {a} + {b} = {a + b}");
        Console.ReadLine();
    }

    public void add(string s1, string s2)
    {
        Console.WriteLine(s1 + s2);
    }

}


