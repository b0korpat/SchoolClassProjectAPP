using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProjectAPP.Models
{
    public class SchoolClass
    {
        private int classYear;
        private string classID;
        private int studentMonhlyDeposit;
        private int studentCount;

        public SchoolClass()
        {
        }
        public SchoolClass(int classYear, string classID, int studentMonhlyDeposit, int studentCount)
        {
            this.classYear = classYear;
            this.classID = classID;
            this.studentMonhlyDeposit = studentMonhlyDeposit;
            this.studentCount = studentCount;
        }

        public int ClassYear { get => classYear; set => classYear = value; }
        public string ClassID { get => classID; set => classID = value; }
        public int StudentMonhlyDeposit { get => studentMonhlyDeposit; set => studentMonhlyDeposit = value; }
        public int StudentCount { get => studentCount; set => studentCount = value; }

        public override string ToString()
        {
            return $"{ClassYear}. {ClassID} ({StudentMonhlyDeposit} Ft)";
        }
    }
}
