using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4611)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimationCurveIdentifier", "Engine", UnrealModuleType.Engine)]
public struct FAnimationCurveIdentifier
{
	private static bool FAnimationCurveIdentifier_IsValid;

	private static int FAnimationCurveIdentifier_StructSize;

	public FAnimationCurveIdentifier Copy()
	{
		return this;
	}

	public static FAnimationCurveIdentifier FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationCurveIdentifier(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationCurveIdentifier value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationCurveIdentifier FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationCurveIdentifier(nativeBuffer + arrayIndex * FAnimationCurveIdentifier_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationCurveIdentifier value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationCurveIdentifier_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationCurveIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationCurveIdentifier");
		}
	}

	public FAnimationCurveIdentifier(IntPtr nativeStruct)
	{
		if (!FAnimationCurveIdentifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimationCurveIdentifier");
		}
	}

	static FAnimationCurveIdentifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationCurveIdentifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationCurveIdentifier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimationCurveIdentifier");
		FAnimationCurveIdentifier_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimationCurveIdentifier_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimationCurveIdentifier", FAnimationCurveIdentifier_IsValid);
	}
}
