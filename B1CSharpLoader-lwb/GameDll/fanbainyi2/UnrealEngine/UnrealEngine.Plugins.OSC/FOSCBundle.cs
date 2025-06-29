using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OSC.OSCBundle", "OSC", UnrealModuleType.EnginePlugin)]
public struct FOSCBundle
{
	private static bool FOSCBundle_IsValid;

	private static int FOSCBundle_StructSize;

	public FOSCBundle Copy()
	{
		return this;
	}

	public static FOSCBundle FromNative(IntPtr nativeBuffer)
	{
		return new FOSCBundle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOSCBundle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOSCBundle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOSCBundle(nativeBuffer + arrayIndex * FOSCBundle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOSCBundle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOSCBundle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOSCBundle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCBundle");
		}
	}

	public FOSCBundle(IntPtr nativeStruct)
	{
		if (!FOSCBundle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OSC.OSCBundle");
		}
	}

	static FOSCBundle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOSCBundle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOSCBundle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OSC.OSCBundle");
		FOSCBundle_StructSize = NativeReflection.GetStructSize(intPtr);
		FOSCBundle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/OSC.OSCBundle", FOSCBundle_IsValid);
	}
}
