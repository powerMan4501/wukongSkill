using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.MeshReductionOptions", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public struct FMeshReductionOptions
{
	private static bool FMeshReductionOptions_IsValid;

	private static int FMeshReductionOptions_StructSize;

	public FMeshReductionOptions Copy()
	{
		return this;
	}

	public static FMeshReductionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FMeshReductionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshReductionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshReductionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshReductionOptions(nativeBuffer + arrayIndex * FMeshReductionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshReductionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshReductionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshReductionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MeshReductionOptions");
		}
	}

	public FMeshReductionOptions(IntPtr nativeStruct)
	{
		if (!FMeshReductionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MeshReductionOptions");
		}
	}

	static FMeshReductionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshReductionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshReductionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepLibraries.MeshReductionOptions");
		FMeshReductionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		FMeshReductionOptions_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/DataprepLibraries.MeshReductionOptions", FMeshReductionOptions_IsValid);
	}
}
