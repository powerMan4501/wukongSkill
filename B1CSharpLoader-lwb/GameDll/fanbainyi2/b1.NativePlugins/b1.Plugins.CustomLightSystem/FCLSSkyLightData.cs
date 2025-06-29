using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSSkyLightData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSSkyLightData
{
	private static bool FCLSSkyLightData_IsValid;

	private static int FCLSSkyLightData_StructSize;

	public FCLSSkyLightData Copy()
	{
		return this;
	}

	public static FCLSSkyLightData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSSkyLightData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSSkyLightData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSSkyLightData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSSkyLightData(nativeBuffer + arrayIndex * FCLSSkyLightData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSSkyLightData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSSkyLightData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSSkyLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSSkyLightData");
		}
	}

	public FCLSSkyLightData(IntPtr nativeStruct)
	{
		if (!FCLSSkyLightData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSSkyLightData");
		}
	}

	static FCLSSkyLightData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSSkyLightData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSSkyLightData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSSkyLightData");
		FCLSSkyLightData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSSkyLightData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSSkyLightData", FCLSSkyLightData_IsValid);
	}
}
