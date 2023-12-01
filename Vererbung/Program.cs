using System;
using Vererbung.Gaz;
using Vererbung.CsharpMasterclass;

Car car = new("12315415436243");

Employee employee = new("Meiser", "Hans", 1700); 
Trainee Trainee = new(336, 270, "Kerchgens", "Tim", 900);
Boss boss = new(true, "Steiner", "Peter", 15500);

employee.Work();
Trainee.Work();
boss.Lead();
boss.Work();

Console.ReadLine();
