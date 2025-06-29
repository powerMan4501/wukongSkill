using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.ComparisonToleranceAmount", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FComparisonToleranceAmount
{
	private static bool FComparisonToleranceAmount_IsValid;

	private static int FComparisonToleranceAmount_StructSize;

	public FComparisonToleranceAmount Copy()
	{
		return this;
	}

	public static FComparisonToleranceAmount FromNative(IntPtr nativeBuffer)
	{
		return new FComparisonToleranceAmount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComparisonToleranceAmount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComparisonToleranceAmount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComparisonToleranceAmount(nativeBuffer + arrayIndex * FComparisonToleranceAmount_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComparisonToleranceAmount value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComparisonToleranceAmount_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComparisonToleranceAmount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.ComparisonToleranceAmount");
		}
	}

	public FComparisonToleranceAmount(IntPtr nativeStruct)
	{
		if (!FComparisonToleranceAmount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.ComparisonToleranceAmount");
		}
	}

	static FComparisonToleranceAmount()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComparisonToleranceAmount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComparisonToleranceAmount));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.ComparisonToleranceAmount");
		FComparisonToleranceAmount_StructSize = NativeReflection.GetStructSize(intPtr);
		FComparisonToleranceAmount_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.ComparisonToleranceAmount", FComparisonToleranceAmount_IsValid);
	}
}
