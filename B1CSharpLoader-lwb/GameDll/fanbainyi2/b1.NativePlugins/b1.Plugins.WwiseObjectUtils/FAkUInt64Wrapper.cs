using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.WwiseObjectUtils;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/WwiseObjectUtils.AkUInt64Wrapper", "WwiseObjectUtils", UnrealModuleType.GamePlugin)]
public struct FAkUInt64Wrapper
{
	private static bool FAkUInt64Wrapper_IsValid;

	private static int FAkUInt64Wrapper_StructSize;

	public FAkUInt64Wrapper Copy()
	{
		return this;
	}

	public static FAkUInt64Wrapper FromNative(IntPtr nativeBuffer)
	{
		return new FAkUInt64Wrapper(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkUInt64Wrapper value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkUInt64Wrapper FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkUInt64Wrapper(nativeBuffer + arrayIndex * FAkUInt64Wrapper_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkUInt64Wrapper value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkUInt64Wrapper_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkUInt64Wrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUInt64Wrapper");
		}
	}

	public FAkUInt64Wrapper(IntPtr nativeStruct)
	{
		if (!FAkUInt64Wrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUInt64Wrapper");
		}
	}

	static FAkUInt64Wrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkUInt64Wrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkUInt64Wrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WwiseObjectUtils.AkUInt64Wrapper");
		FAkUInt64Wrapper_StructSize = NativeReflection.GetStructSize(intPtr);
		FAkUInt64Wrapper_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/WwiseObjectUtils.AkUInt64Wrapper", FAkUInt64Wrapper_IsValid);
	}
}
