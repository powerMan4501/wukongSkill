using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorStaticMeshTreeLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ScanNormalTilesTreeSMInfo_IsValid;

	private static IntPtr ScanNormalTilesTreeSMInfo_FunctionAddress;

	private static int ScanNormalTilesTreeSMInfo_ParamsSize;

	private static bool ScanNormalTilesTreeSMInfo_SourceRootDirectory_IsValid;

	private static FFieldAddress ScanNormalTilesTreeSMInfo_SourceRootDirectory_PropertyAddress;

	private static int ScanNormalTilesTreeSMInfo_SourceRootDirectory_Offset;

	private static bool ScanNormalTilesTreeSMInfo_InTileLevelName_IsValid;

	private static FFieldAddress ScanNormalTilesTreeSMInfo_InTileLevelName_PropertyAddress;

	private static int ScanNormalTilesTreeSMInfo_InTileLevelName_Offset;

	private static bool ScanNormalTilesTreeSMInfo_InScanningRules_IsValid;

	private static FFieldAddress ScanNormalTilesTreeSMInfo_InScanningRules_PropertyAddress;

	private static int ScanNormalTilesTreeSMInfo_InScanningRules_Offset;

	private static bool ScanNormalTilesTreeSMInfo_OutTreeActors_IsValid;

	private static FFieldAddress ScanNormalTilesTreeSMInfo_OutTreeActors_PropertyAddress;

	private static int ScanNormalTilesTreeSMInfo_OutTreeActors_Offset;

	private static bool ScanAllTreeSMInfo_IsValid;

	private static IntPtr ScanAllTreeSMInfo_FunctionAddress;

	private static int ScanAllTreeSMInfo_ParamsSize;

	private static bool ScanAllTreeSMInfo_SourceRootDirectory_IsValid;

	private static FFieldAddress ScanAllTreeSMInfo_SourceRootDirectory_PropertyAddress;

	private static int ScanAllTreeSMInfo_SourceRootDirectory_Offset;

	private static bool ScanAllTreeSMInfo_TargetFilePath_IsValid;

	private static FFieldAddress ScanAllTreeSMInfo_TargetFilePath_PropertyAddress;

	private static int ScanAllTreeSMInfo_TargetFilePath_Offset;

	private static bool ScanAllTreeSMInfo_InScanningRules_IsValid;

	private static FFieldAddress ScanAllTreeSMInfo_InScanningRules_PropertyAddress;

	private static int ScanAllTreeSMInfo_InScanningRules_Offset;

	private static bool IsImposterEnabledByString_IsValid;

	private static IntPtr IsImposterEnabledByString_FunctionAddress;

	private static int IsImposterEnabledByString_ParamsSize;

	private static bool IsImposterEnabledByString_InStaticMesh_IsValid;

	private static FFieldAddress IsImposterEnabledByString_InStaticMesh_PropertyAddress;

	private static int IsImposterEnabledByString_InStaticMesh_Offset;

	private static bool IsImposterEnabledByString_ImposterFilterString_IsValid;

	private static FFieldAddress IsImposterEnabledByString_ImposterFilterString_PropertyAddress;

	private static int IsImposterEnabledByString_ImposterFilterString_Offset;

	private static bool IsImposterEnabledByString_ReturnValue_IsValid;

	private static FFieldAddress IsImposterEnabledByString_ReturnValue_PropertyAddress;

	private static int IsImposterEnabledByString_ReturnValue_Offset;

	private static bool IsImposterEnabled_IsValid;

	private static IntPtr IsImposterEnabled_FunctionAddress;

	private static int IsImposterEnabled_ParamsSize;

	private static bool IsImposterEnabled_InStaticMesh_IsValid;

	private static FFieldAddress IsImposterEnabled_InStaticMesh_PropertyAddress;

	private static int IsImposterEnabled_InStaticMesh_Offset;

	private static bool IsImposterEnabled_ImposterSlotNameKeywords_IsValid;

	private static FFieldAddress IsImposterEnabled_ImposterSlotNameKeywords_PropertyAddress;

	private static int IsImposterEnabled_ImposterSlotNameKeywords_Offset;

	private static bool IsImposterEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsImposterEnabled_ReturnValue_PropertyAddress;

	private static int IsImposterEnabled_ReturnValue_Offset;

	private static bool GetStaticMeshLodInfo_IsValid;

	private static IntPtr GetStaticMeshLodInfo_FunctionAddress;

	private static int GetStaticMeshLodInfo_ParamsSize;

	private static bool GetStaticMeshLodInfo_InStaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshLodInfo_InStaticMesh_PropertyAddress;

	private static int GetStaticMeshLodInfo_InStaticMesh_Offset;

	private static bool GetStaticMeshLodInfo_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshLodInfo_ReturnValue_PropertyAddress;

	private static int GetStaticMeshLodInfo_ReturnValue_Offset;

	private static bool CheckIsTreeActor_IsValid;

	private static IntPtr CheckIsTreeActor_FunctionAddress;

	private static int CheckIsTreeActor_ParamsSize;

	private static bool CheckIsTreeActor_InActor_IsValid;

	private static FFieldAddress CheckIsTreeActor_InActor_PropertyAddress;

	private static int CheckIsTreeActor_InActor_Offset;

	private static bool CheckIsTreeActor_InTreeFilterSettings_IsValid;

	private static FFieldAddress CheckIsTreeActor_InTreeFilterSettings_PropertyAddress;

	private static int CheckIsTreeActor_InTreeFilterSettings_Offset;

	private static bool CheckIsTreeActor_ReturnValue_IsValid;

	private static FFieldAddress CheckIsTreeActor_ReturnValue_PropertyAddress;

	private static int CheckIsTreeActor_ReturnValue_Offset;

	private static bool CheckIsNaniteTreeActor_IsValid;

	private static IntPtr CheckIsNaniteTreeActor_FunctionAddress;

	private static int CheckIsNaniteTreeActor_ParamsSize;

	private static bool CheckIsNaniteTreeActor_InActor_IsValid;

	private static FFieldAddress CheckIsNaniteTreeActor_InActor_PropertyAddress;

	private static int CheckIsNaniteTreeActor_InActor_Offset;

	private static bool CheckIsNaniteTreeActor_InTreeFilterSettings_IsValid;

	private static FFieldAddress CheckIsNaniteTreeActor_InTreeFilterSettings_PropertyAddress;

	private static int CheckIsNaniteTreeActor_InTreeFilterSettings_Offset;

	private static bool CheckIsNaniteTreeActor_ReturnValue_IsValid;

	private static FFieldAddress CheckIsNaniteTreeActor_ReturnValue_PropertyAddress;

	private static int CheckIsNaniteTreeActor_ReturnValue_Offset;

	private static bool CheckIsImposterActor_IsValid;

	private static IntPtr CheckIsImposterActor_FunctionAddress;

	private static int CheckIsImposterActor_ParamsSize;

	private static bool CheckIsImposterActor_InActor_IsValid;

	private static FFieldAddress CheckIsImposterActor_InActor_PropertyAddress;

	private static int CheckIsImposterActor_InActor_Offset;

	private static bool CheckIsImposterActor_InTreeFilterSettings_IsValid;

	private static FFieldAddress CheckIsImposterActor_InTreeFilterSettings_PropertyAddress;

	private static int CheckIsImposterActor_InTreeFilterSettings_Offset;

	private static bool CheckIsImposterActor_OutImposterSMComps_IsValid;

	private static FFieldAddress CheckIsImposterActor_OutImposterSMComps_PropertyAddress;

	private static int CheckIsImposterActor_OutImposterSMComps_Offset;

	private static bool CheckIsImposterActor_ReturnValue_IsValid;

	private static FFieldAddress CheckIsImposterActor_ReturnValue_PropertyAddress;

	private static int CheckIsImposterActor_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanNormalTilesTreeSMInfo")]
	public unsafe static void ScanNormalTilesTreeSMInfo(string SourceRootDirectory, string InTileLevelName, UTreeAssetScanningDataAsset InScanningRules, out List<AActor> OutTreeActors)
	{
		if (!ScanNormalTilesTreeSMInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanNormalTilesTreeSMInfo");
			OutTreeActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanNormalTilesTreeSMInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanNormalTilesTreeSMInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanNormalTilesTreeSMInfo_SourceRootDirectory_Offset), 0, ScanNormalTilesTreeSMInfo_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanNormalTilesTreeSMInfo_InTileLevelName_Offset), 0, ScanNormalTilesTreeSMInfo_InTileLevelName_PropertyAddress.Address, InTileLevelName);
		UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(intPtr, ScanNormalTilesTreeSMInfo_InScanningRules_Offset), 0, ScanNormalTilesTreeSMInfo_InScanningRules_PropertyAddress.Address, InScanningRules);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanNormalTilesTreeSMInfo_FunctionAddress, intPtr, ScanNormalTilesTreeSMInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanNormalTilesTreeSMInfo_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScanNormalTilesTreeSMInfo_InTileLevelName_PropertyAddress.Address, intPtr);
		OutTreeActors = new TArrayCopyMarshaler<AActor>(1, ScanNormalTilesTreeSMInfo_OutTreeActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, ScanNormalTilesTreeSMInfo_OutTreeActors_Offset));
		NativeReflection.DestroyValue_InContainer(ScanNormalTilesTreeSMInfo_OutTreeActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanAllTreeSMInfo")]
	public unsafe static void ScanAllTreeSMInfo(string SourceRootDirectory, string TargetFilePath, UTreeAssetScanningDataAsset InScanningRules)
	{
		if (!ScanAllTreeSMInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanAllTreeSMInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanAllTreeSMInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanAllTreeSMInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanAllTreeSMInfo_SourceRootDirectory_Offset), 0, ScanAllTreeSMInfo_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanAllTreeSMInfo_TargetFilePath_Offset), 0, ScanAllTreeSMInfo_TargetFilePath_PropertyAddress.Address, TargetFilePath);
		UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(intPtr, ScanAllTreeSMInfo_InScanningRules_Offset), 0, ScanAllTreeSMInfo_InScanningRules_PropertyAddress.Address, InScanningRules);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanAllTreeSMInfo_FunctionAddress, intPtr, ScanAllTreeSMInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanAllTreeSMInfo_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScanAllTreeSMInfo_TargetFilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabledByString")]
	public unsafe static bool IsImposterEnabledByString(UStaticMesh InStaticMesh, string ImposterFilterString)
	{
		if (!IsImposterEnabledByString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabledByString");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsImposterEnabledByString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsImposterEnabledByString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsImposterEnabledByString_InStaticMesh_Offset), 0, IsImposterEnabledByString_InStaticMesh_PropertyAddress.Address, InStaticMesh);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsImposterEnabledByString_ImposterFilterString_Offset), 0, IsImposterEnabledByString_ImposterFilterString_PropertyAddress.Address, ImposterFilterString);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsImposterEnabledByString_FunctionAddress, intPtr, IsImposterEnabledByString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsImposterEnabledByString_ImposterFilterString_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsImposterEnabledByString_ReturnValue_Offset), 0, IsImposterEnabledByString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabled")]
	public unsafe static bool IsImposterEnabled(UStaticMesh InStaticMesh, List<string> ImposterSlotNameKeywords)
	{
		if (!IsImposterEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsImposterEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsImposterEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsImposterEnabled_InStaticMesh_Offset), 0, IsImposterEnabled_InStaticMesh_PropertyAddress.Address, InStaticMesh);
		new TArrayCopyMarshaler<string>(1, IsImposterEnabled_ImposterSlotNameKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, IsImposterEnabled_ImposterSlotNameKeywords_Offset), ImposterSlotNameKeywords);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsImposterEnabled_FunctionAddress, intPtr, IsImposterEnabled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsImposterEnabled_ImposterSlotNameKeywords_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsImposterEnabled_ReturnValue_Offset), 0, IsImposterEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:GetStaticMeshLodInfo")]
	public unsafe static List<FTreeSMLodInfo> GetStaticMeshLodInfo(UStaticMesh InStaticMesh)
	{
		if (!GetStaticMeshLodInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:GetStaticMeshLodInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshLodInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshLodInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshLodInfo_InStaticMesh_Offset), 0, GetStaticMeshLodInfo_InStaticMesh_PropertyAddress.Address, InStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshLodInfo_FunctionAddress, intPtr, GetStaticMeshLodInfo_ParamsSize);
		List<FTreeSMLodInfo> result = new TArrayCopyMarshaler<FTreeSMLodInfo>(1, GetStaticMeshLodInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FTreeSMLodInfo, FTreeSMLodInfo>.FromNative, CachedMarshalingDelegates<FTreeSMLodInfo, FTreeSMLodInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshLodInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshLodInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsTreeActor")]
	public unsafe static bool CheckIsTreeActor(AActor InActor, UTreeAssetScanningDataAsset InTreeFilterSettings)
	{
		if (!CheckIsTreeActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsTreeActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsTreeActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsTreeActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckIsTreeActor_InActor_Offset), 0, CheckIsTreeActor_InActor_PropertyAddress.Address, InActor);
		UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(intPtr, CheckIsTreeActor_InTreeFilterSettings_Offset), 0, CheckIsTreeActor_InTreeFilterSettings_PropertyAddress.Address, InTreeFilterSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckIsTreeActor_FunctionAddress, intPtr, CheckIsTreeActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsTreeActor_ReturnValue_Offset), 0, CheckIsTreeActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsNaniteTreeActor")]
	public unsafe static bool CheckIsNaniteTreeActor(AActor InActor, UTreeAssetScanningDataAsset InTreeFilterSettings)
	{
		if (!CheckIsNaniteTreeActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsNaniteTreeActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsNaniteTreeActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsNaniteTreeActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckIsNaniteTreeActor_InActor_Offset), 0, CheckIsNaniteTreeActor_InActor_PropertyAddress.Address, InActor);
		UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(intPtr, CheckIsNaniteTreeActor_InTreeFilterSettings_Offset), 0, CheckIsNaniteTreeActor_InTreeFilterSettings_PropertyAddress.Address, InTreeFilterSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckIsNaniteTreeActor_FunctionAddress, intPtr, CheckIsNaniteTreeActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsNaniteTreeActor_ReturnValue_Offset), 0, CheckIsNaniteTreeActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsImposterActor")]
	public unsafe static bool CheckIsImposterActor(AActor InActor, UTreeAssetScanningDataAsset InTreeFilterSettings, out List<UStaticMeshComponent> OutImposterSMComps)
	{
		if (!CheckIsImposterActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsImposterActor");
			OutImposterSMComps = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsImposterActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsImposterActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckIsImposterActor_InActor_Offset), 0, CheckIsImposterActor_InActor_PropertyAddress.Address, InActor);
		UObjectMarshaler<UTreeAssetScanningDataAsset>.ToNative(IntPtr.Add(intPtr, CheckIsImposterActor_InTreeFilterSettings_Offset), 0, CheckIsImposterActor_InTreeFilterSettings_PropertyAddress.Address, InTreeFilterSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckIsImposterActor_FunctionAddress, intPtr, CheckIsImposterActor_ParamsSize);
		OutImposterSMComps = new TArrayCopyMarshaler<UStaticMeshComponent>(1, CheckIsImposterActor_OutImposterSMComps_PropertyAddress, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.FromNative, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, CheckIsImposterActor_OutImposterSMComps_Offset));
		NativeReflection.DestroyValue_InContainer(CheckIsImposterActor_OutImposterSMComps_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsImposterActor_ReturnValue_Offset), 0, CheckIsImposterActor_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorStaticMeshTreeLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorStaticMeshTreeLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorStaticMeshTreeLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary");
		ScanNormalTilesTreeSMInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanNormalTilesTreeSMInfo");
		ScanNormalTilesTreeSMInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanNormalTilesTreeSMInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanNormalTilesTreeSMInfo_SourceRootDirectory_PropertyAddress, ScanNormalTilesTreeSMInfo_FunctionAddress, "SourceRootDirectory");
		ScanNormalTilesTreeSMInfo_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanNormalTilesTreeSMInfo_FunctionAddress, "SourceRootDirectory");
		ScanNormalTilesTreeSMInfo_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanNormalTilesTreeSMInfo_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanNormalTilesTreeSMInfo_InTileLevelName_PropertyAddress, ScanNormalTilesTreeSMInfo_FunctionAddress, "InTileLevelName");
		ScanNormalTilesTreeSMInfo_InTileLevelName_Offset = NativeReflectionCached.GetPropertyOffset(ScanNormalTilesTreeSMInfo_FunctionAddress, "InTileLevelName");
		ScanNormalTilesTreeSMInfo_InTileLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanNormalTilesTreeSMInfo_FunctionAddress, "InTileLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanNormalTilesTreeSMInfo_InScanningRules_PropertyAddress, ScanNormalTilesTreeSMInfo_FunctionAddress, "InScanningRules");
		ScanNormalTilesTreeSMInfo_InScanningRules_Offset = NativeReflectionCached.GetPropertyOffset(ScanNormalTilesTreeSMInfo_FunctionAddress, "InScanningRules");
		ScanNormalTilesTreeSMInfo_InScanningRules_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanNormalTilesTreeSMInfo_FunctionAddress, "InScanningRules", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanNormalTilesTreeSMInfo_OutTreeActors_PropertyAddress, ScanNormalTilesTreeSMInfo_FunctionAddress, "OutTreeActors");
		ScanNormalTilesTreeSMInfo_OutTreeActors_Offset = NativeReflectionCached.GetPropertyOffset(ScanNormalTilesTreeSMInfo_FunctionAddress, "OutTreeActors");
		ScanNormalTilesTreeSMInfo_OutTreeActors_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanNormalTilesTreeSMInfo_FunctionAddress, "OutTreeActors", Classes.FArrayProperty);
		ScanNormalTilesTreeSMInfo_IsValid = ScanNormalTilesTreeSMInfo_FunctionAddress != IntPtr.Zero && ScanNormalTilesTreeSMInfo_SourceRootDirectory_IsValid && ScanNormalTilesTreeSMInfo_InTileLevelName_IsValid && ScanNormalTilesTreeSMInfo_InScanningRules_IsValid && ScanNormalTilesTreeSMInfo_OutTreeActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanNormalTilesTreeSMInfo", ScanNormalTilesTreeSMInfo_IsValid);
		ScanAllTreeSMInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanAllTreeSMInfo");
		ScanAllTreeSMInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanAllTreeSMInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanAllTreeSMInfo_SourceRootDirectory_PropertyAddress, ScanAllTreeSMInfo_FunctionAddress, "SourceRootDirectory");
		ScanAllTreeSMInfo_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllTreeSMInfo_FunctionAddress, "SourceRootDirectory");
		ScanAllTreeSMInfo_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllTreeSMInfo_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanAllTreeSMInfo_TargetFilePath_PropertyAddress, ScanAllTreeSMInfo_FunctionAddress, "TargetFilePath");
		ScanAllTreeSMInfo_TargetFilePath_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllTreeSMInfo_FunctionAddress, "TargetFilePath");
		ScanAllTreeSMInfo_TargetFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllTreeSMInfo_FunctionAddress, "TargetFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanAllTreeSMInfo_InScanningRules_PropertyAddress, ScanAllTreeSMInfo_FunctionAddress, "InScanningRules");
		ScanAllTreeSMInfo_InScanningRules_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllTreeSMInfo_FunctionAddress, "InScanningRules");
		ScanAllTreeSMInfo_InScanningRules_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllTreeSMInfo_FunctionAddress, "InScanningRules", Classes.FObjectProperty);
		ScanAllTreeSMInfo_IsValid = ScanAllTreeSMInfo_FunctionAddress != IntPtr.Zero && ScanAllTreeSMInfo_SourceRootDirectory_IsValid && ScanAllTreeSMInfo_TargetFilePath_IsValid && ScanAllTreeSMInfo_InScanningRules_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:ScanAllTreeSMInfo", ScanAllTreeSMInfo_IsValid);
		IsImposterEnabledByString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsImposterEnabledByString");
		IsImposterEnabledByString_ParamsSize = NativeReflection.GetFunctionParamsSize(IsImposterEnabledByString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabledByString_InStaticMesh_PropertyAddress, IsImposterEnabledByString_FunctionAddress, "InStaticMesh");
		IsImposterEnabledByString_InStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabledByString_FunctionAddress, "InStaticMesh");
		IsImposterEnabledByString_InStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabledByString_FunctionAddress, "InStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabledByString_ImposterFilterString_PropertyAddress, IsImposterEnabledByString_FunctionAddress, "ImposterFilterString");
		IsImposterEnabledByString_ImposterFilterString_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabledByString_FunctionAddress, "ImposterFilterString");
		IsImposterEnabledByString_ImposterFilterString_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabledByString_FunctionAddress, "ImposterFilterString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabledByString_ReturnValue_PropertyAddress, IsImposterEnabledByString_FunctionAddress, "ReturnValue");
		IsImposterEnabledByString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabledByString_FunctionAddress, "ReturnValue");
		IsImposterEnabledByString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabledByString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsImposterEnabledByString_IsValid = IsImposterEnabledByString_FunctionAddress != IntPtr.Zero && IsImposterEnabledByString_InStaticMesh_IsValid && IsImposterEnabledByString_ImposterFilterString_IsValid && IsImposterEnabledByString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabledByString", IsImposterEnabledByString_IsValid);
		IsImposterEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsImposterEnabled");
		IsImposterEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsImposterEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabled_InStaticMesh_PropertyAddress, IsImposterEnabled_FunctionAddress, "InStaticMesh");
		IsImposterEnabled_InStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabled_FunctionAddress, "InStaticMesh");
		IsImposterEnabled_InStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabled_FunctionAddress, "InStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabled_ImposterSlotNameKeywords_PropertyAddress, IsImposterEnabled_FunctionAddress, "ImposterSlotNameKeywords");
		IsImposterEnabled_ImposterSlotNameKeywords_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabled_FunctionAddress, "ImposterSlotNameKeywords");
		IsImposterEnabled_ImposterSlotNameKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabled_FunctionAddress, "ImposterSlotNameKeywords", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsImposterEnabled_ReturnValue_PropertyAddress, IsImposterEnabled_FunctionAddress, "ReturnValue");
		IsImposterEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsImposterEnabled_FunctionAddress, "ReturnValue");
		IsImposterEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsImposterEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsImposterEnabled_IsValid = IsImposterEnabled_FunctionAddress != IntPtr.Zero && IsImposterEnabled_InStaticMesh_IsValid && IsImposterEnabled_ImposterSlotNameKeywords_IsValid && IsImposterEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:IsImposterEnabled", IsImposterEnabled_IsValid);
		GetStaticMeshLodInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshLodInfo");
		GetStaticMeshLodInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshLodInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshLodInfo_InStaticMesh_PropertyAddress, GetStaticMeshLodInfo_FunctionAddress, "InStaticMesh");
		GetStaticMeshLodInfo_InStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshLodInfo_FunctionAddress, "InStaticMesh");
		GetStaticMeshLodInfo_InStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshLodInfo_FunctionAddress, "InStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshLodInfo_ReturnValue_PropertyAddress, GetStaticMeshLodInfo_FunctionAddress, "ReturnValue");
		GetStaticMeshLodInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshLodInfo_FunctionAddress, "ReturnValue");
		GetStaticMeshLodInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshLodInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetStaticMeshLodInfo_IsValid = GetStaticMeshLodInfo_FunctionAddress != IntPtr.Zero && GetStaticMeshLodInfo_InStaticMesh_IsValid && GetStaticMeshLodInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:GetStaticMeshLodInfo", GetStaticMeshLodInfo_IsValid);
		CheckIsTreeActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckIsTreeActor");
		CheckIsTreeActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsTreeActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckIsTreeActor_InActor_PropertyAddress, CheckIsTreeActor_FunctionAddress, "InActor");
		CheckIsTreeActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsTreeActor_FunctionAddress, "InActor");
		CheckIsTreeActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsTreeActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsTreeActor_InTreeFilterSettings_PropertyAddress, CheckIsTreeActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsTreeActor_InTreeFilterSettings_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsTreeActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsTreeActor_InTreeFilterSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsTreeActor_FunctionAddress, "InTreeFilterSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsTreeActor_ReturnValue_PropertyAddress, CheckIsTreeActor_FunctionAddress, "ReturnValue");
		CheckIsTreeActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsTreeActor_FunctionAddress, "ReturnValue");
		CheckIsTreeActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsTreeActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsTreeActor_IsValid = CheckIsTreeActor_FunctionAddress != IntPtr.Zero && CheckIsTreeActor_InActor_IsValid && CheckIsTreeActor_InTreeFilterSettings_IsValid && CheckIsTreeActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsTreeActor", CheckIsTreeActor_IsValid);
		CheckIsNaniteTreeActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckIsNaniteTreeActor");
		CheckIsNaniteTreeActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsNaniteTreeActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckIsNaniteTreeActor_InActor_PropertyAddress, CheckIsNaniteTreeActor_FunctionAddress, "InActor");
		CheckIsNaniteTreeActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsNaniteTreeActor_FunctionAddress, "InActor");
		CheckIsNaniteTreeActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsNaniteTreeActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsNaniteTreeActor_InTreeFilterSettings_PropertyAddress, CheckIsNaniteTreeActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsNaniteTreeActor_InTreeFilterSettings_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsNaniteTreeActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsNaniteTreeActor_InTreeFilterSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsNaniteTreeActor_FunctionAddress, "InTreeFilterSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsNaniteTreeActor_ReturnValue_PropertyAddress, CheckIsNaniteTreeActor_FunctionAddress, "ReturnValue");
		CheckIsNaniteTreeActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsNaniteTreeActor_FunctionAddress, "ReturnValue");
		CheckIsNaniteTreeActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsNaniteTreeActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsNaniteTreeActor_IsValid = CheckIsNaniteTreeActor_FunctionAddress != IntPtr.Zero && CheckIsNaniteTreeActor_InActor_IsValid && CheckIsNaniteTreeActor_InTreeFilterSettings_IsValid && CheckIsNaniteTreeActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsNaniteTreeActor", CheckIsNaniteTreeActor_IsValid);
		CheckIsImposterActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckIsImposterActor");
		CheckIsImposterActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsImposterActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckIsImposterActor_InActor_PropertyAddress, CheckIsImposterActor_FunctionAddress, "InActor");
		CheckIsImposterActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsImposterActor_FunctionAddress, "InActor");
		CheckIsImposterActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsImposterActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsImposterActor_InTreeFilterSettings_PropertyAddress, CheckIsImposterActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsImposterActor_InTreeFilterSettings_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsImposterActor_FunctionAddress, "InTreeFilterSettings");
		CheckIsImposterActor_InTreeFilterSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsImposterActor_FunctionAddress, "InTreeFilterSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsImposterActor_OutImposterSMComps_PropertyAddress, CheckIsImposterActor_FunctionAddress, "OutImposterSMComps");
		CheckIsImposterActor_OutImposterSMComps_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsImposterActor_FunctionAddress, "OutImposterSMComps");
		CheckIsImposterActor_OutImposterSMComps_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsImposterActor_FunctionAddress, "OutImposterSMComps", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsImposterActor_ReturnValue_PropertyAddress, CheckIsImposterActor_FunctionAddress, "ReturnValue");
		CheckIsImposterActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsImposterActor_FunctionAddress, "ReturnValue");
		CheckIsImposterActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsImposterActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsImposterActor_IsValid = CheckIsImposterActor_FunctionAddress != IntPtr.Zero && CheckIsImposterActor_InActor_IsValid && CheckIsImposterActor_InTreeFilterSettings_IsValid && CheckIsImposterActor_OutImposterSMComps_IsValid && CheckIsImposterActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshTreeLibrary:CheckIsImposterActor", CheckIsImposterActor_IsValid);
	}
}
