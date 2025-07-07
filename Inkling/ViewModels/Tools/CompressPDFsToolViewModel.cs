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

	public CompressPDFsToolViewModel()
	{
		Options = new CompressPDFsToolOptions();
	}
}
