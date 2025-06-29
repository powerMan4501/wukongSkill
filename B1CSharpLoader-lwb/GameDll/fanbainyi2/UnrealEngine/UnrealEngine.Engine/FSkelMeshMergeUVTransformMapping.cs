using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkelMeshMergeUVTransformMapping", "Engine", UnrealModuleType.Engine)]
public struct FSkelMeshMergeUVTransformMapping
{
	private static bool UVTransformsPerMesh_IsValid;

	private static FFieldAddress UVTransformsPerMesh_PropertyAddress;

	private static int UVTransformsPerMesh_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SkelMeshMergeUVTransformMapping:UVTransformsPerMesh")]
	public List<FSkelMeshMergeMeshUVTransforms> UVTransformsPerMesh;

	private static bool FSkelMeshMergeUVTransformMapping_IsValid;

	private static int FSkelMeshMergeUVTransformMapping_StructSize;

	public FSkelMeshMergeUVTransformMapping Copy()
	{
		FSkelMeshMergeUVTransformMapping result = this;
		if (UVTransformsPerMesh != null)
		{
			result.UVTransformsPerMesh = new List<FSkelMeshMergeMeshUVTransforms>(UVTransformsPerMesh);
		}
		return result;
	}

	public static FSkelMeshMergeUVTransformMapping FromNative(IntPtr nativeBuffer)
	{
		return new FSkelMeshMergeUVTransformMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkelMeshMergeUVTransformMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkelMeshMergeUVTransformMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkelMeshMergeUVTransformMapping(nativeBuffer + arrayIndex * FSkelMeshMergeUVTransformMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkelMeshMergeUVTransformMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkelMeshMergeUVTransformMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeUVTransformMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeUVTransformMapping");
		}
		else
		{
			new TArrayCopyMarshaler<FSkelMeshMergeMeshUVTransforms>(1, UVTransformsPerMesh_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.ToNative).ToNative(IntPtr.Add(nativeStruct, UVTransformsPerMesh_Offset), UVTransformsPerMesh);
		}
	}

	public FSkelMeshMergeUVTransformMapping(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeUVTransformMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeUVTransformMapping");
			UVTransformsPerMesh = null;
		}
		else
		{
			UVTransformsPerMesh = new TArrayCopyMarshaler<FSkelMeshMergeMeshUVTransforms>(1, UVTransformsPerMesh_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.ToNative).FromNative(IntPtr.Add(nativeStruct, UVTransformsPerMesh_Offset));
		}
	}

	static FSkelMeshMergeUVTransformMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkelMeshMergeUVTransformMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkelMeshMergeUVTransformMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkelMeshMergeUVTransformMapping");
		FSkelMeshMergeUVTransformMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UVTransformsPerMesh_PropertyAddress, intPtr, "UVTransformsPerMesh");
		UVTransformsPerMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVTransformsPerMesh");
		UVTransformsPerMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVTransformsPerMesh", Classes.FArrayProperty);
		FSkelMeshMergeUVTransformMapping_IsValid = intPtr != IntPtr.Zero && UVTransformsPerMesh_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SkelMeshMergeUVTransformMapping", FSkelMeshMergeUVTransformMapping_IsValid);
	}
}
