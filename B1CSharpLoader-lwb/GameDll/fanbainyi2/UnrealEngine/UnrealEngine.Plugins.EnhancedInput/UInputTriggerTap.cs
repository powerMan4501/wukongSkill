using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputTriggerTap", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerTap : UInputTriggerTimedBase
{
	private static bool TapReleaseTimeThreshold_IsValid;

	private static int TapReleaseTimeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerTap:TapReleaseTimeThreshold")]
	public float TapReleaseTimeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!TapReleaseTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTap:TapReleaseTimeThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TapReleaseTimeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TapReleaseTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTap:TapReleaseTimeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TapReleaseTimeThreshold_Offset), value);
			}
		}
	}

	static UInputTriggerTap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerTap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerTap));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerTap");
		TapReleaseTimeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TapReleaseTimeThreshold");
		TapReleaseTimeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TapReleaseTimeThreshold", Classes.FFloatProperty);
	}
}
