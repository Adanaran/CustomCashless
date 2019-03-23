using System.ComponentModel;
using System.Runtime.CompilerServices;
using CustomCashless.Annotations;

namespace CustomCashless.ViewModels
{
  public class MainWindowViewModel : INotifyPropertyChanged
  {
    private decimal sum;

    public decimal Sum
    {
      get => sum;
      set
      {
        if (value == sum) { return; }

        sum = value;
        OnPropertyChanged();
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}