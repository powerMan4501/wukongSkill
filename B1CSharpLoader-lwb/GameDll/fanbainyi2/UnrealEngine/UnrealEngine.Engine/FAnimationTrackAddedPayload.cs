using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimationTrackAddedPayload", "Engine", UnrealModuleType.Engine)]
public struct FAnimationTrackAddedPayload
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.AnimationTrackPayload:Name")]
	public FName Name;

	private static bool TrackIndex_IsValid;

	private static int TrackIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.AnimationTrackAddedPayload:TrackIndex")]
	public int TrackIndex;

	private static bool FAnimationTrackAddedPayload_IsValid;

	private static int FAnimationTrackAddedPayload_StructSize;

	public FAnimationTrackAddedPayload Copy()
	{
		return this;
	}

	public static FAnimationTrackAddedPayload FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationTrackAddedPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationTrackAddedPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationTrackAddedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationTrackAddedPayload(nativeBuffer + arrayIndex * FAnimationTrackAddedPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationTrackAddedPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationTrackAddedPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationTrackAddedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationTrackAddedPayload");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TrackIndex_Offset), TrackIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FAnimationTrackAddedPayload(IntPtr nativeStruct)
	{
		if (!FAnimationTrackAddedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationTrackAddedPayload");
			TrackIndex = 0;
			Name = default(FName);
		}
		else
		{
			TrackIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TrackIndex_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FAnimationTrackAddedPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationTrackAddedPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationTrackAddedPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimationTrackAddedPayload");
		FAnimationTrackAddedPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrackIndex");
		TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrackIndex", Classes.FIntProperty);
		FAnimationTrackAddedPayload_IsValid = intPtr != IntPtr.Zero && TrackIndex_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimationTrackAddedPayload", FAnimationTrackAddedPayload_IsValid);
	}
}
