using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSMpcData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSMpcData
{
	private static bool FCLSMpcData_IsValid;

	private static int FCLSMpcData_StructSize;

	public FCLSMpcData Copy()
	{
		return this;
	}

	public static FCLSMpcData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSMpcData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSMpcData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSMpcData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSMpcData(nativeBuffer + arrayIndex * FCLSMpcData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSMpcData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSMpcData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSMpcData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMpcData");
		}
	}

	public FCLSMpcData(IntPtr nativeStruct)
	{
		if (!FCLSMpcData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMpcData");
		}
	}

	static FCLSMpcData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSMpcData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSMpcData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSMpcData");
		FCLSMpcData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSMpcData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSMpcData", FCLSMpcData_IsValid);
	}
}
