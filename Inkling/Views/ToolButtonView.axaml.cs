using Avalonia.Controls;
using Avalonia.Input;

using Inkling.ViewModels;

namespace Inkling.Views;

public partial class ToolButtonView : UserControl
{
	public ToolButtonView()
	{
		InitializeComponent();
	}

	private void BorderPointerPressed(object? _sender, PointerPressedEventArgs _e)
	{
		var vm = this.DataContext as ToolButtonViewModel;
		if (vm is null)
			return;
		vm.OpenTool(vm.Tool);
	}
}
