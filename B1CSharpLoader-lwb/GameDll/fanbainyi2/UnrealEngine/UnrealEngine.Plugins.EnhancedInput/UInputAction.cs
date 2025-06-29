using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputAction", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputAction : UDataAsset
{
	private static bool ConsumeInput_IsValid;

	private static FFieldAddress ConsumeInput_PropertyAddress;

	private static int ConsumeInput_Offset;

	private static bool TriggerWhenPaused_IsValid;

	private static FFieldAddress TriggerWhenPaused_PropertyAddress;

	private static int TriggerWhenPaused_Offset;

	private static bool ReserveAllMappings_IsValid;

	private static FFieldAddress ReserveAllMappings_PropertyAddress;

	private static int ReserveAllMappings_Offset;

	private static bool ValueType_IsValid;

	private static FFieldAddress ValueType_PropertyAddress;

	private static int ValueType_Offset;

	private static bool Triggers_IsValid;

	private static FFieldAddress Triggers_PropertyAddress;

	private static int Triggers_Offset;

	private TArrayReadWriteMarshaler<UInputTrigger> Triggers_MarshalerCached;

	private static bool Modifiers_IsValid;

	private static FFieldAddress Modifiers_PropertyAddress;

	private static int Modifiers_Offset;

	private TArrayReadWriteMarshaler<UInputModifier> Modifiers_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:bConsumeInput")]
	public bool ConsumeInput
	{
		get
		{
			CheckDestroyed();
			if (!ConsumeInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bConsumeInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConsumeInput_Offset), 0, ConsumeInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsumeInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bConsumeInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConsumeInput_Offset), 0, ConsumeInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:bTriggerWhenPaused")]
	public bool TriggerWhenPaused
	{
		get
		{
			CheckDestroyed();
			if (!TriggerWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bTriggerWhenPaused");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerWhenPaused_Offset), 0, TriggerWhenPaused_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bTriggerWhenPaused");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerWhenPaused_Offset), 0, TriggerWhenPaused_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:bReserveAllMappings")]
	public bool ReserveAllMappings
	{
		get
		{
			CheckDestroyed();
			if (!ReserveAllMappings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bReserveAllMappings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReserveAllMappings_Offset), 0, ReserveAllMappings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReserveAllMappings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:bReserveAllMappings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReserveAllMappings_Offset), 0, ReserveAllMappings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:ValueType")]
	public EInputActionValueType ValueType
	{
		get
		{
			CheckDestroyed();
			if (!ValueType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:ValueType");
				return EInputActionValueType.Boolean;
			}
			return EnumMarshaler<EInputActionValueType>.FromNative(IntPtr.Add(base.Address, ValueType_Offset), 0, ValueType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ValueType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:ValueType");
			}
			else
			{
				EnumMarshaler<EInputActionValueType>.ToNative(IntPtr.Add(base.Address, ValueType_Offset), 0, ValueType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184909uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:Triggers")]
	public TArrayReadWrite<UInputTrigger> Triggers
	{
		get
		{
			CheckDestroyed();
			if (!Triggers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:Triggers");
				return null;
			}
			if (Triggers_MarshalerCached == null)
			{
				Triggers_MarshalerCached = new TArrayReadWriteMarshaler<UInputTrigger>(1, Triggers_PropertyAddress, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.FromNative, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.ToNative);
			}
			return Triggers_MarshalerCached.FromNative(IntPtr.Add(base.Address, Triggers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184909uL)]
	[UMetaPath("/Script/EnhancedInput.InputAction:Modifiers")]
	public TArrayReadWrite<UInputModifier> Modifiers
	{
		get
		{
			CheckDestroyed();
			if (!Modifiers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputAction:Modifiers");
				return null;
			}
			if (Modifiers_MarshalerCached == null)
			{
				Modifiers_MarshalerCached = new TArrayReadWriteMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative);
			}
			return Modifiers_MarshalerCached.FromNative(IntPtr.Add(base.Address, Modifiers_Offset));
		}
	}

	static UInputAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputAction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputAction");
		NativeReflectionCached.GetPropertyRef(ref ConsumeInput_PropertyAddress, unrealStruct, "bConsumeInput");
		ConsumeInput_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bConsumeInput");
		ConsumeInput_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bConsumeInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerWhenPaused_PropertyAddress, unrealStruct, "bTriggerWhenPaused");
		TriggerWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bTriggerWhenPaused");
		TriggerWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bTriggerWhenPaused", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReserveAllMappings_PropertyAddress, unrealStruct, "bReserveAllMappings");
		ReserveAllMappings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReserveAllMappings");
		ReserveAllMappings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReserveAllMappings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ValueType_PropertyAddress, unrealStruct, "ValueType");
		ValueType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ValueType");
		ValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Triggers_PropertyAddress, unrealStruct, "Triggers");
		Triggers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Triggers");
		Triggers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Triggers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Modifiers_PropertyAddress, unrealStruct, "Modifiers");
		Modifiers_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Modifiers");
		Modifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Modifiers", Classes.FArrayProperty);
	}
}
