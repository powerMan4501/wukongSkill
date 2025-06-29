using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

public static class USlateLibrary_CsExtensions
{
	public static void ScreenToWidgetLocal(this UWorld WorldContextObject, FGeometry Geometry, FVector2D ScreenPosition, out FVector2D LocalCoordinate, bool bIncludeWindowPosition = false)
	{
		USlateLibrary.ScreenToWidgetLocal(WorldContextObject, Geometry, ScreenPosition, out LocalCoordinate, bIncludeWindowPosition);
	}

	public static void ScreenToWidgetAbsolute(this UWorld WorldContextObject, FVector2D ScreenPosition, out FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition = false)
	{
		USlateLibrary.ScreenToWidgetAbsolute(WorldContextObject, ScreenPosition, out AbsoluteCoordinate, bIncludeWindowPosition);
	}

	public static void ScreenToViewport(this UWorld WorldContextObject, FVector2D ScreenPosition, out FVector2D ViewportPosition)
	{
		USlateLibrary.ScreenToViewport(WorldContextObject, ScreenPosition, out ViewportPosition);
	}

	public static void LocalToViewport(this UWorld WorldContextObject, FGeometry Geometry, FVector2D LocalCoordinate, out FVector2D PixelPosition, out FVector2D ViewportPosition)
	{
		USlateLibrary.LocalToViewport(WorldContextObject, Geometry, LocalCoordinate, out PixelPosition, out ViewportPosition);
	}

	public static void AbsoluteToViewport(this UWorld WorldContextObject, FVector2D AbsoluteDesktopCoordinate, out FVector2D PixelPosition, out FVector2D ViewportPosition)
	{
		USlateLibrary.AbsoluteToViewport(WorldContextObject, AbsoluteDesktopCoordinate, out PixelPosition, out ViewportPosition);
	}
}
