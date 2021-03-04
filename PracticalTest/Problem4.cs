using System;
using System.Collections.Generic;


/*
 Given a data structure representing a social network.
 Implement method CanBeConnected on class Friend.

 The method should check if a connection to the given member exists, *efficiently* with respect to time used.
 That should be either a direct friendship or a chain of members between them who are mutual friends.

 For example, if A and B are friends and B and C are friends, then A.CanBeConnected(C) should return true,
 since, C is a friend of B and B is a friend of A.
*/

public class Friend
{
    public string Name { get; private set; }

    public ICollection<Friend> Friends { get; private set; }

    public Friend(string name)
    {
        this.Name = name;
        this.Friends = new List<Friend>();
    }

    public void AddFriendship(Friend friend)
    {
        this.Friends.Add(friend);
        friend.Friends.Add(this);
    }

    public bool CanBeConnected(Friend friend)
    {

        return true;
    }

    public static void Main4(string[] args)
    {
        Friend a = new Friend("A");
        Friend b = new Friend("B");
        Friend c = new Friend("C");

        a.AddFriendship(b);
        b.AddFriendship(c);

        Console.WriteLine(a.CanBeConnected(c));
        Console.ReadLine();
    }
}
