using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSOtherBlendData", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSOtherBlendData
{
	private static bool FCLSOtherBlendData_IsValid;

	private static int FCLSOtherBlendData_StructSize;

	public FCLSOtherBlendData Copy()
	{
		return this;
	}

	public static FCLSOtherBlendData FromNative(IntPtr nativeBuffer)
	{
		return new FCLSOtherBlendData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSOtherBlendData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSOtherBlendData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSOtherBlendData(nativeBuffer + arrayIndex * FCLSOtherBlendData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSOtherBlendData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSOtherBlendData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSOtherBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSOtherBlendData");
		}
	}

	public FCLSOtherBlendData(IntPtr nativeStruct)
	{
		if (!FCLSOtherBlendData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSOtherBlendData");
		}
	}

	static FCLSOtherBlendData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSOtherBlendData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSOtherBlendData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSOtherBlendData");
		FCLSOtherBlendData_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSOtherBlendData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSOtherBlendData", FCLSOtherBlendData_IsValid);
	}
}
