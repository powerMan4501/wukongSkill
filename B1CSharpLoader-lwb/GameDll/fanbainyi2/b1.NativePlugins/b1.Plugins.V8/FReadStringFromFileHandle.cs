using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.ReadStringFromFileHandle", "V8", UnrealModuleType.GamePlugin)]
public struct FReadStringFromFileHandle
{
	private static bool FReadStringFromFileHandle_IsValid;

	private static int FReadStringFromFileHandle_StructSize;

	public FReadStringFromFileHandle Copy()
	{
		return this;
	}

	public static FReadStringFromFileHandle FromNative(IntPtr nativeBuffer)
	{
		return new FReadStringFromFileHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FReadStringFromFileHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FReadStringFromFileHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FReadStringFromFileHandle(nativeBuffer + arrayIndex * FReadStringFromFileHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FReadStringFromFileHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FReadStringFromFileHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FReadStringFromFileHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.ReadStringFromFileHandle");
		}
	}

	public FReadStringFromFileHandle(IntPtr nativeStruct)
	{
		if (!FReadStringFromFileHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.ReadStringFromFileHandle");
		}
	}

	static FReadStringFromFileHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FReadStringFromFileHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FReadStringFromFileHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.ReadStringFromFileHandle");
		FReadStringFromFileHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FReadStringFromFileHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.ReadStringFromFileHandle", FReadStringFromFileHandle_IsValid);
	}
}
