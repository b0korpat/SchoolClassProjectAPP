using Moq;
using SchoolClassProjectAPP.Models;
using SchoolClassProjectAPP.Repos;

namespace SchoolClassProjectAPP.Service.Tests
{
    [TestClass()]
    public class SchoolClassServiceMostPaydSchoolClassTest
    {
        private readonly SchoolClassService _schoolClassService;
        private readonly Mock<ISchoolClassRepo> _schoolClassRepoMock = new Mock<ISchoolClassRepo>();

        public SchoolClassServiceMostPaydSchoolClassTest()
        {
            _schoolClassService = new SchoolClassService(_schoolClassRepoMock.Object);
        }

        [TestMethod()]
        public void OnePaidMost()
        {
            //arrange
            List<SchoolClass> schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { ClassYear = 11, ClassID = "a", StudentMonhlyDeposit = 2000, StudentCount = 10},
                new SchoolClass { ClassYear = 9, ClassID = "b", StudentMonhlyDeposit = 6000, StudentCount = 10},
                new SchoolClass { ClassYear = 12, ClassID = "c", StudentMonhlyDeposit = 8000, StudentCount = 10}
            };

            _schoolClassRepoMock
               .Setup(repo => repo.FindAll())
               .Returns(schoolClasses);

            //act
            string actual = _schoolClassService.MostPaydSchoolClass();

            //assert
            Assert.AreEqual("12.c", actual);
        }
        [TestMethod()]
        public void AllPaidSame()
        {
            //arrange
            List<SchoolClass> schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { ClassYear = 11, ClassID = "a", StudentMonhlyDeposit = 8000, StudentCount = 10},
                new SchoolClass { ClassYear = 19, ClassID = "c", StudentMonhlyDeposit = 8000, StudentCount = 10},
                new SchoolClass { ClassYear = 12, ClassID = "b", StudentMonhlyDeposit = 8000, StudentCount = 10}
            };

            _schoolClassRepoMock
               .Setup(repo => repo.FindAll())
               .Returns(schoolClasses);

            //act
            string actual = _schoolClassService.MostPaydSchoolClass();

            //assert
            Assert.AreEqual("11.a", actual);
        }
        [TestMethod()]
        public void OneClassOnly()
        {
            //arrange
            List<SchoolClass> schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { ClassYear = 11, ClassID = "a", StudentMonhlyDeposit = 6000, StudentCount = 10},
            };

            _schoolClassRepoMock
               .Setup(repo => repo.FindAll())
               .Returns(schoolClasses);

            //act
            string actual = _schoolClassService.MostPaydSchoolClass();

            //assert
            Assert.AreEqual("11.a", actual);
        }
        [TestMethod()]
        public void NegativPay()
        {
            //arrange
            List<SchoolClass> schoolClasses = new List<SchoolClass>()
            {
                new SchoolClass { ClassYear = 11, ClassID = "c", StudentMonhlyDeposit = 6000, StudentCount = 10},
                new SchoolClass { ClassYear = 12, ClassID = "a", StudentMonhlyDeposit = -1000, StudentCount = 10},
            };

            _schoolClassRepoMock
               .Setup(repo => repo.FindAll())
               .Returns(schoolClasses);

            //act
            string actual = _schoolClassService.MostPaydSchoolClass();

            //assert
            Assert.AreEqual("11.c", actual);
        }
        [TestMethod()]
        public void EmptyList()
        {
            //arrange
            List<SchoolClass> schoolClasses = new List<SchoolClass>();

            _schoolClassRepoMock
               .Setup(repo => repo.FindAll())
               .Returns(schoolClasses);

            //act
            string actual = "";
            try
            {
                actual = _schoolClassService.MostPaydSchoolClass();
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Sequence contains no elements", ex.Message);
            }

            //assert

            Assert.AreEqual("", actual);
        }
    }
}