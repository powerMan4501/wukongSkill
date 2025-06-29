using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 8)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.PolyglotTextData", "CoreUObject", UnrealModuleType.Engine)]
public struct FPolyglotTextData
{
	private static bool Category_IsValid;

	private static FFieldAddress Category_PropertyAddress;

	private static int Category_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:Category")]
	public ELocalizedTextSourceCategory Category;

	private static bool NativeCulture_IsValid;

	private static int NativeCulture_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:NativeCulture")]
	public string NativeCulture;

	private static bool Namespace_IsValid;

	private static int Namespace_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:Namespace")]
	public string Namespace;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:Key")]
	public string Key;

	private static bool NativeString_IsValid;

	private static int NativeString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:NativeString")]
	public string NativeString;

	private static bool LocalizedStrings_IsValid;

	private static FFieldAddress LocalizedStrings_PropertyAddress;

	private static int LocalizedStrings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:LocalizedStrings")]
	public Dictionary<string, string> LocalizedStrings;

	private static bool IsMinimalPatch_IsValid;

	private static FFieldAddress IsMinimalPatch_PropertyAddress;

	private static int IsMinimalPatch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.PolyglotTextData:bIsMinimalPatch")]
	public bool IsMinimalPatch;

	private static bool FPolyglotTextData_IsValid;

	private static int FPolyglotTextData_StructSize;

	public FPolyglotTextData Copy()
	{
		FPolyglotTextData result = this;
		if (LocalizedStrings != null)
		{
			result.LocalizedStrings = new Dictionary<string, string>(LocalizedStrings);
		}
		return result;
	}

	public static FPolyglotTextData FromNative(IntPtr nativeBuffer)
	{
		return new FPolyglotTextData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPolyglotTextData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPolyglotTextData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPolyglotTextData(nativeBuffer + arrayIndex * FPolyglotTextData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPolyglotTextData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPolyglotTextData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPolyglotTextData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PolyglotTextData");
			return;
		}
		EnumMarshaler<ELocalizedTextSourceCategory>.ToNative(IntPtr.Add(nativeStruct, Category_Offset), 0, Category_PropertyAddress.Address, Category);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NativeCulture_Offset), NativeCulture);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Namespace_Offset), Namespace);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NativeString_Offset), NativeString);
		new TMapCopyMarshaler<string, string>(1, LocalizedStrings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, LocalizedStrings_Offset), LocalizedStrings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsMinimalPatch_Offset), 0, IsMinimalPatch_PropertyAddress.Address, IsMinimalPatch);
	}

	public FPolyglotTextData(IntPtr nativeStruct)
	{
		if (!FPolyglotTextData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PolyglotTextData");
			Category = ELocalizedTextSourceCategory.Game;
			NativeCulture = FStringMarshaler.DefaultString;
			Namespace = FStringMarshaler.DefaultString;
			Key = FStringMarshaler.DefaultString;
			NativeString = FStringMarshaler.DefaultString;
			LocalizedStrings = null;
			IsMinimalPatch = false;
		}
		else
		{
			Category = EnumMarshaler<ELocalizedTextSourceCategory>.FromNative(IntPtr.Add(nativeStruct, Category_Offset), 0, Category_PropertyAddress.Address);
			NativeCulture = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NativeCulture_Offset));
			Namespace = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Namespace_Offset));
			Key = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			NativeString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NativeString_Offset));
			LocalizedStrings = new TMapCopyMarshaler<string, string>(1, LocalizedStrings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, LocalizedStrings_Offset));
			IsMinimalPatch = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsMinimalPatch_Offset), 0, IsMinimalPatch_PropertyAddress.Address);
		}
	}

	static FPolyglotTextData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPolyglotTextData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPolyglotTextData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.PolyglotTextData");
		FPolyglotTextData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Category_PropertyAddress, intPtr, "Category");
		Category_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Category");
		Category_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Category", Classes.FEnumProperty);
		NativeCulture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NativeCulture");
		NativeCulture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NativeCulture", Classes.FStrProperty);
		Namespace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Namespace");
		Namespace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Namespace", Classes.FStrProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStrProperty);
		NativeString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NativeString");
		NativeString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NativeString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizedStrings_PropertyAddress, intPtr, "LocalizedStrings");
		LocalizedStrings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalizedStrings");
		LocalizedStrings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalizedStrings", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMinimalPatch_PropertyAddress, intPtr, "bIsMinimalPatch");
		IsMinimalPatch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsMinimalPatch");
		IsMinimalPatch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsMinimalPatch", Classes.FBoolProperty);
		FPolyglotTextData_IsValid = intPtr != IntPtr.Zero && Category_IsValid && NativeCulture_IsValid && Namespace_IsValid && Key_IsValid && NativeString_IsValid && LocalizedStrings_IsValid && IsMinimalPatch_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.PolyglotTextData", FPolyglotTextData_IsValid);
	}
}
