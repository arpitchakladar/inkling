namespace Inkling.ViewModels;

public partial class FilePickerViewModel : ViewModelBase
{
	public string Color { get; }

	public FilePickerViewModel(string color)
	{
		Color = color;
	}
}
