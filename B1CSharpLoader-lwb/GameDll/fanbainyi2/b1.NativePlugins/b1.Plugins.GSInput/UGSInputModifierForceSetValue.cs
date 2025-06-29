using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputModifierForceSetValue", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputModifierForceSetValue : UInputModifier
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/GSInput.GSInputModifierForceSetValue:Type")]
	public EInputActionValueType Type
	{
		get
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputModifierForceSetValue:Type");
				return EInputActionValueType.Boolean;
			}
			return EnumMarshaler<EInputActionValueType>.FromNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputModifierForceSetValue:Type");
			}
			else
			{
				EnumMarshaler<EInputActionValueType>.ToNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234293253uL)]
	[UMetaPath("/Script/GSInput.GSInputModifierForceSetValue:Value")]
	public FVector Value
	{
		get
		{
			CheckDestroyed();
			if (!Value_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputModifierForceSetValue:Value");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Value_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Value_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputModifierForceSetValue:Value");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Value_Offset), value);
			}
		}
	}

	static UGSInputModifierForceSetValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputModifierForceSetValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputModifierForceSetValue));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputModifierForceSetValue");
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, unrealStruct, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Type", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Value", Classes.FStructProperty);
	}
}
