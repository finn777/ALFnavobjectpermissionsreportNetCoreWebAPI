using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ALFnavobjectpermissionsreportNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            using (navobjectpermissionsreportsqldatabaseContext db = new navobjectpermissionsreportsqldatabaseContext())
            {
                return "count: " + db.Data.Count<Data>().ToString();
            }

        }

        // GET api/values/TableData/17
        // type: TableData, TableDescription, Form, Report, Dataport, XMLport, Codeunit, MenuSuite, Page 
        // type parameter is case insensitivity, example: api/values/xmlport/10
        [HttpGet("{type}/{id}")]
        public List<Data> Get(string type, long id)
        {
            using (navobjectpermissionsreportsqldatabaseContext db = new navobjectpermissionsreportsqldatabaseContext())
            {
                var filterobjecttype = "\'" + type + "\'"; //'TableData'
                var filterobjectid = id;
                var data = db.Data.FromSql
                           ("SELECT * FROM DATA " +
                            $"WHERE objecttype = {filterobjecttype} and (({filterobjectid} >= rangefrom) AND ({filterobjectid} <= rangeto)) " +
                            "ORDER BY modulename, productline, versionname, dataid").ToList();
                return data;
            }
        }

    }
}
