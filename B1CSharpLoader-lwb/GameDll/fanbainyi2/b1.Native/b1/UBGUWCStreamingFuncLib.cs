using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUWCStreamingFuncLib", "b1", UnrealModuleType.Game)]
public class UBGUWCStreamingFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateStreamingState_IsValid;

	private static IntPtr UpdateStreamingState_FunctionAddress;

	private static int UpdateStreamingState_ParamsSize;

	private static bool UpdateStreamingState_WorldContext_IsValid;

	private static FFieldAddress UpdateStreamingState_WorldContext_PropertyAddress;

	private static int UpdateStreamingState_WorldContext_Offset;

	private static bool UpdateStreamingState_bBlockTillComplete_IsValid;

	private static FFieldAddress UpdateStreamingState_bBlockTillComplete_PropertyAddress;

	private static int UpdateStreamingState_bBlockTillComplete_Offset;

	private static bool UnregisterFromStreamingSource_IsValid;

	private static IntPtr UnregisterFromStreamingSource_FunctionAddress;

	private static int UnregisterFromStreamingSource_ParamsSize;

	private static bool UnregisterFromStreamingSource_InActor_IsValid;

	private static FFieldAddress UnregisterFromStreamingSource_InActor_PropertyAddress;

	private static int UnregisterFromStreamingSource_InActor_Offset;

	private static bool SpawnStreamingSource_IsValid;

	private static IntPtr SpawnStreamingSource_FunctionAddress;

	private static int SpawnStreamingSource_ParamsSize;

	private static bool SpawnStreamingSource_WorldContext_IsValid;

	private static FFieldAddress SpawnStreamingSource_WorldContext_PropertyAddress;

	private static int SpawnStreamingSource_WorldContext_Offset;

	private static bool SpawnStreamingSource_SpawnLocation_IsValid;

	private static FFieldAddress SpawnStreamingSource_SpawnLocation_PropertyAddress;

	private static int SpawnStreamingSource_SpawnLocation_Offset;

	private static bool SetStreamingManagerViewSource_IsValid;

	private static IntPtr SetStreamingManagerViewSource_FunctionAddress;

	private static int SetStreamingManagerViewSource_ParamsSize;

	private static bool SetStreamingManagerViewSource_ViewLocation_IsValid;

	private static FFieldAddress SetStreamingManagerViewSource_ViewLocation_PropertyAddress;

	private static int SetStreamingManagerViewSource_ViewLocation_Offset;

	private static bool SetStreamingManagerViewSource_Duration_IsValid;

	private static FFieldAddress SetStreamingManagerViewSource_Duration_PropertyAddress;

	private static int SetStreamingManagerViewSource_Duration_Offset;

	private static bool SetLevelsStateByNames_IsValid;

	private static IntPtr SetLevelsStateByNames_FunctionAddress;

	private static int SetLevelsStateByNames_ParamsSize;

	private static bool SetLevelsStateByNames_InWorldContext_IsValid;

	private static FFieldAddress SetLevelsStateByNames_InWorldContext_PropertyAddress;

	private static int SetLevelsStateByNames_InWorldContext_Offset;

	private static bool SetLevelsStateByNames_InTargetLevelNames_IsValid;

	private static FFieldAddress SetLevelsStateByNames_InTargetLevelNames_PropertyAddress;

	private static int SetLevelsStateByNames_InTargetLevelNames_Offset;

	private static bool SetLevelsStateByNames_InTargetState_IsValid;

	private static FFieldAddress SetLevelsStateByNames_InTargetState_PropertyAddress;

	private static int SetLevelsStateByNames_InTargetState_Offset;

	private static bool SetLevelsStateByNames_InOperationID_IsValid;

	private static FFieldAddress SetLevelsStateByNames_InOperationID_PropertyAddress;

	private static int SetLevelsStateByNames_InOperationID_Offset;

	private static bool SetLevelsStateByNames_bBlockOnLoad_IsValid;

	private static FFieldAddress SetLevelsStateByNames_bBlockOnLoad_PropertyAddress;

	private static int SetLevelsStateByNames_bBlockOnLoad_Offset;

	private static bool SetLevelsStateByNames_ReturnValue_IsValid;

	private static FFieldAddress SetLevelsStateByNames_ReturnValue_PropertyAddress;

	private static int SetLevelsStateByNames_ReturnValue_Offset;

	private static bool SetLevelsState_IsValid;

	private static IntPtr SetLevelsState_FunctionAddress;

	private static int SetLevelsState_ParamsSize;

	private static bool SetLevelsState_InWorldContext_IsValid;

	private static FFieldAddress SetLevelsState_InWorldContext_PropertyAddress;

	private static int SetLevelsState_InWorldContext_Offset;

	private static bool SetLevelsState_InTargetLevelNameOrKeyword_IsValid;

	private static FFieldAddress SetLevelsState_InTargetLevelNameOrKeyword_PropertyAddress;

	private static int SetLevelsState_InTargetLevelNameOrKeyword_Offset;

	private static bool SetLevelsState_InTargetState_IsValid;

	private static FFieldAddress SetLevelsState_InTargetState_PropertyAddress;

	private static int SetLevelsState_InTargetState_Offset;

	private static bool SetLevelsState_InOperationID_IsValid;

	private static FFieldAddress SetLevelsState_InOperationID_PropertyAddress;

	private static int SetLevelsState_InOperationID_Offset;

	private static bool SetLevelsState_bKeywordMatch_IsValid;

	private static FFieldAddress SetLevelsState_bKeywordMatch_PropertyAddress;

	private static int SetLevelsState_bKeywordMatch_Offset;

	private static bool SetLevelsState_bBlockOnLoad_IsValid;

	private static FFieldAddress SetLevelsState_bBlockOnLoad_PropertyAddress;

	private static int SetLevelsState_bBlockOnLoad_Offset;

	private static bool SetLevelsState_ReturnValue_IsValid;

	private static FFieldAddress SetLevelsState_ReturnValue_PropertyAddress;

	private static int SetLevelsState_ReturnValue_Offset;

	private static bool RegisterAsStreamingSource_IsValid;

	private static IntPtr RegisterAsStreamingSource_FunctionAddress;

	private static int RegisterAsStreamingSource_ParamsSize;

	private static bool RegisterAsStreamingSource_InActor_IsValid;

	private static FFieldAddress RegisterAsStreamingSource_InActor_PropertyAddress;

	private static int RegisterAsStreamingSource_InActor_Offset;

	private static bool QueryProcessingStreamingLevels_IsValid;

	private static IntPtr QueryProcessingStreamingLevels_FunctionAddress;

	private static int QueryProcessingStreamingLevels_ParamsSize;

	private static bool QueryProcessingStreamingLevels_InWorldContext_IsValid;

	private static FFieldAddress QueryProcessingStreamingLevels_InWorldContext_PropertyAddress;

	private static int QueryProcessingStreamingLevels_InWorldContext_Offset;

	private static bool QueryProcessingStreamingLevels_ReturnValue_IsValid;

	private static FFieldAddress QueryProcessingStreamingLevels_ReturnValue_PropertyAddress;

	private static int QueryProcessingStreamingLevels_ReturnValue_Offset;

	private static bool PauseDistanceStreaming_IsValid;

	private static IntPtr PauseDistanceStreaming_FunctionAddress;

	private static int PauseDistanceStreaming_ParamsSize;

	private static bool PauseDistanceStreaming_InWorldContext_IsValid;

	private static FFieldAddress PauseDistanceStreaming_InWorldContext_PropertyAddress;

	private static int PauseDistanceStreaming_InWorldContext_Offset;

	private static bool PauseDistanceStreaming_InExcludedLevelKeywords_IsValid;

	private static FFieldAddress PauseDistanceStreaming_InExcludedLevelKeywords_PropertyAddress;

	private static int PauseDistanceStreaming_InExcludedLevelKeywords_Offset;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_IsValid;

	private static IntPtr ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_ParamsSize;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_IsValid;

	private static FFieldAddress ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_PropertyAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_Offset;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_IsValid;

	private static FFieldAddress ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_PropertyAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_Offset;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_IsValid;

	private static FFieldAddress ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_PropertyAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_Offset;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_IsValid;

	private static FFieldAddress ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_PropertyAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_Offset;

	private static bool ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_IsValid;

	private static FFieldAddress ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_PropertyAddress;

	private static int ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_Offset;

	private static bool IsLevelStreamable_IsValid;

	private static IntPtr IsLevelStreamable_FunctionAddress;

	private static int IsLevelStreamable_ParamsSize;

	private static bool IsLevelStreamable_InWorldContext_IsValid;

	private static FFieldAddress IsLevelStreamable_InWorldContext_PropertyAddress;

	private static int IsLevelStreamable_InWorldContext_Offset;

	private static bool IsLevelStreamable_InTargetLevelName_IsValid;

	private static FFieldAddress IsLevelStreamable_InTargetLevelName_PropertyAddress;

	private static int IsLevelStreamable_InTargetLevelName_Offset;

	private static bool IsLevelStreamable_ReturnValue_IsValid;

	private static FFieldAddress IsLevelStreamable_ReturnValue_PropertyAddress;

	private static int IsLevelStreamable_ReturnValue_Offset;

	private static bool GetProcessingStreamingLevelNum_IsValid;

	private static IntPtr GetProcessingStreamingLevelNum_FunctionAddress;

	private static int GetProcessingStreamingLevelNum_ParamsSize;

	private static bool GetProcessingStreamingLevelNum_InWorldContext_IsValid;

	private static FFieldAddress GetProcessingStreamingLevelNum_InWorldContext_PropertyAddress;

	private static int GetProcessingStreamingLevelNum_InWorldContext_Offset;

	private static bool GetProcessingStreamingLevelNum_ReturnValue_IsValid;

	private static FFieldAddress GetProcessingStreamingLevelNum_ReturnValue_PropertyAddress;

	private static int GetProcessingStreamingLevelNum_ReturnValue_Offset;

	private static bool GetLevelNamesByKeyword_IsValid;

	private static IntPtr GetLevelNamesByKeyword_FunctionAddress;

	private static int GetLevelNamesByKeyword_ParamsSize;

	private static bool GetLevelNamesByKeyword_InWorldContext_IsValid;

	private static FFieldAddress GetLevelNamesByKeyword_InWorldContext_PropertyAddress;

	private static int GetLevelNamesByKeyword_InWorldContext_Offset;

	private static bool GetLevelNamesByKeyword_InLevelNameKeyword_IsValid;

	private static FFieldAddress GetLevelNamesByKeyword_InLevelNameKeyword_PropertyAddress;

	private static int GetLevelNamesByKeyword_InLevelNameKeyword_Offset;

	private static bool GetLevelNamesByKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetLevelNamesByKeyword_ReturnValue_PropertyAddress;

	private static int GetLevelNamesByKeyword_ReturnValue_Offset;

	private static bool GetLevelNames_IsValid;

	private static IntPtr GetLevelNames_FunctionAddress;

	private static int GetLevelNames_ParamsSize;

	private static bool GetLevelNames_InWorldContext_IsValid;

	private static FFieldAddress GetLevelNames_InWorldContext_PropertyAddress;

	private static int GetLevelNames_InWorldContext_Offset;

	private static bool GetLevelNames_OutLevelNames_IsValid;

	private static FFieldAddress GetLevelNames_OutLevelNames_PropertyAddress;

	private static int GetLevelNames_OutLevelNames_Offset;

	private static bool GetLevelNames_ReturnValue_IsValid;

	private static FFieldAddress GetLevelNames_ReturnValue_PropertyAddress;

	private static int GetLevelNames_ReturnValue_Offset;

	private static bool GetLevelCurrentStateAndIsConsideredUpdate_IsValid;

	private static IntPtr GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress;

	private static int GetLevelCurrentStateAndIsConsideredUpdate_ParamsSize;

	private static bool GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_IsValid;

	private static FFieldAddress GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_PropertyAddress;

	private static int GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_Offset;

	private static bool GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_IsValid;

	private static FFieldAddress GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_PropertyAddress;

	private static int GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_Offset;

	private static bool GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_IsValid;

	private static FFieldAddress GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_PropertyAddress;

	private static int GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_Offset;

	private static bool GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_IsValid;

	private static FFieldAddress GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_PropertyAddress;

	private static int GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_Offset;

	private static bool GetAllLevelCurrentState_IsValid;

	private static IntPtr GetAllLevelCurrentState_FunctionAddress;

	private static int GetAllLevelCurrentState_ParamsSize;

	private static bool GetAllLevelCurrentState_InWorldContext_IsValid;

	private static FFieldAddress GetAllLevelCurrentState_InWorldContext_PropertyAddress;

	private static int GetAllLevelCurrentState_InWorldContext_Offset;

	private static bool GetAllLevelCurrentState_OutLevelStreamingList_IsValid;

	private static FFieldAddress GetAllLevelCurrentState_OutLevelStreamingList_PropertyAddress;

	private static int GetAllLevelCurrentState_OutLevelStreamingList_Offset;

	private static bool GetAllLevelCurrentState_bIgnoreWCTile_IsValid;

	private static FFieldAddress GetAllLevelCurrentState_bIgnoreWCTile_PropertyAddress;

	private static int GetAllLevelCurrentState_bIgnoreWCTile_Offset;

	private static bool GetAllLevelCurrentState_ReturnValue_IsValid;

	private static FFieldAddress GetAllLevelCurrentState_ReturnValue_PropertyAddress;

	private static int GetAllLevelCurrentState_ReturnValue_Offset;

	private static bool ForceLoadAllStreamingLevels_IsValid;

	private static IntPtr ForceLoadAllStreamingLevels_FunctionAddress;

	private static int ForceLoadAllStreamingLevels_ParamsSize;

	private static bool ForceLoadAllStreamingLevels_InWorldContext_IsValid;

	private static FFieldAddress ForceLoadAllStreamingLevels_InWorldContext_PropertyAddress;

	private static int ForceLoadAllStreamingLevels_InWorldContext_Offset;

	private static bool FlushAllLevelState_IsValid;

	private static IntPtr FlushAllLevelState_FunctionAddress;

	private static int FlushAllLevelState_ParamsSize;

	private static bool FlushAllLevelState_InWorldContext_IsValid;

	private static FFieldAddress FlushAllLevelState_InWorldContext_PropertyAddress;

	private static int FlushAllLevelState_InWorldContext_Offset;

	private static bool FlushAllLevelState_InExcludedLevelKeywords_IsValid;

	private static FFieldAddress FlushAllLevelState_InExcludedLevelKeywords_PropertyAddress;

	private static int FlushAllLevelState_InExcludedLevelKeywords_Offset;

	private static bool EnableStreamingSource_IsValid;

	private static IntPtr EnableStreamingSource_FunctionAddress;

	private static int EnableStreamingSource_ParamsSize;

	private static bool EnableStreamingSource_InActor_IsValid;

	private static FFieldAddress EnableStreamingSource_InActor_PropertyAddress;

	private static int EnableStreamingSource_InActor_Offset;

	private static bool DisableStreamingSource_IsValid;

	private static IntPtr DisableStreamingSource_FunctionAddress;

	private static int DisableStreamingSource_ParamsSize;

	private static bool DisableStreamingSource_InActor_IsValid;

	private static FFieldAddress DisableStreamingSource_InActor_PropertyAddress;

	private static int DisableStreamingSource_InActor_Offset;

	private static bool DestroyGSWCWorldStreamingSources_IsValid;

	private static IntPtr DestroyGSWCWorldStreamingSources_FunctionAddress;

	private static int DestroyGSWCWorldStreamingSources_ParamsSize;

	private static bool DestroyGSWCWorldStreamingSources_WorldContext_IsValid;

	private static FFieldAddress DestroyGSWCWorldStreamingSources_WorldContext_PropertyAddress;

	private static int DestroyGSWCWorldStreamingSources_WorldContext_Offset;

	private static bool CheckLevelState_IsValid;

	private static IntPtr CheckLevelState_FunctionAddress;

	private static int CheckLevelState_ParamsSize;

	private static bool CheckLevelState_InWorldContext_IsValid;

	private static FFieldAddress CheckLevelState_InWorldContext_PropertyAddress;

	private static int CheckLevelState_InWorldContext_Offset;

	private static bool CheckLevelState_InTargetLevelName_IsValid;

	private static FFieldAddress CheckLevelState_InTargetLevelName_PropertyAddress;

	private static int CheckLevelState_InTargetLevelName_Offset;

	private static bool CacheWorldCompositionStreamingLayers_IsValid;

	private static IntPtr CacheWorldCompositionStreamingLayers_FunctionAddress;

	private static int CacheWorldCompositionStreamingLayers_ParamsSize;

	private static bool CacheWorldCompositionStreamingLayers_InWorldContext_IsValid;

	private static FFieldAddress CacheWorldCompositionStreamingLayers_InWorldContext_PropertyAddress;

	private static int CacheWorldCompositionStreamingLayers_InWorldContext_Offset;

	private static bool CacheWorldCompositionLevelNames_IsValid;

	private static IntPtr CacheWorldCompositionLevelNames_FunctionAddress;

	private static int CacheWorldCompositionLevelNames_ParamsSize;

	private static bool CacheWorldCompositionLevelNames_InWorldContext_IsValid;

	private static FFieldAddress CacheWorldCompositionLevelNames_InWorldContext_PropertyAddress;

	private static int CacheWorldCompositionLevelNames_InWorldContext_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:UpdateStreamingState")]
	public unsafe static void UpdateStreamingState(UObject WorldContext, bool bBlockTillComplete = false)
	{
		if (!UpdateStreamingState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:UpdateStreamingState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateStreamingState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateStreamingState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UpdateStreamingState_WorldContext_Offset), 0, UpdateStreamingState_WorldContext_PropertyAddress.Address, WorldContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateStreamingState_bBlockTillComplete_Offset), 0, UpdateStreamingState_bBlockTillComplete_PropertyAddress.Address, bBlockTillComplete);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateStreamingState_FunctionAddress, intPtr, UpdateStreamingState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:UnregisterFromStreamingSource")]
	public unsafe static void UnregisterFromStreamingSource(AActor InActor)
	{
		if (!UnregisterFromStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:UnregisterFromStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterFromStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterFromStreamingSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UnregisterFromStreamingSource_InActor_Offset), 0, UnregisterFromStreamingSource_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnregisterFromStreamingSource_FunctionAddress, intPtr, UnregisterFromStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:SpawnStreamingSource")]
	public unsafe static void SpawnStreamingSource(UObject WorldContext, FVector SpawnLocation)
	{
		if (!SpawnStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:SpawnStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnStreamingSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnStreamingSource_WorldContext_Offset), 0, SpawnStreamingSource_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnStreamingSource_SpawnLocation_Offset), 0, SpawnStreamingSource_SpawnLocation_PropertyAddress.Address, SpawnLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnStreamingSource_FunctionAddress, intPtr, SpawnStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:SetStreamingManagerViewSource")]
	public unsafe static void SetStreamingManagerViewSource(FVector ViewLocation, float Duration)
	{
		if (!SetStreamingManagerViewSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:SetStreamingManagerViewSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStreamingManagerViewSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStreamingManagerViewSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStreamingManagerViewSource_ViewLocation_Offset), 0, SetStreamingManagerViewSource_ViewLocation_PropertyAddress.Address, ViewLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStreamingManagerViewSource_Duration_Offset), 0, SetStreamingManagerViewSource_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStreamingManagerViewSource_FunctionAddress, intPtr, SetStreamingManagerViewSource_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:SetLevelsStateByNames")]
	public unsafe static List<FGSSetLevelStateFailedInfo> SetLevelsStateByNames(UObject InWorldContext, List<string> InTargetLevelNames, EGSLevelState InTargetState, int InOperationID, bool bBlockOnLoad = false)
	{
		if (!SetLevelsStateByNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:SetLevelsStateByNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelsStateByNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelsStateByNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetLevelsStateByNames_InWorldContext_Offset), 0, SetLevelsStateByNames_InWorldContext_PropertyAddress.Address, InWorldContext);
		new TArrayCopyMarshaler<string>(1, SetLevelsStateByNames_InTargetLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetLevelsStateByNames_InTargetLevelNames_Offset), InTargetLevelNames);
		EnumMarshaler<EGSLevelState>.ToNative(IntPtr.Add(intPtr, SetLevelsStateByNames_InTargetState_Offset), 0, SetLevelsStateByNames_InTargetState_PropertyAddress.Address, InTargetState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLevelsStateByNames_InOperationID_Offset), 0, SetLevelsStateByNames_InOperationID_PropertyAddress.Address, InOperationID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsStateByNames_bBlockOnLoad_Offset), 0, SetLevelsStateByNames_bBlockOnLoad_PropertyAddress.Address, bBlockOnLoad);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLevelsStateByNames_FunctionAddress, intPtr, SetLevelsStateByNames_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelsStateByNames_InTargetLevelNames_PropertyAddress.Address, intPtr);
		List<FGSSetLevelStateFailedInfo> result = new TArrayCopyMarshaler<FGSSetLevelStateFailedInfo>(1, SetLevelsStateByNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSSetLevelStateFailedInfo, FGSSetLevelStateFailedInfo>.FromNative, CachedMarshalingDelegates<FGSSetLevelStateFailedInfo, FGSSetLevelStateFailedInfo>.ToNative).FromNative(IntPtr.Add(intPtr, SetLevelsStateByNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SetLevelsStateByNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:SetLevelsState")]
	public unsafe static List<FGSSetLevelStateFailedInfo> SetLevelsState(UObject InWorldContext, string InTargetLevelNameOrKeyword, EGSLevelState InTargetState, int InOperationID = -1, bool bKeywordMatch = true, bool bBlockOnLoad = false)
	{
		if (!SetLevelsState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:SetLevelsState");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelsState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelsState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetLevelsState_InWorldContext_Offset), 0, SetLevelsState_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsState_InTargetLevelNameOrKeyword_Offset), 0, SetLevelsState_InTargetLevelNameOrKeyword_PropertyAddress.Address, InTargetLevelNameOrKeyword);
		EnumMarshaler<EGSLevelState>.ToNative(IntPtr.Add(intPtr, SetLevelsState_InTargetState_Offset), 0, SetLevelsState_InTargetState_PropertyAddress.Address, InTargetState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLevelsState_InOperationID_Offset), 0, SetLevelsState_InOperationID_PropertyAddress.Address, InOperationID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsState_bKeywordMatch_Offset), 0, SetLevelsState_bKeywordMatch_PropertyAddress.Address, bKeywordMatch);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsState_bBlockOnLoad_Offset), 0, SetLevelsState_bBlockOnLoad_PropertyAddress.Address, bBlockOnLoad);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLevelsState_FunctionAddress, intPtr, SetLevelsState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelsState_InTargetLevelNameOrKeyword_PropertyAddress.Address, intPtr);
		List<FGSSetLevelStateFailedInfo> result = new TArrayCopyMarshaler<FGSSetLevelStateFailedInfo>(1, SetLevelsState_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSSetLevelStateFailedInfo, FGSSetLevelStateFailedInfo>.FromNative, CachedMarshalingDelegates<FGSSetLevelStateFailedInfo, FGSSetLevelStateFailedInfo>.ToNative).FromNative(IntPtr.Add(intPtr, SetLevelsState_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SetLevelsState_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:RegisterAsStreamingSource")]
	public unsafe static void RegisterAsStreamingSource(AActor InActor)
	{
		if (!RegisterAsStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:RegisterAsStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterAsStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterAsStreamingSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RegisterAsStreamingSource_InActor_Offset), 0, RegisterAsStreamingSource_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterAsStreamingSource_FunctionAddress, intPtr, RegisterAsStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:QueryProcessingStreamingLevels")]
	public unsafe static Dictionary<string, string> QueryProcessingStreamingLevels(UObject InWorldContext)
	{
		if (!QueryProcessingStreamingLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:QueryProcessingStreamingLevels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryProcessingStreamingLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryProcessingStreamingLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, QueryProcessingStreamingLevels_InWorldContext_Offset), 0, QueryProcessingStreamingLevels_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryProcessingStreamingLevels_FunctionAddress, intPtr, QueryProcessingStreamingLevels_ParamsSize);
		Dictionary<string, string> result = new TMapCopyMarshaler<string, string>(1, QueryProcessingStreamingLevels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, QueryProcessingStreamingLevels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(QueryProcessingStreamingLevels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:PauseDistanceStreaming")]
	public unsafe static void PauseDistanceStreaming(UObject InWorldContext, List<string> InExcludedLevelKeywords)
	{
		if (!PauseDistanceStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:PauseDistanceStreaming");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseDistanceStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseDistanceStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PauseDistanceStreaming_InWorldContext_Offset), 0, PauseDistanceStreaming_InWorldContext_PropertyAddress.Address, InWorldContext);
		new TArrayCopyMarshaler<string>(1, PauseDistanceStreaming_InExcludedLevelKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, PauseDistanceStreaming_InExcludedLevelKeywords_Offset), InExcludedLevelKeywords);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PauseDistanceStreaming_FunctionAddress, intPtr, PauseDistanceStreaming_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PauseDistanceStreaming_InExcludedLevelKeywords_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:ModifyStreamingDistanceScaleByStreamingLayer")]
	public unsafe static void ModifyStreamingDistanceScaleByStreamingLayer(UObject InWorldContext, string InTargetLayerName, int InTargetLODIndex = -1, float InTargetScaleFactor = 1f, bool bBlockTillStreamingCompleted = false)
	{
		if (!ModifyStreamingDistanceScaleByStreamingLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:ModifyStreamingDistanceScaleByStreamingLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyStreamingDistanceScaleByStreamingLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyStreamingDistanceScaleByStreamingLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_Offset), 0, ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_Offset), 0, ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_PropertyAddress.Address, InTargetLayerName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_Offset), 0, ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_PropertyAddress.Address, InTargetLODIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_Offset), 0, ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_PropertyAddress.Address, InTargetScaleFactor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_Offset), 0, ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_PropertyAddress.Address, bBlockTillStreamingCompleted);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, intPtr, ModifyStreamingDistanceScaleByStreamingLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:IsLevelStreamable")]
	public unsafe static bool IsLevelStreamable(UObject InWorldContext, string InTargetLevelName)
	{
		if (!IsLevelStreamable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:IsLevelStreamable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLevelStreamable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLevelStreamable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsLevelStreamable_InWorldContext_Offset), 0, IsLevelStreamable_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsLevelStreamable_InTargetLevelName_Offset), 0, IsLevelStreamable_InTargetLevelName_PropertyAddress.Address, InTargetLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLevelStreamable_FunctionAddress, intPtr, IsLevelStreamable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsLevelStreamable_InTargetLevelName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLevelStreamable_ReturnValue_Offset), 0, IsLevelStreamable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:GetProcessingStreamingLevelNum")]
	public unsafe static int GetProcessingStreamingLevelNum(UObject InWorldContext)
	{
		if (!GetProcessingStreamingLevelNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:GetProcessingStreamingLevelNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProcessingStreamingLevelNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProcessingStreamingLevelNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetProcessingStreamingLevelNum_InWorldContext_Offset), 0, GetProcessingStreamingLevelNum_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProcessingStreamingLevelNum_FunctionAddress, intPtr, GetProcessingStreamingLevelNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetProcessingStreamingLevelNum_ReturnValue_Offset), 0, GetProcessingStreamingLevelNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:GetLevelNamesByKeyword")]
	public unsafe static List<string> GetLevelNamesByKeyword(UObject InWorldContext, string InLevelNameKeyword)
	{
		if (!GetLevelNamesByKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:GetLevelNamesByKeyword");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelNamesByKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelNamesByKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelNamesByKeyword_InWorldContext_Offset), 0, GetLevelNamesByKeyword_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLevelNamesByKeyword_InLevelNameKeyword_Offset), 0, GetLevelNamesByKeyword_InLevelNameKeyword_PropertyAddress.Address, InLevelNameKeyword);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelNamesByKeyword_FunctionAddress, intPtr, GetLevelNamesByKeyword_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelNamesByKeyword_InLevelNameKeyword_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetLevelNamesByKeyword_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelNamesByKeyword_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelNamesByKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:GetLevelNames")]
	public unsafe static int GetLevelNames(UObject InWorldContext, out List<string> OutLevelNames)
	{
		if (!GetLevelNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:GetLevelNames");
			OutLevelNames = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelNames_InWorldContext_Offset), 0, GetLevelNames_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelNames_FunctionAddress, intPtr, GetLevelNames_ParamsSize);
		OutLevelNames = new TArrayCopyMarshaler<string>(1, GetLevelNames_OutLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelNames_OutLevelNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelNames_OutLevelNames_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLevelNames_ReturnValue_Offset), 0, GetLevelNames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:GetLevelCurrentStateAndIsConsideredUpdate")]
	public unsafe static void GetLevelCurrentStateAndIsConsideredUpdate(UObject InWorldContext, List<string> LevelNames, out Dictionary<string, byte> OutLevelStreamingList, out HashSet<string> OutCosideredUpdateSet)
	{
		if (!GetLevelCurrentStateAndIsConsideredUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:GetLevelCurrentStateAndIsConsideredUpdate");
			OutLevelStreamingList = null;
			OutCosideredUpdateSet = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelCurrentStateAndIsConsideredUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelCurrentStateAndIsConsideredUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_Offset), 0, GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_PropertyAddress.Address, InWorldContext);
		new TArrayCopyMarshaler<string>(1, GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_Offset), LevelNames);
		NativeReflection.InitializeValue_InContainer(GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, intPtr, GetLevelCurrentStateAndIsConsideredUpdate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_PropertyAddress.Address, intPtr);
		OutLevelStreamingList = new TMapCopyMarshaler<string, byte>(1, GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_PropertyAddress.Address, intPtr);
		OutCosideredUpdateSet = new TSetCopyMarshaler<string>(1, GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:GetAllLevelCurrentState")]
	public unsafe static int GetAllLevelCurrentState(UObject InWorldContext, out Dictionary<string, byte> OutLevelStreamingList, bool bIgnoreWCTile = true)
	{
		if (!GetAllLevelCurrentState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:GetAllLevelCurrentState");
			OutLevelStreamingList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllLevelCurrentState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllLevelCurrentState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllLevelCurrentState_InWorldContext_Offset), 0, GetAllLevelCurrentState_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InitializeValue_InContainer(GetAllLevelCurrentState_OutLevelStreamingList_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllLevelCurrentState_bIgnoreWCTile_Offset), 0, GetAllLevelCurrentState_bIgnoreWCTile_PropertyAddress.Address, bIgnoreWCTile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllLevelCurrentState_FunctionAddress, intPtr, GetAllLevelCurrentState_ParamsSize);
		OutLevelStreamingList = new TMapCopyMarshaler<string, byte>(1, GetAllLevelCurrentState_OutLevelStreamingList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllLevelCurrentState_OutLevelStreamingList_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllLevelCurrentState_OutLevelStreamingList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAllLevelCurrentState_ReturnValue_Offset), 0, GetAllLevelCurrentState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:ForceLoadAllStreamingLevels")]
	public unsafe static void ForceLoadAllStreamingLevels(UObject InWorldContext)
	{
		if (!ForceLoadAllStreamingLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:ForceLoadAllStreamingLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceLoadAllStreamingLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceLoadAllStreamingLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ForceLoadAllStreamingLevels_InWorldContext_Offset), 0, ForceLoadAllStreamingLevels_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceLoadAllStreamingLevels_FunctionAddress, intPtr, ForceLoadAllStreamingLevels_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:FlushAllLevelState")]
	public unsafe static void FlushAllLevelState(UObject InWorldContext, List<string> InExcludedLevelKeywords)
	{
		if (!FlushAllLevelState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:FlushAllLevelState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushAllLevelState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushAllLevelState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FlushAllLevelState_InWorldContext_Offset), 0, FlushAllLevelState_InWorldContext_PropertyAddress.Address, InWorldContext);
		new TArrayCopyMarshaler<string>(1, FlushAllLevelState_InExcludedLevelKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, FlushAllLevelState_InExcludedLevelKeywords_Offset), InExcludedLevelKeywords);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FlushAllLevelState_FunctionAddress, intPtr, FlushAllLevelState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FlushAllLevelState_InExcludedLevelKeywords_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:EnableStreamingSource")]
	public unsafe static void EnableStreamingSource(AActor InActor)
	{
		if (!EnableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:EnableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableStreamingSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EnableStreamingSource_InActor_Offset), 0, EnableStreamingSource_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableStreamingSource_FunctionAddress, intPtr, EnableStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:DisableStreamingSource")]
	public unsafe static void DisableStreamingSource(AActor InActor)
	{
		if (!DisableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:DisableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableStreamingSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DisableStreamingSource_InActor_Offset), 0, DisableStreamingSource_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableStreamingSource_FunctionAddress, intPtr, DisableStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:DestroyGSWCWorldStreamingSources")]
	public unsafe static void DestroyGSWCWorldStreamingSources(UObject WorldContext)
	{
		if (!DestroyGSWCWorldStreamingSources_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:DestroyGSWCWorldStreamingSources");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyGSWCWorldStreamingSources_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyGSWCWorldStreamingSources_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DestroyGSWCWorldStreamingSources_WorldContext_Offset), 0, DestroyGSWCWorldStreamingSources_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyGSWCWorldStreamingSources_FunctionAddress, intPtr, DestroyGSWCWorldStreamingSources_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:CheckLevelState")]
	public unsafe static void CheckLevelState(UObject InWorldContext, string InTargetLevelName)
	{
		if (!CheckLevelState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:CheckLevelState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckLevelState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckLevelState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CheckLevelState_InWorldContext_Offset), 0, CheckLevelState_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckLevelState_InTargetLevelName_Offset), 0, CheckLevelState_InTargetLevelName_PropertyAddress.Address, InTargetLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckLevelState_FunctionAddress, intPtr, CheckLevelState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckLevelState_InTargetLevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionStreamingLayers")]
	public unsafe static void CacheWorldCompositionStreamingLayers(UObject InWorldContext)
	{
		if (!CacheWorldCompositionStreamingLayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionStreamingLayers");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheWorldCompositionStreamingLayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheWorldCompositionStreamingLayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CacheWorldCompositionStreamingLayers_InWorldContext_Offset), 0, CacheWorldCompositionStreamingLayers_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CacheWorldCompositionStreamingLayers_FunctionAddress, intPtr, CacheWorldCompositionStreamingLayers_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionLevelNames")]
	public unsafe static void CacheWorldCompositionLevelNames(UObject InWorldContext)
	{
		if (!CacheWorldCompositionLevelNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionLevelNames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheWorldCompositionLevelNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheWorldCompositionLevelNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CacheWorldCompositionLevelNames_InWorldContext_Offset), 0, CacheWorldCompositionLevelNames_InWorldContext_PropertyAddress.Address, InWorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CacheWorldCompositionLevelNames_FunctionAddress, intPtr, CacheWorldCompositionLevelNames_ParamsSize);
	}

	static UBGUWCStreamingFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUWCStreamingFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUWCStreamingFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUWCStreamingFuncLib");
		UpdateStreamingState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateStreamingState");
		UpdateStreamingState_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateStreamingState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateStreamingState_WorldContext_PropertyAddress, UpdateStreamingState_FunctionAddress, "WorldContext");
		UpdateStreamingState_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(UpdateStreamingState_FunctionAddress, "WorldContext");
		UpdateStreamingState_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateStreamingState_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateStreamingState_bBlockTillComplete_PropertyAddress, UpdateStreamingState_FunctionAddress, "bBlockTillComplete");
		UpdateStreamingState_bBlockTillComplete_Offset = NativeReflectionCached.GetPropertyOffset(UpdateStreamingState_FunctionAddress, "bBlockTillComplete");
		UpdateStreamingState_bBlockTillComplete_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateStreamingState_FunctionAddress, "bBlockTillComplete", Classes.FBoolProperty);
		UpdateStreamingState_IsValid = UpdateStreamingState_FunctionAddress != IntPtr.Zero && UpdateStreamingState_WorldContext_IsValid && UpdateStreamingState_bBlockTillComplete_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:UpdateStreamingState", UpdateStreamingState_IsValid);
		UnregisterFromStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterFromStreamingSource");
		UnregisterFromStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterFromStreamingSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterFromStreamingSource_InActor_PropertyAddress, UnregisterFromStreamingSource_FunctionAddress, "InActor");
		UnregisterFromStreamingSource_InActor_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterFromStreamingSource_FunctionAddress, "InActor");
		UnregisterFromStreamingSource_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterFromStreamingSource_FunctionAddress, "InActor", Classes.FObjectProperty);
		UnregisterFromStreamingSource_IsValid = UnregisterFromStreamingSource_FunctionAddress != IntPtr.Zero && UnregisterFromStreamingSource_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:UnregisterFromStreamingSource", UnregisterFromStreamingSource_IsValid);
		SpawnStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnStreamingSource");
		SpawnStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnStreamingSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnStreamingSource_WorldContext_PropertyAddress, SpawnStreamingSource_FunctionAddress, "WorldContext");
		SpawnStreamingSource_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SpawnStreamingSource_FunctionAddress, "WorldContext");
		SpawnStreamingSource_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnStreamingSource_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnStreamingSource_SpawnLocation_PropertyAddress, SpawnStreamingSource_FunctionAddress, "SpawnLocation");
		SpawnStreamingSource_SpawnLocation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnStreamingSource_FunctionAddress, "SpawnLocation");
		SpawnStreamingSource_SpawnLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnStreamingSource_FunctionAddress, "SpawnLocation", Classes.FStructProperty);
		SpawnStreamingSource_IsValid = SpawnStreamingSource_FunctionAddress != IntPtr.Zero && SpawnStreamingSource_WorldContext_IsValid && SpawnStreamingSource_SpawnLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:SpawnStreamingSource", SpawnStreamingSource_IsValid);
		SetStreamingManagerViewSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStreamingManagerViewSource");
		SetStreamingManagerViewSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStreamingManagerViewSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStreamingManagerViewSource_ViewLocation_PropertyAddress, SetStreamingManagerViewSource_FunctionAddress, "ViewLocation");
		SetStreamingManagerViewSource_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetStreamingManagerViewSource_FunctionAddress, "ViewLocation");
		SetStreamingManagerViewSource_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStreamingManagerViewSource_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStreamingManagerViewSource_Duration_PropertyAddress, SetStreamingManagerViewSource_FunctionAddress, "Duration");
		SetStreamingManagerViewSource_Duration_Offset = NativeReflectionCached.GetPropertyOffset(SetStreamingManagerViewSource_FunctionAddress, "Duration");
		SetStreamingManagerViewSource_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStreamingManagerViewSource_FunctionAddress, "Duration", Classes.FFloatProperty);
		SetStreamingManagerViewSource_IsValid = SetStreamingManagerViewSource_FunctionAddress != IntPtr.Zero && SetStreamingManagerViewSource_ViewLocation_IsValid && SetStreamingManagerViewSource_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:SetStreamingManagerViewSource", SetStreamingManagerViewSource_IsValid);
		SetLevelsStateByNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLevelsStateByNames");
		SetLevelsStateByNames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelsStateByNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_InWorldContext_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "InWorldContext");
		SetLevelsStateByNames_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "InWorldContext");
		SetLevelsStateByNames_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_InTargetLevelNames_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "InTargetLevelNames");
		SetLevelsStateByNames_InTargetLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "InTargetLevelNames");
		SetLevelsStateByNames_InTargetLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "InTargetLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_InTargetState_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "InTargetState");
		SetLevelsStateByNames_InTargetState_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "InTargetState");
		SetLevelsStateByNames_InTargetState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "InTargetState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_InOperationID_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "InOperationID");
		SetLevelsStateByNames_InOperationID_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "InOperationID");
		SetLevelsStateByNames_InOperationID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "InOperationID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_bBlockOnLoad_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "bBlockOnLoad");
		SetLevelsStateByNames_bBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "bBlockOnLoad");
		SetLevelsStateByNames_bBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "bBlockOnLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsStateByNames_ReturnValue_PropertyAddress, SetLevelsStateByNames_FunctionAddress, "ReturnValue");
		SetLevelsStateByNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsStateByNames_FunctionAddress, "ReturnValue");
		SetLevelsStateByNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsStateByNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SetLevelsStateByNames_IsValid = SetLevelsStateByNames_FunctionAddress != IntPtr.Zero && SetLevelsStateByNames_InWorldContext_IsValid && SetLevelsStateByNames_InTargetLevelNames_IsValid && SetLevelsStateByNames_InTargetState_IsValid && SetLevelsStateByNames_InOperationID_IsValid && SetLevelsStateByNames_bBlockOnLoad_IsValid && SetLevelsStateByNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:SetLevelsStateByNames", SetLevelsStateByNames_IsValid);
		SetLevelsState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLevelsState");
		SetLevelsState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelsState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_InWorldContext_PropertyAddress, SetLevelsState_FunctionAddress, "InWorldContext");
		SetLevelsState_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "InWorldContext");
		SetLevelsState_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_InTargetLevelNameOrKeyword_PropertyAddress, SetLevelsState_FunctionAddress, "InTargetLevelNameOrKeyword");
		SetLevelsState_InTargetLevelNameOrKeyword_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "InTargetLevelNameOrKeyword");
		SetLevelsState_InTargetLevelNameOrKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "InTargetLevelNameOrKeyword", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_InTargetState_PropertyAddress, SetLevelsState_FunctionAddress, "InTargetState");
		SetLevelsState_InTargetState_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "InTargetState");
		SetLevelsState_InTargetState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "InTargetState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_InOperationID_PropertyAddress, SetLevelsState_FunctionAddress, "InOperationID");
		SetLevelsState_InOperationID_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "InOperationID");
		SetLevelsState_InOperationID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "InOperationID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_bKeywordMatch_PropertyAddress, SetLevelsState_FunctionAddress, "bKeywordMatch");
		SetLevelsState_bKeywordMatch_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "bKeywordMatch");
		SetLevelsState_bKeywordMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "bKeywordMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_bBlockOnLoad_PropertyAddress, SetLevelsState_FunctionAddress, "bBlockOnLoad");
		SetLevelsState_bBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "bBlockOnLoad");
		SetLevelsState_bBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "bBlockOnLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsState_ReturnValue_PropertyAddress, SetLevelsState_FunctionAddress, "ReturnValue");
		SetLevelsState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsState_FunctionAddress, "ReturnValue");
		SetLevelsState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsState_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SetLevelsState_IsValid = SetLevelsState_FunctionAddress != IntPtr.Zero && SetLevelsState_InWorldContext_IsValid && SetLevelsState_InTargetLevelNameOrKeyword_IsValid && SetLevelsState_InTargetState_IsValid && SetLevelsState_InOperationID_IsValid && SetLevelsState_bKeywordMatch_IsValid && SetLevelsState_bBlockOnLoad_IsValid && SetLevelsState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:SetLevelsState", SetLevelsState_IsValid);
		RegisterAsStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterAsStreamingSource");
		RegisterAsStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterAsStreamingSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterAsStreamingSource_InActor_PropertyAddress, RegisterAsStreamingSource_FunctionAddress, "InActor");
		RegisterAsStreamingSource_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RegisterAsStreamingSource_FunctionAddress, "InActor");
		RegisterAsStreamingSource_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterAsStreamingSource_FunctionAddress, "InActor", Classes.FObjectProperty);
		RegisterAsStreamingSource_IsValid = RegisterAsStreamingSource_FunctionAddress != IntPtr.Zero && RegisterAsStreamingSource_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:RegisterAsStreamingSource", RegisterAsStreamingSource_IsValid);
		QueryProcessingStreamingLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryProcessingStreamingLevels");
		QueryProcessingStreamingLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryProcessingStreamingLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryProcessingStreamingLevels_InWorldContext_PropertyAddress, QueryProcessingStreamingLevels_FunctionAddress, "InWorldContext");
		QueryProcessingStreamingLevels_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(QueryProcessingStreamingLevels_FunctionAddress, "InWorldContext");
		QueryProcessingStreamingLevels_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryProcessingStreamingLevels_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryProcessingStreamingLevels_ReturnValue_PropertyAddress, QueryProcessingStreamingLevels_FunctionAddress, "ReturnValue");
		QueryProcessingStreamingLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryProcessingStreamingLevels_FunctionAddress, "ReturnValue");
		QueryProcessingStreamingLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryProcessingStreamingLevels_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		QueryProcessingStreamingLevels_IsValid = QueryProcessingStreamingLevels_FunctionAddress != IntPtr.Zero && QueryProcessingStreamingLevels_InWorldContext_IsValid && QueryProcessingStreamingLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:QueryProcessingStreamingLevels", QueryProcessingStreamingLevels_IsValid);
		PauseDistanceStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PauseDistanceStreaming");
		PauseDistanceStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseDistanceStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseDistanceStreaming_InWorldContext_PropertyAddress, PauseDistanceStreaming_FunctionAddress, "InWorldContext");
		PauseDistanceStreaming_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(PauseDistanceStreaming_FunctionAddress, "InWorldContext");
		PauseDistanceStreaming_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseDistanceStreaming_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseDistanceStreaming_InExcludedLevelKeywords_PropertyAddress, PauseDistanceStreaming_FunctionAddress, "InExcludedLevelKeywords");
		PauseDistanceStreaming_InExcludedLevelKeywords_Offset = NativeReflectionCached.GetPropertyOffset(PauseDistanceStreaming_FunctionAddress, "InExcludedLevelKeywords");
		PauseDistanceStreaming_InExcludedLevelKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseDistanceStreaming_FunctionAddress, "InExcludedLevelKeywords", Classes.FArrayProperty);
		PauseDistanceStreaming_IsValid = PauseDistanceStreaming_FunctionAddress != IntPtr.Zero && PauseDistanceStreaming_InWorldContext_IsValid && PauseDistanceStreaming_InExcludedLevelKeywords_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:PauseDistanceStreaming", PauseDistanceStreaming_IsValid);
		ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyStreamingDistanceScaleByStreamingLayer");
		ModifyStreamingDistanceScaleByStreamingLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_PropertyAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InWorldContext");
		ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InWorldContext");
		ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_PropertyAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLayerName");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLayerName");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLayerName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_PropertyAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLODIndex");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLODIndex");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetLODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_PropertyAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetScaleFactor");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetScaleFactor");
		ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "InTargetScaleFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_PropertyAddress, ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "bBlockTillStreamingCompleted");
		ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "bBlockTillStreamingCompleted");
		ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress, "bBlockTillStreamingCompleted", Classes.FBoolProperty);
		ModifyStreamingDistanceScaleByStreamingLayer_IsValid = ModifyStreamingDistanceScaleByStreamingLayer_FunctionAddress != IntPtr.Zero && ModifyStreamingDistanceScaleByStreamingLayer_InWorldContext_IsValid && ModifyStreamingDistanceScaleByStreamingLayer_InTargetLayerName_IsValid && ModifyStreamingDistanceScaleByStreamingLayer_InTargetLODIndex_IsValid && ModifyStreamingDistanceScaleByStreamingLayer_InTargetScaleFactor_IsValid && ModifyStreamingDistanceScaleByStreamingLayer_bBlockTillStreamingCompleted_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:ModifyStreamingDistanceScaleByStreamingLayer", ModifyStreamingDistanceScaleByStreamingLayer_IsValid);
		IsLevelStreamable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLevelStreamable");
		IsLevelStreamable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLevelStreamable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLevelStreamable_InWorldContext_PropertyAddress, IsLevelStreamable_FunctionAddress, "InWorldContext");
		IsLevelStreamable_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelStreamable_FunctionAddress, "InWorldContext");
		IsLevelStreamable_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelStreamable_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLevelStreamable_InTargetLevelName_PropertyAddress, IsLevelStreamable_FunctionAddress, "InTargetLevelName");
		IsLevelStreamable_InTargetLevelName_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelStreamable_FunctionAddress, "InTargetLevelName");
		IsLevelStreamable_InTargetLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelStreamable_FunctionAddress, "InTargetLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLevelStreamable_ReturnValue_PropertyAddress, IsLevelStreamable_FunctionAddress, "ReturnValue");
		IsLevelStreamable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelStreamable_FunctionAddress, "ReturnValue");
		IsLevelStreamable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelStreamable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLevelStreamable_IsValid = IsLevelStreamable_FunctionAddress != IntPtr.Zero && IsLevelStreamable_InWorldContext_IsValid && IsLevelStreamable_InTargetLevelName_IsValid && IsLevelStreamable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:IsLevelStreamable", IsLevelStreamable_IsValid);
		GetProcessingStreamingLevelNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProcessingStreamingLevelNum");
		GetProcessingStreamingLevelNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProcessingStreamingLevelNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProcessingStreamingLevelNum_InWorldContext_PropertyAddress, GetProcessingStreamingLevelNum_FunctionAddress, "InWorldContext");
		GetProcessingStreamingLevelNum_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetProcessingStreamingLevelNum_FunctionAddress, "InWorldContext");
		GetProcessingStreamingLevelNum_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProcessingStreamingLevelNum_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProcessingStreamingLevelNum_ReturnValue_PropertyAddress, GetProcessingStreamingLevelNum_FunctionAddress, "ReturnValue");
		GetProcessingStreamingLevelNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProcessingStreamingLevelNum_FunctionAddress, "ReturnValue");
		GetProcessingStreamingLevelNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProcessingStreamingLevelNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetProcessingStreamingLevelNum_IsValid = GetProcessingStreamingLevelNum_FunctionAddress != IntPtr.Zero && GetProcessingStreamingLevelNum_InWorldContext_IsValid && GetProcessingStreamingLevelNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:GetProcessingStreamingLevelNum", GetProcessingStreamingLevelNum_IsValid);
		GetLevelNamesByKeyword_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelNamesByKeyword");
		GetLevelNamesByKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelNamesByKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNamesByKeyword_InWorldContext_PropertyAddress, GetLevelNamesByKeyword_FunctionAddress, "InWorldContext");
		GetLevelNamesByKeyword_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNamesByKeyword_FunctionAddress, "InWorldContext");
		GetLevelNamesByKeyword_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNamesByKeyword_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNamesByKeyword_InLevelNameKeyword_PropertyAddress, GetLevelNamesByKeyword_FunctionAddress, "InLevelNameKeyword");
		GetLevelNamesByKeyword_InLevelNameKeyword_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNamesByKeyword_FunctionAddress, "InLevelNameKeyword");
		GetLevelNamesByKeyword_InLevelNameKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNamesByKeyword_FunctionAddress, "InLevelNameKeyword", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNamesByKeyword_ReturnValue_PropertyAddress, GetLevelNamesByKeyword_FunctionAddress, "ReturnValue");
		GetLevelNamesByKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNamesByKeyword_FunctionAddress, "ReturnValue");
		GetLevelNamesByKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNamesByKeyword_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevelNamesByKeyword_IsValid = GetLevelNamesByKeyword_FunctionAddress != IntPtr.Zero && GetLevelNamesByKeyword_InWorldContext_IsValid && GetLevelNamesByKeyword_InLevelNameKeyword_IsValid && GetLevelNamesByKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:GetLevelNamesByKeyword", GetLevelNamesByKeyword_IsValid);
		GetLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelNames");
		GetLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNames_InWorldContext_PropertyAddress, GetLevelNames_FunctionAddress, "InWorldContext");
		GetLevelNames_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNames_FunctionAddress, "InWorldContext");
		GetLevelNames_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNames_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNames_OutLevelNames_PropertyAddress, GetLevelNames_FunctionAddress, "OutLevelNames");
		GetLevelNames_OutLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNames_FunctionAddress, "OutLevelNames");
		GetLevelNames_OutLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNames_FunctionAddress, "OutLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNames_ReturnValue_PropertyAddress, GetLevelNames_FunctionAddress, "ReturnValue");
		GetLevelNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNames_FunctionAddress, "ReturnValue");
		GetLevelNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLevelNames_IsValid = GetLevelNames_FunctionAddress != IntPtr.Zero && GetLevelNames_InWorldContext_IsValid && GetLevelNames_OutLevelNames_IsValid && GetLevelNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:GetLevelNames", GetLevelNames_IsValid);
		GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelCurrentStateAndIsConsideredUpdate");
		GetLevelCurrentStateAndIsConsideredUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_PropertyAddress, GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "InWorldContext");
		GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "InWorldContext");
		GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_PropertyAddress, GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "LevelNames");
		GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "LevelNames");
		GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "LevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_PropertyAddress, GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutLevelStreamingList");
		GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutLevelStreamingList");
		GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutLevelStreamingList", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_PropertyAddress, GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutCosideredUpdateSet");
		GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutCosideredUpdateSet");
		GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress, "OutCosideredUpdateSet", Classes.FSetProperty);
		GetLevelCurrentStateAndIsConsideredUpdate_IsValid = GetLevelCurrentStateAndIsConsideredUpdate_FunctionAddress != IntPtr.Zero && GetLevelCurrentStateAndIsConsideredUpdate_InWorldContext_IsValid && GetLevelCurrentStateAndIsConsideredUpdate_LevelNames_IsValid && GetLevelCurrentStateAndIsConsideredUpdate_OutLevelStreamingList_IsValid && GetLevelCurrentStateAndIsConsideredUpdate_OutCosideredUpdateSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:GetLevelCurrentStateAndIsConsideredUpdate", GetLevelCurrentStateAndIsConsideredUpdate_IsValid);
		GetAllLevelCurrentState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllLevelCurrentState");
		GetAllLevelCurrentState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllLevelCurrentState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelCurrentState_InWorldContext_PropertyAddress, GetAllLevelCurrentState_FunctionAddress, "InWorldContext");
		GetAllLevelCurrentState_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelCurrentState_FunctionAddress, "InWorldContext");
		GetAllLevelCurrentState_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelCurrentState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelCurrentState_OutLevelStreamingList_PropertyAddress, GetAllLevelCurrentState_FunctionAddress, "OutLevelStreamingList");
		GetAllLevelCurrentState_OutLevelStreamingList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelCurrentState_FunctionAddress, "OutLevelStreamingList");
		GetAllLevelCurrentState_OutLevelStreamingList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelCurrentState_FunctionAddress, "OutLevelStreamingList", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelCurrentState_bIgnoreWCTile_PropertyAddress, GetAllLevelCurrentState_FunctionAddress, "bIgnoreWCTile");
		GetAllLevelCurrentState_bIgnoreWCTile_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelCurrentState_FunctionAddress, "bIgnoreWCTile");
		GetAllLevelCurrentState_bIgnoreWCTile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelCurrentState_FunctionAddress, "bIgnoreWCTile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelCurrentState_ReturnValue_PropertyAddress, GetAllLevelCurrentState_FunctionAddress, "ReturnValue");
		GetAllLevelCurrentState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelCurrentState_FunctionAddress, "ReturnValue");
		GetAllLevelCurrentState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelCurrentState_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAllLevelCurrentState_IsValid = GetAllLevelCurrentState_FunctionAddress != IntPtr.Zero && GetAllLevelCurrentState_InWorldContext_IsValid && GetAllLevelCurrentState_OutLevelStreamingList_IsValid && GetAllLevelCurrentState_bIgnoreWCTile_IsValid && GetAllLevelCurrentState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:GetAllLevelCurrentState", GetAllLevelCurrentState_IsValid);
		ForceLoadAllStreamingLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceLoadAllStreamingLevels");
		ForceLoadAllStreamingLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceLoadAllStreamingLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceLoadAllStreamingLevels_InWorldContext_PropertyAddress, ForceLoadAllStreamingLevels_FunctionAddress, "InWorldContext");
		ForceLoadAllStreamingLevels_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(ForceLoadAllStreamingLevels_FunctionAddress, "InWorldContext");
		ForceLoadAllStreamingLevels_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceLoadAllStreamingLevels_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		ForceLoadAllStreamingLevels_IsValid = ForceLoadAllStreamingLevels_FunctionAddress != IntPtr.Zero && ForceLoadAllStreamingLevels_InWorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:ForceLoadAllStreamingLevels", ForceLoadAllStreamingLevels_IsValid);
		FlushAllLevelState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlushAllLevelState");
		FlushAllLevelState_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushAllLevelState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FlushAllLevelState_InWorldContext_PropertyAddress, FlushAllLevelState_FunctionAddress, "InWorldContext");
		FlushAllLevelState_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(FlushAllLevelState_FunctionAddress, "InWorldContext");
		FlushAllLevelState_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(FlushAllLevelState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FlushAllLevelState_InExcludedLevelKeywords_PropertyAddress, FlushAllLevelState_FunctionAddress, "InExcludedLevelKeywords");
		FlushAllLevelState_InExcludedLevelKeywords_Offset = NativeReflectionCached.GetPropertyOffset(FlushAllLevelState_FunctionAddress, "InExcludedLevelKeywords");
		FlushAllLevelState_InExcludedLevelKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(FlushAllLevelState_FunctionAddress, "InExcludedLevelKeywords", Classes.FArrayProperty);
		FlushAllLevelState_IsValid = FlushAllLevelState_FunctionAddress != IntPtr.Zero && FlushAllLevelState_InWorldContext_IsValid && FlushAllLevelState_InExcludedLevelKeywords_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:FlushAllLevelState", FlushAllLevelState_IsValid);
		EnableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableStreamingSource");
		EnableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableStreamingSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableStreamingSource_InActor_PropertyAddress, EnableStreamingSource_FunctionAddress, "InActor");
		EnableStreamingSource_InActor_Offset = NativeReflectionCached.GetPropertyOffset(EnableStreamingSource_FunctionAddress, "InActor");
		EnableStreamingSource_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableStreamingSource_FunctionAddress, "InActor", Classes.FObjectProperty);
		EnableStreamingSource_IsValid = EnableStreamingSource_FunctionAddress != IntPtr.Zero && EnableStreamingSource_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:EnableStreamingSource", EnableStreamingSource_IsValid);
		DisableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableStreamingSource");
		DisableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableStreamingSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableStreamingSource_InActor_PropertyAddress, DisableStreamingSource_FunctionAddress, "InActor");
		DisableStreamingSource_InActor_Offset = NativeReflectionCached.GetPropertyOffset(DisableStreamingSource_FunctionAddress, "InActor");
		DisableStreamingSource_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableStreamingSource_FunctionAddress, "InActor", Classes.FObjectProperty);
		DisableStreamingSource_IsValid = DisableStreamingSource_FunctionAddress != IntPtr.Zero && DisableStreamingSource_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:DisableStreamingSource", DisableStreamingSource_IsValid);
		DestroyGSWCWorldStreamingSources_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyGSWCWorldStreamingSources");
		DestroyGSWCWorldStreamingSources_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyGSWCWorldStreamingSources_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyGSWCWorldStreamingSources_WorldContext_PropertyAddress, DestroyGSWCWorldStreamingSources_FunctionAddress, "WorldContext");
		DestroyGSWCWorldStreamingSources_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(DestroyGSWCWorldStreamingSources_FunctionAddress, "WorldContext");
		DestroyGSWCWorldStreamingSources_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyGSWCWorldStreamingSources_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		DestroyGSWCWorldStreamingSources_IsValid = DestroyGSWCWorldStreamingSources_FunctionAddress != IntPtr.Zero && DestroyGSWCWorldStreamingSources_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:DestroyGSWCWorldStreamingSources", DestroyGSWCWorldStreamingSources_IsValid);
		CheckLevelState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckLevelState");
		CheckLevelState_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckLevelState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckLevelState_InWorldContext_PropertyAddress, CheckLevelState_FunctionAddress, "InWorldContext");
		CheckLevelState_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CheckLevelState_FunctionAddress, "InWorldContext");
		CheckLevelState_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckLevelState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckLevelState_InTargetLevelName_PropertyAddress, CheckLevelState_FunctionAddress, "InTargetLevelName");
		CheckLevelState_InTargetLevelName_Offset = NativeReflectionCached.GetPropertyOffset(CheckLevelState_FunctionAddress, "InTargetLevelName");
		CheckLevelState_InTargetLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckLevelState_FunctionAddress, "InTargetLevelName", Classes.FStrProperty);
		CheckLevelState_IsValid = CheckLevelState_FunctionAddress != IntPtr.Zero && CheckLevelState_InWorldContext_IsValid && CheckLevelState_InTargetLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:CheckLevelState", CheckLevelState_IsValid);
		CacheWorldCompositionStreamingLayers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CacheWorldCompositionStreamingLayers");
		CacheWorldCompositionStreamingLayers_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheWorldCompositionStreamingLayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CacheWorldCompositionStreamingLayers_InWorldContext_PropertyAddress, CacheWorldCompositionStreamingLayers_FunctionAddress, "InWorldContext");
		CacheWorldCompositionStreamingLayers_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CacheWorldCompositionStreamingLayers_FunctionAddress, "InWorldContext");
		CacheWorldCompositionStreamingLayers_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CacheWorldCompositionStreamingLayers_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		CacheWorldCompositionStreamingLayers_IsValid = CacheWorldCompositionStreamingLayers_FunctionAddress != IntPtr.Zero && CacheWorldCompositionStreamingLayers_InWorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionStreamingLayers", CacheWorldCompositionStreamingLayers_IsValid);
		CacheWorldCompositionLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CacheWorldCompositionLevelNames");
		CacheWorldCompositionLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheWorldCompositionLevelNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CacheWorldCompositionLevelNames_InWorldContext_PropertyAddress, CacheWorldCompositionLevelNames_FunctionAddress, "InWorldContext");
		CacheWorldCompositionLevelNames_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CacheWorldCompositionLevelNames_FunctionAddress, "InWorldContext");
		CacheWorldCompositionLevelNames_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CacheWorldCompositionLevelNames_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		CacheWorldCompositionLevelNames_IsValid = CacheWorldCompositionLevelNames_FunctionAddress != IntPtr.Zero && CacheWorldCompositionLevelNames_InWorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUWCStreamingFuncLib:CacheWorldCompositionLevelNames", CacheWorldCompositionLevelNames_IsValid);
	}
}
