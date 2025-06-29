using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo", "OnlineSubsystem", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseRestoreInfo
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo:Identifier")]
	public string Identifier;

	private static bool ReceiptData_IsValid;

	private static int ReceiptData_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo:ReceiptData")]
	public string ReceiptData;

	private static bool TransactionIdentifier_IsValid;

	private static int TransactionIdentifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo:TransactionIdentifier")]
	public string TransactionIdentifier;

	private static bool FInAppPurchaseRestoreInfo_IsValid;

	private static int FInAppPurchaseRestoreInfo_StructSize;

	public FInAppPurchaseRestoreInfo Copy()
	{
		return this;
	}

	public static FInAppPurchaseRestoreInfo FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseRestoreInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseRestoreInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseRestoreInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseRestoreInfo(nativeBuffer + arrayIndex * FInAppPurchaseRestoreInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseRestoreInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseRestoreInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseRestoreInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ReceiptData_Offset), ReceiptData);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TransactionIdentifier_Offset), TransactionIdentifier);
	}

	public FInAppPurchaseRestoreInfo(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseRestoreInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo");
			Identifier = FStringMarshaler.DefaultString;
			ReceiptData = FStringMarshaler.DefaultString;
			TransactionIdentifier = FStringMarshaler.DefaultString;
		}
		else
		{
			Identifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
			ReceiptData = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ReceiptData_Offset));
			TransactionIdentifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TransactionIdentifier_Offset));
		}
	}

	static FInAppPurchaseRestoreInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseRestoreInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseRestoreInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo");
		FInAppPurchaseRestoreInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStrProperty);
		ReceiptData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReceiptData");
		ReceiptData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReceiptData", Classes.FStrProperty);
		TransactionIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransactionIdentifier");
		TransactionIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransactionIdentifier", Classes.FStrProperty);
		FInAppPurchaseRestoreInfo_IsValid = intPtr != IntPtr.Zero && Identifier_IsValid && ReceiptData_IsValid && TransactionIdentifier_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo", FInAppPurchaseRestoreInfo_IsValid);
	}
}
