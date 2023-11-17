using Linq_Beispiel;


/**
Linq = Language Integrated Query

Abfrageausdrücke können verwendet werden, um Daten aus einer beliebigen LINQ-fähigen Datenquelle abzufragen und zu transformieren.
Mit einer einzigen Abfrage können z.B. Daten aus einer SQL-Datenbank abgerufen und ein XML-Stream als Ausgabe generiert werden.
**/


StudentUniversityManager sum = new();
sum.FindMaleStudents();
sum.SelectUniversity();
sum.StudentAndUniversityName();

XMLBeispiel xmlb = new();
xmlb.UseXMLString();

