using System;
using System.Collections.Generic;


/*
 An Industrial building is being divided up and converted into apartments. 
 A large apartment takes up two stories of the building, and a small apartment takes up one story.

 Write a function that, given the number of stories in the building, 
 calculates the number of different possible arrangements of apartments.

 For example, if the building is three stroies high it can accommodate three diffrent possible
 arrangements of apartments: small-small-small, small-large and large-small.

*/

public class Stories
{
    public static int NumberOfArrangements(List<int> list)
    {
        double count = Math.Pow(2, list.Count);
        for (int i = 1; i <= count - 1; i++)
        {
            string str = Convert.ToString(i, 2).PadLeft(list.Count, '0');
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '1')
                {
                    Console.Write(list[j]);
                }
            }
            Console.WriteLine();
        }
        return 2;
        //throw new NotImplementedException("waiting to be implemented.");
    }

    public static void Main3(string[] args)
    {
        Console.WriteLine(NumberOfArrangements(new List<int> { 1, 2, 3 }));
        Console.ReadLine();
    }
}