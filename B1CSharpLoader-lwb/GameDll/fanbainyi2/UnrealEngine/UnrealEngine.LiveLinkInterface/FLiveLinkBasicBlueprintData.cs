using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkBasicBlueprintData
{
	private static bool StaticData_IsValid;

	private static int StaticData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData:StaticData")]
	public FLiveLinkBaseStaticData StaticData;

	private static bool FrameData_IsValid;

	private static int FrameData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData:FrameData")]
	public FLiveLinkBaseFrameData FrameData;

	private static bool FLiveLinkBasicBlueprintData_IsValid;

	private static int FLiveLinkBasicBlueprintData_StructSize;

	public FLiveLinkBasicBlueprintData Copy()
	{
		return this;
	}

	public static FLiveLinkBasicBlueprintData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkBasicBlueprintData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkBasicBlueprintData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkBasicBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkBasicBlueprintData(nativeBuffer + arrayIndex * FLiveLinkBasicBlueprintData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkBasicBlueprintData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkBasicBlueprintData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkBasicBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData");
			return;
		}
		FLiveLinkBaseStaticData.ToNative(IntPtr.Add(nativeStruct, StaticData_Offset), StaticData);
		FLiveLinkBaseFrameData.ToNative(IntPtr.Add(nativeStruct, FrameData_Offset), FrameData);
	}

	public FLiveLinkBasicBlueprintData(IntPtr nativeStruct)
	{
		if (!FLiveLinkBasicBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData");
			StaticData = default(FLiveLinkBaseStaticData);
			FrameData = default(FLiveLinkBaseFrameData);
		}
		else
		{
			StaticData = FLiveLinkBaseStaticData.FromNative(IntPtr.Add(nativeStruct, StaticData_Offset));
			FrameData = FLiveLinkBaseFrameData.FromNative(IntPtr.Add(nativeStruct, FrameData_Offset));
		}
	}

	static FLiveLinkBasicBlueprintData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkBasicBlueprintData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkBasicBlueprintData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData");
		FLiveLinkBasicBlueprintData_StructSize = NativeReflection.GetStructSize(intPtr);
		StaticData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticData");
		StaticData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticData", Classes.FStructProperty);
		FrameData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameData");
		FrameData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameData", Classes.FStructProperty);
		FLiveLinkBasicBlueprintData_IsValid = intPtr != IntPtr.Zero && StaticData_IsValid && FrameData_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkBasicBlueprintData", FLiveLinkBasicBlueprintData_IsValid);
	}
}
