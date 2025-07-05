namespace Inkling.Models.Tools;

public sealed class CompressPDFsToolOptions : ToolOptions
{
	public CompressionLevel CompressionLevel { get; init; } =
		CompressionLevel.Medium;
}
