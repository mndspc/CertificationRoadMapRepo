using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class CRMDbEntities : DbContext
    {
        public CRMDbEntities() : base("name=CRMDbEntities")
        {

        }
        public DbSet<TechInfo> TechInfoes { get; set; }
        public DbSet<CertiDetails> CertiDetails { get; set; }
      
    }

    public class CRMDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CRMDbEntities>
    {
        protected override void Seed(CRMDbEntities context)
        {
            CertiDetails certifications = new CertiDetails { CertiId = 1, CertiName = "Managing Office 365 Content Services", ExamCode = "MS-300T01", TechId = 1, ReleaseDate = DateTime.Parse("03-05-2010"), ExpiryDate = DateTime.Parse("01 - 01 - 2023") };           
            context.CertiDetails.Add(certifications);
            context.SaveChanges();        
        }
    }
}