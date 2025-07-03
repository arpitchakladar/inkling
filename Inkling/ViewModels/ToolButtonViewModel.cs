using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolButtonViewModel : ViewModelBase
{
	private readonly Action<Tool> _openTool;
	public Tool Tool { get; }

	public ToolButtonViewModel(Tool tool, Action<Tool> openTool) {
		Tool = tool;
		_openTool = openTool;
	}

	[RelayCommand]
	public void OpenTool() {
		_openTool(Tool);
	}
}
