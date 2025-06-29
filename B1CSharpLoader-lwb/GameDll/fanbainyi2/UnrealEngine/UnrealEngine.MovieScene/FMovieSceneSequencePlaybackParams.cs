using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneSequencePlaybackParams
{
	private static bool Frame_IsValid;

	private static int Frame_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:Frame")]
	public FFrameTime Frame;

	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:Time")]
	public float Time;

	private static bool MarkedFrame_IsValid;

	private static int MarkedFrame_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:MarkedFrame")]
	public string MarkedFrame;

	private static bool PositionType_IsValid;

	private static FFieldAddress PositionType_PropertyAddress;

	private static int PositionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:PositionType")]
	public EMovieScenePositionType PositionType;

	private static bool UpdateMethod_IsValid;

	private static FFieldAddress UpdateMethod_PropertyAddress;

	private static int UpdateMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:UpdateMethod")]
	public EUpdatePositionMethod UpdateMethod;

	private static bool HasJumped_IsValid;

	private static FFieldAddress HasJumped_PropertyAddress;

	private static int HasJumped_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackParams:bHasJumped")]
	public bool HasJumped;

	private static bool FMovieSceneSequencePlaybackParams_IsValid;

	private static int FMovieSceneSequencePlaybackParams_StructSize;

	public FMovieSceneSequencePlaybackParams Copy()
	{
		return this;
	}

	public static FMovieSceneSequencePlaybackParams FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSequencePlaybackParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSequencePlaybackParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSequencePlaybackParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSequencePlaybackParams(nativeBuffer + arrayIndex * FMovieSceneSequencePlaybackParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSequencePlaybackParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSequencePlaybackParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlaybackParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlaybackParams");
			return;
		}
		FFrameTime.ToNative(IntPtr.Add(nativeStruct, Frame_Offset), Frame);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MarkedFrame_Offset), MarkedFrame);
		EnumMarshaler<EMovieScenePositionType>.ToNative(IntPtr.Add(nativeStruct, PositionType_Offset), 0, PositionType_PropertyAddress.Address, PositionType);
		EnumMarshaler<EUpdatePositionMethod>.ToNative(IntPtr.Add(nativeStruct, UpdateMethod_Offset), 0, UpdateMethod_PropertyAddress.Address, UpdateMethod);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasJumped_Offset), 0, HasJumped_PropertyAddress.Address, HasJumped);
	}

	public FMovieSceneSequencePlaybackParams(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlaybackParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlaybackParams");
			Frame = default(FFrameTime);
			Time = 0f;
			MarkedFrame = FStringMarshaler.DefaultString;
			PositionType = EMovieScenePositionType.Frame;
			UpdateMethod = EUpdatePositionMethod.Play;
			HasJumped = false;
		}
		else
		{
			Frame = FFrameTime.FromNative(IntPtr.Add(nativeStruct, Frame_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
			MarkedFrame = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MarkedFrame_Offset));
			PositionType = EnumMarshaler<EMovieScenePositionType>.FromNative(IntPtr.Add(nativeStruct, PositionType_Offset), 0, PositionType_PropertyAddress.Address);
			UpdateMethod = EnumMarshaler<EUpdatePositionMethod>.FromNative(IntPtr.Add(nativeStruct, UpdateMethod_Offset), 0, UpdateMethod_PropertyAddress.Address);
			HasJumped = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasJumped_Offset), 0, HasJumped_PropertyAddress.Address);
		}
	}

	static FMovieSceneSequencePlaybackParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSequencePlaybackParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSequencePlaybackParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneSequencePlaybackParams");
		FMovieSceneSequencePlaybackParams_StructSize = NativeReflection.GetStructSize(intPtr);
		Frame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frame");
		Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frame", Classes.FStructProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		MarkedFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MarkedFrame");
		MarkedFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MarkedFrame", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PositionType_PropertyAddress, intPtr, "PositionType");
		PositionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionType");
		PositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMethod_PropertyAddress, intPtr, "UpdateMethod");
		UpdateMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpdateMethod");
		UpdateMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpdateMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref HasJumped_PropertyAddress, intPtr, "bHasJumped");
		HasJumped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasJumped");
		HasJumped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasJumped", Classes.FBoolProperty);
		FMovieSceneSequencePlaybackParams_IsValid = intPtr != IntPtr.Zero && Frame_IsValid && Time_IsValid && MarkedFrame_IsValid && PositionType_IsValid && UpdateMethod_IsValid && HasJumped_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneSequencePlaybackParams", FMovieSceneSequencePlaybackParams_IsValid);
	}
}
