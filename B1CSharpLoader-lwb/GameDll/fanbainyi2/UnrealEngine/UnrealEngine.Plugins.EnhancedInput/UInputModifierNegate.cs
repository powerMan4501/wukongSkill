using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779234uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierNegate", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierNegate : UInputModifier
{
	private static bool X_IsValid;

	private static FFieldAddress X_PropertyAddress;

	private static int X_Offset;

	private static bool Y_IsValid;

	private static FFieldAddress Y_PropertyAddress;

	private static int Y_Offset;

	private static bool Z_IsValid;

	private static FFieldAddress Z_PropertyAddress;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierNegate:bX")]
	public bool X
	{
		get
		{
			CheckDestroyed();
			if (!X_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, X_Offset), 0, X_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!X_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, X_Offset), 0, X_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierNegate:bY")]
	public bool Y
	{
		get
		{
			CheckDestroyed();
			if (!Y_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bY");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Y_Offset), 0, Y_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Y_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bY");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Y_Offset), 0, Y_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierNegate:bZ")]
	public bool Z
	{
		get
		{
			CheckDestroyed();
			if (!Z_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bZ");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Z_Offset), 0, Z_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Z_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierNegate:bZ");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Z_Offset), 0, Z_PropertyAddress.Address, value);
			}
		}
	}

	static UInputModifierNegate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierNegate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierNegate));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierNegate");
		NativeReflectionCached.GetPropertyRef(ref X_PropertyAddress, unrealStruct, "bX");
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Y_PropertyAddress, unrealStruct, "bY");
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Z_PropertyAddress, unrealStruct, "bZ");
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bZ");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bZ", Classes.FBoolProperty);
	}
}
