using System.Windows;

namespace OptionalParameterTaskWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        // this part is untracable from the exception we will get
        Dispatcher.BeginInvoke(FunctionWithOptional);
    }

    private void FunctionWithOptional(string? parameter = null)
    {
        Console.WriteLine("Method ran! " + parameter);
    }
}