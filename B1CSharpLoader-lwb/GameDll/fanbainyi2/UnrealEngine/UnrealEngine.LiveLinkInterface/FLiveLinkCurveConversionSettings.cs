using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkCurveConversionSettings
{
	private static bool FLiveLinkCurveConversionSettings_IsValid;

	private static int FLiveLinkCurveConversionSettings_StructSize;

	public FLiveLinkCurveConversionSettings Copy()
	{
		return this;
	}

	public static FLiveLinkCurveConversionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkCurveConversionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkCurveConversionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkCurveConversionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkCurveConversionSettings(nativeBuffer + arrayIndex * FLiveLinkCurveConversionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkCurveConversionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkCurveConversionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkCurveConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings");
		}
	}

	public FLiveLinkCurveConversionSettings(IntPtr nativeStruct)
	{
		if (!FLiveLinkCurveConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings");
		}
	}

	static FLiveLinkCurveConversionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkCurveConversionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkCurveConversionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings");
		FLiveLinkCurveConversionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FLiveLinkCurveConversionSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkCurveConversionSettings", FLiveLinkCurveConversionSettings_IsValid);
	}
}
