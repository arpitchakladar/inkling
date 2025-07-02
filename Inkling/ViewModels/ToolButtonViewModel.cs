using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class ToolButtonViewModel : ViewModelBase
{
	public required string Name { get; init; }
	public required string Description { get; init; }
	public required ICommand OpenToolCommand { get; init; }
}
