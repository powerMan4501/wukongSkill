using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSBlendDataBase", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSBlendDataBase
{
	private static bool FCLSBlendDataBase_IsValid;

	private static int FCLSBlendDataBase_StructSize;

	public FCLSBlendDataBase Copy()
	{
		return this;
	}

	public static FCLSBlendDataBase FromNative(IntPtr nativeBuffer)
	{
		return new FCLSBlendDataBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSBlendDataBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSBlendDataBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSBlendDataBase(nativeBuffer + arrayIndex * FCLSBlendDataBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSBlendDataBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSBlendDataBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSBlendDataBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSBlendDataBase");
		}
	}

	public FCLSBlendDataBase(IntPtr nativeStruct)
	{
		if (!FCLSBlendDataBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSBlendDataBase");
		}
	}

	static FCLSBlendDataBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSBlendDataBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSBlendDataBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSBlendDataBase");
		FCLSBlendDataBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FCLSBlendDataBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSBlendDataBase", FCLSBlendDataBase_IsValid);
	}
}
