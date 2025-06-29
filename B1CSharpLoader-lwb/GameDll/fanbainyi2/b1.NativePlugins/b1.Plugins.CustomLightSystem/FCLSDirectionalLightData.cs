using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSDirectionalLightData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSDirectionalLightData
{
	private static bool FCLSDirectionalLightData_IsValid;

	private static int FCLSDirectionalLightData_StructSize;

	public FCLSDirectionalLightData Copy()
	{
		return this;
	}

	public static FCLSDirectionalLightData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSDirectionalLightData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSDirectionalLightData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSDirectionalLightData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSDirectionalLightData(nativeBuffer + arrayIndex * FCLSDirectionalLightData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSDirectionalLightData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSDirectionalLightData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSDirectionalLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSDirectionalLightData");
		}
	}

	public FCLSDirectionalLightData(IntPtr nativeStruct)
	{
		if (!FCLSDirectionalLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSDirectionalLightData");
		}
	}

	static FCLSDirectionalLightData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSDirectionalLightData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSDirectionalLightData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSDirectionalLightData");
		FCLSDirectionalLightData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSDirectionalLightData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSDirectionalLightData", FCLSDirectionalLightData_IsValid);
	}
}
