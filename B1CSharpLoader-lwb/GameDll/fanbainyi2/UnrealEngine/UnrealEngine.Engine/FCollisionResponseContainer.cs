using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CollisionResponseContainer", "Engine", UnrealModuleType.Engine)]
public struct FCollisionResponseContainer
{
	private static bool FCollisionResponseContainer_IsValid;

	private static int FCollisionResponseContainer_StructSize;

	public FCollisionResponseContainer Copy()
	{
		return this;
	}

	public static FCollisionResponseContainer FromNative(IntPtr nativeBuffer)
	{
		return new FCollisionResponseContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCollisionResponseContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCollisionResponseContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCollisionResponseContainer(nativeBuffer + arrayIndex * FCollisionResponseContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCollisionResponseContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCollisionResponseContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCollisionResponseContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollisionResponseContainer");
		}
	}

	public FCollisionResponseContainer(IntPtr nativeStruct)
	{
		if (!FCollisionResponseContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CollisionResponseContainer");
		}
	}

	static FCollisionResponseContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCollisionResponseContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCollisionResponseContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CollisionResponseContainer");
		FCollisionResponseContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FCollisionResponseContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.CollisionResponseContainer", FCollisionResponseContainer_IsValid);
	}
}
