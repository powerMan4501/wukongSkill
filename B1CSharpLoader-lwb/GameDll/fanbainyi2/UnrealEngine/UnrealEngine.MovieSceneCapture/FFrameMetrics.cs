using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.FrameMetrics", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FFrameMetrics
{
	private static bool TotalElapsedTime_IsValid;

	private static int TotalElapsedTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieSceneCapture.FrameMetrics:TotalElapsedTime")]
	public float TotalElapsedTime;

	private static bool FrameDelta_IsValid;

	private static int FrameDelta_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieSceneCapture.FrameMetrics:FrameDelta")]
	public float FrameDelta;

	private static bool FrameNumber_IsValid;

	private static int FrameNumber_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieSceneCapture.FrameMetrics:FrameNumber")]
	public int FrameNumber;

	private static bool NumDroppedFrames_IsValid;

	private static int NumDroppedFrames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MovieSceneCapture.FrameMetrics:NumDroppedFrames")]
	public int NumDroppedFrames;

	private static bool FFrameMetrics_IsValid;

	private static int FFrameMetrics_StructSize;

	public FFrameMetrics Copy()
	{
		return this;
	}

	public static FFrameMetrics FromNative(IntPtr nativeBuffer)
	{
		return new FFrameMetrics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameMetrics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameMetrics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameMetrics(nativeBuffer + arrayIndex * FFrameMetrics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameMetrics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameMetrics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameMetrics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.FrameMetrics");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalElapsedTime_Offset), TotalElapsedTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FrameDelta_Offset), FrameDelta);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameNumber_Offset), FrameNumber);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumDroppedFrames_Offset), NumDroppedFrames);
	}

	public FFrameMetrics(IntPtr nativeStruct)
	{
		if (!FFrameMetrics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.FrameMetrics");
			TotalElapsedTime = 0f;
			FrameDelta = 0f;
			FrameNumber = 0;
			NumDroppedFrames = 0;
		}
		else
		{
			TotalElapsedTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalElapsedTime_Offset));
			FrameDelta = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FrameDelta_Offset));
			FrameNumber = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameNumber_Offset));
			NumDroppedFrames = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumDroppedFrames_Offset));
		}
	}

	static FFrameMetrics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameMetrics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameMetrics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.FrameMetrics");
		FFrameMetrics_StructSize = NativeReflection.GetStructSize(intPtr);
		TotalElapsedTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalElapsedTime");
		TotalElapsedTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalElapsedTime", Classes.FFloatProperty);
		FrameDelta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameDelta");
		FrameDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameDelta", Classes.FFloatProperty);
		FrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameNumber");
		FrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameNumber", Classes.FIntProperty);
		NumDroppedFrames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumDroppedFrames");
		NumDroppedFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumDroppedFrames", Classes.FIntProperty);
		FFrameMetrics_IsValid = intPtr != IntPtr.Zero && TotalElapsedTime_IsValid && FrameDelta_IsValid && FrameNumber_IsValid && NumDroppedFrames_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.FrameMetrics", FFrameMetrics_IsValid);
	}
}
