using CustomCashless.ViewModels;

namespace CustomCashless.Views
{
  /// <summary>
  ///   Interaktionslogik für MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {
    public MainWindow(MainWindowViewModel viewModel)
    {
      DataContext = viewModel;
      InitializeComponent();
    }
  }
}