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
	public ChoiceBarViewModel CompressionQuality { get; }

	public CompressPDFsToolViewModel()
	{
		Options = new CompressPDFsToolOptions();
		FilePicker = new FilePickerViewModel(CompressPDFsTool.Instance.Color);
		CompressionQuality = new ChoiceBarViewModel(
			"Compression Level",
			new string[] { "Low", "Medium", "High" },
			"Medium"
		);
	}
}
