using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionSource", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FGeometryCollectionSource
{
	private static bool SourceGeometryObject_IsValid;

	private static int SourceGeometryObject_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionSource:SourceGeometryObject")]
	public FSoftObjectPath SourceGeometryObject;

	private static bool LocalTransform_IsValid;

	private static int LocalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionSource:LocalTransform")]
	public FTransform LocalTransform;

	private static bool SourceMaterial_IsValid;

	private static FFieldAddress SourceMaterial_PropertyAddress;

	private static int SourceMaterial_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionSource:SourceMaterial")]
	public List<UMaterialInterface> SourceMaterial;

	private static bool FGeometryCollectionSource_IsValid;

	private static int FGeometryCollectionSource_StructSize;

	public FGeometryCollectionSource Copy()
	{
		FGeometryCollectionSource result = this;
		if (SourceMaterial != null)
		{
			result.SourceMaterial = new List<UMaterialInterface>(SourceMaterial);
		}
		return result;
	}

	public static FGeometryCollectionSource FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryCollectionSource(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryCollectionSource value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryCollectionSource FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryCollectionSource(nativeBuffer + arrayIndex * FGeometryCollectionSource_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryCollectionSource value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryCollectionSource_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryCollectionSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.GeometryCollectionSource");
			return;
		}
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, SourceGeometryObject_Offset), SourceGeometryObject);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LocalTransform_Offset), LocalTransform);
		new TArrayCopyMarshaler<UMaterialInterface>(1, SourceMaterial_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SourceMaterial_Offset), SourceMaterial);
	}

	public FGeometryCollectionSource(IntPtr nativeStruct)
	{
		if (!FGeometryCollectionSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.GeometryCollectionSource");
			SourceGeometryObject = default(FSoftObjectPath);
			LocalTransform = default(FTransform);
			SourceMaterial = null;
		}
		else
		{
			SourceGeometryObject = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, SourceGeometryObject_Offset));
			LocalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LocalTransform_Offset));
			SourceMaterial = new TArrayCopyMarshaler<UMaterialInterface>(1, SourceMaterial_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SourceMaterial_Offset));
		}
	}

	static FGeometryCollectionSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryCollectionSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryCollectionSource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.GeometryCollectionSource");
		FGeometryCollectionSource_StructSize = NativeReflection.GetStructSize(intPtr);
		SourceGeometryObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceGeometryObject");
		SourceGeometryObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceGeometryObject", Classes.FStructProperty);
		LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransform");
		LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SourceMaterial_PropertyAddress, intPtr, "SourceMaterial");
		SourceMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceMaterial");
		SourceMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceMaterial", Classes.FArrayProperty);
		FGeometryCollectionSource_IsValid = intPtr != IntPtr.Zero && SourceGeometryObject_IsValid && LocalTransform_IsValid && SourceMaterial_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.GeometryCollectionSource", FGeometryCollectionSource_IsValid);
	}
}
