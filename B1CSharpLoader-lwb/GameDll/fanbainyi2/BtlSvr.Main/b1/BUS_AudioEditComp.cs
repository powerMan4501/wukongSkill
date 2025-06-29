using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AudioEditComp")]
public class BUS_AudioEditComp : UActorEditCompBase
{
	private static bool LoopEvent_IsValid;

	private static int LoopEvent_Offset;

	private static bool DeadEvent_IsValid;

	private static int DeadEvent_Offset;

	[Category("Audio")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("出生时开始播放的音效")]
	[USharpPath("/Script/b1-Managed.BUS_AudioEditComp:LoopEvent")]
	public UAkEventConfig LoopEvent
	{
		get
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEditComp:LoopEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, LoopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEditComp:LoopEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, LoopEvent_Offset), value);
			}
		}
	}

	[Category("Audio")]
	[Tooltip("死亡时开始播放的音效")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AudioEditComp:DeadEvent")]
	public UAkEventConfig DeadEvent
	{
		get
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEditComp:DeadEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, DeadEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AudioEditComp:DeadEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, DeadEvent_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (!(GetOwner() is BGUCharacterCS))
		{
			BUC_AKMgrData bUC_AKMgrData = RequireWritableData<BUC_AKMgrData>();
			if (bUC_AKMgrData != null)
			{
				bUC_AKMgrData.LoopEvent = LoopEvent;
				bUC_AKMgrData.DeadEvent = DeadEvent;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AudioEditComp");
		LoopEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoopEvent");
		LoopEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoopEvent", Classes.FStructProperty);
		DeadEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DeadEvent");
		DeadEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DeadEvent", Classes.FStructProperty);
	}

	static BUS_AudioEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AudioEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AudioEditComp));
	}
}
