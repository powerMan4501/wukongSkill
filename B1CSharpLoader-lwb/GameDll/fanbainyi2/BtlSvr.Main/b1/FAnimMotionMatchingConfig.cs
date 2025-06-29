using System;
using b1.Plugins.MM;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimMotionMatchingConfig")]
internal struct FAnimMotionMatchingConfig
{
	private UAnimationAnalyzer AA_Default;

	private static int AnimMotionMatchingConfig_StructSize;

	private static int AnimMotionMatchingConfig_IsValid;

	public b1.FAnimMotionMatchingConfig Copy()
	{
		return this;
	}

	public static b1.FAnimMotionMatchingConfig FromNative(IntPtr nativeBuffer)
	{
		return new b1.FAnimMotionMatchingConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, b1.FAnimMotionMatchingConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static b1.FAnimMotionMatchingConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new b1.FAnimMotionMatchingConfig(IntPtr.Add(nativeBuffer, arrayIndex * AnimMotionMatchingConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, b1.FAnimMotionMatchingConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimMotionMatchingConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimMotionMatchingConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimMotionMatchingConfig");
		}
	}

	public FAnimMotionMatchingConfig(IntPtr nativeStruct)
	{
		if (AnimMotionMatchingConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimMotionMatchingConfig");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimMotionMatchingConfig");
		AnimMotionMatchingConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimMotionMatchingConfig_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimMotionMatchingConfig", (byte)AnimMotionMatchingConfig_IsValid != 0);
	}

	static FAnimMotionMatchingConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.FAnimMotionMatchingConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.FAnimMotionMatchingConfig));
	}
}
