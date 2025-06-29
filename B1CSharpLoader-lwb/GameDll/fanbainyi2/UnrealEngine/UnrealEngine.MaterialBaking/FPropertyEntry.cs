using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialBaking;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MaterialBaking.PropertyEntry", "MaterialBaking", UnrealModuleType.Engine)]
public struct FPropertyEntry
{
	private static bool Property_IsValid;

	private static FFieldAddress Property_PropertyAddress;

	private static int Property_Offset;

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.PropertyEntry:Property")]
	public EMaterialProperty Property;

	private static bool UseCustomSize_IsValid;

	private static FFieldAddress UseCustomSize_PropertyAddress;

	private static int UseCustomSize_Offset;

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.PropertyEntry:bUseCustomSize")]
	public bool UseCustomSize;

	private static bool CustomSize_IsValid;

	private static int CustomSize_Offset;

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.PropertyEntry:CustomSize")]
	public FIntPoint CustomSize;

	private static bool UseConstantValue_IsValid;

	private static FFieldAddress UseConstantValue_PropertyAddress;

	private static int UseConstantValue_Offset;

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.PropertyEntry:bUseConstantValue")]
	public bool UseConstantValue;

	private static bool ConstantValue_IsValid;

	private static int ConstantValue_Offset;

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.PropertyEntry:ConstantValue")]
	public float ConstantValue;

	private static bool FPropertyEntry_IsValid;

	private static int FPropertyEntry_StructSize;

	public FPropertyEntry Copy()
	{
		return this;
	}

	public static FPropertyEntry FromNative(IntPtr nativeBuffer)
	{
		return new FPropertyEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPropertyEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPropertyEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPropertyEntry(nativeBuffer + arrayIndex * FPropertyEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPropertyEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPropertyEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPropertyEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MaterialBaking.PropertyEntry");
			return;
		}
		EnumMarshaler<EMaterialProperty>.ToNative(IntPtr.Add(nativeStruct, Property_Offset), 0, Property_PropertyAddress.Address, Property);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCustomSize_Offset), 0, UseCustomSize_PropertyAddress.Address, UseCustomSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, CustomSize_Offset), CustomSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseConstantValue_Offset), 0, UseConstantValue_PropertyAddress.Address, UseConstantValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConstantValue_Offset), ConstantValue);
	}

	public FPropertyEntry(IntPtr nativeStruct)
	{
		if (!FPropertyEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MaterialBaking.PropertyEntry");
			Property = EMaterialProperty.MP_EmissiveColor;
			UseCustomSize = false;
			CustomSize = default(FIntPoint);
			UseConstantValue = false;
			ConstantValue = 0f;
		}
		else
		{
			Property = EnumMarshaler<EMaterialProperty>.FromNative(IntPtr.Add(nativeStruct, Property_Offset), 0, Property_PropertyAddress.Address);
			UseCustomSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCustomSize_Offset), 0, UseCustomSize_PropertyAddress.Address);
			CustomSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, CustomSize_Offset));
			UseConstantValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseConstantValue_Offset), 0, UseConstantValue_PropertyAddress.Address);
			ConstantValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConstantValue_Offset));
		}
	}

	static FPropertyEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPropertyEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPropertyEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MaterialBaking.PropertyEntry");
		FPropertyEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Property_PropertyAddress, intPtr, "Property");
		Property_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Property");
		Property_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Property", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomSize_PropertyAddress, intPtr, "bUseCustomSize");
		UseCustomSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCustomSize");
		UseCustomSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCustomSize", Classes.FBoolProperty);
		CustomSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomSize");
		CustomSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseConstantValue_PropertyAddress, intPtr, "bUseConstantValue");
		UseConstantValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseConstantValue");
		UseConstantValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseConstantValue", Classes.FBoolProperty);
		ConstantValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConstantValue");
		ConstantValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConstantValue", Classes.FFloatProperty);
		FPropertyEntry_IsValid = intPtr != IntPtr.Zero && Property_IsValid && UseCustomSize_IsValid && CustomSize_IsValid && UseConstantValue_IsValid && ConstantValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MaterialBaking.PropertyEntry", FPropertyEntry_IsValid);
	}
}
