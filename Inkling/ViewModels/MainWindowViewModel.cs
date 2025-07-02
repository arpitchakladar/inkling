using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty]
	private ViewModelBase? currentPage;
	private readonly Tool[] _tools;
	public Tool[] Tools => _tools;

	public MainWindowViewModel()
	{
		_tools = new Tool[] {
			new Tool {
				Name = "Compress",
				Description = "Compress PDFs to a smaller size.",
				MultiFile = true,
			},
			new Tool {
				Name = "Merge",
				Description = "Merge PDFs into a single file.",
				MultiFile = true,
			},
			new Tool {
				Name = "Split",
				Description = "Take the pages from a single PDF and create a new one.",
				MultiFile = false,
			},
		};
		CurrentPage = new HomeViewModel(this);
	}

	public void NavigateTo(ViewModelBase page)
	{
		CurrentPage = page;
	}
}
