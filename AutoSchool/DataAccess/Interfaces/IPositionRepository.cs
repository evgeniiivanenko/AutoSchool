using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Context;

namespace AutoSchool.DataAccess.Interfaces
{
    public interface IPositionRepository
    {
        IEnumerable<Position> GetAll();

        void Add(Position Position);

        void Delete(int id);

        void Update(Position Position);

        Position GetById(int id);

        int Create(Position Position);

        void DeletAll();
    }
}
