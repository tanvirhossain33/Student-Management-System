using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    public class StudentManagementDb : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string root = @"C:\DataSource";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            optionsBuilder.UseSqlite(@"Data Source=" + root + @"\StudentManagementDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Student>().ToTable("Student");

            modelBuilder.Entity<Admin>()
                .HasData(
                    new Admin
                    {
                        Id = 1,
                        Username = "admin",
                        Password = "admin"
                    }
                );

            modelBuilder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        Id = 1,
                        LastName = "Tanvir",
                        FirstName = "Hossain",
                        StudentId = "123451",
                        CityOfResidence = "Dhaka",
                        Department = Department.ComputerEngineering
                    },
                    new Student
                    {
                        Id = 2,
                        LastName = "Mohammad",
                        FirstName = "Ali",
                        StudentId = "123452",
                        CityOfResidence = "Dhaka",
                        Department = Department.ElectricalEngineering
                    },
                    new Student
                    {
                        Id = 3,
                        LastName = "Foysal",
                        FirstName = "Ahamed",
                        StudentId = "123453",
                        CityOfResidence = "Dhaka",
                        Department = Department.BusinessEconomics

                    },
                    new Student
                    {
                        Id = 4,
                        LastName = "Tuhin",
                        FirstName = "Miah",
                        StudentId = "123454",
                        CityOfResidence = "Dhaka",
                        Department = Department.NaturalScience
                    }
                );
        }
    }
}
