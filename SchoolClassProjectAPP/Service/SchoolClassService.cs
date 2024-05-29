using SchoolClassProjectAPP.Models;
using SchoolClassProjectAPP.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProjectAPP.Service
{
    public class SchoolClassService : ISchoolClassService
    {
        private readonly ISchoolClassRepo _schoolClassRepo;

        public SchoolClassService(ISchoolClassRepo schoolClassRepo)
        {
            _schoolClassRepo = schoolClassRepo;
        }

        public string MostPaydSchoolClass()
        {
            List<SchoolClass> schoolClasses = _schoolClassRepo.FindAll();

            if (schoolClasses.Count == 0)
            {
                return null;
            }

            SchoolClass mostPaydClass = schoolClasses
                .OrderByDescending(sc => sc.StudentMonhlyDeposit)
                .First();

            return $"{mostPaydClass.ClassYear}.{mostPaydClass.ClassID}";
        }
        public void TenMonthPaymentForThirtyStudent()
        {

            List<SchoolClass> classes = _schoolClassRepo.FindAll();

            foreach (SchoolClass schoolClass in classes)
            {
                Console.WriteLine($"{schoolClass.ClassYear}.{schoolClass.ClassID} össze befizetett osztálypénze: {schoolClass.StudentMonhlyDeposit*300}");
            }



        }
    }
}
