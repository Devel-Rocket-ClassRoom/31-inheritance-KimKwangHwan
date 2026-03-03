using System;


{
    Child child = new Child();
    child.Greet();
    child.Study();
}

{
    Dog dog = new Dog();
    dog.Name = "초코";
    dog.Eat();
    dog.Bark();

    Cat cat = new Cat();
    cat.Name = "나비";
    cat.Eat();
    cat.Meow();
}

{
    Product product = new Product { Name = "키보드", Price = 50000 };
    Console.WriteLine(product.ToString());
    Console.WriteLine(product.GetType());
}

{
    Manager manager = new Manager();
    manager.ShowInfo();
}

{
    Student student = new Student("홍길동", 3);
    Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");
}

{
    Dog2 dog = new Dog2();
}

{
    Dog3 dog = new Dog3();
    Animal3 animal = new Animal3();

    animal.Eat();
    // animal.Bark(); // 오류
}

{
    Dog3 dog = new Dog3 { Name = "멍멍이" };
    Animal3 animal = dog;

    Dog3 dog2 = (Dog3)animal;
    dog2.Bark();
}

{
    Animal3 animal = new Dog3 { Name = "멍멍이" };
    if (animal is Dog3)
    {
        Dog3 dog = (Dog3)animal;
        dog.Bark();
    }

    if (animal is Dog3 dog2)
    {
        dog2.Bark();
    }
}

{
    Animal3 animal = new Cat3 { Name = "야옹이" };
    Dog3 dog = animal as Dog3;

    if (dog != null)
    {
        dog.Bark();
    }
    else
    {
        Console.WriteLine($"Dog3 타입이 아닙니다.");
    }
}

{
    Asset[] assets = new Asset[3];
    assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
    assets[1] = new House { Name = "아파트", Mortgage = 300000000 };
    assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

    foreach (Asset asset in assets )
    {
        Console.WriteLine(asset.Name);
    }
}

{
    Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
    Circle circle = new Circle { Name = "원", Radius = 3 };

    Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
    Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");
}

{
    Car car = new Car();
    car.Start();
    car.Stop();
}

{
    FinalClass obj = new FinalClass();
    obj.Display();
}

{
    Child4 child = new Child4();
    Parent4 parent = child;

    Console.WriteLine($"child.Value: {child.Value}");
    Console.WriteLine($"parent.Value: {parent.Value}");

    child.Show();
    parent.Show();
}

{
    GameCharacter[] characters = new GameCharacter[]
    {
        new Warrior("아서", 25), new Mage("멀린", 40), new Warrior("란슬롯", 30)
    };

    foreach (GameCharacter character in characters)
    {
        character.ShowStatus();
        character.Attack();
        Console.WriteLine();
    }
}

class Parent
{
    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
}

class Child : Parent
{
    public void Study()
    {
        Console.WriteLine("공부합니다.");
    }
}

class Animal
{
    public string Name;
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}

class Product
{
    public string Name;
    public int Price;
}
class Parent2
{
    private int _privateValue = 1;
    protected int _protectedValue = 2;
    public int PublicValue = 3;
}

class Child2 : Parent2
{
    public void ShowValues()
    {
        Console.WriteLine(_protectedValue);
        Console.WriteLine(PublicValue);
    }
}

class Employee
{
    protected string _department = "개발팀";

    public void ShowDepartment()
    {
        Console.WriteLine($"부서: {_department}"); 
    }
}

class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"소속 부서: {base._department}");

        base.ShowDepartment();
    }
}

class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {name}");
    }
}

class Student : Person
{
    public int Grade;
    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {grade}학년");
    }
}

class Animal2
{
    public Animal2()
    {
        Console.WriteLine($"Animal 기본 생성자");
    }
}

class Dog2 : Animal2
{
    public Dog2()
    {
        Console.WriteLine("Dog 생성자");
    }
}

class Animal3
{
    public string Name;
    public void Eat() => Console.WriteLine($"{Name}이(가) 먹습니다.");
}

class Dog3 : Animal3
{
    public void Bark() => Console.WriteLine($"{Name}이(가) 짖습니다.");
}

class Cat3 : Animal3
{
    public void Meow() => Console.WriteLine("야옹");
}

class Asset
{
    public string Name;
}

class Stock : Asset
{
    public int Shares;
}

class House : Asset
{
    public decimal Mortgage;
}

abstract class Shape
{
    public string Name;

    public abstract double GetArea();
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}

abstract class Vehicle
{
    public abstract void Start();
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("자동차 시동을 켭니다.");
    }
}

sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("이 클래스는 상속할 수 없습니다.");
    }
}

class Parent4
{
    public int Value = 10;
    public void Show()
    {
        Console.WriteLine("Parent.Show()");
    }
}

class Child4 : Parent4
{
    public new int Value = 20;

    public new void Show()
    {
        Console.WriteLine("Child.Show()");
    }
}

abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack();

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력: {Health}");
    }
}

class Warrior : GameCharacter
{
    public int Strength { get; protected set; }
    public Warrior(string name, int strength) : base(name, 150)
    {
        Strength = strength;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다.");
    }
}

class Mage : GameCharacter
{
    public int MagicPower { get; protected set; }
    public Mage(string name, int magicPower) : base(name, 80)
    {
        MagicPower = magicPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {MagicPower} 데미지를 입힙니다.");
    }
}