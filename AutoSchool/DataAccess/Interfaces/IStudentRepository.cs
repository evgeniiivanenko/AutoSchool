using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Context;
namespace AutoSchool.DataAccess.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetAllById(int id);

        void Add(Student Student);

        void Delete(int id);

        void Update(Student Student);

        Student GetById(int id);

        int Create(Student Student);

        void DeletAll();
    }
}
