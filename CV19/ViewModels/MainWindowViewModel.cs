using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        /// <summary> Заголовок окна </summary>
        private string _Title ="Анализ статистики CV19";
        public string Title
        { 
            get => _Title;
            set => Set(ref _Title, value); 
        }

        #endregion

        #region Статус программы

        /// <summary>Статус программы</summary> 
        private string _Status = "Ready";
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        #region Close applicatin command

        public ICommand CloseAppCommand { get; }

        private bool CloseAppCommandExecute(object p) => true;

        private void OnCloseAppCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        public MainWindowViewModel()
        {
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecute, CloseAppCommandExecute);
        }
    }
}
