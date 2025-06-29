using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseReceiptInfo2
{
	private static bool ItemName_IsValid;

	private static int ItemName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2:ItemName")]
	public string ItemName;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2:ItemId")]
	public string ItemId;

	private static bool ValidationInfo_IsValid;

	private static int ValidationInfo_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2:ValidationInfo")]
	public string ValidationInfo;

	private static bool FInAppPurchaseReceiptInfo2_IsValid;

	private static int FInAppPurchaseReceiptInfo2_StructSize;

	public FInAppPurchaseReceiptInfo2 Copy()
	{
		return this;
	}

	public static FInAppPurchaseReceiptInfo2 FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseReceiptInfo2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseReceiptInfo2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseReceiptInfo2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseReceiptInfo2(nativeBuffer + arrayIndex * FInAppPurchaseReceiptInfo2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseReceiptInfo2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseReceiptInfo2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseReceiptInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemName_Offset), ItemName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemId_Offset), ItemId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ValidationInfo_Offset), ValidationInfo);
	}

	public FInAppPurchaseReceiptInfo2(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseReceiptInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2");
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

	static FInAppPurchaseReceiptInfo2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseReceiptInfo2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseReceiptInfo2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2");
		FInAppPurchaseReceiptInfo2_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemName");
		ItemName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemName", Classes.FStrProperty);
		ItemId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemId", Classes.FStrProperty);
		ValidationInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidationInfo");
		ValidationInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidationInfo", Classes.FStrProperty);
		FInAppPurchaseReceiptInfo2_IsValid = intPtr != IntPtr.Zero && ItemName_IsValid && ItemId_IsValid && ValidationInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseReceiptInfo2", FInAppPurchaseReceiptInfo2_IsValid);
	}
}
