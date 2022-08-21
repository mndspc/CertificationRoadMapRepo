using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CertiDetailsDAL : ICertiDetailsDAL<CertiDetails>
    {
        public bool AddCertiDetails(CertiDetails certiDetails)
        {
            using (CRMDbEntities dbContext=new CRMDbEntities())
            {
                dbContext.CertiDetails.Add(certiDetails);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool DeleteCertiDetails(int id)
        {         
            using (CRMDbEntities dbContext = new CRMDbEntities())
            {
                var movie = dbContext.CertiDetails.Find(id);
                dbContext.CertiDetails.Remove(movie);
                dbContext.SaveChanges();
                return true;
            }
        }

        public List<CertiDetails> GetAllCertification()
        {
            using (CRMDbEntities dbContext = new CRMDbEntities())
            {
                return dbContext.CertiDetails.ToList();
            }
        }

        public CertiDetails GetCertiByExamCode(string examCode)
        {
            using (CRMDbEntities dbContext = new CRMDbEntities())
            {
                var certi = dbContext.CertiDetails.Where(c=>c.ExamCode==examCode).FirstOrDefault();         
                return certi;
            }
        }

        public bool UpdateCertiDetails(CertiDetails certi)
        {
            using (CRMDbEntities dbContext = new CRMDbEntities())
            {
                var existCerti = dbContext.CertiDetails.Find(certi.CertiId);
                existCerti.CertiId=certi.CertiId;
                existCerti.ExamCode=certi.ExamCode;
                existCerti.CertiName=certi.CertiName;
                existCerti.TechId=certi.TechId;
                existCerti.ReleaseDate = certi.ReleaseDate;
                existCerti.ExpiryDate=certi.ExpiryDate;
              
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
