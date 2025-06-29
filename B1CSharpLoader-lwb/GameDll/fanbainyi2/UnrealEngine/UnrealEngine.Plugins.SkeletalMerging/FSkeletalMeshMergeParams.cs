using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SkeletalMerging;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams", "SkeletalMerging", UnrealModuleType.EnginePlugin)]
public struct FSkeletalMeshMergeParams
{
	private static bool MeshSectionMappings_IsValid;

	private static FFieldAddress MeshSectionMappings_PropertyAddress;

	private static int MeshSectionMappings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:MeshSectionMappings")]
	public List<FSkelMeshMergeSectionMapping> MeshSectionMappings;

	private static bool UVTransformsPerMesh_IsValid;

	private static FFieldAddress UVTransformsPerMesh_PropertyAddress;

	private static int UVTransformsPerMesh_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:UVTransformsPerMesh")]
	public List<FSkelMeshMergeMeshUVTransforms> UVTransformsPerMesh;

	private static bool MeshesToMerge_IsValid;

	private static FFieldAddress MeshesToMerge_PropertyAddress;

	private static int MeshesToMerge_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:MeshesToMerge")]
	public List<USkeletalMesh> MeshesToMerge;

	private static bool StripTopLODS_IsValid;

	private static int StripTopLODS_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:StripTopLODS")]
	public int StripTopLODS;

	private static bool NeedsCpuAccess_IsValid;

	private static FFieldAddress NeedsCpuAccess_PropertyAddress;

	private static int NeedsCpuAccess_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:bNeedsCpuAccess")]
	public bool NeedsCpuAccess;

	private static bool SkeletonBefore_IsValid;

	private static FFieldAddress SkeletonBefore_PropertyAddress;

	private static int SkeletonBefore_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:bSkeletonBefore")]
	public bool SkeletonBefore;

	private static bool Skeleton_IsValid;

	private static int Skeleton_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMeshMergeParams:Skeleton")]
	public USkeleton Skeleton;

	private static bool FSkeletalMeshMergeParams_IsValid;

	private static int FSkeletalMeshMergeParams_StructSize;

	public FSkeletalMeshMergeParams Copy()
	{
		FSkeletalMeshMergeParams result = this;
		if (MeshSectionMappings != null)
		{
			result.MeshSectionMappings = new List<FSkelMeshMergeSectionMapping>(MeshSectionMappings);
		}
		if (UVTransformsPerMesh != null)
		{
			result.UVTransformsPerMesh = new List<FSkelMeshMergeMeshUVTransforms>(UVTransformsPerMesh);
		}
		if (MeshesToMerge != null)
		{
			result.MeshesToMerge = new List<USkeletalMesh>(MeshesToMerge);
		}
		return result;
	}

	public static FSkeletalMeshMergeParams FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletalMeshMergeParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletalMeshMergeParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletalMeshMergeParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletalMeshMergeParams(nativeBuffer + arrayIndex * FSkeletalMeshMergeParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletalMeshMergeParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletalMeshMergeParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletalMeshMergeParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SkeletalMerging.SkeletalMeshMergeParams");
			return;
		}
		new TArrayCopyMarshaler<FSkelMeshMergeSectionMapping>(1, MeshSectionMappings_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeSectionMapping, FSkelMeshMergeSectionMapping>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeSectionMapping, FSkelMeshMergeSectionMapping>.ToNative).ToNative(IntPtr.Add(nativeStruct, MeshSectionMappings_Offset), MeshSectionMappings);
		new TArrayCopyMarshaler<FSkelMeshMergeMeshUVTransforms>(1, UVTransformsPerMesh_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.ToNative).ToNative(IntPtr.Add(nativeStruct, UVTransformsPerMesh_Offset), UVTransformsPerMesh);
		new TArrayCopyMarshaler<USkeletalMesh>(1, MeshesToMerge_PropertyAddress, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.FromNative, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MeshesToMerge_Offset), MeshesToMerge);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StripTopLODS_Offset), StripTopLODS);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedsCpuAccess_Offset), 0, NeedsCpuAccess_PropertyAddress.Address, NeedsCpuAccess);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkeletonBefore_Offset), 0, SkeletonBefore_PropertyAddress.Address, SkeletonBefore);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(nativeStruct, Skeleton_Offset), Skeleton);
	}

	public FSkeletalMeshMergeParams(IntPtr nativeStruct)
	{
		if (!FSkeletalMeshMergeParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SkeletalMerging.SkeletalMeshMergeParams");
			MeshSectionMappings = null;
			UVTransformsPerMesh = null;
			MeshesToMerge = null;
			StripTopLODS = 0;
			NeedsCpuAccess = false;
			SkeletonBefore = false;
			Skeleton = null;
		}
		else
		{
			MeshSectionMappings = new TArrayCopyMarshaler<FSkelMeshMergeSectionMapping>(1, MeshSectionMappings_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeSectionMapping, FSkelMeshMergeSectionMapping>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeSectionMapping, FSkelMeshMergeSectionMapping>.ToNative).FromNative(IntPtr.Add(nativeStruct, MeshSectionMappings_Offset));
			UVTransformsPerMesh = new TArrayCopyMarshaler<FSkelMeshMergeMeshUVTransforms>(1, UVTransformsPerMesh_PropertyAddress, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.FromNative, CachedMarshalingDelegates<FSkelMeshMergeMeshUVTransforms, FSkelMeshMergeMeshUVTransforms>.ToNative).FromNative(IntPtr.Add(nativeStruct, UVTransformsPerMesh_Offset));
			MeshesToMerge = new TArrayCopyMarshaler<USkeletalMesh>(1, MeshesToMerge_PropertyAddress, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.FromNative, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MeshesToMerge_Offset));
			StripTopLODS = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StripTopLODS_Offset));
			NeedsCpuAccess = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedsCpuAccess_Offset), 0, NeedsCpuAccess_PropertyAddress.Address);
			SkeletonBefore = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkeletonBefore_Offset), 0, SkeletonBefore_PropertyAddress.Address);
			Skeleton = UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(nativeStruct, Skeleton_Offset));
		}
	}

	static FSkeletalMeshMergeParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletalMeshMergeParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletalMeshMergeParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SkeletalMerging.SkeletalMeshMergeParams");
		FSkeletalMeshMergeParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MeshSectionMappings_PropertyAddress, intPtr, "MeshSectionMappings");
		MeshSectionMappings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshSectionMappings");
		MeshSectionMappings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshSectionMappings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UVTransformsPerMesh_PropertyAddress, intPtr, "UVTransformsPerMesh");
		UVTransformsPerMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVTransformsPerMesh");
		UVTransformsPerMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVTransformsPerMesh", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshesToMerge_PropertyAddress, intPtr, "MeshesToMerge");
		MeshesToMerge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshesToMerge");
		MeshesToMerge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshesToMerge", Classes.FArrayProperty);
		StripTopLODS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StripTopLODS");
		StripTopLODS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StripTopLODS", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedsCpuAccess_PropertyAddress, intPtr, "bNeedsCpuAccess");
		NeedsCpuAccess_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNeedsCpuAccess");
		NeedsCpuAccess_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNeedsCpuAccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletonBefore_PropertyAddress, intPtr, "bSkeletonBefore");
		SkeletonBefore_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkeletonBefore");
		SkeletonBefore_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkeletonBefore", Classes.FBoolProperty);
		Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Skeleton");
		Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Skeleton", Classes.FObjectProperty);
		FSkeletalMeshMergeParams_IsValid = intPtr != IntPtr.Zero && MeshSectionMappings_IsValid && UVTransformsPerMesh_IsValid && MeshesToMerge_IsValid && StripTopLODS_IsValid && NeedsCpuAccess_IsValid && SkeletonBefore_IsValid && Skeleton_IsValid;
		NativeReflection.LogStructIsValid("/Script/SkeletalMerging.SkeletalMeshMergeParams", FSkeletalMeshMergeParams_IsValid);
	}
}
