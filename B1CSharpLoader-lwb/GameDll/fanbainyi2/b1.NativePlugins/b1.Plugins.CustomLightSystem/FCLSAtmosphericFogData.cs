using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSAtmosphericFogData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSAtmosphericFogData
{
	private static bool FCLSAtmosphericFogData_IsValid;

	private static int FCLSAtmosphericFogData_StructSize;

	public FCLSAtmosphericFogData Copy()
	{
		return this;
	}

	public static FCLSAtmosphericFogData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSAtmosphericFogData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSAtmosphericFogData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSAtmosphericFogData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSAtmosphericFogData(nativeBuffer + arrayIndex * FCLSAtmosphericFogData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSAtmosphericFogData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSAtmosphericFogData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSAtmosphericFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSAtmosphericFogData");
		}
	}

	public FCLSAtmosphericFogData(IntPtr nativeStruct)
	{
		if (!FCLSAtmosphericFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSAtmosphericFogData");
		}
	}

	static FCLSAtmosphericFogData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSAtmosphericFogData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSAtmosphericFogData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSAtmosphericFogData");
		FCLSAtmosphericFogData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSAtmosphericFogData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSAtmosphericFogData", FCLSAtmosphericFogData_IsValid);
	}
}
