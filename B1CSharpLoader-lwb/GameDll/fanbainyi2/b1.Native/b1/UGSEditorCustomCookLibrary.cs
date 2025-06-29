using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorCustomCookLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SwitchSkipRef_IsValid;

	private static IntPtr SwitchSkipRef_FunctionAddress;

	private static int SwitchSkipRef_ParamsSize;

	private static bool SwitchSkipRef_CookAssetList_IsValid;

	private static FFieldAddress SwitchSkipRef_CookAssetList_PropertyAddress;

	private static int SwitchSkipRef_CookAssetList_Offset;

	private static bool SwitchSkipRef_SkipRefList_IsValid;

	private static FFieldAddress SwitchSkipRef_SkipRefList_PropertyAddress;

	private static int SwitchSkipRef_SkipRefList_Offset;

	private static bool SaveSelectedTargetPlatform_IsValid;

	private static IntPtr SaveSelectedTargetPlatform_FunctionAddress;

	private static int SaveSelectedTargetPlatform_ParamsSize;

	private static bool SaveSelectedTargetPlatform_TargetPlatform_IsValid;

	private static FFieldAddress SaveSelectedTargetPlatform_TargetPlatform_PropertyAddress;

	private static int SaveSelectedTargetPlatform_TargetPlatform_Offset;

	private static bool SaveLiteVsPath_IsValid;

	private static IntPtr SaveLiteVsPath_FunctionAddress;

	private static int SaveLiteVsPath_ParamsSize;

	private static bool SaveLiteVsPath_LitePath_IsValid;

	private static FFieldAddress SaveLiteVsPath_LitePath_PropertyAddress;

	private static int SaveLiteVsPath_LitePath_Offset;

	private static bool SaveLiteVsPath_VsPath_IsValid;

	private static FFieldAddress SaveLiteVsPath_VsPath_PropertyAddress;

	private static int SaveLiteVsPath_VsPath_Offset;

	private static bool SaveCustomCookPreset_IsValid;

	private static IntPtr SaveCustomCookPreset_FunctionAddress;

	private static int SaveCustomCookPreset_ParamsSize;

	private static bool SaveCustomCookPreset_CookAssetList_IsValid;

	private static FFieldAddress SaveCustomCookPreset_CookAssetList_PropertyAddress;

	private static int SaveCustomCookPreset_CookAssetList_Offset;

	private static bool SaveCustomCookPreset_SkipRefList_IsValid;

	private static FFieldAddress SaveCustomCookPreset_SkipRefList_PropertyAddress;

	private static int SaveCustomCookPreset_SkipRefList_Offset;

	private static bool SaveCustomCookPreset_ActiveStateList_IsValid;

	private static FFieldAddress SaveCustomCookPreset_ActiveStateList_PropertyAddress;

	private static int SaveCustomCookPreset_ActiveStateList_Offset;

	private static bool SaveCustomCookPreset_SavePresetName_IsValid;

	private static FFieldAddress SaveCustomCookPreset_SavePresetName_PropertyAddress;

	private static int SaveCustomCookPreset_SavePresetName_Offset;

	private static bool RemoveAlwaysCookAsset_IsValid;

	private static IntPtr RemoveAlwaysCookAsset_FunctionAddress;

	private static int RemoveAlwaysCookAsset_ParamsSize;

	private static bool RemoveAlwaysCookAsset_RemoveAssetList_IsValid;

	private static FFieldAddress RemoveAlwaysCookAsset_RemoveAssetList_PropertyAddress;

	private static int RemoveAlwaysCookAsset_RemoveAssetList_Offset;

	private static bool OpenInContentBrowser_IsValid;

	private static IntPtr OpenInContentBrowser_FunctionAddress;

	private static int OpenInContentBrowser_ParamsSize;

	private static bool OpenInContentBrowser_AssetPath_IsValid;

	private static FFieldAddress OpenInContentBrowser_AssetPath_PropertyAddress;

	private static int OpenInContentBrowser_AssetPath_Offset;

	private static bool LoadCustomCookPreset_IsValid;

	private static IntPtr LoadCustomCookPreset_FunctionAddress;

	private static int LoadCustomCookPreset_ParamsSize;

	private static bool LoadCustomCookPreset_LoadPresetName_IsValid;

	private static FFieldAddress LoadCustomCookPreset_LoadPresetName_PropertyAddress;

	private static int LoadCustomCookPreset_LoadPresetName_Offset;

	private static bool IsCookSeverRunning_IsValid;

	private static IntPtr IsCookSeverRunning_FunctionAddress;

	private static int IsCookSeverRunning_ParamsSize;

	private static bool IsCookSeverRunning_ReturnValue_IsValid;

	private static FFieldAddress IsCookSeverRunning_ReturnValue_PropertyAddress;

	private static int IsCookSeverRunning_ReturnValue_Offset;

	private static bool GetSelectedTargetPlatform_IsValid;

	private static IntPtr GetSelectedTargetPlatform_FunctionAddress;

	private static int GetSelectedTargetPlatform_ParamsSize;

	private static bool GetSelectedTargetPlatform_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedTargetPlatform_ReturnValue_PropertyAddress;

	private static int GetSelectedTargetPlatform_ReturnValue_Offset;

	private static bool GetLocalCookToolConfigPath_IsValid;

	private static IntPtr GetLocalCookToolConfigPath_FunctionAddress;

	private static int GetLocalCookToolConfigPath_ParamsSize;

	private static bool GetLocalCookToolConfigPath_ReturnValue_IsValid;

	private static FFieldAddress GetLocalCookToolConfigPath_ReturnValue_PropertyAddress;

	private static int GetLocalCookToolConfigPath_ReturnValue_Offset;

	private static bool GetCookAssetDependencies_IsValid;

	private static IntPtr GetCookAssetDependencies_FunctionAddress;

	private static int GetCookAssetDependencies_ParamsSize;

	private static bool GetCookAssetDependencies_PackageNames_IsValid;

	private static FFieldAddress GetCookAssetDependencies_PackageNames_PropertyAddress;

	private static int GetCookAssetDependencies_PackageNames_Offset;

	private static bool GetCookAssetDependencies_ReturnValue_IsValid;

	private static FFieldAddress GetCookAssetDependencies_ReturnValue_PropertyAddress;

	private static int GetCookAssetDependencies_ReturnValue_Offset;

	private static bool GetConfigVisualStudioPath_IsValid;

	private static IntPtr GetConfigVisualStudioPath_FunctionAddress;

	private static int GetConfigVisualStudioPath_ParamsSize;

	private static bool GetConfigVisualStudioPath_ReturnValue_IsValid;

	private static FFieldAddress GetConfigVisualStudioPath_ReturnValue_PropertyAddress;

	private static int GetConfigVisualStudioPath_ReturnValue_Offset;

	private static bool GetConfigLiteProjectDir_IsValid;

	private static IntPtr GetConfigLiteProjectDir_FunctionAddress;

	private static int GetConfigLiteProjectDir_ParamsSize;

	private static bool GetConfigLiteProjectDir_ReturnValue_IsValid;

	private static FFieldAddress GetConfigLiteProjectDir_ReturnValue_PropertyAddress;

	private static int GetConfigLiteProjectDir_ReturnValue_Offset;

	private static bool GetAlwaysCookAssetSkipRef_IsValid;

	private static IntPtr GetAlwaysCookAssetSkipRef_FunctionAddress;

	private static int GetAlwaysCookAssetSkipRef_ParamsSize;

	private static bool GetAlwaysCookAssetSkipRef_ReturnValue_IsValid;

	private static FFieldAddress GetAlwaysCookAssetSkipRef_ReturnValue_PropertyAddress;

	private static int GetAlwaysCookAssetSkipRef_ReturnValue_Offset;

	private static bool GetAlwaysCookAsset_IsValid;

	private static IntPtr GetAlwaysCookAsset_FunctionAddress;

	private static int GetAlwaysCookAsset_ParamsSize;

	private static bool GetAlwaysCookAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAlwaysCookAsset_ReturnValue_PropertyAddress;

	private static int GetAlwaysCookAsset_ReturnValue_Offset;

	private static bool GetAllCustomCookPresetName_IsValid;

	private static IntPtr GetAllCustomCookPresetName_FunctionAddress;

	private static int GetAllCustomCookPresetName_ParamsSize;

	private static bool GetAllCustomCookPresetName_ReturnValue_IsValid;

	private static FFieldAddress GetAllCustomCookPresetName_ReturnValue_PropertyAddress;

	private static int GetAllCustomCookPresetName_ReturnValue_Offset;

	private static bool DeleteCustomCookPreset_IsValid;

	private static IntPtr DeleteCustomCookPreset_FunctionAddress;

	private static int DeleteCustomCookPreset_ParamsSize;

	private static bool DeleteCustomCookPreset_PresetName_IsValid;

	private static FFieldAddress DeleteCustomCookPreset_PresetName_PropertyAddress;

	private static int DeleteCustomCookPreset_PresetName_Offset;

	private static bool CookSelectedPackagesForCommandlet_IsValid;

	private static IntPtr CookSelectedPackagesForCommandlet_FunctionAddress;

	private static int CookSelectedPackagesForCommandlet_ParamsSize;

	private static bool CookSelectedPackagesForCommandlet_InputPackageNames_IsValid;

	private static FFieldAddress CookSelectedPackagesForCommandlet_InputPackageNames_PropertyAddress;

	private static int CookSelectedPackagesForCommandlet_InputPackageNames_Offset;

	private static bool CookSelectedPackagesForCommandlet_TargetPlatform_IsValid;

	private static FFieldAddress CookSelectedPackagesForCommandlet_TargetPlatform_PropertyAddress;

	private static int CookSelectedPackagesForCommandlet_TargetPlatform_Offset;

	private static bool CookSelectedPackagesForCommandlet_SkipReference_IsValid;

	private static FFieldAddress CookSelectedPackagesForCommandlet_SkipReference_PropertyAddress;

	private static int CookSelectedPackagesForCommandlet_SkipReference_Offset;

	private static bool CookSelectedPackages_IsValid;

	private static IntPtr CookSelectedPackages_FunctionAddress;

	private static int CookSelectedPackages_ParamsSize;

	private static bool CookSelectedPackages_InputPackageNames_IsValid;

	private static FFieldAddress CookSelectedPackages_InputPackageNames_PropertyAddress;

	private static int CookSelectedPackages_InputPackageNames_Offset;

	private static bool CookSelectedPackages_TargetPlatform_IsValid;

	private static FFieldAddress CookSelectedPackages_TargetPlatform_PropertyAddress;

	private static int CookSelectedPackages_TargetPlatform_Offset;

	private static bool CookSelectedPackages_SkipReference_IsValid;

	private static FFieldAddress CookSelectedPackages_SkipReference_PropertyAddress;

	private static int CookSelectedPackages_SkipReference_Offset;

	private static bool CookCustomDirectories_IsValid;

	private static IntPtr CookCustomDirectories_FunctionAddress;

	private static int CookCustomDirectories_ParamsSize;

	private static bool CookCustomDirectories_CookDirectories_IsValid;

	private static FFieldAddress CookCustomDirectories_CookDirectories_PropertyAddress;

	private static int CookCustomDirectories_CookDirectories_Offset;

	private static bool CancelCustomCook_IsValid;

	private static IntPtr CancelCustomCook_FunctionAddress;

	private static int CancelCustomCook_ParamsSize;

	private static bool AddAlwaysCookAssetByPackageName_IsValid;

	private static IntPtr AddAlwaysCookAssetByPackageName_FunctionAddress;

	private static int AddAlwaysCookAssetByPackageName_ParamsSize;

	private static bool AddAlwaysCookAssetByPackageName_PackageNames_IsValid;

	private static FFieldAddress AddAlwaysCookAssetByPackageName_PackageNames_PropertyAddress;

	private static int AddAlwaysCookAssetByPackageName_PackageNames_Offset;

	private static bool AddAlwaysCookAsset_IsValid;

	private static IntPtr AddAlwaysCookAsset_FunctionAddress;

	private static int AddAlwaysCookAsset_ParamsSize;

	private static bool AddAlwaysCookAsset_PackageNames_IsValid;

	private static FFieldAddress AddAlwaysCookAsset_PackageNames_PropertyAddress;

	private static int AddAlwaysCookAsset_PackageNames_Offset;

	private static bool AddAlwaysCookAsset_SkipReference_IsValid;

	private static FFieldAddress AddAlwaysCookAsset_SkipReference_PropertyAddress;

	private static int AddAlwaysCookAsset_SkipReference_Offset;

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SwitchSkipRef")]
	public unsafe static void SwitchSkipRef(List<string> CookAssetList, List<bool> SkipRefList)
	{
		if (!SwitchSkipRef_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SwitchSkipRef");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchSkipRef_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchSkipRef_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, SwitchSkipRef_CookAssetList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SwitchSkipRef_CookAssetList_Offset), CookAssetList);
		new TArrayCopyMarshaler<bool>(1, SwitchSkipRef_SkipRefList_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SwitchSkipRef_SkipRefList_Offset), SkipRefList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SwitchSkipRef_FunctionAddress, intPtr, SwitchSkipRef_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SwitchSkipRef_CookAssetList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SwitchSkipRef_SkipRefList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveSelectedTargetPlatform")]
	public unsafe static void SaveSelectedTargetPlatform(string TargetPlatform)
	{
		if (!SaveSelectedTargetPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveSelectedTargetPlatform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveSelectedTargetPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveSelectedTargetPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveSelectedTargetPlatform_TargetPlatform_Offset), 0, SaveSelectedTargetPlatform_TargetPlatform_PropertyAddress.Address, TargetPlatform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveSelectedTargetPlatform_FunctionAddress, intPtr, SaveSelectedTargetPlatform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveSelectedTargetPlatform_TargetPlatform_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveLiteVsPath")]
	public unsafe static void SaveLiteVsPath(string LitePath, string VsPath)
	{
		if (!SaveLiteVsPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveLiteVsPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLiteVsPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLiteVsPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLiteVsPath_LitePath_Offset), 0, SaveLiteVsPath_LitePath_PropertyAddress.Address, LitePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLiteVsPath_VsPath_Offset), 0, SaveLiteVsPath_VsPath_PropertyAddress.Address, VsPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLiteVsPath_FunctionAddress, intPtr, SaveLiteVsPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLiteVsPath_LitePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveLiteVsPath_VsPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveCustomCookPreset")]
	public unsafe static void SaveCustomCookPreset(List<string> CookAssetList, List<bool> SkipRefList, List<bool> ActiveStateList, string SavePresetName)
	{
		if (!SaveCustomCookPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveCustomCookPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveCustomCookPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveCustomCookPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, SaveCustomCookPreset_CookAssetList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SaveCustomCookPreset_CookAssetList_Offset), CookAssetList);
		new TArrayCopyMarshaler<bool>(1, SaveCustomCookPreset_SkipRefList_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SaveCustomCookPreset_SkipRefList_Offset), SkipRefList);
		new TArrayCopyMarshaler<bool>(1, SaveCustomCookPreset_ActiveStateList_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SaveCustomCookPreset_ActiveStateList_Offset), ActiveStateList);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveCustomCookPreset_SavePresetName_Offset), 0, SaveCustomCookPreset_SavePresetName_PropertyAddress.Address, SavePresetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveCustomCookPreset_FunctionAddress, intPtr, SaveCustomCookPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveCustomCookPreset_CookAssetList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveCustomCookPreset_SkipRefList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveCustomCookPreset_ActiveStateList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveCustomCookPreset_SavePresetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:RemoveAlwaysCookAsset")]
	public unsafe static void RemoveAlwaysCookAsset(List<string> RemoveAssetList)
	{
		if (!RemoveAlwaysCookAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:RemoveAlwaysCookAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAlwaysCookAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAlwaysCookAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, RemoveAlwaysCookAsset_RemoveAssetList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveAlwaysCookAsset_RemoveAssetList_Offset), RemoveAssetList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAlwaysCookAsset_FunctionAddress, intPtr, RemoveAlwaysCookAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAlwaysCookAsset_RemoveAssetList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:OpenInContentBrowser")]
	public unsafe static void OpenInContentBrowser(FName AssetPath)
	{
		if (!OpenInContentBrowser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:OpenInContentBrowser");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenInContentBrowser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenInContentBrowser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OpenInContentBrowser_AssetPath_Offset), 0, OpenInContentBrowser_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenInContentBrowser_FunctionAddress, intPtr, OpenInContentBrowser_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:LoadCustomCookPreset")]
	public unsafe static void LoadCustomCookPreset(string LoadPresetName)
	{
		if (!LoadCustomCookPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:LoadCustomCookPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadCustomCookPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadCustomCookPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadCustomCookPreset_LoadPresetName_Offset), 0, LoadCustomCookPreset_LoadPresetName_PropertyAddress.Address, LoadPresetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadCustomCookPreset_FunctionAddress, intPtr, LoadCustomCookPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadCustomCookPreset_LoadPresetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:IsCookSeverRunning")]
	public unsafe static bool IsCookSeverRunning()
	{
		if (!IsCookSeverRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:IsCookSeverRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCookSeverRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCookSeverRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCookSeverRunning_FunctionAddress, intPtr, IsCookSeverRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCookSeverRunning_ReturnValue_Offset), 0, IsCookSeverRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetSelectedTargetPlatform")]
	public unsafe static string GetSelectedTargetPlatform()
	{
		if (!GetSelectedTargetPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetSelectedTargetPlatform");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedTargetPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedTargetPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedTargetPlatform_FunctionAddress, intPtr, GetSelectedTargetPlatform_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSelectedTargetPlatform_ReturnValue_Offset), 0, GetSelectedTargetPlatform_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectedTargetPlatform_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetLocalCookToolConfigPath")]
	public unsafe static string GetLocalCookToolConfigPath()
	{
		if (!GetLocalCookToolConfigPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetLocalCookToolConfigPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalCookToolConfigPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalCookToolConfigPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalCookToolConfigPath_FunctionAddress, intPtr, GetLocalCookToolConfigPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLocalCookToolConfigPath_ReturnValue_Offset), 0, GetLocalCookToolConfigPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLocalCookToolConfigPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetCookAssetDependencies")]
	public unsafe static List<string> GetCookAssetDependencies(List<string> PackageNames)
	{
		if (!GetCookAssetDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetCookAssetDependencies");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCookAssetDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCookAssetDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetCookAssetDependencies_PackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetCookAssetDependencies_PackageNames_Offset), PackageNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCookAssetDependencies_FunctionAddress, intPtr, GetCookAssetDependencies_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCookAssetDependencies_PackageNames_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetCookAssetDependencies_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetCookAssetDependencies_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCookAssetDependencies_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigVisualStudioPath")]
	public unsafe static string GetConfigVisualStudioPath()
	{
		if (!GetConfigVisualStudioPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigVisualStudioPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConfigVisualStudioPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConfigVisualStudioPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConfigVisualStudioPath_FunctionAddress, intPtr, GetConfigVisualStudioPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetConfigVisualStudioPath_ReturnValue_Offset), 0, GetConfigVisualStudioPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConfigVisualStudioPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigLiteProjectDir")]
	public unsafe static string GetConfigLiteProjectDir()
	{
		if (!GetConfigLiteProjectDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigLiteProjectDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConfigLiteProjectDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConfigLiteProjectDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConfigLiteProjectDir_FunctionAddress, intPtr, GetConfigLiteProjectDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetConfigLiteProjectDir_ReturnValue_Offset), 0, GetConfigLiteProjectDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConfigLiteProjectDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAssetSkipRef")]
	public unsafe static List<bool> GetAlwaysCookAssetSkipRef()
	{
		if (!GetAlwaysCookAssetSkipRef_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAssetSkipRef");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlwaysCookAssetSkipRef_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlwaysCookAssetSkipRef_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAlwaysCookAssetSkipRef_FunctionAddress, intPtr, GetAlwaysCookAssetSkipRef_ParamsSize);
		List<bool> result = new TArrayCopyMarshaler<bool>(1, GetAlwaysCookAssetSkipRef_ReturnValue_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAlwaysCookAssetSkipRef_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAlwaysCookAssetSkipRef_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAsset")]
	public unsafe static List<string> GetAlwaysCookAsset()
	{
		if (!GetAlwaysCookAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlwaysCookAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlwaysCookAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAlwaysCookAsset_FunctionAddress, intPtr, GetAlwaysCookAsset_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAlwaysCookAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAlwaysCookAsset_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAlwaysCookAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAllCustomCookPresetName")]
	public unsafe static List<string> GetAllCustomCookPresetName()
	{
		if (!GetAllCustomCookPresetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAllCustomCookPresetName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllCustomCookPresetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllCustomCookPresetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllCustomCookPresetName_FunctionAddress, intPtr, GetAllCustomCookPresetName_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAllCustomCookPresetName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllCustomCookPresetName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllCustomCookPresetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:DeleteCustomCookPreset")]
	public unsafe static void DeleteCustomCookPreset(string PresetName)
	{
		if (!DeleteCustomCookPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:DeleteCustomCookPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteCustomCookPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteCustomCookPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteCustomCookPreset_PresetName_Offset), 0, DeleteCustomCookPreset_PresetName_PropertyAddress.Address, PresetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteCustomCookPreset_FunctionAddress, intPtr, DeleteCustomCookPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteCustomCookPreset_PresetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackagesForCommandlet")]
	public unsafe static void CookSelectedPackagesForCommandlet(List<string> InputPackageNames, string TargetPlatform = "Windows", bool SkipReference = true)
	{
		if (!CookSelectedPackagesForCommandlet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackagesForCommandlet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookSelectedPackagesForCommandlet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookSelectedPackagesForCommandlet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, CookSelectedPackagesForCommandlet_InputPackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CookSelectedPackagesForCommandlet_InputPackageNames_Offset), InputPackageNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CookSelectedPackagesForCommandlet_TargetPlatform_Offset), 0, CookSelectedPackagesForCommandlet_TargetPlatform_PropertyAddress.Address, TargetPlatform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CookSelectedPackagesForCommandlet_SkipReference_Offset), 0, CookSelectedPackagesForCommandlet_SkipReference_PropertyAddress.Address, SkipReference);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookSelectedPackagesForCommandlet_FunctionAddress, intPtr, CookSelectedPackagesForCommandlet_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CookSelectedPackagesForCommandlet_InputPackageNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CookSelectedPackagesForCommandlet_TargetPlatform_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackages")]
	public unsafe static void CookSelectedPackages(List<string> InputPackageNames, string TargetPlatform = "Windows", bool SkipReference = true)
	{
		if (!CookSelectedPackages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackages");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookSelectedPackages_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookSelectedPackages_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, CookSelectedPackages_InputPackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CookSelectedPackages_InputPackageNames_Offset), InputPackageNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CookSelectedPackages_TargetPlatform_Offset), 0, CookSelectedPackages_TargetPlatform_PropertyAddress.Address, TargetPlatform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CookSelectedPackages_SkipReference_Offset), 0, CookSelectedPackages_SkipReference_PropertyAddress.Address, SkipReference);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookSelectedPackages_FunctionAddress, intPtr, CookSelectedPackages_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CookSelectedPackages_InputPackageNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CookSelectedPackages_TargetPlatform_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookCustomDirectories")]
	public unsafe static void CookCustomDirectories(List<string> CookDirectories)
	{
		if (!CookCustomDirectories_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookCustomDirectories");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookCustomDirectories_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookCustomDirectories_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, CookCustomDirectories_CookDirectories_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CookCustomDirectories_CookDirectories_Offset), CookDirectories);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookCustomDirectories_FunctionAddress, intPtr, CookCustomDirectories_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CookCustomDirectories_CookDirectories_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CancelCustomCook")]
	public unsafe static void CancelCustomCook()
	{
		if (!CancelCustomCook_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CancelCustomCook");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelCustomCook_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelCustomCook_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CancelCustomCook_FunctionAddress, argsSize: CancelCustomCook_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAssetByPackageName")]
	public unsafe static void AddAlwaysCookAssetByPackageName(string PackageNames)
	{
		if (!AddAlwaysCookAssetByPackageName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAssetByPackageName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAlwaysCookAssetByPackageName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAlwaysCookAssetByPackageName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddAlwaysCookAssetByPackageName_PackageNames_Offset), 0, AddAlwaysCookAssetByPackageName_PackageNames_PropertyAddress.Address, PackageNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAlwaysCookAssetByPackageName_FunctionAddress, intPtr, AddAlwaysCookAssetByPackageName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAlwaysCookAssetByPackageName_PackageNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAsset")]
	public unsafe static void AddAlwaysCookAsset(List<string> PackageNames, bool SkipReference = true)
	{
		if (!AddAlwaysCookAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAlwaysCookAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAlwaysCookAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, AddAlwaysCookAsset_PackageNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddAlwaysCookAsset_PackageNames_Offset), PackageNames);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddAlwaysCookAsset_SkipReference_Offset), 0, AddAlwaysCookAsset_SkipReference_PropertyAddress.Address, SkipReference);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAlwaysCookAsset_FunctionAddress, intPtr, AddAlwaysCookAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAlwaysCookAsset_PackageNames_PropertyAddress.Address, intPtr);
	}

	static UGSEditorCustomCookLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorCustomCookLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorCustomCookLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorCustomCookLibrary");
		SwitchSkipRef_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwitchSkipRef");
		SwitchSkipRef_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchSkipRef_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchSkipRef_CookAssetList_PropertyAddress, SwitchSkipRef_FunctionAddress, "CookAssetList");
		SwitchSkipRef_CookAssetList_Offset = NativeReflectionCached.GetPropertyOffset(SwitchSkipRef_FunctionAddress, "CookAssetList");
		SwitchSkipRef_CookAssetList_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchSkipRef_FunctionAddress, "CookAssetList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchSkipRef_SkipRefList_PropertyAddress, SwitchSkipRef_FunctionAddress, "SkipRefList");
		SwitchSkipRef_SkipRefList_Offset = NativeReflectionCached.GetPropertyOffset(SwitchSkipRef_FunctionAddress, "SkipRefList");
		SwitchSkipRef_SkipRefList_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchSkipRef_FunctionAddress, "SkipRefList", Classes.FArrayProperty);
		SwitchSkipRef_IsValid = SwitchSkipRef_FunctionAddress != IntPtr.Zero && SwitchSkipRef_CookAssetList_IsValid && SwitchSkipRef_SkipRefList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SwitchSkipRef", SwitchSkipRef_IsValid);
		SaveSelectedTargetPlatform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveSelectedTargetPlatform");
		SaveSelectedTargetPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveSelectedTargetPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveSelectedTargetPlatform_TargetPlatform_PropertyAddress, SaveSelectedTargetPlatform_FunctionAddress, "TargetPlatform");
		SaveSelectedTargetPlatform_TargetPlatform_Offset = NativeReflectionCached.GetPropertyOffset(SaveSelectedTargetPlatform_FunctionAddress, "TargetPlatform");
		SaveSelectedTargetPlatform_TargetPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveSelectedTargetPlatform_FunctionAddress, "TargetPlatform", Classes.FStrProperty);
		SaveSelectedTargetPlatform_IsValid = SaveSelectedTargetPlatform_FunctionAddress != IntPtr.Zero && SaveSelectedTargetPlatform_TargetPlatform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveSelectedTargetPlatform", SaveSelectedTargetPlatform_IsValid);
		SaveLiteVsPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLiteVsPath");
		SaveLiteVsPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLiteVsPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLiteVsPath_LitePath_PropertyAddress, SaveLiteVsPath_FunctionAddress, "LitePath");
		SaveLiteVsPath_LitePath_Offset = NativeReflectionCached.GetPropertyOffset(SaveLiteVsPath_FunctionAddress, "LitePath");
		SaveLiteVsPath_LitePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLiteVsPath_FunctionAddress, "LitePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLiteVsPath_VsPath_PropertyAddress, SaveLiteVsPath_FunctionAddress, "VsPath");
		SaveLiteVsPath_VsPath_Offset = NativeReflectionCached.GetPropertyOffset(SaveLiteVsPath_FunctionAddress, "VsPath");
		SaveLiteVsPath_VsPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLiteVsPath_FunctionAddress, "VsPath", Classes.FStrProperty);
		SaveLiteVsPath_IsValid = SaveLiteVsPath_FunctionAddress != IntPtr.Zero && SaveLiteVsPath_LitePath_IsValid && SaveLiteVsPath_VsPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveLiteVsPath", SaveLiteVsPath_IsValid);
		SaveCustomCookPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveCustomCookPreset");
		SaveCustomCookPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveCustomCookPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveCustomCookPreset_CookAssetList_PropertyAddress, SaveCustomCookPreset_FunctionAddress, "CookAssetList");
		SaveCustomCookPreset_CookAssetList_Offset = NativeReflectionCached.GetPropertyOffset(SaveCustomCookPreset_FunctionAddress, "CookAssetList");
		SaveCustomCookPreset_CookAssetList_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCustomCookPreset_FunctionAddress, "CookAssetList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveCustomCookPreset_SkipRefList_PropertyAddress, SaveCustomCookPreset_FunctionAddress, "SkipRefList");
		SaveCustomCookPreset_SkipRefList_Offset = NativeReflectionCached.GetPropertyOffset(SaveCustomCookPreset_FunctionAddress, "SkipRefList");
		SaveCustomCookPreset_SkipRefList_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCustomCookPreset_FunctionAddress, "SkipRefList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveCustomCookPreset_ActiveStateList_PropertyAddress, SaveCustomCookPreset_FunctionAddress, "ActiveStateList");
		SaveCustomCookPreset_ActiveStateList_Offset = NativeReflectionCached.GetPropertyOffset(SaveCustomCookPreset_FunctionAddress, "ActiveStateList");
		SaveCustomCookPreset_ActiveStateList_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCustomCookPreset_FunctionAddress, "ActiveStateList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveCustomCookPreset_SavePresetName_PropertyAddress, SaveCustomCookPreset_FunctionAddress, "SavePresetName");
		SaveCustomCookPreset_SavePresetName_Offset = NativeReflectionCached.GetPropertyOffset(SaveCustomCookPreset_FunctionAddress, "SavePresetName");
		SaveCustomCookPreset_SavePresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveCustomCookPreset_FunctionAddress, "SavePresetName", Classes.FStrProperty);
		SaveCustomCookPreset_IsValid = SaveCustomCookPreset_FunctionAddress != IntPtr.Zero && SaveCustomCookPreset_CookAssetList_IsValid && SaveCustomCookPreset_SkipRefList_IsValid && SaveCustomCookPreset_ActiveStateList_IsValid && SaveCustomCookPreset_SavePresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:SaveCustomCookPreset", SaveCustomCookPreset_IsValid);
		RemoveAlwaysCookAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAlwaysCookAsset");
		RemoveAlwaysCookAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAlwaysCookAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAlwaysCookAsset_RemoveAssetList_PropertyAddress, RemoveAlwaysCookAsset_FunctionAddress, "RemoveAssetList");
		RemoveAlwaysCookAsset_RemoveAssetList_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAlwaysCookAsset_FunctionAddress, "RemoveAssetList");
		RemoveAlwaysCookAsset_RemoveAssetList_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAlwaysCookAsset_FunctionAddress, "RemoveAssetList", Classes.FArrayProperty);
		RemoveAlwaysCookAsset_IsValid = RemoveAlwaysCookAsset_FunctionAddress != IntPtr.Zero && RemoveAlwaysCookAsset_RemoveAssetList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:RemoveAlwaysCookAsset", RemoveAlwaysCookAsset_IsValid);
		OpenInContentBrowser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenInContentBrowser");
		OpenInContentBrowser_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenInContentBrowser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenInContentBrowser_AssetPath_PropertyAddress, OpenInContentBrowser_FunctionAddress, "AssetPath");
		OpenInContentBrowser_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(OpenInContentBrowser_FunctionAddress, "AssetPath");
		OpenInContentBrowser_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenInContentBrowser_FunctionAddress, "AssetPath", Classes.FNameProperty);
		OpenInContentBrowser_IsValid = OpenInContentBrowser_FunctionAddress != IntPtr.Zero && OpenInContentBrowser_AssetPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:OpenInContentBrowser", OpenInContentBrowser_IsValid);
		LoadCustomCookPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadCustomCookPreset");
		LoadCustomCookPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadCustomCookPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadCustomCookPreset_LoadPresetName_PropertyAddress, LoadCustomCookPreset_FunctionAddress, "LoadPresetName");
		LoadCustomCookPreset_LoadPresetName_Offset = NativeReflectionCached.GetPropertyOffset(LoadCustomCookPreset_FunctionAddress, "LoadPresetName");
		LoadCustomCookPreset_LoadPresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadCustomCookPreset_FunctionAddress, "LoadPresetName", Classes.FStrProperty);
		LoadCustomCookPreset_IsValid = LoadCustomCookPreset_FunctionAddress != IntPtr.Zero && LoadCustomCookPreset_LoadPresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:LoadCustomCookPreset", LoadCustomCookPreset_IsValid);
		IsCookSeverRunning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCookSeverRunning");
		IsCookSeverRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCookSeverRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCookSeverRunning_ReturnValue_PropertyAddress, IsCookSeverRunning_FunctionAddress, "ReturnValue");
		IsCookSeverRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCookSeverRunning_FunctionAddress, "ReturnValue");
		IsCookSeverRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCookSeverRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCookSeverRunning_IsValid = IsCookSeverRunning_FunctionAddress != IntPtr.Zero && IsCookSeverRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:IsCookSeverRunning", IsCookSeverRunning_IsValid);
		GetSelectedTargetPlatform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedTargetPlatform");
		GetSelectedTargetPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedTargetPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedTargetPlatform_ReturnValue_PropertyAddress, GetSelectedTargetPlatform_FunctionAddress, "ReturnValue");
		GetSelectedTargetPlatform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedTargetPlatform_FunctionAddress, "ReturnValue");
		GetSelectedTargetPlatform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedTargetPlatform_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSelectedTargetPlatform_IsValid = GetSelectedTargetPlatform_FunctionAddress != IntPtr.Zero && GetSelectedTargetPlatform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetSelectedTargetPlatform", GetSelectedTargetPlatform_IsValid);
		GetLocalCookToolConfigPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalCookToolConfigPath");
		GetLocalCookToolConfigPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalCookToolConfigPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalCookToolConfigPath_ReturnValue_PropertyAddress, GetLocalCookToolConfigPath_FunctionAddress, "ReturnValue");
		GetLocalCookToolConfigPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalCookToolConfigPath_FunctionAddress, "ReturnValue");
		GetLocalCookToolConfigPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalCookToolConfigPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLocalCookToolConfigPath_IsValid = GetLocalCookToolConfigPath_FunctionAddress != IntPtr.Zero && GetLocalCookToolConfigPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetLocalCookToolConfigPath", GetLocalCookToolConfigPath_IsValid);
		GetCookAssetDependencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCookAssetDependencies");
		GetCookAssetDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCookAssetDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCookAssetDependencies_PackageNames_PropertyAddress, GetCookAssetDependencies_FunctionAddress, "PackageNames");
		GetCookAssetDependencies_PackageNames_Offset = NativeReflectionCached.GetPropertyOffset(GetCookAssetDependencies_FunctionAddress, "PackageNames");
		GetCookAssetDependencies_PackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookAssetDependencies_FunctionAddress, "PackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookAssetDependencies_ReturnValue_PropertyAddress, GetCookAssetDependencies_FunctionAddress, "ReturnValue");
		GetCookAssetDependencies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCookAssetDependencies_FunctionAddress, "ReturnValue");
		GetCookAssetDependencies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookAssetDependencies_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCookAssetDependencies_IsValid = GetCookAssetDependencies_FunctionAddress != IntPtr.Zero && GetCookAssetDependencies_PackageNames_IsValid && GetCookAssetDependencies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetCookAssetDependencies", GetCookAssetDependencies_IsValid);
		GetConfigVisualStudioPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConfigVisualStudioPath");
		GetConfigVisualStudioPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConfigVisualStudioPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConfigVisualStudioPath_ReturnValue_PropertyAddress, GetConfigVisualStudioPath_FunctionAddress, "ReturnValue");
		GetConfigVisualStudioPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConfigVisualStudioPath_FunctionAddress, "ReturnValue");
		GetConfigVisualStudioPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConfigVisualStudioPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetConfigVisualStudioPath_IsValid = GetConfigVisualStudioPath_FunctionAddress != IntPtr.Zero && GetConfigVisualStudioPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigVisualStudioPath", GetConfigVisualStudioPath_IsValid);
		GetConfigLiteProjectDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConfigLiteProjectDir");
		GetConfigLiteProjectDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConfigLiteProjectDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConfigLiteProjectDir_ReturnValue_PropertyAddress, GetConfigLiteProjectDir_FunctionAddress, "ReturnValue");
		GetConfigLiteProjectDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConfigLiteProjectDir_FunctionAddress, "ReturnValue");
		GetConfigLiteProjectDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConfigLiteProjectDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetConfigLiteProjectDir_IsValid = GetConfigLiteProjectDir_FunctionAddress != IntPtr.Zero && GetConfigLiteProjectDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetConfigLiteProjectDir", GetConfigLiteProjectDir_IsValid);
		GetAlwaysCookAssetSkipRef_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAlwaysCookAssetSkipRef");
		GetAlwaysCookAssetSkipRef_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlwaysCookAssetSkipRef_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlwaysCookAssetSkipRef_ReturnValue_PropertyAddress, GetAlwaysCookAssetSkipRef_FunctionAddress, "ReturnValue");
		GetAlwaysCookAssetSkipRef_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAlwaysCookAssetSkipRef_FunctionAddress, "ReturnValue");
		GetAlwaysCookAssetSkipRef_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlwaysCookAssetSkipRef_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAlwaysCookAssetSkipRef_IsValid = GetAlwaysCookAssetSkipRef_FunctionAddress != IntPtr.Zero && GetAlwaysCookAssetSkipRef_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAssetSkipRef", GetAlwaysCookAssetSkipRef_IsValid);
		GetAlwaysCookAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAlwaysCookAsset");
		GetAlwaysCookAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlwaysCookAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlwaysCookAsset_ReturnValue_PropertyAddress, GetAlwaysCookAsset_FunctionAddress, "ReturnValue");
		GetAlwaysCookAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAlwaysCookAsset_FunctionAddress, "ReturnValue");
		GetAlwaysCookAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlwaysCookAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAlwaysCookAsset_IsValid = GetAlwaysCookAsset_FunctionAddress != IntPtr.Zero && GetAlwaysCookAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAlwaysCookAsset", GetAlwaysCookAsset_IsValid);
		GetAllCustomCookPresetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllCustomCookPresetName");
		GetAllCustomCookPresetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllCustomCookPresetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllCustomCookPresetName_ReturnValue_PropertyAddress, GetAllCustomCookPresetName_FunctionAddress, "ReturnValue");
		GetAllCustomCookPresetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllCustomCookPresetName_FunctionAddress, "ReturnValue");
		GetAllCustomCookPresetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllCustomCookPresetName_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllCustomCookPresetName_IsValid = GetAllCustomCookPresetName_FunctionAddress != IntPtr.Zero && GetAllCustomCookPresetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:GetAllCustomCookPresetName", GetAllCustomCookPresetName_IsValid);
		DeleteCustomCookPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteCustomCookPreset");
		DeleteCustomCookPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteCustomCookPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteCustomCookPreset_PresetName_PropertyAddress, DeleteCustomCookPreset_FunctionAddress, "PresetName");
		DeleteCustomCookPreset_PresetName_Offset = NativeReflectionCached.GetPropertyOffset(DeleteCustomCookPreset_FunctionAddress, "PresetName");
		DeleteCustomCookPreset_PresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteCustomCookPreset_FunctionAddress, "PresetName", Classes.FStrProperty);
		DeleteCustomCookPreset_IsValid = DeleteCustomCookPreset_FunctionAddress != IntPtr.Zero && DeleteCustomCookPreset_PresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:DeleteCustomCookPreset", DeleteCustomCookPreset_IsValid);
		CookSelectedPackagesForCommandlet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookSelectedPackagesForCommandlet");
		CookSelectedPackagesForCommandlet_ParamsSize = NativeReflection.GetFunctionParamsSize(CookSelectedPackagesForCommandlet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackagesForCommandlet_InputPackageNames_PropertyAddress, CookSelectedPackagesForCommandlet_FunctionAddress, "InputPackageNames");
		CookSelectedPackagesForCommandlet_InputPackageNames_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackagesForCommandlet_FunctionAddress, "InputPackageNames");
		CookSelectedPackagesForCommandlet_InputPackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackagesForCommandlet_FunctionAddress, "InputPackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackagesForCommandlet_TargetPlatform_PropertyAddress, CookSelectedPackagesForCommandlet_FunctionAddress, "TargetPlatform");
		CookSelectedPackagesForCommandlet_TargetPlatform_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackagesForCommandlet_FunctionAddress, "TargetPlatform");
		CookSelectedPackagesForCommandlet_TargetPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackagesForCommandlet_FunctionAddress, "TargetPlatform", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackagesForCommandlet_SkipReference_PropertyAddress, CookSelectedPackagesForCommandlet_FunctionAddress, "SkipReference");
		CookSelectedPackagesForCommandlet_SkipReference_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackagesForCommandlet_FunctionAddress, "SkipReference");
		CookSelectedPackagesForCommandlet_SkipReference_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackagesForCommandlet_FunctionAddress, "SkipReference", Classes.FBoolProperty);
		CookSelectedPackagesForCommandlet_IsValid = CookSelectedPackagesForCommandlet_FunctionAddress != IntPtr.Zero && CookSelectedPackagesForCommandlet_InputPackageNames_IsValid && CookSelectedPackagesForCommandlet_TargetPlatform_IsValid && CookSelectedPackagesForCommandlet_SkipReference_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackagesForCommandlet", CookSelectedPackagesForCommandlet_IsValid);
		CookSelectedPackages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookSelectedPackages");
		CookSelectedPackages_ParamsSize = NativeReflection.GetFunctionParamsSize(CookSelectedPackages_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackages_InputPackageNames_PropertyAddress, CookSelectedPackages_FunctionAddress, "InputPackageNames");
		CookSelectedPackages_InputPackageNames_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackages_FunctionAddress, "InputPackageNames");
		CookSelectedPackages_InputPackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackages_FunctionAddress, "InputPackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackages_TargetPlatform_PropertyAddress, CookSelectedPackages_FunctionAddress, "TargetPlatform");
		CookSelectedPackages_TargetPlatform_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackages_FunctionAddress, "TargetPlatform");
		CookSelectedPackages_TargetPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackages_FunctionAddress, "TargetPlatform", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSelectedPackages_SkipReference_PropertyAddress, CookSelectedPackages_FunctionAddress, "SkipReference");
		CookSelectedPackages_SkipReference_Offset = NativeReflectionCached.GetPropertyOffset(CookSelectedPackages_FunctionAddress, "SkipReference");
		CookSelectedPackages_SkipReference_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSelectedPackages_FunctionAddress, "SkipReference", Classes.FBoolProperty);
		CookSelectedPackages_IsValid = CookSelectedPackages_FunctionAddress != IntPtr.Zero && CookSelectedPackages_InputPackageNames_IsValid && CookSelectedPackages_TargetPlatform_IsValid && CookSelectedPackages_SkipReference_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookSelectedPackages", CookSelectedPackages_IsValid);
		CookCustomDirectories_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookCustomDirectories");
		CookCustomDirectories_ParamsSize = NativeReflection.GetFunctionParamsSize(CookCustomDirectories_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookCustomDirectories_CookDirectories_PropertyAddress, CookCustomDirectories_FunctionAddress, "CookDirectories");
		CookCustomDirectories_CookDirectories_Offset = NativeReflectionCached.GetPropertyOffset(CookCustomDirectories_FunctionAddress, "CookDirectories");
		CookCustomDirectories_CookDirectories_IsValid = NativeReflectionCached.ValidatePropertyClass(CookCustomDirectories_FunctionAddress, "CookDirectories", Classes.FArrayProperty);
		CookCustomDirectories_IsValid = CookCustomDirectories_FunctionAddress != IntPtr.Zero && CookCustomDirectories_CookDirectories_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CookCustomDirectories", CookCustomDirectories_IsValid);
		CancelCustomCook_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelCustomCook");
		CancelCustomCook_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelCustomCook_FunctionAddress);
		CancelCustomCook_IsValid = CancelCustomCook_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:CancelCustomCook", CancelCustomCook_IsValid);
		AddAlwaysCookAssetByPackageName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAlwaysCookAssetByPackageName");
		AddAlwaysCookAssetByPackageName_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAlwaysCookAssetByPackageName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAlwaysCookAssetByPackageName_PackageNames_PropertyAddress, AddAlwaysCookAssetByPackageName_FunctionAddress, "PackageNames");
		AddAlwaysCookAssetByPackageName_PackageNames_Offset = NativeReflectionCached.GetPropertyOffset(AddAlwaysCookAssetByPackageName_FunctionAddress, "PackageNames");
		AddAlwaysCookAssetByPackageName_PackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAlwaysCookAssetByPackageName_FunctionAddress, "PackageNames", Classes.FStrProperty);
		AddAlwaysCookAssetByPackageName_IsValid = AddAlwaysCookAssetByPackageName_FunctionAddress != IntPtr.Zero && AddAlwaysCookAssetByPackageName_PackageNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAssetByPackageName", AddAlwaysCookAssetByPackageName_IsValid);
		AddAlwaysCookAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAlwaysCookAsset");
		AddAlwaysCookAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAlwaysCookAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAlwaysCookAsset_PackageNames_PropertyAddress, AddAlwaysCookAsset_FunctionAddress, "PackageNames");
		AddAlwaysCookAsset_PackageNames_Offset = NativeReflectionCached.GetPropertyOffset(AddAlwaysCookAsset_FunctionAddress, "PackageNames");
		AddAlwaysCookAsset_PackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAlwaysCookAsset_FunctionAddress, "PackageNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAlwaysCookAsset_SkipReference_PropertyAddress, AddAlwaysCookAsset_FunctionAddress, "SkipReference");
		AddAlwaysCookAsset_SkipReference_Offset = NativeReflectionCached.GetPropertyOffset(AddAlwaysCookAsset_FunctionAddress, "SkipReference");
		AddAlwaysCookAsset_SkipReference_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAlwaysCookAsset_FunctionAddress, "SkipReference", Classes.FBoolProperty);
		AddAlwaysCookAsset_IsValid = AddAlwaysCookAsset_FunctionAddress != IntPtr.Zero && AddAlwaysCookAsset_PackageNames_IsValid && AddAlwaysCookAsset_SkipReference_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorCustomCookLibrary:AddAlwaysCookAsset", AddAlwaysCookAsset_IsValid);
	}
}
