using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.ViewModels;
namespace AutoSchool.Logic.Interface
{
    public interface IPositionLogic
    {
        List<PositionViewModel> GetAll();

        PositionViewModel GetById(int id);

        void Add(PositionViewModel model);

        void Update(PositionViewModel model);

        void Delete(int id);

        void DeleteAll();
    }
}
