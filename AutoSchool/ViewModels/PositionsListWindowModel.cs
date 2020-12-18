using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.Logic.Interface;

namespace AutoSchool.ViewModels
{
    public class PositionsListWindowModel : ViewModelBase
    {
        #region ICommand
        public ICommand SaveChange { get; private set; }
        public ICommand DeletePosition { get; private set; }
        public ICommand СancelPosition { get; private set; }
        public ICommand CreatePosition { get; set; }
        public ICommand UpdatePosition { get; set; }
        #endregion
        #region Private Variables
        private PositionViewModel selectedPosition;
        private PositionViewModel currentPosition;
        private bool isEnabled;
        private bool IsNewPosition;
        private IPositionLogic positionLogic;
        private AutoSchool.Views.PositionDetailsWnd detail;
        #endregion
        #region Collection
        public ObservableCollection<PositionViewModel> AllPositions { get; set; } = new ObservableCollection<PositionViewModel>();
        #endregion
        #region Public Property
        public bool IsEnabled
        {
            get
            { return isEnabled; }
            set
            {
                isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }
        public PositionViewModel SelectedPosition
        {
            get { return selectedPosition; }
            set
            {
                selectedPosition = value;
                CurrentPosition = value;
                OnPropertyChanged("SelectedPosition");
            }
        }
        public PositionViewModel CurrentPosition
        {
            get { return currentPosition; }
            set
            {
                if (value != null)
                {
                    IsEnabled = true;
                    currentPosition = new PositionViewModel(value);
                }
                else
                {
                    currentPosition = value;
                    IsEnabled = false;
                }
                OnPropertyChanged("CurrentPosition");
            }
        }
        #endregion
        #region Constructor
        public PositionsListWindowModel(IPositionLogic positionLogic)
        {

            IsEnabled = false;
            IsNewPosition = false;
            this.positionLogic = positionLogic ?? throw new ArgumentNullException("positionLogic");

            AllPositions.Clear();

            AllPositions = UpdateCollection();

            AllPositions.CollectionChanged += (sender, e) =>
            {
                if (e.OldItems != null && e.OldItems.Contains(SelectedPosition))
                    SelectedPosition = null;
            };
            this.SaveChange = new Helper.DelegateCommand((o) => this.Save(), (o) =>
            {
                if (SelectedPosition == null || !IsСhangeSelectedCustomer())
                    return false;
                return true;
            });
            this.DeletePosition = new Helper.DelegateCommand((o) => this.Delete(), (o) => SelectedPosition != null);
            this.СancelPosition = new Helper.DelegateCommand((o) => this.Cancel(), (o) => SelectedPosition != null);
            this.CreatePosition = new Helper.DelegateCommand((o) => this.Create());
            this.UpdatePosition = new Helper.DelegateCommand((o) => this.Update(), (o) => SelectedPosition != null);
        }
        #endregion
        #region Private Methods
        private ObservableCollection<PositionViewModel> UpdateCollection()
        {
            List<PositionViewModel> viewModels = new List<PositionViewModel>();
            foreach (var model in positionLogic.GetAll())
            {
                viewModels.Add(model);
            }
            return new ObservableCollection<PositionViewModel>(viewModels.OrderBy(i => i.Id));

        }

        private void Save()
        {
            if (SelectedPosition == null)
                return;
            if (IsNewPosition)
            {
                AllPositions.Add(SelectedPosition);
                positionLogic.Add(SelectedPosition);
            }
            else
            {
                positionLogic.Update(SelectedPosition);
            }

            SelectedPosition = null;

            if (detail != null)
            {
                detail.Close();
                detail = null;
            }
        }

        private void Delete()
        {
            if (SelectedPosition == null)
                return;
            MessageBoxResult result = MessageBox.Show("Вы действительно хотете удалить " + SelectedPosition.Name , "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                positionLogic.Delete(SelectedPosition.Id);
                AllPositions.Remove(SelectedPosition);
                SelectedPosition = null;
            }
        }

        private void Create()
        {
            if (SelectedPosition != null)
                Cancel();
            SelectedPosition = new PositionViewModel();
            IsNewPosition = true;

            detail = new AutoSchool.Views.PositionDetailsWnd {
                DataContext = this
            };

            detail.Show();
        }

        private void Update()
        {
            if (SelectedPosition == null)
                Cancel();

            detail = new AutoSchool.Views.PositionDetailsWnd
            {
                DataContext = this
            };

            detail.Show();
        }

        private void Cancel()
        {
            if (SelectedPosition == null || CurrentPosition == null)
                return;
            SelectedPosition.Id = CurrentPosition.Id;
            SelectedPosition.Name = CurrentPosition.Name;
            SelectedPosition.Salary = CurrentPosition.Salary;
            SelectedPosition = null;
        }

        private bool IsСhangeSelectedCustomer()
        {
            return true;
            //return !PositionViewModel.IsEquals(SelectedPosition, CurrentPosition);
        }
        #endregion
    }
}
