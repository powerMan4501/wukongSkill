using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributePropertySelector", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGAttributePropertySelector
{
	private static bool FPCGAttributePropertySelector_IsValid;

	private static int FPCGAttributePropertySelector_StructSize;

	public FPCGAttributePropertySelector Copy()
	{
		return this;
	}

	public static FPCGAttributePropertySelector FromNative(IntPtr nativeBuffer)
	{
		return new FPCGAttributePropertySelector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGAttributePropertySelector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGAttributePropertySelector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGAttributePropertySelector(nativeBuffer + arrayIndex * FPCGAttributePropertySelector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGAttributePropertySelector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGAttributePropertySelector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertySelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertySelector");
		}
	}

	public FPCGAttributePropertySelector(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertySelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertySelector");
		}
	}

	static FPCGAttributePropertySelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGAttributePropertySelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGAttributePropertySelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGAttributePropertySelector");
		FPCGAttributePropertySelector_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGAttributePropertySelector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGAttributePropertySelector", FPCGAttributePropertySelector_IsValid);
	}
}
