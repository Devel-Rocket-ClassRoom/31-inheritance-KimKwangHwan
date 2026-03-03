using System;

Animal[] animals =
{
    new Lion("시바", 5, "으르렁!"),
    new Elephant("덤보", 10, "뿌우!"),
    new Penguin("뽀로로", 3, "꽥꽥!")
};


Console.WriteLine("[동물 정보]");
foreach (Animal animal in animals)
{
    animal.DisplayInfo();
}

Console.WriteLine();

Console.WriteLine("[동물 소리]");
foreach (Animal animal in animals)
{
    animal.MakeSound();
}
Console.WriteLine();

Console.WriteLine("[동물 행동]");
foreach (Animal animal in animals)
{
    animal.Eat();

    if (animal is Lion lion)
    {
        lion.Hunt();
    }
    if (animal is Elephant elephant)
    {
        elephant.SprayWater();
    }
    if (animal is Penguin penguin)
    {
        penguin.Swim();
    }
}
Console.WriteLine();