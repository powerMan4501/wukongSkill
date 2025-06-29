using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.HitForZBBInfo")]
public struct HitForZBBInfo
{
	public float NotifyBeginTime;

	public float HitWorldTime;

	private static int HitForZBBInfo_StructSize;

	private static int HitForZBBInfo_IsValid;

	public HitForZBBInfo Copy()
	{
		return this;
	}

	public static HitForZBBInfo FromNative(IntPtr nativeBuffer)
	{
		return new HitForZBBInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, HitForZBBInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static HitForZBBInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new HitForZBBInfo(IntPtr.Add(nativeBuffer, arrayIndex * HitForZBBInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, HitForZBBInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HitForZBBInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HitForZBBInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitForZBBInfo");
		}
	}

	public HitForZBBInfo(IntPtr nativeStruct)
	{
		if (HitForZBBInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HitForZBBInfo");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HitForZBBInfo");
		HitForZBBInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		HitForZBBInfo_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HitForZBBInfo", (byte)HitForZBBInfo_IsValid != 0);
	}

	static HitForZBBInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(HitForZBBInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(HitForZBBInfo));
	}
}
