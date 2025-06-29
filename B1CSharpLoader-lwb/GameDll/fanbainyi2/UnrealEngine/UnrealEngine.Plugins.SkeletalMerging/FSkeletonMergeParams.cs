using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SkeletalMerging;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams", "SkeletalMerging", UnrealModuleType.EnginePlugin)]
public struct FSkeletonMergeParams
{
	private static bool SkeletonsToMerge_IsValid;

	private static FFieldAddress SkeletonsToMerge_PropertyAddress;

	private static int SkeletonsToMerge_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:SkeletonsToMerge")]
	public List<USkeleton> SkeletonsToMerge;

	private static bool MergeSockets_IsValid;

	private static FFieldAddress MergeSockets_PropertyAddress;

	private static int MergeSockets_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:bMergeSockets")]
	public bool MergeSockets;

	private static bool MergeVirtualBones_IsValid;

	private static FFieldAddress MergeVirtualBones_PropertyAddress;

	private static int MergeVirtualBones_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:bMergeVirtualBones")]
	public bool MergeVirtualBones;

	private static bool MergeCurveNames_IsValid;

	private static FFieldAddress MergeCurveNames_PropertyAddress;

	private static int MergeCurveNames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:bMergeCurveNames")]
	public bool MergeCurveNames;

	private static bool MergeBlendProfiles_IsValid;

	private static FFieldAddress MergeBlendProfiles_PropertyAddress;

	private static int MergeBlendProfiles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:bMergeBlendProfiles")]
	public bool MergeBlendProfiles;

	private static bool MergeAnimSlotGroups_IsValid;

	private static FFieldAddress MergeAnimSlotGroups_PropertyAddress;

	private static int MergeAnimSlotGroups_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SkeletalMerging.SkeletonMergeParams:bMergeAnimSlotGroups")]
	public bool MergeAnimSlotGroups;

	private static bool FSkeletonMergeParams_IsValid;

	private static int FSkeletonMergeParams_StructSize;

	public FSkeletonMergeParams Copy()
	{
		FSkeletonMergeParams result = this;
		if (SkeletonsToMerge != null)
		{
			result.SkeletonsToMerge = new List<USkeleton>(SkeletonsToMerge);
		}
		return result;
	}

	public static FSkeletonMergeParams FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletonMergeParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletonMergeParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletonMergeParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletonMergeParams(nativeBuffer + arrayIndex * FSkeletonMergeParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletonMergeParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletonMergeParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletonMergeParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SkeletalMerging.SkeletonMergeParams");
			return;
		}
		new TArrayCopyMarshaler<USkeleton>(1, SkeletonsToMerge_PropertyAddress, CachedMarshalingDelegates<USkeleton, UObjectMarshaler<USkeleton>>.FromNative, CachedMarshalingDelegates<USkeleton, UObjectMarshaler<USkeleton>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkeletonsToMerge_Offset), SkeletonsToMerge);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeSockets_Offset), 0, MergeSockets_PropertyAddress.Address, MergeSockets);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeVirtualBones_Offset), 0, MergeVirtualBones_PropertyAddress.Address, MergeVirtualBones);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeCurveNames_Offset), 0, MergeCurveNames_PropertyAddress.Address, MergeCurveNames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeBlendProfiles_Offset), 0, MergeBlendProfiles_PropertyAddress.Address, MergeBlendProfiles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeAnimSlotGroups_Offset), 0, MergeAnimSlotGroups_PropertyAddress.Address, MergeAnimSlotGroups);
	}

	public FSkeletonMergeParams(IntPtr nativeStruct)
	{
		if (!FSkeletonMergeParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SkeletalMerging.SkeletonMergeParams");
			SkeletonsToMerge = null;
			MergeSockets = false;
			MergeVirtualBones = false;
			MergeCurveNames = false;
			MergeBlendProfiles = false;
			MergeAnimSlotGroups = false;
		}
		else
		{
			SkeletonsToMerge = new TArrayCopyMarshaler<USkeleton>(1, SkeletonsToMerge_PropertyAddress, CachedMarshalingDelegates<USkeleton, UObjectMarshaler<USkeleton>>.FromNative, CachedMarshalingDelegates<USkeleton, UObjectMarshaler<USkeleton>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkeletonsToMerge_Offset));
			MergeSockets = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeSockets_Offset), 0, MergeSockets_PropertyAddress.Address);
			MergeVirtualBones = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeVirtualBones_Offset), 0, MergeVirtualBones_PropertyAddress.Address);
			MergeCurveNames = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeCurveNames_Offset), 0, MergeCurveNames_PropertyAddress.Address);
			MergeBlendProfiles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeBlendProfiles_Offset), 0, MergeBlendProfiles_PropertyAddress.Address);
			MergeAnimSlotGroups = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeAnimSlotGroups_Offset), 0, MergeAnimSlotGroups_PropertyAddress.Address);
		}
	}

	static FSkeletonMergeParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletonMergeParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletonMergeParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SkeletalMerging.SkeletonMergeParams");
		FSkeletonMergeParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SkeletonsToMerge_PropertyAddress, intPtr, "SkeletonsToMerge");
		SkeletonsToMerge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkeletonsToMerge");
		SkeletonsToMerge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkeletonsToMerge", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeSockets_PropertyAddress, intPtr, "bMergeSockets");
		MergeSockets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeSockets");
		MergeSockets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeSockets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeVirtualBones_PropertyAddress, intPtr, "bMergeVirtualBones");
		MergeVirtualBones_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeVirtualBones");
		MergeVirtualBones_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeVirtualBones", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeCurveNames_PropertyAddress, intPtr, "bMergeCurveNames");
		MergeCurveNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeCurveNames");
		MergeCurveNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeCurveNames", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeBlendProfiles_PropertyAddress, intPtr, "bMergeBlendProfiles");
		MergeBlendProfiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeBlendProfiles");
		MergeBlendProfiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeBlendProfiles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeAnimSlotGroups_PropertyAddress, intPtr, "bMergeAnimSlotGroups");
		MergeAnimSlotGroups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeAnimSlotGroups");
		MergeAnimSlotGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeAnimSlotGroups", Classes.FBoolProperty);
		FSkeletonMergeParams_IsValid = intPtr != IntPtr.Zero && SkeletonsToMerge_IsValid && MergeSockets_IsValid && MergeVirtualBones_IsValid && MergeCurveNames_IsValid && MergeBlendProfiles_IsValid && MergeAnimSlotGroups_IsValid;
		NativeReflection.LogStructIsValid("/Script/SkeletalMerging.SkeletonMergeParams", FSkeletonMergeParams_IsValid);
	}
}
