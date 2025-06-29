using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.BlendBoneByChannelEntry", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FBlendBoneByChannelEntry
{
	private static bool FBlendBoneByChannelEntry_IsValid;

	private static int FBlendBoneByChannelEntry_StructSize;

	public FBlendBoneByChannelEntry Copy()
	{
		return this;
	}

	public static FBlendBoneByChannelEntry FromNative(IntPtr nativeBuffer)
	{
		return new FBlendBoneByChannelEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlendBoneByChannelEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlendBoneByChannelEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlendBoneByChannelEntry(nativeBuffer + arrayIndex * FBlendBoneByChannelEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlendBoneByChannelEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBlendBoneByChannelEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBlendBoneByChannelEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.BlendBoneByChannelEntry");
		}
	}

	public FBlendBoneByChannelEntry(IntPtr nativeStruct)
	{
		if (!FBlendBoneByChannelEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.BlendBoneByChannelEntry");
		}
	}

	static FBlendBoneByChannelEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBlendBoneByChannelEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlendBoneByChannelEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.BlendBoneByChannelEntry");
		FBlendBoneByChannelEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		FBlendBoneByChannelEntry_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.BlendBoneByChannelEntry", FBlendBoneByChannelEntry_IsValid);
	}
}
