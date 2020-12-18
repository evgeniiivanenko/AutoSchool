using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Logic.Interface;
using AutoSchool.ViewModels;
using AutoSchool.DataAccess.Interfaces;

namespace AutoSchool.Logic
{
    public class PositionLogic : IPositionLogic
    {
        IPositionRepository repository;

        public PositionLogic(IPositionRepository repository)
        {
            this.repository = repository;
        }
        public void Add(PositionViewModel model)
        {
            repository.Add(PositionConverter.ToEntity(model));
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public List<PositionViewModel> GetAll()
        {
            return repository.GetAll().Select(PositionConverter.ToViewModel).ToList();
        }

        public PositionViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PositionViewModel model)
        {
            repository.Update(PositionConverter.ToEntity(model));
        }
    }
}
