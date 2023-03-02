using MauiApp6.MVVM.Views;

namespace MauiApp6;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
