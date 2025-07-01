using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Inkling.Views;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		AddToolButtons();
	}

	private void AddToolButtons()
	{
		var wrapPanel = this.FindControl<WrapPanel>("ToolsPanel");
		for (int i = 1; i <= 10; i++)
		{
			var button = new Button
			{
				Width = 400,
				Height = 400,
			};

			var stackPanel = new StackPanel
			{
				HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
				VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
			};

			// Example: use a Path as icon
			var path = new Path
			{
				Data = Geometry.Parse("M12,2A10,10 0 1 0 12,22A10,10 0 1 0 12,2Z"),
				Fill = Brushes.Black,
				Width = 24,
				Height = 24,
			};

			// Heading
			var heading = new TextBlock
			{
				Text = $"Tool {i}",
				FontWeight = Avalonia.Media.FontWeight.Bold,
				FontSize = 12,
				TextAlignment = Avalonia.Media.TextAlignment.Center,
				Margin = new Thickness(0, 5, 0, 0),
			};

			// Description
			var description = new TextBlock
			{
				Text = $"Description {i}",
				FontSize = 10,
				TextAlignment = Avalonia.Media.TextAlignment.Center,
			};

			// Assemble parts
			stackPanel.Children.Add(path);
			stackPanel.Children.Add(heading);
			stackPanel.Children.Add(description);

			button.Content = stackPanel;

			wrapPanel.Children.Add(button);
		}
	}
}
