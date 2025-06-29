using System;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LevelSequenceEditor;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/LevelSequenceEditor.SequencerChannelProxy", "LevelSequenceEditor", UnrealModuleType.EnginePlugin)]
public struct FSequencerChannelProxy
{
	private static bool ChannelName_IsValid;

	private static int ChannelName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/LevelSequenceEditor.SequencerChannelProxy:ChannelName")]
	public FName ChannelName;

	private static bool Section_IsValid;

	private static int Section_Offset;

	[UProperty(Flags = (PropFlags)7881369141641740uL)]
	[UMetaPath("/Script/LevelSequenceEditor.SequencerChannelProxy:Section")]
	public UMovieSceneSection Section;

	private static bool FSequencerChannelProxy_IsValid;

	private static int FSequencerChannelProxy_StructSize;

	public FSequencerChannelProxy Copy()
	{
		return this;
	}

	public static FSequencerChannelProxy FromNative(IntPtr nativeBuffer)
	{
		return new FSequencerChannelProxy(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequencerChannelProxy value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequencerChannelProxy FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequencerChannelProxy(nativeBuffer + arrayIndex * FSequencerChannelProxy_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequencerChannelProxy value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequencerChannelProxy_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequencerChannelProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequenceEditor.SequencerChannelProxy");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ChannelName_Offset), ChannelName);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(nativeStruct, Section_Offset), Section);
	}

	public FSequencerChannelProxy(IntPtr nativeStruct)
	{
		if (!FSequencerChannelProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequenceEditor.SequencerChannelProxy");
			ChannelName = default(FName);
			Section = null;
		}
		else
		{
			ChannelName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ChannelName_Offset));
			Section = UObjectMarshaler<UMovieSceneSection>.FromNative(IntPtr.Add(nativeStruct, Section_Offset));
		}
	}

	static FSequencerChannelProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencerChannelProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencerChannelProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LevelSequenceEditor.SequencerChannelProxy");
		FSequencerChannelProxy_StructSize = NativeReflection.GetStructSize(intPtr);
		ChannelName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelName");
		ChannelName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelName", Classes.FNameProperty);
		Section_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Section");
		Section_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Section", Classes.FObjectProperty);
		FSequencerChannelProxy_IsValid = intPtr != IntPtr.Zero && ChannelName_IsValid && Section_IsValid;
		NativeReflection.LogStructIsValid("/Script/LevelSequenceEditor.SequencerChannelProxy", FSequencerChannelProxy_IsValid);
	}
}
