using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Context;
using AutoSchool.ViewModels;
namespace AutoSchool.Logic
{
    public class PositionConverter
    {
        public static Position ToEntity(PositionViewModel model)
        {
            if (model == null)
                return null;
            Position Position = new Position
            {
                Id = model.Id,
                Name = model.Name,
                Salary = model.Salary
            };


            return Position;
        }

        public static PositionViewModel ToViewModel(Position position)
        {
            if (position == null)
                return null;

            PositionViewModel model = new PositionViewModel
            {
                Id = position.Id,
                Name = position.Name,
                Salary = position.Salary
            };
            return model;
        }

    }
}
