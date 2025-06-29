using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[UMetaPath("/Script/Engine.PlatformInterfaceDelegateResult", "Engine", UnrealModuleType.Engine)]
public struct FPlatformInterfaceDelegateResult
{
	private static bool FPlatformInterfaceDelegateResult_IsValid;

	private static int FPlatformInterfaceDelegateResult_StructSize;

	public FPlatformInterfaceDelegateResult Copy()
	{
		return this;
	}

	public static FPlatformInterfaceDelegateResult FromNative(IntPtr nativeBuffer)
	{
		return new FPlatformInterfaceDelegateResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPlatformInterfaceDelegateResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPlatformInterfaceDelegateResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPlatformInterfaceDelegateResult(nativeBuffer + arrayIndex * FPlatformInterfaceDelegateResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPlatformInterfaceDelegateResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPlatformInterfaceDelegateResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPlatformInterfaceDelegateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PlatformInterfaceDelegateResult");
		}
	}

	public FPlatformInterfaceDelegateResult(IntPtr nativeStruct)
	{
		if (!FPlatformInterfaceDelegateResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PlatformInterfaceDelegateResult");
		}
	}

	static FPlatformInterfaceDelegateResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPlatformInterfaceDelegateResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlatformInterfaceDelegateResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PlatformInterfaceDelegateResult");
		FPlatformInterfaceDelegateResult_StructSize = NativeReflection.GetStructSize(intPtr);
		FPlatformInterfaceDelegateResult_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PlatformInterfaceDelegateResult", FPlatformInterfaceDelegateResult_IsValid);
	}
}
