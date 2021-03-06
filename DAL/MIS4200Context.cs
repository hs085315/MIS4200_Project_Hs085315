﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MIS4200_Project_Hs085315.Models;

namespace MIS4200_Project_Hs085315.DAL
{
        public class MIS4200Context : DbContext // inherits from DbContext
        {
            public MIS4200Context() : base("name=DefaultConnection")
            {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, MIS4200_Project_Hs085315.Migrations.MISContext.Configuration>("DefaultConnection"));
            }
            // Include each object here. The value inside <> is the name of the class,
            // the value outside should generally be the plural of the class name
            // and is the name used to reference the entity in code
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Grade> Grades { get; set; }
            public DbSet<OrderDetail> OrderDetails { get; set; }

            public DbSet<Order> Orders { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);

        }
    }
}
