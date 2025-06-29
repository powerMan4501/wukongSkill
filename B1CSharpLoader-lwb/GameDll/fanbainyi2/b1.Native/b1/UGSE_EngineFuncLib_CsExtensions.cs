using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class UGSE_EngineFuncLib_CsExtensions
{
	public static void DrawDebugCircleArc(this UWorld WorldContextObject, FVector Center, float Radius, FVector Direction, float AngleWidth, int NumSegments, FLinearColor LineColor, float Duration, float Thickness)
	{
		UGSE_EngineFuncLib.DrawDebugCircleArc(WorldContextObject, Center, Radius, Direction, AngleWidth, NumSegments, LineColor, Duration, Thickness);
	}
}
