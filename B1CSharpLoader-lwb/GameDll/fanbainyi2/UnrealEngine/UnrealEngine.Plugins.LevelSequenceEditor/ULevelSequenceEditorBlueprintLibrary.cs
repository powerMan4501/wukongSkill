using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LevelSequenceEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary", "LevelSequenceEditor", UnrealModuleType.EnginePlugin)]
public class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetTrackFilterEnabled_IsValid;

	private static IntPtr SetTrackFilterEnabled_FunctionAddress;

	private static int SetTrackFilterEnabled_ParamsSize;

	private static bool SetTrackFilterEnabled_TrackFilterName_IsValid;

	private static FFieldAddress SetTrackFilterEnabled_TrackFilterName_PropertyAddress;

	private static int SetTrackFilterEnabled_TrackFilterName_Offset;

	private static bool SetTrackFilterEnabled_bEnabled_IsValid;

	private static FFieldAddress SetTrackFilterEnabled_bEnabled_PropertyAddress;

	private static int SetTrackFilterEnabled_bEnabled_Offset;

	private static bool SetSelectionRangeStart_IsValid;

	private static IntPtr SetSelectionRangeStart_FunctionAddress;

	private static int SetSelectionRangeStart_ParamsSize;

	private static bool SetSelectionRangeStart_NewFrame_IsValid;

	private static FFieldAddress SetSelectionRangeStart_NewFrame_PropertyAddress;

	private static int SetSelectionRangeStart_NewFrame_Offset;

	private static bool SetSelectionRangeEnd_IsValid;

	private static IntPtr SetSelectionRangeEnd_FunctionAddress;

	private static int SetSelectionRangeEnd_ParamsSize;

	private static bool SetSelectionRangeEnd_NewFrame_IsValid;

	private static FFieldAddress SetSelectionRangeEnd_NewFrame_PropertyAddress;

	private static int SetSelectionRangeEnd_NewFrame_Offset;

	private static bool SetRandomColorForChannels_IsValid;

	private static IntPtr SetRandomColorForChannels_FunctionAddress;

	private static int SetRandomColorForChannels_ParamsSize;

	private static bool SetRandomColorForChannels_Class_IsValid;

	private static FFieldAddress SetRandomColorForChannels_Class_PropertyAddress;

	private static int SetRandomColorForChannels_Class_Offset;

	private static bool SetRandomColorForChannels_Identifiers_IsValid;

	private static FFieldAddress SetRandomColorForChannels_Identifiers_PropertyAddress;

	private static int SetRandomColorForChannels_Identifiers_Offset;

	private static bool SetLockLevelSequence_IsValid;

	private static IntPtr SetLockLevelSequence_FunctionAddress;

	private static int SetLockLevelSequence_ParamsSize;

	private static bool SetLockLevelSequence_bLock_IsValid;

	private static FFieldAddress SetLockLevelSequence_bLock_PropertyAddress;

	private static int SetLockLevelSequence_bLock_Offset;

	private static bool SetLockCameraCutToViewport_IsValid;

	private static IntPtr SetLockCameraCutToViewport_FunctionAddress;

	private static int SetLockCameraCutToViewport_ParamsSize;

	private static bool SetLockCameraCutToViewport_bLock_IsValid;

	private static FFieldAddress SetLockCameraCutToViewport_bLock_PropertyAddress;

	private static int SetLockCameraCutToViewport_bLock_Offset;

	private static bool SetCustomColorForChannels_IsValid;

	private static IntPtr SetCustomColorForChannels_FunctionAddress;

	private static int SetCustomColorForChannels_ParamsSize;

	private static bool SetCustomColorForChannels_Class_IsValid;

	private static FFieldAddress SetCustomColorForChannels_Class_PropertyAddress;

	private static int SetCustomColorForChannels_Class_Offset;

	private static bool SetCustomColorForChannels_Identifiers_IsValid;

	private static FFieldAddress SetCustomColorForChannels_Identifiers_PropertyAddress;

	private static int SetCustomColorForChannels_Identifiers_Offset;

	private static bool SetCustomColorForChannels_NewColors_IsValid;

	private static FFieldAddress SetCustomColorForChannels_NewColors_PropertyAddress;

	private static int SetCustomColorForChannels_NewColors_Offset;

	private static bool SetCustomColorForChannel_IsValid;

	private static IntPtr SetCustomColorForChannel_FunctionAddress;

	private static int SetCustomColorForChannel_ParamsSize;

	private static bool SetCustomColorForChannel_Class_IsValid;

	private static FFieldAddress SetCustomColorForChannel_Class_PropertyAddress;

	private static int SetCustomColorForChannel_Class_Offset;

	private static bool SetCustomColorForChannel_Identifier_IsValid;

	private static FFieldAddress SetCustomColorForChannel_Identifier_PropertyAddress;

	private static int SetCustomColorForChannel_Identifier_Offset;

	private static bool SetCustomColorForChannel_NewColor_IsValid;

	private static FFieldAddress SetCustomColorForChannel_NewColor_PropertyAddress;

	private static int SetCustomColorForChannel_NewColor_Offset;

	private static bool SetCurrentTime_IsValid;

	private static IntPtr SetCurrentTime_FunctionAddress;

	private static int SetCurrentTime_ParamsSize;

	private static bool SetCurrentTime_NewFrame_IsValid;

	private static FFieldAddress SetCurrentTime_NewFrame_PropertyAddress;

	private static int SetCurrentTime_NewFrame_Offset;

	private static bool SetCurrentLocalTime_IsValid;

	private static IntPtr SetCurrentLocalTime_FunctionAddress;

	private static int SetCurrentLocalTime_ParamsSize;

	private static bool SetCurrentLocalTime_NewFrame_IsValid;

	private static FFieldAddress SetCurrentLocalTime_NewFrame_PropertyAddress;

	private static int SetCurrentLocalTime_NewFrame_Offset;

	private static bool SelectTracks_IsValid;

	private static IntPtr SelectTracks_FunctionAddress;

	private static int SelectTracks_ParamsSize;

	private static bool SelectTracks_Tracks_IsValid;

	private static FFieldAddress SelectTracks_Tracks_PropertyAddress;

	private static int SelectTracks_Tracks_Offset;

	private static bool SelectSections_IsValid;

	private static IntPtr SelectSections_FunctionAddress;

	private static int SelectSections_ParamsSize;

	private static bool SelectSections_Sections_IsValid;

	private static FFieldAddress SelectSections_Sections_PropertyAddress;

	private static int SelectSections_Sections_Offset;

	private static bool SelectObjects_IsValid;

	private static IntPtr SelectObjects_FunctionAddress;

	private static int SelectObjects_ParamsSize;

	private static bool SelectObjects_ObjectBinding_IsValid;

	private static FFieldAddress SelectObjects_ObjectBinding_PropertyAddress;

	private static int SelectObjects_ObjectBinding_Offset;

	private static bool SelectFolders_IsValid;

	private static IntPtr SelectFolders_FunctionAddress;

	private static int SelectFolders_ParamsSize;

	private static bool SelectFolders_Folders_IsValid;

	private static FFieldAddress SelectFolders_Folders_PropertyAddress;

	private static int SelectFolders_Folders_Offset;

	private static bool SelectChannels_IsValid;

	private static IntPtr SelectChannels_FunctionAddress;

	private static int SelectChannels_ParamsSize;

	private static bool SelectChannels_Channels_IsValid;

	private static FFieldAddress SelectChannels_Channels_PropertyAddress;

	private static int SelectChannels_Channels_Offset;

	private static bool RefreshCurrentLevelSequence_IsValid;

	private static IntPtr RefreshCurrentLevelSequence_FunctionAddress;

	private static int RefreshCurrentLevelSequence_ParamsSize;

	private static bool PlayTo_IsValid;

	private static IntPtr PlayTo_FunctionAddress;

	private static int PlayTo_ParamsSize;

	private static bool PlayTo_PlaybackParams_IsValid;

	private static FFieldAddress PlayTo_PlaybackParams_PropertyAddress;

	private static int PlayTo_PlaybackParams_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool OpenLevelSequence_IsValid;

	private static IntPtr OpenLevelSequence_FunctionAddress;

	private static int OpenLevelSequence_ParamsSize;

	private static bool OpenLevelSequence_LevelSequence_IsValid;

	private static FFieldAddress OpenLevelSequence_LevelSequence_PropertyAddress;

	private static int OpenLevelSequence_LevelSequence_Offset;

	private static bool OpenLevelSequence_ReturnValue_IsValid;

	private static FFieldAddress OpenLevelSequence_ReturnValue_PropertyAddress;

	private static int OpenLevelSequence_ReturnValue_Offset;

	private static bool IsTrackFilterEnabled_IsValid;

	private static IntPtr IsTrackFilterEnabled_FunctionAddress;

	private static int IsTrackFilterEnabled_ParamsSize;

	private static bool IsTrackFilterEnabled_TrackFilterName_IsValid;

	private static FFieldAddress IsTrackFilterEnabled_TrackFilterName_PropertyAddress;

	private static int IsTrackFilterEnabled_TrackFilterName_Offset;

	private static bool IsTrackFilterEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsTrackFilterEnabled_ReturnValue_PropertyAddress;

	private static int IsTrackFilterEnabled_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsLevelSequenceLocked_IsValid;

	private static IntPtr IsLevelSequenceLocked_FunctionAddress;

	private static int IsLevelSequenceLocked_ParamsSize;

	private static bool IsLevelSequenceLocked_ReturnValue_IsValid;

	private static FFieldAddress IsLevelSequenceLocked_ReturnValue_PropertyAddress;

	private static int IsLevelSequenceLocked_ReturnValue_Offset;

	private static bool IsCameraCutLockedToViewport_IsValid;

	private static IntPtr IsCameraCutLockedToViewport_FunctionAddress;

	private static int IsCameraCutLockedToViewport_ParamsSize;

	private static bool IsCameraCutLockedToViewport_ReturnValue_IsValid;

	private static FFieldAddress IsCameraCutLockedToViewport_ReturnValue_PropertyAddress;

	private static int IsCameraCutLockedToViewport_ReturnValue_Offset;

	private static bool HasCustomColorForChannel_IsValid;

	private static IntPtr HasCustomColorForChannel_FunctionAddress;

	private static int HasCustomColorForChannel_ParamsSize;

	private static bool HasCustomColorForChannel_Class_IsValid;

	private static FFieldAddress HasCustomColorForChannel_Class_PropertyAddress;

	private static int HasCustomColorForChannel_Class_Offset;

	private static bool HasCustomColorForChannel_Identifier_IsValid;

	private static FFieldAddress HasCustomColorForChannel_Identifier_PropertyAddress;

	private static int HasCustomColorForChannel_Identifier_Offset;

	private static bool HasCustomColorForChannel_ReturnValue_IsValid;

	private static FFieldAddress HasCustomColorForChannel_ReturnValue_PropertyAddress;

	private static int HasCustomColorForChannel_ReturnValue_Offset;

	private static bool GetTrackFilterNames_IsValid;

	private static IntPtr GetTrackFilterNames_FunctionAddress;

	private static int GetTrackFilterNames_ParamsSize;

	private static bool GetTrackFilterNames_ReturnValue_IsValid;

	private static FFieldAddress GetTrackFilterNames_ReturnValue_PropertyAddress;

	private static int GetTrackFilterNames_ReturnValue_Offset;

	private static bool GetSelectionRangeStart_IsValid;

	private static IntPtr GetSelectionRangeStart_FunctionAddress;

	private static int GetSelectionRangeStart_ParamsSize;

	private static bool GetSelectionRangeStart_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionRangeStart_ReturnValue_PropertyAddress;

	private static int GetSelectionRangeStart_ReturnValue_Offset;

	private static bool GetSelectionRangeEnd_IsValid;

	private static IntPtr GetSelectionRangeEnd_FunctionAddress;

	private static int GetSelectionRangeEnd_ParamsSize;

	private static bool GetSelectionRangeEnd_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionRangeEnd_ReturnValue_PropertyAddress;

	private static int GetSelectionRangeEnd_ReturnValue_Offset;

	private static bool GetSelectedTracks_IsValid;

	private static IntPtr GetSelectedTracks_FunctionAddress;

	private static int GetSelectedTracks_ParamsSize;

	private static bool GetSelectedTracks_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedTracks_ReturnValue_PropertyAddress;

	private static int GetSelectedTracks_ReturnValue_Offset;

	private static bool GetSelectedSections_IsValid;

	private static IntPtr GetSelectedSections_FunctionAddress;

	private static int GetSelectedSections_ParamsSize;

	private static bool GetSelectedSections_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedSections_ReturnValue_PropertyAddress;

	private static int GetSelectedSections_ReturnValue_Offset;

	private static bool GetSelectedObjects_IsValid;

	private static IntPtr GetSelectedObjects_FunctionAddress;

	private static int GetSelectedObjects_ParamsSize;

	private static bool GetSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedObjects_ReturnValue_Offset;

	private static bool GetSelectedFolders_IsValid;

	private static IntPtr GetSelectedFolders_FunctionAddress;

	private static int GetSelectedFolders_ParamsSize;

	private static bool GetSelectedFolders_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedFolders_ReturnValue_PropertyAddress;

	private static int GetSelectedFolders_ReturnValue_Offset;

	private static bool GetSelectedChannels_IsValid;

	private static IntPtr GetSelectedChannels_FunctionAddress;

	private static int GetSelectedChannels_ParamsSize;

	private static bool GetSelectedChannels_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedChannels_ReturnValue_PropertyAddress;

	private static int GetSelectedChannels_ReturnValue_Offset;

	private static bool GetFocusedLevelSequence_IsValid;

	private static IntPtr GetFocusedLevelSequence_FunctionAddress;

	private static int GetFocusedLevelSequence_ParamsSize;

	private static bool GetFocusedLevelSequence_ReturnValue_IsValid;

	private static FFieldAddress GetFocusedLevelSequence_ReturnValue_PropertyAddress;

	private static int GetFocusedLevelSequence_ReturnValue_Offset;

	private static bool GetCustomColorForChannel_IsValid;

	private static IntPtr GetCustomColorForChannel_FunctionAddress;

	private static int GetCustomColorForChannel_ParamsSize;

	private static bool GetCustomColorForChannel_Class_IsValid;

	private static FFieldAddress GetCustomColorForChannel_Class_PropertyAddress;

	private static int GetCustomColorForChannel_Class_Offset;

	private static bool GetCustomColorForChannel_Identifier_IsValid;

	private static FFieldAddress GetCustomColorForChannel_Identifier_PropertyAddress;

	private static int GetCustomColorForChannel_Identifier_Offset;

	private static bool GetCustomColorForChannel_ReturnValue_IsValid;

	private static FFieldAddress GetCustomColorForChannel_ReturnValue_PropertyAddress;

	private static int GetCustomColorForChannel_ReturnValue_Offset;

	private static bool GetCurrentTime_IsValid;

	private static IntPtr GetCurrentTime_FunctionAddress;

	private static int GetCurrentTime_ParamsSize;

	private static bool GetCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentTime_ReturnValue_PropertyAddress;

	private static int GetCurrentTime_ReturnValue_Offset;

	private static bool GetCurrentLocalTime_IsValid;

	private static IntPtr GetCurrentLocalTime_FunctionAddress;

	private static int GetCurrentLocalTime_ParamsSize;

	private static bool GetCurrentLocalTime_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLocalTime_ReturnValue_PropertyAddress;

	private static int GetCurrentLocalTime_ReturnValue_Offset;

	private static bool GetCurrentLevelSequence_IsValid;

	private static IntPtr GetCurrentLevelSequence_FunctionAddress;

	private static int GetCurrentLevelSequence_ParamsSize;

	private static bool GetCurrentLevelSequence_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLevelSequence_ReturnValue_PropertyAddress;

	private static int GetCurrentLevelSequence_ReturnValue_Offset;

	private static bool GetBoundObjects_IsValid;

	private static IntPtr GetBoundObjects_FunctionAddress;

	private static int GetBoundObjects_ParamsSize;

	private static bool GetBoundObjects_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundObjects_ObjectBinding_PropertyAddress;

	private static int GetBoundObjects_ObjectBinding_Offset;

	private static bool GetBoundObjects_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObjects_ReturnValue_PropertyAddress;

	private static int GetBoundObjects_ReturnValue_Offset;

	private static bool EmptySelection_IsValid;

	private static IntPtr EmptySelection_FunctionAddress;

	private static int EmptySelection_ParamsSize;

	private static bool DeleteColorForChannels_IsValid;

	private static IntPtr DeleteColorForChannels_FunctionAddress;

	private static int DeleteColorForChannels_ParamsSize;

	private static bool DeleteColorForChannels_Class_IsValid;

	private static FFieldAddress DeleteColorForChannels_Class_PropertyAddress;

	private static int DeleteColorForChannels_Class_Offset;

	private static bool DeleteColorForChannels_Identifier_IsValid;

	private static FFieldAddress DeleteColorForChannels_Identifier_PropertyAddress;

	private static int DeleteColorForChannels_Identifier_Offset;

	private static bool CloseLevelSequence_IsValid;

	private static IntPtr CloseLevelSequence_FunctionAddress;

	private static int CloseLevelSequence_ParamsSize;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetTrackFilterEnabled")]
	public unsafe static void SetTrackFilterEnabled(FText TrackFilterName, bool bEnabled)
	{
		if (!SetTrackFilterEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetTrackFilterEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrackFilterEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrackFilterEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetTrackFilterEnabled_TrackFilterName_Offset), 0, SetTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, TrackFilterName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTrackFilterEnabled_bEnabled_Offset), 0, SetTrackFilterEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTrackFilterEnabled_FunctionAddress, intPtr, SetTrackFilterEnabled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeStart")]
	public unsafe static void SetSelectionRangeStart(int NewFrame)
	{
		if (!SetSelectionRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectionRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectionRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSelectionRangeStart_NewFrame_Offset), 0, SetSelectionRangeStart_NewFrame_PropertyAddress.Address, NewFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSelectionRangeStart_FunctionAddress, intPtr, SetSelectionRangeStart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeEnd")]
	public unsafe static void SetSelectionRangeEnd(int NewFrame)
	{
		if (!SetSelectionRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectionRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectionRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSelectionRangeEnd_NewFrame_Offset), 0, SetSelectionRangeEnd_NewFrame_PropertyAddress.Address, NewFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSelectionRangeEnd_FunctionAddress, intPtr, SetSelectionRangeEnd_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetRandomColorForChannels")]
	public unsafe static void SetRandomColorForChannels(TSubclassOf<UObject> Class, List<string> Identifiers)
	{
		if (!SetRandomColorForChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetRandomColorForChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRandomColorForChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRandomColorForChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetRandomColorForChannels_Class_Offset), 0, SetRandomColorForChannels_Class_PropertyAddress.Address, Class);
		new TArrayCopyMarshaler<string>(1, SetRandomColorForChannels_Identifiers_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetRandomColorForChannels_Identifiers_Offset), Identifiers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRandomColorForChannels_FunctionAddress, intPtr, SetRandomColorForChannels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRandomColorForChannels_Identifiers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockLevelSequence")]
	public unsafe static void SetLockLevelSequence(bool bLock)
	{
		if (!SetLockLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockLevelSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLockLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLockLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLockLevelSequence_bLock_Offset), 0, SetLockLevelSequence_bLock_PropertyAddress.Address, bLock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLockLevelSequence_FunctionAddress, intPtr, SetLockLevelSequence_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockCameraCutToViewport")]
	public unsafe static void SetLockCameraCutToViewport(bool bLock)
	{
		if (!SetLockCameraCutToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockCameraCutToViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLockCameraCutToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLockCameraCutToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLockCameraCutToViewport_bLock_Offset), 0, SetLockCameraCutToViewport_bLock_PropertyAddress.Address, bLock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLockCameraCutToViewport_FunctionAddress, intPtr, SetLockCameraCutToViewport_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannels")]
	public unsafe static void SetCustomColorForChannels(TSubclassOf<UObject> Class, List<string> Identifiers, List<FLinearColor> NewColors)
	{
		if (!SetCustomColorForChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomColorForChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomColorForChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetCustomColorForChannels_Class_Offset), 0, SetCustomColorForChannels_Class_PropertyAddress.Address, Class);
		new TArrayCopyMarshaler<string>(1, SetCustomColorForChannels_Identifiers_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetCustomColorForChannels_Identifiers_Offset), Identifiers);
		new TArrayCopyMarshaler<FLinearColor>(1, SetCustomColorForChannels_NewColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetCustomColorForChannels_NewColors_Offset), NewColors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCustomColorForChannels_FunctionAddress, intPtr, SetCustomColorForChannels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomColorForChannels_Identifiers_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetCustomColorForChannels_NewColors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannel")]
	public unsafe static void SetCustomColorForChannel(TSubclassOf<UObject> Class, string Identifier, FLinearColor NewColor)
	{
		if (!SetCustomColorForChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomColorForChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomColorForChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetCustomColorForChannel_Class_Offset), 0, SetCustomColorForChannel_Class_PropertyAddress.Address, Class);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomColorForChannel_Identifier_Offset), 0, SetCustomColorForChannel_Identifier_PropertyAddress.Address, Identifier);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetCustomColorForChannel_NewColor_Offset), 0, SetCustomColorForChannel_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCustomColorForChannel_FunctionAddress, intPtr, SetCustomColorForChannel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomColorForChannel_Identifier_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentTime")]
	public unsafe static void SetCurrentTime(int NewFrame)
	{
		if (!SetCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurrentTime_NewFrame_Offset), 0, SetCurrentTime_NewFrame_PropertyAddress.Address, NewFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentTime_FunctionAddress, intPtr, SetCurrentTime_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentLocalTime")]
	public unsafe static void SetCurrentLocalTime(int NewFrame)
	{
		if (!SetCurrentLocalTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentLocalTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLocalTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLocalTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurrentLocalTime_NewFrame_Offset), 0, SetCurrentLocalTime_NewFrame_PropertyAddress.Address, NewFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentLocalTime_FunctionAddress, intPtr, SetCurrentLocalTime_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectTracks")]
	public unsafe static void SelectTracks(List<UMovieSceneTrack> Tracks)
	{
		if (!SelectTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectTracks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMovieSceneTrack>(1, SelectTracks_Tracks_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectTracks_Tracks_Offset), Tracks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectTracks_FunctionAddress, intPtr, SelectTracks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectTracks_Tracks_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectSections")]
	public unsafe static void SelectSections(List<UMovieSceneSection> Sections)
	{
		if (!SelectSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMovieSceneSection>(1, SelectSections_Sections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectSections_Sections_Offset), Sections);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectSections_FunctionAddress, intPtr, SelectSections_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectSections_Sections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectObjects")]
	public unsafe static void SelectObjects(List<Guid> ObjectBinding)
	{
		if (!SelectObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<Guid>(1, SelectObjects_ObjectBinding_PropertyAddress, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.FromNative, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectObjects_ObjectBinding_Offset), ObjectBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectObjects_FunctionAddress, intPtr, SelectObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectObjects_ObjectBinding_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectFolders")]
	public unsafe static void SelectFolders(List<UMovieSceneFolder> Folders)
	{
		if (!SelectFolders_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectFolders");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectFolders_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectFolders_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMovieSceneFolder>(1, SelectFolders_Folders_PropertyAddress, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.FromNative, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectFolders_Folders_Offset), Folders);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectFolders_FunctionAddress, intPtr, SelectFolders_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectFolders_Folders_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectChannels")]
	public unsafe static void SelectChannels(List<FSequencerChannelProxy> Channels)
	{
		if (!SelectChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSequencerChannelProxy>(1, SelectChannels_Channels_PropertyAddress, CachedMarshalingDelegates<FSequencerChannelProxy, FSequencerChannelProxy>.FromNative, CachedMarshalingDelegates<FSequencerChannelProxy, FSequencerChannelProxy>.ToNative).ToNative(IntPtr.Add(intPtr, SelectChannels_Channels_Offset), Channels);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectChannels_FunctionAddress, intPtr, SelectChannels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectChannels_Channels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:RefreshCurrentLevelSequence")]
	public unsafe static void RefreshCurrentLevelSequence()
	{
		if (!RefreshCurrentLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:RefreshCurrentLevelSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshCurrentLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshCurrentLevelSequence_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RefreshCurrentLevelSequence_FunctionAddress, argsSize: RefreshCurrentLevelSequence_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:PlayTo")]
	public unsafe static void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
	{
		if (!PlayTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:PlayTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PlayTo_PlaybackParams_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackParams.ToNative(IntPtr.Add(intPtr, PlayTo_PlaybackParams_Offset), 0, PlayTo_PlaybackParams_PropertyAddress.Address, PlaybackParams);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayTo_FunctionAddress, intPtr, PlayTo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PlayTo_PlaybackParams_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Play")]
	public unsafe static void Play()
	{
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Pause")]
	public unsafe static void Pause()
	{
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:OpenLevelSequence")]
	public unsafe static bool OpenLevelSequence(ULevelSequence LevelSequence)
	{
		if (!OpenLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:OpenLevelSequence");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, OpenLevelSequence_LevelSequence_Offset), 0, OpenLevelSequence_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenLevelSequence_FunctionAddress, intPtr, OpenLevelSequence_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenLevelSequence_ReturnValue_Offset), 0, OpenLevelSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsTrackFilterEnabled")]
	public unsafe static bool IsTrackFilterEnabled(FText TrackFilterName)
	{
		if (!IsTrackFilterEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsTrackFilterEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTrackFilterEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTrackFilterEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, IsTrackFilterEnabled_TrackFilterName_Offset), 0, IsTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, TrackFilterName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTrackFilterEnabled_FunctionAddress, intPtr, IsTrackFilterEnabled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTrackFilterEnabled_TrackFilterName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTrackFilterEnabled_ReturnValue_Offset), 0, IsTrackFilterEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsPlaying")]
	public unsafe static bool IsPlaying()
	{
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsLevelSequenceLocked")]
	public unsafe static bool IsLevelSequenceLocked()
	{
		if (!IsLevelSequenceLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsLevelSequenceLocked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLevelSequenceLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLevelSequenceLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLevelSequenceLocked_FunctionAddress, intPtr, IsLevelSequenceLocked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLevelSequenceLocked_ReturnValue_Offset), 0, IsLevelSequenceLocked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsCameraCutLockedToViewport")]
	public unsafe static bool IsCameraCutLockedToViewport()
	{
		if (!IsCameraCutLockedToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsCameraCutLockedToViewport");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCameraCutLockedToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCameraCutLockedToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCameraCutLockedToViewport_FunctionAddress, intPtr, IsCameraCutLockedToViewport_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCameraCutLockedToViewport_ReturnValue_Offset), 0, IsCameraCutLockedToViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:HasCustomColorForChannel")]
	public unsafe static bool HasCustomColorForChannel(TSubclassOf<UObject> Class, string Identifier)
	{
		if (!HasCustomColorForChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:HasCustomColorForChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCustomColorForChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCustomColorForChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, HasCustomColorForChannel_Class_Offset), 0, HasCustomColorForChannel_Class_PropertyAddress.Address, Class);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HasCustomColorForChannel_Identifier_Offset), 0, HasCustomColorForChannel_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasCustomColorForChannel_FunctionAddress, intPtr, HasCustomColorForChannel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasCustomColorForChannel_Identifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCustomColorForChannel_ReturnValue_Offset), 0, HasCustomColorForChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetTrackFilterNames")]
	public unsafe static List<FText> GetTrackFilterNames()
	{
		if (!GetTrackFilterNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetTrackFilterNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackFilterNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackFilterNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrackFilterNames_FunctionAddress, intPtr, GetTrackFilterNames_ParamsSize);
		List<FText> result = new TArrayCopyMarshaler<FText>(1, GetTrackFilterNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FText, FTextMarshaler>.FromNative, CachedMarshalingDelegates<FText, FTextMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetTrackFilterNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTrackFilterNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeStart")]
	public unsafe static int GetSelectionRangeStart()
	{
		if (!GetSelectionRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeStart");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectionRangeStart_FunctionAddress, intPtr, GetSelectionRangeStart_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectionRangeStart_ReturnValue_Offset), 0, GetSelectionRangeStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeEnd")]
	public unsafe static int GetSelectionRangeEnd()
	{
		if (!GetSelectionRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeEnd");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectionRangeEnd_FunctionAddress, intPtr, GetSelectionRangeEnd_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectionRangeEnd_ReturnValue_Offset), 0, GetSelectionRangeEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedTracks")]
	public unsafe static List<UMovieSceneTrack> GetSelectedTracks()
	{
		if (!GetSelectedTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedTracks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedTracks_FunctionAddress, intPtr, GetSelectedTracks_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, GetSelectedTracks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedTracks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedTracks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedSections")]
	public unsafe static List<UMovieSceneSection> GetSelectedSections()
	{
		if (!GetSelectedSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedSections");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedSections_FunctionAddress, intPtr, GetSelectedSections_ParamsSize);
		List<UMovieSceneSection> result = new TArrayCopyMarshaler<UMovieSceneSection>(1, GetSelectedSections_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedSections_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedSections_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedObjects")]
	public unsafe static List<Guid> GetSelectedObjects()
	{
		if (!GetSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedObjects_FunctionAddress, intPtr, GetSelectedObjects_ParamsSize);
		List<Guid> result = new TArrayCopyMarshaler<Guid>(1, GetSelectedObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.FromNative, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedFolders")]
	public unsafe static List<UMovieSceneFolder> GetSelectedFolders()
	{
		if (!GetSelectedFolders_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedFolders");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedFolders_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedFolders_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedFolders_FunctionAddress, intPtr, GetSelectedFolders_ParamsSize);
		List<UMovieSceneFolder> result = new TArrayCopyMarshaler<UMovieSceneFolder>(1, GetSelectedFolders_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.FromNative, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedFolders_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedFolders_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedChannels")]
	public unsafe static List<FSequencerChannelProxy> GetSelectedChannels()
	{
		if (!GetSelectedChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedChannels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedChannels_FunctionAddress, intPtr, GetSelectedChannels_ParamsSize);
		List<FSequencerChannelProxy> result = new TArrayCopyMarshaler<FSequencerChannelProxy>(1, GetSelectedChannels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerChannelProxy, FSequencerChannelProxy>.FromNative, CachedMarshalingDelegates<FSequencerChannelProxy, FSequencerChannelProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedChannels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedChannels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetFocusedLevelSequence")]
	public unsafe static ULevelSequence GetFocusedLevelSequence()
	{
		if (!GetFocusedLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetFocusedLevelSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocusedLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocusedLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFocusedLevelSequence_FunctionAddress, intPtr, GetFocusedLevelSequence_ParamsSize);
		return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(intPtr, GetFocusedLevelSequence_ReturnValue_Offset), 0, GetFocusedLevelSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCustomColorForChannel")]
	public unsafe static FLinearColor GetCustomColorForChannel(TSubclassOf<UObject> Class, string Identifier)
	{
		if (!GetCustomColorForChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCustomColorForChannel");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomColorForChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomColorForChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCustomColorForChannel_Class_Offset), 0, GetCustomColorForChannel_Class_PropertyAddress.Address, Class);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetCustomColorForChannel_Identifier_Offset), 0, GetCustomColorForChannel_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCustomColorForChannel_FunctionAddress, intPtr, GetCustomColorForChannel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCustomColorForChannel_Identifier_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetCustomColorForChannel_ReturnValue_Offset), 0, GetCustomColorForChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentTime")]
	public unsafe static int GetCurrentTime()
	{
		if (!GetCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentTime");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentTime_FunctionAddress, intPtr, GetCurrentTime_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentTime_ReturnValue_Offset), 0, GetCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLocalTime")]
	public unsafe static int GetCurrentLocalTime()
	{
		if (!GetCurrentLocalTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLocalTime");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLocalTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLocalTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentLocalTime_FunctionAddress, intPtr, GetCurrentLocalTime_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentLocalTime_ReturnValue_Offset), 0, GetCurrentLocalTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLevelSequence")]
	public unsafe static ULevelSequence GetCurrentLevelSequence()
	{
		if (!GetCurrentLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLevelSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLevelSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentLevelSequence_FunctionAddress, intPtr, GetCurrentLevelSequence_ParamsSize);
		return UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(intPtr, GetCurrentLevelSequence_ReturnValue_Offset), 0, GetCurrentLevelSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetBoundObjects")]
	public unsafe static List<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
	{
		if (!GetBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetBoundObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundObjects_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundObjects_ObjectBinding_Offset), 0, GetBoundObjects_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoundObjects_FunctionAddress, intPtr, GetBoundObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetBoundObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:EmptySelection")]
	public unsafe static void EmptySelection()
	{
		if (!EmptySelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:EmptySelection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EmptySelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptySelection_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: EmptySelection_FunctionAddress, argsSize: EmptySelection_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:DeleteColorForChannels")]
	public unsafe static void DeleteColorForChannels(TSubclassOf<UObject> Class, out string Identifier)
	{
		if (!DeleteColorForChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:DeleteColorForChannels");
			Identifier = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteColorForChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteColorForChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DeleteColorForChannels_Class_Offset), 0, DeleteColorForChannels_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteColorForChannels_FunctionAddress, intPtr, DeleteColorForChannels_ParamsSize);
		Identifier = FStringMarshaler.FromNative(IntPtr.Add(intPtr, DeleteColorForChannels_Identifier_Offset), 0, DeleteColorForChannels_Identifier_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DeleteColorForChannels_Identifier_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:CloseLevelSequence")]
	public unsafe static void CloseLevelSequence()
	{
		if (!CloseLevelSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:CloseLevelSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseLevelSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseLevelSequence_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CloseLevelSequence_FunctionAddress, argsSize: CloseLevelSequence_ParamsSize);
	}

	static ULevelSequenceEditorBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequenceEditorBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequenceEditorBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary");
		SetTrackFilterEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTrackFilterEnabled");
		SetTrackFilterEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrackFilterEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFilterEnabled_TrackFilterName_PropertyAddress, SetTrackFilterEnabled_FunctionAddress, "TrackFilterName");
		SetTrackFilterEnabled_TrackFilterName_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFilterEnabled_FunctionAddress, "TrackFilterName");
		SetTrackFilterEnabled_TrackFilterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFilterEnabled_FunctionAddress, "TrackFilterName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFilterEnabled_bEnabled_PropertyAddress, SetTrackFilterEnabled_FunctionAddress, "bEnabled");
		SetTrackFilterEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFilterEnabled_FunctionAddress, "bEnabled");
		SetTrackFilterEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFilterEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetTrackFilterEnabled_IsValid = SetTrackFilterEnabled_FunctionAddress != IntPtr.Zero && SetTrackFilterEnabled_TrackFilterName_IsValid && SetTrackFilterEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetTrackFilterEnabled", SetTrackFilterEnabled_IsValid);
		SetSelectionRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSelectionRangeStart");
		SetSelectionRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectionRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectionRangeStart_NewFrame_PropertyAddress, SetSelectionRangeStart_FunctionAddress, "NewFrame");
		SetSelectionRangeStart_NewFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectionRangeStart_FunctionAddress, "NewFrame");
		SetSelectionRangeStart_NewFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectionRangeStart_FunctionAddress, "NewFrame", Classes.FIntProperty);
		SetSelectionRangeStart_IsValid = SetSelectionRangeStart_FunctionAddress != IntPtr.Zero && SetSelectionRangeStart_NewFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeStart", SetSelectionRangeStart_IsValid);
		SetSelectionRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSelectionRangeEnd");
		SetSelectionRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectionRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectionRangeEnd_NewFrame_PropertyAddress, SetSelectionRangeEnd_FunctionAddress, "NewFrame");
		SetSelectionRangeEnd_NewFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectionRangeEnd_FunctionAddress, "NewFrame");
		SetSelectionRangeEnd_NewFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectionRangeEnd_FunctionAddress, "NewFrame", Classes.FIntProperty);
		SetSelectionRangeEnd_IsValid = SetSelectionRangeEnd_FunctionAddress != IntPtr.Zero && SetSelectionRangeEnd_NewFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetSelectionRangeEnd", SetSelectionRangeEnd_IsValid);
		SetRandomColorForChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRandomColorForChannels");
		SetRandomColorForChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRandomColorForChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRandomColorForChannels_Class_PropertyAddress, SetRandomColorForChannels_FunctionAddress, "Class");
		SetRandomColorForChannels_Class_Offset = NativeReflectionCached.GetPropertyOffset(SetRandomColorForChannels_FunctionAddress, "Class");
		SetRandomColorForChannels_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRandomColorForChannels_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRandomColorForChannels_Identifiers_PropertyAddress, SetRandomColorForChannels_FunctionAddress, "Identifiers");
		SetRandomColorForChannels_Identifiers_Offset = NativeReflectionCached.GetPropertyOffset(SetRandomColorForChannels_FunctionAddress, "Identifiers");
		SetRandomColorForChannels_Identifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRandomColorForChannels_FunctionAddress, "Identifiers", Classes.FArrayProperty);
		SetRandomColorForChannels_IsValid = SetRandomColorForChannels_FunctionAddress != IntPtr.Zero && SetRandomColorForChannels_Class_IsValid && SetRandomColorForChannels_Identifiers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetRandomColorForChannels", SetRandomColorForChannels_IsValid);
		SetLockLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLockLevelSequence");
		SetLockLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLockLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLockLevelSequence_bLock_PropertyAddress, SetLockLevelSequence_FunctionAddress, "bLock");
		SetLockLevelSequence_bLock_Offset = NativeReflectionCached.GetPropertyOffset(SetLockLevelSequence_FunctionAddress, "bLock");
		SetLockLevelSequence_bLock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLockLevelSequence_FunctionAddress, "bLock", Classes.FBoolProperty);
		SetLockLevelSequence_IsValid = SetLockLevelSequence_FunctionAddress != IntPtr.Zero && SetLockLevelSequence_bLock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockLevelSequence", SetLockLevelSequence_IsValid);
		SetLockCameraCutToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLockCameraCutToViewport");
		SetLockCameraCutToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLockCameraCutToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLockCameraCutToViewport_bLock_PropertyAddress, SetLockCameraCutToViewport_FunctionAddress, "bLock");
		SetLockCameraCutToViewport_bLock_Offset = NativeReflectionCached.GetPropertyOffset(SetLockCameraCutToViewport_FunctionAddress, "bLock");
		SetLockCameraCutToViewport_bLock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLockCameraCutToViewport_FunctionAddress, "bLock", Classes.FBoolProperty);
		SetLockCameraCutToViewport_IsValid = SetLockCameraCutToViewport_FunctionAddress != IntPtr.Zero && SetLockCameraCutToViewport_bLock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetLockCameraCutToViewport", SetLockCameraCutToViewport_IsValid);
		SetCustomColorForChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCustomColorForChannels");
		SetCustomColorForChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomColorForChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannels_Class_PropertyAddress, SetCustomColorForChannels_FunctionAddress, "Class");
		SetCustomColorForChannels_Class_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannels_FunctionAddress, "Class");
		SetCustomColorForChannels_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannels_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannels_Identifiers_PropertyAddress, SetCustomColorForChannels_FunctionAddress, "Identifiers");
		SetCustomColorForChannels_Identifiers_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannels_FunctionAddress, "Identifiers");
		SetCustomColorForChannels_Identifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannels_FunctionAddress, "Identifiers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannels_NewColors_PropertyAddress, SetCustomColorForChannels_FunctionAddress, "NewColors");
		SetCustomColorForChannels_NewColors_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannels_FunctionAddress, "NewColors");
		SetCustomColorForChannels_NewColors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannels_FunctionAddress, "NewColors", Classes.FArrayProperty);
		SetCustomColorForChannels_IsValid = SetCustomColorForChannels_FunctionAddress != IntPtr.Zero && SetCustomColorForChannels_Class_IsValid && SetCustomColorForChannels_Identifiers_IsValid && SetCustomColorForChannels_NewColors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannels", SetCustomColorForChannels_IsValid);
		SetCustomColorForChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCustomColorForChannel");
		SetCustomColorForChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomColorForChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannel_Class_PropertyAddress, SetCustomColorForChannel_FunctionAddress, "Class");
		SetCustomColorForChannel_Class_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannel_FunctionAddress, "Class");
		SetCustomColorForChannel_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannel_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannel_Identifier_PropertyAddress, SetCustomColorForChannel_FunctionAddress, "Identifier");
		SetCustomColorForChannel_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannel_FunctionAddress, "Identifier");
		SetCustomColorForChannel_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannel_FunctionAddress, "Identifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColorForChannel_NewColor_PropertyAddress, SetCustomColorForChannel_FunctionAddress, "NewColor");
		SetCustomColorForChannel_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColorForChannel_FunctionAddress, "NewColor");
		SetCustomColorForChannel_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColorForChannel_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetCustomColorForChannel_IsValid = SetCustomColorForChannel_FunctionAddress != IntPtr.Zero && SetCustomColorForChannel_Class_IsValid && SetCustomColorForChannel_Identifier_IsValid && SetCustomColorForChannel_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCustomColorForChannel", SetCustomColorForChannel_IsValid);
		SetCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentTime");
		SetCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentTime_NewFrame_PropertyAddress, SetCurrentTime_FunctionAddress, "NewFrame");
		SetCurrentTime_NewFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentTime_FunctionAddress, "NewFrame");
		SetCurrentTime_NewFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentTime_FunctionAddress, "NewFrame", Classes.FIntProperty);
		SetCurrentTime_IsValid = SetCurrentTime_FunctionAddress != IntPtr.Zero && SetCurrentTime_NewFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentTime", SetCurrentTime_IsValid);
		SetCurrentLocalTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentLocalTime");
		SetCurrentLocalTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLocalTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLocalTime_NewFrame_PropertyAddress, SetCurrentLocalTime_FunctionAddress, "NewFrame");
		SetCurrentLocalTime_NewFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLocalTime_FunctionAddress, "NewFrame");
		SetCurrentLocalTime_NewFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLocalTime_FunctionAddress, "NewFrame", Classes.FIntProperty);
		SetCurrentLocalTime_IsValid = SetCurrentLocalTime_FunctionAddress != IntPtr.Zero && SetCurrentLocalTime_NewFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SetCurrentLocalTime", SetCurrentLocalTime_IsValid);
		SelectTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectTracks");
		SelectTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectTracks_Tracks_PropertyAddress, SelectTracks_FunctionAddress, "Tracks");
		SelectTracks_Tracks_Offset = NativeReflectionCached.GetPropertyOffset(SelectTracks_FunctionAddress, "Tracks");
		SelectTracks_Tracks_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectTracks_FunctionAddress, "Tracks", Classes.FArrayProperty);
		SelectTracks_IsValid = SelectTracks_FunctionAddress != IntPtr.Zero && SelectTracks_Tracks_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectTracks", SelectTracks_IsValid);
		SelectSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectSections");
		SelectSections_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectSections_Sections_PropertyAddress, SelectSections_FunctionAddress, "Sections");
		SelectSections_Sections_Offset = NativeReflectionCached.GetPropertyOffset(SelectSections_FunctionAddress, "Sections");
		SelectSections_Sections_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectSections_FunctionAddress, "Sections", Classes.FArrayProperty);
		SelectSections_IsValid = SelectSections_FunctionAddress != IntPtr.Zero && SelectSections_Sections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectSections", SelectSections_IsValid);
		SelectObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectObjects");
		SelectObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectObjects_ObjectBinding_PropertyAddress, SelectObjects_FunctionAddress, "ObjectBinding");
		SelectObjects_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(SelectObjects_FunctionAddress, "ObjectBinding");
		SelectObjects_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectObjects_FunctionAddress, "ObjectBinding", Classes.FArrayProperty);
		SelectObjects_IsValid = SelectObjects_FunctionAddress != IntPtr.Zero && SelectObjects_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectObjects", SelectObjects_IsValid);
		SelectFolders_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectFolders");
		SelectFolders_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectFolders_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectFolders_Folders_PropertyAddress, SelectFolders_FunctionAddress, "Folders");
		SelectFolders_Folders_Offset = NativeReflectionCached.GetPropertyOffset(SelectFolders_FunctionAddress, "Folders");
		SelectFolders_Folders_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectFolders_FunctionAddress, "Folders", Classes.FArrayProperty);
		SelectFolders_IsValid = SelectFolders_FunctionAddress != IntPtr.Zero && SelectFolders_Folders_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectFolders", SelectFolders_IsValid);
		SelectChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectChannels");
		SelectChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectChannels_Channels_PropertyAddress, SelectChannels_FunctionAddress, "Channels");
		SelectChannels_Channels_Offset = NativeReflectionCached.GetPropertyOffset(SelectChannels_FunctionAddress, "Channels");
		SelectChannels_Channels_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectChannels_FunctionAddress, "Channels", Classes.FArrayProperty);
		SelectChannels_IsValid = SelectChannels_FunctionAddress != IntPtr.Zero && SelectChannels_Channels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:SelectChannels", SelectChannels_IsValid);
		RefreshCurrentLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshCurrentLevelSequence");
		RefreshCurrentLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshCurrentLevelSequence_FunctionAddress);
		RefreshCurrentLevelSequence_IsValid = RefreshCurrentLevelSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:RefreshCurrentLevelSequence", RefreshCurrentLevelSequence_IsValid);
		PlayTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayTo");
		PlayTo_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayTo_PlaybackParams_PropertyAddress, PlayTo_FunctionAddress, "PlaybackParams");
		PlayTo_PlaybackParams_Offset = NativeReflectionCached.GetPropertyOffset(PlayTo_FunctionAddress, "PlaybackParams");
		PlayTo_PlaybackParams_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayTo_FunctionAddress, "PlaybackParams", Classes.FStructProperty);
		PlayTo_IsValid = PlayTo_FunctionAddress != IntPtr.Zero && PlayTo_PlaybackParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:PlayTo", PlayTo_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:Pause", Pause_IsValid);
		OpenLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenLevelSequence");
		OpenLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenLevelSequence_LevelSequence_PropertyAddress, OpenLevelSequence_FunctionAddress, "LevelSequence");
		OpenLevelSequence_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(OpenLevelSequence_FunctionAddress, "LevelSequence");
		OpenLevelSequence_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLevelSequence_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenLevelSequence_ReturnValue_PropertyAddress, OpenLevelSequence_FunctionAddress, "ReturnValue");
		OpenLevelSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenLevelSequence_FunctionAddress, "ReturnValue");
		OpenLevelSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLevelSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenLevelSequence_IsValid = OpenLevelSequence_FunctionAddress != IntPtr.Zero && OpenLevelSequence_LevelSequence_IsValid && OpenLevelSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:OpenLevelSequence", OpenLevelSequence_IsValid);
		IsTrackFilterEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTrackFilterEnabled");
		IsTrackFilterEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTrackFilterEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTrackFilterEnabled_TrackFilterName_PropertyAddress, IsTrackFilterEnabled_FunctionAddress, "TrackFilterName");
		IsTrackFilterEnabled_TrackFilterName_Offset = NativeReflectionCached.GetPropertyOffset(IsTrackFilterEnabled_FunctionAddress, "TrackFilterName");
		IsTrackFilterEnabled_TrackFilterName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTrackFilterEnabled_FunctionAddress, "TrackFilterName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTrackFilterEnabled_ReturnValue_PropertyAddress, IsTrackFilterEnabled_FunctionAddress, "ReturnValue");
		IsTrackFilterEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTrackFilterEnabled_FunctionAddress, "ReturnValue");
		IsTrackFilterEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTrackFilterEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTrackFilterEnabled_IsValid = IsTrackFilterEnabled_FunctionAddress != IntPtr.Zero && IsTrackFilterEnabled_TrackFilterName_IsValid && IsTrackFilterEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsTrackFilterEnabled", IsTrackFilterEnabled_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsPlaying", IsPlaying_IsValid);
		IsLevelSequenceLocked_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLevelSequenceLocked");
		IsLevelSequenceLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLevelSequenceLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLevelSequenceLocked_ReturnValue_PropertyAddress, IsLevelSequenceLocked_FunctionAddress, "ReturnValue");
		IsLevelSequenceLocked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLevelSequenceLocked_FunctionAddress, "ReturnValue");
		IsLevelSequenceLocked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLevelSequenceLocked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLevelSequenceLocked_IsValid = IsLevelSequenceLocked_FunctionAddress != IntPtr.Zero && IsLevelSequenceLocked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsLevelSequenceLocked", IsLevelSequenceLocked_IsValid);
		IsCameraCutLockedToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCameraCutLockedToViewport");
		IsCameraCutLockedToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCameraCutLockedToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCameraCutLockedToViewport_ReturnValue_PropertyAddress, IsCameraCutLockedToViewport_FunctionAddress, "ReturnValue");
		IsCameraCutLockedToViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCameraCutLockedToViewport_FunctionAddress, "ReturnValue");
		IsCameraCutLockedToViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCameraCutLockedToViewport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCameraCutLockedToViewport_IsValid = IsCameraCutLockedToViewport_FunctionAddress != IntPtr.Zero && IsCameraCutLockedToViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:IsCameraCutLockedToViewport", IsCameraCutLockedToViewport_IsValid);
		HasCustomColorForChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasCustomColorForChannel");
		HasCustomColorForChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCustomColorForChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCustomColorForChannel_Class_PropertyAddress, HasCustomColorForChannel_FunctionAddress, "Class");
		HasCustomColorForChannel_Class_Offset = NativeReflectionCached.GetPropertyOffset(HasCustomColorForChannel_FunctionAddress, "Class");
		HasCustomColorForChannel_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCustomColorForChannel_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref HasCustomColorForChannel_Identifier_PropertyAddress, HasCustomColorForChannel_FunctionAddress, "Identifier");
		HasCustomColorForChannel_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(HasCustomColorForChannel_FunctionAddress, "Identifier");
		HasCustomColorForChannel_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCustomColorForChannel_FunctionAddress, "Identifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HasCustomColorForChannel_ReturnValue_PropertyAddress, HasCustomColorForChannel_FunctionAddress, "ReturnValue");
		HasCustomColorForChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCustomColorForChannel_FunctionAddress, "ReturnValue");
		HasCustomColorForChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCustomColorForChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCustomColorForChannel_IsValid = HasCustomColorForChannel_FunctionAddress != IntPtr.Zero && HasCustomColorForChannel_Class_IsValid && HasCustomColorForChannel_Identifier_IsValid && HasCustomColorForChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:HasCustomColorForChannel", HasCustomColorForChannel_IsValid);
		GetTrackFilterNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrackFilterNames");
		GetTrackFilterNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackFilterNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackFilterNames_ReturnValue_PropertyAddress, GetTrackFilterNames_FunctionAddress, "ReturnValue");
		GetTrackFilterNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackFilterNames_FunctionAddress, "ReturnValue");
		GetTrackFilterNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackFilterNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTrackFilterNames_IsValid = GetTrackFilterNames_FunctionAddress != IntPtr.Zero && GetTrackFilterNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetTrackFilterNames", GetTrackFilterNames_IsValid);
		GetSelectionRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectionRangeStart");
		GetSelectionRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionRangeStart_ReturnValue_PropertyAddress, GetSelectionRangeStart_FunctionAddress, "ReturnValue");
		GetSelectionRangeStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionRangeStart_FunctionAddress, "ReturnValue");
		GetSelectionRangeStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionRangeStart_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectionRangeStart_IsValid = GetSelectionRangeStart_FunctionAddress != IntPtr.Zero && GetSelectionRangeStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeStart", GetSelectionRangeStart_IsValid);
		GetSelectionRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectionRangeEnd");
		GetSelectionRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionRangeEnd_ReturnValue_PropertyAddress, GetSelectionRangeEnd_FunctionAddress, "ReturnValue");
		GetSelectionRangeEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionRangeEnd_FunctionAddress, "ReturnValue");
		GetSelectionRangeEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionRangeEnd_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectionRangeEnd_IsValid = GetSelectionRangeEnd_FunctionAddress != IntPtr.Zero && GetSelectionRangeEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectionRangeEnd", GetSelectionRangeEnd_IsValid);
		GetSelectedTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedTracks");
		GetSelectedTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedTracks_ReturnValue_PropertyAddress, GetSelectedTracks_FunctionAddress, "ReturnValue");
		GetSelectedTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedTracks_FunctionAddress, "ReturnValue");
		GetSelectedTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedTracks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedTracks_IsValid = GetSelectedTracks_FunctionAddress != IntPtr.Zero && GetSelectedTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedTracks", GetSelectedTracks_IsValid);
		GetSelectedSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedSections");
		GetSelectedSections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedSections_ReturnValue_PropertyAddress, GetSelectedSections_FunctionAddress, "ReturnValue");
		GetSelectedSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedSections_FunctionAddress, "ReturnValue");
		GetSelectedSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedSections_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedSections_IsValid = GetSelectedSections_FunctionAddress != IntPtr.Zero && GetSelectedSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedSections", GetSelectedSections_IsValid);
		GetSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedObjects");
		GetSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_ReturnValue_PropertyAddress, GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedObjects_IsValid = GetSelectedObjects_FunctionAddress != IntPtr.Zero && GetSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedObjects", GetSelectedObjects_IsValid);
		GetSelectedFolders_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedFolders");
		GetSelectedFolders_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedFolders_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedFolders_ReturnValue_PropertyAddress, GetSelectedFolders_FunctionAddress, "ReturnValue");
		GetSelectedFolders_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedFolders_FunctionAddress, "ReturnValue");
		GetSelectedFolders_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedFolders_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedFolders_IsValid = GetSelectedFolders_FunctionAddress != IntPtr.Zero && GetSelectedFolders_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedFolders", GetSelectedFolders_IsValid);
		GetSelectedChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedChannels");
		GetSelectedChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedChannels_ReturnValue_PropertyAddress, GetSelectedChannels_FunctionAddress, "ReturnValue");
		GetSelectedChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedChannels_FunctionAddress, "ReturnValue");
		GetSelectedChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedChannels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedChannels_IsValid = GetSelectedChannels_FunctionAddress != IntPtr.Zero && GetSelectedChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetSelectedChannels", GetSelectedChannels_IsValid);
		GetFocusedLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFocusedLevelSequence");
		GetFocusedLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocusedLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocusedLevelSequence_ReturnValue_PropertyAddress, GetFocusedLevelSequence_FunctionAddress, "ReturnValue");
		GetFocusedLevelSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusedLevelSequence_FunctionAddress, "ReturnValue");
		GetFocusedLevelSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusedLevelSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFocusedLevelSequence_IsValid = GetFocusedLevelSequence_FunctionAddress != IntPtr.Zero && GetFocusedLevelSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetFocusedLevelSequence", GetFocusedLevelSequence_IsValid);
		GetCustomColorForChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomColorForChannel");
		GetCustomColorForChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomColorForChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomColorForChannel_Class_PropertyAddress, GetCustomColorForChannel_FunctionAddress, "Class");
		GetCustomColorForChannel_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomColorForChannel_FunctionAddress, "Class");
		GetCustomColorForChannel_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomColorForChannel_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomColorForChannel_Identifier_PropertyAddress, GetCustomColorForChannel_FunctionAddress, "Identifier");
		GetCustomColorForChannel_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomColorForChannel_FunctionAddress, "Identifier");
		GetCustomColorForChannel_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomColorForChannel_FunctionAddress, "Identifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomColorForChannel_ReturnValue_PropertyAddress, GetCustomColorForChannel_FunctionAddress, "ReturnValue");
		GetCustomColorForChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomColorForChannel_FunctionAddress, "ReturnValue");
		GetCustomColorForChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomColorForChannel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCustomColorForChannel_IsValid = GetCustomColorForChannel_FunctionAddress != IntPtr.Zero && GetCustomColorForChannel_Class_IsValid && GetCustomColorForChannel_Identifier_IsValid && GetCustomColorForChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCustomColorForChannel", GetCustomColorForChannel_IsValid);
		GetCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentTime");
		GetCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTime_ReturnValue_PropertyAddress, GetCurrentTime_FunctionAddress, "ReturnValue");
		GetCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTime_FunctionAddress, "ReturnValue");
		GetCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTime_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentTime_IsValid = GetCurrentTime_FunctionAddress != IntPtr.Zero && GetCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentTime", GetCurrentTime_IsValid);
		GetCurrentLocalTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentLocalTime");
		GetCurrentLocalTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLocalTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLocalTime_ReturnValue_PropertyAddress, GetCurrentLocalTime_FunctionAddress, "ReturnValue");
		GetCurrentLocalTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLocalTime_FunctionAddress, "ReturnValue");
		GetCurrentLocalTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLocalTime_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentLocalTime_IsValid = GetCurrentLocalTime_FunctionAddress != IntPtr.Zero && GetCurrentLocalTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLocalTime", GetCurrentLocalTime_IsValid);
		GetCurrentLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentLevelSequence");
		GetCurrentLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLevelSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLevelSequence_ReturnValue_PropertyAddress, GetCurrentLevelSequence_FunctionAddress, "ReturnValue");
		GetCurrentLevelSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLevelSequence_FunctionAddress, "ReturnValue");
		GetCurrentLevelSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLevelSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentLevelSequence_IsValid = GetCurrentLevelSequence_FunctionAddress != IntPtr.Zero && GetCurrentLevelSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetCurrentLevelSequence", GetCurrentLevelSequence_IsValid);
		GetBoundObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoundObjects");
		GetBoundObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ObjectBinding_PropertyAddress, GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ReturnValue_PropertyAddress, GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundObjects_IsValid = GetBoundObjects_FunctionAddress != IntPtr.Zero && GetBoundObjects_ObjectBinding_IsValid && GetBoundObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:GetBoundObjects", GetBoundObjects_IsValid);
		EmptySelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EmptySelection");
		EmptySelection_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptySelection_FunctionAddress);
		EmptySelection_IsValid = EmptySelection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:EmptySelection", EmptySelection_IsValid);
		DeleteColorForChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteColorForChannels");
		DeleteColorForChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteColorForChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteColorForChannels_Class_PropertyAddress, DeleteColorForChannels_FunctionAddress, "Class");
		DeleteColorForChannels_Class_Offset = NativeReflectionCached.GetPropertyOffset(DeleteColorForChannels_FunctionAddress, "Class");
		DeleteColorForChannels_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteColorForChannels_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteColorForChannels_Identifier_PropertyAddress, DeleteColorForChannels_FunctionAddress, "Identifier");
		DeleteColorForChannels_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(DeleteColorForChannels_FunctionAddress, "Identifier");
		DeleteColorForChannels_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteColorForChannels_FunctionAddress, "Identifier", Classes.FStrProperty);
		DeleteColorForChannels_IsValid = DeleteColorForChannels_FunctionAddress != IntPtr.Zero && DeleteColorForChannels_Class_IsValid && DeleteColorForChannels_Identifier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:DeleteColorForChannels", DeleteColorForChannels_IsValid);
		CloseLevelSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseLevelSequence");
		CloseLevelSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseLevelSequence_FunctionAddress);
		CloseLevelSequence_IsValid = CloseLevelSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorBlueprintLibrary:CloseLevelSequence", CloseLevelSequence_IsValid);
	}
}
