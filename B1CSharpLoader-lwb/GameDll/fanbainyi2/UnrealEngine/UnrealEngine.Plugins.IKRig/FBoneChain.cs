using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/IKRig.BoneChain", "IKRig", UnrealModuleType.EnginePlugin)]
public struct FBoneChain
{
	private static bool FBoneChain_IsValid;

	private static int FBoneChain_StructSize;

	public FBoneChain Copy()
	{
		return this;
	}

	public static FBoneChain FromNative(IntPtr nativeBuffer)
	{
		return new FBoneChain(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBoneChain value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBoneChain FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBoneChain(nativeBuffer + arrayIndex * FBoneChain_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBoneChain value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBoneChain_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBoneChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.BoneChain");
		}
	}

	public FBoneChain(IntPtr nativeStruct)
	{
		if (!FBoneChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.BoneChain");
		}
	}

	static FBoneChain()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBoneChain)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoneChain));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/IKRig.BoneChain");
		FBoneChain_StructSize = NativeReflection.GetStructSize(intPtr);
		FBoneChain_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/IKRig.BoneChain", FBoneChain_IsValid);
	}
}
