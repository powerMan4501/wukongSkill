using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.AnimationLocomotionLibraryEditor;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorAnimationLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetAnimationDistanceCurve_IsValid;

	private static IntPtr SetAnimationDistanceCurve_FunctionAddress;

	private static int SetAnimationDistanceCurve_ParamsSize;

	private static bool SetAnimationDistanceCurve_Modifier_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_Modifier_PropertyAddress;

	private static int SetAnimationDistanceCurve_Modifier_Offset;

	private static bool SetAnimationDistanceCurve_Animation_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_Animation_PropertyAddress;

	private static int SetAnimationDistanceCurve_Animation_Offset;

	private static bool SetAnimationDistanceCurve_SampleRate_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_SampleRate_PropertyAddress;

	private static int SetAnimationDistanceCurve_SampleRate_Offset;

	private static bool SetAnimationDistanceCurve_CurveName_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_CurveName_PropertyAddress;

	private static int SetAnimationDistanceCurve_CurveName_Offset;

	private static bool SetAnimationDistanceCurve_StopSpeedThreshold_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_StopSpeedThreshold_PropertyAddress;

	private static int SetAnimationDistanceCurve_StopSpeedThreshold_Offset;

	private static bool SetAnimationDistanceCurve_Axis_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_Axis_PropertyAddress;

	private static int SetAnimationDistanceCurve_Axis_Offset;

	private static bool SetAnimationDistanceCurve_bStopAtEnd_IsValid;

	private static FFieldAddress SetAnimationDistanceCurve_bStopAtEnd_PropertyAddress;

	private static int SetAnimationDistanceCurve_bStopAtEnd_Offset;

	private static bool SetAnimationAdditiveSetting_IsValid;

	private static IntPtr SetAnimationAdditiveSetting_FunctionAddress;

	private static int SetAnimationAdditiveSetting_ParamsSize;

	private static bool SetAnimationAdditiveSetting_SrcAnim_IsValid;

	private static FFieldAddress SetAnimationAdditiveSetting_SrcAnim_PropertyAddress;

	private static int SetAnimationAdditiveSetting_SrcAnim_Offset;

	private static bool SetAnimationAdditiveSetting_AdditiveType_IsValid;

	private static FFieldAddress SetAnimationAdditiveSetting_AdditiveType_PropertyAddress;

	private static int SetAnimationAdditiveSetting_AdditiveType_Offset;

	private static bool SetAnimationAdditiveSetting_BasePoseType_IsValid;

	private static FFieldAddress SetAnimationAdditiveSetting_BasePoseType_PropertyAddress;

	private static int SetAnimationAdditiveSetting_BasePoseType_Offset;

	private static bool SetAnimationAdditiveSetting_BasePoseAnimation_IsValid;

	private static FFieldAddress SetAnimationAdditiveSetting_BasePoseAnimation_PropertyAddress;

	private static int SetAnimationAdditiveSetting_BasePoseAnimation_Offset;

	private static bool SetAnimationAdditiveSetting_RefFrameIndex_IsValid;

	private static FFieldAddress SetAnimationAdditiveSetting_RefFrameIndex_PropertyAddress;

	private static int SetAnimationAdditiveSetting_RefFrameIndex_Offset;

	private static bool RenameAnimationFloatCurve_IsValid;

	private static IntPtr RenameAnimationFloatCurve_FunctionAddress;

	private static int RenameAnimationFloatCurve_ParamsSize;

	private static bool RenameAnimationFloatCurve_Animation_IsValid;

	private static FFieldAddress RenameAnimationFloatCurve_Animation_PropertyAddress;

	private static int RenameAnimationFloatCurve_Animation_Offset;

	private static bool RenameAnimationFloatCurve_OldCurveName_IsValid;

	private static FFieldAddress RenameAnimationFloatCurve_OldCurveName_PropertyAddress;

	private static int RenameAnimationFloatCurve_OldCurveName_Offset;

	private static bool RenameAnimationFloatCurve_NewCurveName_IsValid;

	private static FFieldAddress RenameAnimationFloatCurve_NewCurveName_PropertyAddress;

	private static int RenameAnimationFloatCurve_NewCurveName_Offset;

	private static bool RemoveAnimationSyncMarkersByName_IsValid;

	private static IntPtr RemoveAnimationSyncMarkersByName_FunctionAddress;

	private static int RemoveAnimationSyncMarkersByName_ParamsSize;

	private static bool RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_AnimationSequence_Offset;

	private static bool RemoveAnimationSyncMarkersByName_MarkerName_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_MarkerName_Offset;

	private static bool RemoveAnimationSyncMarkersByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_ReturnValue_Offset;

	private static bool OutputSameSourceFileAnimList_IsValid;

	private static IntPtr OutputSameSourceFileAnimList_FunctionAddress;

	private static int OutputSameSourceFileAnimList_ParamsSize;

	private static bool OutputSameSourceFileAnimList_AnimSearchPath_IsValid;

	private static FFieldAddress OutputSameSourceFileAnimList_AnimSearchPath_PropertyAddress;

	private static int OutputSameSourceFileAnimList_AnimSearchPath_Offset;

	private static bool OutputSameSourceFileAnimList_SelectedAssets_IsValid;

	private static FFieldAddress OutputSameSourceFileAnimList_SelectedAssets_PropertyAddress;

	private static int OutputSameSourceFileAnimList_SelectedAssets_Offset;

	private static bool OutputSameSourceFileAnimList_bOutputFullPath_IsValid;

	private static FFieldAddress OutputSameSourceFileAnimList_bOutputFullPath_PropertyAddress;

	private static int OutputSameSourceFileAnimList_bOutputFullPath_Offset;

	private static bool OutputHaveSyncMarkerAnimList_IsValid;

	private static IntPtr OutputHaveSyncMarkerAnimList_FunctionAddress;

	private static int OutputHaveSyncMarkerAnimList_ParamsSize;

	private static bool OutputHaveSyncMarkerAnimList_SelectedAssets_IsValid;

	private static FFieldAddress OutputHaveSyncMarkerAnimList_SelectedAssets_PropertyAddress;

	private static int OutputHaveSyncMarkerAnimList_SelectedAssets_Offset;

	private static bool OutputHaveSyncMarkerAnimList_bOutputFullPath_IsValid;

	private static FFieldAddress OutputHaveSyncMarkerAnimList_bOutputFullPath_PropertyAddress;

	private static int OutputHaveSyncMarkerAnimList_bOutputFullPath_Offset;

	private static bool IsValidAnimNotifyTrackName_IsValid;

	private static IntPtr IsValidAnimNotifyTrackName_FunctionAddress;

	private static int IsValidAnimNotifyTrackName_ParamsSize;

	private static bool IsValidAnimNotifyTrackName_AnimationSequence_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_AnimationSequence_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_AnimationSequence_Offset;

	private static bool IsValidAnimNotifyTrackName_NotifyTrackName_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_NotifyTrackName_Offset;

	private static bool IsValidAnimNotifyTrackName_ReturnValue_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_ReturnValue_Offset;

	private static bool GetFloatKeys_IsValid;

	private static IntPtr GetFloatKeys_FunctionAddress;

	private static int GetFloatKeys_ParamsSize;

	private static bool GetFloatKeys_Animation_IsValid;

	private static FFieldAddress GetFloatKeys_Animation_PropertyAddress;

	private static int GetFloatKeys_Animation_Offset;

	private static bool GetFloatKeys_CurveName_IsValid;

	private static FFieldAddress GetFloatKeys_CurveName_PropertyAddress;

	private static int GetFloatKeys_CurveName_Offset;

	private static bool GetFloatKeys_Times_IsValid;

	private static FFieldAddress GetFloatKeys_Times_PropertyAddress;

	private static int GetFloatKeys_Times_Offset;

	private static bool GetFloatKeys_Values_IsValid;

	private static FFieldAddress GetFloatKeys_Values_PropertyAddress;

	private static int GetFloatKeys_Values_Offset;

	private static bool GetAnimationCurveNames_IsValid;

	private static IntPtr GetAnimationCurveNames_FunctionAddress;

	private static int GetAnimationCurveNames_ParamsSize;

	private static bool GetAnimationCurveNames_Animation_IsValid;

	private static FFieldAddress GetAnimationCurveNames_Animation_PropertyAddress;

	private static int GetAnimationCurveNames_Animation_Offset;

	private static bool GetAnimationCurveNames_CurveType_IsValid;

	private static FFieldAddress GetAnimationCurveNames_CurveType_PropertyAddress;

	private static int GetAnimationCurveNames_CurveType_Offset;

	private static bool GetAnimationCurveNames_CurveNames_IsValid;

	private static FFieldAddress GetAnimationCurveNames_CurveNames_PropertyAddress;

	private static int GetAnimationCurveNames_CurveNames_Offset;

	private static bool GetAdditiveBasePoseType_IsValid;

	private static IntPtr GetAdditiveBasePoseType_FunctionAddress;

	private static int GetAdditiveBasePoseType_ParamsSize;

	private static bool GetAdditiveBasePoseType_AnimationSequence_IsValid;

	private static FFieldAddress GetAdditiveBasePoseType_AnimationSequence_PropertyAddress;

	private static int GetAdditiveBasePoseType_AnimationSequence_Offset;

	private static bool GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;

	private static FFieldAddress GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress;

	private static int GetAdditiveBasePoseType_AdditiveBasePoseType_Offset;

	private static bool GetAdditiveAnimationType_IsValid;

	private static IntPtr GetAdditiveAnimationType_FunctionAddress;

	private static int GetAdditiveAnimationType_ParamsSize;

	private static bool GetAdditiveAnimationType_AnimationSequence_IsValid;

	private static FFieldAddress GetAdditiveAnimationType_AnimationSequence_PropertyAddress;

	private static int GetAdditiveAnimationType_AnimationSequence_Offset;

	private static bool GetAdditiveAnimationType_AdditiveAnimationType_IsValid;

	private static FFieldAddress GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress;

	private static int GetAdditiveAnimationType_AdditiveAnimationType_Offset;

	private static bool DoesCurveExist_IsValid;

	private static IntPtr DoesCurveExist_FunctionAddress;

	private static int DoesCurveExist_ParamsSize;

	private static bool DoesCurveExist_Animation_IsValid;

	private static FFieldAddress DoesCurveExist_Animation_PropertyAddress;

	private static int DoesCurveExist_Animation_Offset;

	private static bool DoesCurveExist_CurveName_IsValid;

	private static FFieldAddress DoesCurveExist_CurveName_PropertyAddress;

	private static int DoesCurveExist_CurveName_Offset;

	private static bool DoesCurveExist_CurveType_IsValid;

	private static FFieldAddress DoesCurveExist_CurveType_PropertyAddress;

	private static int DoesCurveExist_CurveType_Offset;

	private static bool DoesCurveExist_ReturnValue_IsValid;

	private static FFieldAddress DoesCurveExist_ReturnValue_PropertyAddress;

	private static int DoesCurveExist_ReturnValue_Offset;

	private static bool CreateAnimFromPreviewMesh_IsValid;

	private static IntPtr CreateAnimFromPreviewMesh_FunctionAddress;

	private static int CreateAnimFromPreviewMesh_ParamsSize;

	private static bool CreateAnimFromPreviewMesh_Animation_IsValid;

	private static FFieldAddress CreateAnimFromPreviewMesh_Animation_PropertyAddress;

	private static int CreateAnimFromPreviewMesh_Animation_Offset;

	private static bool CopyMontageSlotData_IsValid;

	private static IntPtr CopyMontageSlotData_FunctionAddress;

	private static int CopyMontageSlotData_ParamsSize;

	private static bool CopyMontageSlotData_SrcAnim_IsValid;

	private static FFieldAddress CopyMontageSlotData_SrcAnim_PropertyAddress;

	private static int CopyMontageSlotData_SrcAnim_Offset;

	private static bool CopyMontageSlotData_DestAnim_IsValid;

	private static FFieldAddress CopyMontageSlotData_DestAnim_PropertyAddress;

	private static int CopyMontageSlotData_DestAnim_Offset;

	private static bool CopyMontageSections_IsValid;

	private static IntPtr CopyMontageSections_FunctionAddress;

	private static int CopyMontageSections_ParamsSize;

	private static bool CopyMontageSections_SrcAnim_IsValid;

	private static FFieldAddress CopyMontageSections_SrcAnim_PropertyAddress;

	private static int CopyMontageSections_SrcAnim_Offset;

	private static bool CopyMontageSections_DestAnim_IsValid;

	private static FFieldAddress CopyMontageSections_DestAnim_PropertyAddress;

	private static int CopyMontageSections_DestAnim_Offset;

	private static bool CopyBlendSpaceData_IsValid;

	private static IntPtr CopyBlendSpaceData_FunctionAddress;

	private static int CopyBlendSpaceData_ParamsSize;

	private static bool CopyBlendSpaceData_SrcBS_IsValid;

	private static FFieldAddress CopyBlendSpaceData_SrcBS_PropertyAddress;

	private static int CopyBlendSpaceData_SrcBS_Offset;

	private static bool CopyBlendSpaceData_DestBS_IsValid;

	private static FFieldAddress CopyBlendSpaceData_DestBS_PropertyAddress;

	private static int CopyBlendSpaceData_DestBS_Offset;

	private static bool CopyAnimationSyncMarker_IsValid;

	private static IntPtr CopyAnimationSyncMarker_FunctionAddress;

	private static int CopyAnimationSyncMarker_ParamsSize;

	private static bool CopyAnimationSyncMarker_SrcAnim_IsValid;

	private static FFieldAddress CopyAnimationSyncMarker_SrcAnim_PropertyAddress;

	private static int CopyAnimationSyncMarker_SrcAnim_Offset;

	private static bool CopyAnimationSyncMarker_DestAnim_IsValid;

	private static FFieldAddress CopyAnimationSyncMarker_DestAnim_PropertyAddress;

	private static int CopyAnimationSyncMarker_DestAnim_Offset;

	private static bool CopyAnimationRootMotionSetting_IsValid;

	private static IntPtr CopyAnimationRootMotionSetting_FunctionAddress;

	private static int CopyAnimationRootMotionSetting_ParamsSize;

	private static bool CopyAnimationRootMotionSetting_SrcAnim_IsValid;

	private static FFieldAddress CopyAnimationRootMotionSetting_SrcAnim_PropertyAddress;

	private static int CopyAnimationRootMotionSetting_SrcAnim_Offset;

	private static bool CopyAnimationRootMotionSetting_DestAnim_IsValid;

	private static FFieldAddress CopyAnimationRootMotionSetting_DestAnim_PropertyAddress;

	private static int CopyAnimationRootMotionSetting_DestAnim_Offset;

	private static bool CopyAnimationFloatCurve_IsValid;

	private static IntPtr CopyAnimationFloatCurve_FunctionAddress;

	private static int CopyAnimationFloatCurve_ParamsSize;

	private static bool CopyAnimationFloatCurve_SrcAnim_IsValid;

	private static FFieldAddress CopyAnimationFloatCurve_SrcAnim_PropertyAddress;

	private static int CopyAnimationFloatCurve_SrcAnim_Offset;

	private static bool CopyAnimationFloatCurve_DestAnim_IsValid;

	private static FFieldAddress CopyAnimationFloatCurve_DestAnim_PropertyAddress;

	private static int CopyAnimationFloatCurve_DestAnim_Offset;

	private static bool CopyAnimationAdditiveSetting_IsValid;

	private static IntPtr CopyAnimationAdditiveSetting_FunctionAddress;

	private static int CopyAnimationAdditiveSetting_ParamsSize;

	private static bool CopyAnimationAdditiveSetting_SrcAnim_IsValid;

	private static FFieldAddress CopyAnimationAdditiveSetting_SrcAnim_PropertyAddress;

	private static int CopyAnimationAdditiveSetting_SrcAnim_Offset;

	private static bool CopyAnimationAdditiveSetting_DestAnim_IsValid;

	private static FFieldAddress CopyAnimationAdditiveSetting_DestAnim_PropertyAddress;

	private static int CopyAnimationAdditiveSetting_DestAnim_Offset;

	private static bool ApplyCompression_IsValid;

	private static IntPtr ApplyCompression_FunctionAddress;

	private static int ApplyCompression_ParamsSize;

	private static bool ApplyCompression_Animation_IsValid;

	private static FFieldAddress ApplyCompression_Animation_PropertyAddress;

	private static int ApplyCompression_Animation_Offset;

	private static bool AddFloatCurveKeys_IsValid;

	private static IntPtr AddFloatCurveKeys_FunctionAddress;

	private static int AddFloatCurveKeys_ParamsSize;

	private static bool AddFloatCurveKeys_Animation_IsValid;

	private static FFieldAddress AddFloatCurveKeys_Animation_PropertyAddress;

	private static int AddFloatCurveKeys_Animation_Offset;

	private static bool AddFloatCurveKeys_CurveName_IsValid;

	private static FFieldAddress AddFloatCurveKeys_CurveName_PropertyAddress;

	private static int AddFloatCurveKeys_CurveName_Offset;

	private static bool AddFloatCurveKeys_Times_IsValid;

	private static FFieldAddress AddFloatCurveKeys_Times_PropertyAddress;

	private static int AddFloatCurveKeys_Times_Offset;

	private static bool AddFloatCurveKeys_Values_IsValid;

	private static FFieldAddress AddFloatCurveKeys_Values_PropertyAddress;

	private static int AddFloatCurveKeys_Values_Offset;

	private static bool AddCurve_IsValid;

	private static IntPtr AddCurve_FunctionAddress;

	private static int AddCurve_ParamsSize;

	private static bool AddCurve_Animation_IsValid;

	private static FFieldAddress AddCurve_Animation_PropertyAddress;

	private static int AddCurve_Animation_Offset;

	private static bool AddCurve_CurveName_IsValid;

	private static FFieldAddress AddCurve_CurveName_PropertyAddress;

	private static int AddCurve_CurveName_Offset;

	private static bool AddCurve_CurveType_IsValid;

	private static FFieldAddress AddCurve_CurveType_PropertyAddress;

	private static int AddCurve_CurveType_Offset;

	private static bool AddCurve_bMetaDataCurve_IsValid;

	private static FFieldAddress AddCurve_bMetaDataCurve_PropertyAddress;

	private static int AddCurve_bMetaDataCurve_Offset;

	private static bool AddAnimationSyncMarker_IsValid;

	private static IntPtr AddAnimationSyncMarker_FunctionAddress;

	private static int AddAnimationSyncMarker_ParamsSize;

	private static bool AddAnimationSyncMarker_AnimationSequence_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_AnimationSequence_PropertyAddress;

	private static int AddAnimationSyncMarker_AnimationSequence_Offset;

	private static bool AddAnimationSyncMarker_MarkerName_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_MarkerName_PropertyAddress;

	private static int AddAnimationSyncMarker_MarkerName_Offset;

	private static bool AddAnimationSyncMarker_Time_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_Time_PropertyAddress;

	private static int AddAnimationSyncMarker_Time_Offset;

	private static bool AddAnimationSyncMarker_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_NotifyTrackName_PropertyAddress;

	private static int AddAnimationSyncMarker_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyTrack_IsValid;

	private static IntPtr AddAnimationNotifyTrack_FunctionAddress;

	private static int AddAnimationNotifyTrack_ParamsSize;

	private static bool AddAnimationNotifyTrack_AnimationSequence_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_AnimationSequence_PropertyAddress;

	private static int AddAnimationNotifyTrack_AnimationSequence_Offset;

	private static bool AddAnimationNotifyTrack_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyTrack_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyTrack_TrackColor_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_TrackColor_PropertyAddress;

	private static int AddAnimationNotifyTrack_TrackColor_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationDistanceCurve")]
	public unsafe static void SetAnimationDistanceCurve(UDistanceCurveModifier Modifier, UAnimSequence Animation, int SampleRate, FName CurveName, float StopSpeedThreshold, EDistanceCurve_Axis Axis, bool bStopAtEnd)
	{
		if (!SetAnimationDistanceCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationDistanceCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationDistanceCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationDistanceCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDistanceCurveModifier>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_Modifier_Offset), 0, SetAnimationDistanceCurve_Modifier_PropertyAddress.Address, Modifier);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_Animation_Offset), 0, SetAnimationDistanceCurve_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_SampleRate_Offset), 0, SetAnimationDistanceCurve_SampleRate_PropertyAddress.Address, SampleRate);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_CurveName_Offset), 0, SetAnimationDistanceCurve_CurveName_PropertyAddress.Address, CurveName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_StopSpeedThreshold_Offset), 0, SetAnimationDistanceCurve_StopSpeedThreshold_PropertyAddress.Address, StopSpeedThreshold);
		EnumMarshaler<EDistanceCurve_Axis>.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_Axis_Offset), 0, SetAnimationDistanceCurve_Axis_PropertyAddress.Address, Axis);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimationDistanceCurve_bStopAtEnd_Offset), 0, SetAnimationDistanceCurve_bStopAtEnd_PropertyAddress.Address, bStopAtEnd);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimationDistanceCurve_FunctionAddress, intPtr, SetAnimationDistanceCurve_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationAdditiveSetting")]
	public unsafe static void SetAnimationAdditiveSetting(UAnimSequence SrcAnim, EAdditiveAnimationType AdditiveType, EAdditiveBasePoseType BasePoseType, UAnimSequence BasePoseAnimation, int RefFrameIndex = 0)
	{
		if (!SetAnimationAdditiveSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationAdditiveSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationAdditiveSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationAdditiveSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAnimationAdditiveSetting_SrcAnim_Offset), 0, SetAnimationAdditiveSetting_SrcAnim_PropertyAddress.Address, SrcAnim);
		EnumMarshaler<EAdditiveAnimationType>.ToNative(IntPtr.Add(intPtr, SetAnimationAdditiveSetting_AdditiveType_Offset), 0, SetAnimationAdditiveSetting_AdditiveType_PropertyAddress.Address, AdditiveType);
		EnumMarshaler<EAdditiveBasePoseType>.ToNative(IntPtr.Add(intPtr, SetAnimationAdditiveSetting_BasePoseType_Offset), 0, SetAnimationAdditiveSetting_BasePoseType_PropertyAddress.Address, BasePoseType);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAnimationAdditiveSetting_BasePoseAnimation_Offset), 0, SetAnimationAdditiveSetting_BasePoseAnimation_PropertyAddress.Address, BasePoseAnimation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAnimationAdditiveSetting_RefFrameIndex_Offset), 0, SetAnimationAdditiveSetting_RefFrameIndex_PropertyAddress.Address, RefFrameIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimationAdditiveSetting_FunctionAddress, intPtr, SetAnimationAdditiveSetting_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:RenameAnimationFloatCurve")]
	public unsafe static void RenameAnimationFloatCurve(UAnimSequenceBase Animation, FName OldCurveName, FName NewCurveName)
	{
		if (!RenameAnimationFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:RenameAnimationFloatCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAnimationFloatCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAnimationFloatCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RenameAnimationFloatCurve_Animation_Offset), 0, RenameAnimationFloatCurve_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameAnimationFloatCurve_OldCurveName_Offset), 0, RenameAnimationFloatCurve_OldCurveName_PropertyAddress.Address, OldCurveName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameAnimationFloatCurve_NewCurveName_Offset), 0, RenameAnimationFloatCurve_NewCurveName_PropertyAddress.Address, NewCurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameAnimationFloatCurve_FunctionAddress, intPtr, RenameAnimationFloatCurve_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:RemoveAnimationSyncMarkersByName")]
	public unsafe static int RemoveAnimationSyncMarkersByName(UAnimSequence AnimationSequence, FName MarkerName)
	{
		if (!RemoveAnimationSyncMarkersByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:RemoveAnimationSyncMarkersByName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationSyncMarkersByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationSyncMarkersByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_AnimationSequence_Offset), 0, RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_MarkerName_Offset), 0, RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress.Address, MarkerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, intPtr, RemoveAnimationSyncMarkersByName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_ReturnValue_Offset), 0, RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputSameSourceFileAnimList")]
	public unsafe static void OutputSameSourceFileAnimList(FName AnimSearchPath, List<UObject> SelectedAssets, bool bOutputFullPath)
	{
		if (!OutputSameSourceFileAnimList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputSameSourceFileAnimList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OutputSameSourceFileAnimList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OutputSameSourceFileAnimList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OutputSameSourceFileAnimList_AnimSearchPath_Offset), 0, OutputSameSourceFileAnimList_AnimSearchPath_PropertyAddress.Address, AnimSearchPath);
		new TArrayCopyMarshaler<UObject>(1, OutputSameSourceFileAnimList_SelectedAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OutputSameSourceFileAnimList_SelectedAssets_Offset), SelectedAssets);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OutputSameSourceFileAnimList_bOutputFullPath_Offset), 0, OutputSameSourceFileAnimList_bOutputFullPath_PropertyAddress.Address, bOutputFullPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OutputSameSourceFileAnimList_FunctionAddress, intPtr, OutputSameSourceFileAnimList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OutputSameSourceFileAnimList_SelectedAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputHaveSyncMarkerAnimList")]
	public unsafe static void OutputHaveSyncMarkerAnimList(List<UObject> SelectedAssets, bool bOutputFullPath)
	{
		if (!OutputHaveSyncMarkerAnimList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputHaveSyncMarkerAnimList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OutputHaveSyncMarkerAnimList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OutputHaveSyncMarkerAnimList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, OutputHaveSyncMarkerAnimList_SelectedAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, OutputHaveSyncMarkerAnimList_SelectedAssets_Offset), SelectedAssets);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OutputHaveSyncMarkerAnimList_bOutputFullPath_Offset), 0, OutputHaveSyncMarkerAnimList_bOutputFullPath_PropertyAddress.Address, bOutputFullPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OutputHaveSyncMarkerAnimList_FunctionAddress, intPtr, OutputHaveSyncMarkerAnimList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OutputHaveSyncMarkerAnimList_SelectedAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335815681u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:IsValidAnimNotifyTrackName")]
	public unsafe static bool IsValidAnimNotifyTrackName(UAnimSequence AnimationSequence, FName NotifyTrackName)
	{
		if (!IsValidAnimNotifyTrackName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:IsValidAnimNotifyTrackName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAnimNotifyTrackName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAnimNotifyTrackName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_AnimationSequence_Offset), 0, IsValidAnimNotifyTrackName_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_NotifyTrackName_Offset), 0, IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAnimNotifyTrackName_FunctionAddress, intPtr, IsValidAnimNotifyTrackName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_ReturnValue_Offset), 0, IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetFloatKeys")]
	public unsafe static void GetFloatKeys(UAnimSequenceBase Animation, FName CurveName, out List<float> Times, out List<float> Values)
	{
		if (!GetFloatKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetFloatKeys");
			Times = null;
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetFloatKeys_Animation_Offset), 0, GetFloatKeys_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatKeys_CurveName_Offset), 0, GetFloatKeys_CurveName_PropertyAddress.Address, CurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatKeys_FunctionAddress, intPtr, GetFloatKeys_ParamsSize);
		Times = new TArrayCopyMarshaler<float>(1, GetFloatKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFloatKeys_Times_Offset));
		NativeReflection.DestroyValue_InContainer(GetFloatKeys_Times_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<float>(1, GetFloatKeys_Values_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFloatKeys_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetFloatKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 340009985u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAnimationCurveNames")]
	public unsafe static void GetAnimationCurveNames(UAnimSequenceBase Animation, ERawCurveTrackTypes CurveType, out List<FName> CurveNames)
	{
		if (!GetAnimationCurveNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAnimationCurveNames");
			CurveNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationCurveNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationCurveNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationCurveNames_Animation_Offset), 0, GetAnimationCurveNames_Animation_PropertyAddress.Address, Animation);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, GetAnimationCurveNames_CurveType_Offset), 0, GetAnimationCurveNames_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationCurveNames_FunctionAddress, intPtr, GetAnimationCurveNames_ParamsSize);
		CurveNames = new TArrayCopyMarshaler<FName>(1, GetAnimationCurveNames_CurveNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationCurveNames_CurveNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationCurveNames_CurveNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 340009985u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveBasePoseType")]
	public unsafe static void GetAdditiveBasePoseType(UAnimSequence AnimationSequence, out EAdditiveBasePoseType AdditiveBasePoseType)
	{
		if (!GetAdditiveBasePoseType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveBasePoseType");
			AdditiveBasePoseType = EAdditiveBasePoseType.ABPT_None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditiveBasePoseType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditiveBasePoseType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAdditiveBasePoseType_AnimationSequence_Offset), 0, GetAdditiveBasePoseType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAdditiveBasePoseType_FunctionAddress, intPtr, GetAdditiveBasePoseType_ParamsSize);
		AdditiveBasePoseType = EnumMarshaler<EAdditiveBasePoseType>.FromNative(IntPtr.Add(intPtr, GetAdditiveBasePoseType_AdditiveBasePoseType_Offset), 0, GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress.Address);
	}

	[UFunction(Flags = 340009985u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveAnimationType")]
	public unsafe static void GetAdditiveAnimationType(UAnimSequence AnimationSequence, out EAdditiveAnimationType AdditiveAnimationType)
	{
		if (!GetAdditiveAnimationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveAnimationType");
			AdditiveAnimationType = EAdditiveAnimationType.AAT_None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditiveAnimationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditiveAnimationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAdditiveAnimationType_AnimationSequence_Offset), 0, GetAdditiveAnimationType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAdditiveAnimationType_FunctionAddress, intPtr, GetAdditiveAnimationType_ParamsSize);
		AdditiveAnimationType = EnumMarshaler<EAdditiveAnimationType>.FromNative(IntPtr.Add(intPtr, GetAdditiveAnimationType_AdditiveAnimationType_Offset), 0, GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:DoesCurveExist")]
	public unsafe static bool DoesCurveExist(UAnimSequenceBase Animation, FName CurveName, ERawCurveTrackTypes CurveType)
	{
		if (!DoesCurveExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:DoesCurveExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesCurveExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesCurveExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_Animation_Offset), 0, DoesCurveExist_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_CurveName_Offset), 0, DoesCurveExist_CurveName_PropertyAddress.Address, CurveName);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_CurveType_Offset), 0, DoesCurveExist_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesCurveExist_FunctionAddress, intPtr, DoesCurveExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesCurveExist_ReturnValue_Offset), 0, DoesCurveExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CreateAnimFromPreviewMesh")]
	public unsafe static void CreateAnimFromPreviewMesh(UAnimSequence Animation)
	{
		if (!CreateAnimFromPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CreateAnimFromPreviewMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAnimFromPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAnimFromPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CreateAnimFromPreviewMesh_Animation_Offset), 0, CreateAnimFromPreviewMesh_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAnimFromPreviewMesh_FunctionAddress, intPtr, CreateAnimFromPreviewMesh_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSlotData")]
	public unsafe static void CopyMontageSlotData(UAnimMontage SrcAnim, UAnimMontage DestAnim)
	{
		if (!CopyMontageSlotData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSlotData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMontageSlotData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMontageSlotData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CopyMontageSlotData_SrcAnim_Offset), 0, CopyMontageSlotData_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CopyMontageSlotData_DestAnim_Offset), 0, CopyMontageSlotData_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMontageSlotData_FunctionAddress, intPtr, CopyMontageSlotData_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSections")]
	public unsafe static void CopyMontageSections(UAnimMontage SrcAnim, UAnimMontage DestAnim)
	{
		if (!CopyMontageSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMontageSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMontageSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CopyMontageSections_SrcAnim_Offset), 0, CopyMontageSections_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CopyMontageSections_DestAnim_Offset), 0, CopyMontageSections_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMontageSections_FunctionAddress, intPtr, CopyMontageSections_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyBlendSpaceData")]
	public unsafe static void CopyBlendSpaceData(UBlendSpace SrcBS, UBlendSpace DestBS)
	{
		if (!CopyBlendSpaceData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyBlendSpaceData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyBlendSpaceData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyBlendSpaceData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, CopyBlendSpaceData_SrcBS_Offset), 0, CopyBlendSpaceData_SrcBS_PropertyAddress.Address, SrcBS);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, CopyBlendSpaceData_DestBS_Offset), 0, CopyBlendSpaceData_DestBS_PropertyAddress.Address, DestBS);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyBlendSpaceData_FunctionAddress, intPtr, CopyBlendSpaceData_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationSyncMarker")]
	public unsafe static void CopyAnimationSyncMarker(UAnimSequence SrcAnim, UAnimSequence DestAnim)
	{
		if (!CopyAnimationSyncMarker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationSyncMarker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimationSyncMarker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimationSyncMarker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationSyncMarker_SrcAnim_Offset), 0, CopyAnimationSyncMarker_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationSyncMarker_DestAnim_Offset), 0, CopyAnimationSyncMarker_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimationSyncMarker_FunctionAddress, intPtr, CopyAnimationSyncMarker_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationRootMotionSetting")]
	public unsafe static void CopyAnimationRootMotionSetting(UAnimSequence SrcAnim, UAnimSequence DestAnim)
	{
		if (!CopyAnimationRootMotionSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationRootMotionSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimationRootMotionSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimationRootMotionSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationRootMotionSetting_SrcAnim_Offset), 0, CopyAnimationRootMotionSetting_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationRootMotionSetting_DestAnim_Offset), 0, CopyAnimationRootMotionSetting_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimationRootMotionSetting_FunctionAddress, intPtr, CopyAnimationRootMotionSetting_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationFloatCurve")]
	public unsafe static void CopyAnimationFloatCurve(UAnimSequenceBase SrcAnim, UAnimSequenceBase DestAnim)
	{
		if (!CopyAnimationFloatCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationFloatCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimationFloatCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimationFloatCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CopyAnimationFloatCurve_SrcAnim_Offset), 0, CopyAnimationFloatCurve_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CopyAnimationFloatCurve_DestAnim_Offset), 0, CopyAnimationFloatCurve_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimationFloatCurve_FunctionAddress, intPtr, CopyAnimationFloatCurve_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationAdditiveSetting")]
	public unsafe static void CopyAnimationAdditiveSetting(UAnimSequence SrcAnim, UAnimSequence DestAnim)
	{
		if (!CopyAnimationAdditiveSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationAdditiveSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimationAdditiveSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimationAdditiveSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationAdditiveSetting_SrcAnim_Offset), 0, CopyAnimationAdditiveSetting_SrcAnim_PropertyAddress.Address, SrcAnim);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, CopyAnimationAdditiveSetting_DestAnim_Offset), 0, CopyAnimationAdditiveSetting_DestAnim_PropertyAddress.Address, DestAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimationAdditiveSetting_FunctionAddress, intPtr, CopyAnimationAdditiveSetting_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:ApplyCompression")]
	public unsafe static void ApplyCompression(UAnimSequence Animation)
	{
		if (!ApplyCompression_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:ApplyCompression");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyCompression_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyCompression_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ApplyCompression_Animation_Offset), 0, ApplyCompression_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyCompression_FunctionAddress, intPtr, ApplyCompression_ParamsSize);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddFloatCurveKeys")]
	public unsafe static void AddFloatCurveKeys(UAnimSequenceBase Animation, FName CurveName, List<float> Times, List<float> Values)
	{
		if (!AddFloatCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddFloatCurveKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFloatCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFloatCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_Animation_Offset), 0, AddFloatCurveKeys_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_CurveName_Offset), 0, AddFloatCurveKeys_CurveName_PropertyAddress.Address, CurveName);
		new TArrayCopyMarshaler<float>(1, AddFloatCurveKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_Times_Offset), Times);
		new TArrayCopyMarshaler<float>(1, AddFloatCurveKeys_Values_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_Values_Offset), Values);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFloatCurveKeys_FunctionAddress, intPtr, AddFloatCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFloatCurveKeys_Times_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFloatCurveKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddCurve")]
	public unsafe static void AddCurve(UAnimSequenceBase Animation, FName CurveName, ERawCurveTrackTypes CurveType = ERawCurveTrackTypes.RCT_Float, bool bMetaDataCurve = false)
	{
		if (!AddCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddCurve_Animation_Offset), 0, AddCurve_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCurve_CurveName_Offset), 0, AddCurve_CurveName_PropertyAddress.Address, CurveName);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, AddCurve_CurveType_Offset), 0, AddCurve_CurveType_PropertyAddress.Address, CurveType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCurve_bMetaDataCurve_Offset), 0, AddCurve_bMetaDataCurve_PropertyAddress.Address, bMetaDataCurve);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddCurve_FunctionAddress, intPtr, AddCurve_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationSyncMarker")]
	public unsafe static void AddAnimationSyncMarker(UAnimSequence AnimationSequence, FName MarkerName, float Time, FName NotifyTrackName)
	{
		if (!AddAnimationSyncMarker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationSyncMarker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationSyncMarker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationSyncMarker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_AnimationSequence_Offset), 0, AddAnimationSyncMarker_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_MarkerName_Offset), 0, AddAnimationSyncMarker_MarkerName_PropertyAddress.Address, MarkerName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_Time_Offset), 0, AddAnimationSyncMarker_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_NotifyTrackName_Offset), 0, AddAnimationSyncMarker_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationSyncMarker_FunctionAddress, intPtr, AddAnimationSyncMarker_ParamsSize);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationNotifyTrack")]
	public unsafe static void AddAnimationNotifyTrack(UAnimSequence AnimationSequence, FName NotifyTrackName, FLinearColor TrackColor)
	{
		if (!AddAnimationNotifyTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationNotifyTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_AnimationSequence_Offset), 0, AddAnimationNotifyTrack_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_NotifyTrackName_Offset), 0, AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_TrackColor_Offset), 0, AddAnimationNotifyTrack_TrackColor_PropertyAddress.Address, TrackColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyTrack_FunctionAddress, intPtr, AddAnimationNotifyTrack_ParamsSize);
	}

	static UGSEditorAnimationLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorAnimationLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorAnimationLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorAnimationLibrary");
		SetAnimationDistanceCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimationDistanceCurve");
		SetAnimationDistanceCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationDistanceCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_Modifier_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "Modifier");
		SetAnimationDistanceCurve_Modifier_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "Modifier");
		SetAnimationDistanceCurve_Modifier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "Modifier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_Animation_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "Animation");
		SetAnimationDistanceCurve_Animation_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "Animation");
		SetAnimationDistanceCurve_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_SampleRate_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "SampleRate");
		SetAnimationDistanceCurve_SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "SampleRate");
		SetAnimationDistanceCurve_SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "SampleRate", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_CurveName_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "CurveName");
		SetAnimationDistanceCurve_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "CurveName");
		SetAnimationDistanceCurve_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_StopSpeedThreshold_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "StopSpeedThreshold");
		SetAnimationDistanceCurve_StopSpeedThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "StopSpeedThreshold");
		SetAnimationDistanceCurve_StopSpeedThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "StopSpeedThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_Axis_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "Axis");
		SetAnimationDistanceCurve_Axis_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "Axis");
		SetAnimationDistanceCurve_Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "Axis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationDistanceCurve_bStopAtEnd_PropertyAddress, SetAnimationDistanceCurve_FunctionAddress, "bStopAtEnd");
		SetAnimationDistanceCurve_bStopAtEnd_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationDistanceCurve_FunctionAddress, "bStopAtEnd");
		SetAnimationDistanceCurve_bStopAtEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationDistanceCurve_FunctionAddress, "bStopAtEnd", Classes.FBoolProperty);
		SetAnimationDistanceCurve_IsValid = SetAnimationDistanceCurve_FunctionAddress != IntPtr.Zero && SetAnimationDistanceCurve_Modifier_IsValid && SetAnimationDistanceCurve_Animation_IsValid && SetAnimationDistanceCurve_SampleRate_IsValid && SetAnimationDistanceCurve_CurveName_IsValid && SetAnimationDistanceCurve_StopSpeedThreshold_IsValid && SetAnimationDistanceCurve_Axis_IsValid && SetAnimationDistanceCurve_bStopAtEnd_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationDistanceCurve", SetAnimationDistanceCurve_IsValid);
		SetAnimationAdditiveSetting_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimationAdditiveSetting");
		SetAnimationAdditiveSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationAdditiveSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAdditiveSetting_SrcAnim_PropertyAddress, SetAnimationAdditiveSetting_FunctionAddress, "SrcAnim");
		SetAnimationAdditiveSetting_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAdditiveSetting_FunctionAddress, "SrcAnim");
		SetAnimationAdditiveSetting_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAdditiveSetting_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAdditiveSetting_AdditiveType_PropertyAddress, SetAnimationAdditiveSetting_FunctionAddress, "AdditiveType");
		SetAnimationAdditiveSetting_AdditiveType_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAdditiveSetting_FunctionAddress, "AdditiveType");
		SetAnimationAdditiveSetting_AdditiveType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAdditiveSetting_FunctionAddress, "AdditiveType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAdditiveSetting_BasePoseType_PropertyAddress, SetAnimationAdditiveSetting_FunctionAddress, "BasePoseType");
		SetAnimationAdditiveSetting_BasePoseType_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAdditiveSetting_FunctionAddress, "BasePoseType");
		SetAnimationAdditiveSetting_BasePoseType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAdditiveSetting_FunctionAddress, "BasePoseType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAdditiveSetting_BasePoseAnimation_PropertyAddress, SetAnimationAdditiveSetting_FunctionAddress, "BasePoseAnimation");
		SetAnimationAdditiveSetting_BasePoseAnimation_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAdditiveSetting_FunctionAddress, "BasePoseAnimation");
		SetAnimationAdditiveSetting_BasePoseAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAdditiveSetting_FunctionAddress, "BasePoseAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationAdditiveSetting_RefFrameIndex_PropertyAddress, SetAnimationAdditiveSetting_FunctionAddress, "RefFrameIndex");
		SetAnimationAdditiveSetting_RefFrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationAdditiveSetting_FunctionAddress, "RefFrameIndex");
		SetAnimationAdditiveSetting_RefFrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationAdditiveSetting_FunctionAddress, "RefFrameIndex", Classes.FIntProperty);
		SetAnimationAdditiveSetting_IsValid = SetAnimationAdditiveSetting_FunctionAddress != IntPtr.Zero && SetAnimationAdditiveSetting_SrcAnim_IsValid && SetAnimationAdditiveSetting_AdditiveType_IsValid && SetAnimationAdditiveSetting_BasePoseType_IsValid && SetAnimationAdditiveSetting_BasePoseAnimation_IsValid && SetAnimationAdditiveSetting_RefFrameIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:SetAnimationAdditiveSetting", SetAnimationAdditiveSetting_IsValid);
		RenameAnimationFloatCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameAnimationFloatCurve");
		RenameAnimationFloatCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAnimationFloatCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAnimationFloatCurve_Animation_PropertyAddress, RenameAnimationFloatCurve_FunctionAddress, "Animation");
		RenameAnimationFloatCurve_Animation_Offset = NativeReflectionCached.GetPropertyOffset(RenameAnimationFloatCurve_FunctionAddress, "Animation");
		RenameAnimationFloatCurve_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAnimationFloatCurve_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAnimationFloatCurve_OldCurveName_PropertyAddress, RenameAnimationFloatCurve_FunctionAddress, "OldCurveName");
		RenameAnimationFloatCurve_OldCurveName_Offset = NativeReflectionCached.GetPropertyOffset(RenameAnimationFloatCurve_FunctionAddress, "OldCurveName");
		RenameAnimationFloatCurve_OldCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAnimationFloatCurve_FunctionAddress, "OldCurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAnimationFloatCurve_NewCurveName_PropertyAddress, RenameAnimationFloatCurve_FunctionAddress, "NewCurveName");
		RenameAnimationFloatCurve_NewCurveName_Offset = NativeReflectionCached.GetPropertyOffset(RenameAnimationFloatCurve_FunctionAddress, "NewCurveName");
		RenameAnimationFloatCurve_NewCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAnimationFloatCurve_FunctionAddress, "NewCurveName", Classes.FNameProperty);
		RenameAnimationFloatCurve_IsValid = RenameAnimationFloatCurve_FunctionAddress != IntPtr.Zero && RenameAnimationFloatCurve_Animation_IsValid && RenameAnimationFloatCurve_OldCurveName_IsValid && RenameAnimationFloatCurve_NewCurveName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:RenameAnimationFloatCurve", RenameAnimationFloatCurve_IsValid);
		RemoveAnimationSyncMarkersByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationSyncMarkersByName");
		RemoveAnimationSyncMarkersByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationSyncMarkersByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByName_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName");
		RemoveAnimationSyncMarkersByName_MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName");
		RemoveAnimationSyncMarkersByName_MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAnimationSyncMarkersByName_IsValid = RemoveAnimationSyncMarkersByName_FunctionAddress != IntPtr.Zero && RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid && RemoveAnimationSyncMarkersByName_MarkerName_IsValid && RemoveAnimationSyncMarkersByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:RemoveAnimationSyncMarkersByName", RemoveAnimationSyncMarkersByName_IsValid);
		OutputSameSourceFileAnimList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OutputSameSourceFileAnimList");
		OutputSameSourceFileAnimList_ParamsSize = NativeReflection.GetFunctionParamsSize(OutputSameSourceFileAnimList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OutputSameSourceFileAnimList_AnimSearchPath_PropertyAddress, OutputSameSourceFileAnimList_FunctionAddress, "AnimSearchPath");
		OutputSameSourceFileAnimList_AnimSearchPath_Offset = NativeReflectionCached.GetPropertyOffset(OutputSameSourceFileAnimList_FunctionAddress, "AnimSearchPath");
		OutputSameSourceFileAnimList_AnimSearchPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OutputSameSourceFileAnimList_FunctionAddress, "AnimSearchPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputSameSourceFileAnimList_SelectedAssets_PropertyAddress, OutputSameSourceFileAnimList_FunctionAddress, "SelectedAssets");
		OutputSameSourceFileAnimList_SelectedAssets_Offset = NativeReflectionCached.GetPropertyOffset(OutputSameSourceFileAnimList_FunctionAddress, "SelectedAssets");
		OutputSameSourceFileAnimList_SelectedAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(OutputSameSourceFileAnimList_FunctionAddress, "SelectedAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputSameSourceFileAnimList_bOutputFullPath_PropertyAddress, OutputSameSourceFileAnimList_FunctionAddress, "bOutputFullPath");
		OutputSameSourceFileAnimList_bOutputFullPath_Offset = NativeReflectionCached.GetPropertyOffset(OutputSameSourceFileAnimList_FunctionAddress, "bOutputFullPath");
		OutputSameSourceFileAnimList_bOutputFullPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OutputSameSourceFileAnimList_FunctionAddress, "bOutputFullPath", Classes.FBoolProperty);
		OutputSameSourceFileAnimList_IsValid = OutputSameSourceFileAnimList_FunctionAddress != IntPtr.Zero && OutputSameSourceFileAnimList_AnimSearchPath_IsValid && OutputSameSourceFileAnimList_SelectedAssets_IsValid && OutputSameSourceFileAnimList_bOutputFullPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputSameSourceFileAnimList", OutputSameSourceFileAnimList_IsValid);
		OutputHaveSyncMarkerAnimList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OutputHaveSyncMarkerAnimList");
		OutputHaveSyncMarkerAnimList_ParamsSize = NativeReflection.GetFunctionParamsSize(OutputHaveSyncMarkerAnimList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OutputHaveSyncMarkerAnimList_SelectedAssets_PropertyAddress, OutputHaveSyncMarkerAnimList_FunctionAddress, "SelectedAssets");
		OutputHaveSyncMarkerAnimList_SelectedAssets_Offset = NativeReflectionCached.GetPropertyOffset(OutputHaveSyncMarkerAnimList_FunctionAddress, "SelectedAssets");
		OutputHaveSyncMarkerAnimList_SelectedAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(OutputHaveSyncMarkerAnimList_FunctionAddress, "SelectedAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputHaveSyncMarkerAnimList_bOutputFullPath_PropertyAddress, OutputHaveSyncMarkerAnimList_FunctionAddress, "bOutputFullPath");
		OutputHaveSyncMarkerAnimList_bOutputFullPath_Offset = NativeReflectionCached.GetPropertyOffset(OutputHaveSyncMarkerAnimList_FunctionAddress, "bOutputFullPath");
		OutputHaveSyncMarkerAnimList_bOutputFullPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OutputHaveSyncMarkerAnimList_FunctionAddress, "bOutputFullPath", Classes.FBoolProperty);
		OutputHaveSyncMarkerAnimList_IsValid = OutputHaveSyncMarkerAnimList_FunctionAddress != IntPtr.Zero && OutputHaveSyncMarkerAnimList_SelectedAssets_IsValid && OutputHaveSyncMarkerAnimList_bOutputFullPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:OutputHaveSyncMarkerAnimList", OutputHaveSyncMarkerAnimList_IsValid);
		IsValidAnimNotifyTrackName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAnimNotifyTrackName");
		IsValidAnimNotifyTrackName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAnimNotifyTrackName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_AnimationSequence_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequence");
		IsValidAnimNotifyTrackName_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequence");
		IsValidAnimNotifyTrackName_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName");
		IsValidAnimNotifyTrackName_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName");
		IsValidAnimNotifyTrackName_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue");
		IsValidAnimNotifyTrackName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue");
		IsValidAnimNotifyTrackName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAnimNotifyTrackName_IsValid = IsValidAnimNotifyTrackName_FunctionAddress != IntPtr.Zero && IsValidAnimNotifyTrackName_AnimationSequence_IsValid && IsValidAnimNotifyTrackName_NotifyTrackName_IsValid && IsValidAnimNotifyTrackName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:IsValidAnimNotifyTrackName", IsValidAnimNotifyTrackName_IsValid);
		GetFloatKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatKeys");
		GetFloatKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_Animation_PropertyAddress, GetFloatKeys_FunctionAddress, "Animation");
		GetFloatKeys_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "Animation");
		GetFloatKeys_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_CurveName_PropertyAddress, GetFloatKeys_FunctionAddress, "CurveName");
		GetFloatKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "CurveName");
		GetFloatKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_Times_PropertyAddress, GetFloatKeys_FunctionAddress, "Times");
		GetFloatKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "Times");
		GetFloatKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_Values_PropertyAddress, GetFloatKeys_FunctionAddress, "Values");
		GetFloatKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "Values");
		GetFloatKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		GetFloatKeys_IsValid = GetFloatKeys_FunctionAddress != IntPtr.Zero && GetFloatKeys_Animation_IsValid && GetFloatKeys_CurveName_IsValid && GetFloatKeys_Times_IsValid && GetFloatKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetFloatKeys", GetFloatKeys_IsValid);
		GetAnimationCurveNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationCurveNames");
		GetAnimationCurveNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationCurveNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_Animation_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "Animation");
		GetAnimationCurveNames_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "Animation");
		GetAnimationCurveNames_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_CurveType_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "CurveType");
		GetAnimationCurveNames_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "CurveType");
		GetAnimationCurveNames_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_CurveNames_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "CurveNames");
		GetAnimationCurveNames_CurveNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "CurveNames");
		GetAnimationCurveNames_CurveNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "CurveNames", Classes.FArrayProperty);
		GetAnimationCurveNames_IsValid = GetAnimationCurveNames_FunctionAddress != IntPtr.Zero && GetAnimationCurveNames_Animation_IsValid && GetAnimationCurveNames_CurveType_IsValid && GetAnimationCurveNames_CurveNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAnimationCurveNames", GetAnimationCurveNames_IsValid);
		GetAdditiveBasePoseType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAdditiveBasePoseType");
		GetAdditiveBasePoseType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditiveBasePoseType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveBasePoseType_AnimationSequence_PropertyAddress, GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		GetAdditiveBasePoseType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		GetAdditiveBasePoseType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress, GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		GetAdditiveBasePoseType_AdditiveBasePoseType_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType", Classes.FByteProperty);
		GetAdditiveBasePoseType_IsValid = GetAdditiveBasePoseType_FunctionAddress != IntPtr.Zero && GetAdditiveBasePoseType_AnimationSequence_IsValid && GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveBasePoseType", GetAdditiveBasePoseType_IsValid);
		GetAdditiveAnimationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAdditiveAnimationType");
		GetAdditiveAnimationType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditiveAnimationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveAnimationType_AnimationSequence_PropertyAddress, GetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		GetAdditiveAnimationType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		GetAdditiveAnimationType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveAnimationType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress, GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		GetAdditiveAnimationType_AdditiveAnimationType_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		GetAdditiveAnimationType_AdditiveAnimationType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType", Classes.FByteProperty);
		GetAdditiveAnimationType_IsValid = GetAdditiveAnimationType_FunctionAddress != IntPtr.Zero && GetAdditiveAnimationType_AnimationSequence_IsValid && GetAdditiveAnimationType_AdditiveAnimationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:GetAdditiveAnimationType", GetAdditiveAnimationType_IsValid);
		DoesCurveExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesCurveExist");
		DoesCurveExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesCurveExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_Animation_PropertyAddress, DoesCurveExist_FunctionAddress, "Animation");
		DoesCurveExist_Animation_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "Animation");
		DoesCurveExist_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_CurveName_PropertyAddress, DoesCurveExist_FunctionAddress, "CurveName");
		DoesCurveExist_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "CurveName");
		DoesCurveExist_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_CurveType_PropertyAddress, DoesCurveExist_FunctionAddress, "CurveType");
		DoesCurveExist_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "CurveType");
		DoesCurveExist_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_ReturnValue_PropertyAddress, DoesCurveExist_FunctionAddress, "ReturnValue");
		DoesCurveExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "ReturnValue");
		DoesCurveExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesCurveExist_IsValid = DoesCurveExist_FunctionAddress != IntPtr.Zero && DoesCurveExist_Animation_IsValid && DoesCurveExist_CurveName_IsValid && DoesCurveExist_CurveType_IsValid && DoesCurveExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:DoesCurveExist", DoesCurveExist_IsValid);
		CreateAnimFromPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAnimFromPreviewMesh");
		CreateAnimFromPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAnimFromPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAnimFromPreviewMesh_Animation_PropertyAddress, CreateAnimFromPreviewMesh_FunctionAddress, "Animation");
		CreateAnimFromPreviewMesh_Animation_Offset = NativeReflectionCached.GetPropertyOffset(CreateAnimFromPreviewMesh_FunctionAddress, "Animation");
		CreateAnimFromPreviewMesh_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAnimFromPreviewMesh_FunctionAddress, "Animation", Classes.FObjectProperty);
		CreateAnimFromPreviewMesh_IsValid = CreateAnimFromPreviewMesh_FunctionAddress != IntPtr.Zero && CreateAnimFromPreviewMesh_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CreateAnimFromPreviewMesh", CreateAnimFromPreviewMesh_IsValid);
		CopyMontageSlotData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMontageSlotData");
		CopyMontageSlotData_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMontageSlotData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMontageSlotData_SrcAnim_PropertyAddress, CopyMontageSlotData_FunctionAddress, "SrcAnim");
		CopyMontageSlotData_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyMontageSlotData_FunctionAddress, "SrcAnim");
		CopyMontageSlotData_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMontageSlotData_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMontageSlotData_DestAnim_PropertyAddress, CopyMontageSlotData_FunctionAddress, "DestAnim");
		CopyMontageSlotData_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyMontageSlotData_FunctionAddress, "DestAnim");
		CopyMontageSlotData_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMontageSlotData_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyMontageSlotData_IsValid = CopyMontageSlotData_FunctionAddress != IntPtr.Zero && CopyMontageSlotData_SrcAnim_IsValid && CopyMontageSlotData_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSlotData", CopyMontageSlotData_IsValid);
		CopyMontageSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMontageSections");
		CopyMontageSections_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMontageSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMontageSections_SrcAnim_PropertyAddress, CopyMontageSections_FunctionAddress, "SrcAnim");
		CopyMontageSections_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyMontageSections_FunctionAddress, "SrcAnim");
		CopyMontageSections_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMontageSections_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMontageSections_DestAnim_PropertyAddress, CopyMontageSections_FunctionAddress, "DestAnim");
		CopyMontageSections_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyMontageSections_FunctionAddress, "DestAnim");
		CopyMontageSections_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMontageSections_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyMontageSections_IsValid = CopyMontageSections_FunctionAddress != IntPtr.Zero && CopyMontageSections_SrcAnim_IsValid && CopyMontageSections_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyMontageSections", CopyMontageSections_IsValid);
		CopyBlendSpaceData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyBlendSpaceData");
		CopyBlendSpaceData_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyBlendSpaceData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyBlendSpaceData_SrcBS_PropertyAddress, CopyBlendSpaceData_FunctionAddress, "SrcBS");
		CopyBlendSpaceData_SrcBS_Offset = NativeReflectionCached.GetPropertyOffset(CopyBlendSpaceData_FunctionAddress, "SrcBS");
		CopyBlendSpaceData_SrcBS_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyBlendSpaceData_FunctionAddress, "SrcBS", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyBlendSpaceData_DestBS_PropertyAddress, CopyBlendSpaceData_FunctionAddress, "DestBS");
		CopyBlendSpaceData_DestBS_Offset = NativeReflectionCached.GetPropertyOffset(CopyBlendSpaceData_FunctionAddress, "DestBS");
		CopyBlendSpaceData_DestBS_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyBlendSpaceData_FunctionAddress, "DestBS", Classes.FObjectProperty);
		CopyBlendSpaceData_IsValid = CopyBlendSpaceData_FunctionAddress != IntPtr.Zero && CopyBlendSpaceData_SrcBS_IsValid && CopyBlendSpaceData_DestBS_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyBlendSpaceData", CopyBlendSpaceData_IsValid);
		CopyAnimationSyncMarker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimationSyncMarker");
		CopyAnimationSyncMarker_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimationSyncMarker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationSyncMarker_SrcAnim_PropertyAddress, CopyAnimationSyncMarker_FunctionAddress, "SrcAnim");
		CopyAnimationSyncMarker_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationSyncMarker_FunctionAddress, "SrcAnim");
		CopyAnimationSyncMarker_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationSyncMarker_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationSyncMarker_DestAnim_PropertyAddress, CopyAnimationSyncMarker_FunctionAddress, "DestAnim");
		CopyAnimationSyncMarker_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationSyncMarker_FunctionAddress, "DestAnim");
		CopyAnimationSyncMarker_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationSyncMarker_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyAnimationSyncMarker_IsValid = CopyAnimationSyncMarker_FunctionAddress != IntPtr.Zero && CopyAnimationSyncMarker_SrcAnim_IsValid && CopyAnimationSyncMarker_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationSyncMarker", CopyAnimationSyncMarker_IsValid);
		CopyAnimationRootMotionSetting_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimationRootMotionSetting");
		CopyAnimationRootMotionSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimationRootMotionSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationRootMotionSetting_SrcAnim_PropertyAddress, CopyAnimationRootMotionSetting_FunctionAddress, "SrcAnim");
		CopyAnimationRootMotionSetting_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationRootMotionSetting_FunctionAddress, "SrcAnim");
		CopyAnimationRootMotionSetting_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationRootMotionSetting_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationRootMotionSetting_DestAnim_PropertyAddress, CopyAnimationRootMotionSetting_FunctionAddress, "DestAnim");
		CopyAnimationRootMotionSetting_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationRootMotionSetting_FunctionAddress, "DestAnim");
		CopyAnimationRootMotionSetting_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationRootMotionSetting_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyAnimationRootMotionSetting_IsValid = CopyAnimationRootMotionSetting_FunctionAddress != IntPtr.Zero && CopyAnimationRootMotionSetting_SrcAnim_IsValid && CopyAnimationRootMotionSetting_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationRootMotionSetting", CopyAnimationRootMotionSetting_IsValid);
		CopyAnimationFloatCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimationFloatCurve");
		CopyAnimationFloatCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimationFloatCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationFloatCurve_SrcAnim_PropertyAddress, CopyAnimationFloatCurve_FunctionAddress, "SrcAnim");
		CopyAnimationFloatCurve_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationFloatCurve_FunctionAddress, "SrcAnim");
		CopyAnimationFloatCurve_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationFloatCurve_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationFloatCurve_DestAnim_PropertyAddress, CopyAnimationFloatCurve_FunctionAddress, "DestAnim");
		CopyAnimationFloatCurve_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationFloatCurve_FunctionAddress, "DestAnim");
		CopyAnimationFloatCurve_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationFloatCurve_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyAnimationFloatCurve_IsValid = CopyAnimationFloatCurve_FunctionAddress != IntPtr.Zero && CopyAnimationFloatCurve_SrcAnim_IsValid && CopyAnimationFloatCurve_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationFloatCurve", CopyAnimationFloatCurve_IsValid);
		CopyAnimationAdditiveSetting_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimationAdditiveSetting");
		CopyAnimationAdditiveSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimationAdditiveSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationAdditiveSetting_SrcAnim_PropertyAddress, CopyAnimationAdditiveSetting_FunctionAddress, "SrcAnim");
		CopyAnimationAdditiveSetting_SrcAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationAdditiveSetting_FunctionAddress, "SrcAnim");
		CopyAnimationAdditiveSetting_SrcAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationAdditiveSetting_FunctionAddress, "SrcAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationAdditiveSetting_DestAnim_PropertyAddress, CopyAnimationAdditiveSetting_FunctionAddress, "DestAnim");
		CopyAnimationAdditiveSetting_DestAnim_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationAdditiveSetting_FunctionAddress, "DestAnim");
		CopyAnimationAdditiveSetting_DestAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationAdditiveSetting_FunctionAddress, "DestAnim", Classes.FObjectProperty);
		CopyAnimationAdditiveSetting_IsValid = CopyAnimationAdditiveSetting_FunctionAddress != IntPtr.Zero && CopyAnimationAdditiveSetting_SrcAnim_IsValid && CopyAnimationAdditiveSetting_DestAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:CopyAnimationAdditiveSetting", CopyAnimationAdditiveSetting_IsValid);
		ApplyCompression_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyCompression");
		ApplyCompression_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyCompression_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyCompression_Animation_PropertyAddress, ApplyCompression_FunctionAddress, "Animation");
		ApplyCompression_Animation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyCompression_FunctionAddress, "Animation");
		ApplyCompression_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyCompression_FunctionAddress, "Animation", Classes.FObjectProperty);
		ApplyCompression_IsValid = ApplyCompression_FunctionAddress != IntPtr.Zero && ApplyCompression_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:ApplyCompression", ApplyCompression_IsValid);
		AddFloatCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFloatCurveKeys");
		AddFloatCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFloatCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_Animation_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "Animation");
		AddFloatCurveKeys_Animation_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "Animation");
		AddFloatCurveKeys_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_CurveName_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "CurveName");
		AddFloatCurveKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "CurveName");
		AddFloatCurveKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_Times_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "Times");
		AddFloatCurveKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "Times");
		AddFloatCurveKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_Values_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "Values");
		AddFloatCurveKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "Values");
		AddFloatCurveKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		AddFloatCurveKeys_IsValid = AddFloatCurveKeys_FunctionAddress != IntPtr.Zero && AddFloatCurveKeys_Animation_IsValid && AddFloatCurveKeys_CurveName_IsValid && AddFloatCurveKeys_Times_IsValid && AddFloatCurveKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddFloatCurveKeys", AddFloatCurveKeys_IsValid);
		AddCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddCurve");
		AddCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_Animation_PropertyAddress, AddCurve_FunctionAddress, "Animation");
		AddCurve_Animation_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "Animation");
		AddCurve_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveName_PropertyAddress, AddCurve_FunctionAddress, "CurveName");
		AddCurve_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveName");
		AddCurve_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveType_PropertyAddress, AddCurve_FunctionAddress, "CurveType");
		AddCurve_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveType");
		AddCurve_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_bMetaDataCurve_PropertyAddress, AddCurve_FunctionAddress, "bMetaDataCurve");
		AddCurve_bMetaDataCurve_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "bMetaDataCurve");
		AddCurve_bMetaDataCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "bMetaDataCurve", Classes.FBoolProperty);
		AddCurve_IsValid = AddCurve_FunctionAddress != IntPtr.Zero && AddCurve_Animation_IsValid && AddCurve_CurveName_IsValid && AddCurve_CurveType_IsValid && AddCurve_bMetaDataCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddCurve", AddCurve_IsValid);
		AddAnimationSyncMarker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationSyncMarker");
		AddAnimationSyncMarker_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationSyncMarker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_AnimationSequence_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "AnimationSequence");
		AddAnimationSyncMarker_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "AnimationSequence");
		AddAnimationSyncMarker_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_MarkerName_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "MarkerName");
		AddAnimationSyncMarker_MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "MarkerName");
		AddAnimationSyncMarker_MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "MarkerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_Time_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "Time");
		AddAnimationSyncMarker_Time_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "Time");
		AddAnimationSyncMarker_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_NotifyTrackName_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName");
		AddAnimationSyncMarker_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName");
		AddAnimationSyncMarker_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		AddAnimationSyncMarker_IsValid = AddAnimationSyncMarker_FunctionAddress != IntPtr.Zero && AddAnimationSyncMarker_AnimationSequence_IsValid && AddAnimationSyncMarker_MarkerName_IsValid && AddAnimationSyncMarker_Time_IsValid && AddAnimationSyncMarker_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationSyncMarker", AddAnimationSyncMarker_IsValid);
		AddAnimationNotifyTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyTrack");
		AddAnimationNotifyTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_AnimationSequence_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "AnimationSequence");
		AddAnimationNotifyTrack_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "AnimationSequence");
		AddAnimationNotifyTrack_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_TrackColor_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "TrackColor");
		AddAnimationNotifyTrack_TrackColor_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "TrackColor");
		AddAnimationNotifyTrack_TrackColor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "TrackColor", Classes.FStructProperty);
		AddAnimationNotifyTrack_IsValid = AddAnimationNotifyTrack_FunctionAddress != IntPtr.Zero && AddAnimationNotifyTrack_AnimationSequence_IsValid && AddAnimationNotifyTrack_NotifyTrackName_IsValid && AddAnimationNotifyTrack_TrackColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAnimationLibrary:AddAnimationNotifyTrack", AddAnimationNotifyTrack_IsValid);
	}
}
