using SchoolClassProjectAPP.Models;

namespace SchoolClassProjectAPP.Repos
{
    public class SchoolClassRepo : ISchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses;

        public SchoolClassRepo()
        {
            _schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { ClassYear = 11, ClassID = "a", StudentMonhlyDeposit = 2000, StudentCount = 10},
                new SchoolClass { ClassYear = 9, ClassID = "b", StudentMonhlyDeposit = 6000, StudentCount = 10},
                new SchoolClass { ClassYear = 12, ClassID = "c", StudentMonhlyDeposit = 8000, StudentCount = 10}
            };
        }
        public List<SchoolClass> FindAll()
        {
            return _schoolClasses;
        }
        
    }
}

