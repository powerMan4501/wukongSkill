using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SHIrradianceMap", "Engine", UnrealModuleType.Engine)]
public struct FSHIrradianceMap
{
	private static bool FSHIrradianceMap_IsValid;

	private static int FSHIrradianceMap_StructSize;

	public FSHIrradianceMap Copy()
	{
		return this;
	}

	public static FSHIrradianceMap FromNative(IntPtr nativeBuffer)
	{
		return new FSHIrradianceMap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSHIrradianceMap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSHIrradianceMap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSHIrradianceMap(nativeBuffer + arrayIndex * FSHIrradianceMap_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSHIrradianceMap value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSHIrradianceMap_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSHIrradianceMap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SHIrradianceMap");
		}
	}

	public FSHIrradianceMap(IntPtr nativeStruct)
	{
		if (!FSHIrradianceMap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SHIrradianceMap");
		}
	}

	static FSHIrradianceMap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSHIrradianceMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSHIrradianceMap));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SHIrradianceMap");
		FSHIrradianceMap_StructSize = NativeReflection.GetStructSize(intPtr);
		FSHIrradianceMap_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.SHIrradianceMap", FSHIrradianceMap_IsValid);
	}
}
