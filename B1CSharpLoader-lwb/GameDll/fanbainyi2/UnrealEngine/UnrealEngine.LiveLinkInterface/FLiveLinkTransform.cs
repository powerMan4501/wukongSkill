using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransform", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkTransform
{
	private static bool FLiveLinkTransform_IsValid;

	private static int FLiveLinkTransform_StructSize;

	public FLiveLinkTransform Copy()
	{
		return this;
	}

	public static FLiveLinkTransform FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkTransform(nativeBuffer + arrayIndex * FLiveLinkTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransform");
		}
	}

	public FLiveLinkTransform(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransform");
		}
	}

	static FLiveLinkTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkTransform");
		FLiveLinkTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FLiveLinkTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkTransform", FLiveLinkTransform_IsValid);
	}
}
