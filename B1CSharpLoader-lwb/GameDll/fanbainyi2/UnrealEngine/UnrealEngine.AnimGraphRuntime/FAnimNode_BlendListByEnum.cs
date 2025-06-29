using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendListByEnum
{
	private static bool FAnimNode_BlendListByEnum_IsValid;

	private static int FAnimNode_BlendListByEnum_StructSize;

	public FAnimNode_BlendListByEnum Copy()
	{
		return this;
	}

	public static FAnimNode_BlendListByEnum FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendListByEnum(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendListByEnum value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendListByEnum FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendListByEnum(nativeBuffer + arrayIndex * FAnimNode_BlendListByEnum_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendListByEnum value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendListByEnum_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByEnum_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum");
		}
	}

	public FAnimNode_BlendListByEnum(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByEnum_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum");
		}
	}

	static FAnimNode_BlendListByEnum()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendListByEnum)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendListByEnum));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum");
		FAnimNode_BlendListByEnum_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_BlendListByEnum_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendListByEnum", FAnimNode_BlendListByEnum_IsValid);
	}
}
