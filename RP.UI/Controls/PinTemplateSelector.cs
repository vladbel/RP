using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using RP.ViewModels.Controls;

namespace RP.UI.Controls
{
    public class PinTemplateSelector: DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {

            if (item != null && item is PinViewModel)
            {
                var pinViewModel = item as PinViewModel;

                switch (pinViewModel.PinMode)
                {
                    case PinMode.Read:
                        return PinReaderTemplate;
                    case PinMode.Write:
                        return PinWriterTemplate;
                }
            }

            return null;
        }

        public DataTemplate PinReaderTemplate { get; set; }
        public DataTemplate PinWriterTemplate { get; set; }
    }
}
