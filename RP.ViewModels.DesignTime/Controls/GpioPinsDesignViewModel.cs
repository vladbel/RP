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
                    PinName = 1,
                    PinValue = 11,
                    PinMode = PinMode.Read
                },
                new PinViewModel()
                {
                    PinName = 2,
                    PinValue = 22,
                    PinMode = PinMode.Write
                },
                new PinViewModel()
                {
                    PinName = 3,
                    PinValue = 33,
                    PinMode = PinMode.Write
                }

            };
        }
    }
}
