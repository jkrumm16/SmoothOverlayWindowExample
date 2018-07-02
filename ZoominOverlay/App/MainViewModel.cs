namespace WpfApp
{
    public class MainViewModel : ViewModelBase
    {
        private bool _showOverlay;

        public bool ShowOverlay
        {
            get { return _showOverlay; }
            set { SetFieldAndNotifyPropertyChanged(ref _showOverlay, value); }
        }

        public SimpleRelayCommand ShowOverlayCommand { get; private set; }
        public SimpleRelayCommand CloseOverlayCommand { get; private set; }

        public MainViewModel()
        {
            ShowOverlayCommand = new SimpleRelayCommand(OnShowOverlay);
            CloseOverlayCommand = new SimpleRelayCommand(OnCloseOverlay);
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
