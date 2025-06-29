using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AlphaBlend", "Engine", UnrealModuleType.Engine)]
public struct FAlphaBlend
{
	private static bool FAlphaBlend_IsValid;

	private static int FAlphaBlend_StructSize;

	public FAlphaBlend Copy()
	{
		return this;
	}

	public static FAlphaBlend FromNative(IntPtr nativeBuffer)
	{
		return new FAlphaBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAlphaBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAlphaBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAlphaBlend(nativeBuffer + arrayIndex * FAlphaBlend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAlphaBlend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAlphaBlend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAlphaBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AlphaBlend");
		}
	}

	public FAlphaBlend(IntPtr nativeStruct)
	{
		if (!FAlphaBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AlphaBlend");
		}
	}

	static FAlphaBlend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAlphaBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAlphaBlend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AlphaBlend");
		FAlphaBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		FAlphaBlend_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AlphaBlend", FAlphaBlend_IsValid);
	}
}
