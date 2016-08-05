using RP.ViewModels.Common;

namespace RP.ViewModels.DesignTime
{
    public class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            Property = "Designe Time Property";
        }

        private string _property;
        public string Property
        {
            get
            {
                return _property;
            }
            set
            {
                _property = value;
                OnPropertyChanged();
            }
        }
    }
}
