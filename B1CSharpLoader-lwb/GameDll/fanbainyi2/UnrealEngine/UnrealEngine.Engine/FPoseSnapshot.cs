using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.PoseSnapshot", "Engine", UnrealModuleType.Engine)]
public struct FPoseSnapshot
{
	private static bool LocalTransforms_IsValid;

	private static FFieldAddress LocalTransforms_PropertyAddress;

	private static int LocalTransforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.PoseSnapshot:LocalTransforms")]
	public List<FTransform> LocalTransforms;

	private static bool BoneNames_IsValid;

	private static FFieldAddress BoneNames_PropertyAddress;

	private static int BoneNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.PoseSnapshot:BoneNames")]
	public List<FName> BoneNames;

	private static bool SkeletalMeshName_IsValid;

	private static int SkeletalMeshName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PoseSnapshot:SkeletalMeshName")]
	public FName SkeletalMeshName;

	private static bool SnapshotName_IsValid;

	private static int SnapshotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PoseSnapshot:SnapshotName")]
	public FName SnapshotName;

	private static bool IsValid_IsValid;

	private static FFieldAddress IsValid_PropertyAddress;

	private static int IsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PoseSnapshot:bIsValid")]
	public bool IsValid;

	private static bool FPoseSnapshot_IsValid;

	private static int FPoseSnapshot_StructSize;

	public FPoseSnapshot Copy()
	{
		FPoseSnapshot result = this;
		if (LocalTransforms != null)
		{
			result.LocalTransforms = new List<FTransform>(LocalTransforms);
		}
		if (BoneNames != null)
		{
			result.BoneNames = new List<FName>(BoneNames);
		}
		return result;
	}

	public static FPoseSnapshot FromNative(IntPtr nativeBuffer)
	{
		return new FPoseSnapshot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPoseSnapshot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPoseSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPoseSnapshot(nativeBuffer + arrayIndex * FPoseSnapshot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPoseSnapshot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPoseSnapshot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPoseSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseSnapshot");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, LocalTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LocalTransforms_Offset), LocalTransforms);
		new TArrayCopyMarshaler<FName>(1, BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BoneNames_Offset), BoneNames);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SkeletalMeshName_Offset), SkeletalMeshName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SnapshotName_Offset), SnapshotName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address, IsValid);
	}

	public FPoseSnapshot(IntPtr nativeStruct)
	{
		if (!FPoseSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PoseSnapshot");
			LocalTransforms = null;
			BoneNames = null;
			SkeletalMeshName = default(FName);
			SnapshotName = default(FName);
			IsValid = false;
		}
		else
		{
			LocalTransforms = new TArrayCopyMarshaler<FTransform>(1, LocalTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LocalTransforms_Offset));
			BoneNames = new TArrayCopyMarshaler<FName>(1, BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BoneNames_Offset));
			SkeletalMeshName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SkeletalMeshName_Offset));
			SnapshotName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SnapshotName_Offset));
			IsValid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsValid_Offset), 0, IsValid_PropertyAddress.Address);
		}
	}

	static FPoseSnapshot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPoseSnapshot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPoseSnapshot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PoseSnapshot");
		FPoseSnapshot_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref LocalTransforms_PropertyAddress, intPtr, "LocalTransforms");
		LocalTransforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransforms");
		LocalTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransforms", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneNames_PropertyAddress, intPtr, "BoneNames");
		BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneNames");
		BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneNames", Classes.FArrayProperty);
		SkeletalMeshName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkeletalMeshName");
		SkeletalMeshName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkeletalMeshName", Classes.FNameProperty);
		SnapshotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SnapshotName");
		SnapshotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SnapshotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_PropertyAddress, intPtr, "bIsValid");
		IsValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsValid");
		IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsValid", Classes.FBoolProperty);
		FPoseSnapshot_IsValid = intPtr != IntPtr.Zero && LocalTransforms_IsValid && BoneNames_IsValid && SkeletalMeshName_IsValid && SnapshotName_IsValid && IsValid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PoseSnapshot", FPoseSnapshot_IsValid);
	}
}
