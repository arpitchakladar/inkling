using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolButtonViewModel : ViewModelBase
{
	public Action<Tool> OpenTool { get; }
	public Tool Tool { get; }

	public ToolButtonViewModel(Tool tool, Action<Tool> openTool) {
		Tool = tool;
		OpenTool = openTool;
	}
}
