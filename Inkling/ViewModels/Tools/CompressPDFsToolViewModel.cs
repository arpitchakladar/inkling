using CommunityToolkit.Mvvm.ComponentModel;
using Inkling.Models;
using Inkling.ViewModels;

namespace Inkling.ViewModels.Tools;

public partial class CompressPDFsToolViewModel : ToolViewModelBase
{
	private CompressPDFsToolOptions _options;
	public override ToolOptions Options
	{
		get => _options;
		protected set =>
			SetProperty(ref _options, (CompressPDFsToolOptions)value);
	}
	public FilePickerViewModel FilePicker { get; }

	public CompressPDFsToolViewModel()
	{
		Options = new CompressPDFsToolOptions();
		FilePicker = new FilePickerViewModel(CompressPDFsTool.Instance.Color);
	}
}
