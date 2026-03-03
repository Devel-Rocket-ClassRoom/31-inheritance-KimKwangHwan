using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    protected string _sound;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}");
    }
}

class Lion : Animal
{
    public Lion(string name, int age, string sound) : base(name, age)
    {
        _sound = sound;
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
    }
}

class Elephant : Animal
{
    public Elephant(string name, int age, string sound) : base(name, age)
    {
        _sound = sound;
    }

    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}

class Penguin : Animal
{
    public Penguin(string name, int age, string sound) : base(name, age)
    {
        _sound = sound;
    }

    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}