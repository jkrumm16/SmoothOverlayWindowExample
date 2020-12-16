using DemoWpfApplication.ViewModels;

namespace WpfApp
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
