using System;
using System.Collections.Generic;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FEnhancedActionKeyMapping
{
	private static bool Action_IsValid;

	private static int Action_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:Action")]
	public UInputAction Action;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755399441055765uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:Key")]
	public FKey Key;

	private static bool IsPlayerMappable_IsValid;

	private static FFieldAddress IsPlayerMappable_PropertyAddress;

	private static int IsPlayerMappable_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:bIsPlayerMappable")]
	public bool IsPlayerMappable;

	private static bool PlayerMappableOptions_IsValid;

	private static int PlayerMappableOptions_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:PlayerMappableOptions")]
	public FPlayerMappableKeyOptions PlayerMappableOptions;

	private static bool Triggers_IsValid;

	private static FFieldAddress Triggers_PropertyAddress;

	private static int Triggers_Offset;

	[UProperty(Flags = (PropFlags)5630049290027533uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:Triggers")]
	public List<UInputTrigger> Triggers;

	private static bool Modifiers_IsValid;

	private static FFieldAddress Modifiers_PropertyAddress;

	private static int Modifiers_Offset;

	[UProperty(Flags = (PropFlags)5630049290027533uL)]
	[UMetaPath("/Script/EnhancedInput.EnhancedActionKeyMapping:Modifiers")]
	public List<UInputModifier> Modifiers;

	private static bool FEnhancedActionKeyMapping_IsValid;

	private static int FEnhancedActionKeyMapping_StructSize;

	public FEnhancedActionKeyMapping Copy()
	{
		FEnhancedActionKeyMapping result = this;
		if (Triggers != null)
		{
			result.Triggers = new List<UInputTrigger>(Triggers);
		}
		if (Modifiers != null)
		{
			result.Modifiers = new List<UInputModifier>(Modifiers);
		}
		return result;
	}

	public static FEnhancedActionKeyMapping FromNative(IntPtr nativeBuffer)
	{
		return new FEnhancedActionKeyMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEnhancedActionKeyMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEnhancedActionKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEnhancedActionKeyMapping(nativeBuffer + arrayIndex * FEnhancedActionKeyMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEnhancedActionKeyMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEnhancedActionKeyMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEnhancedActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.EnhancedActionKeyMapping");
			return;
		}
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(nativeStruct, Action_Offset), Action);
		FKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPlayerMappable_Offset), 0, IsPlayerMappable_PropertyAddress.Address, IsPlayerMappable);
		FPlayerMappableKeyOptions.ToNative(IntPtr.Add(nativeStruct, PlayerMappableOptions_Offset), PlayerMappableOptions);
		new TArrayCopyMarshaler<UInputTrigger>(1, Triggers_PropertyAddress, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.FromNative, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Triggers_Offset), Triggers);
		new TArrayCopyMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Modifiers_Offset), Modifiers);
	}

	public FEnhancedActionKeyMapping(IntPtr nativeStruct)
	{
		if (!FEnhancedActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.EnhancedActionKeyMapping");
			Action = null;
			Key = default(FKey);
			IsPlayerMappable = false;
			PlayerMappableOptions = default(FPlayerMappableKeyOptions);
			Triggers = null;
			Modifiers = null;
		}
		else
		{
			Action = UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(nativeStruct, Action_Offset));
			Key = FKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			IsPlayerMappable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPlayerMappable_Offset), 0, IsPlayerMappable_PropertyAddress.Address);
			PlayerMappableOptions = FPlayerMappableKeyOptions.FromNative(IntPtr.Add(nativeStruct, PlayerMappableOptions_Offset));
			Triggers = new TArrayCopyMarshaler<UInputTrigger>(1, Triggers_PropertyAddress, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.FromNative, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Triggers_Offset));
			Modifiers = new TArrayCopyMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Modifiers_Offset));
		}
	}

	static FEnhancedActionKeyMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEnhancedActionKeyMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnhancedActionKeyMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.EnhancedActionKeyMapping");
		FEnhancedActionKeyMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		Action_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Action");
		Action_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Action", Classes.FObjectProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlayerMappable_PropertyAddress, intPtr, "bIsPlayerMappable");
		IsPlayerMappable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPlayerMappable");
		IsPlayerMappable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPlayerMappable", Classes.FBoolProperty);
		PlayerMappableOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerMappableOptions");
		PlayerMappableOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerMappableOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Triggers_PropertyAddress, intPtr, "Triggers");
		Triggers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Triggers");
		Triggers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Triggers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Modifiers_PropertyAddress, intPtr, "Modifiers");
		Modifiers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Modifiers");
		Modifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Modifiers", Classes.FArrayProperty);
		FEnhancedActionKeyMapping_IsValid = intPtr != IntPtr.Zero && Action_IsValid && Key_IsValid && IsPlayerMappable_IsValid && PlayerMappableOptions_IsValid && Triggers_IsValid && Modifiers_IsValid;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.EnhancedActionKeyMapping", FEnhancedActionKeyMapping_IsValid);
	}
}
