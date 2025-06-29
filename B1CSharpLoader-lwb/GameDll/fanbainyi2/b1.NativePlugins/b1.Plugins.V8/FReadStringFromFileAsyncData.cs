using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.ReadStringFromFileAsyncData", "V8", UnrealModuleType.GamePlugin)]
public struct FReadStringFromFileAsyncData
{
	private static bool FReadStringFromFileAsyncData_IsValid;

	private static int FReadStringFromFileAsyncData_StructSize;

	public FReadStringFromFileAsyncData Copy()
	{
		return this;
	}

	public static FReadStringFromFileAsyncData FromNative(IntPtr nativeBuffer)
	{
		return new FReadStringFromFileAsyncData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FReadStringFromFileAsyncData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FReadStringFromFileAsyncData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FReadStringFromFileAsyncData(nativeBuffer + arrayIndex * FReadStringFromFileAsyncData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FReadStringFromFileAsyncData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FReadStringFromFileAsyncData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FReadStringFromFileAsyncData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.ReadStringFromFileAsyncData");
		}
	}

	public FReadStringFromFileAsyncData(IntPtr nativeStruct)
	{
		if (!FReadStringFromFileAsyncData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.ReadStringFromFileAsyncData");
		}
	}

	static FReadStringFromFileAsyncData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FReadStringFromFileAsyncData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FReadStringFromFileAsyncData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.ReadStringFromFileAsyncData");
		FReadStringFromFileAsyncData_StructSize = NativeReflection.GetStructSize(intPtr);
		FReadStringFromFileAsyncData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.ReadStringFromFileAsyncData", FReadStringFromFileAsyncData_IsValid);
	}
}
