using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UVisualLoggerLibrary_CsExtensions
{
	public static void LogText(this UWorld WorldContextObject, string Text, FName LogCategory, bool bAddToMessageLog)
	{
		UVisualLoggerLibrary.LogText(WorldContextObject, Text, LogCategory, bAddToMessageLog);
	}

	public static void LogSegment(this UWorld WorldContextObject, FVector SegmentStart, FVector SegmentEnd, string Text, FLinearColor ObjectColor, float Thickness, FName CategoryName, bool bAddToMessageLog)
	{
		UVisualLoggerLibrary.LogSegment(WorldContextObject, SegmentStart, SegmentEnd, Text, ObjectColor, Thickness, CategoryName, bAddToMessageLog);
	}

	public static void LogLocation(this UWorld WorldContextObject, FVector Location, string Text, FLinearColor ObjectColor, float Radius, FName LogCategory, bool bAddToMessageLog)
	{
		UVisualLoggerLibrary.LogLocation(WorldContextObject, Location, Text, ObjectColor, Radius, LogCategory, bAddToMessageLog);
	}

	public static void LogBox(this UWorld WorldContextObject, FBox BoxShape, string Text, FLinearColor ObjectColor, FName LogCategory, bool bAddToMessageLog)
	{
		UVisualLoggerLibrary.LogBox(WorldContextObject, BoxShape, Text, ObjectColor, LogCategory, bAddToMessageLog);
	}
}
