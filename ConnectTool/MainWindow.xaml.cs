using System.Windows.Input;
using DnDTool.ViewModel;
using MahApps.Metro.Controls;

namespace DnDTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void UIElement_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MenuToggleButton.IsChecked = false;
        }

        //private async void MenuPopupButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    var sampleMessageDialog = new SampleMessageDialog
        //    {
        //        Message = { Text = ((ButtonBase)sender).Content.ToString() }
        //    };

        //    await DialogHost.Show(sampleMessageDialog, "RootDialog");
        //}
    }
}