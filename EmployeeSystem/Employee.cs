using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        this._name = name;
        this._baseSalary = baseSalary;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public int CalculatePay()
    {
        return _baseSalary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[직원] 이름");
    }
}

class Manager : Employee
{
    private int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        this._bonus = bonus;
    }
    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}");
        Console.WriteLine($"보너스: {_bonus:N0}");
        Console.WriteLine($"총 급여: {CalculatePay():N0}\n");
    }
}

class Developer : Employee
{
    private int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        this._overtimeHours = overtimeHours;
    }
    public new int CalculatePay()
    {
        return _baseSalary + (_overtimeHours * 20000);
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}");
        Console.WriteLine($"초과근무: {_overtimeHours:N0}");
        Console.WriteLine($"총 급여: {CalculatePay():N0}\n");
    }
}

class Intern : Employee
{
    public Intern(string name) : base(name, 1500000)
    {

    }
    public new int CalculatePay()
    {
        return _baseSalary;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}");
        Console.WriteLine($"총 급여: {CalculatePay():N0}\n");
    }
}