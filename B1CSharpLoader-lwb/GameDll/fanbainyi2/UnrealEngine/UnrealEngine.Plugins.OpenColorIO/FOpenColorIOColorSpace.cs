using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OpenColorIO.OpenColorIOColorSpace", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public struct FOpenColorIOColorSpace
{
	private static bool FOpenColorIOColorSpace_IsValid;

	private static int FOpenColorIOColorSpace_StructSize;

	public FOpenColorIOColorSpace Copy()
	{
		return this;
	}

	public static FOpenColorIOColorSpace FromNative(IntPtr nativeBuffer)
	{
		return new FOpenColorIOColorSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOpenColorIOColorSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOpenColorIOColorSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOpenColorIOColorSpace(nativeBuffer + arrayIndex * FOpenColorIOColorSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOpenColorIOColorSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOpenColorIOColorSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOpenColorIOColorSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIOColorSpace");
		}
	}

	public FOpenColorIOColorSpace(IntPtr nativeStruct)
	{
		if (!FOpenColorIOColorSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIOColorSpace");
		}
	}

	static FOpenColorIOColorSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOpenColorIOColorSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOpenColorIOColorSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OpenColorIO.OpenColorIOColorSpace");
		FOpenColorIOColorSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FOpenColorIOColorSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/OpenColorIO.OpenColorIOColorSpace", FOpenColorIOColorSpace_IsValid);
	}
}
