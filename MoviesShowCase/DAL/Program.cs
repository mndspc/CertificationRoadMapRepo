using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
namespace DAL
{
    internal class Program
    {
        static void Main()
        {
            using (CRMDbEntities dbContext = new CRMDbEntities())
            {
                var techs = new List<TechInfo>
                {
                new TechInfo{TechId=1,TechName="Microsoft Office"},
                new TechInfo{TechId=2,TechName="Microsoft Sharepoint"}
                };

                techs.ForEach(s => dbContext.TechInfoes.Add(s));
                dbContext.SaveChanges();
            }
            
        }
    }
}
