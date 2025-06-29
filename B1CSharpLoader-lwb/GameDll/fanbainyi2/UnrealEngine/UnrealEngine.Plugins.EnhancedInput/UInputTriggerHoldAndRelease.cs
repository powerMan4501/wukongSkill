using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputTriggerHoldAndRelease", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerHoldAndRelease : UInputTriggerTimedBase
{
	private static bool HoldTimeThreshold_IsValid;

	private static int HoldTimeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerHoldAndRelease:HoldTimeThreshold")]
	public float HoldTimeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHoldAndRelease:HoldTimeThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHoldAndRelease:HoldTimeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset), value);
			}
		}
	}

	static UInputTriggerHoldAndRelease()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerHoldAndRelease)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerHoldAndRelease));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerHoldAndRelease");
		HoldTimeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoldTimeThreshold");
		HoldTimeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoldTimeThreshold", Classes.FFloatProperty);
	}
}
