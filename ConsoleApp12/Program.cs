using System;
using System.Globalization;

public class Program
{ //probably incomplete notes about LINQ 
        //how not to do it, how to do without it
	static void Main()
	{
		List <int> list = new List<int>() {4,5,6,7,8, 2,5, 1,13, 68, 1,3};
        foreach ( int number in list)
        {
            if (number >4)
            {
                filterList.Add(number);
            }
    }

        //if the number is greater than 4
    
    


    //with LINQ    you will probably use this because your coworkers are lazy, you will learn it and then you will be faster and lazy too
    // Linq is built on the backs of generics
    List<int> result = list.Where(number => number > 4).ToList(); // if ever you run into an IEnumerable, you just make it a List and then you don't have to deal with it
    
    //this arrow symbol is a      lambda =>  ,  don't get it confused with the greater or equal to is written the opposite way like this >=
    //                            number  => this is what each thing in your list is going to be called 
    //                                                 number > 4 what we actually compare 
    //                            given number, return number > 4 (nothing smaller than 4 will be returned in this instance)
    
    // IEnumerable<T> a sequence of items                  


    }
}
