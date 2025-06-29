using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary", "MovieRenderPipelineEditor", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineEditorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WarnUserOfUnsavedMap_IsValid;

	private static IntPtr WarnUserOfUnsavedMap_FunctionAddress;

	private static int WarnUserOfUnsavedMap_ParamsSize;

	private static bool SaveQueueToManifestFile_IsValid;

	private static IntPtr SaveQueueToManifestFile_FunctionAddress;

	private static int SaveQueueToManifestFile_ParamsSize;

	private static bool SaveQueueToManifestFile_InPipelineQueue_IsValid;

	private static FFieldAddress SaveQueueToManifestFile_InPipelineQueue_PropertyAddress;

	private static int SaveQueueToManifestFile_InPipelineQueue_Offset;

	private static bool SaveQueueToManifestFile_OutManifestFilePath_IsValid;

	private static FFieldAddress SaveQueueToManifestFile_OutManifestFilePath_PropertyAddress;

	private static int SaveQueueToManifestFile_OutManifestFilePath_Offset;

	private static bool SaveQueueToManifestFile_ReturnValue_IsValid;

	private static FFieldAddress SaveQueueToManifestFile_ReturnValue_PropertyAddress;

	private static int SaveQueueToManifestFile_ReturnValue_Offset;

	private static bool IsMapValidForRemoteRender_IsValid;

	private static IntPtr IsMapValidForRemoteRender_FunctionAddress;

	private static int IsMapValidForRemoteRender_ParamsSize;

	private static bool IsMapValidForRemoteRender_InJobs_IsValid;

	private static FFieldAddress IsMapValidForRemoteRender_InJobs_PropertyAddress;

	private static int IsMapValidForRemoteRender_InJobs_Offset;

	private static bool IsMapValidForRemoteRender_ReturnValue_IsValid;

	private static FFieldAddress IsMapValidForRemoteRender_ReturnValue_PropertyAddress;

	private static int IsMapValidForRemoteRender_ReturnValue_Offset;

	private static bool ExportConfigToAsset_IsValid;

	private static IntPtr ExportConfigToAsset_FunctionAddress;

	private static int ExportConfigToAsset_ParamsSize;

	private static bool ExportConfigToAsset_InConfig_IsValid;

	private static FFieldAddress ExportConfigToAsset_InConfig_PropertyAddress;

	private static int ExportConfigToAsset_InConfig_Offset;

	private static bool ExportConfigToAsset_InPackagePath_IsValid;

	private static FFieldAddress ExportConfigToAsset_InPackagePath_PropertyAddress;

	private static int ExportConfigToAsset_InPackagePath_Offset;

	private static bool ExportConfigToAsset_InFileName_IsValid;

	private static FFieldAddress ExportConfigToAsset_InFileName_PropertyAddress;

	private static int ExportConfigToAsset_InFileName_Offset;

	private static bool ExportConfigToAsset_bInSaveAsset_IsValid;

	private static FFieldAddress ExportConfigToAsset_bInSaveAsset_PropertyAddress;

	private static int ExportConfigToAsset_bInSaveAsset_Offset;

	private static bool ExportConfigToAsset_OutAsset_IsValid;

	private static FFieldAddress ExportConfigToAsset_OutAsset_PropertyAddress;

	private static int ExportConfigToAsset_OutAsset_Offset;

	private static bool ExportConfigToAsset_OutErrorReason_IsValid;

	private static FFieldAddress ExportConfigToAsset_OutErrorReason_PropertyAddress;

	private static int ExportConfigToAsset_OutErrorReason_Offset;

	private static bool ExportConfigToAsset_ReturnValue_IsValid;

	private static FFieldAddress ExportConfigToAsset_ReturnValue_PropertyAddress;

	private static int ExportConfigToAsset_ReturnValue_Offset;

	private static bool EnsureJobHasDefaultSettings_IsValid;

	private static IntPtr EnsureJobHasDefaultSettings_FunctionAddress;

	private static int EnsureJobHasDefaultSettings_ParamsSize;

	private static bool EnsureJobHasDefaultSettings_InJob_IsValid;

	private static FFieldAddress EnsureJobHasDefaultSettings_InJob_PropertyAddress;

	private static int EnsureJobHasDefaultSettings_InJob_Offset;

	private static bool CreateJobFromSequence_IsValid;

	private static IntPtr CreateJobFromSequence_FunctionAddress;

	private static int CreateJobFromSequence_ParamsSize;

	private static bool CreateJobFromSequence_InPipelineQueue_IsValid;

	private static FFieldAddress CreateJobFromSequence_InPipelineQueue_PropertyAddress;

	private static int CreateJobFromSequence_InPipelineQueue_Offset;

	private static bool CreateJobFromSequence_InSequence_IsValid;

	private static FFieldAddress CreateJobFromSequence_InSequence_PropertyAddress;

	private static int CreateJobFromSequence_InSequence_Offset;

	private static bool CreateJobFromSequence_ReturnValue_IsValid;

	private static FFieldAddress CreateJobFromSequence_ReturnValue_PropertyAddress;

	private static int CreateJobFromSequence_ReturnValue_Offset;

	private static bool ConvertManifestFileToString_IsValid;

	private static IntPtr ConvertManifestFileToString_FunctionAddress;

	private static int ConvertManifestFileToString_ParamsSize;

	private static bool ConvertManifestFileToString_InManifestFilePath_IsValid;

	private static FFieldAddress ConvertManifestFileToString_InManifestFilePath_PropertyAddress;

	private static int ConvertManifestFileToString_InManifestFilePath_Offset;

	private static bool ConvertManifestFileToString_ReturnValue_IsValid;

	private static FFieldAddress ConvertManifestFileToString_ReturnValue_PropertyAddress;

	private static int ConvertManifestFileToString_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:WarnUserOfUnsavedMap")]
	public unsafe static void WarnUserOfUnsavedMap()
	{
		if (!WarnUserOfUnsavedMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:WarnUserOfUnsavedMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WarnUserOfUnsavedMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WarnUserOfUnsavedMap_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: WarnUserOfUnsavedMap_FunctionAddress, argsSize: WarnUserOfUnsavedMap_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:SaveQueueToManifestFile")]
	public unsafe static UMoviePipelineQueue SaveQueueToManifestFile(UMoviePipelineQueue InPipelineQueue, out string OutManifestFilePath)
	{
		if (!SaveQueueToManifestFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:SaveQueueToManifestFile");
			OutManifestFilePath = FStringMarshaler.DefaultString;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveQueueToManifestFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveQueueToManifestFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, SaveQueueToManifestFile_InPipelineQueue_Offset), 0, SaveQueueToManifestFile_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveQueueToManifestFile_FunctionAddress, intPtr, SaveQueueToManifestFile_ParamsSize);
		OutManifestFilePath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SaveQueueToManifestFile_OutManifestFilePath_Offset), 0, SaveQueueToManifestFile_OutManifestFilePath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveQueueToManifestFile_OutManifestFilePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMoviePipelineQueue>.FromNative(IntPtr.Add(intPtr, SaveQueueToManifestFile_ReturnValue_Offset), 0, SaveQueueToManifestFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:IsMapValidForRemoteRender")]
	public unsafe static bool IsMapValidForRemoteRender(List<UMoviePipelineExecutorJob> InJobs)
	{
		if (!IsMapValidForRemoteRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:IsMapValidForRemoteRender");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMapValidForRemoteRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMapValidForRemoteRender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMoviePipelineExecutorJob>(1, IsMapValidForRemoteRender_InJobs_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineExecutorJob, UObjectMarshaler<UMoviePipelineExecutorJob>>.FromNative, CachedMarshalingDelegates<UMoviePipelineExecutorJob, UObjectMarshaler<UMoviePipelineExecutorJob>>.ToNative).ToNative(IntPtr.Add(intPtr, IsMapValidForRemoteRender_InJobs_Offset), InJobs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsMapValidForRemoteRender_FunctionAddress, intPtr, IsMapValidForRemoteRender_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsMapValidForRemoteRender_InJobs_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMapValidForRemoteRender_ReturnValue_Offset), 0, IsMapValidForRemoteRender_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ExportConfigToAsset")]
	public unsafe static bool ExportConfigToAsset(UMoviePipelineMasterConfig InConfig, string InPackagePath, string InFileName, bool bInSaveAsset, out UMoviePipelineMasterConfig OutAsset, out FText OutErrorReason)
	{
		if (!ExportConfigToAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ExportConfigToAsset");
			OutAsset = null;
			OutErrorReason = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportConfigToAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportConfigToAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineMasterConfig>.ToNative(IntPtr.Add(intPtr, ExportConfigToAsset_InConfig_Offset), 0, ExportConfigToAsset_InConfig_PropertyAddress.Address, InConfig);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportConfigToAsset_InPackagePath_Offset), 0, ExportConfigToAsset_InPackagePath_PropertyAddress.Address, InPackagePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportConfigToAsset_InFileName_Offset), 0, ExportConfigToAsset_InFileName_PropertyAddress.Address, InFileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportConfigToAsset_bInSaveAsset_Offset), 0, ExportConfigToAsset_bInSaveAsset_PropertyAddress.Address, bInSaveAsset);
		NativeReflection.InitializeValue_InContainer(ExportConfigToAsset_OutErrorReason_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportConfigToAsset_FunctionAddress, intPtr, ExportConfigToAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportConfigToAsset_InPackagePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportConfigToAsset_InFileName_PropertyAddress.Address, intPtr);
		OutAsset = UObjectMarshaler<UMoviePipelineMasterConfig>.FromNative(IntPtr.Add(intPtr, ExportConfigToAsset_OutAsset_Offset), 0, ExportConfigToAsset_OutAsset_PropertyAddress.Address);
		OutErrorReason = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ExportConfigToAsset_OutErrorReason_Offset), 0, ExportConfigToAsset_OutErrorReason_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportConfigToAsset_OutErrorReason_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportConfigToAsset_ReturnValue_Offset), 0, ExportConfigToAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:EnsureJobHasDefaultSettings")]
	public unsafe static void EnsureJobHasDefaultSettings(UMoviePipelineExecutorJob InJob)
	{
		if (!EnsureJobHasDefaultSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:EnsureJobHasDefaultSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnsureJobHasDefaultSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnsureJobHasDefaultSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, EnsureJobHasDefaultSettings_InJob_Offset), 0, EnsureJobHasDefaultSettings_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnsureJobHasDefaultSettings_FunctionAddress, intPtr, EnsureJobHasDefaultSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:CreateJobFromSequence")]
	public unsafe static UMoviePipelineExecutorJob CreateJobFromSequence(UMoviePipelineQueue InPipelineQueue, ULevelSequence InSequence)
	{
		if (!CreateJobFromSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:CreateJobFromSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateJobFromSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateJobFromSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, CreateJobFromSequence_InPipelineQueue_Offset), 0, CreateJobFromSequence_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, CreateJobFromSequence_InSequence_Offset), 0, CreateJobFromSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateJobFromSequence_FunctionAddress, intPtr, CreateJobFromSequence_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(intPtr, CreateJobFromSequence_ReturnValue_Offset), 0, CreateJobFromSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ConvertManifestFileToString")]
	public unsafe static string ConvertManifestFileToString(string InManifestFilePath)
	{
		if (!ConvertManifestFileToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ConvertManifestFileToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertManifestFileToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertManifestFileToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertManifestFileToString_InManifestFilePath_Offset), 0, ConvertManifestFileToString_InManifestFilePath_PropertyAddress.Address, InManifestFilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertManifestFileToString_FunctionAddress, intPtr, ConvertManifestFileToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertManifestFileToString_InManifestFilePath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ConvertManifestFileToString_ReturnValue_Offset), 0, ConvertManifestFileToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertManifestFileToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMoviePipelineEditorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineEditorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineEditorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary");
		WarnUserOfUnsavedMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WarnUserOfUnsavedMap");
		WarnUserOfUnsavedMap_ParamsSize = NativeReflection.GetFunctionParamsSize(WarnUserOfUnsavedMap_FunctionAddress);
		WarnUserOfUnsavedMap_IsValid = WarnUserOfUnsavedMap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:WarnUserOfUnsavedMap", WarnUserOfUnsavedMap_IsValid);
		SaveQueueToManifestFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveQueueToManifestFile");
		SaveQueueToManifestFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveQueueToManifestFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveQueueToManifestFile_InPipelineQueue_PropertyAddress, SaveQueueToManifestFile_FunctionAddress, "InPipelineQueue");
		SaveQueueToManifestFile_InPipelineQueue_Offset = NativeReflectionCached.GetPropertyOffset(SaveQueueToManifestFile_FunctionAddress, "InPipelineQueue");
		SaveQueueToManifestFile_InPipelineQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveQueueToManifestFile_FunctionAddress, "InPipelineQueue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveQueueToManifestFile_OutManifestFilePath_PropertyAddress, SaveQueueToManifestFile_FunctionAddress, "OutManifestFilePath");
		SaveQueueToManifestFile_OutManifestFilePath_Offset = NativeReflectionCached.GetPropertyOffset(SaveQueueToManifestFile_FunctionAddress, "OutManifestFilePath");
		SaveQueueToManifestFile_OutManifestFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveQueueToManifestFile_FunctionAddress, "OutManifestFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveQueueToManifestFile_ReturnValue_PropertyAddress, SaveQueueToManifestFile_FunctionAddress, "ReturnValue");
		SaveQueueToManifestFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveQueueToManifestFile_FunctionAddress, "ReturnValue");
		SaveQueueToManifestFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveQueueToManifestFile_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SaveQueueToManifestFile_IsValid = SaveQueueToManifestFile_FunctionAddress != IntPtr.Zero && SaveQueueToManifestFile_InPipelineQueue_IsValid && SaveQueueToManifestFile_OutManifestFilePath_IsValid && SaveQueueToManifestFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:SaveQueueToManifestFile", SaveQueueToManifestFile_IsValid);
		IsMapValidForRemoteRender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMapValidForRemoteRender");
		IsMapValidForRemoteRender_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMapValidForRemoteRender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMapValidForRemoteRender_InJobs_PropertyAddress, IsMapValidForRemoteRender_FunctionAddress, "InJobs");
		IsMapValidForRemoteRender_InJobs_Offset = NativeReflectionCached.GetPropertyOffset(IsMapValidForRemoteRender_FunctionAddress, "InJobs");
		IsMapValidForRemoteRender_InJobs_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMapValidForRemoteRender_FunctionAddress, "InJobs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMapValidForRemoteRender_ReturnValue_PropertyAddress, IsMapValidForRemoteRender_FunctionAddress, "ReturnValue");
		IsMapValidForRemoteRender_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMapValidForRemoteRender_FunctionAddress, "ReturnValue");
		IsMapValidForRemoteRender_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMapValidForRemoteRender_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMapValidForRemoteRender_IsValid = IsMapValidForRemoteRender_FunctionAddress != IntPtr.Zero && IsMapValidForRemoteRender_InJobs_IsValid && IsMapValidForRemoteRender_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:IsMapValidForRemoteRender", IsMapValidForRemoteRender_IsValid);
		ExportConfigToAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportConfigToAsset");
		ExportConfigToAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportConfigToAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_InConfig_PropertyAddress, ExportConfigToAsset_FunctionAddress, "InConfig");
		ExportConfigToAsset_InConfig_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "InConfig");
		ExportConfigToAsset_InConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "InConfig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_InPackagePath_PropertyAddress, ExportConfigToAsset_FunctionAddress, "InPackagePath");
		ExportConfigToAsset_InPackagePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "InPackagePath");
		ExportConfigToAsset_InPackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "InPackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_InFileName_PropertyAddress, ExportConfigToAsset_FunctionAddress, "InFileName");
		ExportConfigToAsset_InFileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "InFileName");
		ExportConfigToAsset_InFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "InFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_bInSaveAsset_PropertyAddress, ExportConfigToAsset_FunctionAddress, "bInSaveAsset");
		ExportConfigToAsset_bInSaveAsset_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "bInSaveAsset");
		ExportConfigToAsset_bInSaveAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "bInSaveAsset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_OutAsset_PropertyAddress, ExportConfigToAsset_FunctionAddress, "OutAsset");
		ExportConfigToAsset_OutAsset_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "OutAsset");
		ExportConfigToAsset_OutAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "OutAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_OutErrorReason_PropertyAddress, ExportConfigToAsset_FunctionAddress, "OutErrorReason");
		ExportConfigToAsset_OutErrorReason_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "OutErrorReason");
		ExportConfigToAsset_OutErrorReason_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "OutErrorReason", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportConfigToAsset_ReturnValue_PropertyAddress, ExportConfigToAsset_FunctionAddress, "ReturnValue");
		ExportConfigToAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportConfigToAsset_FunctionAddress, "ReturnValue");
		ExportConfigToAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportConfigToAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportConfigToAsset_IsValid = ExportConfigToAsset_FunctionAddress != IntPtr.Zero && ExportConfigToAsset_InConfig_IsValid && ExportConfigToAsset_InPackagePath_IsValid && ExportConfigToAsset_InFileName_IsValid && ExportConfigToAsset_bInSaveAsset_IsValid && ExportConfigToAsset_OutAsset_IsValid && ExportConfigToAsset_OutErrorReason_IsValid && ExportConfigToAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ExportConfigToAsset", ExportConfigToAsset_IsValid);
		EnsureJobHasDefaultSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnsureJobHasDefaultSettings");
		EnsureJobHasDefaultSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(EnsureJobHasDefaultSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnsureJobHasDefaultSettings_InJob_PropertyAddress, EnsureJobHasDefaultSettings_FunctionAddress, "InJob");
		EnsureJobHasDefaultSettings_InJob_Offset = NativeReflectionCached.GetPropertyOffset(EnsureJobHasDefaultSettings_FunctionAddress, "InJob");
		EnsureJobHasDefaultSettings_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureJobHasDefaultSettings_FunctionAddress, "InJob", Classes.FObjectProperty);
		EnsureJobHasDefaultSettings_IsValid = EnsureJobHasDefaultSettings_FunctionAddress != IntPtr.Zero && EnsureJobHasDefaultSettings_InJob_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:EnsureJobHasDefaultSettings", EnsureJobHasDefaultSettings_IsValid);
		CreateJobFromSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateJobFromSequence");
		CreateJobFromSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateJobFromSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateJobFromSequence_InPipelineQueue_PropertyAddress, CreateJobFromSequence_FunctionAddress, "InPipelineQueue");
		CreateJobFromSequence_InPipelineQueue_Offset = NativeReflectionCached.GetPropertyOffset(CreateJobFromSequence_FunctionAddress, "InPipelineQueue");
		CreateJobFromSequence_InPipelineQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateJobFromSequence_FunctionAddress, "InPipelineQueue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateJobFromSequence_InSequence_PropertyAddress, CreateJobFromSequence_FunctionAddress, "InSequence");
		CreateJobFromSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateJobFromSequence_FunctionAddress, "InSequence");
		CreateJobFromSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateJobFromSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateJobFromSequence_ReturnValue_PropertyAddress, CreateJobFromSequence_FunctionAddress, "ReturnValue");
		CreateJobFromSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateJobFromSequence_FunctionAddress, "ReturnValue");
		CreateJobFromSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateJobFromSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateJobFromSequence_IsValid = CreateJobFromSequence_FunctionAddress != IntPtr.Zero && CreateJobFromSequence_InPipelineQueue_IsValid && CreateJobFromSequence_InSequence_IsValid && CreateJobFromSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:CreateJobFromSequence", CreateJobFromSequence_IsValid);
		ConvertManifestFileToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertManifestFileToString");
		ConvertManifestFileToString_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertManifestFileToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertManifestFileToString_InManifestFilePath_PropertyAddress, ConvertManifestFileToString_FunctionAddress, "InManifestFilePath");
		ConvertManifestFileToString_InManifestFilePath_Offset = NativeReflectionCached.GetPropertyOffset(ConvertManifestFileToString_FunctionAddress, "InManifestFilePath");
		ConvertManifestFileToString_InManifestFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertManifestFileToString_FunctionAddress, "InManifestFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertManifestFileToString_ReturnValue_PropertyAddress, ConvertManifestFileToString_FunctionAddress, "ReturnValue");
		ConvertManifestFileToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertManifestFileToString_FunctionAddress, "ReturnValue");
		ConvertManifestFileToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertManifestFileToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ConvertManifestFileToString_IsValid = ConvertManifestFileToString_FunctionAddress != IntPtr.Zero && ConvertManifestFileToString_InManifestFilePath_IsValid && ConvertManifestFileToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelineEditorBlueprintLibrary:ConvertManifestFileToString", ConvertManifestFileToString_IsValid);
	}
}
