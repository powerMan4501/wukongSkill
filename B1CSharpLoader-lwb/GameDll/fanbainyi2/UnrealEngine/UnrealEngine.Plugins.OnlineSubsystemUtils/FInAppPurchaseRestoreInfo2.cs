using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseRestoreInfo2
{
	private static bool ItemName_IsValid;

	private static int ItemName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2:ItemName")]
	public string ItemName;

	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2:ItemId")]
	public string ItemId;

	private static bool ValidationInfo_IsValid;

	private static int ValidationInfo_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2:ValidationInfo")]
	public string ValidationInfo;

	private static bool FInAppPurchaseRestoreInfo2_IsValid;

	private static int FInAppPurchaseRestoreInfo2_StructSize;

	public FInAppPurchaseRestoreInfo2 Copy()
	{
		return this;
	}

	public static FInAppPurchaseRestoreInfo2 FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseRestoreInfo2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseRestoreInfo2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseRestoreInfo2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseRestoreInfo2(nativeBuffer + arrayIndex * FInAppPurchaseRestoreInfo2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseRestoreInfo2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseRestoreInfo2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseRestoreInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemName_Offset), ItemName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ItemId_Offset), ItemId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ValidationInfo_Offset), ValidationInfo);
	}

	public FInAppPurchaseRestoreInfo2(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseRestoreInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2");
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

	static FInAppPurchaseRestoreInfo2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseRestoreInfo2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseRestoreInfo2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2");
		FInAppPurchaseRestoreInfo2_StructSize = NativeReflection.GetStructSize(intPtr);
		ItemName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemName");
		ItemName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemName", Classes.FStrProperty);
		ItemId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ItemId", Classes.FStrProperty);
		ValidationInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValidationInfo");
		ValidationInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValidationInfo", Classes.FStrProperty);
		FInAppPurchaseRestoreInfo2_IsValid = intPtr != IntPtr.Zero && ItemName_IsValid && ItemId_IsValid && ValidationInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreInfo2", FInAppPurchaseRestoreInfo2_IsValid);
	}
}
