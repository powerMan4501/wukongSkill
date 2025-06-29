using UnrealEngine.Runtime;

namespace b1;

public struct FDisplayLine
{
	public string Line;

	public FColor Color;

	public static FDisplayLine Empty = new FDisplayLine
	{
		Line = string.Empty,
		Color = FColor.White
	};

	public FDisplayLine(string InLine, FColor InColor)
	{
		Line = InLine;
		Color = InColor;
	}
}
