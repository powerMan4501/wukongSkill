using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionMatchData", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionMatchData
{
	private static bool SelectedSkeletonBoneTransforms_IsValid;

	private static FFieldAddress SelectedSkeletonBoneTransforms_PropertyAddress;

	private static int SelectedSkeletonBoneTransforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.MotionMatchData:SelectedSkeletonBoneTransforms")]
	public List<FTransform> SelectedSkeletonBoneTransforms;

	private static bool ElectedSourceReference_IsValid;

	private static int ElectedSourceReference_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchData:ElectedSourceReference")]
	public FName ElectedSourceReference;

	private static bool FMotionMatchData_IsValid;

	private static int FMotionMatchData_StructSize;

	public FMotionMatchData Copy()
	{
		FMotionMatchData result = this;
		if (SelectedSkeletonBoneTransforms != null)
		{
			result.SelectedSkeletonBoneTransforms = new List<FTransform>(SelectedSkeletonBoneTransforms);
		}
		return result;
	}

	public static FMotionMatchData FromNative(IntPtr nativeBuffer)
	{
		return new FMotionMatchData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionMatchData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionMatchData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionMatchData(nativeBuffer + arrayIndex * FMotionMatchData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionMatchData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionMatchData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionMatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchData");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, SelectedSkeletonBoneTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SelectedSkeletonBoneTransforms_Offset), SelectedSkeletonBoneTransforms);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ElectedSourceReference_Offset), ElectedSourceReference);
	}

	public FMotionMatchData(IntPtr nativeStruct)
	{
		if (!FMotionMatchData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchData");
			SelectedSkeletonBoneTransforms = null;
			ElectedSourceReference = default(FName);
		}
		else
		{
			SelectedSkeletonBoneTransforms = new TArrayCopyMarshaler<FTransform>(1, SelectedSkeletonBoneTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SelectedSkeletonBoneTransforms_Offset));
			ElectedSourceReference = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ElectedSourceReference_Offset));
		}
	}

	static FMotionMatchData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionMatchData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionMatchData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionMatchData");
		FMotionMatchData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SelectedSkeletonBoneTransforms_PropertyAddress, intPtr, "SelectedSkeletonBoneTransforms");
		SelectedSkeletonBoneTransforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedSkeletonBoneTransforms");
		SelectedSkeletonBoneTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedSkeletonBoneTransforms", Classes.FArrayProperty);
		ElectedSourceReference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElectedSourceReference");
		ElectedSourceReference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElectedSourceReference", Classes.FNameProperty);
		FMotionMatchData_IsValid = intPtr != IntPtr.Zero && SelectedSkeletonBoneTransforms_IsValid && ElectedSourceReference_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MotionMatchData", FMotionMatchData_IsValid);
	}
}
