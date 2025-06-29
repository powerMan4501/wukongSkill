using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.AxisSettings", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FAxisSettings
{
	private static bool FAxisSettings_IsValid;

	private static int FAxisSettings_StructSize;

	public FAxisSettings Copy()
	{
		return this;
	}

	public static FAxisSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAxisSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAxisSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAxisSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAxisSettings(nativeBuffer + arrayIndex * FAxisSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAxisSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAxisSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAxisSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AxisSettings");
		}
	}

	public FAxisSettings(IntPtr nativeStruct)
	{
		if (!FAxisSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AxisSettings");
		}
	}

	static FAxisSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAxisSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAxisSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.AxisSettings");
		FAxisSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FAxisSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.AxisSettings", FAxisSettings_IsValid);
	}
}
