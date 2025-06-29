using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputTriggerWiggle", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputTriggerWiggle : UInputTriggerTimedBase
{
	private static bool AreaCount_IsValid;

	private static int AreaCount_Offset;

	private static bool IntervalAreaDistance_IsValid;

	private static int IntervalAreaDistance_Offset;

	private static bool InnerRadius_IsValid;

	private static int InnerRadius_Offset;

	private static bool EffectiveCrossDuration_IsValid;

	private static int EffectiveCrossDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerWiggle:AreaCount")]
	public int AreaCount
	{
		get
		{
			CheckDestroyed();
			if (!AreaCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:AreaCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AreaCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:AreaCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AreaCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerWiggle:IntervalAreaDistance")]
	public int IntervalAreaDistance
	{
		get
		{
			CheckDestroyed();
			if (!IntervalAreaDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:IntervalAreaDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, IntervalAreaDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalAreaDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:IntervalAreaDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, IntervalAreaDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerWiggle:InnerRadius")]
	public float InnerRadius
	{
		get
		{
			CheckDestroyed();
			if (!InnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:InnerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InnerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:InnerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InnerRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerWiggle:EffectiveCrossDuration")]
	public float EffectiveCrossDuration
	{
		get
		{
			CheckDestroyed();
			if (!EffectiveCrossDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:EffectiveCrossDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EffectiveCrossDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectiveCrossDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerWiggle:EffectiveCrossDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EffectiveCrossDuration_Offset), value);
			}
		}
	}

	static UGSInputTriggerWiggle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputTriggerWiggle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputTriggerWiggle));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputTriggerWiggle");
		AreaCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AreaCount");
		AreaCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AreaCount", Classes.FIntProperty);
		IntervalAreaDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IntervalAreaDistance");
		IntervalAreaDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IntervalAreaDistance", Classes.FIntProperty);
		InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InnerRadius");
		InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InnerRadius", Classes.FFloatProperty);
		EffectiveCrossDuration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EffectiveCrossDuration");
		EffectiveCrossDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EffectiveCrossDuration", Classes.FFloatProperty);
	}
}
