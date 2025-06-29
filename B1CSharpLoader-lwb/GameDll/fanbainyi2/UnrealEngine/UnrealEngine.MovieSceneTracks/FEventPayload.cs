using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.EventPayload", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FEventPayload
{
	private static bool EventName_IsValid;

	private static int EventName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieSceneTracks.EventPayload:EventName")]
	public FName EventName;

	private static bool Parameters_IsValid;

	private static int Parameters_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/MovieSceneTracks.EventPayload:Parameters")]
	public FMovieSceneEventParameters Parameters;

	private static bool FEventPayload_IsValid;

	private static int FEventPayload_StructSize;

	public FEventPayload Copy()
	{
		return this;
	}

	public static FEventPayload FromNative(IntPtr nativeBuffer)
	{
		return new FEventPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEventPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEventPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEventPayload(nativeBuffer + arrayIndex * FEventPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEventPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEventPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEventPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.EventPayload");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, EventName_Offset), EventName);
		FMovieSceneEventParameters.ToNative(IntPtr.Add(nativeStruct, Parameters_Offset), Parameters);
	}

	public FEventPayload(IntPtr nativeStruct)
	{
		if (!FEventPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.EventPayload");
			EventName = default(FName);
			Parameters = default(FMovieSceneEventParameters);
		}
		else
		{
			EventName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, EventName_Offset));
			Parameters = FMovieSceneEventParameters.FromNative(IntPtr.Add(nativeStruct, Parameters_Offset));
		}
	}

	static FEventPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEventPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEventPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.EventPayload");
		FEventPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		EventName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		Parameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Parameters");
		Parameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Parameters", Classes.FStructProperty);
		FEventPayload_IsValid = intPtr != IntPtr.Zero && EventName_IsValid && Parameters_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.EventPayload", FEventPayload_IsValid);
	}
}
