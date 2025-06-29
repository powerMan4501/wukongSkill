using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementFramework;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/TypedElementFramework.ScriptTypedElementHandle", "TypedElementFramework", UnrealModuleType.Engine)]
public struct FScriptTypedElementHandle
{
	private static bool FScriptTypedElementHandle_IsValid;

	private static int FScriptTypedElementHandle_StructSize;

	public FScriptTypedElementHandle Copy()
	{
		return this;
	}

	public static FScriptTypedElementHandle FromNative(IntPtr nativeBuffer)
	{
		return new FScriptTypedElementHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScriptTypedElementHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScriptTypedElementHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScriptTypedElementHandle(nativeBuffer + arrayIndex * FScriptTypedElementHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScriptTypedElementHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScriptTypedElementHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScriptTypedElementHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementFramework.ScriptTypedElementHandle");
		}
	}

	public FScriptTypedElementHandle(IntPtr nativeStruct)
	{
		if (!FScriptTypedElementHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementFramework.ScriptTypedElementHandle");
		}
	}

	static FScriptTypedElementHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScriptTypedElementHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScriptTypedElementHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementFramework.ScriptTypedElementHandle");
		FScriptTypedElementHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FScriptTypedElementHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/TypedElementFramework.ScriptTypedElementHandle", FScriptTypedElementHandle_IsValid);
	}
}
