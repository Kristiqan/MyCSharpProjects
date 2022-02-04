using System;

public class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal created. ");
    }
   public void eat()
    {
        Console.WriteLine("Eating...");
    }
}


class Cat: Animal
{
    public Cat()
    {
        Console.WriteLine("Cat created");
    }
    public void walk()
    {
        Console.WriteLine("Walking...");
    }

}

class Tiger : Animal
{
    public Tiger()
    {
        Console.WriteLine("Tiger created");
    }
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
    public void walk()
    {
        Console.WriteLine("Walking... ");
    }
    public void Hunt()
    {
        Console.WriteLine("Hunting...");
    }
}

class DomesticCat : Animal
{
    public DomesticCat()
    {
        Console.WriteLine("Tiger created");
    }
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
    public void walk()
    {
        Console.WriteLine("Walking... ");
    }
    public void DrinkMilk()
    {
        Console.WriteLine("Drinking milk...");
    }
}




class MainExe
{
    static void Main()
    {
        Animal a1 = new Animal();
        Cat a2= new Cat();
        Tiger a3 = new Tiger();
        DomesticCat a4 = new DomesticCat();
    }
}