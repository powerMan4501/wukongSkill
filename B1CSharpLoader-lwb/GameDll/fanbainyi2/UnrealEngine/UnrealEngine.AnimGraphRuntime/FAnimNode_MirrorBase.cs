using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_MirrorBase", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_MirrorBase
{
	private static bool FAnimNode_MirrorBase_IsValid;

	private static int FAnimNode_MirrorBase_StructSize;

	public FAnimNode_MirrorBase Copy()
	{
		return this;
	}

	public static FAnimNode_MirrorBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_MirrorBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_MirrorBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_MirrorBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_MirrorBase(nativeBuffer + arrayIndex * FAnimNode_MirrorBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_MirrorBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_MirrorBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_MirrorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MirrorBase");
		}
	}

	public FAnimNode_MirrorBase(IntPtr nativeStruct)
	{
		if (!FAnimNode_MirrorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_MirrorBase");
		}
	}

	static FAnimNode_MirrorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_MirrorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_MirrorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_MirrorBase");
		FAnimNode_MirrorBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_MirrorBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_MirrorBase", FAnimNode_MirrorBase_IsValid);
	}
}
