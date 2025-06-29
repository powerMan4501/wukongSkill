using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.MeshReductionArray", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public struct FMeshReductionArray
{
	private static bool FMeshReductionArray_IsValid;

	private static int FMeshReductionArray_StructSize;

	public FMeshReductionArray Copy()
	{
		return this;
	}

	public static FMeshReductionArray FromNative(IntPtr nativeBuffer)
	{
		return new FMeshReductionArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshReductionArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshReductionArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshReductionArray(nativeBuffer + arrayIndex * FMeshReductionArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshReductionArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshReductionArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshReductionArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MeshReductionArray");
		}
	}

	public FMeshReductionArray(IntPtr nativeStruct)
	{
		if (!FMeshReductionArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepLibraries.MeshReductionArray");
		}
	}

	static FMeshReductionArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshReductionArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshReductionArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepLibraries.MeshReductionArray");
		FMeshReductionArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FMeshReductionArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/DataprepLibraries.MeshReductionArray", FMeshReductionArray_IsValid);
	}
}
