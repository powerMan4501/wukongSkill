using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public struct FHoudiniStaticMeshGenerationProperties
{
	private static bool FHoudiniStaticMeshGenerationProperties_IsValid;

	private static int FHoudiniStaticMeshGenerationProperties_StructSize;

	public FHoudiniStaticMeshGenerationProperties Copy()
	{
		return this;
	}

	public static FHoudiniStaticMeshGenerationProperties FromNative(IntPtr nativeBuffer)
	{
		return new FHoudiniStaticMeshGenerationProperties(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHoudiniStaticMeshGenerationProperties value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHoudiniStaticMeshGenerationProperties FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHoudiniStaticMeshGenerationProperties(nativeBuffer + arrayIndex * FHoudiniStaticMeshGenerationProperties_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHoudiniStaticMeshGenerationProperties value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHoudiniStaticMeshGenerationProperties_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHoudiniStaticMeshGenerationProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties");
		}
	}

	public FHoudiniStaticMeshGenerationProperties(IntPtr nativeStruct)
	{
		if (!FHoudiniStaticMeshGenerationProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties");
		}
	}

	static FHoudiniStaticMeshGenerationProperties()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHoudiniStaticMeshGenerationProperties)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHoudiniStaticMeshGenerationProperties));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties");
		FHoudiniStaticMeshGenerationProperties_StructSize = NativeReflection.GetStructSize(intPtr);
		FHoudiniStaticMeshGenerationProperties_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HoudiniEngineRuntime.HoudiniStaticMeshGenerationProperties", FHoudiniStaticMeshGenerationProperties_IsValid);
	}
}
