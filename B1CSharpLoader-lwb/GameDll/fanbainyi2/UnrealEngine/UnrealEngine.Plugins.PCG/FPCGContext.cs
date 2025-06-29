using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGContext", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGContext
{
	private static bool FPCGContext_IsValid;

	private static int FPCGContext_StructSize;

	public FPCGContext Copy()
	{
		return this;
	}

	public static FPCGContext FromNative(IntPtr nativeBuffer)
	{
		return new FPCGContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGContext(nativeBuffer + arrayIndex * FPCGContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGContext");
		}
	}

	public FPCGContext(IntPtr nativeStruct)
	{
		if (!FPCGContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGContext");
		}
	}

	static FPCGContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGContext");
		FPCGContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGContext", FPCGContext_IsValid);
	}
}
