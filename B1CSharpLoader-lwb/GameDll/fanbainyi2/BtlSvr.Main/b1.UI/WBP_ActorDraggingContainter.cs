using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WBP_ActorDraggingContainter")]
public class WBP_ActorDraggingContainter : BUI_Widget
{
	public WBP_ActorDraggingController draggingArea;

	private static bool draggableActor_IsValid;

	private static int draggableActor_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[ExposeOnSpawn]
	[USharpPath("/Script/b1-Managed.WBP_ActorDraggingContainter:draggableActor")]
	public AActor draggableActor
	{
		get
		{
			CheckDestroyed();
			if (!draggableActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingContainter:draggableActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, draggableActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!draggableActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.WBP_ActorDraggingContainter:draggableActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, draggableActor_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		UGSE_EngineFuncLib.LogInfo("WBP_ActorDraggingContainter: OnUIInitialized");
		base.OnUIConstruct();
		draggingArea = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.DraggingArea) as WBP_ActorDraggingController;
		if (draggingArea != null)
		{
			if (draggableActor != null)
			{
				draggingArea.draggableActor = draggableActor;
			}
			else
			{
				UGSE_EngineFuncLib.LogInfo("WBP_ActorDraggingContainter's DraggableActor is null");
			}
		}
		else
		{
			UGSE_EngineFuncLib.LogInfo("WBP_ActorDraggingContainter: DraggingArea is null");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.WBP_ActorDraggingContainter");
		draggableActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "draggableActor");
		draggableActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "draggableActor", Classes.FObjectProperty);
	}

	static WBP_ActorDraggingContainter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(WBP_ActorDraggingContainter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(WBP_ActorDraggingContainter));
	}
}
