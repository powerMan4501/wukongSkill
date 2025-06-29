using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimInitializationContext", "Engine", UnrealModuleType.Engine)]
public struct FAnimInitializationContext
{
	private static bool FAnimInitializationContext_IsValid;

	private static int FAnimInitializationContext_StructSize;

	public FAnimInitializationContext Copy()
	{
		return this;
	}

	public static FAnimInitializationContext FromNative(IntPtr nativeBuffer)
	{
		return new FAnimInitializationContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimInitializationContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimInitializationContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimInitializationContext(nativeBuffer + arrayIndex * FAnimInitializationContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimInitializationContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimInitializationContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimInitializationContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimInitializationContext");
		}
	}

	public FAnimInitializationContext(IntPtr nativeStruct)
	{
		if (!FAnimInitializationContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimInitializationContext");
		}
	}

	static FAnimInitializationContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimInitializationContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimInitializationContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimInitializationContext");
		FAnimInitializationContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimInitializationContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimInitializationContext", FAnimInitializationContext_IsValid);
	}
}
