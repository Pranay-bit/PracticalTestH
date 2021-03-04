using System;

/*
 Write a method that, efficiently with respect to time used, finds the n-th lowest selling book in the list.
 Each element of the sales array represents a single sale of a book with that books id. The n-th lowest
 selling book is the book that has more sales than n-1 books. If multiple books share the n-th lowest selling
 spot, the method can return any one of them.

 For example, NthLowestSelling(new int[](5,4,3,2,1,5,4,3,2,5,4,3,5,4,5),2) should return 2.
 In the array, the book with the Id 1 was sold once, Id 2 twice, Id 3 three times. Id 4 four times, and
 Id 5 five times, making the book with the Id 1 the lowest selling book in the array and Id 2 the second lowest
 selling book.
*/

public class BookSale
{
    public static int NthLowestSelling(int[] sales, int n)
    {
        Array.Sort(sales);

        int min_count = n + 1, res = -1;
        int curr_count = 1;

        for (int i = 1; i < n; i++)
        {
            if (sales[i] == sales[i - 1])
                curr_count++;
            else
            {
                if (curr_count < min_count)
                {
                    min_count = curr_count;
                    res = sales[i - 1];
                }

               // curr_count = 2;
            }
        }

        // If last element is least frequent 
        if (curr_count < min_count)
        {
            min_count = curr_count;
            res = sales[n - 1];
        }

        return res;

    }

    public static void Main2(string[] args)
    {
        int x = NthLowestSelling(new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 1, 1, 5, 4, 3, 5, 4, 5 }, 2);
        Console.WriteLine(x);
        Console.ReadLine();
    }
}