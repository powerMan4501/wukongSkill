using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AssetRegistry.TagAndValue", "AssetRegistry", UnrealModuleType.Engine)]
public struct FTagAndValue
{
	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/AssetRegistry.TagAndValue:Tag")]
	public FName Tag;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755399441064452uL)]
	[UMetaPath("/Script/AssetRegistry.TagAndValue:Value")]
	public string Value;

	private static bool FTagAndValue_IsValid;

	private static int FTagAndValue_StructSize;

	public FTagAndValue Copy()
	{
		return this;
	}

	public static FTagAndValue FromNative(IntPtr nativeBuffer)
	{
		return new FTagAndValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTagAndValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTagAndValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTagAndValue(nativeBuffer + arrayIndex * FTagAndValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTagAndValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTagAndValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTagAndValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetRegistry.TagAndValue");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FTagAndValue(IntPtr nativeStruct)
	{
		if (!FTagAndValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AssetRegistry.TagAndValue");
			Tag = default(FName);
			Value = FStringMarshaler.DefaultString;
		}
		else
		{
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
			Value = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FTagAndValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTagAndValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTagAndValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AssetRegistry.TagAndValue");
		FTagAndValue_StructSize = NativeReflection.GetStructSize(intPtr);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStrProperty);
		FTagAndValue_IsValid = intPtr != IntPtr.Zero && Tag_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/AssetRegistry.TagAndValue", FTagAndValue_IsValid);
	}
}
