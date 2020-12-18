using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Context;
using AutoSchool.DataAccess.Interfaces;

namespace AutoSchool.DataAccess
{
    public class StudentRepository : IStudentRepository
    {

        private AutoSchoolContext context;

        public StudentRepository()
        {
            context = new AutoSchoolContext();
        }

        public void Add(Student Student)
        {
            throw new NotImplementedException();
        }

        public int Create(Student Student)
        {
            throw new NotImplementedException();
        }

        public void DeletAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student Student)
        {
            throw new NotImplementedException();
        }
    }
}
