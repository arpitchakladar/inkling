using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
	[ObservableProperty]
	private ViewModelBase? currentPage;

	public MainWindowViewModel()
	{
		CurrentPage = new HomeViewModel(this);
	}

	public void NavigateTo(ViewModelBase page)
	{
		CurrentPage = page;
	}
}
