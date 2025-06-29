using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.BuffDispTickData")]
public struct BuffDispTickData
{
	public float CurrentCurvePos;

	public float CurvePosScale;

	public FUStFloatCurveToParam FloatCurveToParam;

	public UCurveFloat CurveFloat;

	private static int BuffDispTickData_StructSize;

	private static int BuffDispTickData_IsValid;

	public BuffDispTickData Copy()
	{
		return this;
	}

	public static BuffDispTickData FromNative(IntPtr nativeBuffer)
	{
		return new BuffDispTickData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BuffDispTickData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BuffDispTickData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BuffDispTickData(IntPtr.Add(nativeBuffer, arrayIndex * BuffDispTickData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BuffDispTickData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BuffDispTickData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BuffDispTickData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BuffDispTickData");
		}
	}

	public BuffDispTickData(IntPtr nativeStruct)
	{
		if (BuffDispTickData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BuffDispTickData");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BuffDispTickData");
		BuffDispTickData_StructSize = NativeReflection.GetStructSize(intPtr);
		BuffDispTickData_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BuffDispTickData", (byte)BuffDispTickData_IsValid != 0);
	}

	static BuffDispTickData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BuffDispTickData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BuffDispTickData));
	}
}
