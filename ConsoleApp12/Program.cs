using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

public class Program
{ //probably incomplete notes about LINQ 
        //how not to do it, how to do without it
        
	static void Main()
    {
        List<Person> list = BabyMaker();
        //p equals the things in our person list
        List<Person> peopleNamedBob = list.Where(p => p.Name == "Bob" && p.Age <10 ).ToList();

        //example                     //woah this one has where and age, filter by name and then transform into the shape of only ages
        var result = list.Where(p => p.Age > 9).Select(p=>p.Name); //you cant add order by name before select, because then 
                                                                // then there isnt names anymore, the list is transformed 
        var result2 = list.Where(p => p.Age > 9)
                          .OrderBy(p=>p.Name)
                          .Select(p=>p.Name);
//using groupby is like going a whole nother level above orderby, you like group a list of lists together. crazy and complex


        //any returns a bool asking if the specified thing is in the list
        //any exist in it? true/false
        var testing = list.Any(p => p.Name == "Jeff"); //must be exact, using less search letter like "Jef" returns false
        
        var testing2 = list.Where(p => p.Name == "Jeff"); //must be exact, using less search letter like "Jef" returns false
        var firstGuy = testing2.FirstOrDefault();
        
        var testing3 = list.OrderBy(p => p.Name == "Jeff"); //This isn't actually link but it will print the list in a Re-ordered way

        // select - transforming
        // we dont care about the people anymore, only a list of their ages
        List<int> transformed = list.Select(p => p.Age).ToList();

        //var discounted = order.Select(o +> o.Price * .9).ToList; makes a list of discounted prices, same quantity, different shape

        

        // using .distinct shows you one specific result if Bob is in there multiple times, probably the []first result of Bob
    }
    //LINQ is a great tool to give us a subset of a List

    public static List<Person> BabyMaker()
    {
        List<Person> list = new List<Person>()
        {
            new Person("Bob", 4),
            new Person("Bob", 4),
            new Person("Bob", 4),
            new Person("Bob", 4),
            new Person("Bob", 4),
            new Person("Bob", 4),
        };
        return list;
    }    
}
public class Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
}