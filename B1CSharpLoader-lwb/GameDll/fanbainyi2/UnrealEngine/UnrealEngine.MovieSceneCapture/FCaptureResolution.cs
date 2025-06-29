using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.CaptureResolution", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FCaptureResolution
{
	private static bool ResX_IsValid;

	private static int ResX_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.CaptureResolution:ResX")]
	public int ResX;

	private static bool ResY_IsValid;

	private static int ResY_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.CaptureResolution:ResY")]
	public int ResY;

	private static bool FCaptureResolution_IsValid;

	private static int FCaptureResolution_StructSize;

	public FCaptureResolution Copy()
	{
		return this;
	}

	public static FCaptureResolution FromNative(IntPtr nativeBuffer)
	{
		return new FCaptureResolution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCaptureResolution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCaptureResolution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCaptureResolution(nativeBuffer + arrayIndex * FCaptureResolution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCaptureResolution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCaptureResolution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCaptureResolution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CaptureResolution");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResX_Offset), ResX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResY_Offset), ResY);
	}

	public FCaptureResolution(IntPtr nativeStruct)
	{
		if (!FCaptureResolution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CaptureResolution");
			ResX = 0;
			ResY = 0;
		}
		else
		{
			ResX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResX_Offset));
			ResY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResY_Offset));
		}
	}

	static FCaptureResolution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCaptureResolution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCaptureResolution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.CaptureResolution");
		FCaptureResolution_StructSize = NativeReflection.GetStructSize(intPtr);
		ResX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResX");
		ResX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResX", Classes.FIntProperty);
		ResY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResY");
		ResY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResY", Classes.FIntProperty);
		FCaptureResolution_IsValid = intPtr != IntPtr.Zero && ResX_IsValid && ResY_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.CaptureResolution", FCaptureResolution_IsValid);
	}
}
