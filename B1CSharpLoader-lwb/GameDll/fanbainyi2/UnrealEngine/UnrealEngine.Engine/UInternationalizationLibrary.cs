using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetInternationalizationLibrary", "Engine", UnrealModuleType.Engine)]
public class UInternationalizationLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetCurrentLocale_IsValid;

	private static IntPtr SetCurrentLocale_FunctionAddress;

	private static int SetCurrentLocale_ParamsSize;

	private static bool SetCurrentLocale_Culture_IsValid;

	private static FFieldAddress SetCurrentLocale_Culture_PropertyAddress;

	private static int SetCurrentLocale_Culture_Offset;

	private static bool SetCurrentLocale_SaveToConfig_IsValid;

	private static FFieldAddress SetCurrentLocale_SaveToConfig_PropertyAddress;

	private static int SetCurrentLocale_SaveToConfig_Offset;

	private static bool SetCurrentLocale_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentLocale_ReturnValue_PropertyAddress;

	private static int SetCurrentLocale_ReturnValue_Offset;

	private static bool SetCurrentLanguageAndLocale_IsValid;

	private static IntPtr SetCurrentLanguageAndLocale_FunctionAddress;

	private static int SetCurrentLanguageAndLocale_ParamsSize;

	private static bool SetCurrentLanguageAndLocale_Culture_IsValid;

	private static FFieldAddress SetCurrentLanguageAndLocale_Culture_PropertyAddress;

	private static int SetCurrentLanguageAndLocale_Culture_Offset;

	private static bool SetCurrentLanguageAndLocale_SaveToConfig_IsValid;

	private static FFieldAddress SetCurrentLanguageAndLocale_SaveToConfig_PropertyAddress;

	private static int SetCurrentLanguageAndLocale_SaveToConfig_Offset;

	private static bool SetCurrentLanguageAndLocale_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentLanguageAndLocale_ReturnValue_PropertyAddress;

	private static int SetCurrentLanguageAndLocale_ReturnValue_Offset;

	private static bool SetCurrentLanguage_IsValid;

	private static IntPtr SetCurrentLanguage_FunctionAddress;

	private static int SetCurrentLanguage_ParamsSize;

	private static bool SetCurrentLanguage_Culture_IsValid;

	private static FFieldAddress SetCurrentLanguage_Culture_PropertyAddress;

	private static int SetCurrentLanguage_Culture_Offset;

	private static bool SetCurrentLanguage_SaveToConfig_IsValid;

	private static FFieldAddress SetCurrentLanguage_SaveToConfig_PropertyAddress;

	private static int SetCurrentLanguage_SaveToConfig_Offset;

	private static bool SetCurrentLanguage_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentLanguage_ReturnValue_PropertyAddress;

	private static int SetCurrentLanguage_ReturnValue_Offset;

	private static bool SetCurrentCulture_IsValid;

	private static IntPtr SetCurrentCulture_FunctionAddress;

	private static int SetCurrentCulture_ParamsSize;

	private static bool SetCurrentCulture_Culture_IsValid;

	private static FFieldAddress SetCurrentCulture_Culture_PropertyAddress;

	private static int SetCurrentCulture_Culture_Offset;

	private static bool SetCurrentCulture_SaveToConfig_IsValid;

	private static FFieldAddress SetCurrentCulture_SaveToConfig_PropertyAddress;

	private static int SetCurrentCulture_SaveToConfig_Offset;

	private static bool SetCurrentCulture_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentCulture_ReturnValue_PropertyAddress;

	private static int SetCurrentCulture_ReturnValue_Offset;

	private static bool SetCurrentAssetGroupCulture_IsValid;

	private static IntPtr SetCurrentAssetGroupCulture_FunctionAddress;

	private static int SetCurrentAssetGroupCulture_ParamsSize;

	private static bool SetCurrentAssetGroupCulture_AssetGroup_IsValid;

	private static FFieldAddress SetCurrentAssetGroupCulture_AssetGroup_PropertyAddress;

	private static int SetCurrentAssetGroupCulture_AssetGroup_Offset;

	private static bool SetCurrentAssetGroupCulture_Culture_IsValid;

	private static FFieldAddress SetCurrentAssetGroupCulture_Culture_PropertyAddress;

	private static int SetCurrentAssetGroupCulture_Culture_Offset;

	private static bool SetCurrentAssetGroupCulture_SaveToConfig_IsValid;

	private static FFieldAddress SetCurrentAssetGroupCulture_SaveToConfig_PropertyAddress;

	private static int SetCurrentAssetGroupCulture_SaveToConfig_Offset;

	private static bool SetCurrentAssetGroupCulture_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentAssetGroupCulture_ReturnValue_PropertyAddress;

	private static int SetCurrentAssetGroupCulture_ReturnValue_Offset;

	private static bool GetSuitableCulture_IsValid;

	private static IntPtr GetSuitableCulture_FunctionAddress;

	private static int GetSuitableCulture_ParamsSize;

	private static bool GetSuitableCulture_AvailableCultures_IsValid;

	private static FFieldAddress GetSuitableCulture_AvailableCultures_PropertyAddress;

	private static int GetSuitableCulture_AvailableCultures_Offset;

	private static bool GetSuitableCulture_CultureToMatch_IsValid;

	private static FFieldAddress GetSuitableCulture_CultureToMatch_PropertyAddress;

	private static int GetSuitableCulture_CultureToMatch_Offset;

	private static bool GetSuitableCulture_FallbackCulture_IsValid;

	private static FFieldAddress GetSuitableCulture_FallbackCulture_PropertyAddress;

	private static int GetSuitableCulture_FallbackCulture_Offset;

	private static bool GetSuitableCulture_ReturnValue_IsValid;

	private static FFieldAddress GetSuitableCulture_ReturnValue_PropertyAddress;

	private static int GetSuitableCulture_ReturnValue_Offset;

	private static bool GetNativeCulture_IsValid;

	private static IntPtr GetNativeCulture_FunctionAddress;

	private static int GetNativeCulture_ParamsSize;

	private static bool GetNativeCulture_TextCategory_IsValid;

	private static FFieldAddress GetNativeCulture_TextCategory_PropertyAddress;

	private static int GetNativeCulture_TextCategory_Offset;

	private static bool GetNativeCulture_ReturnValue_IsValid;

	private static FFieldAddress GetNativeCulture_ReturnValue_PropertyAddress;

	private static int GetNativeCulture_ReturnValue_Offset;

	private static bool GetLocalizedCultures_IsValid;

	private static IntPtr GetLocalizedCultures_FunctionAddress;

	private static int GetLocalizedCultures_ParamsSize;

	private static bool GetLocalizedCultures_IncludeGame_IsValid;

	private static FFieldAddress GetLocalizedCultures_IncludeGame_PropertyAddress;

	private static int GetLocalizedCultures_IncludeGame_Offset;

	private static bool GetLocalizedCultures_IncludeEngine_IsValid;

	private static FFieldAddress GetLocalizedCultures_IncludeEngine_PropertyAddress;

	private static int GetLocalizedCultures_IncludeEngine_Offset;

	private static bool GetLocalizedCultures_IncludeEditor_IsValid;

	private static FFieldAddress GetLocalizedCultures_IncludeEditor_PropertyAddress;

	private static int GetLocalizedCultures_IncludeEditor_Offset;

	private static bool GetLocalizedCultures_IncludeAdditional_IsValid;

	private static FFieldAddress GetLocalizedCultures_IncludeAdditional_PropertyAddress;

	private static int GetLocalizedCultures_IncludeAdditional_Offset;

	private static bool GetLocalizedCultures_ReturnValue_IsValid;

	private static FFieldAddress GetLocalizedCultures_ReturnValue_PropertyAddress;

	private static int GetLocalizedCultures_ReturnValue_Offset;

	private static bool GetCurrentLocale_IsValid;

	private static IntPtr GetCurrentLocale_FunctionAddress;

	private static int GetCurrentLocale_ParamsSize;

	private static bool GetCurrentLocale_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLocale_ReturnValue_PropertyAddress;

	private static int GetCurrentLocale_ReturnValue_Offset;

	private static bool GetCurrentLanguage_IsValid;

	private static IntPtr GetCurrentLanguage_FunctionAddress;

	private static int GetCurrentLanguage_ParamsSize;

	private static bool GetCurrentLanguage_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLanguage_ReturnValue_PropertyAddress;

	private static int GetCurrentLanguage_ReturnValue_Offset;

	private static bool GetCurrentCulture_IsValid;

	private static IntPtr GetCurrentCulture_FunctionAddress;

	private static int GetCurrentCulture_ParamsSize;

	private static bool GetCurrentCulture_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentCulture_ReturnValue_PropertyAddress;

	private static int GetCurrentCulture_ReturnValue_Offset;

	private static bool GetCurrentAssetGroupCulture_IsValid;

	private static IntPtr GetCurrentAssetGroupCulture_FunctionAddress;

	private static int GetCurrentAssetGroupCulture_ParamsSize;

	private static bool GetCurrentAssetGroupCulture_AssetGroup_IsValid;

	private static FFieldAddress GetCurrentAssetGroupCulture_AssetGroup_PropertyAddress;

	private static int GetCurrentAssetGroupCulture_AssetGroup_Offset;

	private static bool GetCurrentAssetGroupCulture_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentAssetGroupCulture_ReturnValue_PropertyAddress;

	private static int GetCurrentAssetGroupCulture_ReturnValue_Offset;

	private static bool GetCultureDisplayName_IsValid;

	private static IntPtr GetCultureDisplayName_FunctionAddress;

	private static int GetCultureDisplayName_ParamsSize;

	private static bool GetCultureDisplayName_Culture_IsValid;

	private static FFieldAddress GetCultureDisplayName_Culture_PropertyAddress;

	private static int GetCultureDisplayName_Culture_Offset;

	private static bool GetCultureDisplayName_Localized_IsValid;

	private static FFieldAddress GetCultureDisplayName_Localized_PropertyAddress;

	private static int GetCultureDisplayName_Localized_Offset;

	private static bool GetCultureDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetCultureDisplayName_ReturnValue_PropertyAddress;

	private static int GetCultureDisplayName_ReturnValue_Offset;

	private static bool ClearCurrentAssetGroupCulture_IsValid;

	private static IntPtr ClearCurrentAssetGroupCulture_FunctionAddress;

	private static int ClearCurrentAssetGroupCulture_ParamsSize;

	private static bool ClearCurrentAssetGroupCulture_AssetGroup_IsValid;

	private static FFieldAddress ClearCurrentAssetGroupCulture_AssetGroup_PropertyAddress;

	private static int ClearCurrentAssetGroupCulture_AssetGroup_Offset;

	private static bool ClearCurrentAssetGroupCulture_SaveToConfig_IsValid;

	private static FFieldAddress ClearCurrentAssetGroupCulture_SaveToConfig_PropertyAddress;

	private static int ClearCurrentAssetGroupCulture_SaveToConfig_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLocale")]
	public unsafe static bool SetCurrentLocale(string Culture, bool SaveToConfig = false)
	{
		if (!SetCurrentLocale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLocale");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLocale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLocale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLocale_Culture_Offset), 0, SetCurrentLocale_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLocale_SaveToConfig_Offset), 0, SetCurrentLocale_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentLocale_FunctionAddress, intPtr, SetCurrentLocale_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentLocale_Culture_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentLocale_ReturnValue_Offset), 0, SetCurrentLocale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguageAndLocale")]
	public unsafe static bool SetCurrentLanguageAndLocale(string Culture, bool SaveToConfig = false)
	{
		if (!SetCurrentLanguageAndLocale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguageAndLocale");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLanguageAndLocale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLanguageAndLocale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLanguageAndLocale_Culture_Offset), 0, SetCurrentLanguageAndLocale_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLanguageAndLocale_SaveToConfig_Offset), 0, SetCurrentLanguageAndLocale_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentLanguageAndLocale_FunctionAddress, intPtr, SetCurrentLanguageAndLocale_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentLanguageAndLocale_Culture_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentLanguageAndLocale_ReturnValue_Offset), 0, SetCurrentLanguageAndLocale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguage")]
	public unsafe static bool SetCurrentLanguage(string Culture, bool SaveToConfig = false)
	{
		if (!SetCurrentLanguage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLanguage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLanguage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLanguage_Culture_Offset), 0, SetCurrentLanguage_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentLanguage_SaveToConfig_Offset), 0, SetCurrentLanguage_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentLanguage_FunctionAddress, intPtr, SetCurrentLanguage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentLanguage_Culture_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentLanguage_ReturnValue_Offset), 0, SetCurrentLanguage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:SetCurrentCulture")]
	public unsafe static bool SetCurrentCulture(string Culture, bool SaveToConfig = false)
	{
		if (!SetCurrentCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:SetCurrentCulture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentCulture_Culture_Offset), 0, SetCurrentCulture_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentCulture_SaveToConfig_Offset), 0, SetCurrentCulture_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentCulture_FunctionAddress, intPtr, SetCurrentCulture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentCulture_Culture_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentCulture_ReturnValue_Offset), 0, SetCurrentCulture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:SetCurrentAssetGroupCulture")]
	public unsafe static bool SetCurrentAssetGroupCulture(FName AssetGroup, string Culture, bool SaveToConfig = false)
	{
		if (!SetCurrentAssetGroupCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:SetCurrentAssetGroupCulture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentAssetGroupCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentAssetGroupCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCurrentAssetGroupCulture_AssetGroup_Offset), 0, SetCurrentAssetGroupCulture_AssetGroup_PropertyAddress.Address, AssetGroup);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentAssetGroupCulture_Culture_Offset), 0, SetCurrentAssetGroupCulture_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentAssetGroupCulture_SaveToConfig_Offset), 0, SetCurrentAssetGroupCulture_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentAssetGroupCulture_FunctionAddress, intPtr, SetCurrentAssetGroupCulture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentAssetGroupCulture_Culture_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentAssetGroupCulture_ReturnValue_Offset), 0, SetCurrentAssetGroupCulture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetSuitableCulture")]
	public unsafe static string GetSuitableCulture(List<string> AvailableCultures, string CultureToMatch, string FallbackCulture = "en")
	{
		if (!GetSuitableCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetSuitableCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSuitableCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSuitableCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetSuitableCulture_AvailableCultures_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetSuitableCulture_AvailableCultures_Offset), AvailableCultures);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSuitableCulture_CultureToMatch_Offset), 0, GetSuitableCulture_CultureToMatch_PropertyAddress.Address, CultureToMatch);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSuitableCulture_FallbackCulture_Offset), 0, GetSuitableCulture_FallbackCulture_PropertyAddress.Address, FallbackCulture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSuitableCulture_FunctionAddress, intPtr, GetSuitableCulture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSuitableCulture_AvailableCultures_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetSuitableCulture_CultureToMatch_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetSuitableCulture_FallbackCulture_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSuitableCulture_ReturnValue_Offset), 0, GetSuitableCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSuitableCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetNativeCulture")]
	public unsafe static string GetNativeCulture(ELocalizedTextSourceCategory TextCategory)
	{
		if (!GetNativeCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetNativeCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNativeCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNativeCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELocalizedTextSourceCategory>.ToNative(IntPtr.Add(intPtr, GetNativeCulture_TextCategory_Offset), 0, GetNativeCulture_TextCategory_PropertyAddress.Address, TextCategory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNativeCulture_FunctionAddress, intPtr, GetNativeCulture_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNativeCulture_ReturnValue_Offset), 0, GetNativeCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNativeCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetLocalizedCultures")]
	public unsafe static List<string> GetLocalizedCultures(bool IncludeGame = true, bool IncludeEngine = false, bool IncludeEditor = false, bool IncludeAdditional = false)
	{
		if (!GetLocalizedCultures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetLocalizedCultures");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalizedCultures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalizedCultures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalizedCultures_IncludeGame_Offset), 0, GetLocalizedCultures_IncludeGame_PropertyAddress.Address, IncludeGame);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalizedCultures_IncludeEngine_Offset), 0, GetLocalizedCultures_IncludeEngine_PropertyAddress.Address, IncludeEngine);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalizedCultures_IncludeEditor_Offset), 0, GetLocalizedCultures_IncludeEditor_PropertyAddress.Address, IncludeEditor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalizedCultures_IncludeAdditional_Offset), 0, GetLocalizedCultures_IncludeAdditional_PropertyAddress.Address, IncludeAdditional);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalizedCultures_FunctionAddress, intPtr, GetLocalizedCultures_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetLocalizedCultures_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLocalizedCultures_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLocalizedCultures_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLocale")]
	public unsafe static string GetCurrentLocale()
	{
		if (!GetCurrentLocale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLocale");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLocale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLocale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentLocale_FunctionAddress, intPtr, GetCurrentLocale_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentLocale_ReturnValue_Offset), 0, GetCurrentLocale_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentLocale_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLanguage")]
	public unsafe static string GetCurrentLanguage()
	{
		if (!GetCurrentLanguage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLanguage");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLanguage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLanguage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentLanguage_FunctionAddress, intPtr, GetCurrentLanguage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentLanguage_ReturnValue_Offset), 0, GetCurrentLanguage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentLanguage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetCurrentCulture")]
	public unsafe static string GetCurrentCulture()
	{
		if (!GetCurrentCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetCurrentCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentCulture_FunctionAddress, intPtr, GetCurrentCulture_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentCulture_ReturnValue_Offset), 0, GetCurrentCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetCurrentAssetGroupCulture")]
	public unsafe static string GetCurrentAssetGroupCulture(FName AssetGroup)
	{
		if (!GetCurrentAssetGroupCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetCurrentAssetGroupCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAssetGroupCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAssetGroupCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCurrentAssetGroupCulture_AssetGroup_Offset), 0, GetCurrentAssetGroupCulture_AssetGroup_PropertyAddress.Address, AssetGroup);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentAssetGroupCulture_FunctionAddress, intPtr, GetCurrentAssetGroupCulture_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentAssetGroupCulture_ReturnValue_Offset), 0, GetCurrentAssetGroupCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentAssetGroupCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:GetCultureDisplayName")]
	public unsafe static string GetCultureDisplayName(string Culture, bool Localized = true)
	{
		if (!GetCultureDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:GetCultureDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCultureDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCultureDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetCultureDisplayName_Culture_Offset), 0, GetCultureDisplayName_Culture_PropertyAddress.Address, Culture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetCultureDisplayName_Localized_Offset), 0, GetCultureDisplayName_Localized_PropertyAddress.Address, Localized);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCultureDisplayName_FunctionAddress, intPtr, GetCultureDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCultureDisplayName_Culture_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCultureDisplayName_ReturnValue_Offset), 0, GetCultureDisplayName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCultureDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInternationalizationLibrary:ClearCurrentAssetGroupCulture")]
	public unsafe static void ClearCurrentAssetGroupCulture(FName AssetGroup, bool SaveToConfig = false)
	{
		if (!ClearCurrentAssetGroupCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInternationalizationLibrary:ClearCurrentAssetGroupCulture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearCurrentAssetGroupCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearCurrentAssetGroupCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearCurrentAssetGroupCulture_AssetGroup_Offset), 0, ClearCurrentAssetGroupCulture_AssetGroup_PropertyAddress.Address, AssetGroup);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearCurrentAssetGroupCulture_SaveToConfig_Offset), 0, ClearCurrentAssetGroupCulture_SaveToConfig_PropertyAddress.Address, SaveToConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearCurrentAssetGroupCulture_FunctionAddress, intPtr, ClearCurrentAssetGroupCulture_ParamsSize);
	}

	static UInternationalizationLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInternationalizationLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInternationalizationLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetInternationalizationLibrary");
		SetCurrentLocale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentLocale");
		SetCurrentLocale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLocale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLocale_Culture_PropertyAddress, SetCurrentLocale_FunctionAddress, "Culture");
		SetCurrentLocale_Culture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLocale_FunctionAddress, "Culture");
		SetCurrentLocale_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLocale_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLocale_SaveToConfig_PropertyAddress, SetCurrentLocale_FunctionAddress, "SaveToConfig");
		SetCurrentLocale_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLocale_FunctionAddress, "SaveToConfig");
		SetCurrentLocale_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLocale_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLocale_ReturnValue_PropertyAddress, SetCurrentLocale_FunctionAddress, "ReturnValue");
		SetCurrentLocale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLocale_FunctionAddress, "ReturnValue");
		SetCurrentLocale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLocale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentLocale_IsValid = SetCurrentLocale_FunctionAddress != IntPtr.Zero && SetCurrentLocale_Culture_IsValid && SetCurrentLocale_SaveToConfig_IsValid && SetCurrentLocale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLocale", SetCurrentLocale_IsValid);
		SetCurrentLanguageAndLocale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentLanguageAndLocale");
		SetCurrentLanguageAndLocale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLanguageAndLocale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguageAndLocale_Culture_PropertyAddress, SetCurrentLanguageAndLocale_FunctionAddress, "Culture");
		SetCurrentLanguageAndLocale_Culture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguageAndLocale_FunctionAddress, "Culture");
		SetCurrentLanguageAndLocale_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguageAndLocale_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguageAndLocale_SaveToConfig_PropertyAddress, SetCurrentLanguageAndLocale_FunctionAddress, "SaveToConfig");
		SetCurrentLanguageAndLocale_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguageAndLocale_FunctionAddress, "SaveToConfig");
		SetCurrentLanguageAndLocale_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguageAndLocale_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguageAndLocale_ReturnValue_PropertyAddress, SetCurrentLanguageAndLocale_FunctionAddress, "ReturnValue");
		SetCurrentLanguageAndLocale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguageAndLocale_FunctionAddress, "ReturnValue");
		SetCurrentLanguageAndLocale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguageAndLocale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentLanguageAndLocale_IsValid = SetCurrentLanguageAndLocale_FunctionAddress != IntPtr.Zero && SetCurrentLanguageAndLocale_Culture_IsValid && SetCurrentLanguageAndLocale_SaveToConfig_IsValid && SetCurrentLanguageAndLocale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguageAndLocale", SetCurrentLanguageAndLocale_IsValid);
		SetCurrentLanguage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentLanguage");
		SetCurrentLanguage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLanguage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguage_Culture_PropertyAddress, SetCurrentLanguage_FunctionAddress, "Culture");
		SetCurrentLanguage_Culture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguage_FunctionAddress, "Culture");
		SetCurrentLanguage_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguage_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguage_SaveToConfig_PropertyAddress, SetCurrentLanguage_FunctionAddress, "SaveToConfig");
		SetCurrentLanguage_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguage_FunctionAddress, "SaveToConfig");
		SetCurrentLanguage_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguage_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLanguage_ReturnValue_PropertyAddress, SetCurrentLanguage_FunctionAddress, "ReturnValue");
		SetCurrentLanguage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLanguage_FunctionAddress, "ReturnValue");
		SetCurrentLanguage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLanguage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentLanguage_IsValid = SetCurrentLanguage_FunctionAddress != IntPtr.Zero && SetCurrentLanguage_Culture_IsValid && SetCurrentLanguage_SaveToConfig_IsValid && SetCurrentLanguage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:SetCurrentLanguage", SetCurrentLanguage_IsValid);
		SetCurrentCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentCulture");
		SetCurrentCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentCulture_Culture_PropertyAddress, SetCurrentCulture_FunctionAddress, "Culture");
		SetCurrentCulture_Culture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentCulture_FunctionAddress, "Culture");
		SetCurrentCulture_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentCulture_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentCulture_SaveToConfig_PropertyAddress, SetCurrentCulture_FunctionAddress, "SaveToConfig");
		SetCurrentCulture_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentCulture_FunctionAddress, "SaveToConfig");
		SetCurrentCulture_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentCulture_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentCulture_ReturnValue_PropertyAddress, SetCurrentCulture_FunctionAddress, "ReturnValue");
		SetCurrentCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentCulture_FunctionAddress, "ReturnValue");
		SetCurrentCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentCulture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentCulture_IsValid = SetCurrentCulture_FunctionAddress != IntPtr.Zero && SetCurrentCulture_Culture_IsValid && SetCurrentCulture_SaveToConfig_IsValid && SetCurrentCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:SetCurrentCulture", SetCurrentCulture_IsValid);
		SetCurrentAssetGroupCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentAssetGroupCulture");
		SetCurrentAssetGroupCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentAssetGroupCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAssetGroupCulture_AssetGroup_PropertyAddress, SetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		SetCurrentAssetGroupCulture_AssetGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		SetCurrentAssetGroupCulture_AssetGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAssetGroupCulture_Culture_PropertyAddress, SetCurrentAssetGroupCulture_FunctionAddress, "Culture");
		SetCurrentAssetGroupCulture_Culture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAssetGroupCulture_FunctionAddress, "Culture");
		SetCurrentAssetGroupCulture_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAssetGroupCulture_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAssetGroupCulture_SaveToConfig_PropertyAddress, SetCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig");
		SetCurrentAssetGroupCulture_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig");
		SetCurrentAssetGroupCulture_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAssetGroupCulture_ReturnValue_PropertyAddress, SetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue");
		SetCurrentAssetGroupCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue");
		SetCurrentAssetGroupCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentAssetGroupCulture_IsValid = SetCurrentAssetGroupCulture_FunctionAddress != IntPtr.Zero && SetCurrentAssetGroupCulture_AssetGroup_IsValid && SetCurrentAssetGroupCulture_Culture_IsValid && SetCurrentAssetGroupCulture_SaveToConfig_IsValid && SetCurrentAssetGroupCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:SetCurrentAssetGroupCulture", SetCurrentAssetGroupCulture_IsValid);
		GetSuitableCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSuitableCulture");
		GetSuitableCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSuitableCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSuitableCulture_AvailableCultures_PropertyAddress, GetSuitableCulture_FunctionAddress, "AvailableCultures");
		GetSuitableCulture_AvailableCultures_Offset = NativeReflectionCached.GetPropertyOffset(GetSuitableCulture_FunctionAddress, "AvailableCultures");
		GetSuitableCulture_AvailableCultures_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSuitableCulture_FunctionAddress, "AvailableCultures", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSuitableCulture_CultureToMatch_PropertyAddress, GetSuitableCulture_FunctionAddress, "CultureToMatch");
		GetSuitableCulture_CultureToMatch_Offset = NativeReflectionCached.GetPropertyOffset(GetSuitableCulture_FunctionAddress, "CultureToMatch");
		GetSuitableCulture_CultureToMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSuitableCulture_FunctionAddress, "CultureToMatch", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSuitableCulture_FallbackCulture_PropertyAddress, GetSuitableCulture_FunctionAddress, "FallbackCulture");
		GetSuitableCulture_FallbackCulture_Offset = NativeReflectionCached.GetPropertyOffset(GetSuitableCulture_FunctionAddress, "FallbackCulture");
		GetSuitableCulture_FallbackCulture_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSuitableCulture_FunctionAddress, "FallbackCulture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSuitableCulture_ReturnValue_PropertyAddress, GetSuitableCulture_FunctionAddress, "ReturnValue");
		GetSuitableCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSuitableCulture_FunctionAddress, "ReturnValue");
		GetSuitableCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSuitableCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSuitableCulture_IsValid = GetSuitableCulture_FunctionAddress != IntPtr.Zero && GetSuitableCulture_AvailableCultures_IsValid && GetSuitableCulture_CultureToMatch_IsValid && GetSuitableCulture_FallbackCulture_IsValid && GetSuitableCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetSuitableCulture", GetSuitableCulture_IsValid);
		GetNativeCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNativeCulture");
		GetNativeCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNativeCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNativeCulture_TextCategory_PropertyAddress, GetNativeCulture_FunctionAddress, "TextCategory");
		GetNativeCulture_TextCategory_Offset = NativeReflectionCached.GetPropertyOffset(GetNativeCulture_FunctionAddress, "TextCategory");
		GetNativeCulture_TextCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNativeCulture_FunctionAddress, "TextCategory", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNativeCulture_ReturnValue_PropertyAddress, GetNativeCulture_FunctionAddress, "ReturnValue");
		GetNativeCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNativeCulture_FunctionAddress, "ReturnValue");
		GetNativeCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNativeCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNativeCulture_IsValid = GetNativeCulture_FunctionAddress != IntPtr.Zero && GetNativeCulture_TextCategory_IsValid && GetNativeCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetNativeCulture", GetNativeCulture_IsValid);
		GetLocalizedCultures_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalizedCultures");
		GetLocalizedCultures_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalizedCultures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalizedCultures_IncludeGame_PropertyAddress, GetLocalizedCultures_FunctionAddress, "IncludeGame");
		GetLocalizedCultures_IncludeGame_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalizedCultures_FunctionAddress, "IncludeGame");
		GetLocalizedCultures_IncludeGame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalizedCultures_FunctionAddress, "IncludeGame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalizedCultures_IncludeEngine_PropertyAddress, GetLocalizedCultures_FunctionAddress, "IncludeEngine");
		GetLocalizedCultures_IncludeEngine_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalizedCultures_FunctionAddress, "IncludeEngine");
		GetLocalizedCultures_IncludeEngine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalizedCultures_FunctionAddress, "IncludeEngine", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalizedCultures_IncludeEditor_PropertyAddress, GetLocalizedCultures_FunctionAddress, "IncludeEditor");
		GetLocalizedCultures_IncludeEditor_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalizedCultures_FunctionAddress, "IncludeEditor");
		GetLocalizedCultures_IncludeEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalizedCultures_FunctionAddress, "IncludeEditor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalizedCultures_IncludeAdditional_PropertyAddress, GetLocalizedCultures_FunctionAddress, "IncludeAdditional");
		GetLocalizedCultures_IncludeAdditional_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalizedCultures_FunctionAddress, "IncludeAdditional");
		GetLocalizedCultures_IncludeAdditional_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalizedCultures_FunctionAddress, "IncludeAdditional", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalizedCultures_ReturnValue_PropertyAddress, GetLocalizedCultures_FunctionAddress, "ReturnValue");
		GetLocalizedCultures_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalizedCultures_FunctionAddress, "ReturnValue");
		GetLocalizedCultures_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalizedCultures_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLocalizedCultures_IsValid = GetLocalizedCultures_FunctionAddress != IntPtr.Zero && GetLocalizedCultures_IncludeGame_IsValid && GetLocalizedCultures_IncludeEngine_IsValid && GetLocalizedCultures_IncludeEditor_IsValid && GetLocalizedCultures_IncludeAdditional_IsValid && GetLocalizedCultures_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetLocalizedCultures", GetLocalizedCultures_IsValid);
		GetCurrentLocale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentLocale");
		GetCurrentLocale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLocale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLocale_ReturnValue_PropertyAddress, GetCurrentLocale_FunctionAddress, "ReturnValue");
		GetCurrentLocale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLocale_FunctionAddress, "ReturnValue");
		GetCurrentLocale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLocale_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentLocale_IsValid = GetCurrentLocale_FunctionAddress != IntPtr.Zero && GetCurrentLocale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLocale", GetCurrentLocale_IsValid);
		GetCurrentLanguage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentLanguage");
		GetCurrentLanguage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLanguage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLanguage_ReturnValue_PropertyAddress, GetCurrentLanguage_FunctionAddress, "ReturnValue");
		GetCurrentLanguage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLanguage_FunctionAddress, "ReturnValue");
		GetCurrentLanguage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLanguage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentLanguage_IsValid = GetCurrentLanguage_FunctionAddress != IntPtr.Zero && GetCurrentLanguage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetCurrentLanguage", GetCurrentLanguage_IsValid);
		GetCurrentCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentCulture");
		GetCurrentCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentCulture_ReturnValue_PropertyAddress, GetCurrentCulture_FunctionAddress, "ReturnValue");
		GetCurrentCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentCulture_FunctionAddress, "ReturnValue");
		GetCurrentCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentCulture_IsValid = GetCurrentCulture_FunctionAddress != IntPtr.Zero && GetCurrentCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetCurrentCulture", GetCurrentCulture_IsValid);
		GetCurrentAssetGroupCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentAssetGroupCulture");
		GetCurrentAssetGroupCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAssetGroupCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAssetGroupCulture_AssetGroup_PropertyAddress, GetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		GetCurrentAssetGroupCulture_AssetGroup_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		GetCurrentAssetGroupCulture_AssetGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAssetGroupCulture_FunctionAddress, "AssetGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAssetGroupCulture_ReturnValue_PropertyAddress, GetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue");
		GetCurrentAssetGroupCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue");
		GetCurrentAssetGroupCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAssetGroupCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentAssetGroupCulture_IsValid = GetCurrentAssetGroupCulture_FunctionAddress != IntPtr.Zero && GetCurrentAssetGroupCulture_AssetGroup_IsValid && GetCurrentAssetGroupCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetCurrentAssetGroupCulture", GetCurrentAssetGroupCulture_IsValid);
		GetCultureDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCultureDisplayName");
		GetCultureDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCultureDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCultureDisplayName_Culture_PropertyAddress, GetCultureDisplayName_FunctionAddress, "Culture");
		GetCultureDisplayName_Culture_Offset = NativeReflectionCached.GetPropertyOffset(GetCultureDisplayName_FunctionAddress, "Culture");
		GetCultureDisplayName_Culture_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCultureDisplayName_FunctionAddress, "Culture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCultureDisplayName_Localized_PropertyAddress, GetCultureDisplayName_FunctionAddress, "Localized");
		GetCultureDisplayName_Localized_Offset = NativeReflectionCached.GetPropertyOffset(GetCultureDisplayName_FunctionAddress, "Localized");
		GetCultureDisplayName_Localized_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCultureDisplayName_FunctionAddress, "Localized", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCultureDisplayName_ReturnValue_PropertyAddress, GetCultureDisplayName_FunctionAddress, "ReturnValue");
		GetCultureDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCultureDisplayName_FunctionAddress, "ReturnValue");
		GetCultureDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCultureDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCultureDisplayName_IsValid = GetCultureDisplayName_FunctionAddress != IntPtr.Zero && GetCultureDisplayName_Culture_IsValid && GetCultureDisplayName_Localized_IsValid && GetCultureDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:GetCultureDisplayName", GetCultureDisplayName_IsValid);
		ClearCurrentAssetGroupCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearCurrentAssetGroupCulture");
		ClearCurrentAssetGroupCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCurrentAssetGroupCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearCurrentAssetGroupCulture_AssetGroup_PropertyAddress, ClearCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		ClearCurrentAssetGroupCulture_AssetGroup_Offset = NativeReflectionCached.GetPropertyOffset(ClearCurrentAssetGroupCulture_FunctionAddress, "AssetGroup");
		ClearCurrentAssetGroupCulture_AssetGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearCurrentAssetGroupCulture_FunctionAddress, "AssetGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearCurrentAssetGroupCulture_SaveToConfig_PropertyAddress, ClearCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig");
		ClearCurrentAssetGroupCulture_SaveToConfig_Offset = NativeReflectionCached.GetPropertyOffset(ClearCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig");
		ClearCurrentAssetGroupCulture_SaveToConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearCurrentAssetGroupCulture_FunctionAddress, "SaveToConfig", Classes.FBoolProperty);
		ClearCurrentAssetGroupCulture_IsValid = ClearCurrentAssetGroupCulture_FunctionAddress != IntPtr.Zero && ClearCurrentAssetGroupCulture_AssetGroup_IsValid && ClearCurrentAssetGroupCulture_SaveToConfig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInternationalizationLibrary:ClearCurrentAssetGroupCulture", ClearCurrentAssetGroupCulture_IsValid);
	}
}
