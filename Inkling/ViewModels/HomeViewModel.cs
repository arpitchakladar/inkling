using System.Linq;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public ObservableCollection<ToolButtonViewModel> ToolButtons { get; init; }

	public HomeViewModel(MainWindowViewModel main)
	{
		_main = main;
		_main.Title = "INKLING";

		ToolButtons = new ObservableCollection<ToolButtonViewModel>(_main.Tools
			.Select(tool => new ToolButtonViewModel(
				tool,
				OpenTool
			))
		);
	}

	public void OpenTool(Tool tool)
	{
		_main.NavigateTo(new ToolViewModel(_main, tool));
	}
}
