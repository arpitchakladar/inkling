using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	private readonly Tool _tool;
	public string ToolName => _tool.Name;

	public ToolViewModel(MainWindowViewModel main, Tool tool)
	{
		_main = main;
		_tool = tool;
		_main.Title = ToolName;
	}

	[RelayCommand]
	public void GoBack()
	{
		_main.NavigateTo(new HomeViewModel(_main));
	}
}
