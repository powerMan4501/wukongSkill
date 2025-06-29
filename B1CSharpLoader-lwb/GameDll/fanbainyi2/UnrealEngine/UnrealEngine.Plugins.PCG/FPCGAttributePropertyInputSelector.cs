using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 528897)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGAttributePropertyInputSelector", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGAttributePropertyInputSelector
{
	private static bool FPCGAttributePropertyInputSelector_IsValid;

	private static int FPCGAttributePropertyInputSelector_StructSize;

	public FPCGAttributePropertyInputSelector Copy()
	{
		return this;
	}

	public static FPCGAttributePropertyInputSelector FromNative(IntPtr nativeBuffer)
	{
		return new FPCGAttributePropertyInputSelector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGAttributePropertyInputSelector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGAttributePropertyInputSelector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGAttributePropertyInputSelector(nativeBuffer + arrayIndex * FPCGAttributePropertyInputSelector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGAttributePropertyInputSelector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGAttributePropertyInputSelector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyInputSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyInputSelector");
		}
	}

	public FPCGAttributePropertyInputSelector(IntPtr nativeStruct)
	{
		if (!FPCGAttributePropertyInputSelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGAttributePropertyInputSelector");
		}
	}

	static FPCGAttributePropertyInputSelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGAttributePropertyInputSelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGAttributePropertyInputSelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGAttributePropertyInputSelector");
		FPCGAttributePropertyInputSelector_StructSize = NativeReflection.GetStructSize(intPtr);
		FPCGAttributePropertyInputSelector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGAttributePropertyInputSelector", FPCGAttributePropertyInputSelector_IsValid);
	}
}
