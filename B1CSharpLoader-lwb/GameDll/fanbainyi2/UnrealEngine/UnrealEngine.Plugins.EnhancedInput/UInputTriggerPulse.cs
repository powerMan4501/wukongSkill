using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputTriggerPulse", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerPulse : UInputTriggerTimedBase
{
	private static bool TriggerOnStart_IsValid;

	private static FFieldAddress TriggerOnStart_PropertyAddress;

	private static int TriggerOnStart_Offset;

	private static bool Interval_IsValid;

	private static int Interval_Offset;

	private static bool TriggerLimit_IsValid;

	private static int TriggerLimit_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerPulse:bTriggerOnStart")]
	public bool TriggerOnStart
	{
		get
		{
			CheckDestroyed();
			if (!TriggerOnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:bTriggerOnStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerOnStart_Offset), 0, TriggerOnStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerOnStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:bTriggerOnStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerOnStart_Offset), 0, TriggerOnStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerPulse:Interval")]
	public float Interval
	{
		get
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:Interval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Interval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:Interval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Interval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerPulse:TriggerLimit")]
	public int TriggerLimit
	{
		get
		{
			CheckDestroyed();
			if (!TriggerLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:TriggerLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TriggerLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerPulse:TriggerLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TriggerLimit_Offset), value);
			}
		}
	}

	static UInputTriggerPulse()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerPulse)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerPulse));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerPulse");
		NativeReflectionCached.GetPropertyRef(ref TriggerOnStart_PropertyAddress, unrealStruct, "bTriggerOnStart");
		TriggerOnStart_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTriggerOnStart");
		TriggerOnStart_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTriggerOnStart", Classes.FBoolProperty);
		Interval_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Interval");
		Interval_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Interval", Classes.FFloatProperty);
		TriggerLimit_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TriggerLimit");
		TriggerLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TriggerLimit", Classes.FIntProperty);
	}
}
