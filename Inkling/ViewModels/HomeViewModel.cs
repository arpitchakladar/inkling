using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public ObservableCollection<ToolButtonViewModel> ToolButtons { get; } = new();

	public HomeViewModel(MainWindowViewModel main)
	{
		_main = main;

		AddToolButtons();
	}

	[RelayCommand]
	public void OpenTool()
	{
		_main.NavigateTo(new ToolViewModel(_main));
	}

	private void AddToolButtons() {
		foreach (var tool in _main.Tools)
		{
			ToolButtons.Add(new ToolButtonViewModel {
				Name = tool.Name,
				Description = tool.Description,
				OpenToolCommand = OpenToolCommand,
			});
		}
	}
}
