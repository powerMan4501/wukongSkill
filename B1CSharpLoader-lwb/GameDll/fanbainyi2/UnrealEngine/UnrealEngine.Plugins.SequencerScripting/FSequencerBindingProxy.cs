using System;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.SequencerBindingProxy", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public struct FSequencerBindingProxy
{
	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/SequencerScripting.SequencerBindingProxy:Sequence")]
	public UMovieSceneSequence Sequence;

	private static bool FSequencerBindingProxy_IsValid;

	private static int FSequencerBindingProxy_StructSize;

	public FSequencerBindingProxy Copy()
	{
		return this;
	}

	public static FSequencerBindingProxy FromNative(IntPtr nativeBuffer)
	{
		return new FSequencerBindingProxy(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSequencerBindingProxy value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSequencerBindingProxy FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSequencerBindingProxy(nativeBuffer + arrayIndex * FSequencerBindingProxy_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSequencerBindingProxy value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSequencerBindingProxy_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSequencerBindingProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScripting.SequencerBindingProxy");
		}
		else
		{
			UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		}
	}

	public FSequencerBindingProxy(IntPtr nativeStruct)
	{
		if (!FSequencerBindingProxy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SequencerScripting.SequencerBindingProxy");
			Sequence = null;
		}
		else
		{
			Sequence = UObjectMarshaler<UMovieSceneSequence>.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
		}
	}

	static FSequencerBindingProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencerBindingProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencerBindingProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SequencerScripting.SequencerBindingProxy");
		FSequencerBindingProxy_StructSize = NativeReflection.GetStructSize(intPtr);
		Sequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sequence", Classes.FObjectProperty);
		FSequencerBindingProxy_IsValid = intPtr != IntPtr.Zero && Sequence_IsValid;
		NativeReflection.LogStructIsValid("/Script/SequencerScripting.SequencerBindingProxy", FSequencerBindingProxy_IsValid);
	}
}
