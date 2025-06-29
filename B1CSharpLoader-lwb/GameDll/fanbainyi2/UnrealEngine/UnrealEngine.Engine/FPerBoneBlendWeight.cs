using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.PerBoneBlendWeight", "Engine", UnrealModuleType.Engine)]
public struct FPerBoneBlendWeight
{
	private static bool FPerBoneBlendWeight_IsValid;

	private static int FPerBoneBlendWeight_StructSize;

	public FPerBoneBlendWeight Copy()
	{
		return this;
	}

	public static FPerBoneBlendWeight FromNative(IntPtr nativeBuffer)
	{
		return new FPerBoneBlendWeight(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerBoneBlendWeight value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerBoneBlendWeight FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerBoneBlendWeight(nativeBuffer + arrayIndex * FPerBoneBlendWeight_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerBoneBlendWeight value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPerBoneBlendWeight_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPerBoneBlendWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PerBoneBlendWeight");
		}
	}

	public FPerBoneBlendWeight(IntPtr nativeStruct)
	{
		if (!FPerBoneBlendWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PerBoneBlendWeight");
		}
	}

	static FPerBoneBlendWeight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPerBoneBlendWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerBoneBlendWeight));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PerBoneBlendWeight");
		FPerBoneBlendWeight_StructSize = NativeReflection.GetStructSize(intPtr);
		FPerBoneBlendWeight_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PerBoneBlendWeight", FPerBoneBlendWeight_IsValid);
	}
}
