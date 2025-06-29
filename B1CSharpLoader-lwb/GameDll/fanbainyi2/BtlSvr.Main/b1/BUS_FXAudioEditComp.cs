using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXAudioEditComp")]
public class BUS_FXAudioEditComp : UActorEditCompBase
{
	private static bool LoopEvent_IsValid;

	private static int LoopEvent_Offset;

	private static bool DestructibleEvent_IsValid;

	private static int DestructibleEvent_Offset;

	[Category("Audio")]
	[Tooltip("出生时开始播放的音效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_FXAudioEditComp:LoopEvent")]
	public UAkEventConfig LoopEvent
	{
		get
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAudioEditComp:LoopEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, LoopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAudioEditComp:LoopEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, LoopEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Audio")]
	[Tooltip("破碎时开始播放的音效")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FXAudioEditComp:DestructibleEvent")]
	public UAkEventConfig DestructibleEvent
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAudioEditComp:DestructibleEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, DestructibleEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAudioEditComp:DestructibleEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, DestructibleEvent_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_FXActorAudioData bUC_FXActorAudioData = RequireWritableData<BUC_FXActorAudioData>();
		bUC_FXActorAudioData.LoopEvent = LoopEvent;
		bUC_FXActorAudioData.DestructibleEvent = DestructibleEvent;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXAudioEditComp");
		LoopEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoopEvent");
		LoopEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoopEvent", Classes.FStructProperty);
		DestructibleEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleEvent");
		DestructibleEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleEvent", Classes.FStructProperty);
	}

	static BUS_FXAudioEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXAudioEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXAudioEditComp));
	}
}
