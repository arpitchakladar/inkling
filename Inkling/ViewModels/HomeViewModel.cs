using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inkling.Models.Tools;

namespace Inkling.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public ToolButtonViewModel[] ToolButtons { get; }

	public HomeViewModel(MainWindowViewModel main)
	{
		_main = main;
		_main.Title = "INKLING";

		ToolButtons = Tool
			.Tools.Select(tool => new ToolButtonViewModel(tool, OpenTool))
			.ToArray();
	}

	public void OpenTool(Tool tool)
	{
		_main.NavigateTo(new ToolViewModel(_main, tool));
	}
}
