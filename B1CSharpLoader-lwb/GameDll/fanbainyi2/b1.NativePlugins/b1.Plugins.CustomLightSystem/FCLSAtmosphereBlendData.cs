using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSAtmosphereBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSAtmosphereBlendData
{
	private static bool FCLSAtmosphereBlendData_IsValid;

	private static int FCLSAtmosphereBlendData_StructSize;

	public FCLSAtmosphereBlendData Copy()
	{
		return this;
	}

	public static FCLSAtmosphereBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSAtmosphereBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSAtmosphereBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSAtmosphereBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSAtmosphereBlendData(nativeBuffer + arrayIndex * FCLSAtmosphereBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSAtmosphereBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSAtmosphereBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSAtmosphereBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSAtmosphereBlendData");
		}
	}

	public FCLSAtmosphereBlendData(IntPtr nativeStruct)
	{
		if (!FCLSAtmosphereBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSAtmosphereBlendData");
		}
	}

	static FCLSAtmosphereBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSAtmosphereBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSAtmosphereBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSAtmosphereBlendData");
		FCLSAtmosphereBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSAtmosphereBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSAtmosphereBlendData", FCLSAtmosphereBlendData_IsValid);
	}
}
