using LibraryPatternMVVM.Stores;

namespace LibraryPatternMVVM.Services.NavigationServices
{
    public class CloseModalNavigationService : INavigationService
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public CloseModalNavigationService(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public void Navigate() => _modalNavigationStore.Close();
    }
}