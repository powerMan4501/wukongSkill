using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ActorInstanceHandle", "Engine", UnrealModuleType.Engine)]
public struct FActorInstanceHandle
{
	private static bool FActorInstanceHandle_IsValid;

	private static int FActorInstanceHandle_StructSize;

	public FActorInstanceHandle Copy()
	{
		return this;
	}

	public static FActorInstanceHandle FromNative(IntPtr nativeBuffer)
	{
		return new FActorInstanceHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorInstanceHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorInstanceHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorInstanceHandle(nativeBuffer + arrayIndex * FActorInstanceHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorInstanceHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorInstanceHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorInstanceHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ActorInstanceHandle");
		}
	}

	public FActorInstanceHandle(IntPtr nativeStruct)
	{
		if (!FActorInstanceHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ActorInstanceHandle");
		}
	}

	static FActorInstanceHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorInstanceHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorInstanceHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ActorInstanceHandle");
		FActorInstanceHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FActorInstanceHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.ActorInstanceHandle", FActorInstanceHandle_IsValid);
	}
}
