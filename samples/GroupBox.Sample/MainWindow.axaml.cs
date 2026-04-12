using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GroupBox.Avalonia.Sample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
