using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneSectionParameters
{
	private static bool StartFrameOffset_IsValid;

	private static int StartFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:StartFrameOffset")]
	public FFrameNumber StartFrameOffset;

	private static bool CanLoop_IsValid;

	private static FFieldAddress CanLoop_PropertyAddress;

	private static int CanLoop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:bCanLoop")]
	public bool CanLoop;

	private static bool EndFrameOffset_IsValid;

	private static int EndFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:EndFrameOffset")]
	public FFrameNumber EndFrameOffset;

	private static bool FirstLoopStartFrameOffset_IsValid;

	private static int FirstLoopStartFrameOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:FirstLoopStartFrameOffset")]
	public FFrameNumber FirstLoopStartFrameOffset;

	private static bool TimeScale_IsValid;

	private static int TimeScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:TimeScale")]
	public float TimeScale;

	private static bool HierarchicalBias_IsValid;

	private static int HierarchicalBias_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSectionParameters:HierarchicalBias")]
	public int HierarchicalBias;

	private static bool FMovieSceneSectionParameters_IsValid;

	private static int FMovieSceneSectionParameters_StructSize;

	public FMovieSceneSectionParameters Copy()
	{
		return this;
	}

	public static FMovieSceneSectionParameters FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSectionParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSectionParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSectionParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSectionParameters(nativeBuffer + arrayIndex * FMovieSceneSectionParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSectionParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSectionParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSectionParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSectionParameters");
			return;
		}
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, StartFrameOffset_Offset), StartFrameOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanLoop_Offset), 0, CanLoop_PropertyAddress.Address, CanLoop);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, EndFrameOffset_Offset), EndFrameOffset);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, FirstLoopStartFrameOffset_Offset), FirstLoopStartFrameOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeScale_Offset), TimeScale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HierarchicalBias_Offset), HierarchicalBias);
	}

	public FMovieSceneSectionParameters(IntPtr nativeStruct)
	{
		if (!FMovieSceneSectionParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSectionParameters");
			StartFrameOffset = default(FFrameNumber);
			CanLoop = false;
			EndFrameOffset = default(FFrameNumber);
			FirstLoopStartFrameOffset = default(FFrameNumber);
			TimeScale = 0f;
			HierarchicalBias = 0;
		}
		else
		{
			StartFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, StartFrameOffset_Offset));
			CanLoop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanLoop_Offset), 0, CanLoop_PropertyAddress.Address);
			EndFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, EndFrameOffset_Offset));
			FirstLoopStartFrameOffset = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, FirstLoopStartFrameOffset_Offset));
			TimeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeScale_Offset));
			HierarchicalBias = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HierarchicalBias_Offset));
		}
	}

	static FMovieSceneSectionParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSectionParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSectionParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneSectionParameters");
		FMovieSceneSectionParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		StartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartFrameOffset");
		StartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartFrameOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanLoop_PropertyAddress, intPtr, "bCanLoop");
		CanLoop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanLoop");
		CanLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanLoop", Classes.FBoolProperty);
		EndFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndFrameOffset");
		EndFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndFrameOffset", Classes.FStructProperty);
		FirstLoopStartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FirstLoopStartFrameOffset");
		FirstLoopStartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FirstLoopStartFrameOffset", Classes.FStructProperty);
		TimeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeScale");
		TimeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeScale", Classes.FFloatProperty);
		HierarchicalBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HierarchicalBias");
		HierarchicalBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HierarchicalBias", Classes.FIntProperty);
		FMovieSceneSectionParameters_IsValid = intPtr != IntPtr.Zero && StartFrameOffset_IsValid && CanLoop_IsValid && EndFrameOffset_IsValid && FirstLoopStartFrameOffset_IsValid && TimeScale_IsValid && HierarchicalBias_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneSectionParameters", FMovieSceneSectionParameters_IsValid);
	}
}
