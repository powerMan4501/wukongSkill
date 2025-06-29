using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/Engine.RadialDamageEvent", "Engine", UnrealModuleType.Engine)]
public struct FRadialDamageEvent
{
	private static bool FRadialDamageEvent_IsValid;

	private static int FRadialDamageEvent_StructSize;

	public FRadialDamageEvent Copy()
	{
		return this;
	}

	public static FRadialDamageEvent FromNative(IntPtr nativeBuffer)
	{
		return new FRadialDamageEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRadialDamageEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRadialDamageEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRadialDamageEvent(nativeBuffer + arrayIndex * FRadialDamageEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRadialDamageEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRadialDamageEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRadialDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RadialDamageEvent");
		}
	}

	public FRadialDamageEvent(IntPtr nativeStruct)
	{
		if (!FRadialDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RadialDamageEvent");
		}
	}

	static FRadialDamageEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRadialDamageEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRadialDamageEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RadialDamageEvent");
		FRadialDamageEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRadialDamageEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.RadialDamageEvent", FRadialDamageEvent_IsValid);
	}
}
