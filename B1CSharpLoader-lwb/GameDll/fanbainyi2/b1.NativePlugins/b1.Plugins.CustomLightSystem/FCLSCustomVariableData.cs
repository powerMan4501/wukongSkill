using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSCustomVariableData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSCustomVariableData
{
	private static bool FCLSCustomVariableData_IsValid;

	private static int FCLSCustomVariableData_StructSize;

	public FCLSCustomVariableData Copy()
	{
		return this;
	}

	public static FCLSCustomVariableData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSCustomVariableData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSCustomVariableData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSCustomVariableData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSCustomVariableData(nativeBuffer + arrayIndex * FCLSCustomVariableData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSCustomVariableData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSCustomVariableData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSCustomVariableData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSCustomVariableData");
		}
	}

	public FCLSCustomVariableData(IntPtr nativeStruct)
	{
		if (!FCLSCustomVariableData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSCustomVariableData");
		}
	}

	static FCLSCustomVariableData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSCustomVariableData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSCustomVariableData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSCustomVariableData");
		FCLSCustomVariableData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSCustomVariableData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSCustomVariableData", FCLSCustomVariableData_IsValid);
	}
}
