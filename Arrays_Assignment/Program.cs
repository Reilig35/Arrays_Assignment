using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Task 01 Start
        bool isUserWrong = true;

        string[] myStringArray = { "Hello", "World", "is", "used", "to", "test", "your", "code" };

        Console.WriteLine("Please select an index position of my string array:\n");

        int userChoice = Convert.ToInt32(Console.ReadLine());

        while(isUserWrong)
        if (userChoice <= 7) { Console.WriteLine(myStringArray[userChoice]); isUserWrong = false; }

        else { Console.WriteLine("Sorry outside range of string array\nPlease select an index position between 0 and 7\n"); userChoice = Convert.ToInt32(Console.ReadLine()); }
        
        
        
        
        //Task 01 End

        isUserWrong = true;

        int[] myIntArray = { 900, 2, 1000, 26, 345, 12,};

        Console.WriteLine("Please select an index position:\n");

        userChoice = Convert.ToInt32(Console.ReadLine());

        while (isUserWrong)
            if (userChoice <= 5) { Console.WriteLine(myIntArray[userChoice]); isUserWrong = false; }

            else { Console.WriteLine("Sorry outside range of integer array\nPlease select an index position between 0 and 5\n"); userChoice = Convert.ToInt32(Console.ReadLine()); }

        //Task 02 Start

       
        
        
        //Task 03 Start
        isUserWrong = true;

        List<string> myStringList = new List<string>();
        
        myStringList.Add("Hello");
        myStringList.Add("my");
        myStringList.Add("name");
        myStringList.Add("is");
        myStringList.Add("William");
        myStringList.Add("and");
        myStringList.Add("I\'m");
        myStringList.Add("learning");
        myStringList.Add("with");
        myStringList.Add("the");
        myStringList.Add("Tech");
        myStringList.Add("Academey");
        

        Console.WriteLine("Please select an index position:\n");

        userChoice = Convert.ToInt32(Console.ReadLine());

        while (isUserWrong)
            if (userChoice <= 11) { Console.WriteLine(myStringList[userChoice]); isUserWrong = false; }

            else { Console.WriteLine("Sorry outside range of integer array\nPlease select an index position between 0 and 5\n"); userChoice = Convert.ToInt32(Console.ReadLine()); }

        //Task 03 End

    }
}

