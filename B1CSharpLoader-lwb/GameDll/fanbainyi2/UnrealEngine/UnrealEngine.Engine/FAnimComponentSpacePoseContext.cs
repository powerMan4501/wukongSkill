using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimComponentSpacePoseContext", "Engine", UnrealModuleType.Engine)]
public struct FAnimComponentSpacePoseContext
{
	private static bool FAnimComponentSpacePoseContext_IsValid;

	private static int FAnimComponentSpacePoseContext_StructSize;

	public FAnimComponentSpacePoseContext Copy()
	{
		return this;
	}

	public static FAnimComponentSpacePoseContext FromNative(IntPtr nativeBuffer)
	{
		return new FAnimComponentSpacePoseContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimComponentSpacePoseContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimComponentSpacePoseContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimComponentSpacePoseContext(nativeBuffer + arrayIndex * FAnimComponentSpacePoseContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimComponentSpacePoseContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimComponentSpacePoseContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimComponentSpacePoseContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimComponentSpacePoseContext");
		}
	}

	public FAnimComponentSpacePoseContext(IntPtr nativeStruct)
	{
		if (!FAnimComponentSpacePoseContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimComponentSpacePoseContext");
		}
	}

	static FAnimComponentSpacePoseContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimComponentSpacePoseContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimComponentSpacePoseContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimComponentSpacePoseContext");
		FAnimComponentSpacePoseContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimComponentSpacePoseContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimComponentSpacePoseContext", FAnimComponentSpacePoseContext_IsValid);
	}
}
