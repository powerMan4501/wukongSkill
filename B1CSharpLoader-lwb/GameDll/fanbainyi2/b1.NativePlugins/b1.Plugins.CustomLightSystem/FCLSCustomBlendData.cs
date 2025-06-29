using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSCustomBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSCustomBlendData
{
	private static bool FCLSCustomBlendData_IsValid;

	private static int FCLSCustomBlendData_StructSize;

	public FCLSCustomBlendData Copy()
	{
		return this;
	}

	public static FCLSCustomBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSCustomBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSCustomBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSCustomBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSCustomBlendData(nativeBuffer + arrayIndex * FCLSCustomBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSCustomBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSCustomBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSCustomBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSCustomBlendData");
		}
	}

	public FCLSCustomBlendData(IntPtr nativeStruct)
	{
		if (!FCLSCustomBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSCustomBlendData");
		}
	}

	static FCLSCustomBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSCustomBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSCustomBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSCustomBlendData");
		FCLSCustomBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSCustomBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSCustomBlendData", FCLSCustomBlendData_IsValid);
	}
}
