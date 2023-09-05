using LibraryPatternMVVM.ViewModels.Base;
using System;

namespace LibraryPatternMVVM.Stores
{
    public class ModalNavigationStore
    {
        public event Action CurrentViewModelChanged;
        public bool IsOpen => CurrentViewModel != null;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        public void Close() => CurrentViewModel = null;
        private void OnCurrentViewModelChanged() => CurrentViewModelChanged?.Invoke();
    }
}
