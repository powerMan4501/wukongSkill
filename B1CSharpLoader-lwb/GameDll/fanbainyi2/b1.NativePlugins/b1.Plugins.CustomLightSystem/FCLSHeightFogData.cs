using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSHeightFogData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSHeightFogData
{
	private static bool FCLSHeightFogData_IsValid;

	private static int FCLSHeightFogData_StructSize;

	public FCLSHeightFogData Copy()
	{
		return this;
	}

	public static FCLSHeightFogData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSHeightFogData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSHeightFogData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSHeightFogData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSHeightFogData(nativeBuffer + arrayIndex * FCLSHeightFogData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSHeightFogData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSHeightFogData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSHeightFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSHeightFogData");
		}
	}

	public FCLSHeightFogData(IntPtr nativeStruct)
	{
		if (!FCLSHeightFogData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSHeightFogData");
		}
	}

	static FCLSHeightFogData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSHeightFogData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSHeightFogData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSHeightFogData");
		FCLSHeightFogData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSHeightFogData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSHeightFogData", FCLSHeightFogData_IsValid);
	}
}
