using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.WwiseObjectUtils;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/WwiseObjectUtils.AkUInt32Wrapper", "WwiseObjectUtils", UnrealModuleType.GamePlugin)]
public struct FAkUInt32Wrapper
{
	private static bool FAkUInt32Wrapper_IsValid;

	private static int FAkUInt32Wrapper_StructSize;

	public FAkUInt32Wrapper Copy()
	{
		return this;
	}

	public static FAkUInt32Wrapper FromNative(IntPtr nativeBuffer)
	{
		return new FAkUInt32Wrapper(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkUInt32Wrapper value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkUInt32Wrapper FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkUInt32Wrapper(nativeBuffer + arrayIndex * FAkUInt32Wrapper_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkUInt32Wrapper value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkUInt32Wrapper_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkUInt32Wrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUInt32Wrapper");
		}
	}

	public FAkUInt32Wrapper(IntPtr nativeStruct)
	{
		if (!FAkUInt32Wrapper_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUInt32Wrapper");
		}
	}

	static FAkUInt32Wrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkUInt32Wrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkUInt32Wrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WwiseObjectUtils.AkUInt32Wrapper");
		FAkUInt32Wrapper_StructSize = NativeReflection.GetStructSize(intPtr);
		FAkUInt32Wrapper_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/WwiseObjectUtils.AkUInt32Wrapper", FAkUInt32Wrapper_IsValid);
	}
}
