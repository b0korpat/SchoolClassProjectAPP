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
            SchoolClass mostPaydClass = _schoolClassRepo
                .FindAll()
                .OrderByDescending(sc => sc.StudentMonhlyDeposit)
                .First();
            return $"{mostPaydClass.ClassYear}.{mostPaydClass.ClassID}";
        }
    }
}
