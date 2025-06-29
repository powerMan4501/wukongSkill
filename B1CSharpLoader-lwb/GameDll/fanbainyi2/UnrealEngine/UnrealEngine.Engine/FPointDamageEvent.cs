using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/Engine.PointDamageEvent", "Engine", UnrealModuleType.Engine)]
public struct FPointDamageEvent
{
	private static bool FPointDamageEvent_IsValid;

	private static int FPointDamageEvent_StructSize;

	public FPointDamageEvent Copy()
	{
		return this;
	}

	public static FPointDamageEvent FromNative(IntPtr nativeBuffer)
	{
		return new FPointDamageEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPointDamageEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPointDamageEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPointDamageEvent(nativeBuffer + arrayIndex * FPointDamageEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPointDamageEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPointDamageEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPointDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PointDamageEvent");
		}
	}

	public FPointDamageEvent(IntPtr nativeStruct)
	{
		if (!FPointDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PointDamageEvent");
		}
	}

	static FPointDamageEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPointDamageEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPointDamageEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PointDamageEvent");
		FPointDamageEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FPointDamageEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.PointDamageEvent", FPointDamageEvent_IsValid);
	}
}
