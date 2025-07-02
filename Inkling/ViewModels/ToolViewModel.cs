using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public Tool Tool { get; init; }

	public ToolViewModel(MainWindowViewModel main, Tool tool)
	{
		_main = main;
		Tool = tool;
		_main.Title = Tool.Name;
	}

	[RelayCommand]
	public void GoBack()
	{
		_main.NavigateTo(new HomeViewModel(_main));
	}
}
