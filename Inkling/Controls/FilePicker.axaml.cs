using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;
using Inkling.Models;

namespace Inkling.Controls;

public partial class FilePicker : UserControl
{
	public static readonly StyledProperty<string?> SelectedPathProperty =
		AvaloniaProperty.Register<FilePicker, string?>(nameof(SelectedPath));
	public static readonly StyledProperty<bool> AllowMultipleProperty =
		AvaloniaProperty.Register<FilePicker, bool>(
			nameof(AllowMultiple),
			false
		);
	public static readonly StyledProperty<string> LabelProperty =
		AvaloniaProperty.Register<FilePicker, string>(
			nameof(Label),
			"Select File"
		);
	public static readonly StyledProperty<
		List<FilePickerFileType>
	> FileTypesProperty = AvaloniaProperty.Register<
		FilePicker,
		List<FilePickerFileType>
	>(
		nameof(FileTypes),
		new List<FilePickerFileType> { FilePickerFileTypes.All }
	);

	public string? SelectedPath
	{
		get => GetValue(SelectedPathProperty);
		set => SetValue(SelectedPathProperty, value);
	}
	public string Label
	{
		get => GetValue(LabelProperty);
		set => SetValue(LabelProperty, value);
	}
	public bool AllowMultiple
	{
		get => GetValue(AllowMultipleProperty);
		set => SetValue(AllowMultipleProperty, value);
	}
	public List<FilePickerFileType> FileTypes
	{
		get => GetValue(FileTypesProperty);
		set => SetValue(FileTypesProperty, value);
	}

	public FilePicker()
	{
		InitializeComponent();
	}

	private async void OnOpenFileClick(
		object? sender,
		Avalonia.Interactivity.RoutedEventArgs e
	)
	{
		var topLevel = TopLevel.GetTopLevel(this);
		if (topLevel == null)
			return;

		var files = await topLevel.StorageProvider.OpenFilePickerAsync(
			new FilePickerOpenOptions
			{
				Title = this.Label,
				AllowMultiple = AllowMultiple,
				FileTypeFilter = this.FileTypes,
			}
		);

		if (files.Count >= 1)
		{
			SelectedPath = files[0].Path.LocalPath;
		}
	}
}
