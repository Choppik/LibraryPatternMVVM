using LibraryPatternMVVM.Stores;
using LibraryPatternMVVM.ViewModels.Base;
using System;

namespace LibraryPatternMVVM.Services.NavigationServices
{
    public class ParameterNavigationService<TParameter, TViewModel> : IParamNavigationService<TParameter>
        where TViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _navigationStore;
        private readonly Func<TParameter, TViewModel> _createViewModel;

        public ParameterNavigationService(ModalNavigationStore navigationStore, Func<TParameter, TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}