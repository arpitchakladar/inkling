using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class ToolViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public string ToolName => "Compress";

	public ToolViewModel(MainWindowViewModel main)
	{
		_main = main;
	}

	[RelayCommand]
	public void GoBack()
	{
		_main.NavigateTo(new HomeViewModel(_main));
	}
}
