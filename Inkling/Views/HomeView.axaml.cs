using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;

using Inkling.ViewModels;

namespace Inkling.Views;

public partial class HomeView : UserControl
{
	public HomeView()
	{
		InitializeComponent();

		this.DataContextChanged += (_, _) => AddToolButtons();
	}

	private void AddToolButtons()
	{
		var vm = this.DataContext as HomeViewModel;

		if (vm is null)
			return;

		for (int i = 1; i <= 10; i++)
		{
			vm.ToolButtons.Add(new ToolButtonViewModel(i, vm.OpenToolCommand));
		}
	}
}
