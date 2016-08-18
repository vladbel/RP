using RP.ViewModels.Controls;
using System.Collections.ObjectModel;


namespace RP.ViewModels.DesignTime.Controls
{
    public class GpioPinsDesignViewModel: GpioPinsViewModel
    {
        public GpioPinsDesignViewModel()
        {
            Pins = new ObservableCollection<PinViewModel>()
            {
                new PinViewModel()
                {
                    PinValue = 55,
                    PinMode = PinMode.Read
                },
                new PinViewModel()
                {
                    PinValue = 66,
                    PinMode = PinMode.Write
                }
            };
        }
    }
}
