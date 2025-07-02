using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Inkling.Models;

namespace Inkling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty]
	private ViewModelBase? currentPage;
	[ObservableProperty]
	private string title;
	private readonly Tool[] _tools;
	public Tool[] Tools => _tools;

	public MainWindowViewModel()
	{
		_tools = new Tool[] {
			new Tool {
				Name = "Compress PDFs",
				Description = "Compress PDFs to a smaller size.",
				MultiFile = true,
				Color = "#db3612",
				Icon = "minimize-solid.svg",
			},
			new Tool {
				Name = "Merge PDFs",
				Description = "Merge PDFs into a single file.",
				MultiFile = true,
				Color = "#db9b12",
				Icon = "paperclip-solid.svg",
			},
			new Tool {
				Name = "Split PDF",
				Description = "Take the pages from a single PDF and create a new one.",
				MultiFile = false,
				Color = "#b7db12",
				Icon = "scissors-solid.svg",
			},
		};
		Title = "INKLING";
		CurrentPage = new HomeViewModel(this);
	}

	public void NavigateTo(ViewModelBase page)
	{
		CurrentPage = page;
	}
}
