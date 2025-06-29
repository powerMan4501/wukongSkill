using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public struct FOnlineProxyStoreOffer
{
	private static bool OfferId_IsValid;

	private static int OfferId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:OfferId")]
	public string OfferId;

	private static bool Title_IsValid;

	private static int Title_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:Title")]
	public FText Title;

	private static bool Description_IsValid;

	private static int Description_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:Description")]
	public FText Description;

	private static bool LongDescription_IsValid;

	private static int LongDescription_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:LongDescription")]
	public FText LongDescription;

	private static bool RegularPriceText_IsValid;

	private static int RegularPriceText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:RegularPriceText")]
	public FText RegularPriceText;

	private static bool RegularPrice_IsValid;

	private static int RegularPrice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:RegularPrice")]
	public int RegularPrice;

	private static bool PriceText_IsValid;

	private static int PriceText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:PriceText")]
	public FText PriceText;

	private static bool NumericPrice_IsValid;

	private static int NumericPrice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:NumericPrice")]
	public int NumericPrice;

	private static bool CurrencyCode_IsValid;

	private static int CurrencyCode_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:CurrencyCode")]
	public string CurrencyCode;

	private static bool ReleaseDate_IsValid;

	private static int ReleaseDate_Offset;

	[UProperty(Flags = (PropFlags)6755468160533012uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:ReleaseDate")]
	public FDateTime ReleaseDate;

	private static bool ExpirationDate_IsValid;

	private static int ExpirationDate_Offset;

	[UProperty(Flags = (PropFlags)6755468160533012uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:ExpirationDate")]
	public FDateTime ExpirationDate;

	private static bool DiscountType_IsValid;

	private static FFieldAddress DiscountType_PropertyAddress;

	private static int DiscountType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:DiscountType")]
	public EOnlineProxyStoreOfferDiscountType DiscountType;

	private static bool DynamicFields_IsValid;

	private static FFieldAddress DynamicFields_PropertyAddress;

	private static int DynamicFields_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer:DynamicFields")]
	public Dictionary<string, string> DynamicFields;

	private static bool FOnlineProxyStoreOffer_IsValid;

	private static int FOnlineProxyStoreOffer_StructSize;

	public FOnlineProxyStoreOffer Copy()
	{
		FOnlineProxyStoreOffer result = this;
		if (DynamicFields != null)
		{
			result.DynamicFields = new Dictionary<string, string>(DynamicFields);
		}
		return result;
	}

	public static FOnlineProxyStoreOffer FromNative(IntPtr nativeBuffer)
	{
		return new FOnlineProxyStoreOffer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOnlineProxyStoreOffer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOnlineProxyStoreOffer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOnlineProxyStoreOffer(nativeBuffer + arrayIndex * FOnlineProxyStoreOffer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOnlineProxyStoreOffer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOnlineProxyStoreOffer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOnlineProxyStoreOffer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OfferId_Offset), OfferId);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Title_Offset), Title);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Description_Offset), Description);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, LongDescription_Offset), LongDescription);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, RegularPriceText_Offset), RegularPriceText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RegularPrice_Offset), RegularPrice);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, PriceText_Offset), PriceText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumericPrice_Offset), NumericPrice);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrencyCode_Offset), CurrencyCode);
		FDateTime.ToNative(IntPtr.Add(nativeStruct, ReleaseDate_Offset), ReleaseDate);
		FDateTime.ToNative(IntPtr.Add(nativeStruct, ExpirationDate_Offset), ExpirationDate);
		EnumMarshaler<EOnlineProxyStoreOfferDiscountType>.ToNative(IntPtr.Add(nativeStruct, DiscountType_Offset), 0, DiscountType_PropertyAddress.Address, DiscountType);
		new TMapCopyMarshaler<string, string>(1, DynamicFields_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, DynamicFields_Offset), DynamicFields);
	}

	public FOnlineProxyStoreOffer(IntPtr nativeStruct)
	{
		if (!FOnlineProxyStoreOffer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer");
			OfferId = FStringMarshaler.DefaultString;
			Title = null;
			Description = null;
			LongDescription = null;
			RegularPriceText = null;
			RegularPrice = 0;
			PriceText = null;
			NumericPrice = 0;
			CurrencyCode = FStringMarshaler.DefaultString;
			ReleaseDate = default(FDateTime);
			ExpirationDate = default(FDateTime);
			DiscountType = EOnlineProxyStoreOfferDiscountType.NotOnSale;
			DynamicFields = null;
		}
		else
		{
			OfferId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OfferId_Offset));
			Title = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Title_Offset));
			Description = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Description_Offset));
			LongDescription = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, LongDescription_Offset));
			RegularPriceText = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, RegularPriceText_Offset));
			RegularPrice = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RegularPrice_Offset));
			PriceText = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, PriceText_Offset));
			NumericPrice = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumericPrice_Offset));
			CurrencyCode = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrencyCode_Offset));
			ReleaseDate = FDateTime.FromNative(IntPtr.Add(nativeStruct, ReleaseDate_Offset));
			ExpirationDate = FDateTime.FromNative(IntPtr.Add(nativeStruct, ExpirationDate_Offset));
			DiscountType = EnumMarshaler<EOnlineProxyStoreOfferDiscountType>.FromNative(IntPtr.Add(nativeStruct, DiscountType_Offset), 0, DiscountType_PropertyAddress.Address);
			DynamicFields = new TMapCopyMarshaler<string, string>(1, DynamicFields_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, DynamicFields_Offset));
		}
	}

	static FOnlineProxyStoreOffer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOnlineProxyStoreOffer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnlineProxyStoreOffer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer");
		FOnlineProxyStoreOffer_StructSize = NativeReflection.GetStructSize(intPtr);
		OfferId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OfferId");
		OfferId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OfferId", Classes.FStrProperty);
		Title_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Title");
		Title_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Title", Classes.FTextProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FTextProperty);
		LongDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LongDescription");
		LongDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LongDescription", Classes.FTextProperty);
		RegularPriceText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RegularPriceText");
		RegularPriceText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RegularPriceText", Classes.FTextProperty);
		RegularPrice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RegularPrice");
		RegularPrice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RegularPrice", Classes.FIntProperty);
		PriceText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriceText");
		PriceText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriceText", Classes.FTextProperty);
		NumericPrice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumericPrice");
		NumericPrice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumericPrice", Classes.FIntProperty);
		CurrencyCode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrencyCode");
		CurrencyCode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrencyCode", Classes.FStrProperty);
		ReleaseDate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseDate");
		ReleaseDate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseDate", Classes.FStructProperty);
		ExpirationDate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExpirationDate");
		ExpirationDate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExpirationDate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DiscountType_PropertyAddress, intPtr, "DiscountType");
		DiscountType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DiscountType");
		DiscountType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DiscountType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DynamicFields_PropertyAddress, intPtr, "DynamicFields");
		DynamicFields_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicFields");
		DynamicFields_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicFields", Classes.FMapProperty);
		FOnlineProxyStoreOffer_IsValid = intPtr != IntPtr.Zero && OfferId_IsValid && Title_IsValid && Description_IsValid && LongDescription_IsValid && RegularPriceText_IsValid && RegularPrice_IsValid && PriceText_IsValid && NumericPrice_IsValid && CurrencyCode_IsValid && ReleaseDate_IsValid && ExpirationDate_IsValid && DiscountType_IsValid && DynamicFields_IsValid;
		NativeReflection.LogStructIsValid("/Script/OnlineSubsystemUtils.OnlineProxyStoreOffer", FOnlineProxyStoreOffer_IsValid);
	}
}
