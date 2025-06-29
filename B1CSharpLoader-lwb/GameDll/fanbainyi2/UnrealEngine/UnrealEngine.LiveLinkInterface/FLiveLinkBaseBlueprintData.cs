using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkBaseBlueprintData
{
	private static bool FLiveLinkBaseBlueprintData_IsValid;

	private static int FLiveLinkBaseBlueprintData_StructSize;

	public FLiveLinkBaseBlueprintData Copy()
	{
		return this;
	}

	public static FLiveLinkBaseBlueprintData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkBaseBlueprintData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkBaseBlueprintData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkBaseBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkBaseBlueprintData(nativeBuffer + arrayIndex * FLiveLinkBaseBlueprintData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkBaseBlueprintData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkBaseBlueprintData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData");
		}
	}

	public FLiveLinkBaseBlueprintData(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData");
		}
	}

	static FLiveLinkBaseBlueprintData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkBaseBlueprintData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkBaseBlueprintData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData");
		FLiveLinkBaseBlueprintData_StructSize = NativeReflection.GetStructSize(intPtr);
		FLiveLinkBaseBlueprintData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData", FLiveLinkBaseBlueprintData_IsValid);
	}
}
