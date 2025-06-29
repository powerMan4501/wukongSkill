using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimExecutionContext", "Engine", UnrealModuleType.Engine)]
public struct FAnimExecutionContext
{
	private static bool FAnimExecutionContext_IsValid;

	private static int FAnimExecutionContext_StructSize;

	public FAnimExecutionContext Copy()
	{
		return this;
	}

	public static FAnimExecutionContext FromNative(IntPtr nativeBuffer)
	{
		return new FAnimExecutionContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimExecutionContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimExecutionContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimExecutionContext(nativeBuffer + arrayIndex * FAnimExecutionContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimExecutionContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimExecutionContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimExecutionContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimExecutionContext");
		}
	}

	public FAnimExecutionContext(IntPtr nativeStruct)
	{
		if (!FAnimExecutionContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimExecutionContext");
		}
	}

	static FAnimExecutionContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimExecutionContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimExecutionContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimExecutionContext");
		FAnimExecutionContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimExecutionContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimExecutionContext", FAnimExecutionContext_IsValid);
	}
}
