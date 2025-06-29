using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneSkeletalAnimationParams
{
	private static bool Animation_IsValid;

	private static int Animation_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:Animation")]
	public UAnimSequenceBase Animation;

	private static bool FirstLoopStartFrameOffset_IsValid;

	private static int FirstLoopStartFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:FirstLoopStartFrameOffset")]
	public FFrameNumber FirstLoopStartFrameOffset;

	private static bool StartFrameOffset_IsValid;

	private static int StartFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:StartFrameOffset")]
	public FFrameNumber StartFrameOffset;

	private static bool EndFrameOffset_IsValid;

	private static int EndFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:EndFrameOffset")]
	public FFrameNumber EndFrameOffset;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:PlayRate")]
	public float PlayRate;

	private static bool Reverse_IsValid;

	private static FFieldAddress Reverse_PropertyAddress;

	private static int Reverse_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:bReverse")]
	public bool Reverse;

	private static bool SlotName_IsValid;

	private static int SlotName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:SlotName")]
	public FName SlotName;

	private static bool MirrorDataTable_IsValid;

	private static int MirrorDataTable_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:MirrorDataTable")]
	public UMirrorDataTable MirrorDataTable;

	private static bool SkipAnimNotifiers_IsValid;

	private static FFieldAddress SkipAnimNotifiers_PropertyAddress;

	private static int SkipAnimNotifiers_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams:bSkipAnimNotifiers")]
	public bool SkipAnimNotifiers;

	private static bool FMovieSceneSkeletalAnimationParams_IsValid;

	private static int FMovieSceneSkeletalAnimationParams_StructSize;

	public FMovieSceneSkeletalAnimationParams Copy()
	{
		return this;
	}

	public static FMovieSceneSkeletalAnimationParams FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSkeletalAnimationParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSkeletalAnimationParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSkeletalAnimationParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSkeletalAnimationParams(nativeBuffer + arrayIndex * FMovieSceneSkeletalAnimationParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSkeletalAnimationParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSkeletalAnimationParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSkeletalAnimationParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams");
			return;
		}
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(nativeStruct, Animation_Offset), Animation);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, FirstLoopStartFrameOffset_Offset), FirstLoopStartFrameOffset);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, StartFrameOffset_Offset), StartFrameOffset);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, EndFrameOffset_Offset), EndFrameOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayRate_Offset), PlayRate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Reverse_Offset), 0, Reverse_PropertyAddress.Address, Reverse);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SlotName_Offset), SlotName);
		UObjectMarshaler<UMirrorDataTable>.ToNative(IntPtr.Add(nativeStruct, MirrorDataTable_Offset), MirrorDataTable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipAnimNotifiers_Offset), 0, SkipAnimNotifiers_PropertyAddress.Address, SkipAnimNotifiers);
	}

	public FMovieSceneSkeletalAnimationParams(IntPtr nativeStruct)
	{
		if (!FMovieSceneSkeletalAnimationParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams");
			Animation = null;
			FirstLoopStartFrameOffset = default(FFrameNumber);
			StartFrameOffset = default(FFrameNumber);
			EndFrameOffset = default(FFrameNumber);
			PlayRate = 0f;
			Reverse = false;
			SlotName = default(FName);
			MirrorDataTable = null;
			SkipAnimNotifiers = false;
		}
		else
		{
			Animation = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(nativeStruct, Animation_Offset));
			FirstLoopStartFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, FirstLoopStartFrameOffset_Offset));
			StartFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, StartFrameOffset_Offset));
			EndFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, EndFrameOffset_Offset));
			PlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayRate_Offset));
			Reverse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Reverse_Offset), 0, Reverse_PropertyAddress.Address);
			SlotName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SlotName_Offset));
			MirrorDataTable = UObjectMarshaler<UMirrorDataTable>.FromNative(IntPtr.Add(nativeStruct, MirrorDataTable_Offset));
			SkipAnimNotifiers = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipAnimNotifiers_Offset), 0, SkipAnimNotifiers_PropertyAddress.Address);
		}
	}

	static FMovieSceneSkeletalAnimationParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSkeletalAnimationParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSkeletalAnimationParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams");
		FMovieSceneSkeletalAnimationParams_StructSize = NativeReflection.GetStructSize(intPtr);
		Animation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Animation");
		Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Animation", Classes.FObjectProperty);
		FirstLoopStartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FirstLoopStartFrameOffset");
		FirstLoopStartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FirstLoopStartFrameOffset", Classes.FStructProperty);
		StartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartFrameOffset");
		StartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartFrameOffset", Classes.FStructProperty);
		EndFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndFrameOffset");
		EndFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndFrameOffset", Classes.FStructProperty);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Reverse_PropertyAddress, intPtr, "bReverse");
		Reverse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReverse");
		Reverse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReverse", Classes.FBoolProperty);
		SlotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SlotName");
		SlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SlotName", Classes.FNameProperty);
		MirrorDataTable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MirrorDataTable");
		MirrorDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MirrorDataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipAnimNotifiers_PropertyAddress, intPtr, "bSkipAnimNotifiers");
		SkipAnimNotifiers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipAnimNotifiers");
		SkipAnimNotifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipAnimNotifiers", Classes.FBoolProperty);
		FMovieSceneSkeletalAnimationParams_IsValid = intPtr != IntPtr.Zero && Animation_IsValid && FirstLoopStartFrameOffset_IsValid && StartFrameOffset_IsValid && EndFrameOffset_IsValid && PlayRate_IsValid && Reverse_IsValid && SlotName_IsValid && MirrorDataTable_IsValid && SkipAnimNotifiers_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams", FMovieSceneSkeletalAnimationParams_IsValid);
	}
}
