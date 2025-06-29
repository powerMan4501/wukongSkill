using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkelMeshMergeMeshUVTransforms", "Engine", UnrealModuleType.Engine)]
public struct FSkelMeshMergeMeshUVTransforms
{
	private static bool UVTransforms_IsValid;

	private static FFieldAddress UVTransforms_PropertyAddress;

	private static int UVTransforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SkelMeshMergeMeshUVTransforms:UVTransforms")]
	public List<FTransform> UVTransforms;

	private static bool FSkelMeshMergeMeshUVTransforms_IsValid;

	private static int FSkelMeshMergeMeshUVTransforms_StructSize;

	public FSkelMeshMergeMeshUVTransforms Copy()
	{
		FSkelMeshMergeMeshUVTransforms result = this;
		if (UVTransforms != null)
		{
			result.UVTransforms = new List<FTransform>(UVTransforms);
		}
		return result;
	}

	public static FSkelMeshMergeMeshUVTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FSkelMeshMergeMeshUVTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkelMeshMergeMeshUVTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkelMeshMergeMeshUVTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkelMeshMergeMeshUVTransforms(nativeBuffer + arrayIndex * FSkelMeshMergeMeshUVTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkelMeshMergeMeshUVTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkelMeshMergeMeshUVTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeMeshUVTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeMeshUVTransforms");
		}
		else
		{
			new TArrayCopyMarshaler<FTransform>(1, UVTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, UVTransforms_Offset), UVTransforms);
		}
	}

	public FSkelMeshMergeMeshUVTransforms(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeMeshUVTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeMeshUVTransforms");
			UVTransforms = null;
		}
		else
		{
			UVTransforms = new TArrayCopyMarshaler<FTransform>(1, UVTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, UVTransforms_Offset));
		}
	}

	static FSkelMeshMergeMeshUVTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkelMeshMergeMeshUVTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkelMeshMergeMeshUVTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkelMeshMergeMeshUVTransforms");
		FSkelMeshMergeMeshUVTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UVTransforms_PropertyAddress, intPtr, "UVTransforms");
		UVTransforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVTransforms");
		UVTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVTransforms", Classes.FArrayProperty);
		FSkelMeshMergeMeshUVTransforms_IsValid = intPtr != IntPtr.Zero && UVTransforms_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SkelMeshMergeMeshUVTransforms", FSkelMeshMergeMeshUVTransforms_IsValid);
	}
}
