using DemoWpfApplication.Commands;
using DemoWpfApplication.ViewModels.Base;

namespace DemoWpfApplication.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool _showOverlay;

        public bool ShowOverlay
        {
            get { return _showOverlay; }
            set { SetField(ref _showOverlay, value); }
        }

        public RelayCommand ShowOverlayCommand { get; private set; }
        public RelayCommand CloseOverlayCommand { get; private set; }

        public MainViewModel()
        {
            ShowOverlayCommand = new RelayCommand(OnShowOverlay);
            CloseOverlayCommand = new RelayCommand(OnCloseOverlay);
        }

        private void OnCloseOverlay()
        {
            ShowOverlay = false;
        }

        private void OnShowOverlay()
        {
            ShowOverlay = true;
        }
    }
}
