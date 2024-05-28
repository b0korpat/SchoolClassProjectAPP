using SchoolClassProjectAPP.Models;
using SchoolClassProjectAPP.Service;
using SchoolClassProjectAPP.Repos;

Console.WriteLine("hello");
SchoolClass kilencA =  new SchoolClass(9,"a",7000,3);
SchoolClass kilencB =  new SchoolClass(9,"b",6000, 3);

Console.WriteLine(kilencA.ToString());

StudentClassMethods.DifferanceBetweenClasses(kilencA, kilencB);


SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
SchoolClassService schoolClassService = new SchoolClassService(schoolClassRepo);
Console.WriteLine(schoolClassService.MostPaydSchoolClass());
