using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendListByBool", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendListByBool
{
	private static bool FAnimNode_BlendListByBool_IsValid;

	private static int FAnimNode_BlendListByBool_StructSize;

	public FAnimNode_BlendListByBool Copy()
	{
		return this;
	}

	public static FAnimNode_BlendListByBool FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendListByBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendListByBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendListByBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendListByBool(nativeBuffer + arrayIndex * FAnimNode_BlendListByBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendListByBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendListByBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByBool");
		}
	}

	public FAnimNode_BlendListByBool(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendListByBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendListByBool");
		}
	}

	static FAnimNode_BlendListByBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendListByBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendListByBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendListByBool");
		FAnimNode_BlendListByBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_BlendListByBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendListByBool", FAnimNode_BlendListByBool_IsValid);
	}
}
