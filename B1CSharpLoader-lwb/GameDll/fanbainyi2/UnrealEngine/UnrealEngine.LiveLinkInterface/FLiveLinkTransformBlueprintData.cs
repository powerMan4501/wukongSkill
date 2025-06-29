using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkTransformBlueprintData
{
	private static bool StaticData_IsValid;

	private static int StaticData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData:StaticData")]
	public FLiveLinkTransformStaticData StaticData;

	private static bool FrameData_IsValid;

	private static int FrameData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData:FrameData")]
	public FLiveLinkTransformFrameData FrameData;

	private static bool FLiveLinkTransformBlueprintData_IsValid;

	private static int FLiveLinkTransformBlueprintData_StructSize;

	public FLiveLinkTransformBlueprintData Copy()
	{
		return this;
	}

	public static FLiveLinkTransformBlueprintData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkTransformBlueprintData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkTransformBlueprintData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkTransformBlueprintData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkTransformBlueprintData(nativeBuffer + arrayIndex * FLiveLinkTransformBlueprintData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkTransformBlueprintData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkTransformBlueprintData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData");
			return;
		}
		FLiveLinkTransformStaticData.ToNative(IntPtr.Add(nativeStruct, StaticData_Offset), StaticData);
		FLiveLinkTransformFrameData.ToNative(IntPtr.Add(nativeStruct, FrameData_Offset), FrameData);
	}

	public FLiveLinkTransformBlueprintData(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformBlueprintData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData");
			StaticData = default(FLiveLinkTransformStaticData);
			FrameData = default(FLiveLinkTransformFrameData);
		}
		else
		{
			StaticData = FLiveLinkTransformStaticData.FromNative(IntPtr.Add(nativeStruct, StaticData_Offset));
			FrameData = FLiveLinkTransformFrameData.FromNative(IntPtr.Add(nativeStruct, FrameData_Offset));
		}
	}

	static FLiveLinkTransformBlueprintData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkTransformBlueprintData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkTransformBlueprintData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData");
		FLiveLinkTransformBlueprintData_StructSize = NativeReflection.GetStructSize(intPtr);
		StaticData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticData");
		StaticData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticData", Classes.FStructProperty);
		FrameData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameData");
		FrameData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameData", Classes.FStructProperty);
		FLiveLinkTransformBlueprintData_IsValid = intPtr != IntPtr.Zero && StaticData_IsValid && FrameData_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkTransformBlueprintData", FLiveLinkTransformBlueprintData_IsValid);
	}
}
