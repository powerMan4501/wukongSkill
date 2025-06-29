using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimPoseContext", "Engine", UnrealModuleType.Engine)]
public struct FAnimPoseContext
{
	private static bool FAnimPoseContext_IsValid;

	private static int FAnimPoseContext_StructSize;

	public FAnimPoseContext Copy()
	{
		return this;
	}

	public static FAnimPoseContext FromNative(IntPtr nativeBuffer)
	{
		return new FAnimPoseContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimPoseContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimPoseContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimPoseContext(nativeBuffer + arrayIndex * FAnimPoseContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimPoseContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimPoseContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimPoseContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimPoseContext");
		}
	}

	public FAnimPoseContext(IntPtr nativeStruct)
	{
		if (!FAnimPoseContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimPoseContext");
		}
	}

	static FAnimPoseContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimPoseContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimPoseContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimPoseContext");
		FAnimPoseContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimPoseContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimPoseContext", FAnimPoseContext_IsValid);
	}
}
