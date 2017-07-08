using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xmlTester.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace xmlTester.DAL
{
    public class d2aComparatorContext : DbContext
    {
        public d2aComparatorContext() : base("d2aComparatorContext")
        {
        }
        public DbSet<FundModel> Funds { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<d2a_SessionModel> d2a_Sessions { get; set; }
        public DbSet<d2a_ReturnSetModel> d2a_ReturnSets{ get; set; }
        public DbSet<FormModel> Forms { get; set; }
        public DbSet<d2a_UserInfoModel> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}