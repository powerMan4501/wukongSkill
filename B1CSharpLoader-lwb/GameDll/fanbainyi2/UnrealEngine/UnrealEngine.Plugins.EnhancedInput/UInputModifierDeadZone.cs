using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierDeadZone", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierDeadZone : UInputModifier
{
	private static bool LowerThreshold_IsValid;

	private static int LowerThreshold_Offset;

	private static bool UpperThreshold_IsValid;

	private static int UpperThreshold_Offset;

	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierDeadZone:LowerThreshold")]
	public float LowerThreshold
	{
		get
		{
			CheckDestroyed();
			if (!LowerThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:LowerThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LowerThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowerThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:LowerThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LowerThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierDeadZone:UpperThreshold")]
	public float UpperThreshold
	{
		get
		{
			CheckDestroyed();
			if (!UpperThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:UpperThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpperThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpperThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:UpperThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpperThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierDeadZone:Type")]
	public EDeadZoneType Type
	{
		get
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:Type");
				return EDeadZoneType.Axial;
			}
			return EnumMarshaler<EDeadZoneType>.FromNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierDeadZone:Type");
			}
			else
			{
				EnumMarshaler<EDeadZoneType>.ToNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address, value);
			}
		}
	}

	static UInputModifierDeadZone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierDeadZone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierDeadZone));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierDeadZone");
		LowerThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LowerThreshold");
		LowerThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LowerThreshold", Classes.FFloatProperty);
		UpperThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UpperThreshold");
		UpperThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UpperThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, unrealStruct, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Type", Classes.FEnumProperty);
	}
}
