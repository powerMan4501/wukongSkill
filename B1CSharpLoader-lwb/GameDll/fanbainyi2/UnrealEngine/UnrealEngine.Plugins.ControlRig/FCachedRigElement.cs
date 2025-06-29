using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.CachedRigElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FCachedRigElement
{
	private static bool FCachedRigElement_IsValid;

	private static int FCachedRigElement_StructSize;

	public FCachedRigElement Copy()
	{
		return this;
	}

	public static FCachedRigElement FromNative(IntPtr nativeBuffer)
	{
		return new FCachedRigElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedRigElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedRigElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedRigElement(nativeBuffer + arrayIndex * FCachedRigElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedRigElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedRigElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedRigElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.CachedRigElement");
		}
	}

	public FCachedRigElement(IntPtr nativeStruct)
	{
		if (!FCachedRigElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.CachedRigElement");
		}
	}

	static FCachedRigElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedRigElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedRigElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.CachedRigElement");
		FCachedRigElement_StructSize = NativeReflection.GetStructSize(intPtr);
		FCachedRigElement_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.CachedRigElement", FCachedRigElement_IsValid);
	}
}
