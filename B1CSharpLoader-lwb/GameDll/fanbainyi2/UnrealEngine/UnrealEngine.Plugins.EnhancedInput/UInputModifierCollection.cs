using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779234uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputModifierCollection", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputModifierCollection : UInputModifier
{
	private static bool Modifiers_IsValid;

	private static FFieldAddress Modifiers_PropertyAddress;

	private static int Modifiers_Offset;

	private TArrayReadWriteMarshaler<UInputModifier> Modifiers_MarshalerCached;

	private static bool PermitValueTypeModification_IsValid;

	private static FFieldAddress PermitValueTypeModification_PropertyAddress;

	private static int PermitValueTypeModification_Offset;

	[UProperty(Flags = (PropFlags)4503599627373061uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierCollection:Modifiers")]
	public TArrayReadWrite<UInputModifier> Modifiers
	{
		get
		{
			CheckDestroyed();
			if (!Modifiers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierCollection:Modifiers");
				return null;
			}
			if (Modifiers_MarshalerCached == null)
			{
				Modifiers_MarshalerCached = new TArrayReadWriteMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative);
			}
			return Modifiers_MarshalerCached.FromNative(IntPtr.Add(base.Address, Modifiers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EnhancedInput.InputModifierCollection:bPermitValueTypeModification")]
	public bool PermitValueTypeModification
	{
		get
		{
			CheckDestroyed();
			if (!PermitValueTypeModification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierCollection:bPermitValueTypeModification");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PermitValueTypeModification_Offset), 0, PermitValueTypeModification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PermitValueTypeModification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputModifierCollection:bPermitValueTypeModification");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PermitValueTypeModification_Offset), 0, PermitValueTypeModification_PropertyAddress.Address, value);
			}
		}
	}

	static UInputModifierCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputModifierCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputModifierCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputModifierCollection");
		NativeReflectionCached.GetPropertyRef(ref Modifiers_PropertyAddress, unrealStruct, "Modifiers");
		Modifiers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Modifiers");
		Modifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Modifiers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PermitValueTypeModification_PropertyAddress, unrealStruct, "bPermitValueTypeModification");
		PermitValueTypeModification_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPermitValueTypeModification");
		PermitValueTypeModification_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPermitValueTypeModification", Classes.FBoolProperty);
	}
}
