using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigEnumControlProxyValue", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigEnumControlProxyValue
{
	private static bool FControlRigEnumControlProxyValue_IsValid;

	private static int FControlRigEnumControlProxyValue_StructSize;

	public FControlRigEnumControlProxyValue Copy()
	{
		return this;
	}

	public static FControlRigEnumControlProxyValue FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigEnumControlProxyValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigEnumControlProxyValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigEnumControlProxyValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigEnumControlProxyValue(nativeBuffer + arrayIndex * FControlRigEnumControlProxyValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigEnumControlProxyValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigEnumControlProxyValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigEnumControlProxyValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigEnumControlProxyValue");
		}
	}

	public FControlRigEnumControlProxyValue(IntPtr nativeStruct)
	{
		if (!FControlRigEnumControlProxyValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigEnumControlProxyValue");
		}
	}

	static FControlRigEnumControlProxyValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigEnumControlProxyValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigEnumControlProxyValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigEnumControlProxyValue");
		FControlRigEnumControlProxyValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FControlRigEnumControlProxyValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigEnumControlProxyValue", FControlRigEnumControlProxyValue_IsValid);
	}
}
