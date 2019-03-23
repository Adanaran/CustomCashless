using System.Windows;
using CustomCashless.Views;
using Grace.DependencyInjection;

namespace CustomCashless
{
  /// <summary>
  ///   Interaktionslogik für "App.xaml"
  /// </summary>
  public partial class App
  {
    private DependencyInjectionContainer container;

    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      container = new DependencyInjectionContainer();
      Current.MainWindow = container.Locate<MainWindow>();
      Current.MainWindow.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
      base.OnExit(e);
      container.Dispose();
    }
  }
}