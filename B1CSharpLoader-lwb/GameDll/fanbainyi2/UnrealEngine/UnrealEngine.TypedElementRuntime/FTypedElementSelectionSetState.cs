using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.TypedElementRuntime;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSetState", "TypedElementRuntime", UnrealModuleType.Engine)]
public struct FTypedElementSelectionSetState
{
	private static bool FTypedElementSelectionSetState_IsValid;

	private static int FTypedElementSelectionSetState_StructSize;

	public FTypedElementSelectionSetState Copy()
	{
		return this;
	}

	public static FTypedElementSelectionSetState FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementSelectionSetState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementSelectionSetState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementSelectionSetState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementSelectionSetState(nativeBuffer + arrayIndex * FTypedElementSelectionSetState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementSelectionSetState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementSelectionSetState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionSetState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionSetState");
		}
	}

	public FTypedElementSelectionSetState(IntPtr nativeStruct)
	{
		if (!FTypedElementSelectionSetState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TypedElementRuntime.TypedElementSelectionSetState");
		}
	}

	static FTypedElementSelectionSetState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementSelectionSetState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementSelectionSetState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TypedElementRuntime.TypedElementSelectionSetState");
		FTypedElementSelectionSetState_StructSize = NativeReflection.GetStructSize(intPtr);
		FTypedElementSelectionSetState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/TypedElementRuntime.TypedElementSelectionSetState", FTypedElementSelectionSetState_IsValid);
	}
}
