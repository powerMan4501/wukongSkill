using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ConstraintInstanceAccessor", "Engine", UnrealModuleType.Engine)]
public struct FConstraintInstanceAccessor
{
	private static bool FConstraintInstanceAccessor_IsValid;

	private static int FConstraintInstanceAccessor_StructSize;

	public FConstraintInstanceAccessor Copy()
	{
		return this;
	}

	public static FConstraintInstanceAccessor FromNative(IntPtr nativeBuffer)
	{
		return new FConstraintInstanceAccessor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FConstraintInstanceAccessor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FConstraintInstanceAccessor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FConstraintInstanceAccessor(nativeBuffer + arrayIndex * FConstraintInstanceAccessor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FConstraintInstanceAccessor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FConstraintInstanceAccessor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FConstraintInstanceAccessor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ConstraintInstanceAccessor");
		}
	}

	public FConstraintInstanceAccessor(IntPtr nativeStruct)
	{
		if (!FConstraintInstanceAccessor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ConstraintInstanceAccessor");
		}
	}

	static FConstraintInstanceAccessor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FConstraintInstanceAccessor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FConstraintInstanceAccessor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ConstraintInstanceAccessor");
		FConstraintInstanceAccessor_StructSize = NativeReflection.GetStructSize(intPtr);
		FConstraintInstanceAccessor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.ConstraintInstanceAccessor", FConstraintInstanceAccessor_IsValid);
	}
}
