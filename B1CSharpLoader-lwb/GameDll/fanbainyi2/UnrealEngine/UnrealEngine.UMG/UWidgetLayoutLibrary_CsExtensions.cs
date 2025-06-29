using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

public static class UWidgetLayoutLibrary_CsExtensions
{
	public static void RemoveAllWidgets(this UWorld WorldContextObject)
	{
		UWidgetLayoutLibrary.RemoveAllWidgets(WorldContextObject);
	}

	public static FGeometry GetViewportWidgetGeometry(this UWorld WorldContextObject)
	{
		return UWidgetLayoutLibrary.GetViewportWidgetGeometry(WorldContextObject);
	}

	public static FVector2D GetViewportSize(this UWorld WorldContextObject)
	{
		return UWidgetLayoutLibrary.GetViewportSize(WorldContextObject);
	}

	public static float GetViewportScale(this UWorld WorldContextObject)
	{
		return UWidgetLayoutLibrary.GetViewportScale(WorldContextObject);
	}

	public static FVector2D GetMousePositionOnViewport(this UWorld WorldContextObject)
	{
		return UWidgetLayoutLibrary.GetMousePositionOnViewport(WorldContextObject);
	}
}
