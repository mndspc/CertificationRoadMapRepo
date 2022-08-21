using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public interface ICertiDetailsDAL<CertiDetails>
    {
        List<CertiDetails> GetAllCertification();
        CertiDetails GetCertiByExamCode(string examCode);
        bool AddCertiDetails(CertiDetails certiDetails);
        bool UpdateCertiDetails(CertiDetails certiDetails);
        bool DeleteCertiDetails(int id);
    }
}
