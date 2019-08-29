﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithIssuesCore.Models
{
    public static class StudentDb
    {
        public static Student Add(Student p, SchoolContext db)
        {
            //Add student to context
            db.Students.Add(p);
            db.SaveChanges();
            return p;

        }

        public static List<Student> GetStudents(SchoolContext context)
        {
            return (from s in context.Students
                    select s).ToList();
        }

        public static Student GetStudent(SchoolContext context, int id)
        {
            Student p = context
                            .Students
                            .Where(s => s.StudentId == id)
                            .SingleOrDefault();
            return p;
        }

        public static void Delete(SchoolContext context, Student p)
        {

            //Mark the object as deleted
            Student s = new Student()
            {
                StudentId = p.StudentId
            };
            context.Entry(s).State = EntityState.Deleted;

            //Send delete query to database
            context.SaveChanges();
        }

        public static void Update(SchoolContext context, Student p)
        {
            context.Students.Update(p);
        }
    }
}
