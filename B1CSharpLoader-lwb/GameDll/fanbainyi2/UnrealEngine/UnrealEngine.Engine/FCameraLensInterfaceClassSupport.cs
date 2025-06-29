using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraLensInterfaceClassSupport", "Engine", UnrealModuleType.Engine)]
public struct FCameraLensInterfaceClassSupport
{
	private static bool FCameraLensInterfaceClassSupport_IsValid;

	private static int FCameraLensInterfaceClassSupport_StructSize;

	public FCameraLensInterfaceClassSupport Copy()
	{
		return this;
	}

	public static FCameraLensInterfaceClassSupport FromNative(IntPtr nativeBuffer)
	{
		return new FCameraLensInterfaceClassSupport(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraLensInterfaceClassSupport value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraLensInterfaceClassSupport FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraLensInterfaceClassSupport(nativeBuffer + arrayIndex * FCameraLensInterfaceClassSupport_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraLensInterfaceClassSupport value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraLensInterfaceClassSupport_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraLensInterfaceClassSupport_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraLensInterfaceClassSupport");
		}
	}

	public FCameraLensInterfaceClassSupport(IntPtr nativeStruct)
	{
		if (!FCameraLensInterfaceClassSupport_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraLensInterfaceClassSupport");
		}
	}

	static FCameraLensInterfaceClassSupport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraLensInterfaceClassSupport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraLensInterfaceClassSupport));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraLensInterfaceClassSupport");
		FCameraLensInterfaceClassSupport_StructSize = NativeReflection.GetStructSize(intPtr);
		FCameraLensInterfaceClassSupport_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraLensInterfaceClassSupport", FCameraLensInterfaceClassSupport_IsValid);
	}
}
