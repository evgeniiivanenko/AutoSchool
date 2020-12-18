using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoSchool.Logic;
using AutoSchool.Logic.Interface;
using AutoSchool.DataAccess.Interfaces;
using AutoSchool.DataAccess;
using AutoSchool.ViewModels;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace AutoSchool.Views
{
    /// <summary>
    /// Interaction logic for PositionsListWnd.xaml
    /// </summary>
    public partial class PositionsListWnd : Window
    {
        private IPositionLogic positionLogic;
        private IPositionRepository positionRepository;
        public PositionsListWnd()
        {
            InitializeComponent();

            try
            {
                positionRepository = new PositionRepository();
                positionLogic = new PositionLogic(positionRepository);

                PositionsListWindowModel viewModel = new PositionsListWindowModel(positionLogic);

                DataContext = viewModel;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(1);
            }
        }
    }
}
