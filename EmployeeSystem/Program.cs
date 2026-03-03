using System;

Manager manager = new Manager("김부장", 5000000, 1000000);
Developer developer = new Developer("이개발", 4000000, 10);
Intern intern = new Intern("박인턴");

manager.PrintInfo();
developer.PrintInfo();
intern.PrintInfo();