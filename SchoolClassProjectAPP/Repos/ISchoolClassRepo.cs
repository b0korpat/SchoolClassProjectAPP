using SchoolClassProjectAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProjectAPP.Repos
{
    public interface ISchoolClassRepo
    {
        public List<SchoolClass> FindAll();
    }
}
