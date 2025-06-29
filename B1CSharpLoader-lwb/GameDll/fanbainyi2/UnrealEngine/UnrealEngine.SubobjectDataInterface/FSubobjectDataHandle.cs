using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.SubobjectDataInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SubobjectDataInterface.SubobjectDataHandle", "SubobjectDataInterface", UnrealModuleType.Engine)]
public struct FSubobjectDataHandle
{
	private static bool FSubobjectDataHandle_IsValid;

	private static int FSubobjectDataHandle_StructSize;

	public FSubobjectDataHandle Copy()
	{
		return this;
	}

	public static FSubobjectDataHandle FromNative(IntPtr nativeBuffer)
	{
		return new FSubobjectDataHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubobjectDataHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubobjectDataHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubobjectDataHandle(nativeBuffer + arrayIndex * FSubobjectDataHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubobjectDataHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubobjectDataHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubobjectDataHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.SubobjectDataHandle");
		}
	}

	public FSubobjectDataHandle(IntPtr nativeStruct)
	{
		if (!FSubobjectDataHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.SubobjectDataHandle");
		}
	}

	static FSubobjectDataHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubobjectDataHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubobjectDataHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SubobjectDataInterface.SubobjectDataHandle");
		FSubobjectDataHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FSubobjectDataHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SubobjectDataInterface.SubobjectDataHandle", FSubobjectDataHandle_IsValid);
	}
}
