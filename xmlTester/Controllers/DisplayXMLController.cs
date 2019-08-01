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
using System.Collections.ObjectModel;

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
           
            var data = new csReturn();
            //var data_d2a = new List<returnListType>();
            //get data from source
            data = ReturnData(_Filename);
            //return data to view using model directive
            return View(data);
        }



        public csReturn ReturnData(string _FileName)
        {
            //get file path from server

            csReturn cs = new csReturn();                     //  < returns, <'Superannuation Quartely Return','Club Super',2017-03-31,'123 456 789 00'>>
            List<FormModel> returns = new List<FormModel>();  //  <  <320,"Bal Sheet",<{BE10003,'Cash at Bank, 100000.00,MONETARY},{BE10004,'Receivables',20000.00,MONETARY}>,<330,'Profit and Loss', <PL20000,'Contributions',300.00,MONETARY}> >
            if (string.IsNullOrEmpty(_FileName))
            {
                // _FileName = "ClubMar17new forms.xml";
                _FileName = "Club Superannuation Quarterly Return (RSE) Dec16 V2.xml";
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(Server.MapPath("~/XMLfiles/"), _FileName));


            formOwner foTemp = new formOwner();

            XmlNode formHeaderNode = doc.SelectSingleNode("/return");
            ViewBag.Fund = formHeaderNode.Attributes["entityName"].Value;
            ViewBag.Period = formHeaderNode.Attributes["period"].Value;
            DateTime tmpdate = DateTime.ParseExact(ViewBag.Period, "yyyy-MM-dd", null);
            ViewBag.PeriodShort = tmpdate.ToString("MMM yy");
            ViewBag.Name = formHeaderNode.Attributes["name"].Value;

            foTemp.entity = formHeaderNode.Attributes["entity"].Value;                  // 12345678911   ABN of APRA entity
            foTemp.period = Convert.ToDateTime(tmpdate);                                                    // 2016-12-31     APRA form date format
            foTemp.entityName = formHeaderNode.Attributes["entityName"].Value;          // "ABC Super"
            foTemp.name = formHeaderNode.Attributes["name"].Value;                      // "Superannuation Quarterly Return (RSE)"

            cs.fo = foTemp;
            cs.fms = returns;
         
            ViewBag.Filename = _FileName;

            foreach (XmlNode node in doc.SelectNodes("/return/form"))

            { //Fetch the Node values and assign it to Model

                List<formItems> tempList  = new List<formItems>();

                returns.Add(new FormModel
                {
                    name = node.Attributes["name"].Value,
                    code = node.Attributes["code"].Value,
                    items = tempList
                });


                //      foreach (XmlNode itemNode in node.SelectNodes("/return/form[@code='" & returns &  "']/item"))
                foreach (XmlNode itemNode in node.SelectNodes("./group/item"))
                {   //loop through each <item> node in the xml form:  <item code="BSAO22800" data_type="MONETARY" type="apra:currentTaxAssets">2,111</item>
                    int num = 0;
                    Dictionary<string, int> cv = new Dictionary<string,int>();

                    if (int.TryParse(itemNode.InnerText, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out num))
                    {
                        cv.Add(itemNode.Attributes["code"].Value, num);
                     }
                        else
                    {
                        cv.Add(itemNode.Attributes["code"].Value, 0);
                    }
                    //Now that we've set the dollar value to be $0 if it was null, or else the value in the form, we can add the formItem
                    tempList.Add(new formItems
                    {
                        codeVals = cv,
                        type = itemNode.Attributes["type"].Value,
                        data_type = itemNode.Attributes["data_type"].Value
                    });
                    ;
                }

            }
            return cs;
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
                            //code = itemNode.Attributes["code"].Value,
                            type = itemNode.Attributes["type"].Value,
                           // value = num
                        });
                }

            }


            return returns;
        }
    }
}