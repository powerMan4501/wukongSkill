using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerContext", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGStaticMeshSpawnerContext
{
	private static bool FPCGStaticMeshSpawnerContext_IsValid;

	private static int FPCGStaticMeshSpawnerContext_StructSize;

	public FPCGStaticMeshSpawnerContext Copy()
	{
		return this;
	}

	public static FPCGStaticMeshSpawnerContext FromNative(IntPtr nativeBuffer)
	{
		return new FPCGStaticMeshSpawnerContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGStaticMeshSpawnerContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGStaticMeshSpawnerContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGStaticMeshSpawnerContext(nativeBuffer + arrayIndex * FPCGStaticMeshSpawnerContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGStaticMeshSpawnerContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGStaticMeshSpawnerContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGStaticMeshSpawnerContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGStaticMeshSpawnerContext");
		}
	}

	public FPCGStaticMeshSpawnerContext(IntPtr nativeStruct)
	{
		if (!FPCGStaticMeshSpawnerContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGStaticMeshSpawnerContext");
		}
	}

	static FPCGStaticMeshSpawnerContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGStaticMeshSpawnerContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGStaticMeshSpawnerContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGStaticMeshSpawnerContext");
		FPCGStaticMeshSpawnerContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGStaticMeshSpawnerContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGStaticMeshSpawnerContext", FPCGStaticMeshSpawnerContext_IsValid);
	}
}
