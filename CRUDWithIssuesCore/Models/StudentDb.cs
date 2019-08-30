using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithIssuesCore.Models
{
    public static class StudentDb
    {
        public static async Task<Student> Add(Student p, SchoolContext db)
        {
            //Add student to context
            await db.AddAsync(p);
            await db.SaveChangesAsync();
            return p;

        }

        public static async Task<List<Student>> GetStudents(SchoolContext context)
        {
            List<Student> students = await context.Students.OrderBy(s => s.Name).ToListAsync();
            return students;
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
