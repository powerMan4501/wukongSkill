using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.DamageEvent", "Engine", UnrealModuleType.Engine)]
public struct FDamageEvent
{
	private static bool FDamageEvent_IsValid;

	private static int FDamageEvent_StructSize;

	public FDamageEvent Copy()
	{
		return this;
	}

	public static FDamageEvent FromNative(IntPtr nativeBuffer)
	{
		return new FDamageEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDamageEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDamageEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDamageEvent(nativeBuffer + arrayIndex * FDamageEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDamageEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDamageEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DamageEvent");
		}
	}

	public FDamageEvent(IntPtr nativeStruct)
	{
		if (!FDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DamageEvent");
		}
	}

	static FDamageEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDamageEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDamageEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DamageEvent");
		FDamageEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FDamageEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.DamageEvent", FDamageEvent_IsValid);
	}
}
