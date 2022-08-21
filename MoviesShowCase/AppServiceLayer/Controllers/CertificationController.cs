using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Models;
namespace AppServiceLayer.Controllers
{
  
    public class CertificationController : ApiController
    {
        CertiDetailsDAL CertiDAL = new CertiDetailsDAL();

        [HttpPost]
        [Route("Certi/SaveCerti")]
        public HttpResponseMessage PostCertiInfo(CertiDetails certi)
        {
           var result= CertiDAL.AddCertiDetails(certi);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
          }

        [HttpDelete]
        [Route("Certi/DeleteCerti/{id}")]
        public HttpResponseMessage DeleteCerti(int id)
        {
            var result = CertiDAL.DeleteCertiDetails(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPut]
        [Route("Certi/UpdateCerti")]
        public HttpResponseMessage UpdateMoview([FromBody] CertiDetails certiDetails)
        {
            var result = CertiDAL.UpdateCertiDetails(certiDetails);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpGet]
        [Route("Certi/GetAll")]
        public HttpResponseMessage GetAllCertifications()
        {
            var certiInfoes = CertiDAL.GetAllCertification();
            if (certiInfoes!=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,certiInfoes);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpGet]
        [Route("Certi/GetByExamCode/{examCode}")]
        public HttpResponseMessage GetByExamCode(string examCode)
        {
            var certiInfo = CertiDAL.GetCertiByExamCode(examCode);
            if (certiInfo != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, certiInfo);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }


    }
}
