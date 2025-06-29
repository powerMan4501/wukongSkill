using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OSC.OSCAddress", "OSC", UnrealModuleType.EnginePlugin)]
public struct FOSCAddress
{
	private static bool FOSCAddress_IsValid;

	private static int FOSCAddress_StructSize;

	public FOSCAddress Copy()
	{
		return this;
	}

	public static FOSCAddress FromNative(IntPtr nativeBuffer)
	{
		return new FOSCAddress(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOSCAddress value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOSCAddress FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOSCAddress(nativeBuffer + arrayIndex * FOSCAddress_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOSCAddress value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOSCAddress_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOSCAddress_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCAddress");
		}
	}

	public FOSCAddress(IntPtr nativeStruct)
	{
		if (!FOSCAddress_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCAddress");
		}
	}

	static FOSCAddress()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOSCAddress)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOSCAddress));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OSC.OSCAddress");
		FOSCAddress_StructSize = NativeReflection.GetStructSize(intPtr);
		FOSCAddress_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/OSC.OSCAddress", FOSCAddress_IsValid);
	}
}
