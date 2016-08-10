using RP.ViewModels.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.ViewModels.DesignTime.Controls
{
    public class PinReadOnlyViewModel: PinViewModel 
    {
        public PinReadOnlyViewModel() : base()
        {
            this.PinMode = PinMode.Read;
            this.PinValue = 33;
            this.PinName = 60;
        }
    }
}
