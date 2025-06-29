using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSSkyLightBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSSkyLightBlendData
{
	private static bool FCLSSkyLightBlendData_IsValid;

	private static int FCLSSkyLightBlendData_StructSize;

	public FCLSSkyLightBlendData Copy()
	{
		return this;
	}

	public static FCLSSkyLightBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSSkyLightBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSSkyLightBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSSkyLightBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSSkyLightBlendData(nativeBuffer + arrayIndex * FCLSSkyLightBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSSkyLightBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSSkyLightBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSSkyLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSSkyLightBlendData");
		}
	}

	public FCLSSkyLightBlendData(IntPtr nativeStruct)
	{
		if (!FCLSSkyLightBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSSkyLightBlendData");
		}
	}

	static FCLSSkyLightBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSSkyLightBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSSkyLightBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSSkyLightBlendData");
		FCLSSkyLightBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSSkyLightBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSSkyLightBlendData", FCLSSkyLightBlendData_IsValid);
	}
}
