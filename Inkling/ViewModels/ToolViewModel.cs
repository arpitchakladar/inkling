using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Inkling.Models.Tools;
using Inkling.ViewModels.Tools;

namespace Inkling.ViewModels;

public partial class ToolViewModel : ViewModelBase
{
	private readonly MainWindowViewModel _main;
	public Tool Tool { get; }
	public ToolViewModelBase RealToolViewModel { get; }

	public ToolViewModel(MainWindowViewModel main, Tool tool)
	{
		_main = main;
		_main.Title = tool.Name;
		Tool = tool;
		RealToolViewModel = tool switch
		{
			CompressPDFsTool => new CompressPDFsToolViewModel(),
			// TODO: Complete this
			MergePDFsTool => null,
			SplitPDFTool => null,
		};
	}

	[RelayCommand]
	public void GoBack()
	{
		_main.NavigateTo(new HomeViewModel(_main));
	}

	[RelayCommand]
	public void RunTool()
	{
		Tool.RunAsync(RealToolViewModel.Options);
	}
}
