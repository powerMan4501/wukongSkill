using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIRequestID", "AIModule", UnrealModuleType.Engine)]
public struct FAIRequestID
{
	private static bool FAIRequestID_IsValid;

	private static int FAIRequestID_StructSize;

	public FAIRequestID Copy()
	{
		return this;
	}

	public static FAIRequestID FromNative(IntPtr nativeBuffer)
	{
		return new FAIRequestID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAIRequestID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAIRequestID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAIRequestID(nativeBuffer + arrayIndex * FAIRequestID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAIRequestID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAIRequestID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAIRequestID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIRequestID");
		}
	}

	public FAIRequestID(IntPtr nativeStruct)
	{
		if (!FAIRequestID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIRequestID");
		}
	}

	static FAIRequestID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAIRequestID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAIRequestID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AIRequestID");
		FAIRequestID_StructSize = NativeReflection.GetStructSize(intPtr);
		FAIRequestID_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AIModule.AIRequestID", FAIRequestID_IsValid);
	}
}
