using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSHeightFogBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSHeightFogBlendData
{
	private static bool FCLSHeightFogBlendData_IsValid;

	private static int FCLSHeightFogBlendData_StructSize;

	public FCLSHeightFogBlendData Copy()
	{
		return this;
	}

	public static FCLSHeightFogBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSHeightFogBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSHeightFogBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSHeightFogBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSHeightFogBlendData(nativeBuffer + arrayIndex * FCLSHeightFogBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSHeightFogBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSHeightFogBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSHeightFogBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSHeightFogBlendData");
		}
	}

	public FCLSHeightFogBlendData(IntPtr nativeStruct)
	{
		if (!FCLSHeightFogBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSHeightFogBlendData");
		}
	}

	static FCLSHeightFogBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSHeightFogBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSHeightFogBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSHeightFogBlendData");
		FCLSHeightFogBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSHeightFogBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSHeightFogBlendData", FCLSHeightFogBlendData_IsValid);
	}
}
