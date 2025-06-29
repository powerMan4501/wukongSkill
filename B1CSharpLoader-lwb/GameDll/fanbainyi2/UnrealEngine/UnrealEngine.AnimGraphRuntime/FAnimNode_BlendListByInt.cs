using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendListByInt", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendListByInt
{
	private static bool FAnimNode_BlendListByInt_IsValid;

	private static int FAnimNode_BlendListByInt_StructSize;

	public FAnimNode_BlendListByInt Copy()
	{
		return this;
	}

	public static FAnimNode_BlendListByInt FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendListByInt(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendListByInt value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendListByInt FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendListByInt(nativeBuffer + arrayIndex * FAnimNode_BlendListByInt_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendListByInt value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendListByInt_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByInt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByInt");
		}
	}

	public FAnimNode_BlendListByInt(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByInt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByInt");
		}
	}

	static FAnimNode_BlendListByInt()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendListByInt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendListByInt));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByInt");
		FAnimNode_BlendListByInt_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_BlendListByInt_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendListByInt", FAnimNode_BlendListByInt_IsValid);
	}
}
