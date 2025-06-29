using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendListBase", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendListBase
{
	private static bool FAnimNode_BlendListBase_IsValid;

	private static int FAnimNode_BlendListBase_StructSize;

	public FAnimNode_BlendListBase Copy()
	{
		return this;
	}

	public static FAnimNode_BlendListBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendListBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendListBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendListBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendListBase(nativeBuffer + arrayIndex * FAnimNode_BlendListBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendListBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendListBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListBase");
		}
	}

	public FAnimNode_BlendListBase(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListBase");
		}
	}

	static FAnimNode_BlendListBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendListBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendListBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendListBase");
		FAnimNode_BlendListBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_BlendListBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendListBase", FAnimNode_BlendListBase_IsValid);
	}
}
