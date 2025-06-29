using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.IKFootLocation", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FIKFootLocation
{
	private static bool FIKFootLocation_IsValid;

	private static int FIKFootLocation_StructSize;

	public FIKFootLocation Copy()
	{
		return this;
	}

	public static FIKFootLocation FromNative(IntPtr nativeBuffer)
	{
		return new FIKFootLocation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FIKFootLocation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FIKFootLocation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FIKFootLocation(nativeBuffer + arrayIndex * FIKFootLocation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FIKFootLocation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FIKFootLocation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FIKFootLocation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.IKFootLocation");
		}
	}

	public FIKFootLocation(IntPtr nativeStruct)
	{
		if (!FIKFootLocation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.IKFootLocation");
		}
	}

	static FIKFootLocation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIKFootLocation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIKFootLocation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.IKFootLocation");
		FIKFootLocation_StructSize = NativeReflection.GetStructSize(intPtr);
		FIKFootLocation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.IKFootLocation", FIKFootLocation_IsValid);
	}
}
