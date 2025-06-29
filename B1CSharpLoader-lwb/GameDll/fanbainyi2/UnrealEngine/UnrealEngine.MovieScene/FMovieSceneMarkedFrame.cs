using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneMarkedFrame", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneMarkedFrame
{
	private static bool FrameNumber_IsValid;

	private static int FrameNumber_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneMarkedFrame:FrameNumber")]
	public FFrameNumber FrameNumber;

	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneMarkedFrame:Label")]
	public string Label;

	private static bool IsDeterminismFence_IsValid;

	private static FFieldAddress IsDeterminismFence_PropertyAddress;

	private static int IsDeterminismFence_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneMarkedFrame:bIsDeterminismFence")]
	public bool IsDeterminismFence;

	private static bool FMovieSceneMarkedFrame_IsValid;

	private static int FMovieSceneMarkedFrame_StructSize;

	public FMovieSceneMarkedFrame Copy()
	{
		return this;
	}

	public static FMovieSceneMarkedFrame FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneMarkedFrame(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneMarkedFrame value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneMarkedFrame FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneMarkedFrame(nativeBuffer + arrayIndex * FMovieSceneMarkedFrame_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneMarkedFrame value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneMarkedFrame_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneMarkedFrame");
			return;
		}
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, FrameNumber_Offset), FrameNumber);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDeterminismFence_Offset), 0, IsDeterminismFence_PropertyAddress.Address, IsDeterminismFence);
	}

	public FMovieSceneMarkedFrame(IntPtr nativeStruct)
	{
		if (!FMovieSceneMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneMarkedFrame");
			FrameNumber = default(FFrameNumber);
			Label = FStringMarshaler.DefaultString;
			IsDeterminismFence = false;
		}
		else
		{
			FrameNumber = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, FrameNumber_Offset));
			Label = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
			IsDeterminismFence = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDeterminismFence_Offset), 0, IsDeterminismFence_PropertyAddress.Address);
		}
	}

	static FMovieSceneMarkedFrame()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneMarkedFrame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneMarkedFrame));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneMarkedFrame");
		FMovieSceneMarkedFrame_StructSize = NativeReflection.GetStructSize(intPtr);
		FrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumber");
		FrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumber", Classes.FStructProperty);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDeterminismFence_PropertyAddress, intPtr, "bIsDeterminismFence");
		IsDeterminismFence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDeterminismFence");
		IsDeterminismFence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDeterminismFence", Classes.FBoolProperty);
		FMovieSceneMarkedFrame_IsValid = intPtr != IntPtr.Zero && FrameNumber_IsValid && Label_IsValid && IsDeterminismFence_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneMarkedFrame", FMovieSceneMarkedFrame_IsValid);
	}
}
