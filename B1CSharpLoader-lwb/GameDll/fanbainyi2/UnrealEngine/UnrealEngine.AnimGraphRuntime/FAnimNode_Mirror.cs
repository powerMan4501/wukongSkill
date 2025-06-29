using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Mirror", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_Mirror
{
	private static bool FAnimNode_Mirror_IsValid;

	private static int FAnimNode_Mirror_StructSize;

	public FAnimNode_Mirror Copy()
	{
		return this;
	}

	public static FAnimNode_Mirror FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Mirror(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Mirror value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Mirror FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Mirror(nativeBuffer + arrayIndex * FAnimNode_Mirror_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Mirror value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Mirror_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Mirror_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Mirror");
		}
	}

	public FAnimNode_Mirror(IntPtr nativeStruct)
	{
		if (!FAnimNode_Mirror_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Mirror");
		}
	}

	static FAnimNode_Mirror()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Mirror)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Mirror));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_Mirror");
		FAnimNode_Mirror_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_Mirror_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_Mirror", FAnimNode_Mirror_IsValid);
	}
}
