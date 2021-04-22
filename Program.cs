using List__Add__Famous_New_Mexico;
using Magnum;
using System;
using System.Collections;
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
        Console.WriteLine("\n*****Public override to string");
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
        
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Carlos Condit (born 1984) – born in Albuquerque, UFC fighter", FamousPersonId = 1 });
       // Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Bob Foster (born 1938) – born in Albuquerque, light-heavyweight boxer, world champion", FamousPersonId = 2 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Holly Holm (born 1981) – born in Albuquerque, boxer/mixed martial fighter", FamousPersonId = 3 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Diego Sanchez (born 1981) – born in Albuquerque, UFC fighter", FamousPersonId = 4 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Neil Patrick Harris (born 1973) – actor, How I Met Your Mother/Doogie Howser, M.D.", FamousPersonId = 5 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Andre Roberson (born 1991) – born in Las Cruces, NBA player", FamousPersonId = 6 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Johnny Tapia (1967 -2012 1991) – born in Albuquerque, boxer", FamousPersonId = 7 });
        Console.WriteLine();
        NMpeople.Add(new FamousPerson() { FamousPersonName = "Onawa Lynn Lacy (born June 10, 1982) – from Gamerco, Miss New Mexico USA 2006 title", FamousPersonId = 8 });
        //Console.WriteLine();
        Console.WriteLine("\nFamous New Mexico Athletes & Actors:\n");
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

        Console.WriteLine("\nRemove an object from an instance of the class:\n\n*****Remove: \n\nHolly Holm,\nDiego Sanchez,\nNeil Patrick Harris,\nAndre Roberson...\n\n*****Then print remainder:\n");
        foreach (FamousPerson afamousPerson in NMpeople)
        {
            Console.WriteLine(afamousPerson);
        }
        Console.WriteLine("\n+++++++++++++++++++++++Other  operations +++++++++++++++++++++++++\n");
        Console.WriteLine("\n*Now, Check Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("***Check Count: {0}", NMpeople.Count);
        NMpeople.TrimExcess();
        Console.WriteLine("\n*Now, TrimExcess():");
        Console.WriteLine("***Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("***Count: {0}", NMpeople.Count);

        NMpeople.Clear();
        Console.WriteLine("\n*Now, Clear():");
        Console.WriteLine("***Capacity: {0}", NMpeople.Capacity);
        Console.WriteLine("***Count: {0}", NMpeople.Count);
        Console.ReadLine();
        Console.WriteLine("\n+++++++++++++++++++++++Next indexing a string collection+++++++++++++++++++++++++");
       
        Console.Clear();
       
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "\nCondit, C.(born 1984), Albuquerque, UFC fighter\n";
        stringCollection[1] = "\nFoster, B. (born 1938), Albuquerque, light-heavyweight boxer, world champion\n";
        stringCollection[2] = "\nHolm, H. (born 1981), Albuquerque, boxer/mixed martial fighter\n";
        stringCollection[3] = "\nSanchez, D. (born 1981), in Albuquerque, UFC fighter\n";
        stringCollection[4] = "\nHarris, N.P. (born 1973), actor: How I Met Your Mother/Doogie Howser, M.D.\n";
        stringCollection[5] = "\nRoberson, A. (born 1991), Las Cruces, NBA player\n";
        stringCollection[6] = "\nTapia, J. (1967 - 2012 1991), Albuquerque, boxer\n";
        stringCollection[7] = "\nLacy, O.L. (born June 10, 1982), Gamerco, Miss New Mexico USA 2006 title\n";

        Console.WriteLine($"\n\n*Show entire string index:  \n\n" +
            $"index[0]:  { stringCollection[0]} \nindex[1]:  { stringCollection[1]}\nindex[2]:  { stringCollection[2]}\nindex[3]:  { stringCollection[3]}\nindex[4]:  { stringCollection[4]}\nindex[5]:  { stringCollection[5]}\nindex[6]:  { stringCollection[6]}\nindex[7]:  { stringCollection[7]}");
        Console.WriteLine($"\n*Print string index at [3]:\n\nThe entry is:\n{stringCollection[3]}");
        
       
        
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\n+++++++++++++++++++++++++++++++++Now indexing an int collection++++++++++++++++++++++++++++++++++++++++");
        var intCollection = new SampleCollection<int>();
        intCollection[0] = 000; 
        intCollection[1] = 111;
        intCollection[2] = 222;
        intCollection[3] = 333;
        Console.WriteLine($"\n*Show an entire 'int' Index:  \n\n" +
            $"index[0]:  { intCollection[0]} \nindex[1]:  { intCollection[1]}\nindex[2]:  { intCollection[2]}\nindex[3]:  { intCollection[3]}");

        Console.WriteLine($"\n*Print index at [3]:\n\n'{intCollection[3]}'");
        Console.WriteLine("\n++++++++++++++OverLoad the '+' operator: Add two instances of the custom list class++++++++++\n");
        OurListFamousNewMexicoPersons ourListFamousNewMexicoPersons = new OurListFamousNewMexicoPersons();
        OurListFamousNewMexicoPersons obj = ourListFamousNewMexicoPersons;
        Console.WriteLine("*obj.add 2 ints:\n");
        obj.add(333, 111);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++\n");
        Console.WriteLine("*obj.add 2 strings:\n");
        obj.add($"C. Condit(born 1984), Albuquerque, UFC fighter", "\nJ. Tapia (1967 - 2012 1991), Albuquerque, boxer\n");
        Console.WriteLine("\n+++++++++++Press any key to overload using the SubMethod+++++++++++++\n");
        Console.ReadLine();
       Console.Clear();
        //Console.ReadKey();
        Console.WriteLine("\n+++++++++OverLoad '-' operator: Subtract custom list class instance from another instance++++++++++\n");
        int myNum1 = SubMethod(8, 5);
        double myNum2 = SubMethod(4.3, 6.26);
        Console.WriteLine("\n*****Using SubMethod:  (int x, int y/ return x - y;), on an 'int'");
        Console.ReadLine();
        Console.WriteLine("Int: 8 - 5 = " + myNum1);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++\n");
        Console.WriteLine("\n*****Using SubMethod:  (int x, int y/ return x - y;), on an 'double'");
        Console.ReadLine();
        Console.WriteLine("Double: 4.3 - 6.26 = " + myNum2);
        Console.WriteLine("\n++++++++++++++++++++++++++++++++++\n");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\n\n\n\n*****Using 'Zip method' on two arrays: \n\n******var array1 = new string[] { 'blue', 'red', 'green'}; \n\nAND....\n \n******var array2 = new string[] { 'sky', 'sunset', 'cactus' };");
        Console.ReadLine();
        {
            // Two source arrays.
            var array1 = new string[] {"blue", "red", "green"};
            var array2 = new string[] {"sky", "sunset", "cactus"};

            // Concatenate elements at each position together.
            var zip = array1.Zip(array2, (a, b) => (a + "   =  " + b));
            Console.WriteLine();
            foreach (var value in zip)
            {
                Console.WriteLine("ZIP:   {0}", value);
                Console.ReadLine();
            }
        }
        Console.WriteLine("++++++++++++++++++++++++++++++++++\n");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\n++++++++++++++++Make Iterable using IEnumerable+++++++++++++};");
        {

            // Storing the elements of GetMyList
            IEnumerable<string> my_slist = GetMyList();

            // Display the elements return from iteration
            foreach (var i in my_slist)
            {
                Console.WriteLine($"\nIterate: " + i + "\n");
            }
        }

       Console.WriteLine("++++++++++++++++++++++++++++++++++\n");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\n++++++++++++++++Sorting Array using Comparer+++++++++++++};");
        Console.ReadLine();
        {
            // Create and initialize a new array.
            String[] words = { "The", "ZIA", "IS", "THE", "symbol",
                         "for", "New", "Mexico", "bueno" };
            // Instantiate the reverse comparer.
            IComparer revComparer = new ReverseComparer();

            // Display the values of the array.
            Console.WriteLine("*The original order of elements in the array:\n");
            
            DisplayValues(words);
            Console.ReadLine();

            // Sort a section of the array using the default comparer.
            Array.Sort(words, 1, 3);
            Console.WriteLine("*After sorting elements 1-3 by using the default comparer:\n");
            DisplayValues(words);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadLine();
            Console.Clear();
            // Sort a section of the array using the reverse case-insensitive comparer.
            Array.Sort(words, 1, 3, revComparer);
            Console.WriteLine("\n\n\n*After sorting elements 1-3 by using the reverse case-insensitive comparer:\n");
            
            DisplayValues(words);
            Console.ReadLine();

            // Sort the entire array using the default comparer.
            Array.Sort(words);
            Console.WriteLine("\n\n\n*After sorting the entire array by using the default comparer:\n");
            DisplayValues(words);
            Console.ReadLine();
            Console.Clear();
            // Sort the entire array by using the reverse case-insensitive comparer.
            Array.Sort(words, revComparer);
            Console.WriteLine("\n\n\n*After sorting the entire array using the reverse case-insensitive comparer:\n");
            DisplayValues(words);

            Console.WriteLine("\n******************************Thank you, That's it\n\n\n\n\n\n\n\n");
           
        }




    }
    public void add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.ReadLine();
    }

    public void add(string s1, string s2)
    {
        Console.WriteLine(s1 + s2);
    }
    static int SubMethod(int x, int y)
    {
        
        return x - y;
        
    }

    static double SubMethod(double x, double y)
    {
        
        return x - y;
    }
    public static IEnumerable<string> GetMyList()
    {
        // Creating and adding elements in list
        List<string> my_list = new List<string>() {
                     "Roswell", "Las Cruces", "Albuquerque", "Santa Fe" };


        // Iterating the elements of my_list
        foreach (var items in my_list)
        {
            // Returning the element after every iteration
            yield return items;
        }


        //Console.WriteLine("The End\nThank you!");
    }
    public static void DisplayValues(String[] arr)
    {
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0);
              i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, arr[i]);
        }
        Console.WriteLine();
    }

}
public class ReverseComparer : IComparer
{
    // Call CaseInsensitiveComparer.Compare with the parameters reversed.
    public int Compare(Object x, Object y)
    {
        return (new CaseInsensitiveComparer()).Compare(y, x);
    }
}


