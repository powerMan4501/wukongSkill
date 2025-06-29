using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightBlueprintData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkLightBlueprintData
{
	private static bool StaticData_IsValid;

	private static int StaticData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightBlueprintData:StaticData")]
	public FLiveLinkLightStaticData StaticData;

	private static bool FrameData_IsValid;

	private static int FrameData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightBlueprintData:FrameData")]
	public FLiveLinkLightFrameData FrameData;

	private static bool FLiveLinkLightBlueprintData_IsValid;

	private static int FLiveLinkLightBlueprintData_StructSize;

	public FLiveLinkLightBlueprintData Copy()
	{
		return this;
	}

	public static FLiveLinkLightBlueprintData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkLightBlueprintData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkLightBlueprintData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkLightBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkLightBlueprintData(nativeBuffer + arrayIndex * FLiveLinkLightBlueprintData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkLightBlueprintData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkLightBlueprintData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightBlueprintData");
			return;
		}
		FLiveLinkLightStaticData.ToNative(IntPtr.Add(nativeStruct, StaticData_Offset), StaticData);
		FLiveLinkLightFrameData.ToNative(IntPtr.Add(nativeStruct, FrameData_Offset), FrameData);
	}

	public FLiveLinkLightBlueprintData(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightBlueprintData");
			StaticData = default(FLiveLinkLightStaticData);
			FrameData = default(FLiveLinkLightFrameData);
		}
		else
		{
			StaticData = FLiveLinkLightStaticData.FromNative(IntPtr.Add(nativeStruct, StaticData_Offset));
			FrameData = FLiveLinkLightFrameData.FromNative(IntPtr.Add(nativeStruct, FrameData_Offset));
		}
	}

	static FLiveLinkLightBlueprintData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkLightBlueprintData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkLightBlueprintData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkLightBlueprintData");
		FLiveLinkLightBlueprintData_StructSize = NativeReflection.GetStructSize(intPtr);
		StaticData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticData");
		StaticData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticData", Classes.FStructProperty);
		FrameData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameData");
		FrameData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameData", Classes.FStructProperty);
		FLiveLinkLightBlueprintData_IsValid = intPtr != IntPtr.Zero && StaticData_IsValid && FrameData_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkLightBlueprintData", FLiveLinkLightBlueprintData_IsValid);
	}
}
