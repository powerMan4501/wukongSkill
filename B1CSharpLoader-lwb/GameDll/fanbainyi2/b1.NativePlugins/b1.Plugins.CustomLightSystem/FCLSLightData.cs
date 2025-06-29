using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSLightData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSLightData
{
	private static bool FCLSLightData_IsValid;

	private static int FCLSLightData_StructSize;

	public FCLSLightData Copy()
	{
		return this;
	}

	public static FCLSLightData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSLightData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSLightData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSLightData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSLightData(nativeBuffer + arrayIndex * FCLSLightData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSLightData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSLightData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSLightData");
		}
	}

	public FCLSLightData(IntPtr nativeStruct)
	{
		if (!FCLSLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSLightData");
		}
	}

	static FCLSLightData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSLightData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSLightData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSLightData");
		FCLSLightData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSLightData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSLightData", FCLSLightData_IsValid);
	}
}
