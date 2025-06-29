using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputTriggerChordHold", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputTriggerChordHold : UInputTrigger
{
	private static bool HoldTimeThreshold_IsValid;

	private static int HoldTimeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerChordHold:HoldTimeThreshold")]
	public float HoldTimeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordHold:HoldTimeThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordHold:HoldTimeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset), value);
			}
		}
	}

	static UGSInputTriggerChordHold()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputTriggerChordHold)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputTriggerChordHold));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputTriggerChordHold");
		HoldTimeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoldTimeThreshold");
		HoldTimeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoldTimeThreshold", Classes.FFloatProperty);
	}
}
