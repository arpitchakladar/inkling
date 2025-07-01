using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class ToolButtonViewModel : ViewModelBase
{
	public readonly int _id;
	private readonly ICommand _openToolCommand;
	public string Title => "Merge PDFs";
	public string Description => "Merge multiple PDFs into a single PDF file.";
	public ICommand OpenToolCommand => _openToolCommand;

	public ToolButtonViewModel(int id, ICommand OpenToolCommand)
	{
		_id = id;
		_openToolCommand = OpenToolCommand;
	}
}
