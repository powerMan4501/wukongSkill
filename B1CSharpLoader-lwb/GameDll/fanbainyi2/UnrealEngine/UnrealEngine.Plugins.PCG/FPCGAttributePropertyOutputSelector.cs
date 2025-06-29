using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 528897)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributePropertyOutputSelector", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGAttributePropertyOutputSelector
{
	private static bool FPCGAttributePropertyOutputSelector_IsValid;

	private static int FPCGAttributePropertyOutputSelector_StructSize;

	public FPCGAttributePropertyOutputSelector Copy()
	{
		return this;
	}

	public static FPCGAttributePropertyOutputSelector FromNative(IntPtr nativeBuffer)
	{
		return new FPCGAttributePropertyOutputSelector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGAttributePropertyOutputSelector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGAttributePropertyOutputSelector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGAttributePropertyOutputSelector(nativeBuffer + arrayIndex * FPCGAttributePropertyOutputSelector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGAttributePropertyOutputSelector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGAttributePropertyOutputSelector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyOutputSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyOutputSelector");
		}
	}

	public FPCGAttributePropertyOutputSelector(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyOutputSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyOutputSelector");
		}
	}

	static FPCGAttributePropertyOutputSelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGAttributePropertyOutputSelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGAttributePropertyOutputSelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGAttributePropertyOutputSelector");
		FPCGAttributePropertyOutputSelector_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGAttributePropertyOutputSelector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGAttributePropertyOutputSelector", FPCGAttributePropertyOutputSelector_IsValid);
	}
}
