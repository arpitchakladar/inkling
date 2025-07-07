using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.Controls;

public partial class ChoiceBar : UserControl
{
	public partial class ChoiceBarChoice : ObservableObject
	{
		public required string Text { get; init; }

		[ObservableProperty]
		// Notify UI when IsSelected changes
		[NotifyPropertyChangedFor(nameof(BackgroundBrush))]
		[NotifyPropertyChangedFor(nameof(ForegroundBrush))]
		private bool _isSelected;

		// Computed property for Background Brush based on IsSelected
		public IBrush BackgroundBrush =>
			IsSelected ? Brushes.Black : Brushes.Transparent;

		// Computed property for Foreground Brush based on IsSelected
		public IBrush ForegroundBrush =>
			IsSelected ? Brushes.White : Brushes.Black;
	}

	public static readonly StyledProperty<string> LabelProperty =
		AvaloniaProperty.Register<ChoiceBar, string>(
			nameof(Label),
			"Choose Option"
		);
	public static readonly StyledProperty<
		ObservableCollection<ChoiceBarChoice>
	> ChoicesProperty = AvaloniaProperty.Register<
		ChoiceBar,
		ObservableCollection<ChoiceBarChoice>
	>(nameof(Choices), new ObservableCollection<ChoiceBarChoice>());
	private string _currentChoice;

	public string Label
	{
		get => GetValue(LabelProperty);
		set => SetValue(LabelProperty, value);
	}
	public string Choices
	{
		set =>
			SetValue(
				ChoicesProperty,
				new ObservableCollection<ChoiceBarChoice>(
					value
						.Split(',')
						.Select(choice => new ChoiceBarChoice()
						{
							Text = choice,
							IsSelected = _currentChoice == choice,
						})
				)
			);
	}
	public ObservableCollection<ChoiceBarChoice> ChoicesArray =>
		GetValue(ChoicesProperty);
	public string Choice
	{
		set
		{
			_currentChoice = value;
			foreach (var choice in ChoicesArray)
			{
				choice.IsSelected = choice.Text == _currentChoice;
			}
		}
	}
	public string Default
	{
		set => Choice = value;
	}

	public ChoiceBar()
	{
		InitializeComponent();
	}

	private void OnChooseOption(
		object? sender,
		Avalonia.Interactivity.RoutedEventArgs e
	)
	{
		if (sender is not Button button || button.Tag is not string choice)
			return;

		Choice = choice;
	}
}
