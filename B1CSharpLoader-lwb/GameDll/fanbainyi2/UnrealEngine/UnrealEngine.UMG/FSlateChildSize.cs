using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.SlateChildSize", "UMG", UnrealModuleType.Engine)]
public struct FSlateChildSize
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.SlateChildSize:Value")]
	public float Value;

	private static bool SizeRule_IsValid;

	private static FFieldAddress SizeRule_PropertyAddress;

	private static int SizeRule_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMG.SlateChildSize:SizeRule")]
	public ESlateSizeRule SizeRule;

	private static bool FSlateChildSize_IsValid;

	private static int FSlateChildSize_StructSize;

	public FSlateChildSize Copy()
	{
		return this;
	}

	public static FSlateChildSize FromNative(IntPtr nativeBuffer)
	{
		return new FSlateChildSize(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateChildSize value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateChildSize FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateChildSize(nativeBuffer + arrayIndex * FSlateChildSize_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateChildSize value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateChildSize_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateChildSize_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.SlateChildSize");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<ESlateSizeRule>.ToNative(IntPtr.Add(nativeStruct, SizeRule_Offset), 0, SizeRule_PropertyAddress.Address, SizeRule);
	}

	public FSlateChildSize(IntPtr nativeStruct)
	{
		if (!FSlateChildSize_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.SlateChildSize");
			Value = 0f;
			SizeRule = ESlateSizeRule.Automatic;
		}
		else
		{
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			SizeRule = EnumMarshaler<ESlateSizeRule>.FromNative(IntPtr.Add(nativeStruct, SizeRule_Offset), 0, SizeRule_PropertyAddress.Address);
		}
	}

	static FSlateChildSize()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateChildSize)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateChildSize));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.SlateChildSize");
		FSlateChildSize_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SizeRule_PropertyAddress, intPtr, "SizeRule");
		SizeRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SizeRule");
		SizeRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SizeRule", Classes.FByteProperty);
		FSlateChildSize_IsValid = intPtr != IntPtr.Zero && Value_IsValid && SizeRule_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMG.SlateChildSize", FSlateChildSize_IsValid);
	}
}
