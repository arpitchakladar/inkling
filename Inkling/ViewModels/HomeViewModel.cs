using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;

	public HomeViewModel(MainWindowViewModel main)
	{
		_main = main;
	}

	[RelayCommand]
	public void OpenToolPage()
	{
		_main.NavigateTo(new ToolViewModel(_main));
	}
}
