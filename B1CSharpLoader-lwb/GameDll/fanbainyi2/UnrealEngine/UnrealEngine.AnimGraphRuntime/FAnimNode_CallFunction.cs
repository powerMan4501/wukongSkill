using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CallFunction", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_CallFunction
{
	private static bool FAnimNode_CallFunction_IsValid;

	private static int FAnimNode_CallFunction_StructSize;

	public FAnimNode_CallFunction Copy()
	{
		return this;
	}

	public static FAnimNode_CallFunction FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_CallFunction(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_CallFunction value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_CallFunction FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_CallFunction(nativeBuffer + arrayIndex * FAnimNode_CallFunction_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_CallFunction value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_CallFunction_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_CallFunction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CallFunction");
		}
	}

	public FAnimNode_CallFunction(IntPtr nativeStruct)
	{
		if (!FAnimNode_CallFunction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CallFunction");
		}
	}

	static FAnimNode_CallFunction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_CallFunction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_CallFunction));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_CallFunction");
		FAnimNode_CallFunction_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimNode_CallFunction_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_CallFunction", FAnimNode_CallFunction_IsValid);
	}
}
