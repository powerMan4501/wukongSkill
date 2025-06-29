using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FInAppPurchaseProductInfo2
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:Identifier")]
	public string Identifier;

	private static bool TransactionIdentifier_IsValid;

	private static int TransactionIdentifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:TransactionIdentifier")]
	public string TransactionIdentifier;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:DisplayName")]
	public string DisplayName;

	private static bool DisplayDescription_IsValid;

	private static int DisplayDescription_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:DisplayDescription")]
	public string DisplayDescription;

	private static bool DisplayPrice_IsValid;

	private static int DisplayPrice_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:DisplayPrice")]
	public string DisplayPrice;

	private static bool RawPrice_IsValid;

	private static int RawPrice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:RawPrice")]
	public float RawPrice;

	private static bool CurrencyCode_IsValid;

	private static int CurrencyCode_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:CurrencyCode")]
	public string CurrencyCode;

	private static bool CurrencySymbol_IsValid;

	private static int CurrencySymbol_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:CurrencySymbol")]
	public string CurrencySymbol;

	private static bool DecimalSeparator_IsValid;

	private static int DecimalSeparator_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:DecimalSeparator")]
	public string DecimalSeparator;

	private static bool GroupingSeparator_IsValid;

	private static int GroupingSeparator_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:GroupingSeparator")]
	public string GroupingSeparator;

	private static bool ReceiptData_IsValid;

	private static int ReceiptData_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:ReceiptData")]
	public string ReceiptData;

	private static bool DynamicFields_IsValid;

	private static FFieldAddress DynamicFields_PropertyAddress;

	private static int DynamicFields_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2:DynamicFields")]
	public Dictionary<string, string> DynamicFields;

	private static bool FInAppPurchaseProductInfo2_IsValid;

	private static int FInAppPurchaseProductInfo2_StructSize;

	public FInAppPurchaseProductInfo2 Copy()
	{
		FInAppPurchaseProductInfo2 result = this;
		if (DynamicFields != null)
		{
			result.DynamicFields = new Dictionary<string, string>(DynamicFields);
		}
		return result;
	}

	public static FInAppPurchaseProductInfo2 FromNative(IntPtr nativeBuffer)
	{
		return new FInAppPurchaseProductInfo2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInAppPurchaseProductInfo2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInAppPurchaseProductInfo2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInAppPurchaseProductInfo2(nativeBuffer + arrayIndex * FInAppPurchaseProductInfo2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInAppPurchaseProductInfo2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInAppPurchaseProductInfo2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TransactionIdentifier_Offset), TransactionIdentifier);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayDescription_Offset), DisplayDescription);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayPrice_Offset), DisplayPrice);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RawPrice_Offset), RawPrice);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrencyCode_Offset), CurrencyCode);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrencySymbol_Offset), CurrencySymbol);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DecimalSeparator_Offset), DecimalSeparator);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, GroupingSeparator_Offset), GroupingSeparator);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ReceiptData_Offset), ReceiptData);
		new TMapCopyMarshaler<string, string>(1, DynamicFields_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, DynamicFields_Offset), DynamicFields);
	}

	public FInAppPurchaseProductInfo2(IntPtr nativeStruct)
	{
		if (!FInAppPurchaseProductInfo2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2");
			Identifier = FStringMarshaler.DefaultString;
			TransactionIdentifier = FStringMarshaler.DefaultString;
			DisplayName = FStringMarshaler.DefaultString;
			DisplayDescription = FStringMarshaler.DefaultString;
			DisplayPrice = FStringMarshaler.DefaultString;
			RawPrice = 0f;
			CurrencyCode = FStringMarshaler.DefaultString;
			CurrencySymbol = FStringMarshaler.DefaultString;
			DecimalSeparator = FStringMarshaler.DefaultString;
			GroupingSeparator = FStringMarshaler.DefaultString;
			ReceiptData = FStringMarshaler.DefaultString;
			DynamicFields = null;
		}
		else
		{
			Identifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
			TransactionIdentifier = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TransactionIdentifier_Offset));
			DisplayName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			DisplayDescription = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayDescription_Offset));
			DisplayPrice = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayPrice_Offset));
			RawPrice = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RawPrice_Offset));
			CurrencyCode = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrencyCode_Offset));
			CurrencySymbol = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrencySymbol_Offset));
			DecimalSeparator = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DecimalSeparator_Offset));
			GroupingSeparator = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, GroupingSeparator_Offset));
			ReceiptData = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ReceiptData_Offset));
			DynamicFields = new TMapCopyMarshaler<string, string>(1, DynamicFields_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, DynamicFields_Offset));
		}
	}

	static FInAppPurchaseProductInfo2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInAppPurchaseProductInfo2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInAppPurchaseProductInfo2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2");
		FInAppPurchaseProductInfo2_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStrProperty);
		TransactionIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransactionIdentifier");
		TransactionIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransactionIdentifier", Classes.FStrProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FStrProperty);
		DisplayDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayDescription");
		DisplayDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayDescription", Classes.FStrProperty);
		DisplayPrice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayPrice");
		DisplayPrice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayPrice", Classes.FStrProperty);
		RawPrice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RawPrice");
		RawPrice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RawPrice", Classes.FFloatProperty);
		CurrencyCode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrencyCode");
		CurrencyCode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrencyCode", Classes.FStrProperty);
		CurrencySymbol_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrencySymbol");
		CurrencySymbol_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrencySymbol", Classes.FStrProperty);
		DecimalSeparator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecimalSeparator");
		DecimalSeparator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecimalSeparator", Classes.FStrProperty);
		GroupingSeparator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupingSeparator");
		GroupingSeparator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupingSeparator", Classes.FStrProperty);
		ReceiptData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReceiptData");
		ReceiptData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReceiptData", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DynamicFields_PropertyAddress, intPtr, "DynamicFields");
		DynamicFields_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicFields");
		DynamicFields_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicFields", Classes.FMapProperty);
		FInAppPurchaseProductInfo2_IsValid = intPtr != IntPtr.Zero && Identifier_IsValid && TransactionIdentifier_IsValid && DisplayName_IsValid && DisplayDescription_IsValid && DisplayPrice_IsValid && RawPrice_IsValid && CurrencyCode_IsValid && CurrencySymbol_IsValid && DecimalSeparator_IsValid && GroupingSeparator_IsValid && ReceiptData_IsValid && DynamicFields_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseProductInfo2", FInAppPurchaseProductInfo2_IsValid);
	}
}
