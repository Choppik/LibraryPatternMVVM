namespace LibraryPatternMVVM.Services.NavigationServices
{
    public interface IParamNavigationService<TParameter>
    {
        void Navigate(TParameter parameter);
    }
}