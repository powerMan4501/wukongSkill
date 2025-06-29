using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierFOVScaling", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierFOVScaling : UInputModifier
{
	private static bool FOVScale_IsValid;

	private static int FOVScale_Offset;

	private static bool FOVScalingType_IsValid;

	private static FFieldAddress FOVScalingType_PropertyAddress;

	private static int FOVScalingType_Offset;

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierFOVScaling:FOVScale")]
	public float FOVScale
	{
		get
		{
			CheckDestroyed();
			if (!FOVScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierFOVScaling:FOVScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FOVScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FOVScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierFOVScaling:FOVScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FOVScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierFOVScaling:FOVScalingType")]
	public EFOVScalingType FOVScalingType
	{
		get
		{
			CheckDestroyed();
			if (!FOVScalingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierFOVScaling:FOVScalingType");
				return EFOVScalingType.Standard;
			}
			return EnumMarshaler<EFOVScalingType>.FromNative(IntPtr.Add(base.Address, FOVScalingType_Offset), 0, FOVScalingType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FOVScalingType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierFOVScaling:FOVScalingType");
			}
			else
			{
				EnumMarshaler<EFOVScalingType>.ToNative(IntPtr.Add(base.Address, FOVScalingType_Offset), 0, FOVScalingType_PropertyAddress.Address, value);
			}
		}
	}

	static UInputModifierFOVScaling()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierFOVScaling)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierFOVScaling));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierFOVScaling");
		FOVScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FOVScale");
		FOVScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FOVScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FOVScalingType_PropertyAddress, unrealStruct, "FOVScalingType");
		FOVScalingType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FOVScalingType");
		FOVScalingType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FOVScalingType", Classes.FEnumProperty);
	}
}
