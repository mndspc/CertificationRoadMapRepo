using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using DAL.Models;
using System.Collections;

namespace DALTest
{

    [TestFixture]
    internal class CertiDetailsDALTest
    {
        [Test]
        public void AddCertiTest()
        {
            Mock<ICertiDetailsDAL<CertiDetails>> mockObject = new Mock<ICertiDetailsDAL<CertiDetails>>();
            var flag = false;
            CertiDetails certi = new CertiDetails { CertiId = 1, CertiName = "Managing Office 365 Content Services", ExamCode = "MS-300T01", TechId = 1, ReleaseDate = DateTime.Parse("03-05-2010"), ExpiryDate = DateTime.Parse("01-01-2023") };
            if (certi.CertiId> 0)
            {
                flag = true;
            }          
            mockObject.Setup(m=>m.AddCertiDetails(certi)).Returns(flag);
            Mock.Verify();
            var result = mockObject.Object;
            //Actual Result
            var certiDALResult = result.AddCertiDetails(certi);

            //Expected Result
            Assert.True(certiDALResult);
        }

        [Test]
        public void GetAllCertiTest()
        {
            ArrayList codes = new ArrayList {1,2 };
            Mock<ICertiDetailsDAL<CertiDetails>> mockObject = new Mock<ICertiDetailsDAL<CertiDetails>>();
            mockObject.Setup(m => m.GetAllCertification()).Returns(new List<CertiDetails> { new CertiDetails { CertiId = 1, CertiName = "Managing Office 365 Content Services", ExamCode = "MS-300T01", TechId = 1, ReleaseDate = DateTime.Parse("03-05-2010"), ExpiryDate = DateTime.Parse("01-01-2023") }, new CertiDetails { CertiId = 2, CertiName = "Managing SharePoint Online", ExamCode = "MS-300T02", TechId = 2, ReleaseDate = DateTime.Parse("03-05-2015"), ExpiryDate = DateTime.Parse("01-01-2024") } });

            var flag = false;
            var actualCerti = mockObject.Object;
            var expectedCerti = actualCerti.GetAllCertification();
            expectedCerti = expectedCerti.ToList();
            foreach (var certi in expectedCerti)
            {
                if (codes.Contains( certi.CertiId))
                {
                    flag= true;
                }
            }
            Assert.True(flag);
        }

        [Test]
        [TestCase("MS-300T01")]
        public void GetCertiByExamCode(string examCode)
        {
            
            Mock<ICertiDetailsDAL<CertiDetails>> mockObject = new Mock<ICertiDetailsDAL<CertiDetails>>();

            mockObject.Setup(m => m.GetCertiByExamCode(examCode)).Returns(new CertiDetails { CertiId = 1, CertiName = "Managing Office 365 Content Services", ExamCode = "MS-300T01", TechId = 1, ReleaseDate = DateTime.Parse("03-05-2010"), ExpiryDate = DateTime.Parse("01-01-2023") });

            Mock.Verify();
            var actualCertiResult = mockObject.Object;
            var expectedCerti= actualCertiResult.GetCertiByExamCode(examCode);

            var actualResult= actualCertiResult.GetCertiByExamCode(examCode);
            Assert.AreEqual(expectedCerti.ExamCode, actualResult.ExamCode);
        }

       

        [Test]
        public void UpdateCertiTest()
        {
            Mock<ICertiDetailsDAL<CertiDetails>> mockObject = new Mock<ICertiDetailsDAL<CertiDetails>>();
            var flag = false;
            CertiDetails certi = new CertiDetails { CertiId = 1, CertiName = "Managing Office 365 Content Services", ExamCode = "MS-300T01", TechId = 1, ReleaseDate = DateTime.Parse("03-05-2010"), ExpiryDate = DateTime.Parse("01-01-2023") };
            if (certi.CertiId > 0)
            {
                flag = true;
            }
            mockObject.Setup(m => m.UpdateCertiDetails(certi)).Returns(flag);
            Mock.Verify();
            var result = mockObject.Object;
            //Actual Result

            var certiDALResult = result.UpdateCertiDetails(certi);

            //Expected Result
            Assert.True(certiDALResult);
        }
    }
}