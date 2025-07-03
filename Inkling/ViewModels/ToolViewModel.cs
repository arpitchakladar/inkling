using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class ToolViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public Tool Tool { get; }
	public FilePickerViewModel FilePicker { get; }

	public ToolViewModel(MainWindowViewModel main, Tool tool)
	{
		_main = main;
		_main.Title = tool.Name;
		Tool = tool;
		FilePicker = new FilePickerViewModel(tool.Color);
	}

	[RelayCommand]
	public void GoBack()
	{
		_main.NavigateTo(new HomeViewModel(_main));
	}
}
