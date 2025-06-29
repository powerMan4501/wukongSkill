using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.MovieSceneCapture;
using UnrealEngine.MovieSceneTools;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Plugins.SequencerScripting;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.Plugins.SequencerScriptingEditor;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary", "SequencerScriptingEditor", UnrealModuleType.EnginePlugin)]
public class USequencerTools : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RenderMovie_IsValid;

	private static IntPtr RenderMovie_FunctionAddress;

	private static int RenderMovie_ParamsSize;

	private static bool RenderMovie_InCaptureSettings_IsValid;

	private static FFieldAddress RenderMovie_InCaptureSettings_PropertyAddress;

	private static int RenderMovie_InCaptureSettings_Offset;

	private static bool RenderMovie_OnFinishedCallback_IsValid;

	private static FFieldAddress RenderMovie_OnFinishedCallback_PropertyAddress;

	private static int RenderMovie_OnFinishedCallback_Offset;

	private static bool RenderMovie_ReturnValue_IsValid;

	private static FFieldAddress RenderMovie_ReturnValue_PropertyAddress;

	private static int RenderMovie_ReturnValue_Offset;

	private static bool IsRenderingMovie_IsValid;

	private static IntPtr IsRenderingMovie_FunctionAddress;

	private static int IsRenderingMovie_ParamsSize;

	private static bool IsRenderingMovie_ReturnValue_IsValid;

	private static FFieldAddress IsRenderingMovie_ReturnValue_PropertyAddress;

	private static int IsRenderingMovie_ReturnValue_Offset;

	private static bool IsEventEndpointValid_IsValid;

	private static IntPtr IsEventEndpointValid_FunctionAddress;

	private static int IsEventEndpointValid_ParamsSize;

	private static bool IsEventEndpointValid_InEndpoint_IsValid;

	private static FFieldAddress IsEventEndpointValid_InEndpoint_PropertyAddress;

	private static int IsEventEndpointValid_InEndpoint_Offset;

	private static bool IsEventEndpointValid_ReturnValue_IsValid;

	private static FFieldAddress IsEventEndpointValid_ReturnValue_PropertyAddress;

	private static int IsEventEndpointValid_ReturnValue_Offset;

	private static bool ImportLevelSequenceFBX_IsValid;

	private static IntPtr ImportLevelSequenceFBX_FunctionAddress;

	private static int ImportLevelSequenceFBX_ParamsSize;

	private static bool ImportLevelSequenceFBX_InWorld_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_InWorld_PropertyAddress;

	private static int ImportLevelSequenceFBX_InWorld_Offset;

	private static bool ImportLevelSequenceFBX_InSequence_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_InSequence_PropertyAddress;

	private static int ImportLevelSequenceFBX_InSequence_Offset;

	private static bool ImportLevelSequenceFBX_InBindings_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_InBindings_PropertyAddress;

	private static int ImportLevelSequenceFBX_InBindings_Offset;

	private static bool ImportLevelSequenceFBX_InImportFBXSettings_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_InImportFBXSettings_PropertyAddress;

	private static int ImportLevelSequenceFBX_InImportFBXSettings_Offset;

	private static bool ImportLevelSequenceFBX_InImportFilename_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_InImportFilename_PropertyAddress;

	private static int ImportLevelSequenceFBX_InImportFilename_Offset;

	private static bool ImportLevelSequenceFBX_ReturnValue_IsValid;

	private static FFieldAddress ImportLevelSequenceFBX_ReturnValue_PropertyAddress;

	private static int ImportLevelSequenceFBX_ReturnValue_Offset;

	private static bool ImportFBXToControlRig_IsValid;

	private static IntPtr ImportFBXToControlRig_FunctionAddress;

	private static int ImportFBXToControlRig_ParamsSize;

	private static bool ImportFBXToControlRig_World_IsValid;

	private static FFieldAddress ImportFBXToControlRig_World_PropertyAddress;

	private static int ImportFBXToControlRig_World_Offset;

	private static bool ImportFBXToControlRig_InSequence_IsValid;

	private static FFieldAddress ImportFBXToControlRig_InSequence_PropertyAddress;

	private static int ImportFBXToControlRig_InSequence_Offset;

	private static bool ImportFBXToControlRig_ActorWithControlRigTrack_IsValid;

	private static FFieldAddress ImportFBXToControlRig_ActorWithControlRigTrack_PropertyAddress;

	private static int ImportFBXToControlRig_ActorWithControlRigTrack_Offset;

	private static bool ImportFBXToControlRig_SelectedControlRigNames_IsValid;

	private static FFieldAddress ImportFBXToControlRig_SelectedControlRigNames_PropertyAddress;

	private static int ImportFBXToControlRig_SelectedControlRigNames_Offset;

	private static bool ImportFBXToControlRig_ImportFBXControlRigSettings_IsValid;

	private static FFieldAddress ImportFBXToControlRig_ImportFBXControlRigSettings_PropertyAddress;

	private static int ImportFBXToControlRig_ImportFBXControlRigSettings_Offset;

	private static bool ImportFBXToControlRig_ImportFilename_IsValid;

	private static FFieldAddress ImportFBXToControlRig_ImportFilename_PropertyAddress;

	private static int ImportFBXToControlRig_ImportFilename_Offset;

	private static bool ImportFBXToControlRig_ReturnValue_IsValid;

	private static FFieldAddress ImportFBXToControlRig_ReturnValue_PropertyAddress;

	private static int ImportFBXToControlRig_ReturnValue_Offset;

	private static bool GetObjectBindings_IsValid;

	private static IntPtr GetObjectBindings_FunctionAddress;

	private static int GetObjectBindings_ParamsSize;

	private static bool GetObjectBindings_InWorld_IsValid;

	private static FFieldAddress GetObjectBindings_InWorld_PropertyAddress;

	private static int GetObjectBindings_InWorld_Offset;

	private static bool GetObjectBindings_InSequence_IsValid;

	private static FFieldAddress GetObjectBindings_InSequence_PropertyAddress;

	private static int GetObjectBindings_InSequence_Offset;

	private static bool GetObjectBindings_InObject_IsValid;

	private static FFieldAddress GetObjectBindings_InObject_PropertyAddress;

	private static int GetObjectBindings_InObject_Offset;

	private static bool GetObjectBindings_InRange_IsValid;

	private static FFieldAddress GetObjectBindings_InRange_PropertyAddress;

	private static int GetObjectBindings_InRange_Offset;

	private static bool GetObjectBindings_ReturnValue_IsValid;

	private static FFieldAddress GetObjectBindings_ReturnValue_PropertyAddress;

	private static int GetObjectBindings_ReturnValue_Offset;

	private static bool GetBoundObjects_IsValid;

	private static IntPtr GetBoundObjects_FunctionAddress;

	private static int GetBoundObjects_ParamsSize;

	private static bool GetBoundObjects_InWorld_IsValid;

	private static FFieldAddress GetBoundObjects_InWorld_PropertyAddress;

	private static int GetBoundObjects_InWorld_Offset;

	private static bool GetBoundObjects_InSequence_IsValid;

	private static FFieldAddress GetBoundObjects_InSequence_PropertyAddress;

	private static int GetBoundObjects_InSequence_Offset;

	private static bool GetBoundObjects_InBindings_IsValid;

	private static FFieldAddress GetBoundObjects_InBindings_PropertyAddress;

	private static int GetBoundObjects_InBindings_Offset;

	private static bool GetBoundObjects_InRange_IsValid;

	private static FFieldAddress GetBoundObjects_InRange_PropertyAddress;

	private static int GetBoundObjects_InRange_Offset;

	private static bool GetBoundObjects_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObjects_ReturnValue_PropertyAddress;

	private static int GetBoundObjects_ReturnValue_Offset;

	private static bool ExportLevelSequenceFBX_IsValid;

	private static IntPtr ExportLevelSequenceFBX_FunctionAddress;

	private static int ExportLevelSequenceFBX_ParamsSize;

	private static bool ExportLevelSequenceFBX_InWorld_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_InWorld_PropertyAddress;

	private static int ExportLevelSequenceFBX_InWorld_Offset;

	private static bool ExportLevelSequenceFBX_InSequence_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_InSequence_PropertyAddress;

	private static int ExportLevelSequenceFBX_InSequence_Offset;

	private static bool ExportLevelSequenceFBX_InBindings_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_InBindings_PropertyAddress;

	private static int ExportLevelSequenceFBX_InBindings_Offset;

	private static bool ExportLevelSequenceFBX_InMasterTracks_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_InMasterTracks_PropertyAddress;

	private static int ExportLevelSequenceFBX_InMasterTracks_Offset;

	private static bool ExportLevelSequenceFBX_OverrideOptions_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_OverrideOptions_PropertyAddress;

	private static int ExportLevelSequenceFBX_OverrideOptions_Offset;

	private static bool ExportLevelSequenceFBX_InFBXFileName_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_InFBXFileName_PropertyAddress;

	private static int ExportLevelSequenceFBX_InFBXFileName_Offset;

	private static bool ExportLevelSequenceFBX_ReturnValue_IsValid;

	private static FFieldAddress ExportLevelSequenceFBX_ReturnValue_PropertyAddress;

	private static int ExportLevelSequenceFBX_ReturnValue_Offset;

	private static bool ExportAnimSequence_IsValid;

	private static IntPtr ExportAnimSequence_FunctionAddress;

	private static int ExportAnimSequence_ParamsSize;

	private static bool ExportAnimSequence_World_IsValid;

	private static FFieldAddress ExportAnimSequence_World_PropertyAddress;

	private static int ExportAnimSequence_World_Offset;

	private static bool ExportAnimSequence_Sequence_IsValid;

	private static FFieldAddress ExportAnimSequence_Sequence_PropertyAddress;

	private static int ExportAnimSequence_Sequence_Offset;

	private static bool ExportAnimSequence_AnimSequence_IsValid;

	private static FFieldAddress ExportAnimSequence_AnimSequence_PropertyAddress;

	private static int ExportAnimSequence_AnimSequence_Offset;

	private static bool ExportAnimSequence_ExportOption_IsValid;

	private static FFieldAddress ExportAnimSequence_ExportOption_PropertyAddress;

	private static int ExportAnimSequence_ExportOption_Offset;

	private static bool ExportAnimSequence_Binding_IsValid;

	private static FFieldAddress ExportAnimSequence_Binding_PropertyAddress;

	private static int ExportAnimSequence_Binding_Offset;

	private static bool ExportAnimSequence_ReturnValue_IsValid;

	private static FFieldAddress ExportAnimSequence_ReturnValue_PropertyAddress;

	private static int ExportAnimSequence_ReturnValue_Offset;

	private static bool CreateQuickBinding_IsValid;

	private static IntPtr CreateQuickBinding_FunctionAddress;

	private static int CreateQuickBinding_ParamsSize;

	private static bool CreateQuickBinding_InSequence_IsValid;

	private static FFieldAddress CreateQuickBinding_InSequence_PropertyAddress;

	private static int CreateQuickBinding_InSequence_Offset;

	private static bool CreateQuickBinding_InObject_IsValid;

	private static FFieldAddress CreateQuickBinding_InObject_PropertyAddress;

	private static int CreateQuickBinding_InObject_Offset;

	private static bool CreateQuickBinding_InFunctionName_IsValid;

	private static FFieldAddress CreateQuickBinding_InFunctionName_PropertyAddress;

	private static int CreateQuickBinding_InFunctionName_Offset;

	private static bool CreateQuickBinding_bCallInEditor_IsValid;

	private static FFieldAddress CreateQuickBinding_bCallInEditor_PropertyAddress;

	private static int CreateQuickBinding_bCallInEditor_Offset;

	private static bool CreateQuickBinding_ReturnValue_IsValid;

	private static FFieldAddress CreateQuickBinding_ReturnValue_PropertyAddress;

	private static int CreateQuickBinding_ReturnValue_Offset;

	private static bool CreateEvent_IsValid;

	private static IntPtr CreateEvent_FunctionAddress;

	private static int CreateEvent_ParamsSize;

	private static bool CreateEvent_InSequence_IsValid;

	private static FFieldAddress CreateEvent_InSequence_PropertyAddress;

	private static int CreateEvent_InSequence_Offset;

	private static bool CreateEvent_InSection_IsValid;

	private static FFieldAddress CreateEvent_InSection_PropertyAddress;

	private static int CreateEvent_InSection_Offset;

	private static bool CreateEvent_InEndpoint_IsValid;

	private static FFieldAddress CreateEvent_InEndpoint_PropertyAddress;

	private static int CreateEvent_InEndpoint_Offset;

	private static bool CreateEvent_InPayload_IsValid;

	private static FFieldAddress CreateEvent_InPayload_PropertyAddress;

	private static int CreateEvent_InPayload_Offset;

	private static bool CreateEvent_ReturnValue_IsValid;

	private static FFieldAddress CreateEvent_ReturnValue_PropertyAddress;

	private static int CreateEvent_ReturnValue_Offset;

	private static bool CancelMovieRender_IsValid;

	private static IntPtr CancelMovieRender_FunctionAddress;

	private static int CancelMovieRender_ParamsSize;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:RenderMovie")]
	public unsafe static bool RenderMovie(UMovieSceneCapture InCaptureSettings, FOnRenderMovieStopped OnFinishedCallback)
	{
		if (!RenderMovie_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:RenderMovie");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderMovie_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderMovie_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneCapture>.ToNative(IntPtr.Add(intPtr, RenderMovie_InCaptureSettings_Offset), 0, RenderMovie_InCaptureSettings_PropertyAddress.Address, InCaptureSettings);
		FDelegateMarshaler<FOnRenderMovieStopped>.ToNative(IntPtr.Add(intPtr, RenderMovie_OnFinishedCallback_Offset), 0, RenderMovie_OnFinishedCallback_PropertyAddress.Address, OnFinishedCallback);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenderMovie_FunctionAddress, intPtr, RenderMovie_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenderMovie_ReturnValue_Offset), 0, RenderMovie_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsRenderingMovie")]
	public unsafe static bool IsRenderingMovie()
	{
		if (!IsRenderingMovie_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsRenderingMovie");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRenderingMovie_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRenderingMovie_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRenderingMovie_FunctionAddress, intPtr, IsRenderingMovie_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRenderingMovie_ReturnValue_Offset), 0, IsRenderingMovie_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsEventEndpointValid")]
	public unsafe static bool IsEventEndpointValid(FSequencerQuickBindingResult InEndpoint)
	{
		if (!IsEventEndpointValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsEventEndpointValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEventEndpointValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEventEndpointValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsEventEndpointValid_InEndpoint_PropertyAddress.Address, intPtr);
		FSequencerQuickBindingResult.ToNative(IntPtr.Add(intPtr, IsEventEndpointValid_InEndpoint_Offset), 0, IsEventEndpointValid_InEndpoint_PropertyAddress.Address, InEndpoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsEventEndpointValid_FunctionAddress, intPtr, IsEventEndpointValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsEventEndpointValid_InEndpoint_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEventEndpointValid_ReturnValue_Offset), 0, IsEventEndpointValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportLevelSequenceFBX")]
	public unsafe static bool ImportLevelSequenceFBX(UWorld InWorld, ULevelSequence InSequence, List<FSequencerBindingProxy> InBindings, UMovieSceneUserImportFBXSettings InImportFBXSettings, string InImportFilename)
	{
		if (!ImportLevelSequenceFBX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportLevelSequenceFBX");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportLevelSequenceFBX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportLevelSequenceFBX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_InWorld_Offset), 0, ImportLevelSequenceFBX_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_InSequence_Offset), 0, ImportLevelSequenceFBX_InSequence_PropertyAddress.Address, InSequence);
		new TArrayCopyMarshaler<FSequencerBindingProxy>(1, ImportLevelSequenceFBX_InBindings_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).ToNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_InBindings_Offset), InBindings);
		UObjectMarshaler<UMovieSceneUserImportFBXSettings>.ToNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_InImportFBXSettings_Offset), 0, ImportLevelSequenceFBX_InImportFBXSettings_PropertyAddress.Address, InImportFBXSettings);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_InImportFilename_Offset), 0, ImportLevelSequenceFBX_InImportFilename_PropertyAddress.Address, InImportFilename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportLevelSequenceFBX_FunctionAddress, intPtr, ImportLevelSequenceFBX_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportLevelSequenceFBX_InBindings_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportLevelSequenceFBX_InImportFilename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ImportLevelSequenceFBX_ReturnValue_Offset), 0, ImportLevelSequenceFBX_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportFBXToControlRig")]
	public unsafe static bool ImportFBXToControlRig(UWorld World, ULevelSequence InSequence, string ActorWithControlRigTrack, List<string> SelectedControlRigNames, UMovieSceneUserImportFBXControlRigSettings ImportFBXControlRigSettings, string ImportFilename)
	{
		if (!ImportFBXToControlRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportFBXToControlRig");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportFBXToControlRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportFBXToControlRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_World_Offset), 0, ImportFBXToControlRig_World_PropertyAddress.Address, World);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_InSequence_Offset), 0, ImportFBXToControlRig_InSequence_PropertyAddress.Address, InSequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_ActorWithControlRigTrack_Offset), 0, ImportFBXToControlRig_ActorWithControlRigTrack_PropertyAddress.Address, ActorWithControlRigTrack);
		new TArrayCopyMarshaler<string>(1, ImportFBXToControlRig_SelectedControlRigNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_SelectedControlRigNames_Offset), SelectedControlRigNames);
		UObjectMarshaler<UMovieSceneUserImportFBXControlRigSettings>.ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_ImportFBXControlRigSettings_Offset), 0, ImportFBXToControlRig_ImportFBXControlRigSettings_PropertyAddress.Address, ImportFBXControlRigSettings);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportFBXToControlRig_ImportFilename_Offset), 0, ImportFBXToControlRig_ImportFilename_PropertyAddress.Address, ImportFilename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportFBXToControlRig_FunctionAddress, intPtr, ImportFBXToControlRig_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportFBXToControlRig_ActorWithControlRigTrack_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportFBXToControlRig_SelectedControlRigNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportFBXToControlRig_ImportFilename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ImportFBXToControlRig_ReturnValue_Offset), 0, ImportFBXToControlRig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetObjectBindings")]
	public unsafe static List<FSequencerBoundObjects> GetObjectBindings(UWorld InWorld, ULevelSequence InSequence, List<UObject> InObject, FSequencerScriptingRange InRange)
	{
		if (!GetObjectBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetObjectBindings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetObjectBindings_InWorld_Offset), 0, GetObjectBindings_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetObjectBindings_InSequence_Offset), 0, GetObjectBindings_InSequence_PropertyAddress.Address, InSequence);
		new TArrayCopyMarshaler<UObject>(1, GetObjectBindings_InObject_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, GetObjectBindings_InObject_Offset), InObject);
		NativeReflection.InitializeValue_InContainer(GetObjectBindings_InRange_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetObjectBindings_InRange_Offset), 0, GetObjectBindings_InRange_PropertyAddress.Address, InRange);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjectBindings_FunctionAddress, intPtr, GetObjectBindings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetObjectBindings_InObject_PropertyAddress.Address, intPtr);
		List<FSequencerBoundObjects> result = new TArrayCopyMarshaler<FSequencerBoundObjects>(1, GetObjectBindings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBoundObjects, FSequencerBoundObjects>.FromNative, CachedMarshalingDelegates<FSequencerBoundObjects, FSequencerBoundObjects>.ToNative).FromNative(IntPtr.Add(intPtr, GetObjectBindings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetObjectBindings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetBoundObjects")]
	public unsafe static List<FSequencerBoundObjects> GetBoundObjects(UWorld InWorld, ULevelSequence InSequence, List<FSequencerBindingProxy> InBindings, FSequencerScriptingRange InRange)
	{
		if (!GetBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetBoundObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetBoundObjects_InWorld_Offset), 0, GetBoundObjects_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetBoundObjects_InSequence_Offset), 0, GetBoundObjects_InSequence_PropertyAddress.Address, InSequence);
		new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetBoundObjects_InBindings_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).ToNative(IntPtr.Add(intPtr, GetBoundObjects_InBindings_Offset), InBindings);
		NativeReflection.InitializeValue_InContainer(GetBoundObjects_InRange_PropertyAddress.Address, intPtr);
		FSequencerScriptingRange.ToNative(IntPtr.Add(intPtr, GetBoundObjects_InRange_Offset), 0, GetBoundObjects_InRange_PropertyAddress.Address, InRange);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoundObjects_FunctionAddress, intPtr, GetBoundObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoundObjects_InBindings_PropertyAddress.Address, intPtr);
		List<FSequencerBoundObjects> result = new TArrayCopyMarshaler<FSequencerBoundObjects>(1, GetBoundObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBoundObjects, FSequencerBoundObjects>.FromNative, CachedMarshalingDelegates<FSequencerBoundObjects, FSequencerBoundObjects>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportLevelSequenceFBX")]
	public unsafe static bool ExportLevelSequenceFBX(UWorld InWorld, ULevelSequence InSequence, List<FSequencerBindingProxy> InBindings, List<UMovieSceneTrack> InMasterTracks, UFbxExportOption OverrideOptions, string InFBXFileName)
	{
		if (!ExportLevelSequenceFBX_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportLevelSequenceFBX");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportLevelSequenceFBX_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportLevelSequenceFBX_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_InWorld_Offset), 0, ExportLevelSequenceFBX_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_InSequence_Offset), 0, ExportLevelSequenceFBX_InSequence_PropertyAddress.Address, InSequence);
		new TArrayCopyMarshaler<FSequencerBindingProxy>(1, ExportLevelSequenceFBX_InBindings_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_InBindings_Offset), InBindings);
		new TArrayCopyMarshaler<UMovieSceneTrack>(1, ExportLevelSequenceFBX_InMasterTracks_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_InMasterTracks_Offset), InMasterTracks);
		UObjectMarshaler<UFbxExportOption>.ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_OverrideOptions_Offset), 0, ExportLevelSequenceFBX_OverrideOptions_PropertyAddress.Address, OverrideOptions);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_InFBXFileName_Offset), 0, ExportLevelSequenceFBX_InFBXFileName_PropertyAddress.Address, InFBXFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportLevelSequenceFBX_FunctionAddress, intPtr, ExportLevelSequenceFBX_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportLevelSequenceFBX_InBindings_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportLevelSequenceFBX_InMasterTracks_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportLevelSequenceFBX_InFBXFileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportLevelSequenceFBX_ReturnValue_Offset), 0, ExportLevelSequenceFBX_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportAnimSequence")]
	public unsafe static bool ExportAnimSequence(UWorld World, ULevelSequence Sequence, UAnimSequence AnimSequence, UAnimSeqExportOption ExportOption, FSequencerBindingProxy Binding)
	{
		if (!ExportAnimSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportAnimSequence");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportAnimSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportAnimSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ExportAnimSequence_World_Offset), 0, ExportAnimSequence_World_PropertyAddress.Address, World);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ExportAnimSequence_Sequence_Offset), 0, ExportAnimSequence_Sequence_PropertyAddress.Address, Sequence);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ExportAnimSequence_AnimSequence_Offset), 0, ExportAnimSequence_AnimSequence_PropertyAddress.Address, AnimSequence);
		UObjectMarshaler<UAnimSeqExportOption>.ToNative(IntPtr.Add(intPtr, ExportAnimSequence_ExportOption_Offset), 0, ExportAnimSequence_ExportOption_PropertyAddress.Address, ExportOption);
		NativeReflection.InitializeValue_InContainer(ExportAnimSequence_Binding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, ExportAnimSequence_Binding_Offset), 0, ExportAnimSequence_Binding_PropertyAddress.Address, Binding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportAnimSequence_FunctionAddress, intPtr, ExportAnimSequence_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportAnimSequence_ReturnValue_Offset), 0, ExportAnimSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateQuickBinding")]
	public unsafe static FSequencerQuickBindingResult CreateQuickBinding(UMovieSceneSequence InSequence, UObject InObject, string InFunctionName, bool bCallInEditor)
	{
		if (!CreateQuickBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateQuickBinding");
			return default(FSequencerQuickBindingResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateQuickBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateQuickBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, CreateQuickBinding_InSequence_Offset), 0, CreateQuickBinding_InSequence_PropertyAddress.Address, InSequence);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateQuickBinding_InObject_Offset), 0, CreateQuickBinding_InObject_PropertyAddress.Address, InObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateQuickBinding_InFunctionName_Offset), 0, CreateQuickBinding_InFunctionName_PropertyAddress.Address, InFunctionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateQuickBinding_bCallInEditor_Offset), 0, CreateQuickBinding_bCallInEditor_PropertyAddress.Address, bCallInEditor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateQuickBinding_FunctionAddress, intPtr, CreateQuickBinding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateQuickBinding_InFunctionName_PropertyAddress.Address, intPtr);
		FSequencerQuickBindingResult result = FSequencerQuickBindingResult.FromNative(IntPtr.Add(intPtr, CreateQuickBinding_ReturnValue_Offset), 0, CreateQuickBinding_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateQuickBinding_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateEvent")]
	public unsafe static FMovieSceneEvent CreateEvent(UMovieSceneSequence InSequence, UMovieSceneEventSectionBase InSection, FSequencerQuickBindingResult InEndpoint, List<string> InPayload)
	{
		if (!CreateEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateEvent");
			return default(FMovieSceneEvent);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, CreateEvent_InSequence_Offset), 0, CreateEvent_InSequence_PropertyAddress.Address, InSequence);
		UObjectMarshaler<UMovieSceneEventSectionBase>.ToNative(IntPtr.Add(intPtr, CreateEvent_InSection_Offset), 0, CreateEvent_InSection_PropertyAddress.Address, InSection);
		NativeReflection.InitializeValue_InContainer(CreateEvent_InEndpoint_PropertyAddress.Address, intPtr);
		FSequencerQuickBindingResult.ToNative(IntPtr.Add(intPtr, CreateEvent_InEndpoint_Offset), 0, CreateEvent_InEndpoint_PropertyAddress.Address, InEndpoint);
		new TArrayCopyMarshaler<string>(1, CreateEvent_InPayload_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CreateEvent_InPayload_Offset), InPayload);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateEvent_FunctionAddress, intPtr, CreateEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateEvent_InEndpoint_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateEvent_InPayload_PropertyAddress.Address, intPtr);
		FMovieSceneEvent result = FMovieSceneEvent.FromNative(IntPtr.Add(intPtr, CreateEvent_ReturnValue_Offset), 0, CreateEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CancelMovieRender")]
	public unsafe static void CancelMovieRender()
	{
		if (!CancelMovieRender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CancelMovieRender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelMovieRender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelMovieRender_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CancelMovieRender_FunctionAddress, argsSize: CancelMovieRender_ParamsSize);
	}

	static USequencerTools()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequencerTools)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequencerTools));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary");
		RenderMovie_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenderMovie");
		RenderMovie_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderMovie_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderMovie_InCaptureSettings_PropertyAddress, RenderMovie_FunctionAddress, "InCaptureSettings");
		RenderMovie_InCaptureSettings_Offset = NativeReflectionCached.GetPropertyOffset(RenderMovie_FunctionAddress, "InCaptureSettings");
		RenderMovie_InCaptureSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderMovie_FunctionAddress, "InCaptureSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderMovie_OnFinishedCallback_PropertyAddress, RenderMovie_FunctionAddress, "OnFinishedCallback");
		RenderMovie_OnFinishedCallback_Offset = NativeReflectionCached.GetPropertyOffset(RenderMovie_FunctionAddress, "OnFinishedCallback");
		RenderMovie_OnFinishedCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderMovie_FunctionAddress, "OnFinishedCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderMovie_ReturnValue_PropertyAddress, RenderMovie_FunctionAddress, "ReturnValue");
		RenderMovie_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenderMovie_FunctionAddress, "ReturnValue");
		RenderMovie_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderMovie_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenderMovie_IsValid = RenderMovie_FunctionAddress != IntPtr.Zero && RenderMovie_InCaptureSettings_IsValid && RenderMovie_OnFinishedCallback_IsValid && RenderMovie_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:RenderMovie", RenderMovie_IsValid);
		IsRenderingMovie_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRenderingMovie");
		IsRenderingMovie_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRenderingMovie_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRenderingMovie_ReturnValue_PropertyAddress, IsRenderingMovie_FunctionAddress, "ReturnValue");
		IsRenderingMovie_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRenderingMovie_FunctionAddress, "ReturnValue");
		IsRenderingMovie_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRenderingMovie_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRenderingMovie_IsValid = IsRenderingMovie_FunctionAddress != IntPtr.Zero && IsRenderingMovie_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsRenderingMovie", IsRenderingMovie_IsValid);
		IsEventEndpointValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEventEndpointValid");
		IsEventEndpointValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEventEndpointValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEventEndpointValid_InEndpoint_PropertyAddress, IsEventEndpointValid_FunctionAddress, "InEndpoint");
		IsEventEndpointValid_InEndpoint_Offset = NativeReflectionCached.GetPropertyOffset(IsEventEndpointValid_FunctionAddress, "InEndpoint");
		IsEventEndpointValid_InEndpoint_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEventEndpointValid_FunctionAddress, "InEndpoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEventEndpointValid_ReturnValue_PropertyAddress, IsEventEndpointValid_FunctionAddress, "ReturnValue");
		IsEventEndpointValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEventEndpointValid_FunctionAddress, "ReturnValue");
		IsEventEndpointValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEventEndpointValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEventEndpointValid_IsValid = IsEventEndpointValid_FunctionAddress != IntPtr.Zero && IsEventEndpointValid_InEndpoint_IsValid && IsEventEndpointValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:IsEventEndpointValid", IsEventEndpointValid_IsValid);
		ImportLevelSequenceFBX_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportLevelSequenceFBX");
		ImportLevelSequenceFBX_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportLevelSequenceFBX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_InWorld_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "InWorld");
		ImportLevelSequenceFBX_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "InWorld");
		ImportLevelSequenceFBX_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_InSequence_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "InSequence");
		ImportLevelSequenceFBX_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "InSequence");
		ImportLevelSequenceFBX_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_InBindings_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "InBindings");
		ImportLevelSequenceFBX_InBindings_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "InBindings");
		ImportLevelSequenceFBX_InBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "InBindings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_InImportFBXSettings_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "InImportFBXSettings");
		ImportLevelSequenceFBX_InImportFBXSettings_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "InImportFBXSettings");
		ImportLevelSequenceFBX_InImportFBXSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "InImportFBXSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_InImportFilename_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "InImportFilename");
		ImportLevelSequenceFBX_InImportFilename_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "InImportFilename");
		ImportLevelSequenceFBX_InImportFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "InImportFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportLevelSequenceFBX_ReturnValue_PropertyAddress, ImportLevelSequenceFBX_FunctionAddress, "ReturnValue");
		ImportLevelSequenceFBX_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportLevelSequenceFBX_FunctionAddress, "ReturnValue");
		ImportLevelSequenceFBX_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportLevelSequenceFBX_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ImportLevelSequenceFBX_IsValid = ImportLevelSequenceFBX_FunctionAddress != IntPtr.Zero && ImportLevelSequenceFBX_InWorld_IsValid && ImportLevelSequenceFBX_InSequence_IsValid && ImportLevelSequenceFBX_InBindings_IsValid && ImportLevelSequenceFBX_InImportFBXSettings_IsValid && ImportLevelSequenceFBX_InImportFilename_IsValid && ImportLevelSequenceFBX_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportLevelSequenceFBX", ImportLevelSequenceFBX_IsValid);
		ImportFBXToControlRig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportFBXToControlRig");
		ImportFBXToControlRig_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportFBXToControlRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_World_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "World");
		ImportFBXToControlRig_World_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "World");
		ImportFBXToControlRig_World_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_InSequence_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "InSequence");
		ImportFBXToControlRig_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "InSequence");
		ImportFBXToControlRig_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_ActorWithControlRigTrack_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "ActorWithControlRigTrack");
		ImportFBXToControlRig_ActorWithControlRigTrack_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "ActorWithControlRigTrack");
		ImportFBXToControlRig_ActorWithControlRigTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "ActorWithControlRigTrack", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_SelectedControlRigNames_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "SelectedControlRigNames");
		ImportFBXToControlRig_SelectedControlRigNames_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "SelectedControlRigNames");
		ImportFBXToControlRig_SelectedControlRigNames_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "SelectedControlRigNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_ImportFBXControlRigSettings_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "ImportFBXControlRigSettings");
		ImportFBXToControlRig_ImportFBXControlRigSettings_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "ImportFBXControlRigSettings");
		ImportFBXToControlRig_ImportFBXControlRigSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "ImportFBXControlRigSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_ImportFilename_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "ImportFilename");
		ImportFBXToControlRig_ImportFilename_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "ImportFilename");
		ImportFBXToControlRig_ImportFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "ImportFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFBXToControlRig_ReturnValue_PropertyAddress, ImportFBXToControlRig_FunctionAddress, "ReturnValue");
		ImportFBXToControlRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportFBXToControlRig_FunctionAddress, "ReturnValue");
		ImportFBXToControlRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFBXToControlRig_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ImportFBXToControlRig_IsValid = ImportFBXToControlRig_FunctionAddress != IntPtr.Zero && ImportFBXToControlRig_World_IsValid && ImportFBXToControlRig_InSequence_IsValid && ImportFBXToControlRig_ActorWithControlRigTrack_IsValid && ImportFBXToControlRig_SelectedControlRigNames_IsValid && ImportFBXToControlRig_ImportFBXControlRigSettings_IsValid && ImportFBXToControlRig_ImportFilename_IsValid && ImportFBXToControlRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ImportFBXToControlRig", ImportFBXToControlRig_IsValid);
		GetObjectBindings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjectBindings");
		GetObjectBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_InWorld_PropertyAddress, GetObjectBindings_FunctionAddress, "InWorld");
		GetObjectBindings_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "InWorld");
		GetObjectBindings_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_InSequence_PropertyAddress, GetObjectBindings_FunctionAddress, "InSequence");
		GetObjectBindings_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "InSequence");
		GetObjectBindings_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_InObject_PropertyAddress, GetObjectBindings_FunctionAddress, "InObject");
		GetObjectBindings_InObject_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "InObject");
		GetObjectBindings_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "InObject", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_InRange_PropertyAddress, GetObjectBindings_FunctionAddress, "InRange");
		GetObjectBindings_InRange_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "InRange");
		GetObjectBindings_InRange_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "InRange", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_ReturnValue_PropertyAddress, GetObjectBindings_FunctionAddress, "ReturnValue");
		GetObjectBindings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "ReturnValue");
		GetObjectBindings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetObjectBindings_IsValid = GetObjectBindings_FunctionAddress != IntPtr.Zero && GetObjectBindings_InWorld_IsValid && GetObjectBindings_InSequence_IsValid && GetObjectBindings_InObject_IsValid && GetObjectBindings_InRange_IsValid && GetObjectBindings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetObjectBindings", GetObjectBindings_IsValid);
		GetBoundObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoundObjects");
		GetBoundObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_InWorld_PropertyAddress, GetBoundObjects_FunctionAddress, "InWorld");
		GetBoundObjects_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "InWorld");
		GetBoundObjects_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_InSequence_PropertyAddress, GetBoundObjects_FunctionAddress, "InSequence");
		GetBoundObjects_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "InSequence");
		GetBoundObjects_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_InBindings_PropertyAddress, GetBoundObjects_FunctionAddress, "InBindings");
		GetBoundObjects_InBindings_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "InBindings");
		GetBoundObjects_InBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "InBindings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_InRange_PropertyAddress, GetBoundObjects_FunctionAddress, "InRange");
		GetBoundObjects_InRange_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "InRange");
		GetBoundObjects_InRange_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "InRange", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ReturnValue_PropertyAddress, GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundObjects_IsValid = GetBoundObjects_FunctionAddress != IntPtr.Zero && GetBoundObjects_InWorld_IsValid && GetBoundObjects_InSequence_IsValid && GetBoundObjects_InBindings_IsValid && GetBoundObjects_InRange_IsValid && GetBoundObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:GetBoundObjects", GetBoundObjects_IsValid);
		ExportLevelSequenceFBX_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportLevelSequenceFBX");
		ExportLevelSequenceFBX_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportLevelSequenceFBX_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_InWorld_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "InWorld");
		ExportLevelSequenceFBX_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "InWorld");
		ExportLevelSequenceFBX_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_InSequence_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "InSequence");
		ExportLevelSequenceFBX_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "InSequence");
		ExportLevelSequenceFBX_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_InBindings_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "InBindings");
		ExportLevelSequenceFBX_InBindings_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "InBindings");
		ExportLevelSequenceFBX_InBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "InBindings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_InMasterTracks_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "InMasterTracks");
		ExportLevelSequenceFBX_InMasterTracks_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "InMasterTracks");
		ExportLevelSequenceFBX_InMasterTracks_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "InMasterTracks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_OverrideOptions_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "OverrideOptions");
		ExportLevelSequenceFBX_OverrideOptions_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "OverrideOptions");
		ExportLevelSequenceFBX_OverrideOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "OverrideOptions", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_InFBXFileName_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "InFBXFileName");
		ExportLevelSequenceFBX_InFBXFileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "InFBXFileName");
		ExportLevelSequenceFBX_InFBXFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "InFBXFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportLevelSequenceFBX_ReturnValue_PropertyAddress, ExportLevelSequenceFBX_FunctionAddress, "ReturnValue");
		ExportLevelSequenceFBX_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevelSequenceFBX_FunctionAddress, "ReturnValue");
		ExportLevelSequenceFBX_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevelSequenceFBX_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportLevelSequenceFBX_IsValid = ExportLevelSequenceFBX_FunctionAddress != IntPtr.Zero && ExportLevelSequenceFBX_InWorld_IsValid && ExportLevelSequenceFBX_InSequence_IsValid && ExportLevelSequenceFBX_InBindings_IsValid && ExportLevelSequenceFBX_InMasterTracks_IsValid && ExportLevelSequenceFBX_OverrideOptions_IsValid && ExportLevelSequenceFBX_InFBXFileName_IsValid && ExportLevelSequenceFBX_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportLevelSequenceFBX", ExportLevelSequenceFBX_IsValid);
		ExportAnimSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportAnimSequence");
		ExportAnimSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportAnimSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_World_PropertyAddress, ExportAnimSequence_FunctionAddress, "World");
		ExportAnimSequence_World_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "World");
		ExportAnimSequence_World_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_Sequence_PropertyAddress, ExportAnimSequence_FunctionAddress, "Sequence");
		ExportAnimSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "Sequence");
		ExportAnimSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_AnimSequence_PropertyAddress, ExportAnimSequence_FunctionAddress, "AnimSequence");
		ExportAnimSequence_AnimSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "AnimSequence");
		ExportAnimSequence_AnimSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_ExportOption_PropertyAddress, ExportAnimSequence_FunctionAddress, "ExportOption");
		ExportAnimSequence_ExportOption_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "ExportOption");
		ExportAnimSequence_ExportOption_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "ExportOption", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_Binding_PropertyAddress, ExportAnimSequence_FunctionAddress, "Binding");
		ExportAnimSequence_Binding_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "Binding");
		ExportAnimSequence_Binding_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "Binding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAnimSequence_ReturnValue_PropertyAddress, ExportAnimSequence_FunctionAddress, "ReturnValue");
		ExportAnimSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportAnimSequence_FunctionAddress, "ReturnValue");
		ExportAnimSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAnimSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportAnimSequence_IsValid = ExportAnimSequence_FunctionAddress != IntPtr.Zero && ExportAnimSequence_World_IsValid && ExportAnimSequence_Sequence_IsValid && ExportAnimSequence_AnimSequence_IsValid && ExportAnimSequence_ExportOption_IsValid && ExportAnimSequence_Binding_IsValid && ExportAnimSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:ExportAnimSequence", ExportAnimSequence_IsValid);
		CreateQuickBinding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateQuickBinding");
		CreateQuickBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateQuickBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateQuickBinding_InSequence_PropertyAddress, CreateQuickBinding_FunctionAddress, "InSequence");
		CreateQuickBinding_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuickBinding_FunctionAddress, "InSequence");
		CreateQuickBinding_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuickBinding_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuickBinding_InObject_PropertyAddress, CreateQuickBinding_FunctionAddress, "InObject");
		CreateQuickBinding_InObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuickBinding_FunctionAddress, "InObject");
		CreateQuickBinding_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuickBinding_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuickBinding_InFunctionName_PropertyAddress, CreateQuickBinding_FunctionAddress, "InFunctionName");
		CreateQuickBinding_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuickBinding_FunctionAddress, "InFunctionName");
		CreateQuickBinding_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuickBinding_FunctionAddress, "InFunctionName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuickBinding_bCallInEditor_PropertyAddress, CreateQuickBinding_FunctionAddress, "bCallInEditor");
		CreateQuickBinding_bCallInEditor_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuickBinding_FunctionAddress, "bCallInEditor");
		CreateQuickBinding_bCallInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuickBinding_FunctionAddress, "bCallInEditor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateQuickBinding_ReturnValue_PropertyAddress, CreateQuickBinding_FunctionAddress, "ReturnValue");
		CreateQuickBinding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateQuickBinding_FunctionAddress, "ReturnValue");
		CreateQuickBinding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateQuickBinding_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateQuickBinding_IsValid = CreateQuickBinding_FunctionAddress != IntPtr.Zero && CreateQuickBinding_InSequence_IsValid && CreateQuickBinding_InObject_IsValid && CreateQuickBinding_InFunctionName_IsValid && CreateQuickBinding_bCallInEditor_IsValid && CreateQuickBinding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateQuickBinding", CreateQuickBinding_IsValid);
		CreateEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateEvent");
		CreateEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateEvent_InSequence_PropertyAddress, CreateEvent_FunctionAddress, "InSequence");
		CreateEvent_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(CreateEvent_FunctionAddress, "InSequence");
		CreateEvent_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEvent_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEvent_InSection_PropertyAddress, CreateEvent_FunctionAddress, "InSection");
		CreateEvent_InSection_Offset = NativeReflectionCached.GetPropertyOffset(CreateEvent_FunctionAddress, "InSection");
		CreateEvent_InSection_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEvent_FunctionAddress, "InSection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEvent_InEndpoint_PropertyAddress, CreateEvent_FunctionAddress, "InEndpoint");
		CreateEvent_InEndpoint_Offset = NativeReflectionCached.GetPropertyOffset(CreateEvent_FunctionAddress, "InEndpoint");
		CreateEvent_InEndpoint_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEvent_FunctionAddress, "InEndpoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEvent_InPayload_PropertyAddress, CreateEvent_FunctionAddress, "InPayload");
		CreateEvent_InPayload_Offset = NativeReflectionCached.GetPropertyOffset(CreateEvent_FunctionAddress, "InPayload");
		CreateEvent_InPayload_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEvent_FunctionAddress, "InPayload", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEvent_ReturnValue_PropertyAddress, CreateEvent_FunctionAddress, "ReturnValue");
		CreateEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateEvent_FunctionAddress, "ReturnValue");
		CreateEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateEvent_IsValid = CreateEvent_FunctionAddress != IntPtr.Zero && CreateEvent_InSequence_IsValid && CreateEvent_InSection_IsValid && CreateEvent_InEndpoint_IsValid && CreateEvent_InPayload_IsValid && CreateEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CreateEvent", CreateEvent_IsValid);
		CancelMovieRender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelMovieRender");
		CancelMovieRender_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelMovieRender_FunctionAddress);
		CancelMovieRender_IsValid = CancelMovieRender_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScriptingEditor.SequencerToolsFunctionLibrary:CancelMovieRender", CancelMovieRender_IsValid);
	}
}
