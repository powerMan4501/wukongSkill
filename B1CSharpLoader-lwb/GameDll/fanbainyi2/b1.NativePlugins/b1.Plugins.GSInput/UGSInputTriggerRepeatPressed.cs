using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputTriggerRepeatPressed", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputTriggerRepeatPressed : UInputTrigger
{
	private static bool Interval_IsValid;

	private static int Interval_Offset;

	private static bool RepeatedPressedTriggerCount_IsValid;

	private static int RepeatedPressedTriggerCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerRepeatPressed:Interval")]
	public float Interval
	{
		get
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerRepeatPressed:Interval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Interval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerRepeatPressed:Interval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Interval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerRepeatPressed:RepeatedPressedTriggerCount")]
	public int RepeatedPressedTriggerCount
	{
		get
		{
			CheckDestroyed();
			if (!RepeatedPressedTriggerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerRepeatPressed:RepeatedPressedTriggerCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RepeatedPressedTriggerCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RepeatedPressedTriggerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerRepeatPressed:RepeatedPressedTriggerCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RepeatedPressedTriggerCount_Offset), value);
			}
		}
	}

	static UGSInputTriggerRepeatPressed()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputTriggerRepeatPressed)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputTriggerRepeatPressed));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputTriggerRepeatPressed");
		Interval_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Interval");
		Interval_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Interval", Classes.FFloatProperty);
		RepeatedPressedTriggerCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RepeatedPressedTriggerCount");
		RepeatedPressedTriggerCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RepeatedPressedTriggerCount", Classes.FIntProperty);
	}
}
