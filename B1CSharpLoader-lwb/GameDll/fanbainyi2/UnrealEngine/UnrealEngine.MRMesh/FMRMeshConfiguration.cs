using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MRMesh;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MRMesh.MRMeshConfiguration", "MRMesh", UnrealModuleType.Engine)]
public struct FMRMeshConfiguration
{
	private static bool FMRMeshConfiguration_IsValid;

	private static int FMRMeshConfiguration_StructSize;

	public FMRMeshConfiguration Copy()
	{
		return this;
	}

	public static FMRMeshConfiguration FromNative(IntPtr nativeBuffer)
	{
		return new FMRMeshConfiguration(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMRMeshConfiguration value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMRMeshConfiguration FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMRMeshConfiguration(nativeBuffer + arrayIndex * FMRMeshConfiguration_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMRMeshConfiguration value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMRMeshConfiguration_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMRMeshConfiguration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MRMesh.MRMeshConfiguration");
		}
	}

	public FMRMeshConfiguration(IntPtr nativeStruct)
	{
		if (!FMRMeshConfiguration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MRMesh.MRMeshConfiguration");
		}
	}

	static FMRMeshConfiguration()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMRMeshConfiguration)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMRMeshConfiguration));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MRMesh.MRMeshConfiguration");
		FMRMeshConfiguration_StructSize = NativeReflection.GetStructSize(intPtr);
		FMRMeshConfiguration_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MRMesh.MRMeshConfiguration", FMRMeshConfiguration_IsValid);
	}
}
