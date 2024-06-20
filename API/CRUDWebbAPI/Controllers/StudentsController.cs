using CRUDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;

namespace CRUDWebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        CollegeEntities OE = new CollegeEntities();
        // ..api/Students/
        public IQueryable<student> Get()
        {
            return OE.students;
        }
        // ../api/Students/1
        public student Get(int id) { 
            student student = OE.students.Find(id);
            return student;
        }

        // ../api/department
        public void Put(int id, student student)
        {
            //OE.Entry(student).State = System.Data.Entity.EntityState.Modified;
            //OE.SaveChanges();
            student foundStudent = OE.students.Find(id);
            foundStudent.FirstName = student.FirstName;
            foundStudent.LastName = student.LastName;   
            foundStudent.age = student.age;
            foundStudent.Gender = student.Gender;
            OE.SaveChanges();
        }

        // ../api/department
        public void Delete(int id)
        {
            student student = OE.students.Find(id);
            OE.students.Remove(student);
            OE.SaveChanges();
        }
        // ..api/Students/
        public void Post(student student)
        {
            OE.students.Add(student);
            OE.SaveChanges();
        }
    }
}