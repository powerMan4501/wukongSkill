using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseReceiptInfo
{
	private static bool ItemName_IsValid;

	private static int ItemName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo:ItemName")]
	public string ItemName;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo:ItemId")]
	public string ItemId;

	private static bool ValidationInfo_IsValid;

	private static int ValidationInfo_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo:ValidationInfo")]
	public string ValidationInfo;

	private static bool FInAppPurchaseReceiptInfo_IsValid;

	private static int FInAppPurchaseReceiptInfo_StructSize;

	public FInAppPurchaseReceiptInfo Copy()
	{
		return this;
	}

	public static FInAppPurchaseReceiptInfo FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseReceiptInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseReceiptInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseReceiptInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseReceiptInfo(nativeBuffer + arrayIndex * FInAppPurchaseReceiptInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseReceiptInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseReceiptInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseReceiptInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemName_Offset), ItemName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemId_Offset), ItemId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ValidationInfo_Offset), ValidationInfo);
	}

	public FInAppPurchaseReceiptInfo(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseReceiptInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo");
			ItemName = FStringMarshaler.DefaultString;
			ItemId = FStringMarshaler.DefaultString;
			ValidationInfo = FStringMarshaler.DefaultString;
		}
		else
		{
			ItemName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemName_Offset));
			ItemId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ItemId_Offset));
			ValidationInfo = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ValidationInfo_Offset));
		}
	}

	static FInAppPurchaseReceiptInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseReceiptInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseReceiptInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo");
		FInAppPurchaseReceiptInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemName");
		ItemName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemName", Classes.FStrProperty);
		ItemId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemId", Classes.FStrProperty);
		ValidationInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidationInfo");
		ValidationInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidationInfo", Classes.FStrProperty);
		FInAppPurchaseReceiptInfo_IsValid = intPtr != IntPtr.Zero && ItemName_IsValid && ItemId_IsValid && ValidationInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo", FInAppPurchaseReceiptInfo_IsValid);
	}
}
