using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateJobShotListFromSequence_IsValid;

	private static IntPtr UpdateJobShotListFromSequence_FunctionAddress;

	private static int UpdateJobShotListFromSequence_ParamsSize;

	private static bool UpdateJobShotListFromSequence_InSequence_IsValid;

	private static FFieldAddress UpdateJobShotListFromSequence_InSequence_PropertyAddress;

	private static int UpdateJobShotListFromSequence_InSequence_Offset;

	private static bool UpdateJobShotListFromSequence_InJob_IsValid;

	private static FFieldAddress UpdateJobShotListFromSequence_InJob_PropertyAddress;

	private static int UpdateJobShotListFromSequence_InJob_Offset;

	private static bool UpdateJobShotListFromSequence_bShotsChanged_IsValid;

	private static FFieldAddress UpdateJobShotListFromSequence_bShotsChanged_PropertyAddress;

	private static int UpdateJobShotListFromSequence_bShotsChanged_Offset;

	private static bool ResolveVersionNumber_IsValid;

	private static IntPtr ResolveVersionNumber_FunctionAddress;

	private static int ResolveVersionNumber_ParamsSize;

	private static bool ResolveVersionNumber_InParams_IsValid;

	private static FFieldAddress ResolveVersionNumber_InParams_PropertyAddress;

	private static int ResolveVersionNumber_InParams_Offset;

	private static bool ResolveVersionNumber_ReturnValue_IsValid;

	private static FFieldAddress ResolveVersionNumber_ReturnValue_PropertyAddress;

	private static int ResolveVersionNumber_ReturnValue_Offset;

	private static bool ResolveFilenameFormatArguments_IsValid;

	private static IntPtr ResolveFilenameFormatArguments_FunctionAddress;

	private static int ResolveFilenameFormatArguments_ParamsSize;

	private static bool ResolveFilenameFormatArguments_InFormatString_IsValid;

	private static FFieldAddress ResolveFilenameFormatArguments_InFormatString_PropertyAddress;

	private static int ResolveFilenameFormatArguments_InFormatString_Offset;

	private static bool ResolveFilenameFormatArguments_InParams_IsValid;

	private static FFieldAddress ResolveFilenameFormatArguments_InParams_PropertyAddress;

	private static int ResolveFilenameFormatArguments_InParams_Offset;

	private static bool ResolveFilenameFormatArguments_OutFinalPath_IsValid;

	private static FFieldAddress ResolveFilenameFormatArguments_OutFinalPath_PropertyAddress;

	private static int ResolveFilenameFormatArguments_OutFinalPath_Offset;

	private static bool ResolveFilenameFormatArguments_OutMergedFormatArgs_IsValid;

	private static FFieldAddress ResolveFilenameFormatArguments_OutMergedFormatArgs_PropertyAddress;

	private static int ResolveFilenameFormatArguments_OutMergedFormatArgs_Offset;

	private static bool LoadManifestFileFromString_IsValid;

	private static IntPtr LoadManifestFileFromString_FunctionAddress;

	private static int LoadManifestFileFromString_ParamsSize;

	private static bool LoadManifestFileFromString_InManifestFilePath_IsValid;

	private static FFieldAddress LoadManifestFileFromString_InManifestFilePath_PropertyAddress;

	private static int LoadManifestFileFromString_InManifestFilePath_Offset;

	private static bool LoadManifestFileFromString_ReturnValue_IsValid;

	private static FFieldAddress LoadManifestFileFromString_ReturnValue_PropertyAddress;

	private static int LoadManifestFileFromString_ReturnValue_Offset;

	private static bool GetPipelineState_IsValid;

	private static IntPtr GetPipelineState_FunctionAddress;

	private static int GetPipelineState_ParamsSize;

	private static bool GetPipelineState_InPipeline_IsValid;

	private static FFieldAddress GetPipelineState_InPipeline_PropertyAddress;

	private static int GetPipelineState_InPipeline_Offset;

	private static bool GetPipelineState_ReturnValue_IsValid;

	private static FFieldAddress GetPipelineState_ReturnValue_PropertyAddress;

	private static int GetPipelineState_ReturnValue_Offset;

	private static bool GetOverallSegmentCounts_IsValid;

	private static IntPtr GetOverallSegmentCounts_FunctionAddress;

	private static int GetOverallSegmentCounts_ParamsSize;

	private static bool GetOverallSegmentCounts_InMoviePipeline_IsValid;

	private static FFieldAddress GetOverallSegmentCounts_InMoviePipeline_PropertyAddress;

	private static int GetOverallSegmentCounts_InMoviePipeline_Offset;

	private static bool GetOverallSegmentCounts_OutCurrentIndex_IsValid;

	private static FFieldAddress GetOverallSegmentCounts_OutCurrentIndex_PropertyAddress;

	private static int GetOverallSegmentCounts_OutCurrentIndex_Offset;

	private static bool GetOverallSegmentCounts_OutTotalCount_IsValid;

	private static FFieldAddress GetOverallSegmentCounts_OutTotalCount_PropertyAddress;

	private static int GetOverallSegmentCounts_OutTotalCount_Offset;

	private static bool GetOverallOutputFrames_IsValid;

	private static IntPtr GetOverallOutputFrames_FunctionAddress;

	private static int GetOverallOutputFrames_ParamsSize;

	private static bool GetOverallOutputFrames_InMoviePipeline_IsValid;

	private static FFieldAddress GetOverallOutputFrames_InMoviePipeline_PropertyAddress;

	private static int GetOverallOutputFrames_InMoviePipeline_Offset;

	private static bool GetOverallOutputFrames_OutCurrentIndex_IsValid;

	private static FFieldAddress GetOverallOutputFrames_OutCurrentIndex_PropertyAddress;

	private static int GetOverallOutputFrames_OutCurrentIndex_Offset;

	private static bool GetOverallOutputFrames_OutTotalCount_IsValid;

	private static FFieldAddress GetOverallOutputFrames_OutTotalCount_PropertyAddress;

	private static int GetOverallOutputFrames_OutTotalCount_Offset;

	private static bool GetMoviePipelineEngineChangelistLabel_IsValid;

	private static IntPtr GetMoviePipelineEngineChangelistLabel_FunctionAddress;

	private static int GetMoviePipelineEngineChangelistLabel_ParamsSize;

	private static bool GetMoviePipelineEngineChangelistLabel_InMoviePipeline_IsValid;

	private static FFieldAddress GetMoviePipelineEngineChangelistLabel_InMoviePipeline_PropertyAddress;

	private static int GetMoviePipelineEngineChangelistLabel_InMoviePipeline_Offset;

	private static bool GetMoviePipelineEngineChangelistLabel_ReturnValue_IsValid;

	private static FFieldAddress GetMoviePipelineEngineChangelistLabel_ReturnValue_PropertyAddress;

	private static int GetMoviePipelineEngineChangelistLabel_ReturnValue_Offset;

	private static bool GetMasterTimecode_IsValid;

	private static IntPtr GetMasterTimecode_FunctionAddress;

	private static int GetMasterTimecode_ParamsSize;

	private static bool GetMasterTimecode_InMoviePipeline_IsValid;

	private static FFieldAddress GetMasterTimecode_InMoviePipeline_PropertyAddress;

	private static int GetMasterTimecode_InMoviePipeline_Offset;

	private static bool GetMasterTimecode_ReturnValue_IsValid;

	private static FFieldAddress GetMasterTimecode_ReturnValue_PropertyAddress;

	private static int GetMasterTimecode_ReturnValue_Offset;

	private static bool GetMasterFrameNumber_IsValid;

	private static IntPtr GetMasterFrameNumber_FunctionAddress;

	private static int GetMasterFrameNumber_ParamsSize;

	private static bool GetMasterFrameNumber_InMoviePipeline_IsValid;

	private static FFieldAddress GetMasterFrameNumber_InMoviePipeline_PropertyAddress;

	private static int GetMasterFrameNumber_InMoviePipeline_Offset;

	private static bool GetMasterFrameNumber_ReturnValue_IsValid;

	private static FFieldAddress GetMasterFrameNumber_ReturnValue_PropertyAddress;

	private static int GetMasterFrameNumber_ReturnValue_Offset;

	private static bool GetMapPackageName_IsValid;

	private static IntPtr GetMapPackageName_FunctionAddress;

	private static int GetMapPackageName_ParamsSize;

	private static bool GetMapPackageName_InJob_IsValid;

	private static FFieldAddress GetMapPackageName_InJob_PropertyAddress;

	private static int GetMapPackageName_InJob_Offset;

	private static bool GetMapPackageName_ReturnValue_IsValid;

	private static FFieldAddress GetMapPackageName_ReturnValue_PropertyAddress;

	private static int GetMapPackageName_ReturnValue_Offset;

	private static bool GetJobName_IsValid;

	private static IntPtr GetJobName_FunctionAddress;

	private static int GetJobName_ParamsSize;

	private static bool GetJobName_InMoviePipeline_IsValid;

	private static FFieldAddress GetJobName_InMoviePipeline_PropertyAddress;

	private static int GetJobName_InMoviePipeline_Offset;

	private static bool GetJobName_ReturnValue_IsValid;

	private static FFieldAddress GetJobName_ReturnValue_PropertyAddress;

	private static int GetJobName_ReturnValue_Offset;

	private static bool GetJobInitializationTime_IsValid;

	private static IntPtr GetJobInitializationTime_FunctionAddress;

	private static int GetJobInitializationTime_ParamsSize;

	private static bool GetJobInitializationTime_InMoviePipeline_IsValid;

	private static FFieldAddress GetJobInitializationTime_InMoviePipeline_PropertyAddress;

	private static int GetJobInitializationTime_InMoviePipeline_Offset;

	private static bool GetJobInitializationTime_ReturnValue_IsValid;

	private static FFieldAddress GetJobInitializationTime_ReturnValue_PropertyAddress;

	private static int GetJobInitializationTime_ReturnValue_Offset;

	private static bool GetJobAuthor_IsValid;

	private static IntPtr GetJobAuthor_FunctionAddress;

	private static int GetJobAuthor_ParamsSize;

	private static bool GetJobAuthor_InMoviePipeline_IsValid;

	private static FFieldAddress GetJobAuthor_InMoviePipeline_PropertyAddress;

	private static int GetJobAuthor_InMoviePipeline_Offset;

	private static bool GetJobAuthor_ReturnValue_IsValid;

	private static FFieldAddress GetJobAuthor_ReturnValue_PropertyAddress;

	private static int GetJobAuthor_ReturnValue_Offset;

	private static bool GetEstimatedTimeRemaining_IsValid;

	private static IntPtr GetEstimatedTimeRemaining_FunctionAddress;

	private static int GetEstimatedTimeRemaining_ParamsSize;

	private static bool GetEstimatedTimeRemaining_InPipeline_IsValid;

	private static FFieldAddress GetEstimatedTimeRemaining_InPipeline_PropertyAddress;

	private static int GetEstimatedTimeRemaining_InPipeline_Offset;

	private static bool GetEstimatedTimeRemaining_OutEstimate_IsValid;

	private static FFieldAddress GetEstimatedTimeRemaining_OutEstimate_PropertyAddress;

	private static int GetEstimatedTimeRemaining_OutEstimate_Offset;

	private static bool GetEstimatedTimeRemaining_ReturnValue_IsValid;

	private static FFieldAddress GetEstimatedTimeRemaining_ReturnValue_PropertyAddress;

	private static int GetEstimatedTimeRemaining_ReturnValue_Offset;

	private static bool GetEffectiveOutputResolution_IsValid;

	private static IntPtr GetEffectiveOutputResolution_FunctionAddress;

	private static int GetEffectiveOutputResolution_ParamsSize;

	private static bool GetEffectiveOutputResolution_InMasterConfig_IsValid;

	private static FFieldAddress GetEffectiveOutputResolution_InMasterConfig_PropertyAddress;

	private static int GetEffectiveOutputResolution_InMasterConfig_Offset;

	private static bool GetEffectiveOutputResolution_InPipelineExecutorShot_IsValid;

	private static FFieldAddress GetEffectiveOutputResolution_InPipelineExecutorShot_PropertyAddress;

	private static int GetEffectiveOutputResolution_InPipelineExecutorShot_Offset;

	private static bool GetEffectiveOutputResolution_ReturnValue_IsValid;

	private static FFieldAddress GetEffectiveOutputResolution_ReturnValue_PropertyAddress;

	private static int GetEffectiveOutputResolution_ReturnValue_Offset;

	private static bool GetCurrentShotTimecode_IsValid;

	private static IntPtr GetCurrentShotTimecode_FunctionAddress;

	private static int GetCurrentShotTimecode_ParamsSize;

	private static bool GetCurrentShotTimecode_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentShotTimecode_InMoviePipeline_PropertyAddress;

	private static int GetCurrentShotTimecode_InMoviePipeline_Offset;

	private static bool GetCurrentShotTimecode_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentShotTimecode_ReturnValue_PropertyAddress;

	private static int GetCurrentShotTimecode_ReturnValue_Offset;

	private static bool GetCurrentShotFrameNumber_IsValid;

	private static IntPtr GetCurrentShotFrameNumber_FunctionAddress;

	private static int GetCurrentShotFrameNumber_ParamsSize;

	private static bool GetCurrentShotFrameNumber_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentShotFrameNumber_InMoviePipeline_PropertyAddress;

	private static int GetCurrentShotFrameNumber_InMoviePipeline_Offset;

	private static bool GetCurrentShotFrameNumber_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentShotFrameNumber_ReturnValue_PropertyAddress;

	private static int GetCurrentShotFrameNumber_ReturnValue_Offset;

	private static bool GetCurrentSequence_IsValid;

	private static IntPtr GetCurrentSequence_FunctionAddress;

	private static int GetCurrentSequence_ParamsSize;

	private static bool GetCurrentSequence_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentSequence_InMoviePipeline_PropertyAddress;

	private static int GetCurrentSequence_InMoviePipeline_Offset;

	private static bool GetCurrentSequence_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSequence_ReturnValue_PropertyAddress;

	private static int GetCurrentSequence_ReturnValue_Offset;

	private static bool GetCurrentSegmentWorkMetrics_IsValid;

	private static IntPtr GetCurrentSegmentWorkMetrics_FunctionAddress;

	private static int GetCurrentSegmentWorkMetrics_ParamsSize;

	private static bool GetCurrentSegmentWorkMetrics_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentSegmentWorkMetrics_InMoviePipeline_PropertyAddress;

	private static int GetCurrentSegmentWorkMetrics_InMoviePipeline_Offset;

	private static bool GetCurrentSegmentWorkMetrics_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSegmentWorkMetrics_ReturnValue_PropertyAddress;

	private static int GetCurrentSegmentWorkMetrics_ReturnValue_Offset;

	private static bool GetCurrentSegmentState_IsValid;

	private static IntPtr GetCurrentSegmentState_FunctionAddress;

	private static int GetCurrentSegmentState_ParamsSize;

	private static bool GetCurrentSegmentState_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentSegmentState_InMoviePipeline_PropertyAddress;

	private static int GetCurrentSegmentState_InMoviePipeline_Offset;

	private static bool GetCurrentSegmentState_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSegmentState_ReturnValue_PropertyAddress;

	private static int GetCurrentSegmentState_ReturnValue_Offset;

	private static bool GetCurrentSegmentName_IsValid;

	private static IntPtr GetCurrentSegmentName_FunctionAddress;

	private static int GetCurrentSegmentName_ParamsSize;

	private static bool GetCurrentSegmentName_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentSegmentName_InMoviePipeline_PropertyAddress;

	private static int GetCurrentSegmentName_InMoviePipeline_Offset;

	private static bool GetCurrentSegmentName_OutOuterName_IsValid;

	private static FFieldAddress GetCurrentSegmentName_OutOuterName_PropertyAddress;

	private static int GetCurrentSegmentName_OutOuterName_Offset;

	private static bool GetCurrentSegmentName_OutInnerName_IsValid;

	private static FFieldAddress GetCurrentSegmentName_OutInnerName_PropertyAddress;

	private static int GetCurrentSegmentName_OutInnerName_Offset;

	private static bool GetCurrentFocusDistance_IsValid;

	private static IntPtr GetCurrentFocusDistance_FunctionAddress;

	private static int GetCurrentFocusDistance_ParamsSize;

	private static bool GetCurrentFocusDistance_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentFocusDistance_InMoviePipeline_PropertyAddress;

	private static int GetCurrentFocusDistance_InMoviePipeline_Offset;

	private static bool GetCurrentFocusDistance_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFocusDistance_ReturnValue_PropertyAddress;

	private static int GetCurrentFocusDistance_ReturnValue_Offset;

	private static bool GetCurrentFocalLength_IsValid;

	private static IntPtr GetCurrentFocalLength_FunctionAddress;

	private static int GetCurrentFocalLength_ParamsSize;

	private static bool GetCurrentFocalLength_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentFocalLength_InMoviePipeline_PropertyAddress;

	private static int GetCurrentFocalLength_InMoviePipeline_Offset;

	private static bool GetCurrentFocalLength_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFocalLength_ReturnValue_PropertyAddress;

	private static int GetCurrentFocalLength_ReturnValue_Offset;

	private static bool GetCurrentExecutorShot_IsValid;

	private static IntPtr GetCurrentExecutorShot_FunctionAddress;

	private static int GetCurrentExecutorShot_ParamsSize;

	private static bool GetCurrentExecutorShot_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentExecutorShot_InMoviePipeline_PropertyAddress;

	private static int GetCurrentExecutorShot_InMoviePipeline_Offset;

	private static bool GetCurrentExecutorShot_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentExecutorShot_ReturnValue_PropertyAddress;

	private static int GetCurrentExecutorShot_ReturnValue_Offset;

	private static bool GetCurrentAperture_IsValid;

	private static IntPtr GetCurrentAperture_FunctionAddress;

	private static int GetCurrentAperture_ParamsSize;

	private static bool GetCurrentAperture_InMoviePipeline_IsValid;

	private static FFieldAddress GetCurrentAperture_InMoviePipeline_PropertyAddress;

	private static int GetCurrentAperture_InMoviePipeline_Offset;

	private static bool GetCurrentAperture_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentAperture_ReturnValue_PropertyAddress;

	private static int GetCurrentAperture_ReturnValue_Offset;

	private static bool GetCompletionPercentage_IsValid;

	private static IntPtr GetCompletionPercentage_FunctionAddress;

	private static int GetCompletionPercentage_ParamsSize;

	private static bool GetCompletionPercentage_InPipeline_IsValid;

	private static FFieldAddress GetCompletionPercentage_InPipeline_PropertyAddress;

	private static int GetCompletionPercentage_InPipeline_Offset;

	private static bool GetCompletionPercentage_ReturnValue_IsValid;

	private static FFieldAddress GetCompletionPercentage_ReturnValue_PropertyAddress;

	private static int GetCompletionPercentage_ReturnValue_Offset;

	private static bool FindOrGetDefaultSettingForShot_IsValid;

	private static IntPtr FindOrGetDefaultSettingForShot_FunctionAddress;

	private static int FindOrGetDefaultSettingForShot_ParamsSize;

	private static bool FindOrGetDefaultSettingForShot_InSettingType_IsValid;

	private static FFieldAddress FindOrGetDefaultSettingForShot_InSettingType_PropertyAddress;

	private static int FindOrGetDefaultSettingForShot_InSettingType_Offset;

	private static bool FindOrGetDefaultSettingForShot_InMasterConfig_IsValid;

	private static FFieldAddress FindOrGetDefaultSettingForShot_InMasterConfig_PropertyAddress;

	private static int FindOrGetDefaultSettingForShot_InMasterConfig_Offset;

	private static bool FindOrGetDefaultSettingForShot_InShot_IsValid;

	private static FFieldAddress FindOrGetDefaultSettingForShot_InShot_PropertyAddress;

	private static int FindOrGetDefaultSettingForShot_InShot_Offset;

	private static bool FindOrGetDefaultSettingForShot_ReturnValue_IsValid;

	private static FFieldAddress FindOrGetDefaultSettingForShot_ReturnValue_PropertyAddress;

	private static int FindOrGetDefaultSettingForShot_ReturnValue_Offset;

	private static bool DuplicateSequence_IsValid;

	private static IntPtr DuplicateSequence_FunctionAddress;

	private static int DuplicateSequence_ParamsSize;

	private static bool DuplicateSequence_Outer_IsValid;

	private static FFieldAddress DuplicateSequence_Outer_PropertyAddress;

	private static int DuplicateSequence_Outer_Offset;

	private static bool DuplicateSequence_InSequence_IsValid;

	private static FFieldAddress DuplicateSequence_InSequence_PropertyAddress;

	private static int DuplicateSequence_InSequence_Offset;

	private static bool DuplicateSequence_ReturnValue_IsValid;

	private static FFieldAddress DuplicateSequence_ReturnValue_PropertyAddress;

	private static int DuplicateSequence_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:UpdateJobShotListFromSequence")]
	public unsafe static void UpdateJobShotListFromSequence(ULevelSequence InSequence, UMoviePipelineExecutorJob InJob, out bool bShotsChanged)
	{
		if (!UpdateJobShotListFromSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:UpdateJobShotListFromSequence");
			bShotsChanged = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateJobShotListFromSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateJobShotListFromSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, UpdateJobShotListFromSequence_InSequence_Offset), 0, UpdateJobShotListFromSequence_InSequence_PropertyAddress.Address, InSequence);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, UpdateJobShotListFromSequence_InJob_Offset), 0, UpdateJobShotListFromSequence_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateJobShotListFromSequence_FunctionAddress, intPtr, UpdateJobShotListFromSequence_ParamsSize);
		bShotsChanged = BoolMarshaler.FromNative(IntPtr.Add(intPtr, UpdateJobShotListFromSequence_bShotsChanged_Offset), 0, UpdateJobShotListFromSequence_bShotsChanged_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveVersionNumber")]
	public unsafe static int ResolveVersionNumber(FMoviePipelineFilenameResolveParams InParams)
	{
		if (!ResolveVersionNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveVersionNumber");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveVersionNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveVersionNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ResolveVersionNumber_InParams_PropertyAddress.Address, intPtr);
		FMoviePipelineFilenameResolveParams.ToNative(IntPtr.Add(intPtr, ResolveVersionNumber_InParams_Offset), 0, ResolveVersionNumber_InParams_PropertyAddress.Address, InParams);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResolveVersionNumber_FunctionAddress, intPtr, ResolveVersionNumber_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResolveVersionNumber_InParams_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ResolveVersionNumber_ReturnValue_Offset), 0, ResolveVersionNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveFilenameFormatArguments")]
	public unsafe static void ResolveFilenameFormatArguments(string InFormatString, FMoviePipelineFilenameResolveParams InParams, out string OutFinalPath, out FMoviePipelineFormatArgs OutMergedFormatArgs)
	{
		if (!ResolveFilenameFormatArguments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveFilenameFormatArguments");
			OutFinalPath = FStringMarshaler.DefaultString;
			OutMergedFormatArgs = default(FMoviePipelineFormatArgs);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveFilenameFormatArguments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveFilenameFormatArguments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ResolveFilenameFormatArguments_InFormatString_Offset), 0, ResolveFilenameFormatArguments_InFormatString_PropertyAddress.Address, InFormatString);
		NativeReflection.InitializeValue_InContainer(ResolveFilenameFormatArguments_InParams_PropertyAddress.Address, intPtr);
		FMoviePipelineFilenameResolveParams.ToNative(IntPtr.Add(intPtr, ResolveFilenameFormatArguments_InParams_Offset), 0, ResolveFilenameFormatArguments_InParams_PropertyAddress.Address, InParams);
		NativeReflection.InitializeValue_InContainer(ResolveFilenameFormatArguments_OutMergedFormatArgs_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResolveFilenameFormatArguments_FunctionAddress, intPtr, ResolveFilenameFormatArguments_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResolveFilenameFormatArguments_InFormatString_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ResolveFilenameFormatArguments_InParams_PropertyAddress.Address, intPtr);
		OutFinalPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ResolveFilenameFormatArguments_OutFinalPath_Offset), 0, ResolveFilenameFormatArguments_OutFinalPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ResolveFilenameFormatArguments_OutFinalPath_PropertyAddress.Address, intPtr);
		OutMergedFormatArgs = FMoviePipelineFormatArgs.FromNative(IntPtr.Add(intPtr, ResolveFilenameFormatArguments_OutMergedFormatArgs_Offset), 0, ResolveFilenameFormatArguments_OutMergedFormatArgs_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ResolveFilenameFormatArguments_OutMergedFormatArgs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:LoadManifestFileFromString")]
	public unsafe static UMoviePipelineQueue LoadManifestFileFromString(string InManifestFilePath)
	{
		if (!LoadManifestFileFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:LoadManifestFileFromString");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadManifestFileFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadManifestFileFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadManifestFileFromString_InManifestFilePath_Offset), 0, LoadManifestFileFromString_InManifestFilePath_PropertyAddress.Address, InManifestFilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadManifestFileFromString_FunctionAddress, intPtr, LoadManifestFileFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadManifestFileFromString_InManifestFilePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMoviePipelineQueue>.FromNative(IntPtr.Add(intPtr, LoadManifestFileFromString_ReturnValue_Offset), 0, LoadManifestFileFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetPipelineState")]
	public unsafe static EMovieRenderPipelineState GetPipelineState(UMoviePipeline InPipeline)
	{
		if (!GetPipelineState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetPipelineState");
			return EMovieRenderPipelineState.Uninitialized;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPipelineState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPipelineState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetPipelineState_InPipeline_Offset), 0, GetPipelineState_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPipelineState_FunctionAddress, intPtr, GetPipelineState_ParamsSize);
		return EnumMarshaler<EMovieRenderPipelineState>.FromNative(IntPtr.Add(intPtr, GetPipelineState_ReturnValue_Offset), 0, GetPipelineState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallSegmentCounts")]
	public unsafe static void GetOverallSegmentCounts(UMoviePipeline InMoviePipeline, out int OutCurrentIndex, out int OutTotalCount)
	{
		if (!GetOverallSegmentCounts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallSegmentCounts");
			OutCurrentIndex = 0;
			OutTotalCount = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverallSegmentCounts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverallSegmentCounts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetOverallSegmentCounts_InMoviePipeline_Offset), 0, GetOverallSegmentCounts_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOverallSegmentCounts_FunctionAddress, intPtr, GetOverallSegmentCounts_ParamsSize);
		OutCurrentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverallSegmentCounts_OutCurrentIndex_Offset), 0, GetOverallSegmentCounts_OutCurrentIndex_PropertyAddress.Address);
		OutTotalCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverallSegmentCounts_OutTotalCount_Offset), 0, GetOverallSegmentCounts_OutTotalCount_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallOutputFrames")]
	public unsafe static void GetOverallOutputFrames(UMoviePipeline InMoviePipeline, out int OutCurrentIndex, out int OutTotalCount)
	{
		if (!GetOverallOutputFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallOutputFrames");
			OutCurrentIndex = 0;
			OutTotalCount = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverallOutputFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverallOutputFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetOverallOutputFrames_InMoviePipeline_Offset), 0, GetOverallOutputFrames_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOverallOutputFrames_FunctionAddress, intPtr, GetOverallOutputFrames_ParamsSize);
		OutCurrentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverallOutputFrames_OutCurrentIndex_Offset), 0, GetOverallOutputFrames_OutCurrentIndex_PropertyAddress.Address);
		OutTotalCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverallOutputFrames_OutTotalCount_Offset), 0, GetOverallOutputFrames_OutTotalCount_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMoviePipelineEngineChangelistLabel")]
	public unsafe static string GetMoviePipelineEngineChangelistLabel(UMoviePipeline InMoviePipeline)
	{
		if (!GetMoviePipelineEngineChangelistLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMoviePipelineEngineChangelistLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMoviePipelineEngineChangelistLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMoviePipelineEngineChangelistLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetMoviePipelineEngineChangelistLabel_InMoviePipeline_Offset), 0, GetMoviePipelineEngineChangelistLabel_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMoviePipelineEngineChangelistLabel_FunctionAddress, intPtr, GetMoviePipelineEngineChangelistLabel_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetMoviePipelineEngineChangelistLabel_ReturnValue_Offset), 0, GetMoviePipelineEngineChangelistLabel_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetMoviePipelineEngineChangelistLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterTimecode")]
	public unsafe static FTimecode GetMasterTimecode(UMoviePipeline InMoviePipeline)
	{
		if (!GetMasterTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterTimecode");
			return default(FTimecode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMasterTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMasterTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetMasterTimecode_InMoviePipeline_Offset), 0, GetMasterTimecode_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMasterTimecode_FunctionAddress, intPtr, GetMasterTimecode_ParamsSize);
		return FTimecode.FromNative(IntPtr.Add(intPtr, GetMasterTimecode_ReturnValue_Offset), 0, GetMasterTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterFrameNumber")]
	public unsafe static FFrameNumber GetMasterFrameNumber(UMoviePipeline InMoviePipeline)
	{
		if (!GetMasterFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterFrameNumber");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMasterFrameNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMasterFrameNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetMasterFrameNumber_InMoviePipeline_Offset), 0, GetMasterFrameNumber_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMasterFrameNumber_FunctionAddress, intPtr, GetMasterFrameNumber_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, GetMasterFrameNumber_ReturnValue_Offset), 0, GetMasterFrameNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMapPackageName")]
	public unsafe static string GetMapPackageName(UMoviePipelineExecutorJob InJob)
	{
		if (!GetMapPackageName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMapPackageName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMapPackageName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMapPackageName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, GetMapPackageName_InJob_Offset), 0, GetMapPackageName_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMapPackageName_FunctionAddress, intPtr, GetMapPackageName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMapPackageName_ReturnValue_Offset), 0, GetMapPackageName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMapPackageName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobName")]
	public unsafe static string GetJobName(UMoviePipeline InMoviePipeline)
	{
		if (!GetJobName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJobName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJobName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetJobName_InMoviePipeline_Offset), 0, GetJobName_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetJobName_FunctionAddress, intPtr, GetJobName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetJobName_ReturnValue_Offset), 0, GetJobName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetJobName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobInitializationTime")]
	public unsafe static FDateTime GetJobInitializationTime(UMoviePipeline InMoviePipeline)
	{
		if (!GetJobInitializationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobInitializationTime");
			return default(FDateTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJobInitializationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJobInitializationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetJobInitializationTime_InMoviePipeline_Offset), 0, GetJobInitializationTime_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetJobInitializationTime_FunctionAddress, intPtr, GetJobInitializationTime_ParamsSize);
		return FDateTime.FromNative(IntPtr.Add(intPtr, GetJobInitializationTime_ReturnValue_Offset), 0, GetJobInitializationTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobAuthor")]
	public unsafe static string GetJobAuthor(UMoviePipeline InMoviePipeline)
	{
		if (!GetJobAuthor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobAuthor");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJobAuthor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJobAuthor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetJobAuthor_InMoviePipeline_Offset), 0, GetJobAuthor_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetJobAuthor_FunctionAddress, intPtr, GetJobAuthor_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetJobAuthor_ReturnValue_Offset), 0, GetJobAuthor_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetJobAuthor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEstimatedTimeRemaining")]
	public unsafe static bool GetEstimatedTimeRemaining(UMoviePipeline InPipeline, out FTimespan OutEstimate)
	{
		if (!GetEstimatedTimeRemaining_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEstimatedTimeRemaining");
			OutEstimate = default(FTimespan);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEstimatedTimeRemaining_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEstimatedTimeRemaining_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetEstimatedTimeRemaining_InPipeline_Offset), 0, GetEstimatedTimeRemaining_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEstimatedTimeRemaining_FunctionAddress, intPtr, GetEstimatedTimeRemaining_ParamsSize);
		OutEstimate = FTimespan.FromNative(IntPtr.Add(intPtr, GetEstimatedTimeRemaining_OutEstimate_Offset), 0, GetEstimatedTimeRemaining_OutEstimate_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEstimatedTimeRemaining_ReturnValue_Offset), 0, GetEstimatedTimeRemaining_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEffectiveOutputResolution")]
	public unsafe static FIntPoint GetEffectiveOutputResolution(UMoviePipelineMasterConfig InMasterConfig, UMoviePipelineExecutorShot InPipelineExecutorShot)
	{
		if (!GetEffectiveOutputResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEffectiveOutputResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEffectiveOutputResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEffectiveOutputResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(intPtr, GetEffectiveOutputResolution_InMasterConfig_Offset), 0, GetEffectiveOutputResolution_InMasterConfig_PropertyAddress.Address, InMasterConfig);
		UObjectMarshaler<UMoviePipelineExecutorShot>.ToNative(IntPtr.Add(intPtr, GetEffectiveOutputResolution_InPipelineExecutorShot_Offset), 0, GetEffectiveOutputResolution_InPipelineExecutorShot_PropertyAddress.Address, InPipelineExecutorShot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEffectiveOutputResolution_FunctionAddress, intPtr, GetEffectiveOutputResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetEffectiveOutputResolution_ReturnValue_Offset), 0, GetEffectiveOutputResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotTimecode")]
	public unsafe static FTimecode GetCurrentShotTimecode(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentShotTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotTimecode");
			return default(FTimecode);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentShotTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentShotTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentShotTimecode_InMoviePipeline_Offset), 0, GetCurrentShotTimecode_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentShotTimecode_FunctionAddress, intPtr, GetCurrentShotTimecode_ParamsSize);
		return FTimecode.FromNative(IntPtr.Add(intPtr, GetCurrentShotTimecode_ReturnValue_Offset), 0, GetCurrentShotTimecode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotFrameNumber")]
	public unsafe static FFrameNumber GetCurrentShotFrameNumber(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentShotFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotFrameNumber");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentShotFrameNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentShotFrameNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentShotFrameNumber_InMoviePipeline_Offset), 0, GetCurrentShotFrameNumber_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentShotFrameNumber_FunctionAddress, intPtr, GetCurrentShotFrameNumber_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, GetCurrentShotFrameNumber_ReturnValue_Offset), 0, GetCurrentShotFrameNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSequence")]
	public unsafe static ULevelSequence GetCurrentSequence(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentSequence_InMoviePipeline_Offset), 0, GetCurrentSequence_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentSequence_FunctionAddress, intPtr, GetCurrentSequence_ParamsSize);
		return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(intPtr, GetCurrentSequence_ReturnValue_Offset), 0, GetCurrentSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentWorkMetrics")]
	public unsafe static FMoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentSegmentWorkMetrics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentWorkMetrics");
			return default(FMoviePipelineSegmentWorkMetrics);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSegmentWorkMetrics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSegmentWorkMetrics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentSegmentWorkMetrics_InMoviePipeline_Offset), 0, GetCurrentSegmentWorkMetrics_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentSegmentWorkMetrics_FunctionAddress, intPtr, GetCurrentSegmentWorkMetrics_ParamsSize);
		FMoviePipelineSegmentWorkMetrics result = FMoviePipelineSegmentWorkMetrics.FromNative(IntPtr.Add(intPtr, GetCurrentSegmentWorkMetrics_ReturnValue_Offset), 0, GetCurrentSegmentWorkMetrics_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentSegmentWorkMetrics_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentState")]
	public unsafe static EMovieRenderShotState GetCurrentSegmentState(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentSegmentState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentState");
			return EMovieRenderShotState.Uninitialized;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSegmentState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSegmentState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentSegmentState_InMoviePipeline_Offset), 0, GetCurrentSegmentState_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentSegmentState_FunctionAddress, intPtr, GetCurrentSegmentState_ParamsSize);
		return EnumMarshaler<EMovieRenderShotState>.FromNative(IntPtr.Add(intPtr, GetCurrentSegmentState_ReturnValue_Offset), 0, GetCurrentSegmentState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentName")]
	public unsafe static void GetCurrentSegmentName(UMoviePipeline InMoviePipeline, out FText OutOuterName, out FText OutInnerName)
	{
		if (!GetCurrentSegmentName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentName");
			OutOuterName = null;
			OutInnerName = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSegmentName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSegmentName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentSegmentName_InMoviePipeline_Offset), 0, GetCurrentSegmentName_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InitializeValue_InContainer(GetCurrentSegmentName_OutOuterName_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetCurrentSegmentName_OutInnerName_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentSegmentName_FunctionAddress, intPtr, GetCurrentSegmentName_ParamsSize);
		OutOuterName = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentSegmentName_OutOuterName_Offset), 0, GetCurrentSegmentName_OutOuterName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentSegmentName_OutOuterName_PropertyAddress.Address, intPtr);
		OutInnerName = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentSegmentName_OutInnerName_Offset), 0, GetCurrentSegmentName_OutInnerName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentSegmentName_OutInnerName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocusDistance")]
	public unsafe static float GetCurrentFocusDistance(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentFocusDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocusDistance");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFocusDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFocusDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentFocusDistance_InMoviePipeline_Offset), 0, GetCurrentFocusDistance_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentFocusDistance_FunctionAddress, intPtr, GetCurrentFocusDistance_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentFocusDistance_ReturnValue_Offset), 0, GetCurrentFocusDistance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocalLength")]
	public unsafe static float GetCurrentFocalLength(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentFocalLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocalLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFocalLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFocalLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentFocalLength_InMoviePipeline_Offset), 0, GetCurrentFocalLength_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentFocalLength_FunctionAddress, intPtr, GetCurrentFocalLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentFocalLength_ReturnValue_Offset), 0, GetCurrentFocalLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentExecutorShot")]
	public unsafe static UMoviePipelineExecutorShot GetCurrentExecutorShot(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentExecutorShot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentExecutorShot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentExecutorShot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentExecutorShot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentExecutorShot_InMoviePipeline_Offset), 0, GetCurrentExecutorShot_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentExecutorShot_FunctionAddress, intPtr, GetCurrentExecutorShot_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorShot>.FromNative(IntPtr.Add(intPtr, GetCurrentExecutorShot_ReturnValue_Offset), 0, GetCurrentExecutorShot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentAperture")]
	public unsafe static float GetCurrentAperture(UMoviePipeline InMoviePipeline)
	{
		if (!GetCurrentAperture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentAperture");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAperture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAperture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCurrentAperture_InMoviePipeline_Offset), 0, GetCurrentAperture_InMoviePipeline_PropertyAddress.Address, InMoviePipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentAperture_FunctionAddress, intPtr, GetCurrentAperture_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentAperture_ReturnValue_Offset), 0, GetCurrentAperture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCompletionPercentage")]
	public unsafe static float GetCompletionPercentage(UMoviePipeline InPipeline)
	{
		if (!GetCompletionPercentage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCompletionPercentage");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCompletionPercentage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCompletionPercentage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetCompletionPercentage_InPipeline_Offset), 0, GetCompletionPercentage_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCompletionPercentage_FunctionAddress, intPtr, GetCompletionPercentage_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCompletionPercentage_ReturnValue_Offset), 0, GetCompletionPercentage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:FindOrGetDefaultSettingForShot")]
	public unsafe static UMoviePipelineSetting FindOrGetDefaultSettingForShot(TSubclassOf<UMoviePipelineSetting> InSettingType, UMoviePipelineMasterConfig InMasterConfig, UMoviePipelineExecutorShot InShot)
	{
		if (!FindOrGetDefaultSettingForShot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:FindOrGetDefaultSettingForShot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOrGetDefaultSettingForShot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOrGetDefaultSettingForShot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineSetting>.ToNative(IntPtr.Add(intPtr, FindOrGetDefaultSettingForShot_InSettingType_Offset), 0, FindOrGetDefaultSettingForShot_InSettingType_PropertyAddress.Address, InSettingType);
		UObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(intPtr, FindOrGetDefaultSettingForShot_InMasterConfig_Offset), 0, FindOrGetDefaultSettingForShot_InMasterConfig_PropertyAddress.Address, InMasterConfig);
		UObjectMarshaler<UMoviePipelineExecutorShot>.ToNative(IntPtr.Add(intPtr, FindOrGetDefaultSettingForShot_InShot_Offset), 0, FindOrGetDefaultSettingForShot_InShot_PropertyAddress.Address, InShot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindOrGetDefaultSettingForShot_FunctionAddress, intPtr, FindOrGetDefaultSettingForShot_ParamsSize);
		return UObjectMarshaler<UMoviePipelineSetting>.FromNative(IntPtr.Add(intPtr, FindOrGetDefaultSettingForShot_ReturnValue_Offset), 0, FindOrGetDefaultSettingForShot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:DuplicateSequence")]
	public unsafe static UMovieSceneSequence DuplicateSequence(UObject Outer, UMovieSceneSequence InSequence)
	{
		if (!DuplicateSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:DuplicateSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateSequence_Outer_Offset), 0, DuplicateSequence_Outer_PropertyAddress.Address, Outer);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, DuplicateSequence_InSequence_Offset), 0, DuplicateSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateSequence_FunctionAddress, intPtr, DuplicateSequence_ParamsSize);
		return UObjectMarshaler<UMovieSceneSequence>.FromNative(IntPtr.Add(intPtr, DuplicateSequence_ReturnValue_Offset), 0, DuplicateSequence_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipelineLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary");
		UpdateJobShotListFromSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateJobShotListFromSequence");
		UpdateJobShotListFromSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateJobShotListFromSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateJobShotListFromSequence_InSequence_PropertyAddress, UpdateJobShotListFromSequence_FunctionAddress, "InSequence");
		UpdateJobShotListFromSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(UpdateJobShotListFromSequence_FunctionAddress, "InSequence");
		UpdateJobShotListFromSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateJobShotListFromSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateJobShotListFromSequence_InJob_PropertyAddress, UpdateJobShotListFromSequence_FunctionAddress, "InJob");
		UpdateJobShotListFromSequence_InJob_Offset = NativeReflectionCached.GetPropertyOffset(UpdateJobShotListFromSequence_FunctionAddress, "InJob");
		UpdateJobShotListFromSequence_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateJobShotListFromSequence_FunctionAddress, "InJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateJobShotListFromSequence_bShotsChanged_PropertyAddress, UpdateJobShotListFromSequence_FunctionAddress, "bShotsChanged");
		UpdateJobShotListFromSequence_bShotsChanged_Offset = NativeReflectionCached.GetPropertyOffset(UpdateJobShotListFromSequence_FunctionAddress, "bShotsChanged");
		UpdateJobShotListFromSequence_bShotsChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateJobShotListFromSequence_FunctionAddress, "bShotsChanged", Classes.FBoolProperty);
		UpdateJobShotListFromSequence_IsValid = UpdateJobShotListFromSequence_FunctionAddress != IntPtr.Zero && UpdateJobShotListFromSequence_InSequence_IsValid && UpdateJobShotListFromSequence_InJob_IsValid && UpdateJobShotListFromSequence_bShotsChanged_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:UpdateJobShotListFromSequence", UpdateJobShotListFromSequence_IsValid);
		ResolveVersionNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResolveVersionNumber");
		ResolveVersionNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveVersionNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveVersionNumber_InParams_PropertyAddress, ResolveVersionNumber_FunctionAddress, "InParams");
		ResolveVersionNumber_InParams_Offset = NativeReflectionCached.GetPropertyOffset(ResolveVersionNumber_FunctionAddress, "InParams");
		ResolveVersionNumber_InParams_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveVersionNumber_FunctionAddress, "InParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveVersionNumber_ReturnValue_PropertyAddress, ResolveVersionNumber_FunctionAddress, "ReturnValue");
		ResolveVersionNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResolveVersionNumber_FunctionAddress, "ReturnValue");
		ResolveVersionNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveVersionNumber_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ResolveVersionNumber_IsValid = ResolveVersionNumber_FunctionAddress != IntPtr.Zero && ResolveVersionNumber_InParams_IsValid && ResolveVersionNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveVersionNumber", ResolveVersionNumber_IsValid);
		ResolveFilenameFormatArguments_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResolveFilenameFormatArguments");
		ResolveFilenameFormatArguments_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveFilenameFormatArguments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveFilenameFormatArguments_InFormatString_PropertyAddress, ResolveFilenameFormatArguments_FunctionAddress, "InFormatString");
		ResolveFilenameFormatArguments_InFormatString_Offset = NativeReflectionCached.GetPropertyOffset(ResolveFilenameFormatArguments_FunctionAddress, "InFormatString");
		ResolveFilenameFormatArguments_InFormatString_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveFilenameFormatArguments_FunctionAddress, "InFormatString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveFilenameFormatArguments_InParams_PropertyAddress, ResolveFilenameFormatArguments_FunctionAddress, "InParams");
		ResolveFilenameFormatArguments_InParams_Offset = NativeReflectionCached.GetPropertyOffset(ResolveFilenameFormatArguments_FunctionAddress, "InParams");
		ResolveFilenameFormatArguments_InParams_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveFilenameFormatArguments_FunctionAddress, "InParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveFilenameFormatArguments_OutFinalPath_PropertyAddress, ResolveFilenameFormatArguments_FunctionAddress, "OutFinalPath");
		ResolveFilenameFormatArguments_OutFinalPath_Offset = NativeReflectionCached.GetPropertyOffset(ResolveFilenameFormatArguments_FunctionAddress, "OutFinalPath");
		ResolveFilenameFormatArguments_OutFinalPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveFilenameFormatArguments_FunctionAddress, "OutFinalPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveFilenameFormatArguments_OutMergedFormatArgs_PropertyAddress, ResolveFilenameFormatArguments_FunctionAddress, "OutMergedFormatArgs");
		ResolveFilenameFormatArguments_OutMergedFormatArgs_Offset = NativeReflectionCached.GetPropertyOffset(ResolveFilenameFormatArguments_FunctionAddress, "OutMergedFormatArgs");
		ResolveFilenameFormatArguments_OutMergedFormatArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveFilenameFormatArguments_FunctionAddress, "OutMergedFormatArgs", Classes.FStructProperty);
		ResolveFilenameFormatArguments_IsValid = ResolveFilenameFormatArguments_FunctionAddress != IntPtr.Zero && ResolveFilenameFormatArguments_InFormatString_IsValid && ResolveFilenameFormatArguments_InParams_IsValid && ResolveFilenameFormatArguments_OutFinalPath_IsValid && ResolveFilenameFormatArguments_OutMergedFormatArgs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:ResolveFilenameFormatArguments", ResolveFilenameFormatArguments_IsValid);
		LoadManifestFileFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadManifestFileFromString");
		LoadManifestFileFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadManifestFileFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadManifestFileFromString_InManifestFilePath_PropertyAddress, LoadManifestFileFromString_FunctionAddress, "InManifestFilePath");
		LoadManifestFileFromString_InManifestFilePath_Offset = NativeReflectionCached.GetPropertyOffset(LoadManifestFileFromString_FunctionAddress, "InManifestFilePath");
		LoadManifestFileFromString_InManifestFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadManifestFileFromString_FunctionAddress, "InManifestFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadManifestFileFromString_ReturnValue_PropertyAddress, LoadManifestFileFromString_FunctionAddress, "ReturnValue");
		LoadManifestFileFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadManifestFileFromString_FunctionAddress, "ReturnValue");
		LoadManifestFileFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadManifestFileFromString_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadManifestFileFromString_IsValid = LoadManifestFileFromString_FunctionAddress != IntPtr.Zero && LoadManifestFileFromString_InManifestFilePath_IsValid && LoadManifestFileFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:LoadManifestFileFromString", LoadManifestFileFromString_IsValid);
		GetPipelineState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPipelineState");
		GetPipelineState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPipelineState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPipelineState_InPipeline_PropertyAddress, GetPipelineState_FunctionAddress, "InPipeline");
		GetPipelineState_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetPipelineState_FunctionAddress, "InPipeline");
		GetPipelineState_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPipelineState_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPipelineState_ReturnValue_PropertyAddress, GetPipelineState_FunctionAddress, "ReturnValue");
		GetPipelineState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPipelineState_FunctionAddress, "ReturnValue");
		GetPipelineState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPipelineState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPipelineState_IsValid = GetPipelineState_FunctionAddress != IntPtr.Zero && GetPipelineState_InPipeline_IsValid && GetPipelineState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetPipelineState", GetPipelineState_IsValid);
		GetOverallSegmentCounts_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOverallSegmentCounts");
		GetOverallSegmentCounts_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverallSegmentCounts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverallSegmentCounts_InMoviePipeline_PropertyAddress, GetOverallSegmentCounts_FunctionAddress, "InMoviePipeline");
		GetOverallSegmentCounts_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallSegmentCounts_FunctionAddress, "InMoviePipeline");
		GetOverallSegmentCounts_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallSegmentCounts_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverallSegmentCounts_OutCurrentIndex_PropertyAddress, GetOverallSegmentCounts_FunctionAddress, "OutCurrentIndex");
		GetOverallSegmentCounts_OutCurrentIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallSegmentCounts_FunctionAddress, "OutCurrentIndex");
		GetOverallSegmentCounts_OutCurrentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallSegmentCounts_FunctionAddress, "OutCurrentIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverallSegmentCounts_OutTotalCount_PropertyAddress, GetOverallSegmentCounts_FunctionAddress, "OutTotalCount");
		GetOverallSegmentCounts_OutTotalCount_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallSegmentCounts_FunctionAddress, "OutTotalCount");
		GetOverallSegmentCounts_OutTotalCount_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallSegmentCounts_FunctionAddress, "OutTotalCount", Classes.FIntProperty);
		GetOverallSegmentCounts_IsValid = GetOverallSegmentCounts_FunctionAddress != IntPtr.Zero && GetOverallSegmentCounts_InMoviePipeline_IsValid && GetOverallSegmentCounts_OutCurrentIndex_IsValid && GetOverallSegmentCounts_OutTotalCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallSegmentCounts", GetOverallSegmentCounts_IsValid);
		GetOverallOutputFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOverallOutputFrames");
		GetOverallOutputFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverallOutputFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverallOutputFrames_InMoviePipeline_PropertyAddress, GetOverallOutputFrames_FunctionAddress, "InMoviePipeline");
		GetOverallOutputFrames_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallOutputFrames_FunctionAddress, "InMoviePipeline");
		GetOverallOutputFrames_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallOutputFrames_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverallOutputFrames_OutCurrentIndex_PropertyAddress, GetOverallOutputFrames_FunctionAddress, "OutCurrentIndex");
		GetOverallOutputFrames_OutCurrentIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallOutputFrames_FunctionAddress, "OutCurrentIndex");
		GetOverallOutputFrames_OutCurrentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallOutputFrames_FunctionAddress, "OutCurrentIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverallOutputFrames_OutTotalCount_PropertyAddress, GetOverallOutputFrames_FunctionAddress, "OutTotalCount");
		GetOverallOutputFrames_OutTotalCount_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallOutputFrames_FunctionAddress, "OutTotalCount");
		GetOverallOutputFrames_OutTotalCount_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallOutputFrames_FunctionAddress, "OutTotalCount", Classes.FIntProperty);
		GetOverallOutputFrames_IsValid = GetOverallOutputFrames_FunctionAddress != IntPtr.Zero && GetOverallOutputFrames_InMoviePipeline_IsValid && GetOverallOutputFrames_OutCurrentIndex_IsValid && GetOverallOutputFrames_OutTotalCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetOverallOutputFrames", GetOverallOutputFrames_IsValid);
		GetMoviePipelineEngineChangelistLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMoviePipelineEngineChangelistLabel");
		GetMoviePipelineEngineChangelistLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMoviePipelineEngineChangelistLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMoviePipelineEngineChangelistLabel_InMoviePipeline_PropertyAddress, GetMoviePipelineEngineChangelistLabel_FunctionAddress, "InMoviePipeline");
		GetMoviePipelineEngineChangelistLabel_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetMoviePipelineEngineChangelistLabel_FunctionAddress, "InMoviePipeline");
		GetMoviePipelineEngineChangelistLabel_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMoviePipelineEngineChangelistLabel_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMoviePipelineEngineChangelistLabel_ReturnValue_PropertyAddress, GetMoviePipelineEngineChangelistLabel_FunctionAddress, "ReturnValue");
		GetMoviePipelineEngineChangelistLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMoviePipelineEngineChangelistLabel_FunctionAddress, "ReturnValue");
		GetMoviePipelineEngineChangelistLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMoviePipelineEngineChangelistLabel_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetMoviePipelineEngineChangelistLabel_IsValid = GetMoviePipelineEngineChangelistLabel_FunctionAddress != IntPtr.Zero && GetMoviePipelineEngineChangelistLabel_InMoviePipeline_IsValid && GetMoviePipelineEngineChangelistLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMoviePipelineEngineChangelistLabel", GetMoviePipelineEngineChangelistLabel_IsValid);
		GetMasterTimecode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMasterTimecode");
		GetMasterTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMasterTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMasterTimecode_InMoviePipeline_PropertyAddress, GetMasterTimecode_FunctionAddress, "InMoviePipeline");
		GetMasterTimecode_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterTimecode_FunctionAddress, "InMoviePipeline");
		GetMasterTimecode_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterTimecode_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMasterTimecode_ReturnValue_PropertyAddress, GetMasterTimecode_FunctionAddress, "ReturnValue");
		GetMasterTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterTimecode_FunctionAddress, "ReturnValue");
		GetMasterTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterTimecode_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMasterTimecode_IsValid = GetMasterTimecode_FunctionAddress != IntPtr.Zero && GetMasterTimecode_InMoviePipeline_IsValid && GetMasterTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterTimecode", GetMasterTimecode_IsValid);
		GetMasterFrameNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMasterFrameNumber");
		GetMasterFrameNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMasterFrameNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMasterFrameNumber_InMoviePipeline_PropertyAddress, GetMasterFrameNumber_FunctionAddress, "InMoviePipeline");
		GetMasterFrameNumber_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterFrameNumber_FunctionAddress, "InMoviePipeline");
		GetMasterFrameNumber_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterFrameNumber_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMasterFrameNumber_ReturnValue_PropertyAddress, GetMasterFrameNumber_FunctionAddress, "ReturnValue");
		GetMasterFrameNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterFrameNumber_FunctionAddress, "ReturnValue");
		GetMasterFrameNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterFrameNumber_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMasterFrameNumber_IsValid = GetMasterFrameNumber_FunctionAddress != IntPtr.Zero && GetMasterFrameNumber_InMoviePipeline_IsValid && GetMasterFrameNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMasterFrameNumber", GetMasterFrameNumber_IsValid);
		GetMapPackageName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMapPackageName");
		GetMapPackageName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMapPackageName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMapPackageName_InJob_PropertyAddress, GetMapPackageName_FunctionAddress, "InJob");
		GetMapPackageName_InJob_Offset = NativeReflectionCached.GetPropertyOffset(GetMapPackageName_FunctionAddress, "InJob");
		GetMapPackageName_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMapPackageName_FunctionAddress, "InJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMapPackageName_ReturnValue_PropertyAddress, GetMapPackageName_FunctionAddress, "ReturnValue");
		GetMapPackageName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMapPackageName_FunctionAddress, "ReturnValue");
		GetMapPackageName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMapPackageName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMapPackageName_IsValid = GetMapPackageName_FunctionAddress != IntPtr.Zero && GetMapPackageName_InJob_IsValid && GetMapPackageName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetMapPackageName", GetMapPackageName_IsValid);
		GetJobName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetJobName");
		GetJobName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJobName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJobName_InMoviePipeline_PropertyAddress, GetJobName_FunctionAddress, "InMoviePipeline");
		GetJobName_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetJobName_FunctionAddress, "InMoviePipeline");
		GetJobName_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobName_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetJobName_ReturnValue_PropertyAddress, GetJobName_FunctionAddress, "ReturnValue");
		GetJobName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJobName_FunctionAddress, "ReturnValue");
		GetJobName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetJobName_IsValid = GetJobName_FunctionAddress != IntPtr.Zero && GetJobName_InMoviePipeline_IsValid && GetJobName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobName", GetJobName_IsValid);
		GetJobInitializationTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetJobInitializationTime");
		GetJobInitializationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJobInitializationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJobInitializationTime_InMoviePipeline_PropertyAddress, GetJobInitializationTime_FunctionAddress, "InMoviePipeline");
		GetJobInitializationTime_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetJobInitializationTime_FunctionAddress, "InMoviePipeline");
		GetJobInitializationTime_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobInitializationTime_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetJobInitializationTime_ReturnValue_PropertyAddress, GetJobInitializationTime_FunctionAddress, "ReturnValue");
		GetJobInitializationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJobInitializationTime_FunctionAddress, "ReturnValue");
		GetJobInitializationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobInitializationTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetJobInitializationTime_IsValid = GetJobInitializationTime_FunctionAddress != IntPtr.Zero && GetJobInitializationTime_InMoviePipeline_IsValid && GetJobInitializationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobInitializationTime", GetJobInitializationTime_IsValid);
		GetJobAuthor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetJobAuthor");
		GetJobAuthor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJobAuthor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJobAuthor_InMoviePipeline_PropertyAddress, GetJobAuthor_FunctionAddress, "InMoviePipeline");
		GetJobAuthor_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetJobAuthor_FunctionAddress, "InMoviePipeline");
		GetJobAuthor_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobAuthor_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetJobAuthor_ReturnValue_PropertyAddress, GetJobAuthor_FunctionAddress, "ReturnValue");
		GetJobAuthor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJobAuthor_FunctionAddress, "ReturnValue");
		GetJobAuthor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobAuthor_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetJobAuthor_IsValid = GetJobAuthor_FunctionAddress != IntPtr.Zero && GetJobAuthor_InMoviePipeline_IsValid && GetJobAuthor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetJobAuthor", GetJobAuthor_IsValid);
		GetEstimatedTimeRemaining_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEstimatedTimeRemaining");
		GetEstimatedTimeRemaining_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEstimatedTimeRemaining_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEstimatedTimeRemaining_InPipeline_PropertyAddress, GetEstimatedTimeRemaining_FunctionAddress, "InPipeline");
		GetEstimatedTimeRemaining_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetEstimatedTimeRemaining_FunctionAddress, "InPipeline");
		GetEstimatedTimeRemaining_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEstimatedTimeRemaining_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEstimatedTimeRemaining_OutEstimate_PropertyAddress, GetEstimatedTimeRemaining_FunctionAddress, "OutEstimate");
		GetEstimatedTimeRemaining_OutEstimate_Offset = NativeReflectionCached.GetPropertyOffset(GetEstimatedTimeRemaining_FunctionAddress, "OutEstimate");
		GetEstimatedTimeRemaining_OutEstimate_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEstimatedTimeRemaining_FunctionAddress, "OutEstimate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEstimatedTimeRemaining_ReturnValue_PropertyAddress, GetEstimatedTimeRemaining_FunctionAddress, "ReturnValue");
		GetEstimatedTimeRemaining_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEstimatedTimeRemaining_FunctionAddress, "ReturnValue");
		GetEstimatedTimeRemaining_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEstimatedTimeRemaining_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEstimatedTimeRemaining_IsValid = GetEstimatedTimeRemaining_FunctionAddress != IntPtr.Zero && GetEstimatedTimeRemaining_InPipeline_IsValid && GetEstimatedTimeRemaining_OutEstimate_IsValid && GetEstimatedTimeRemaining_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEstimatedTimeRemaining", GetEstimatedTimeRemaining_IsValid);
		GetEffectiveOutputResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEffectiveOutputResolution");
		GetEffectiveOutputResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEffectiveOutputResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEffectiveOutputResolution_InMasterConfig_PropertyAddress, GetEffectiveOutputResolution_FunctionAddress, "InMasterConfig");
		GetEffectiveOutputResolution_InMasterConfig_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectiveOutputResolution_FunctionAddress, "InMasterConfig");
		GetEffectiveOutputResolution_InMasterConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectiveOutputResolution_FunctionAddress, "InMasterConfig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEffectiveOutputResolution_InPipelineExecutorShot_PropertyAddress, GetEffectiveOutputResolution_FunctionAddress, "InPipelineExecutorShot");
		GetEffectiveOutputResolution_InPipelineExecutorShot_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectiveOutputResolution_FunctionAddress, "InPipelineExecutorShot");
		GetEffectiveOutputResolution_InPipelineExecutorShot_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectiveOutputResolution_FunctionAddress, "InPipelineExecutorShot", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEffectiveOutputResolution_ReturnValue_PropertyAddress, GetEffectiveOutputResolution_FunctionAddress, "ReturnValue");
		GetEffectiveOutputResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectiveOutputResolution_FunctionAddress, "ReturnValue");
		GetEffectiveOutputResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectiveOutputResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEffectiveOutputResolution_IsValid = GetEffectiveOutputResolution_FunctionAddress != IntPtr.Zero && GetEffectiveOutputResolution_InMasterConfig_IsValid && GetEffectiveOutputResolution_InPipelineExecutorShot_IsValid && GetEffectiveOutputResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetEffectiveOutputResolution", GetEffectiveOutputResolution_IsValid);
		GetCurrentShotTimecode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentShotTimecode");
		GetCurrentShotTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentShotTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentShotTimecode_InMoviePipeline_PropertyAddress, GetCurrentShotTimecode_FunctionAddress, "InMoviePipeline");
		GetCurrentShotTimecode_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentShotTimecode_FunctionAddress, "InMoviePipeline");
		GetCurrentShotTimecode_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentShotTimecode_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentShotTimecode_ReturnValue_PropertyAddress, GetCurrentShotTimecode_FunctionAddress, "ReturnValue");
		GetCurrentShotTimecode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentShotTimecode_FunctionAddress, "ReturnValue");
		GetCurrentShotTimecode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentShotTimecode_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentShotTimecode_IsValid = GetCurrentShotTimecode_FunctionAddress != IntPtr.Zero && GetCurrentShotTimecode_InMoviePipeline_IsValid && GetCurrentShotTimecode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotTimecode", GetCurrentShotTimecode_IsValid);
		GetCurrentShotFrameNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentShotFrameNumber");
		GetCurrentShotFrameNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentShotFrameNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentShotFrameNumber_InMoviePipeline_PropertyAddress, GetCurrentShotFrameNumber_FunctionAddress, "InMoviePipeline");
		GetCurrentShotFrameNumber_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentShotFrameNumber_FunctionAddress, "InMoviePipeline");
		GetCurrentShotFrameNumber_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentShotFrameNumber_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentShotFrameNumber_ReturnValue_PropertyAddress, GetCurrentShotFrameNumber_FunctionAddress, "ReturnValue");
		GetCurrentShotFrameNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentShotFrameNumber_FunctionAddress, "ReturnValue");
		GetCurrentShotFrameNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentShotFrameNumber_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentShotFrameNumber_IsValid = GetCurrentShotFrameNumber_FunctionAddress != IntPtr.Zero && GetCurrentShotFrameNumber_InMoviePipeline_IsValid && GetCurrentShotFrameNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentShotFrameNumber", GetCurrentShotFrameNumber_IsValid);
		GetCurrentSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentSequence");
		GetCurrentSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSequence_InMoviePipeline_PropertyAddress, GetCurrentSequence_FunctionAddress, "InMoviePipeline");
		GetCurrentSequence_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSequence_FunctionAddress, "InMoviePipeline");
		GetCurrentSequence_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSequence_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSequence_ReturnValue_PropertyAddress, GetCurrentSequence_FunctionAddress, "ReturnValue");
		GetCurrentSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSequence_FunctionAddress, "ReturnValue");
		GetCurrentSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentSequence_IsValid = GetCurrentSequence_FunctionAddress != IntPtr.Zero && GetCurrentSequence_InMoviePipeline_IsValid && GetCurrentSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSequence", GetCurrentSequence_IsValid);
		GetCurrentSegmentWorkMetrics_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentSegmentWorkMetrics");
		GetCurrentSegmentWorkMetrics_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSegmentWorkMetrics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentWorkMetrics_InMoviePipeline_PropertyAddress, GetCurrentSegmentWorkMetrics_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentWorkMetrics_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentWorkMetrics_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentWorkMetrics_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentWorkMetrics_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentWorkMetrics_ReturnValue_PropertyAddress, GetCurrentSegmentWorkMetrics_FunctionAddress, "ReturnValue");
		GetCurrentSegmentWorkMetrics_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentWorkMetrics_FunctionAddress, "ReturnValue");
		GetCurrentSegmentWorkMetrics_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentWorkMetrics_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentSegmentWorkMetrics_IsValid = GetCurrentSegmentWorkMetrics_FunctionAddress != IntPtr.Zero && GetCurrentSegmentWorkMetrics_InMoviePipeline_IsValid && GetCurrentSegmentWorkMetrics_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentWorkMetrics", GetCurrentSegmentWorkMetrics_IsValid);
		GetCurrentSegmentState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentSegmentState");
		GetCurrentSegmentState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSegmentState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentState_InMoviePipeline_PropertyAddress, GetCurrentSegmentState_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentState_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentState_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentState_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentState_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentState_ReturnValue_PropertyAddress, GetCurrentSegmentState_FunctionAddress, "ReturnValue");
		GetCurrentSegmentState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentState_FunctionAddress, "ReturnValue");
		GetCurrentSegmentState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurrentSegmentState_IsValid = GetCurrentSegmentState_FunctionAddress != IntPtr.Zero && GetCurrentSegmentState_InMoviePipeline_IsValid && GetCurrentSegmentState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentState", GetCurrentSegmentState_IsValid);
		GetCurrentSegmentName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentSegmentName");
		GetCurrentSegmentName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSegmentName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentName_InMoviePipeline_PropertyAddress, GetCurrentSegmentName_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentName_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentName_FunctionAddress, "InMoviePipeline");
		GetCurrentSegmentName_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentName_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentName_OutOuterName_PropertyAddress, GetCurrentSegmentName_FunctionAddress, "OutOuterName");
		GetCurrentSegmentName_OutOuterName_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentName_FunctionAddress, "OutOuterName");
		GetCurrentSegmentName_OutOuterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentName_FunctionAddress, "OutOuterName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSegmentName_OutInnerName_PropertyAddress, GetCurrentSegmentName_FunctionAddress, "OutInnerName");
		GetCurrentSegmentName_OutInnerName_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSegmentName_FunctionAddress, "OutInnerName");
		GetCurrentSegmentName_OutInnerName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSegmentName_FunctionAddress, "OutInnerName", Classes.FTextProperty);
		GetCurrentSegmentName_IsValid = GetCurrentSegmentName_FunctionAddress != IntPtr.Zero && GetCurrentSegmentName_InMoviePipeline_IsValid && GetCurrentSegmentName_OutOuterName_IsValid && GetCurrentSegmentName_OutInnerName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentSegmentName", GetCurrentSegmentName_IsValid);
		GetCurrentFocusDistance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentFocusDistance");
		GetCurrentFocusDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFocusDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFocusDistance_InMoviePipeline_PropertyAddress, GetCurrentFocusDistance_FunctionAddress, "InMoviePipeline");
		GetCurrentFocusDistance_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFocusDistance_FunctionAddress, "InMoviePipeline");
		GetCurrentFocusDistance_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFocusDistance_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFocusDistance_ReturnValue_PropertyAddress, GetCurrentFocusDistance_FunctionAddress, "ReturnValue");
		GetCurrentFocusDistance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFocusDistance_FunctionAddress, "ReturnValue");
		GetCurrentFocusDistance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFocusDistance_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentFocusDistance_IsValid = GetCurrentFocusDistance_FunctionAddress != IntPtr.Zero && GetCurrentFocusDistance_InMoviePipeline_IsValid && GetCurrentFocusDistance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocusDistance", GetCurrentFocusDistance_IsValid);
		GetCurrentFocalLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentFocalLength");
		GetCurrentFocalLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFocalLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFocalLength_InMoviePipeline_PropertyAddress, GetCurrentFocalLength_FunctionAddress, "InMoviePipeline");
		GetCurrentFocalLength_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFocalLength_FunctionAddress, "InMoviePipeline");
		GetCurrentFocalLength_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFocalLength_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFocalLength_ReturnValue_PropertyAddress, GetCurrentFocalLength_FunctionAddress, "ReturnValue");
		GetCurrentFocalLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFocalLength_FunctionAddress, "ReturnValue");
		GetCurrentFocalLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFocalLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentFocalLength_IsValid = GetCurrentFocalLength_FunctionAddress != IntPtr.Zero && GetCurrentFocalLength_InMoviePipeline_IsValid && GetCurrentFocalLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentFocalLength", GetCurrentFocalLength_IsValid);
		GetCurrentExecutorShot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentExecutorShot");
		GetCurrentExecutorShot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentExecutorShot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentExecutorShot_InMoviePipeline_PropertyAddress, GetCurrentExecutorShot_FunctionAddress, "InMoviePipeline");
		GetCurrentExecutorShot_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentExecutorShot_FunctionAddress, "InMoviePipeline");
		GetCurrentExecutorShot_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentExecutorShot_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentExecutorShot_ReturnValue_PropertyAddress, GetCurrentExecutorShot_FunctionAddress, "ReturnValue");
		GetCurrentExecutorShot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentExecutorShot_FunctionAddress, "ReturnValue");
		GetCurrentExecutorShot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentExecutorShot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentExecutorShot_IsValid = GetCurrentExecutorShot_FunctionAddress != IntPtr.Zero && GetCurrentExecutorShot_InMoviePipeline_IsValid && GetCurrentExecutorShot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentExecutorShot", GetCurrentExecutorShot_IsValid);
		GetCurrentAperture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentAperture");
		GetCurrentAperture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAperture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAperture_InMoviePipeline_PropertyAddress, GetCurrentAperture_FunctionAddress, "InMoviePipeline");
		GetCurrentAperture_InMoviePipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAperture_FunctionAddress, "InMoviePipeline");
		GetCurrentAperture_InMoviePipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAperture_FunctionAddress, "InMoviePipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAperture_ReturnValue_PropertyAddress, GetCurrentAperture_FunctionAddress, "ReturnValue");
		GetCurrentAperture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAperture_FunctionAddress, "ReturnValue");
		GetCurrentAperture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAperture_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentAperture_IsValid = GetCurrentAperture_FunctionAddress != IntPtr.Zero && GetCurrentAperture_InMoviePipeline_IsValid && GetCurrentAperture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCurrentAperture", GetCurrentAperture_IsValid);
		GetCompletionPercentage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCompletionPercentage");
		GetCompletionPercentage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCompletionPercentage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCompletionPercentage_InPipeline_PropertyAddress, GetCompletionPercentage_FunctionAddress, "InPipeline");
		GetCompletionPercentage_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetCompletionPercentage_FunctionAddress, "InPipeline");
		GetCompletionPercentage_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCompletionPercentage_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCompletionPercentage_ReturnValue_PropertyAddress, GetCompletionPercentage_FunctionAddress, "ReturnValue");
		GetCompletionPercentage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCompletionPercentage_FunctionAddress, "ReturnValue");
		GetCompletionPercentage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCompletionPercentage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCompletionPercentage_IsValid = GetCompletionPercentage_FunctionAddress != IntPtr.Zero && GetCompletionPercentage_InPipeline_IsValid && GetCompletionPercentage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:GetCompletionPercentage", GetCompletionPercentage_IsValid);
		FindOrGetDefaultSettingForShot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindOrGetDefaultSettingForShot");
		FindOrGetDefaultSettingForShot_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrGetDefaultSettingForShot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOrGetDefaultSettingForShot_InSettingType_PropertyAddress, FindOrGetDefaultSettingForShot_FunctionAddress, "InSettingType");
		FindOrGetDefaultSettingForShot_InSettingType_Offset = NativeReflectionCached.GetPropertyOffset(FindOrGetDefaultSettingForShot_FunctionAddress, "InSettingType");
		FindOrGetDefaultSettingForShot_InSettingType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrGetDefaultSettingForShot_FunctionAddress, "InSettingType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrGetDefaultSettingForShot_InMasterConfig_PropertyAddress, FindOrGetDefaultSettingForShot_FunctionAddress, "InMasterConfig");
		FindOrGetDefaultSettingForShot_InMasterConfig_Offset = NativeReflectionCached.GetPropertyOffset(FindOrGetDefaultSettingForShot_FunctionAddress, "InMasterConfig");
		FindOrGetDefaultSettingForShot_InMasterConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrGetDefaultSettingForShot_FunctionAddress, "InMasterConfig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrGetDefaultSettingForShot_InShot_PropertyAddress, FindOrGetDefaultSettingForShot_FunctionAddress, "InShot");
		FindOrGetDefaultSettingForShot_InShot_Offset = NativeReflectionCached.GetPropertyOffset(FindOrGetDefaultSettingForShot_FunctionAddress, "InShot");
		FindOrGetDefaultSettingForShot_InShot_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrGetDefaultSettingForShot_FunctionAddress, "InShot", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrGetDefaultSettingForShot_ReturnValue_PropertyAddress, FindOrGetDefaultSettingForShot_FunctionAddress, "ReturnValue");
		FindOrGetDefaultSettingForShot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindOrGetDefaultSettingForShot_FunctionAddress, "ReturnValue");
		FindOrGetDefaultSettingForShot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrGetDefaultSettingForShot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindOrGetDefaultSettingForShot_IsValid = FindOrGetDefaultSettingForShot_FunctionAddress != IntPtr.Zero && FindOrGetDefaultSettingForShot_InSettingType_IsValid && FindOrGetDefaultSettingForShot_InMasterConfig_IsValid && FindOrGetDefaultSettingForShot_InShot_IsValid && FindOrGetDefaultSettingForShot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:FindOrGetDefaultSettingForShot", FindOrGetDefaultSettingForShot_IsValid);
		DuplicateSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateSequence");
		DuplicateSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSequence_Outer_PropertyAddress, DuplicateSequence_FunctionAddress, "Outer");
		DuplicateSequence_Outer_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSequence_FunctionAddress, "Outer");
		DuplicateSequence_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSequence_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSequence_InSequence_PropertyAddress, DuplicateSequence_FunctionAddress, "InSequence");
		DuplicateSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSequence_FunctionAddress, "InSequence");
		DuplicateSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSequence_ReturnValue_PropertyAddress, DuplicateSequence_FunctionAddress, "ReturnValue");
		DuplicateSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSequence_FunctionAddress, "ReturnValue");
		DuplicateSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateSequence_IsValid = DuplicateSequence_FunctionAddress != IntPtr.Zero && DuplicateSequence_Outer_IsValid && DuplicateSequence_InSequence_IsValid && DuplicateSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineBlueprintLibrary:DuplicateSequence", DuplicateSequence_IsValid);
	}
}
