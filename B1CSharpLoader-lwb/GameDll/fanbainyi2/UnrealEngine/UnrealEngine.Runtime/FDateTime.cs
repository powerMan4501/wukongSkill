using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 236603)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.DateTime", "CoreUObject", UnrealModuleType.Engine)]
public struct FDateTime
{
	private static bool FDateTime_IsValid;

	private static int FDateTime_StructSize;

	public FDateTime Copy()
	{
		return this;
	}

	public static FDateTime FromNative(IntPtr nativeBuffer)
	{
		return new FDateTime(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDateTime value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDateTime FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDateTime(nativeBuffer + arrayIndex * FDateTime_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDateTime value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDateTime_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDateTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.DateTime");
		}
	}

	public FDateTime(IntPtr nativeStruct)
	{
		if (!FDateTime_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.DateTime");
		}
	}

	static FDateTime()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDateTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDateTime));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.DateTime");
		FDateTime_StructSize = NativeReflection.GetStructSize(intPtr);
		FDateTime_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.DateTime", FDateTime_IsValid);
	}
}
