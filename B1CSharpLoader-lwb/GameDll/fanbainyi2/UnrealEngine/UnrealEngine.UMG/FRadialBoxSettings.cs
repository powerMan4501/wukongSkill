using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UMG.RadialBoxSettings", "UMG", UnrealModuleType.Engine)]
public struct FRadialBoxSettings
{
	private static bool FRadialBoxSettings_IsValid;

	private static int FRadialBoxSettings_StructSize;

	public FRadialBoxSettings Copy()
	{
		return this;
	}

	public static FRadialBoxSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRadialBoxSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRadialBoxSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRadialBoxSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRadialBoxSettings(nativeBuffer + arrayIndex * FRadialBoxSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRadialBoxSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRadialBoxSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRadialBoxSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RadialBoxSettings");
		}
	}

	public FRadialBoxSettings(IntPtr nativeStruct)
	{
		if (!FRadialBoxSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.RadialBoxSettings");
		}
	}

	static FRadialBoxSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRadialBoxSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRadialBoxSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.RadialBoxSettings");
		FRadialBoxSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FRadialBoxSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UMG.RadialBoxSettings", FRadialBoxSettings_IsValid);
	}
}
