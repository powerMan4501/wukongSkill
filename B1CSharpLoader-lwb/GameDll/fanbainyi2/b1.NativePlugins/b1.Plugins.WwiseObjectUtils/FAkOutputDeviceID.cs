using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.WwiseObjectUtils;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/WwiseObjectUtils.AkOutputDeviceID", "WwiseObjectUtils", UnrealModuleType.GamePlugin)]
public struct FAkOutputDeviceID
{
	private static bool FAkOutputDeviceID_IsValid;

	private static int FAkOutputDeviceID_StructSize;

	public FAkOutputDeviceID Copy()
	{
		return this;
	}

	public static FAkOutputDeviceID FromNative(IntPtr nativeBuffer)
	{
		return new FAkOutputDeviceID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkOutputDeviceID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkOutputDeviceID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkOutputDeviceID(nativeBuffer + arrayIndex * FAkOutputDeviceID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkOutputDeviceID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkOutputDeviceID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkOutputDeviceID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkOutputDeviceID");
		}
	}

	public FAkOutputDeviceID(IntPtr nativeStruct)
	{
		if (!FAkOutputDeviceID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkOutputDeviceID");
		}
	}

	static FAkOutputDeviceID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkOutputDeviceID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkOutputDeviceID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WwiseObjectUtils.AkOutputDeviceID");
		FAkOutputDeviceID_StructSize = NativeReflection.GetStructSize(intPtr);
		FAkOutputDeviceID_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/WwiseObjectUtils.AkOutputDeviceID", FAkOutputDeviceID_IsValid);
	}
}
