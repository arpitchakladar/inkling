using CommunityToolkit.Mvvm.ComponentModel;

using Inkling.Models;
using Inkling.ViewModels;

namespace Inkling.ViewModels.Tools;

public abstract class ToolViewModelBase : ObservableObject
{
	public abstract ToolOptions Options { get; protected set; }
}
