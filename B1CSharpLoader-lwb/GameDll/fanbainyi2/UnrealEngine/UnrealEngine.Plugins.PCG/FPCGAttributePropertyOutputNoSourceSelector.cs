using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributePropertyOutputNoSourceSelector", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGAttributePropertyOutputNoSourceSelector
{
	private static bool FPCGAttributePropertyOutputNoSourceSelector_IsValid;

	private static int FPCGAttributePropertyOutputNoSourceSelector_StructSize;

	public FPCGAttributePropertyOutputNoSourceSelector Copy()
	{
		return this;
	}

	public static FPCGAttributePropertyOutputNoSourceSelector FromNative(IntPtr nativeBuffer)
	{
		return new FPCGAttributePropertyOutputNoSourceSelector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGAttributePropertyOutputNoSourceSelector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGAttributePropertyOutputNoSourceSelector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGAttributePropertyOutputNoSourceSelector(nativeBuffer + arrayIndex * FPCGAttributePropertyOutputNoSourceSelector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGAttributePropertyOutputNoSourceSelector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGAttributePropertyOutputNoSourceSelector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyOutputNoSourceSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyOutputNoSourceSelector");
		}
	}

	public FPCGAttributePropertyOutputNoSourceSelector(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyOutputNoSourceSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyOutputNoSourceSelector");
		}
	}

	static FPCGAttributePropertyOutputNoSourceSelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGAttributePropertyOutputNoSourceSelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGAttributePropertyOutputNoSourceSelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGAttributePropertyOutputNoSourceSelector");
		FPCGAttributePropertyOutputNoSourceSelector_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGAttributePropertyOutputNoSourceSelector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGAttributePropertyOutputNoSourceSelector", FPCGAttributePropertyOutputNoSourceSelector_IsValid);
	}
}
