using System;

class animal
{
    public virtual void speak()
    { 
         Console.WriteLine("Animal makesa sound");
    }
}

class dog : Animal
{

    public override void Speak()
    {
         Console.WriteLine("Dog barks");
    }
}

class program
{
    static void Main()
    {
        Animal a1 = new Animal();
        Animal a2 = new Dog();

        a1.Speak();
        a2.Speak();
    }
}