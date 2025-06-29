using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.WwiseObjectUtils;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/WwiseObjectUtils.AkUniqueID", "WwiseObjectUtils", UnrealModuleType.GamePlugin)]
public struct FAkUniqueID
{
	private static bool FAkUniqueID_IsValid;

	private static int FAkUniqueID_StructSize;

	public FAkUniqueID Copy()
	{
		return this;
	}

	public static FAkUniqueID FromNative(IntPtr nativeBuffer)
	{
		return new FAkUniqueID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkUniqueID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkUniqueID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkUniqueID(nativeBuffer + arrayIndex * FAkUniqueID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkUniqueID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkUniqueID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkUniqueID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUniqueID");
		}
	}

	public FAkUniqueID(IntPtr nativeStruct)
	{
		if (!FAkUniqueID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WwiseObjectUtils.AkUniqueID");
		}
	}

	static FAkUniqueID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkUniqueID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkUniqueID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WwiseObjectUtils.AkUniqueID");
		FAkUniqueID_StructSize = NativeReflection.GetStructSize(intPtr);
		FAkUniqueID_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/WwiseObjectUtils.AkUniqueID", FAkUniqueID_IsValid);
	}
}
