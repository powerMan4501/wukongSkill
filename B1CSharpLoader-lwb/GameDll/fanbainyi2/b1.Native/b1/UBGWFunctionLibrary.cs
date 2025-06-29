using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGWFunctionLibrary", "b1", UnrealModuleType.Game)]
public class UBGWFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RetargetLevelStreamingLevelNames_IsValid;

	private static IntPtr RetargetLevelStreamingLevelNames_FunctionAddress;

	private static int RetargetLevelStreamingLevelNames_ParamsSize;

	private static bool RetargetLevelStreamingLevelNames_WorldContext_IsValid;

	private static FFieldAddress RetargetLevelStreamingLevelNames_WorldContext_PropertyAddress;

	private static int RetargetLevelStreamingLevelNames_WorldContext_Offset;

	private static bool RetargetLevelStreamingLevelNames_sourceNames_IsValid;

	private static FFieldAddress RetargetLevelStreamingLevelNames_sourceNames_PropertyAddress;

	private static int RetargetLevelStreamingLevelNames_sourceNames_Offset;

	private static bool RetargetLevelStreamingLevelNames_destNames_IsValid;

	private static FFieldAddress RetargetLevelStreamingLevelNames_destNames_PropertyAddress;

	private static int RetargetLevelStreamingLevelNames_destNames_Offset;

	private static bool RetargetLevelStreamingLevelNames_levelPrefix_IsValid;

	private static FFieldAddress RetargetLevelStreamingLevelNames_levelPrefix_PropertyAddress;

	private static int RetargetLevelStreamingLevelNames_levelPrefix_Offset;

	private static bool ResumeBGWVolumeLevelStreaming_IsValid;

	private static IntPtr ResumeBGWVolumeLevelStreaming_FunctionAddress;

	private static int ResumeBGWVolumeLevelStreaming_ParamsSize;

	private static bool ResumeBGWVolumeLevelStreaming_WorldContextObject_IsValid;

	private static FFieldAddress ResumeBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress;

	private static int ResumeBGWVolumeLevelStreaming_WorldContextObject_Offset;

	private static bool PauseBGWVolumeLevelStreaming_IsValid;

	private static IntPtr PauseBGWVolumeLevelStreaming_FunctionAddress;

	private static int PauseBGWVolumeLevelStreaming_ParamsSize;

	private static bool PauseBGWVolumeLevelStreaming_WorldContextObject_IsValid;

	private static FFieldAddress PauseBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress;

	private static int PauseBGWVolumeLevelStreaming_WorldContextObject_Offset;

	private static bool MaintainVolumesContainYuanjing_IsValid;

	private static IntPtr MaintainVolumesContainYuanjing_FunctionAddress;

	private static int MaintainVolumesContainYuanjing_ParamsSize;

	private static bool MaintainVolumesContainYuanjing_InStreamingVolumes_IsValid;

	private static FFieldAddress MaintainVolumesContainYuanjing_InStreamingVolumes_PropertyAddress;

	private static int MaintainVolumesContainYuanjing_InStreamingVolumes_Offset;

	private static bool IsDistanceStreamingValid_IsValid;

	private static IntPtr IsDistanceStreamingValid_FunctionAddress;

	private static int IsDistanceStreamingValid_ParamsSize;

	private static bool IsDistanceStreamingValid_WorldContextObject_IsValid;

	private static FFieldAddress IsDistanceStreamingValid_WorldContextObject_PropertyAddress;

	private static int IsDistanceStreamingValid_WorldContextObject_Offset;

	private static bool IsDistanceStreamingValid_ReturnValue_IsValid;

	private static FFieldAddress IsDistanceStreamingValid_ReturnValue_PropertyAddress;

	private static int IsDistanceStreamingValid_ReturnValue_Offset;

	private static bool GetLevelStreamingAssetName_IsValid;

	private static IntPtr GetLevelStreamingAssetName_FunctionAddress;

	private static int GetLevelStreamingAssetName_ParamsSize;

	private static bool GetLevelStreamingAssetName_LevelStreaming_IsValid;

	private static FFieldAddress GetLevelStreamingAssetName_LevelStreaming_PropertyAddress;

	private static int GetLevelStreamingAssetName_LevelStreaming_Offset;

	private static bool GetLevelStreamingAssetName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelStreamingAssetName_ReturnValue_PropertyAddress;

	private static int GetLevelStreamingAssetName_ReturnValue_Offset;

	private static bool GetBGWEvents_IsValid;

	private static IntPtr GetBGWEvents_FunctionAddress;

	private static int GetBGWEvents_ParamsSize;

	private static bool GetBGWEvents_WorldContextObject_IsValid;

	private static FFieldAddress GetBGWEvents_WorldContextObject_PropertyAddress;

	private static int GetBGWEvents_WorldContextObject_Offset;

	private static bool GetBGWEvents_ReturnValue_IsValid;

	private static FFieldAddress GetBGWEvents_ReturnValue_PropertyAddress;

	private static int GetBGWEvents_ReturnValue_Offset;

	private static bool BGWSetIsCameraMoveableWhenPaused_IsValid;

	private static IntPtr BGWSetIsCameraMoveableWhenPaused_FunctionAddress;

	private static int BGWSetIsCameraMoveableWhenPaused_ParamsSize;

	private static bool BGWSetIsCameraMoveableWhenPaused_WorldContextObject_IsValid;

	private static FFieldAddress BGWSetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress;

	private static int BGWSetIsCameraMoveableWhenPaused_WorldContextObject_Offset;

	private static bool BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_IsValid;

	private static FFieldAddress BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_PropertyAddress;

	private static int BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_Offset;

	private static bool BGWSetGamePaused_IsValid;

	private static IntPtr BGWSetGamePaused_FunctionAddress;

	private static int BGWSetGamePaused_ParamsSize;

	private static bool BGWSetGamePaused_WorldContextObject_IsValid;

	private static FFieldAddress BGWSetGamePaused_WorldContextObject_PropertyAddress;

	private static int BGWSetGamePaused_WorldContextObject_Offset;

	private static bool BGWSetGamePaused_bPaused_IsValid;

	private static FFieldAddress BGWSetGamePaused_bPaused_PropertyAddress;

	private static int BGWSetGamePaused_bPaused_Offset;

	private static bool BGWSetAllLevelStreamingVolumeEnabled_IsValid;

	private static IntPtr BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress;

	private static int BGWSetAllLevelStreamingVolumeEnabled_ParamsSize;

	private static bool BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_IsValid;

	private static FFieldAddress BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_PropertyAddress;

	private static int BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_Offset;

	private static bool BGWSetAllLevelStreamingVolumeEnabled_bEnabled_IsValid;

	private static FFieldAddress BGWSetAllLevelStreamingVolumeEnabled_bEnabled_PropertyAddress;

	private static int BGWSetAllLevelStreamingVolumeEnabled_bEnabled_Offset;

	private static bool BGWRequestAsyncLoad_IsValid;

	private static IntPtr BGWRequestAsyncLoad_FunctionAddress;

	private static int BGWRequestAsyncLoad_ParamsSize;

	private static bool BGWRequestAsyncLoad_WorldContextObject_IsValid;

	private static FFieldAddress BGWRequestAsyncLoad_WorldContextObject_PropertyAddress;

	private static int BGWRequestAsyncLoad_WorldContextObject_Offset;

	private static bool BGWRequestAsyncLoad_LoadList_IsValid;

	private static FFieldAddress BGWRequestAsyncLoad_LoadList_PropertyAddress;

	private static int BGWRequestAsyncLoad_LoadList_Offset;

	private static bool BGWRequestAsyncLoad_CallBackDelegate_IsValid;

	private static FFieldAddress BGWRequestAsyncLoad_CallBackDelegate_PropertyAddress;

	private static int BGWRequestAsyncLoad_CallBackDelegate_Offset;

	private static bool BGWRemoveLevelFromWhiteList_IsValid;

	private static IntPtr BGWRemoveLevelFromWhiteList_FunctionAddress;

	private static int BGWRemoveLevelFromWhiteList_ParamsSize;

	private static bool BGWRemoveLevelFromWhiteList_WorldContextObject_IsValid;

	private static FFieldAddress BGWRemoveLevelFromWhiteList_WorldContextObject_PropertyAddress;

	private static int BGWRemoveLevelFromWhiteList_WorldContextObject_Offset;

	private static bool BGWRemoveLevelFromWhiteList_InLevelName_IsValid;

	private static FFieldAddress BGWRemoveLevelFromWhiteList_InLevelName_PropertyAddress;

	private static int BGWRemoveLevelFromWhiteList_InLevelName_Offset;

	private static bool BGWRemoveLevelFromBlackList_IsValid;

	private static IntPtr BGWRemoveLevelFromBlackList_FunctionAddress;

	private static int BGWRemoveLevelFromBlackList_ParamsSize;

	private static bool BGWRemoveLevelFromBlackList_WorldContextObject_IsValid;

	private static FFieldAddress BGWRemoveLevelFromBlackList_WorldContextObject_PropertyAddress;

	private static int BGWRemoveLevelFromBlackList_WorldContextObject_Offset;

	private static bool BGWRemoveLevelFromBlackList_InLevelName_IsValid;

	private static FFieldAddress BGWRemoveLevelFromBlackList_InLevelName_PropertyAddress;

	private static int BGWRemoveLevelFromBlackList_InLevelName_Offset;

	private static bool BGWProcessLevelStreamingVolumes_IsValid;

	private static IntPtr BGWProcessLevelStreamingVolumes_FunctionAddress;

	private static int BGWProcessLevelStreamingVolumes_ParamsSize;

	private static bool BGWProcessLevelStreamingVolumes_WorldContextObject_IsValid;

	private static FFieldAddress BGWProcessLevelStreamingVolumes_WorldContextObject_PropertyAddress;

	private static int BGWProcessLevelStreamingVolumes_WorldContextObject_Offset;

	private static bool BGWProcessLevelStreamingVolumes_OverrideViewLocation_IsValid;

	private static FFieldAddress BGWProcessLevelStreamingVolumes_OverrideViewLocation_PropertyAddress;

	private static int BGWProcessLevelStreamingVolumes_OverrideViewLocation_Offset;

	private static bool BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_IsValid;

	private static FFieldAddress BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_PropertyAddress;

	private static int BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_Offset;

	private static bool BGWGetStatusChangedStreamingLevels_IsValid;

	private static IntPtr BGWGetStatusChangedStreamingLevels_FunctionAddress;

	private static int BGWGetStatusChangedStreamingLevels_ParamsSize;

	private static bool BGWGetStatusChangedStreamingLevels_WorldContextObject_IsValid;

	private static FFieldAddress BGWGetStatusChangedStreamingLevels_WorldContextObject_PropertyAddress;

	private static int BGWGetStatusChangedStreamingLevels_WorldContextObject_Offset;

	private static bool BGWGetStatusChangedStreamingLevels_OutStreamingLevels_IsValid;

	private static FFieldAddress BGWGetStatusChangedStreamingLevels_OutStreamingLevels_PropertyAddress;

	private static int BGWGetStatusChangedStreamingLevels_OutStreamingLevels_Offset;

	private static bool BGWGetIsCameraMoveableWhenPaused_IsValid;

	private static IntPtr BGWGetIsCameraMoveableWhenPaused_FunctionAddress;

	private static int BGWGetIsCameraMoveableWhenPaused_ParamsSize;

	private static bool BGWGetIsCameraMoveableWhenPaused_WorldContextObject_IsValid;

	private static FFieldAddress BGWGetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress;

	private static int BGWGetIsCameraMoveableWhenPaused_WorldContextObject_Offset;

	private static bool BGWGetIsCameraMoveableWhenPaused_ReturnValue_IsValid;

	private static FFieldAddress BGWGetIsCameraMoveableWhenPaused_ReturnValue_PropertyAddress;

	private static int BGWGetIsCameraMoveableWhenPaused_ReturnValue_Offset;

	private static bool BGWGetAlwaysCookPathList_IsValid;

	private static IntPtr BGWGetAlwaysCookPathList_FunctionAddress;

	private static int BGWGetAlwaysCookPathList_ParamsSize;

	private static bool BGWGetAlwaysCookPathList_ReturnValue_IsValid;

	private static FFieldAddress BGWGetAlwaysCookPathList_ReturnValue_PropertyAddress;

	private static int BGWGetAlwaysCookPathList_ReturnValue_Offset;

	private static bool BGWGetAllStreamingLevels_IsValid;

	private static IntPtr BGWGetAllStreamingLevels_FunctionAddress;

	private static int BGWGetAllStreamingLevels_ParamsSize;

	private static bool BGWGetAllStreamingLevels_WorldContextObject_IsValid;

	private static FFieldAddress BGWGetAllStreamingLevels_WorldContextObject_PropertyAddress;

	private static int BGWGetAllStreamingLevels_WorldContextObject_Offset;

	private static bool BGWGetAllStreamingLevels_ReturnValue_IsValid;

	private static FFieldAddress BGWGetAllStreamingLevels_ReturnValue_PropertyAddress;

	private static int BGWGetAllStreamingLevels_ReturnValue_Offset;

	private static bool BGWFindWorldInPackage_IsValid;

	private static IntPtr BGWFindWorldInPackage_FunctionAddress;

	private static int BGWFindWorldInPackage_ParamsSize;

	private static bool BGWFindWorldInPackage_Package_IsValid;

	private static FFieldAddress BGWFindWorldInPackage_Package_PropertyAddress;

	private static int BGWFindWorldInPackage_Package_Offset;

	private static bool BGWFindWorldInPackage_ReturnValue_IsValid;

	private static FFieldAddress BGWFindWorldInPackage_ReturnValue_PropertyAddress;

	private static int BGWFindWorldInPackage_ReturnValue_Offset;

	private static bool BGWCreatePreloadDataAsset_IsValid;

	private static IntPtr BGWCreatePreloadDataAsset_FunctionAddress;

	private static int BGWCreatePreloadDataAsset_ParamsSize;

	private static bool BGWCreatePreloadDataAsset_FullPath_IsValid;

	private static FFieldAddress BGWCreatePreloadDataAsset_FullPath_PropertyAddress;

	private static int BGWCreatePreloadDataAsset_FullPath_Offset;

	private static bool BGWCreatePreloadDataAsset_Name_IsValid;

	private static FFieldAddress BGWCreatePreloadDataAsset_Name_PropertyAddress;

	private static int BGWCreatePreloadDataAsset_Name_Offset;

	private static bool BGWCreatePreloadDataAsset_ReturnValue_IsValid;

	private static FFieldAddress BGWCreatePreloadDataAsset_ReturnValue_PropertyAddress;

	private static int BGWCreatePreloadDataAsset_ReturnValue_Offset;

	private static bool BGWAddLevelToWhiteList_IsValid;

	private static IntPtr BGWAddLevelToWhiteList_FunctionAddress;

	private static int BGWAddLevelToWhiteList_ParamsSize;

	private static bool BGWAddLevelToWhiteList_WorldContextObject_IsValid;

	private static FFieldAddress BGWAddLevelToWhiteList_WorldContextObject_PropertyAddress;

	private static int BGWAddLevelToWhiteList_WorldContextObject_Offset;

	private static bool BGWAddLevelToWhiteList_InLevelName_IsValid;

	private static FFieldAddress BGWAddLevelToWhiteList_InLevelName_PropertyAddress;

	private static int BGWAddLevelToWhiteList_InLevelName_Offset;

	private static bool BGWAddLevelToWhiteList_InUsage_IsValid;

	private static FFieldAddress BGWAddLevelToWhiteList_InUsage_PropertyAddress;

	private static int BGWAddLevelToWhiteList_InUsage_Offset;

	private static bool BGWAddLevelToBlackList_IsValid;

	private static IntPtr BGWAddLevelToBlackList_FunctionAddress;

	private static int BGWAddLevelToBlackList_ParamsSize;

	private static bool BGWAddLevelToBlackList_WorldContextObject_IsValid;

	private static FFieldAddress BGWAddLevelToBlackList_WorldContextObject_PropertyAddress;

	private static int BGWAddLevelToBlackList_WorldContextObject_Offset;

	private static bool BGWAddLevelToBlackList_InLevelName_IsValid;

	private static FFieldAddress BGWAddLevelToBlackList_InLevelName_PropertyAddress;

	private static int BGWAddLevelToBlackList_InLevelName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:RetargetLevelStreamingLevelNames")]
	public unsafe static void RetargetLevelStreamingLevelNames(UObject WorldContext, string sourceNames, string destNames, string levelPrefix)
	{
		if (!RetargetLevelStreamingLevelNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:RetargetLevelStreamingLevelNames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RetargetLevelStreamingLevelNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RetargetLevelStreamingLevelNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RetargetLevelStreamingLevelNames_WorldContext_Offset), 0, RetargetLevelStreamingLevelNames_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RetargetLevelStreamingLevelNames_sourceNames_Offset), 0, RetargetLevelStreamingLevelNames_sourceNames_PropertyAddress.Address, sourceNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RetargetLevelStreamingLevelNames_destNames_Offset), 0, RetargetLevelStreamingLevelNames_destNames_PropertyAddress.Address, destNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RetargetLevelStreamingLevelNames_levelPrefix_Offset), 0, RetargetLevelStreamingLevelNames_levelPrefix_PropertyAddress.Address, levelPrefix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RetargetLevelStreamingLevelNames_FunctionAddress, intPtr, RetargetLevelStreamingLevelNames_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RetargetLevelStreamingLevelNames_sourceNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RetargetLevelStreamingLevelNames_destNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RetargetLevelStreamingLevelNames_levelPrefix_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:ResumeBGWVolumeLevelStreaming")]
	public unsafe static void ResumeBGWVolumeLevelStreaming(UObject WorldContextObject)
	{
		if (!ResumeBGWVolumeLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:ResumeBGWVolumeLevelStreaming");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeBGWVolumeLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeBGWVolumeLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ResumeBGWVolumeLevelStreaming_WorldContextObject_Offset), 0, ResumeBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResumeBGWVolumeLevelStreaming_FunctionAddress, intPtr, ResumeBGWVolumeLevelStreaming_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:PauseBGWVolumeLevelStreaming")]
	public unsafe static void PauseBGWVolumeLevelStreaming(UObject WorldContextObject)
	{
		if (!PauseBGWVolumeLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:PauseBGWVolumeLevelStreaming");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseBGWVolumeLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseBGWVolumeLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PauseBGWVolumeLevelStreaming_WorldContextObject_Offset), 0, PauseBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PauseBGWVolumeLevelStreaming_FunctionAddress, intPtr, PauseBGWVolumeLevelStreaming_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:MaintainVolumesContainYuanjing")]
	public unsafe static void MaintainVolumesContainYuanjing(List<ABGWLevelStreamingVolume> InStreamingVolumes)
	{
		if (!MaintainVolumesContainYuanjing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:MaintainVolumesContainYuanjing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MaintainVolumesContainYuanjing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MaintainVolumesContainYuanjing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<ABGWLevelStreamingVolume>(1, MaintainVolumesContainYuanjing_InStreamingVolumes_PropertyAddress, CachedMarshalingDelegates<ABGWLevelStreamingVolume, UObjectMarshaler<ABGWLevelStreamingVolume>>.FromNative, CachedMarshalingDelegates<ABGWLevelStreamingVolume, UObjectMarshaler<ABGWLevelStreamingVolume>>.ToNative).ToNative(IntPtr.Add(intPtr, MaintainVolumesContainYuanjing_InStreamingVolumes_Offset), InStreamingVolumes);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MaintainVolumesContainYuanjing_FunctionAddress, intPtr, MaintainVolumesContainYuanjing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MaintainVolumesContainYuanjing_InStreamingVolumes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:IsDistanceStreamingValid")]
	public unsafe static bool IsDistanceStreamingValid(UObject WorldContextObject)
	{
		if (!IsDistanceStreamingValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:IsDistanceStreamingValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDistanceStreamingValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDistanceStreamingValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsDistanceStreamingValid_WorldContextObject_Offset), 0, IsDistanceStreamingValid_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDistanceStreamingValid_FunctionAddress, intPtr, IsDistanceStreamingValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDistanceStreamingValid_ReturnValue_Offset), 0, IsDistanceStreamingValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:GetLevelStreamingAssetName")]
	public unsafe static string GetLevelStreamingAssetName(ULevelStreaming LevelStreaming)
	{
		if (!GetLevelStreamingAssetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:GetLevelStreamingAssetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreamingAssetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreamingAssetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingAssetName_LevelStreaming_Offset), 0, GetLevelStreamingAssetName_LevelStreaming_PropertyAddress.Address, LevelStreaming);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelStreamingAssetName_FunctionAddress, intPtr, GetLevelStreamingAssetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelStreamingAssetName_ReturnValue_Offset), 0, GetLevelStreamingAssetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLevelStreamingAssetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:GetBGWEvents")]
	public unsafe static UBGW_EventCollection GetBGWEvents(UObject WorldContextObject)
	{
		if (!GetBGWEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:GetBGWEvents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBGWEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBGWEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetBGWEvents_WorldContextObject_Offset), 0, GetBGWEvents_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBGWEvents_FunctionAddress, intPtr, GetBGWEvents_ParamsSize);
		return UObjectMarshaler<UBGW_EventCollection>.FromNative(IntPtr.Add(intPtr, GetBGWEvents_ReturnValue_Offset), 0, GetBGWEvents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWSetIsCameraMoveableWhenPaused")]
	public unsafe static void BGWSetIsCameraMoveableWhenPaused(UObject WorldContextObject, bool IsCameraMoveable)
	{
		if (!BGWSetIsCameraMoveableWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWSetIsCameraMoveableWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWSetIsCameraMoveableWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWSetIsCameraMoveableWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWSetIsCameraMoveableWhenPaused_WorldContextObject_Offset), 0, BGWSetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_Offset), 0, BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_PropertyAddress.Address, IsCameraMoveable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWSetIsCameraMoveableWhenPaused_FunctionAddress, intPtr, BGWSetIsCameraMoveableWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWSetGamePaused")]
	public unsafe static void BGWSetGamePaused(UObject WorldContextObject, bool bPaused)
	{
		if (!BGWSetGamePaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWSetGamePaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWSetGamePaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWSetGamePaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWSetGamePaused_WorldContextObject_Offset), 0, BGWSetGamePaused_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWSetGamePaused_bPaused_Offset), 0, BGWSetGamePaused_bPaused_PropertyAddress.Address, bPaused);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWSetGamePaused_FunctionAddress, intPtr, BGWSetGamePaused_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWSetAllLevelStreamingVolumeEnabled")]
	public unsafe static void BGWSetAllLevelStreamingVolumeEnabled(UObject WorldContextObject, bool bEnabled)
	{
		if (!BGWSetAllLevelStreamingVolumeEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWSetAllLevelStreamingVolumeEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWSetAllLevelStreamingVolumeEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWSetAllLevelStreamingVolumeEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_Offset), 0, BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWSetAllLevelStreamingVolumeEnabled_bEnabled_Offset), 0, BGWSetAllLevelStreamingVolumeEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, intPtr, BGWSetAllLevelStreamingVolumeEnabled_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWRequestAsyncLoad")]
	public unsafe static void BGWRequestAsyncLoad(UObject WorldContextObject, List<FSoftObjectPath> LoadList, FBUE_GrantItemsDeferred_CS CallBackDelegate)
	{
		if (!BGWRequestAsyncLoad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWRequestAsyncLoad");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWRequestAsyncLoad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWRequestAsyncLoad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWRequestAsyncLoad_WorldContextObject_Offset), 0, BGWRequestAsyncLoad_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<FSoftObjectPath>(1, BGWRequestAsyncLoad_LoadList_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(intPtr, BGWRequestAsyncLoad_LoadList_Offset), LoadList);
		FDelegateMarshaler<FBUE_GrantItemsDeferred_CS>.ToNative(IntPtr.Add(intPtr, BGWRequestAsyncLoad_CallBackDelegate_Offset), 0, BGWRequestAsyncLoad_CallBackDelegate_PropertyAddress.Address, CallBackDelegate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWRequestAsyncLoad_FunctionAddress, intPtr, BGWRequestAsyncLoad_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGWRequestAsyncLoad_LoadList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromWhiteList")]
	public unsafe static void BGWRemoveLevelFromWhiteList(UObject WorldContextObject, FName InLevelName)
	{
		if (!BGWRemoveLevelFromWhiteList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromWhiteList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWRemoveLevelFromWhiteList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWRemoveLevelFromWhiteList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWRemoveLevelFromWhiteList_WorldContextObject_Offset), 0, BGWRemoveLevelFromWhiteList_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGWRemoveLevelFromWhiteList_InLevelName_Offset), 0, BGWRemoveLevelFromWhiteList_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWRemoveLevelFromWhiteList_FunctionAddress, intPtr, BGWRemoveLevelFromWhiteList_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromBlackList")]
	public unsafe static void BGWRemoveLevelFromBlackList(UObject WorldContextObject, FName InLevelName)
	{
		if (!BGWRemoveLevelFromBlackList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromBlackList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWRemoveLevelFromBlackList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWRemoveLevelFromBlackList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWRemoveLevelFromBlackList_WorldContextObject_Offset), 0, BGWRemoveLevelFromBlackList_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGWRemoveLevelFromBlackList_InLevelName_Offset), 0, BGWRemoveLevelFromBlackList_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWRemoveLevelFromBlackList_FunctionAddress, intPtr, BGWRemoveLevelFromBlackList_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWProcessLevelStreamingVolumes")]
	public unsafe static void BGWProcessLevelStreamingVolumes(UObject WorldContextObject, FVector OverrideViewLocation, bool bUseOverrideViewLocation = false)
	{
		if (!BGWProcessLevelStreamingVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWProcessLevelStreamingVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWProcessLevelStreamingVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWProcessLevelStreamingVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWProcessLevelStreamingVolumes_WorldContextObject_Offset), 0, BGWProcessLevelStreamingVolumes_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGWProcessLevelStreamingVolumes_OverrideViewLocation_Offset), 0, BGWProcessLevelStreamingVolumes_OverrideViewLocation_PropertyAddress.Address, OverrideViewLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_Offset), 0, BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_PropertyAddress.Address, bUseOverrideViewLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWProcessLevelStreamingVolumes_FunctionAddress, intPtr, BGWProcessLevelStreamingVolumes_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWGetStatusChangedStreamingLevels")]
	public unsafe static void BGWGetStatusChangedStreamingLevels(UObject WorldContextObject, out Dictionary<ULevelStreaming, FGSStreamingLevelLoadSetting> OutStreamingLevels)
	{
		if (!BGWGetStatusChangedStreamingLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWGetStatusChangedStreamingLevels");
			OutStreamingLevels = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWGetStatusChangedStreamingLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWGetStatusChangedStreamingLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWGetStatusChangedStreamingLevels_WorldContextObject_Offset), 0, BGWGetStatusChangedStreamingLevels_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(BGWGetStatusChangedStreamingLevels_OutStreamingLevels_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWGetStatusChangedStreamingLevels_FunctionAddress, intPtr, BGWGetStatusChangedStreamingLevels_ParamsSize);
		OutStreamingLevels = new TMapCopyMarshaler<ULevelStreaming, FGSStreamingLevelLoadSetting>(1, BGWGetStatusChangedStreamingLevels_OutStreamingLevels_PropertyAddress, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.FromNative, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.ToNative, CachedMarshalingDelegates<FGSStreamingLevelLoadSetting, FGSStreamingLevelLoadSetting>.FromNative, CachedMarshalingDelegates<FGSStreamingLevelLoadSetting, FGSStreamingLevelLoadSetting>.ToNative).FromNative(IntPtr.Add(intPtr, BGWGetStatusChangedStreamingLevels_OutStreamingLevels_Offset));
		NativeReflection.DestroyValue_InContainer(BGWGetStatusChangedStreamingLevels_OutStreamingLevels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWGetIsCameraMoveableWhenPaused")]
	public unsafe static bool BGWGetIsCameraMoveableWhenPaused(UObject WorldContextObject)
	{
		if (!BGWGetIsCameraMoveableWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWGetIsCameraMoveableWhenPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWGetIsCameraMoveableWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWGetIsCameraMoveableWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWGetIsCameraMoveableWhenPaused_WorldContextObject_Offset), 0, BGWGetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWGetIsCameraMoveableWhenPaused_FunctionAddress, intPtr, BGWGetIsCameraMoveableWhenPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGWGetIsCameraMoveableWhenPaused_ReturnValue_Offset), 0, BGWGetIsCameraMoveableWhenPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWGetAlwaysCookPathList")]
	public unsafe static List<string> BGWGetAlwaysCookPathList()
	{
		if (!BGWGetAlwaysCookPathList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWGetAlwaysCookPathList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWGetAlwaysCookPathList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWGetAlwaysCookPathList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWGetAlwaysCookPathList_FunctionAddress, intPtr, BGWGetAlwaysCookPathList_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, BGWGetAlwaysCookPathList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, BGWGetAlwaysCookPathList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(BGWGetAlwaysCookPathList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWGetAllStreamingLevels")]
	public unsafe static List<ULevelStreaming> BGWGetAllStreamingLevels(UObject WorldContextObject)
	{
		if (!BGWGetAllStreamingLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWGetAllStreamingLevels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWGetAllStreamingLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWGetAllStreamingLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWGetAllStreamingLevels_WorldContextObject_Offset), 0, BGWGetAllStreamingLevels_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWGetAllStreamingLevels_FunctionAddress, intPtr, BGWGetAllStreamingLevels_ParamsSize);
		List<ULevelStreaming> result = new TArrayCopyMarshaler<ULevelStreaming>(1, BGWGetAllStreamingLevels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.FromNative, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.ToNative).FromNative(IntPtr.Add(intPtr, BGWGetAllStreamingLevels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(BGWGetAllStreamingLevels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWFindWorldInPackage")]
	public unsafe static UWorld BGWFindWorldInPackage(UPackage Package)
	{
		if (!BGWFindWorldInPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWFindWorldInPackage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWFindWorldInPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWFindWorldInPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, BGWFindWorldInPackage_Package_Offset), 0, BGWFindWorldInPackage_Package_PropertyAddress.Address, Package);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWFindWorldInPackage_FunctionAddress, intPtr, BGWFindWorldInPackage_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, BGWFindWorldInPackage_ReturnValue_Offset), 0, BGWFindWorldInPackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWCreatePreloadDataAsset")]
	public unsafe static bool BGWCreatePreloadDataAsset(string FullPath, string Name)
	{
		if (!BGWCreatePreloadDataAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWCreatePreloadDataAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWCreatePreloadDataAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWCreatePreloadDataAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGWCreatePreloadDataAsset_FullPath_Offset), 0, BGWCreatePreloadDataAsset_FullPath_PropertyAddress.Address, FullPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGWCreatePreloadDataAsset_Name_Offset), 0, BGWCreatePreloadDataAsset_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWCreatePreloadDataAsset_FunctionAddress, intPtr, BGWCreatePreloadDataAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGWCreatePreloadDataAsset_FullPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BGWCreatePreloadDataAsset_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGWCreatePreloadDataAsset_ReturnValue_Offset), 0, BGWCreatePreloadDataAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWAddLevelToWhiteList")]
	public unsafe static void BGWAddLevelToWhiteList(UObject WorldContextObject, FName InLevelName, EBGWStreamingVolumeUsage InUsage)
	{
		if (!BGWAddLevelToWhiteList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWAddLevelToWhiteList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWAddLevelToWhiteList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWAddLevelToWhiteList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWAddLevelToWhiteList_WorldContextObject_Offset), 0, BGWAddLevelToWhiteList_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGWAddLevelToWhiteList_InLevelName_Offset), 0, BGWAddLevelToWhiteList_InLevelName_PropertyAddress.Address, InLevelName);
		EnumMarshaler<EBGWStreamingVolumeUsage>.ToNative(IntPtr.Add(intPtr, BGWAddLevelToWhiteList_InUsage_Offset), 0, BGWAddLevelToWhiteList_InUsage_PropertyAddress.Address, InUsage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWAddLevelToWhiteList_FunctionAddress, intPtr, BGWAddLevelToWhiteList_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGWFunctionLibrary:BGWAddLevelToBlackList")]
	public unsafe static void BGWAddLevelToBlackList(UObject WorldContextObject, FName InLevelName)
	{
		if (!BGWAddLevelToBlackList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWFunctionLibrary:BGWAddLevelToBlackList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWAddLevelToBlackList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWAddLevelToBlackList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGWAddLevelToBlackList_WorldContextObject_Offset), 0, BGWAddLevelToBlackList_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGWAddLevelToBlackList_InLevelName_Offset), 0, BGWAddLevelToBlackList_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGWAddLevelToBlackList_FunctionAddress, intPtr, BGWAddLevelToBlackList_ParamsSize);
	}

	static UBGWFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWFunctionLibrary");
		RetargetLevelStreamingLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RetargetLevelStreamingLevelNames");
		RetargetLevelStreamingLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(RetargetLevelStreamingLevelNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RetargetLevelStreamingLevelNames_WorldContext_PropertyAddress, RetargetLevelStreamingLevelNames_FunctionAddress, "WorldContext");
		RetargetLevelStreamingLevelNames_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RetargetLevelStreamingLevelNames_FunctionAddress, "WorldContext");
		RetargetLevelStreamingLevelNames_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RetargetLevelStreamingLevelNames_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RetargetLevelStreamingLevelNames_sourceNames_PropertyAddress, RetargetLevelStreamingLevelNames_FunctionAddress, "sourceNames");
		RetargetLevelStreamingLevelNames_sourceNames_Offset = NativeReflectionCached.GetPropertyOffset(RetargetLevelStreamingLevelNames_FunctionAddress, "sourceNames");
		RetargetLevelStreamingLevelNames_sourceNames_IsValid = NativeReflectionCached.ValidatePropertyClass(RetargetLevelStreamingLevelNames_FunctionAddress, "sourceNames", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RetargetLevelStreamingLevelNames_destNames_PropertyAddress, RetargetLevelStreamingLevelNames_FunctionAddress, "destNames");
		RetargetLevelStreamingLevelNames_destNames_Offset = NativeReflectionCached.GetPropertyOffset(RetargetLevelStreamingLevelNames_FunctionAddress, "destNames");
		RetargetLevelStreamingLevelNames_destNames_IsValid = NativeReflectionCached.ValidatePropertyClass(RetargetLevelStreamingLevelNames_FunctionAddress, "destNames", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RetargetLevelStreamingLevelNames_levelPrefix_PropertyAddress, RetargetLevelStreamingLevelNames_FunctionAddress, "levelPrefix");
		RetargetLevelStreamingLevelNames_levelPrefix_Offset = NativeReflectionCached.GetPropertyOffset(RetargetLevelStreamingLevelNames_FunctionAddress, "levelPrefix");
		RetargetLevelStreamingLevelNames_levelPrefix_IsValid = NativeReflectionCached.ValidatePropertyClass(RetargetLevelStreamingLevelNames_FunctionAddress, "levelPrefix", Classes.FStrProperty);
		RetargetLevelStreamingLevelNames_IsValid = RetargetLevelStreamingLevelNames_FunctionAddress != IntPtr.Zero && RetargetLevelStreamingLevelNames_WorldContext_IsValid && RetargetLevelStreamingLevelNames_sourceNames_IsValid && RetargetLevelStreamingLevelNames_destNames_IsValid && RetargetLevelStreamingLevelNames_levelPrefix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:RetargetLevelStreamingLevelNames", RetargetLevelStreamingLevelNames_IsValid);
		ResumeBGWVolumeLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResumeBGWVolumeLevelStreaming");
		ResumeBGWVolumeLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeBGWVolumeLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResumeBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress, ResumeBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject");
		ResumeBGWVolumeLevelStreaming_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ResumeBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject");
		ResumeBGWVolumeLevelStreaming_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		ResumeBGWVolumeLevelStreaming_IsValid = ResumeBGWVolumeLevelStreaming_FunctionAddress != IntPtr.Zero && ResumeBGWVolumeLevelStreaming_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:ResumeBGWVolumeLevelStreaming", ResumeBGWVolumeLevelStreaming_IsValid);
		PauseBGWVolumeLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PauseBGWVolumeLevelStreaming");
		PauseBGWVolumeLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseBGWVolumeLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseBGWVolumeLevelStreaming_WorldContextObject_PropertyAddress, PauseBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject");
		PauseBGWVolumeLevelStreaming_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PauseBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject");
		PauseBGWVolumeLevelStreaming_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseBGWVolumeLevelStreaming_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		PauseBGWVolumeLevelStreaming_IsValid = PauseBGWVolumeLevelStreaming_FunctionAddress != IntPtr.Zero && PauseBGWVolumeLevelStreaming_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:PauseBGWVolumeLevelStreaming", PauseBGWVolumeLevelStreaming_IsValid);
		MaintainVolumesContainYuanjing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MaintainVolumesContainYuanjing");
		MaintainVolumesContainYuanjing_ParamsSize = NativeReflection.GetFunctionParamsSize(MaintainVolumesContainYuanjing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MaintainVolumesContainYuanjing_InStreamingVolumes_PropertyAddress, MaintainVolumesContainYuanjing_FunctionAddress, "InStreamingVolumes");
		MaintainVolumesContainYuanjing_InStreamingVolumes_Offset = NativeReflectionCached.GetPropertyOffset(MaintainVolumesContainYuanjing_FunctionAddress, "InStreamingVolumes");
		MaintainVolumesContainYuanjing_InStreamingVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(MaintainVolumesContainYuanjing_FunctionAddress, "InStreamingVolumes", Classes.FArrayProperty);
		MaintainVolumesContainYuanjing_IsValid = MaintainVolumesContainYuanjing_FunctionAddress != IntPtr.Zero && MaintainVolumesContainYuanjing_InStreamingVolumes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:MaintainVolumesContainYuanjing", MaintainVolumesContainYuanjing_IsValid);
		IsDistanceStreamingValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDistanceStreamingValid");
		IsDistanceStreamingValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDistanceStreamingValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDistanceStreamingValid_WorldContextObject_PropertyAddress, IsDistanceStreamingValid_FunctionAddress, "WorldContextObject");
		IsDistanceStreamingValid_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsDistanceStreamingValid_FunctionAddress, "WorldContextObject");
		IsDistanceStreamingValid_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDistanceStreamingValid_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDistanceStreamingValid_ReturnValue_PropertyAddress, IsDistanceStreamingValid_FunctionAddress, "ReturnValue");
		IsDistanceStreamingValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDistanceStreamingValid_FunctionAddress, "ReturnValue");
		IsDistanceStreamingValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDistanceStreamingValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDistanceStreamingValid_IsValid = IsDistanceStreamingValid_FunctionAddress != IntPtr.Zero && IsDistanceStreamingValid_WorldContextObject_IsValid && IsDistanceStreamingValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:IsDistanceStreamingValid", IsDistanceStreamingValid_IsValid);
		GetLevelStreamingAssetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelStreamingAssetName");
		GetLevelStreamingAssetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingAssetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingAssetName_LevelStreaming_PropertyAddress, GetLevelStreamingAssetName_FunctionAddress, "LevelStreaming");
		GetLevelStreamingAssetName_LevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingAssetName_FunctionAddress, "LevelStreaming");
		GetLevelStreamingAssetName_LevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingAssetName_FunctionAddress, "LevelStreaming", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingAssetName_ReturnValue_PropertyAddress, GetLevelStreamingAssetName_FunctionAddress, "ReturnValue");
		GetLevelStreamingAssetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingAssetName_FunctionAddress, "ReturnValue");
		GetLevelStreamingAssetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingAssetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLevelStreamingAssetName_IsValid = GetLevelStreamingAssetName_FunctionAddress != IntPtr.Zero && GetLevelStreamingAssetName_LevelStreaming_IsValid && GetLevelStreamingAssetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:GetLevelStreamingAssetName", GetLevelStreamingAssetName_IsValid);
		GetBGWEvents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBGWEvents");
		GetBGWEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBGWEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBGWEvents_WorldContextObject_PropertyAddress, GetBGWEvents_FunctionAddress, "WorldContextObject");
		GetBGWEvents_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetBGWEvents_FunctionAddress, "WorldContextObject");
		GetBGWEvents_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBGWEvents_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBGWEvents_ReturnValue_PropertyAddress, GetBGWEvents_FunctionAddress, "ReturnValue");
		GetBGWEvents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBGWEvents_FunctionAddress, "ReturnValue");
		GetBGWEvents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBGWEvents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBGWEvents_IsValid = GetBGWEvents_FunctionAddress != IntPtr.Zero && GetBGWEvents_WorldContextObject_IsValid && GetBGWEvents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:GetBGWEvents", GetBGWEvents_IsValid);
		BGWSetIsCameraMoveableWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWSetIsCameraMoveableWhenPaused");
		BGWSetIsCameraMoveableWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWSetIsCameraMoveableWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWSetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress, BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject");
		BGWSetIsCameraMoveableWhenPaused_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject");
		BGWSetIsCameraMoveableWhenPaused_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_PropertyAddress, BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "IsCameraMoveable");
		BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "IsCameraMoveable");
		BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetIsCameraMoveableWhenPaused_FunctionAddress, "IsCameraMoveable", Classes.FBoolProperty);
		BGWSetIsCameraMoveableWhenPaused_IsValid = BGWSetIsCameraMoveableWhenPaused_FunctionAddress != IntPtr.Zero && BGWSetIsCameraMoveableWhenPaused_WorldContextObject_IsValid && BGWSetIsCameraMoveableWhenPaused_IsCameraMoveable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWSetIsCameraMoveableWhenPaused", BGWSetIsCameraMoveableWhenPaused_IsValid);
		BGWSetGamePaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWSetGamePaused");
		BGWSetGamePaused_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWSetGamePaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWSetGamePaused_WorldContextObject_PropertyAddress, BGWSetGamePaused_FunctionAddress, "WorldContextObject");
		BGWSetGamePaused_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetGamePaused_FunctionAddress, "WorldContextObject");
		BGWSetGamePaused_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetGamePaused_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWSetGamePaused_bPaused_PropertyAddress, BGWSetGamePaused_FunctionAddress, "bPaused");
		BGWSetGamePaused_bPaused_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetGamePaused_FunctionAddress, "bPaused");
		BGWSetGamePaused_bPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetGamePaused_FunctionAddress, "bPaused", Classes.FBoolProperty);
		BGWSetGamePaused_IsValid = BGWSetGamePaused_FunctionAddress != IntPtr.Zero && BGWSetGamePaused_WorldContextObject_IsValid && BGWSetGamePaused_bPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWSetGamePaused", BGWSetGamePaused_IsValid);
		BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWSetAllLevelStreamingVolumeEnabled");
		BGWSetAllLevelStreamingVolumeEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_PropertyAddress, BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "WorldContextObject");
		BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "WorldContextObject");
		BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWSetAllLevelStreamingVolumeEnabled_bEnabled_PropertyAddress, BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "bEnabled");
		BGWSetAllLevelStreamingVolumeEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "bEnabled");
		BGWSetAllLevelStreamingVolumeEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		BGWSetAllLevelStreamingVolumeEnabled_IsValid = BGWSetAllLevelStreamingVolumeEnabled_FunctionAddress != IntPtr.Zero && BGWSetAllLevelStreamingVolumeEnabled_WorldContextObject_IsValid && BGWSetAllLevelStreamingVolumeEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWSetAllLevelStreamingVolumeEnabled", BGWSetAllLevelStreamingVolumeEnabled_IsValid);
		BGWRequestAsyncLoad_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWRequestAsyncLoad");
		BGWRequestAsyncLoad_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWRequestAsyncLoad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWRequestAsyncLoad_WorldContextObject_PropertyAddress, BGWRequestAsyncLoad_FunctionAddress, "WorldContextObject");
		BGWRequestAsyncLoad_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWRequestAsyncLoad_FunctionAddress, "WorldContextObject");
		BGWRequestAsyncLoad_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRequestAsyncLoad_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWRequestAsyncLoad_LoadList_PropertyAddress, BGWRequestAsyncLoad_FunctionAddress, "LoadList");
		BGWRequestAsyncLoad_LoadList_Offset = NativeReflectionCached.GetPropertyOffset(BGWRequestAsyncLoad_FunctionAddress, "LoadList");
		BGWRequestAsyncLoad_LoadList_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRequestAsyncLoad_FunctionAddress, "LoadList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWRequestAsyncLoad_CallBackDelegate_PropertyAddress, BGWRequestAsyncLoad_FunctionAddress, "CallBackDelegate");
		BGWRequestAsyncLoad_CallBackDelegate_Offset = NativeReflectionCached.GetPropertyOffset(BGWRequestAsyncLoad_FunctionAddress, "CallBackDelegate");
		BGWRequestAsyncLoad_CallBackDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRequestAsyncLoad_FunctionAddress, "CallBackDelegate", Classes.FDelegateProperty);
		BGWRequestAsyncLoad_IsValid = BGWRequestAsyncLoad_FunctionAddress != IntPtr.Zero && BGWRequestAsyncLoad_WorldContextObject_IsValid && BGWRequestAsyncLoad_LoadList_IsValid && BGWRequestAsyncLoad_CallBackDelegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWRequestAsyncLoad", BGWRequestAsyncLoad_IsValid);
		BGWRemoveLevelFromWhiteList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWRemoveLevelFromWhiteList");
		BGWRemoveLevelFromWhiteList_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWRemoveLevelFromWhiteList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWRemoveLevelFromWhiteList_WorldContextObject_PropertyAddress, BGWRemoveLevelFromWhiteList_FunctionAddress, "WorldContextObject");
		BGWRemoveLevelFromWhiteList_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWRemoveLevelFromWhiteList_FunctionAddress, "WorldContextObject");
		BGWRemoveLevelFromWhiteList_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRemoveLevelFromWhiteList_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWRemoveLevelFromWhiteList_InLevelName_PropertyAddress, BGWRemoveLevelFromWhiteList_FunctionAddress, "InLevelName");
		BGWRemoveLevelFromWhiteList_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGWRemoveLevelFromWhiteList_FunctionAddress, "InLevelName");
		BGWRemoveLevelFromWhiteList_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRemoveLevelFromWhiteList_FunctionAddress, "InLevelName", Classes.FNameProperty);
		BGWRemoveLevelFromWhiteList_IsValid = BGWRemoveLevelFromWhiteList_FunctionAddress != IntPtr.Zero && BGWRemoveLevelFromWhiteList_WorldContextObject_IsValid && BGWRemoveLevelFromWhiteList_InLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromWhiteList", BGWRemoveLevelFromWhiteList_IsValid);
		BGWRemoveLevelFromBlackList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWRemoveLevelFromBlackList");
		BGWRemoveLevelFromBlackList_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWRemoveLevelFromBlackList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWRemoveLevelFromBlackList_WorldContextObject_PropertyAddress, BGWRemoveLevelFromBlackList_FunctionAddress, "WorldContextObject");
		BGWRemoveLevelFromBlackList_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWRemoveLevelFromBlackList_FunctionAddress, "WorldContextObject");
		BGWRemoveLevelFromBlackList_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRemoveLevelFromBlackList_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWRemoveLevelFromBlackList_InLevelName_PropertyAddress, BGWRemoveLevelFromBlackList_FunctionAddress, "InLevelName");
		BGWRemoveLevelFromBlackList_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGWRemoveLevelFromBlackList_FunctionAddress, "InLevelName");
		BGWRemoveLevelFromBlackList_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWRemoveLevelFromBlackList_FunctionAddress, "InLevelName", Classes.FNameProperty);
		BGWRemoveLevelFromBlackList_IsValid = BGWRemoveLevelFromBlackList_FunctionAddress != IntPtr.Zero && BGWRemoveLevelFromBlackList_WorldContextObject_IsValid && BGWRemoveLevelFromBlackList_InLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWRemoveLevelFromBlackList", BGWRemoveLevelFromBlackList_IsValid);
		BGWProcessLevelStreamingVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWProcessLevelStreamingVolumes");
		BGWProcessLevelStreamingVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWProcessLevelStreamingVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWProcessLevelStreamingVolumes_WorldContextObject_PropertyAddress, BGWProcessLevelStreamingVolumes_FunctionAddress, "WorldContextObject");
		BGWProcessLevelStreamingVolumes_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWProcessLevelStreamingVolumes_FunctionAddress, "WorldContextObject");
		BGWProcessLevelStreamingVolumes_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWProcessLevelStreamingVolumes_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWProcessLevelStreamingVolumes_OverrideViewLocation_PropertyAddress, BGWProcessLevelStreamingVolumes_FunctionAddress, "OverrideViewLocation");
		BGWProcessLevelStreamingVolumes_OverrideViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGWProcessLevelStreamingVolumes_FunctionAddress, "OverrideViewLocation");
		BGWProcessLevelStreamingVolumes_OverrideViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWProcessLevelStreamingVolumes_FunctionAddress, "OverrideViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_PropertyAddress, BGWProcessLevelStreamingVolumes_FunctionAddress, "bUseOverrideViewLocation");
		BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGWProcessLevelStreamingVolumes_FunctionAddress, "bUseOverrideViewLocation");
		BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWProcessLevelStreamingVolumes_FunctionAddress, "bUseOverrideViewLocation", Classes.FBoolProperty);
		BGWProcessLevelStreamingVolumes_IsValid = BGWProcessLevelStreamingVolumes_FunctionAddress != IntPtr.Zero && BGWProcessLevelStreamingVolumes_WorldContextObject_IsValid && BGWProcessLevelStreamingVolumes_OverrideViewLocation_IsValid && BGWProcessLevelStreamingVolumes_bUseOverrideViewLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWProcessLevelStreamingVolumes", BGWProcessLevelStreamingVolumes_IsValid);
		BGWGetStatusChangedStreamingLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWGetStatusChangedStreamingLevels");
		BGWGetStatusChangedStreamingLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWGetStatusChangedStreamingLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWGetStatusChangedStreamingLevels_WorldContextObject_PropertyAddress, BGWGetStatusChangedStreamingLevels_FunctionAddress, "WorldContextObject");
		BGWGetStatusChangedStreamingLevels_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetStatusChangedStreamingLevels_FunctionAddress, "WorldContextObject");
		BGWGetStatusChangedStreamingLevels_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetStatusChangedStreamingLevels_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetStatusChangedStreamingLevels_OutStreamingLevels_PropertyAddress, BGWGetStatusChangedStreamingLevels_FunctionAddress, "OutStreamingLevels");
		BGWGetStatusChangedStreamingLevels_OutStreamingLevels_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetStatusChangedStreamingLevels_FunctionAddress, "OutStreamingLevels");
		BGWGetStatusChangedStreamingLevels_OutStreamingLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetStatusChangedStreamingLevels_FunctionAddress, "OutStreamingLevels", Classes.FMapProperty);
		BGWGetStatusChangedStreamingLevels_IsValid = BGWGetStatusChangedStreamingLevels_FunctionAddress != IntPtr.Zero && BGWGetStatusChangedStreamingLevels_WorldContextObject_IsValid && BGWGetStatusChangedStreamingLevels_OutStreamingLevels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWGetStatusChangedStreamingLevels", BGWGetStatusChangedStreamingLevels_IsValid);
		BGWGetIsCameraMoveableWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWGetIsCameraMoveableWhenPaused");
		BGWGetIsCameraMoveableWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWGetIsCameraMoveableWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWGetIsCameraMoveableWhenPaused_WorldContextObject_PropertyAddress, BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject");
		BGWGetIsCameraMoveableWhenPaused_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject");
		BGWGetIsCameraMoveableWhenPaused_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetIsCameraMoveableWhenPaused_ReturnValue_PropertyAddress, BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "ReturnValue");
		BGWGetIsCameraMoveableWhenPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "ReturnValue");
		BGWGetIsCameraMoveableWhenPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetIsCameraMoveableWhenPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGWGetIsCameraMoveableWhenPaused_IsValid = BGWGetIsCameraMoveableWhenPaused_FunctionAddress != IntPtr.Zero && BGWGetIsCameraMoveableWhenPaused_WorldContextObject_IsValid && BGWGetIsCameraMoveableWhenPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWGetIsCameraMoveableWhenPaused", BGWGetIsCameraMoveableWhenPaused_IsValid);
		BGWGetAlwaysCookPathList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWGetAlwaysCookPathList");
		BGWGetAlwaysCookPathList_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWGetAlwaysCookPathList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWGetAlwaysCookPathList_ReturnValue_PropertyAddress, BGWGetAlwaysCookPathList_FunctionAddress, "ReturnValue");
		BGWGetAlwaysCookPathList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetAlwaysCookPathList_FunctionAddress, "ReturnValue");
		BGWGetAlwaysCookPathList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetAlwaysCookPathList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BGWGetAlwaysCookPathList_IsValid = BGWGetAlwaysCookPathList_FunctionAddress != IntPtr.Zero && BGWGetAlwaysCookPathList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWGetAlwaysCookPathList", BGWGetAlwaysCookPathList_IsValid);
		BGWGetAllStreamingLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWGetAllStreamingLevels");
		BGWGetAllStreamingLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWGetAllStreamingLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWGetAllStreamingLevels_WorldContextObject_PropertyAddress, BGWGetAllStreamingLevels_FunctionAddress, "WorldContextObject");
		BGWGetAllStreamingLevels_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetAllStreamingLevels_FunctionAddress, "WorldContextObject");
		BGWGetAllStreamingLevels_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetAllStreamingLevels_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetAllStreamingLevels_ReturnValue_PropertyAddress, BGWGetAllStreamingLevels_FunctionAddress, "ReturnValue");
		BGWGetAllStreamingLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetAllStreamingLevels_FunctionAddress, "ReturnValue");
		BGWGetAllStreamingLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetAllStreamingLevels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BGWGetAllStreamingLevels_IsValid = BGWGetAllStreamingLevels_FunctionAddress != IntPtr.Zero && BGWGetAllStreamingLevels_WorldContextObject_IsValid && BGWGetAllStreamingLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWGetAllStreamingLevels", BGWGetAllStreamingLevels_IsValid);
		BGWFindWorldInPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWFindWorldInPackage");
		BGWFindWorldInPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWFindWorldInPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWFindWorldInPackage_Package_PropertyAddress, BGWFindWorldInPackage_FunctionAddress, "Package");
		BGWFindWorldInPackage_Package_Offset = NativeReflectionCached.GetPropertyOffset(BGWFindWorldInPackage_FunctionAddress, "Package");
		BGWFindWorldInPackage_Package_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWFindWorldInPackage_FunctionAddress, "Package", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWFindWorldInPackage_ReturnValue_PropertyAddress, BGWFindWorldInPackage_FunctionAddress, "ReturnValue");
		BGWFindWorldInPackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWFindWorldInPackage_FunctionAddress, "ReturnValue");
		BGWFindWorldInPackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWFindWorldInPackage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGWFindWorldInPackage_IsValid = BGWFindWorldInPackage_FunctionAddress != IntPtr.Zero && BGWFindWorldInPackage_Package_IsValid && BGWFindWorldInPackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWFindWorldInPackage", BGWFindWorldInPackage_IsValid);
		BGWCreatePreloadDataAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWCreatePreloadDataAsset");
		BGWCreatePreloadDataAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWCreatePreloadDataAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWCreatePreloadDataAsset_FullPath_PropertyAddress, BGWCreatePreloadDataAsset_FunctionAddress, "FullPath");
		BGWCreatePreloadDataAsset_FullPath_Offset = NativeReflectionCached.GetPropertyOffset(BGWCreatePreloadDataAsset_FunctionAddress, "FullPath");
		BGWCreatePreloadDataAsset_FullPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWCreatePreloadDataAsset_FunctionAddress, "FullPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWCreatePreloadDataAsset_Name_PropertyAddress, BGWCreatePreloadDataAsset_FunctionAddress, "Name");
		BGWCreatePreloadDataAsset_Name_Offset = NativeReflectionCached.GetPropertyOffset(BGWCreatePreloadDataAsset_FunctionAddress, "Name");
		BGWCreatePreloadDataAsset_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWCreatePreloadDataAsset_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWCreatePreloadDataAsset_ReturnValue_PropertyAddress, BGWCreatePreloadDataAsset_FunctionAddress, "ReturnValue");
		BGWCreatePreloadDataAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWCreatePreloadDataAsset_FunctionAddress, "ReturnValue");
		BGWCreatePreloadDataAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWCreatePreloadDataAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGWCreatePreloadDataAsset_IsValid = BGWCreatePreloadDataAsset_FunctionAddress != IntPtr.Zero && BGWCreatePreloadDataAsset_FullPath_IsValid && BGWCreatePreloadDataAsset_Name_IsValid && BGWCreatePreloadDataAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWCreatePreloadDataAsset", BGWCreatePreloadDataAsset_IsValid);
		BGWAddLevelToWhiteList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWAddLevelToWhiteList");
		BGWAddLevelToWhiteList_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWAddLevelToWhiteList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWAddLevelToWhiteList_WorldContextObject_PropertyAddress, BGWAddLevelToWhiteList_FunctionAddress, "WorldContextObject");
		BGWAddLevelToWhiteList_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWAddLevelToWhiteList_FunctionAddress, "WorldContextObject");
		BGWAddLevelToWhiteList_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWAddLevelToWhiteList_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWAddLevelToWhiteList_InLevelName_PropertyAddress, BGWAddLevelToWhiteList_FunctionAddress, "InLevelName");
		BGWAddLevelToWhiteList_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGWAddLevelToWhiteList_FunctionAddress, "InLevelName");
		BGWAddLevelToWhiteList_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWAddLevelToWhiteList_FunctionAddress, "InLevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWAddLevelToWhiteList_InUsage_PropertyAddress, BGWAddLevelToWhiteList_FunctionAddress, "InUsage");
		BGWAddLevelToWhiteList_InUsage_Offset = NativeReflectionCached.GetPropertyOffset(BGWAddLevelToWhiteList_FunctionAddress, "InUsage");
		BGWAddLevelToWhiteList_InUsage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWAddLevelToWhiteList_FunctionAddress, "InUsage", Classes.FEnumProperty);
		BGWAddLevelToWhiteList_IsValid = BGWAddLevelToWhiteList_FunctionAddress != IntPtr.Zero && BGWAddLevelToWhiteList_WorldContextObject_IsValid && BGWAddLevelToWhiteList_InLevelName_IsValid && BGWAddLevelToWhiteList_InUsage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWAddLevelToWhiteList", BGWAddLevelToWhiteList_IsValid);
		BGWAddLevelToBlackList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGWAddLevelToBlackList");
		BGWAddLevelToBlackList_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWAddLevelToBlackList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWAddLevelToBlackList_WorldContextObject_PropertyAddress, BGWAddLevelToBlackList_FunctionAddress, "WorldContextObject");
		BGWAddLevelToBlackList_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGWAddLevelToBlackList_FunctionAddress, "WorldContextObject");
		BGWAddLevelToBlackList_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWAddLevelToBlackList_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWAddLevelToBlackList_InLevelName_PropertyAddress, BGWAddLevelToBlackList_FunctionAddress, "InLevelName");
		BGWAddLevelToBlackList_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGWAddLevelToBlackList_FunctionAddress, "InLevelName");
		BGWAddLevelToBlackList_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWAddLevelToBlackList_FunctionAddress, "InLevelName", Classes.FNameProperty);
		BGWAddLevelToBlackList_IsValid = BGWAddLevelToBlackList_FunctionAddress != IntPtr.Zero && BGWAddLevelToBlackList_WorldContextObject_IsValid && BGWAddLevelToBlackList_InLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWFunctionLibrary:BGWAddLevelToBlackList", BGWAddLevelToBlackList_IsValid);
	}
}
