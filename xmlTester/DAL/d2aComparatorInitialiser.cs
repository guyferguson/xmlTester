using System;
using System.Collections.Generic;
using System.Linq;
using xmlTester.Models;

namespace xmlTester.DAL
{
    public class d2aComparatorInitialiser : System.Data.Entity.DropCreateDatabaseAlways<d2aComparatorContext>   //DropCreateDatabaseIfModelChanges<d2aComparatorContext>
    {
        protected override void Seed(d2aComparatorContext context)
        {

            var funds = new List<FundModel>
            {
            new FundModel{FundCode="CLUB",FullName="Club Super",DateAdded=DateTime.Now, Active=Active.Y, ABN=155344123123},
            new FundModel{FundCode="QIEC",FullName="Queensland Independent Education and Care",DateAdded=DateTime.Now, Active=Active.Y, ABN=155344123888},
            new FundModel{FundCode="ENERGY",FullName="Energy Super",DateAdded=DateTime.Now, Active=Active.Y,ABN=155344123999},
            new FundModel{FundCode="SMERF",FullName="Super Money Eligible Rollover Fund",DateAdded=DateTime.Now, Active=Active.N,ABN=155344123000, FundID=1  },
            };
            funds.ForEach(s => context.Funds.Add(s));
            context.SaveChanges();

            var returnSets = new List<d2a_ReturnSetModel>
            {
            new d2a_ReturnSetModel{entityName="CLUB",entity="155344123123", FullName="Club Super" },
            };

            returnSets.ForEach(s => context.d2a_ReturnSets.Add(s));
            context.SaveChanges();


            var users = new List<UserModel>
            {
            new UserModel{ FirstName="Guy", Surname="Ferguson", DateAdded = DateTime.Now, Active= Active.Y, GUID="{1234-0000-1234-A}"  },
            new UserModel{ FirstName="Mark", Surname="Blencoe", DateAdded = DateTime.Now, Active= Active.Y , GUID="{1234-1000-1234-A}"  },
            new UserModel{ FirstName="Adam", Surname="Somerville", DateAdded = DateTime.Now, Active= Active.Y , GUID="{1234-2000-1234-A}"  },
            new UserModel{ FirstName="Wendy", Surname="Chen", DateAdded = DateTime.Now, Active= Active.Y , GUID="{1234-3000-1234-A}"  },
            new UserModel{ FirstName="Philippa", Surname="Matthew", DateAdded = DateTime.Now, Active= Active.Y , GUID="{1234-4000-1234-A}"  },
            new UserModel{ FirstName="Biljana", Surname="Butterworth", DateAdded = DateTime.Now, Active= Active.Y , GUID="{1234-5000-1234-A}"  },
            new UserModel{ FirstName="Leonie", Surname="Ring", DateAdded = DateTime.Now, Active= Active.Y, GUID="{1234-6000-1234-A}"   },
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var sessions = new List<d2a_SessionModel>
            {
                new d2a_SessionModel { ID= 1, User = users.Single(s=>s.FirstName == "Guy") , logon= DateTime.Now}
            };
            sessions.ForEach(s => context.d2a_Sessions.Add(s));
            context.SaveChanges();


            var userInfos = new List<d2a_UserInfoModel>
            {
                new d2a_UserInfoModel {User = users.Single(s=>s.FirstName == "Guy"),Funds=funds.ToArray(), ReturnSets = returnSets.ToArray() }
            };
            userInfos.ForEach(s => context.UserInfo.Add(s));
            context.SaveChanges();



             base.Seed(context);
        }
    }
}