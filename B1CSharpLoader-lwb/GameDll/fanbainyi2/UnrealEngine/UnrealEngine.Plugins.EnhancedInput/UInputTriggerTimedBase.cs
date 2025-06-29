using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[Abstract]
[UClass(Flags = (ClassFlags)1884303527uL, Config = "Input")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/EnhancedInput.InputTriggerTimedBase", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerTimedBase : UInputTrigger
{
	private static bool HeldDuration_IsValid;

	private static int HeldDuration_Offset;

	private static bool AffectedByTimeDilation_IsValid;

	private static FFieldAddress AffectedByTimeDilation_PropertyAddress;

	private static int AffectedByTimeDilation_Offset;

	[UProperty(Flags = (PropFlags)11267864954667524uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerTimedBase:HeldDuration")]
	protected float HeldDuration
	{
		get
		{
			CheckDestroyed();
			if (!HeldDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTimedBase:HeldDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeldDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeldDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTimedBase:HeldDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeldDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerTimedBase:bAffectedByTimeDilation")]
	public bool AffectedByTimeDilation
	{
		get
		{
			CheckDestroyed();
			if (!AffectedByTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTimedBase:bAffectedByTimeDilation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectedByTimeDilation_Offset), 0, AffectedByTimeDilation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectedByTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerTimedBase:bAffectedByTimeDilation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectedByTimeDilation_Offset), 0, AffectedByTimeDilation_PropertyAddress.Address, value);
			}
		}
	}

	static UInputTriggerTimedBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerTimedBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerTimedBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerTimedBase");
		HeldDuration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HeldDuration");
		HeldDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HeldDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectedByTimeDilation_PropertyAddress, unrealStruct, "bAffectedByTimeDilation");
		AffectedByTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAffectedByTimeDilation");
		AffectedByTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAffectedByTimeDilation", Classes.FBoolProperty);
	}
}
