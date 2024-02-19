using Moq;
using SchoolLib;

namespace TestProjectSchool
{
    [TestFixture]
    public class Tests
    {
        SchoolManagement schmgmt;
        [SetUp]
        public void Setup()
        {
            schmgmt = new SchoolManagement();
        }

        [Test]
        public void AllStuNotNull()
        {
            foreach(School sc in  schmgmt.Allstulist()) {
                Assert.IsNotNull(sc.StuId);
                Assert.IsNotNull(sc.SubName);
                Assert.IsNotNull(sc.TeacherName);

                Assert.IsNotNull(sc.SubName);
            }

        }
        [Test]
        public void SearchStuTest()
        {
            int id = 2;
            string name = "Shyam";
            foreach(School sc in schmgmt.SearchStu(2))
            {
                Assert.That(sc.StuId, Is.EqualTo(id));
                Assert.That(sc.StuName, Is.EqualTo(name));
            }
        }
        [Test]
        public void StumarkTest()
        {
            Mock<SchoolManagement> mock = new Mock<SchoolManagement>();
            mock.Setup(x => x.StudentMarks()).Returns(true);
            Assert.That(mock.Object.StudentMarks(), Is.EqualTo(true));
        }
    }
}