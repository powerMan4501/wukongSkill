using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkCameraBlueprintData
{
	private static bool StaticData_IsValid;

	private static int StaticData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData:StaticData")]
	public FLiveLinkCameraStaticData StaticData;

	private static bool FrameData_IsValid;

	private static int FrameData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData:FrameData")]
	public FLiveLinkCameraFrameData FrameData;

	private static bool FLiveLinkCameraBlueprintData_IsValid;

	private static int FLiveLinkCameraBlueprintData_StructSize;

	public FLiveLinkCameraBlueprintData Copy()
	{
		return this;
	}

	public static FLiveLinkCameraBlueprintData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkCameraBlueprintData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkCameraBlueprintData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkCameraBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkCameraBlueprintData(nativeBuffer + arrayIndex * FLiveLinkCameraBlueprintData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkCameraBlueprintData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkCameraBlueprintData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData");
			return;
		}
		FLiveLinkCameraStaticData.ToNative(IntPtr.Add(nativeStruct, StaticData_Offset), StaticData);
		FLiveLinkCameraFrameData.ToNative(IntPtr.Add(nativeStruct, FrameData_Offset), FrameData);
	}

	public FLiveLinkCameraBlueprintData(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData");
			StaticData = default(FLiveLinkCameraStaticData);
			FrameData = default(FLiveLinkCameraFrameData);
		}
		else
		{
			StaticData = FLiveLinkCameraStaticData.FromNative(IntPtr.Add(nativeStruct, StaticData_Offset));
			FrameData = FLiveLinkCameraFrameData.FromNative(IntPtr.Add(nativeStruct, FrameData_Offset));
		}
	}

	static FLiveLinkCameraBlueprintData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkCameraBlueprintData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkCameraBlueprintData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData");
		FLiveLinkCameraBlueprintData_StructSize = NativeReflection.GetStructSize(intPtr);
		StaticData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticData");
		StaticData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticData", Classes.FStructProperty);
		FrameData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameData");
		FrameData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameData", Classes.FStructProperty);
		FLiveLinkCameraBlueprintData_IsValid = intPtr != IntPtr.Zero && StaticData_IsValid && FrameData_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkCameraBlueprintData", FLiveLinkCameraBlueprintData_IsValid);
	}
}
