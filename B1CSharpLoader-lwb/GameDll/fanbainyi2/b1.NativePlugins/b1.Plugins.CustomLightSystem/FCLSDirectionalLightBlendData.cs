using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSDirectionalLightBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSDirectionalLightBlendData
{
	private static bool FCLSDirectionalLightBlendData_IsValid;

	private static int FCLSDirectionalLightBlendData_StructSize;

	public FCLSDirectionalLightBlendData Copy()
	{
		return this;
	}

	public static FCLSDirectionalLightBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSDirectionalLightBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSDirectionalLightBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSDirectionalLightBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSDirectionalLightBlendData(nativeBuffer + arrayIndex * FCLSDirectionalLightBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSDirectionalLightBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSDirectionalLightBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSDirectionalLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSDirectionalLightBlendData");
		}
	}

	public FCLSDirectionalLightBlendData(IntPtr nativeStruct)
	{
		if (!FCLSDirectionalLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSDirectionalLightBlendData");
		}
	}

	static FCLSDirectionalLightBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSDirectionalLightBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSDirectionalLightBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSDirectionalLightBlendData");
		FCLSDirectionalLightBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSDirectionalLightBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSDirectionalLightBlendData", FCLSDirectionalLightBlendData_IsValid);
	}
}
