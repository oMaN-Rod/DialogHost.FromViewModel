using System.Windows;
using Prism.Ioc;
using Prism.Regions;

namespace DialogHost.FromViewModel.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IContainerExtension _container;
        private IRegionManager _regionManager;

        public MainWindow(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;
            _regionManager = regionManager;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var view = _container.Resolve<ViewA>();
            var region = _regionManager.Regions["ContentRegion"];
            region.Add(view);
        }
    }
}
