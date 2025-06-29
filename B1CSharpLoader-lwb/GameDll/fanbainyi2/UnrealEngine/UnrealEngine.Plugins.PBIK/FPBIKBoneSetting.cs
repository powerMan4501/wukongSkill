using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PBIK;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PBIK.PBIKBoneSetting", "PBIK", UnrealModuleType.EnginePlugin)]
public struct FPBIKBoneSetting
{
	private static bool FPBIKBoneSetting_IsValid;

	private static int FPBIKBoneSetting_StructSize;

	public FPBIKBoneSetting Copy()
	{
		return this;
	}

	public static FPBIKBoneSetting FromNative(IntPtr nativeBuffer)
	{
		return new FPBIKBoneSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPBIKBoneSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPBIKBoneSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPBIKBoneSetting(nativeBuffer + arrayIndex * FPBIKBoneSetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPBIKBoneSetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPBIKBoneSetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPBIKBoneSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.PBIKBoneSetting");
		}
	}

	public FPBIKBoneSetting(IntPtr nativeStruct)
	{
		if (!FPBIKBoneSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.PBIKBoneSetting");
		}
	}

	static FPBIKBoneSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPBIKBoneSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPBIKBoneSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PBIK.PBIKBoneSetting");
		FPBIKBoneSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		FPBIKBoneSetting_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PBIK.PBIKBoneSetting", FPBIKBoneSetting_IsValid);
	}
}
