using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.PerBoneBlendWeights", "Engine", UnrealModuleType.Engine)]
public struct FPerBoneBlendWeights
{
	private static bool FPerBoneBlendWeights_IsValid;

	private static int FPerBoneBlendWeights_StructSize;

	public FPerBoneBlendWeights Copy()
	{
		return this;
	}

	public static FPerBoneBlendWeights FromNative(IntPtr nativeBuffer)
	{
		return new FPerBoneBlendWeights(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerBoneBlendWeights value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerBoneBlendWeights FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerBoneBlendWeights(nativeBuffer + arrayIndex * FPerBoneBlendWeights_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerBoneBlendWeights value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPerBoneBlendWeights_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPerBoneBlendWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PerBoneBlendWeights");
		}
	}

	public FPerBoneBlendWeights(IntPtr nativeStruct)
	{
		if (!FPerBoneBlendWeights_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PerBoneBlendWeights");
		}
	}

	static FPerBoneBlendWeights()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPerBoneBlendWeights)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerBoneBlendWeights));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PerBoneBlendWeights");
		FPerBoneBlendWeights_StructSize = NativeReflection.GetStructSize(intPtr);
		FPerBoneBlendWeights_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PerBoneBlendWeights", FPerBoneBlendWeights_IsValid);
	}
}
