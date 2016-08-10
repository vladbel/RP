using RP.ViewModels.Common;
using RP.ViewModels.Controls;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RP.ViewModels.DesignTime.Controls
{
    public class PinWritableViewModel : PinViewModel
    {
        public PinWritableViewModel() : base()
        {
            PinMode = PinMode.Write;
            PinValue = 77;
            PinName = 11;
        }
    }
}
