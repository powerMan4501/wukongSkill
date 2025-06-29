using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.BlendSampleData", "Engine", UnrealModuleType.Engine)]
public struct FBlendSampleData
{
	private static bool FBlendSampleData_IsValid;

	private static int FBlendSampleData_StructSize;

	public FBlendSampleData Copy()
	{
		return this;
	}

	public static FBlendSampleData FromNative(IntPtr nativeBuffer)
	{
		return new FBlendSampleData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlendSampleData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlendSampleData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlendSampleData(nativeBuffer + arrayIndex * FBlendSampleData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlendSampleData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBlendSampleData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBlendSampleData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BlendSampleData");
		}
	}

	public FBlendSampleData(IntPtr nativeStruct)
	{
		if (!FBlendSampleData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BlendSampleData");
		}
	}

	static FBlendSampleData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBlendSampleData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlendSampleData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BlendSampleData");
		FBlendSampleData_StructSize = NativeReflection.GetStructSize(intPtr);
		FBlendSampleData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.BlendSampleData", FBlendSampleData_IsValid);
	}
}
