using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OSC.OSCMessage", "OSC", UnrealModuleType.EnginePlugin)]
public struct FOSCMessage
{
	private static bool FOSCMessage_IsValid;

	private static int FOSCMessage_StructSize;

	public FOSCMessage Copy()
	{
		return this;
	}

	public static FOSCMessage FromNative(IntPtr nativeBuffer)
	{
		return new FOSCMessage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOSCMessage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOSCMessage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOSCMessage(nativeBuffer + arrayIndex * FOSCMessage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOSCMessage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOSCMessage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOSCMessage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCMessage");
		}
	}

	public FOSCMessage(IntPtr nativeStruct)
	{
		if (!FOSCMessage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCMessage");
		}
	}

	static FOSCMessage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOSCMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOSCMessage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OSC.OSCMessage");
		FOSCMessage_StructSize = NativeReflection.GetStructSize(intPtr);
		FOSCMessage_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/OSC.OSCMessage", FOSCMessage_IsValid);
	}
}
