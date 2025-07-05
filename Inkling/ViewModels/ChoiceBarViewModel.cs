using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Inkling.ViewModels;

public partial class ChoiceBarViewModel : ViewModelBase
{
	public partial class ChoiceBarChoice : ObservableObject
	{
		public required string Text { get; init; }
		public required ICommand Command { get; init; }

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

	public string Label { get; }
	public ObservableCollection<ChoiceBarChoice> Choices { get; set; }
	public string Choice => Choices.FirstOrDefault(c => c.IsSelected)?.Text;

	public ChoiceBarViewModel(
		string label,
		string[] choices,
		string defaultChoice
	)
	{
		Label = label;
		Choices = new ObservableCollection<ChoiceBarChoice>(
			choices.Select(choice => new ChoiceBarChoice()
			{
				Text = choice,
				Command = new RelayCommand(() => Choose(choice)),
				IsSelected = choice == defaultChoice,
			})
		);
	}

	public void Choose(string choice)
	{
		foreach (var currentChoice in Choices)
		{
			currentChoice.IsSelected = currentChoice.Text == choice;
		}
	}
}
