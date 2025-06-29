using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.JsonUtilities;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 463361)]
[BlueprintType]
[UMetaPath("/Script/JsonUtilities.JsonObjectWrapper", "JsonUtilities", UnrealModuleType.Engine)]
public struct FJsonObjectWrapper
{
	private static bool FJsonObjectWrapper_IsValid;

	private static int FJsonObjectWrapper_StructSize;

	public FJsonObjectWrapper Copy()
	{
		return this;
	}

	public static FJsonObjectWrapper FromNative(IntPtr nativeBuffer)
	{
		return new FJsonObjectWrapper(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJsonObjectWrapper value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJsonObjectWrapper FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJsonObjectWrapper(nativeBuffer + arrayIndex * FJsonObjectWrapper_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJsonObjectWrapper value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJsonObjectWrapper_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJsonObjectWrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JsonUtilities.JsonObjectWrapper");
		}
	}

	public FJsonObjectWrapper(IntPtr nativeStruct)
	{
		if (!FJsonObjectWrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JsonUtilities.JsonObjectWrapper");
		}
	}

	static FJsonObjectWrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJsonObjectWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJsonObjectWrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JsonUtilities.JsonObjectWrapper");
		FJsonObjectWrapper_StructSize = NativeReflection.GetStructSize(intPtr);
		FJsonObjectWrapper_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JsonUtilities.JsonObjectWrapper", FJsonObjectWrapper_IsValid);
	}
}
