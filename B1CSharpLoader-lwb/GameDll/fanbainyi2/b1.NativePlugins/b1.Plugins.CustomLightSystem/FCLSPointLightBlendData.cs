using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPointLightBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSPointLightBlendData
{
	private static bool FCLSPointLightBlendData_IsValid;

	private static int FCLSPointLightBlendData_StructSize;

	public FCLSPointLightBlendData Copy()
	{
		return this;
	}

	public static FCLSPointLightBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSPointLightBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSPointLightBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSPointLightBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSPointLightBlendData(nativeBuffer + arrayIndex * FCLSPointLightBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSPointLightBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSPointLightBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSPointLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPointLightBlendData");
		}
	}

	public FCLSPointLightBlendData(IntPtr nativeStruct)
	{
		if (!FCLSPointLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPointLightBlendData");
		}
	}

	static FCLSPointLightBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSPointLightBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSPointLightBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSPointLightBlendData");
		FCLSPointLightBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSPointLightBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSPointLightBlendData", FCLSPointLightBlendData_IsValid);
	}
}
