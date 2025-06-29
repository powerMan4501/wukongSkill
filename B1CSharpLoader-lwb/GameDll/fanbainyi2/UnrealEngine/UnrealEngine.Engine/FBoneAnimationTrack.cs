using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.BoneAnimationTrack", "Engine", UnrealModuleType.Engine)]
public struct FBoneAnimationTrack
{
	private static bool InternalTrackData_IsValid;

	private static int InternalTrackData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/Engine.BoneAnimationTrack:InternalTrackData")]
	public FRawAnimSequenceTrack InternalTrackData;

	private static bool BoneTreeIndex_IsValid;

	private static int BoneTreeIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.BoneAnimationTrack:BoneTreeIndex")]
	public int BoneTreeIndex;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.BoneAnimationTrack:Name")]
	public FName Name;

	private static bool FBoneAnimationTrack_IsValid;

	private static int FBoneAnimationTrack_StructSize;

	public FBoneAnimationTrack Copy()
	{
		return this;
	}

	public static FBoneAnimationTrack FromNative(IntPtr nativeBuffer)
	{
		return new FBoneAnimationTrack(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBoneAnimationTrack value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBoneAnimationTrack FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBoneAnimationTrack(nativeBuffer + arrayIndex * FBoneAnimationTrack_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBoneAnimationTrack value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBoneAnimationTrack_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBoneAnimationTrack_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BoneAnimationTrack");
			return;
		}
		FRawAnimSequenceTrack.ToNative(IntPtr.Add(nativeStruct, InternalTrackData_Offset), InternalTrackData);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BoneTreeIndex_Offset), BoneTreeIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FBoneAnimationTrack(IntPtr nativeStruct)
	{
		if (!FBoneAnimationTrack_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BoneAnimationTrack");
			InternalTrackData = default(FRawAnimSequenceTrack);
			BoneTreeIndex = 0;
			Name = default(FName);
		}
		else
		{
			InternalTrackData = FRawAnimSequenceTrack.FromNative(IntPtr.Add(nativeStruct, InternalTrackData_Offset));
			BoneTreeIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BoneTreeIndex_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FBoneAnimationTrack()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBoneAnimationTrack)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoneAnimationTrack));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BoneAnimationTrack");
		FBoneAnimationTrack_StructSize = NativeReflection.GetStructSize(intPtr);
		InternalTrackData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTrackData");
		InternalTrackData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTrackData", Classes.FStructProperty);
		BoneTreeIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneTreeIndex");
		BoneTreeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneTreeIndex", Classes.FIntProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FBoneAnimationTrack_IsValid = intPtr != IntPtr.Zero && InternalTrackData_IsValid && BoneTreeIndex_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.BoneAnimationTrack", FBoneAnimationTrack_IsValid);
	}
}
