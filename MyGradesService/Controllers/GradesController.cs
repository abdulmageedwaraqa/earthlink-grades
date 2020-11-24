using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GradesDataAccess;

namespace MyGradesService.Controllers
{
    public class GradesController : ApiController
    {
        public IEnumerable<tblResult> Get()
        {
            using (ResultsDBEntities entities = new ResultsDBEntities())
            {
                return entities.tblResults.ToList();
            }
        }

        public tblResult Get(String id)
        {
            using (ResultsDBEntities entities = new ResultsDBEntities())
            {
                return entities.tblResults.FirstOrDefault(e => e.ExamID ==id);
            }
        }
    }
}
