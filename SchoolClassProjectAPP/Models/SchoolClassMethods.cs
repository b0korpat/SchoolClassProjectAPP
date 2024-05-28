namespace SchoolClassProjectAPP.Models
{
    public class StudentClassMethods
    {
        public static void DifferanceBetweenClasses(SchoolClass first, SchoolClass second)
        {
            int difference = first.StudentMonhlyDeposit - second.StudentMonhlyDeposit;

            if (difference > 0)
            {
                Console.WriteLine($"{first.ClassYear}.{first.ClassID} osztály diákjai havonta {Math.Abs(difference)} forinttal többet fizetnek osztálypénzbe, mint {second.ClassYear}.{second.ClassID} osztály tanulói.");
            }
            else if (difference < 0)
            {
                Console.WriteLine($"{second.ClassYear}.{second.ClassID} osztály diákjai havonta {Math.Abs(difference)} forinttal többet fizetnek osztálypénzbe, mint {first.ClassYear}.{first.ClassID} osztály tanulói.");
            }
            else
            {
                Console.WriteLine($"{first.ClassYear}.{first.ClassID} és {second.ClassYear}.{second.ClassID} osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.");
            }
        }
    }
}
