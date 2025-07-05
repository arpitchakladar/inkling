using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inkling.Models;

namespace Inkling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty]
	private ViewModelBase? _currentPage;

	[ObservableProperty]
	private string _title;

	public MainWindowViewModel()
	{
		Title = "INKLING";
		NavigateTo(new HomeViewModel(this));
	}

	public void NavigateTo(ViewModelBase page)
	{
		CurrentPage = page;
	}
}
