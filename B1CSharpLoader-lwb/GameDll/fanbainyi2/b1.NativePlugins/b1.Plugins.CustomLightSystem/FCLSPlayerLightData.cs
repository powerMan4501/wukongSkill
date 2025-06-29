using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSPlayerLightData
{
	private static bool FCLSPlayerLightData_IsValid;

	private static int FCLSPlayerLightData_StructSize;

	public FCLSPlayerLightData Copy()
	{
		return this;
	}

	public static FCLSPlayerLightData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSPlayerLightData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSPlayerLightData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSPlayerLightData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSPlayerLightData(nativeBuffer + arrayIndex * FCLSPlayerLightData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSPlayerLightData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSPlayerLightData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightData");
		}
	}

	public FCLSPlayerLightData(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightData");
		}
	}

	static FCLSPlayerLightData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSPlayerLightData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSPlayerLightData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSPlayerLightData");
		FCLSPlayerLightData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSPlayerLightData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSPlayerLightData", FCLSPlayerLightData_IsValid);
	}
}
