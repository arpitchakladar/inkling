using CommunityToolkit.Mvvm.ComponentModel;

using Inkling.Models;
using Inkling.ViewModels;

namespace Inkling.ViewModels.Tools;

public partial class CompressPDFsToolViewModel : ToolViewModelBase
{
	[ObservableProperty]
	public CompressPDFsToolOptions _options;
	public FilePickerViewModel FilePicker { get; }

	public CompressPDFsToolViewModel()
	{
		FilePicker = new FilePickerViewModel(CompressPDFsTool.Instance.Color);
	}
}
