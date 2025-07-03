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

	public MainWindowViewModel()
	{
		Title = "INKLING";
		CurrentPage = new HomeViewModel(this);
	}

	public void NavigateTo(ViewModelBase page)
	{
		CurrentPage = page;
	}
}
