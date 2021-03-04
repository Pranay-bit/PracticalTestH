using System;

/*
 Add the missing code to Chicken and Egg so the following actions are completed:

    1. Chicken implements the IBird interface.
    2. A Chicken lays an egg that will hatch into a new Chicken.
    3. Eggs from other types of birds should hatch into a new bird of their parent type.
    4. Hatching an egg for the second time throws a System.InvalidOperationExeception.
*/

public interface IBird
{
    Egg Lay();
}
// Should implement IBird
public class Chicken : IBird
{
    public Chicken()
    {
    }
    public Egg Lay()
    {
        return new Egg(() => new Chicken());
    }
}
public class Egg
{
    private bool hasHatched = false;
    public Egg(Func<IBird> createBird)
    {
        createBird = Hatch;
    }
    public IBird Hatch()
    {
        if (!hasHatched)
        {
            hasHatched = true;
            return new Chicken();
        }
        throw new InvalidOperationException();
       

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var chicken1 = new Chicken();
        var egg = chicken1.Lay();
        var childChicken = egg.Hatch();
        var childChicken2 = egg.Hatch();
    }
}