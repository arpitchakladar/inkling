using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolButtonViewModel : ViewModelBase
{
	public ICommand OpenToolCommand { get; init; }
	public Tool Tool { get; init; }

	public ToolButtonViewModel(Tool tool, ICommand openToolCommand) {
		Tool = tool;
		OpenToolCommand = openToolCommand;
	}
}
