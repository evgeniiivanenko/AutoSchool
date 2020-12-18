using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Context;
using AutoSchool.DataAccess.Interfaces;

namespace AutoSchool.DataAccess
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AutoSchoolContext context;

        public PositionRepository()
        {
            context = new AutoSchoolContext();
        }

        public void Add(Position Position)
        {
            context.Position.Add(Position);
            context.SaveChanges();
        }

        public int Create(Position Position)
        {
            throw new NotImplementedException();
        }

        public void DeletAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@PositionId", id);
            context.Database.ExecuteSqlCommand("PositionDeleteById @PositionId", param);
        }

        public IEnumerable<Position> GetAll()
        {
            var positions = context.Database.SqlQuery<Position>("PositionGetAll").ToList();
            return positions;
        }

        public Position GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Position Position)
        {
            System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@PositionId", Position.Id);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@Name", Position.Name);
            System.Data.SqlClient.SqlParameter param3 = new System.Data.SqlClient.SqlParameter("@Salary", Position.Salary);
            context.Database.ExecuteSqlCommand("PositionUpdate @PositionId, @Name, @Salary", new[] { param, param2, param3 });
        }
    }
}
