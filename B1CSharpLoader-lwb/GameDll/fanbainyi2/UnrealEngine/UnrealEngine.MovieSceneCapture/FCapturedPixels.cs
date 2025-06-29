using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.CapturedPixels", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FCapturedPixels
{
	private static bool FCapturedPixels_IsValid;

	private static int FCapturedPixels_StructSize;

	public FCapturedPixels Copy()
	{
		return this;
	}

	public static FCapturedPixels FromNative(IntPtr nativeBuffer)
	{
		return new FCapturedPixels(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCapturedPixels value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCapturedPixels FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCapturedPixels(nativeBuffer + arrayIndex * FCapturedPixels_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCapturedPixels value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCapturedPixels_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCapturedPixels_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CapturedPixels");
		}
	}

	public FCapturedPixels(IntPtr nativeStruct)
	{
		if (!FCapturedPixels_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CapturedPixels");
		}
	}

	static FCapturedPixels()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCapturedPixels)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCapturedPixels));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.CapturedPixels");
		FCapturedPixels_StructSize = NativeReflection.GetStructSize(intPtr);
		FCapturedPixels_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.CapturedPixels", FCapturedPixels_IsValid);
	}
}
