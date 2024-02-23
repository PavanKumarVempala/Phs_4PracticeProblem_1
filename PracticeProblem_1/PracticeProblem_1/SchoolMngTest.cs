using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLib;

namespace PracticeProblem_1
{
    [TestFixture]
    public class SchoolMngTest
    {
        SchMang schMang;   
        [SetUp]
        public void SetUp()
        {
            schMang = new SchMang();
        }
        [Test]
        public void SchollNotNull()
        {
            foreach(var tech in SchMang.allDetails())
            {
                Assert.IsNotNull(tech.Id);
                Assert.IsNotNull(tech.TName);
                Assert.IsNotNull(tech.Subject);
                Assert.IsNotNull(tech.Salary);
               
            }

        }
    }
}
