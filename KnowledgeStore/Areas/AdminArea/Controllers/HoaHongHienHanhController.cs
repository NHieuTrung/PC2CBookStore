using Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeStore.Areas.AdminArea.Controllers
{
    public class HoaHongHienHanhController : Controller
    {
        KnowledgeStoreEntities db = new KnowledgeStoreEntities();
        // GET: AdminArea/HoaHongHienHanh
        public ActionResult Index()
        {
            var lshh = db.LichSuHoaHongs.ToList();

            return View(lshh);
        }
    }
}