using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using xmlTester.DAL;
using xmlTester.Models;
using System.IO;

namespace xmlTester.Controllers
{
    public class UploadFileController : Controller
    {
        private d2aComparatorContext db = new d2aComparatorContext();
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadAdditionalFile()
        {
            var funds = from r in db.Funds
                        select r.FullName;
            // Send a different model to this View - so it can list all existiing sets in UserInfo
            //var model = new d2a_UserInfoModel {Funds=funds.ToArray, ReturnSets="lots" }
            return View(funds);
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            string _FileName = "";
            try
            {
                if (file.ContentLength > 0)
                {
                    _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/XMLfiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                var data = new List<FormModel>();
                var data_d2a = new List<returnListType>();
                //get data from source
              //  data = ReturnData(_FileName);
                //retrn data to view using model directive

                return RedirectToAction("DisplayXML", "DisplayXML", new { _FileName = _FileName});
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }

       
    }
}