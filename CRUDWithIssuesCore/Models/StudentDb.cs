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

        public static async Task<Student> GetStudent(SchoolContext context, int id)
        {
            Student p = await context
                            .Students
                            .Where(s => s.StudentId == id)
                            .SingleOrDefaultAsync();
            return p;
        }

        public static async Task DeleteById(int id, SchoolContext context)
        {

            //Mark the object as deleted
            Student s = new Student()
            {
                StudentId = id
            };
            context.Entry(s).State = EntityState.Deleted;

            //Send delete query to database
            await context.SaveChangesAsync();
        }

        public static async Task<Student> UpdateStudent(Student p, SchoolContext context)
        {
            context.Update(p);
            await context.SaveChangesAsync();
            return p;
        }
    }
}
