using System;

public class Program
{ //probably incomplete notes about Generics
	public static void Main()
	{
		List <int> list = new List<int>(1000);
	}
}

//Generics - The wild Car!
public class Box<T>
{
public int Value{ get; set; }
private int Count { get; set; }

public void MyBetterList()
    {
        Items = new T[size];
        Count = 0;
        EndPosition = 0;
    }

public void Add(T item)
    {
        
    }

}
//what is a list? Its a generic that 
//behind the scenes is actually a sneaky array










//not needed anymore because Generics
/* public class stringBox
{
public string Value{ get; set; }
}
public class boolBox
{
public bool Value{ get; set; }   
} */