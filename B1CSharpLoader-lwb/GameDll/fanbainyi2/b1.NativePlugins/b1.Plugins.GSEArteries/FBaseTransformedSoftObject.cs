using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEArteries.BaseTransformedSoftObject", "GSEArteries", UnrealModuleType.GamePlugin)]
public struct FBaseTransformedSoftObject
{
	private static bool SoftObjectPath_IsValid;

	private static int SoftObjectPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSEArteries.BaseTransformedSoftObject:SoftObjectPath")]
	public FSoftObjectPath SoftObjectPath;

	private static bool BaseTransform_IsValid;

	private static int BaseTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/GSEArteries.BaseTransformedSoftObject:BaseTransform")]
	public FTransform BaseTransform;

	private static bool FBaseTransformedSoftObject_IsValid;

	private static int FBaseTransformedSoftObject_StructSize;

	public FBaseTransformedSoftObject Copy()
	{
		return this;
	}

	public static FBaseTransformedSoftObject FromNative(IntPtr nativeBuffer)
	{
		return new FBaseTransformedSoftObject(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBaseTransformedSoftObject value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBaseTransformedSoftObject FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBaseTransformedSoftObject(nativeBuffer + arrayIndex * FBaseTransformedSoftObject_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBaseTransformedSoftObject value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBaseTransformedSoftObject_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBaseTransformedSoftObject_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.BaseTransformedSoftObject");
			return;
		}
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, SoftObjectPath_Offset), SoftObjectPath);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, BaseTransform_Offset), BaseTransform);
	}

	public FBaseTransformedSoftObject(IntPtr nativeStruct)
	{
		if (!FBaseTransformedSoftObject_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.BaseTransformedSoftObject");
			SoftObjectPath = default(FSoftObjectPath);
			BaseTransform = default(FTransform);
		}
		else
		{
			SoftObjectPath = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, SoftObjectPath_Offset));
			BaseTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, BaseTransform_Offset));
		}
	}

	static FBaseTransformedSoftObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBaseTransformedSoftObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBaseTransformedSoftObject));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEArteries.BaseTransformedSoftObject");
		FBaseTransformedSoftObject_StructSize = NativeReflection.GetStructSize(intPtr);
		SoftObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftObjectPath");
		SoftObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftObjectPath", Classes.FStructProperty);
		BaseTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseTransform");
		BaseTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseTransform", Classes.FStructProperty);
		FBaseTransformedSoftObject_IsValid = intPtr != IntPtr.Zero && SoftObjectPath_IsValid && BaseTransform_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEArteries.BaseTransformedSoftObject", FBaseTransformedSoftObject_IsValid);
	}
}
