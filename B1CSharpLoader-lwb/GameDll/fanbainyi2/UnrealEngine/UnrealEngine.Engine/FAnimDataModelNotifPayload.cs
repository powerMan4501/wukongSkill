using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimDataModelNotifPayload", "Engine", UnrealModuleType.Engine)]
public struct FAnimDataModelNotifPayload
{
	private static bool FAnimDataModelNotifPayload_IsValid;

	private static int FAnimDataModelNotifPayload_StructSize;

	public FAnimDataModelNotifPayload Copy()
	{
		return this;
	}

	public static FAnimDataModelNotifPayload FromNative(IntPtr nativeBuffer)
	{
		return new FAnimDataModelNotifPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimDataModelNotifPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimDataModelNotifPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimDataModelNotifPayload(nativeBuffer + arrayIndex * FAnimDataModelNotifPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimDataModelNotifPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimDataModelNotifPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimDataModelNotifPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimDataModelNotifPayload");
		}
	}

	public FAnimDataModelNotifPayload(IntPtr nativeStruct)
	{
		if (!FAnimDataModelNotifPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimDataModelNotifPayload");
		}
	}

	static FAnimDataModelNotifPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimDataModelNotifPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimDataModelNotifPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimDataModelNotifPayload");
		FAnimDataModelNotifPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		FAnimDataModelNotifPayload_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimDataModelNotifPayload", FAnimDataModelNotifPayload_IsValid);
	}
}
