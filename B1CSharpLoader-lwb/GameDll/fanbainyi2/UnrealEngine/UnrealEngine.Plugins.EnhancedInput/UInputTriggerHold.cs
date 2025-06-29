using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputTriggerHold", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerHold : UInputTriggerTimedBase
{
	private static bool HoldTimeThreshold_IsValid;

	private static int HoldTimeThreshold_Offset;

	private static bool IsOneShot_IsValid;

	private static FFieldAddress IsOneShot_PropertyAddress;

	private static int IsOneShot_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerHold:HoldTimeThreshold")]
	public float HoldTimeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHold:HoldTimeThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHold:HoldTimeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerHold:bIsOneShot")]
	public bool IsOneShot
	{
		get
		{
			CheckDestroyed();
			if (!IsOneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHold:bIsOneShot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOneShot_Offset), 0, IsOneShot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOneShot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerHold:bIsOneShot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOneShot_Offset), 0, IsOneShot_PropertyAddress.Address, value);
			}
		}
	}

	static UInputTriggerHold()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerHold)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerHold));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerHold");
		HoldTimeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoldTimeThreshold");
		HoldTimeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoldTimeThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOneShot_PropertyAddress, unrealStruct, "bIsOneShot");
		IsOneShot_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsOneShot");
		IsOneShot_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsOneShot", Classes.FBoolProperty);
	}
}
