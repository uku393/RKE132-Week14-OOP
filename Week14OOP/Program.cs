Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.LevelOfHappiness != 7)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name = "Koer"; //field
    private int _levelOfHappiness = 0;

    //constructor
    public Dog(string name) //name - lets the user name the dog 
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof woof");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle wiggle!");
    }
}


//Cat newCat = new Cat ("Garfield", "ginger");
//Console.WriteLine($"{newCat.Name} wants a rub on its belly.");

//while (newCat.BellyFull !> 0)
//{
//    newCat.Sleep();
//}
//newCat.Meow();
//newCat.ShowCatData();

//class Cat
//{
//    private string _name;
//    private string _color;
//    private int _bellyFull;
//    public Cat(string name, string color)
//    {
//        _name = name;
//        _color = color;
//        _bellyFull = 10;
//        Console.WriteLine($"A {color} cat {name} has been created.");
//    }

//    public string Name //getter
//    {
//        get { return _name;}
//    }

//    public int BellyFull //getter
//    {
//        get { return _bellyFull;}
//    }
//    public void Sleep()
//    {
//        _bellyFull--;
//        Console.WriteLine($"{_name} says: Z-z-Z-z-Z-z");
//    }
//    public void Meow()
//    {
//        Console.WriteLine($"{_name} says: Meow!");
//    }
//    public void ShowCatData() //displays info about the cat object
//    {
//        Console.WriteLine($"Name: {_name}");
//        Console.WriteLine($"Color: {_color}");
//        Console.WriteLine($"Level of hungriness: {_bellyFull}");
//    }

//}










