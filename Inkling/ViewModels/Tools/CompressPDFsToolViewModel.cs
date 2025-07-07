using CommunityToolkit.Mvvm.ComponentModel;
using Inkling.Models.Tools;
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
	public ChoiceBarViewModel CompressionQuality { get; }

	public CompressPDFsToolViewModel()
	{
		Options = new CompressPDFsToolOptions();
		CompressionQuality = new ChoiceBarViewModel(
			"Compression Level",
			new string[] { "Low", "Medium", "High" },
			"Medium"
		);
	}
}
