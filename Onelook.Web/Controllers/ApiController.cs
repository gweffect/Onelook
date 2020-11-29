using Microsoft.AspNetCore.Mvc;
using Onelook.Data;
using Onelook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onelook.Web.Controllers
{
    public class ApiController : Controller
    {
        private readonly DbContext dbContext;
        private readonly IFreeSql db;
        public ApiController(DbContext _dbContext)
        {
            dbContext = _dbContext;
            db = _dbContext.instance;
        }
        public IActionResult GetHotWordList()
        {
            var list = dbContext.instance.Select<HotWord>().ToList();
            return Json(list);
        }

        public IActionResult GetRecommendList()
        {
            var list = db.Select<Recommend>().ToList();
            return Json(list);
        }

        public IActionResult GetRecommendDetailList(int? recommendId)
        {
            var list = db.Select<RecommandDetail>().Where(parms => parms.RecommandId == recommendId).ToList();
            return Json(list);
        }
    }
}
