using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimCurveBase", "Engine", UnrealModuleType.Engine)]
public struct FAnimCurveBase
{
	private static bool FAnimCurveBase_IsValid;

	private static int FAnimCurveBase_StructSize;

	public FAnimCurveBase Copy()
	{
		return this;
	}

	public static FAnimCurveBase FromNative(IntPtr nativeBuffer)
	{
		return new FAnimCurveBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimCurveBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimCurveBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimCurveBase(nativeBuffer + arrayIndex * FAnimCurveBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimCurveBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimCurveBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimCurveBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimCurveBase");
		}
	}

	public FAnimCurveBase(IntPtr nativeStruct)
	{
		if (!FAnimCurveBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimCurveBase");
		}
	}

	static FAnimCurveBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimCurveBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimCurveBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimCurveBase");
		FAnimCurveBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimCurveBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimCurveBase", FAnimCurveBase_IsValid);
	}
}
