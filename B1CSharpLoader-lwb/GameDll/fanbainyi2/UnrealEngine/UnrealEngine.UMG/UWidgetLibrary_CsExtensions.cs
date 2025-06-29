using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

public static class UWidgetLibrary_CsExtensions
{
	public static bool SetHardwareCursor(this UWorld WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
	{
		return UWidgetLibrary.SetHardwareCursor(WorldContextObject, CursorShape, CursorName, HotSpot);
	}

	public static FEventReply LockMouse(this UWidget CapturingWidget, ref FEventReply Reply)
	{
		return UWidgetLibrary.LockMouse(ref Reply, CapturingWidget);
	}

	public static void GetSafeZonePadding(this UWorld WorldContextObject, out FVector4 SafePadding, out FVector2D SafePaddingScale, out FVector4 SpillOverPadding)
	{
		UWidgetLibrary.GetSafeZonePadding(WorldContextObject, out SafePadding, out SafePaddingScale, out SpillOverPadding);
	}

	public static void GetAllWidgetsWithInterface(this UWorld WorldContextObject, out List<UUserWidget> FoundWidgets, TSubclassOfInterface<IInterface> Interface, bool TopLevelOnly)
	{
		UWidgetLibrary.GetAllWidgetsWithInterface(WorldContextObject, out FoundWidgets, Interface, TopLevelOnly);
	}

	public static void GetAllWidgetsOfClass(this UWorld WorldContextObject, out List<UUserWidget> FoundWidgets, TSubclassOf<UUserWidget> WidgetClass, bool TopLevelOnly = true)
	{
		UWidgetLibrary.GetAllWidgetsOfClass(WorldContextObject, out FoundWidgets, WidgetClass, TopLevelOnly);
	}

	public static FEventReply DetectDragIfPressed(this UWidget WidgetDetectingDrag, FPointerEvent PointerEvent, FKey DragKey)
	{
		return UWidgetLibrary.DetectDragIfPressed(PointerEvent, WidgetDetectingDrag, DragKey);
	}

	public static FEventReply DetectDrag(this UWidget WidgetDetectingDrag, ref FEventReply Reply, FKey DragKey)
	{
		return UWidgetLibrary.DetectDrag(ref Reply, WidgetDetectingDrag, DragKey);
	}

	public static FEventReply CaptureMouse(this UWidget CapturingWidget, ref FEventReply Reply)
	{
		return UWidgetLibrary.CaptureMouse(ref Reply, CapturingWidget);
	}
}
