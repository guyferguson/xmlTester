using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using xmlTester.Models;
using System.IO;
using System.Globalization;

namespace xmlTester.Controllers
{

    public class DisplayXMLController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DisplayXML(string _Filename)
        {
           
            var data = new List<FormModel>();
            var data_d2a = new List<returnListType>();
            //get data from source
            data = ReturnData(_Filename);
            //return data to view using model directive
            return View(data);
        }



        public List<FormModel> ReturnData(string _FileName)
        {
            //get file path from server

            List<FormModel> returns = new List<FormModel>();
            if (string.IsNullOrEmpty(_FileName))
            {
                _FileName = "ClubMar17new forms.xml";
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(Server.MapPath("~/XMLfiles/"), _FileName));


            formOwner fo = new formOwner();

            XmlNode formHeaderNode = doc.SelectSingleNode("/return");
            ViewBag.Fund = formHeaderNode.Attributes["entityName"].Value;
            ViewBag.Period = formHeaderNode.Attributes["period"].Value;
            DateTime tmpdate = DateTime.ParseExact(ViewBag.Period, "yyyy-MM-dd", null);
            ViewBag.PeriodShort = tmpdate.ToString("MMM yy");
            ViewBag.Name = formHeaderNode.Attributes["name"].Value;
            ViewBag.Filename = _FileName;

            foreach (XmlNode node in doc.SelectNodes("/return/form"))

            { //Fetch the Node values and assign it to Model


                List<formItems> tempList = new List<formItems>();

                returns.Add(new FormModel
                {
                    name = node.Attributes["name"].Value,
                    code = node.Attributes["code"].Value,
                    items = tempList
                });


                //      foreach (XmlNode itemNode in node.SelectNodes("/return/form[@code='" & returns &  "']/item"))
                foreach (XmlNode itemNode in node.SelectNodes("./group/item"))
                {   //loop through each item in the form
                    int num;
                    if (int.TryParse(itemNode.InnerText, NumberStyles.AllowThousands,
                                     CultureInfo.InvariantCulture, out num))
                        tempList.Add(new formItems
                        {
                            code = itemNode.Attributes["code"].Value,
                            type = itemNode.Attributes["type"].Value,
                            value = num
                        });
                }

            }




            return returns;
        }

        public List<FormModel> ReturnData()
        {
            //get file path from server

            List<FormModel> returns = new List<FormModel>();
            XmlDocument doc = new XmlDocument();
            String filename = "Club Mar17v2.xml";
            doc.Load(Path.Combine(Server.MapPath("~/XMLfiles/"), filename));
            //   doc.Load(Server.MapPath("~/XMLfiles/ClubMar17new forms.xml"));

            formOwner fo = new formOwner();

            XmlNode formHeaderNode = doc.SelectSingleNode("/return");
            ViewBag.Fund = formHeaderNode.Attributes["entityName"].Value;
            ViewBag.Period = formHeaderNode.Attributes["period"].Value;
            DateTime tmpdate = DateTime.ParseExact(ViewBag.Period, "yyyy-MM-dd", null);
            ViewBag.PeriodShort = tmpdate.ToString("MMM yy");
            ViewBag.Name = formHeaderNode.Attributes["name"].Value;
            ViewBag.Filename = filename;

            foreach (XmlNode node in doc.SelectNodes("/return/form"))

            { //Fetch the Node values and assign it to Model


                List<formItems> tempList = new List<formItems>();

                returns.Add(new FormModel
                {
                    name = node.Attributes["name"].Value,
                    code = node.Attributes["code"].Value,
                    items = tempList
                });


                //      foreach (XmlNode itemNode in node.SelectNodes("/return/form[@code='" & returns &  "']/item"))
                foreach (XmlNode itemNode in node.SelectNodes("./group/item"))
                {   //loop through each item in the form
                    int num;
                    if (int.TryParse(itemNode.InnerText, NumberStyles.AllowThousands,
                                     CultureInfo.InvariantCulture, out num))
                        tempList.Add(new formItems
                        {
                            code = itemNode.Attributes["code"].Value,
                            type = itemNode.Attributes["type"].Value,
                            value = num
                        });
                }

            }


            return returns;
        }
    }
}