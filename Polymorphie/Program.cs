using Polymorphie.GAZ;
using Polymorphie.CsharpMasterclass;
using System;
using System.Collections.Generic;

//GAZ
List<Shape> shapes = new List<Shape>();
shapes.Add(new Circle());
shapes.Add(new Rectangle());
shapes.Add(new Circle());
shapes.Add(new Circle());
shapes.Add(new Circle());
shapes.Add(new Rectangle());
shapes.Add(new Rectangle());
shapes.Add(new Rectangle());
Canvas canvas = new();
canvas.DrawShapes(shapes);
Console.WriteLine("\n");


// Die Methoden Reparieren und ZeigeDetails in der Bas-Class
// MUSS mit virtual deklariert werden, damit diese geerbten
// Methoden ind den Unterklassen mit override deklariert werden
// können. Andern Falls werden die Unterklassen wie die Basisklasse
// behandelt, wodurch die geerbten Methoden nicht als override gelten!
var autos = new List<Auto>
{
    new Audi("A4", 200, "blau"),
    new Audi("Quatro", 140, "rot"),
    new BMW("5", 130, "schwarz"),
    new BMW("6", 240, "silber")
};

foreach (var auto in autos)
{
    auto.ZeigeDetails();
    auto.Reparieren();
}
Console.WriteLine("\n");

Audi audi = new("A5", 150, "gold");
BMW bmw = new("Z3", 120, "schwarz");
audi.SetInfo(333666, "Jonas Engelen");
audi.GetInfo();
bmw.GetInfo();

Console.ReadLine();
