using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

public static class B1GlobalFSlateColor
{
	public static readonly FSlateColor Gray = new FSlateColor
	{
		SpecifiedColor = new FLinearColor(FColor.FromHex("#373737"))
	};

	public static readonly FSlateColor Green = new FSlateColor
	{
		SpecifiedColor = new FLinearColor(FColor.FromHex("#006019"))
	};

	public static readonly FSlateColor Red = new FSlateColor
	{
		SpecifiedColor = new FLinearColor(FColor.FromHex("#B71D16"))
	};

	public static readonly FSlateColor Yellow = new FSlateColor
	{
		SpecifiedColor = new FLinearColor(FColor.FromHex("#F27203"))
	};
}
