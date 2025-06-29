using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.UnitZBBInfo")]
public struct UnitZBBInfo
{
	public bool NeedTest;

	public bool Effective;

	public FVector Position;

	public float HitTimer;

	public float Distance;

	public List<string> NotifyBeginTime;

	private static int UnitZBBInfo_StructSize;

	private static int UnitZBBInfo_IsValid;

	public UnitZBBInfo Copy()
	{
		return this;
	}

	public static UnitZBBInfo FromNative(IntPtr nativeBuffer)
	{
		return new UnitZBBInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UnitZBBInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UnitZBBInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UnitZBBInfo(IntPtr.Add(nativeBuffer, arrayIndex * UnitZBBInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UnitZBBInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitZBBInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitZBBInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitZBBInfo");
		}
	}

	public UnitZBBInfo(IntPtr nativeStruct)
	{
		if (UnitZBBInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitZBBInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitZBBInfo");
		UnitZBBInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		UnitZBBInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitZBBInfo", (byte)UnitZBBInfo_IsValid != 0);
	}

	static UnitZBBInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UnitZBBInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UnitZBBInfo));
	}
}
