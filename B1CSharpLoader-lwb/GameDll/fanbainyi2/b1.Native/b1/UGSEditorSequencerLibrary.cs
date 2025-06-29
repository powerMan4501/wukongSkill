using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.AkAudio;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorSequencerLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RemoveSections_IsValid;

	private static IntPtr RemoveSections_FunctionAddress;

	private static int RemoveSections_ParamsSize;

	private static bool RemoveSections_LevelSequence_IsValid;

	private static FFieldAddress RemoveSections_LevelSequence_PropertyAddress;

	private static int RemoveSections_LevelSequence_Offset;

	private static bool RemoveSections_Sections_IsValid;

	private static FFieldAddress RemoveSections_Sections_PropertyAddress;

	private static int RemoveSections_Sections_Offset;

	private static bool GetLevelSequenceFrameRate_IsValid;

	private static IntPtr GetLevelSequenceFrameRate_FunctionAddress;

	private static int GetLevelSequenceFrameRate_ParamsSize;

	private static bool GetLevelSequenceFrameRate_LevelSequence_IsValid;

	private static FFieldAddress GetLevelSequenceFrameRate_LevelSequence_PropertyAddress;

	private static int GetLevelSequenceFrameRate_LevelSequence_Offset;

	private static bool GetLevelSequenceFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetLevelSequenceFrameRate_ReturnValue_PropertyAddress;

	private static int GetLevelSequenceFrameRate_ReturnValue_Offset;

	private static bool ExportSequenceShotInfoToFile_IsValid;

	private static IntPtr ExportSequenceShotInfoToFile_FunctionAddress;

	private static int ExportSequenceShotInfoToFile_ParamsSize;

	private static bool ExportSequenceShotInfoToFile_InLevelSequence_IsValid;

	private static FFieldAddress ExportSequenceShotInfoToFile_InLevelSequence_PropertyAddress;

	private static int ExportSequenceShotInfoToFile_InLevelSequence_Offset;

	private static bool ExportSequenceShotInfoToFile_FilePath_IsValid;

	private static FFieldAddress ExportSequenceShotInfoToFile_FilePath_PropertyAddress;

	private static int ExportSequenceShotInfoToFile_FilePath_Offset;

	private static bool ClearActor_Transform_IsValid;

	private static IntPtr ClearActor_Transform_FunctionAddress;

	private static int ClearActor_Transform_ParamsSize;

	private static bool ClearActor_Transform_LevelSequence_IsValid;

	private static FFieldAddress ClearActor_Transform_LevelSequence_PropertyAddress;

	private static int ClearActor_Transform_LevelSequence_Offset;

	private static bool ClearActor_Transform_TargetActor_IsValid;

	private static FFieldAddress ClearActor_Transform_TargetActor_PropertyAddress;

	private static int ClearActor_Transform_TargetActor_Offset;

	private static bool CheckSectionValid_FindSectionRangeEmpty_IsValid;

	private static IntPtr CheckSectionValid_FindSectionRangeEmpty_FunctionAddress;

	private static int CheckSectionValid_FindSectionRangeEmpty_ParamsSize;

	private static bool CheckSectionValid_FindSectionRangeEmpty_LevelSequence_IsValid;

	private static FFieldAddress CheckSectionValid_FindSectionRangeEmpty_LevelSequence_PropertyAddress;

	private static int CheckSectionValid_FindSectionRangeEmpty_LevelSequence_Offset;

	private static bool CheckSectionValid_FindSectionRangeEmpty_TrackClass_IsValid;

	private static FFieldAddress CheckSectionValid_FindSectionRangeEmpty_TrackClass_PropertyAddress;

	private static int CheckSectionValid_FindSectionRangeEmpty_TrackClass_Offset;

	private static bool CheckSectionValid_FindSectionRangeEmpty_SectionClass_IsValid;

	private static FFieldAddress CheckSectionValid_FindSectionRangeEmpty_SectionClass_PropertyAddress;

	private static int CheckSectionValid_FindSectionRangeEmpty_SectionClass_Offset;

	private static bool CheckSectionValid_FindSectionRangeEmpty_WarningSections_IsValid;

	private static FFieldAddress CheckSectionValid_FindSectionRangeEmpty_WarningSections_PropertyAddress;

	private static int CheckSectionValid_FindSectionRangeEmpty_WarningSections_Offset;

	private static bool Carry_AKEventTrack_IsValid;

	private static IntPtr Carry_AKEventTrack_FunctionAddress;

	private static int Carry_AKEventTrack_ParamsSize;

	private static bool Carry_AKEventTrack_LevelSequence_IsValid;

	private static FFieldAddress Carry_AKEventTrack_LevelSequence_PropertyAddress;

	private static int Carry_AKEventTrack_LevelSequence_Offset;

	private static bool Carry_AKEventTrack_TrackClass_IsValid;

	private static FFieldAddress Carry_AKEventTrack_TrackClass_PropertyAddress;

	private static int Carry_AKEventTrack_TrackClass_Offset;

	private static bool Carry_AKEventTrack_SectionType_IsValid;

	private static FFieldAddress Carry_AKEventTrack_SectionType_PropertyAddress;

	private static int Carry_AKEventTrack_SectionType_Offset;

	private static bool Carry_AKEventTrack_AddedSections_IsValid;

	private static FFieldAddress Carry_AKEventTrack_AddedSections_PropertyAddress;

	private static int Carry_AKEventTrack_AddedSections_Offset;

	private static bool Carry_AKEventTrack_AkEvents_IsValid;

	private static FFieldAddress Carry_AKEventTrack_AkEvents_PropertyAddress;

	private static int Carry_AKEventTrack_AkEvents_Offset;

	private static bool Carry_AKEventTrack_ReturnValue_IsValid;

	private static FFieldAddress Carry_AKEventTrack_ReturnValue_PropertyAddress;

	private static int Carry_AKEventTrack_ReturnValue_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocusDistance_IsValid;

	private static IntPtr AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress;

	private static int AddKeyframeToCineCameraTrack_FocusDistance_ParamsSize;

	private static bool AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocalLength_IsValid;

	private static IntPtr AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress;

	private static int AddKeyframeToCineCameraTrack_FocalLength_ParamsSize;

	private static bool AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_Offset;

	private static bool AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_IsValid;

	private static FFieldAddress AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_PropertyAddress;

	private static int AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_Offset;

	private static bool AddKeyframeToCameraTrack_Transform_IsValid;

	private static IntPtr AddKeyframeToCameraTrack_Transform_FunctionAddress;

	private static int AddKeyframeToCameraTrack_Transform_ParamsSize;

	private static bool AddKeyframeToCameraTrack_Transform_LevelSequence_IsValid;

	private static FFieldAddress AddKeyframeToCameraTrack_Transform_LevelSequence_PropertyAddress;

	private static int AddKeyframeToCameraTrack_Transform_LevelSequence_Offset;

	private static bool AddKeyframeToCameraTrack_Transform_CameraActor_IsValid;

	private static FFieldAddress AddKeyframeToCameraTrack_Transform_CameraActor_PropertyAddress;

	private static int AddKeyframeToCameraTrack_Transform_CameraActor_Offset;

	private static bool AddKeyframeToCameraTrack_Transform_FrameToKey_IsValid;

	private static FFieldAddress AddKeyframeToCameraTrack_Transform_FrameToKey_PropertyAddress;

	private static int AddKeyframeToCameraTrack_Transform_FrameToKey_Offset;

	private static bool AddKeyframeToCameraTrack_Transform_InTransform_IsValid;

	private static FFieldAddress AddKeyframeToCameraTrack_Transform_InTransform_PropertyAddress;

	private static int AddKeyframeToCameraTrack_Transform_InTransform_Offset;

	private static bool AddKeyframeToActor_Transform_IsValid;

	private static IntPtr AddKeyframeToActor_Transform_FunctionAddress;

	private static int AddKeyframeToActor_Transform_ParamsSize;

	private static bool AddKeyframeToActor_Transform_LevelSequence_IsValid;

	private static FFieldAddress AddKeyframeToActor_Transform_LevelSequence_PropertyAddress;

	private static int AddKeyframeToActor_Transform_LevelSequence_Offset;

	private static bool AddKeyframeToActor_Transform_TargetActor_IsValid;

	private static FFieldAddress AddKeyframeToActor_Transform_TargetActor_PropertyAddress;

	private static int AddKeyframeToActor_Transform_TargetActor_Offset;

	private static bool AddKeyframeToActor_Transform_FrameToKey_IsValid;

	private static FFieldAddress AddKeyframeToActor_Transform_FrameToKey_PropertyAddress;

	private static int AddKeyframeToActor_Transform_FrameToKey_Offset;

	private static bool AddKeyframeToActor_Transform_InTransform_IsValid;

	private static FFieldAddress AddKeyframeToActor_Transform_InTransform_PropertyAddress;

	private static int AddKeyframeToActor_Transform_InTransform_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:RemoveSections")]
	public unsafe static void RemoveSections(ULevelSequence LevelSequence, List<UMovieSceneSection> Sections)
	{
		if (!RemoveSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:RemoveSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, RemoveSections_LevelSequence_Offset), 0, RemoveSections_LevelSequence_PropertyAddress.Address, LevelSequence);
		new TArrayCopyMarshaler<UMovieSceneSection>(1, RemoveSections_Sections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveSections_Sections_Offset), Sections);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSections_FunctionAddress, intPtr, RemoveSections_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveSections_Sections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:GetLevelSequenceFrameRate")]
	public unsafe static float GetLevelSequenceFrameRate(ULevelSequence LevelSequence)
	{
		if (!GetLevelSequenceFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:GetLevelSequenceFrameRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelSequenceFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelSequenceFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceFrameRate_LevelSequence_Offset), 0, GetLevelSequenceFrameRate_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelSequenceFrameRate_FunctionAddress, intPtr, GetLevelSequenceFrameRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLevelSequenceFrameRate_ReturnValue_Offset), 0, GetLevelSequenceFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:ExportSequenceShotInfoToFile")]
	public unsafe static void ExportSequenceShotInfoToFile(ULevelSequence InLevelSequence, string FilePath)
	{
		if (!ExportSequenceShotInfoToFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:ExportSequenceShotInfoToFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportSequenceShotInfoToFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportSequenceShotInfoToFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ExportSequenceShotInfoToFile_InLevelSequence_Offset), 0, ExportSequenceShotInfoToFile_InLevelSequence_PropertyAddress.Address, InLevelSequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportSequenceShotInfoToFile_FilePath_Offset), 0, ExportSequenceShotInfoToFile_FilePath_PropertyAddress.Address, FilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportSequenceShotInfoToFile_FunctionAddress, intPtr, ExportSequenceShotInfoToFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportSequenceShotInfoToFile_FilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:ClearActor_Transform")]
	public unsafe static void ClearActor_Transform(ULevelSequence LevelSequence, AActor TargetActor)
	{
		if (!ClearActor_Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:ClearActor_Transform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearActor_Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearActor_Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ClearActor_Transform_LevelSequence_Offset), 0, ClearActor_Transform_LevelSequence_PropertyAddress.Address, LevelSequence);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ClearActor_Transform_TargetActor_Offset), 0, ClearActor_Transform_TargetActor_PropertyAddress.Address, TargetActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearActor_Transform_FunctionAddress, intPtr, ClearActor_Transform_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:CheckSectionValid_FindSectionRangeEmpty")]
	public unsafe static void CheckSectionValid_FindSectionRangeEmpty(ULevelSequence LevelSequence, TSubclassOf<UMovieSceneTrack> TrackClass, TSubclassOf<UMovieSceneSection> SectionClass, out List<UMovieSceneSection> WarningSections)
	{
		if (!CheckSectionValid_FindSectionRangeEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:CheckSectionValid_FindSectionRangeEmpty");
			WarningSections = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckSectionValid_FindSectionRangeEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckSectionValid_FindSectionRangeEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, CheckSectionValid_FindSectionRangeEmpty_LevelSequence_Offset), 0, CheckSectionValid_FindSectionRangeEmpty_LevelSequence_PropertyAddress.Address, LevelSequence);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, CheckSectionValid_FindSectionRangeEmpty_TrackClass_Offset), 0, CheckSectionValid_FindSectionRangeEmpty_TrackClass_PropertyAddress.Address, TrackClass);
		TSubclassOfMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, CheckSectionValid_FindSectionRangeEmpty_SectionClass_Offset), 0, CheckSectionValid_FindSectionRangeEmpty_SectionClass_PropertyAddress.Address, SectionClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, intPtr, CheckSectionValid_FindSectionRangeEmpty_ParamsSize);
		WarningSections = new TArrayCopyMarshaler<UMovieSceneSection>(1, CheckSectionValid_FindSectionRangeEmpty_WarningSections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).FromNative(IntPtr.Add(intPtr, CheckSectionValid_FindSectionRangeEmpty_WarningSections_Offset));
		NativeReflection.DestroyValue_InContainer(CheckSectionValid_FindSectionRangeEmpty_WarningSections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:Carry_AKEventTrack")]
	public unsafe static bool Carry_AKEventTrack(ULevelSequence LevelSequence, TSubclassOf<UMovieSceneTrack> TrackClass, TSubclassOf<UObject> SectionType, out List<UMovieSceneSection> AddedSections, out List<UAkAudioEvent> AkEvents)
	{
		if (!Carry_AKEventTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:Carry_AKEventTrack");
			AddedSections = null;
			AkEvents = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Carry_AKEventTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Carry_AKEventTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, Carry_AKEventTrack_LevelSequence_Offset), 0, Carry_AKEventTrack_LevelSequence_PropertyAddress.Address, LevelSequence);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, Carry_AKEventTrack_TrackClass_Offset), 0, Carry_AKEventTrack_TrackClass_PropertyAddress.Address, TrackClass);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Carry_AKEventTrack_SectionType_Offset), 0, Carry_AKEventTrack_SectionType_PropertyAddress.Address, SectionType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Carry_AKEventTrack_FunctionAddress, intPtr, Carry_AKEventTrack_ParamsSize);
		AddedSections = new TArrayCopyMarshaler<UMovieSceneSection>(1, Carry_AKEventTrack_AddedSections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).FromNative(IntPtr.Add(intPtr, Carry_AKEventTrack_AddedSections_Offset));
		NativeReflection.DestroyValue_InContainer(Carry_AKEventTrack_AddedSections_PropertyAddress.Address, intPtr);
		AkEvents = new TArrayCopyMarshaler<UAkAudioEvent>(1, Carry_AKEventTrack_AkEvents_PropertyAddress, CachedMarshalingDelegates<UAkAudioEvent, UObjectMarshaler<UAkAudioEvent>>.FromNative, CachedMarshalingDelegates<UAkAudioEvent, UObjectMarshaler<UAkAudioEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, Carry_AKEventTrack_AkEvents_Offset));
		NativeReflection.DestroyValue_InContainer(Carry_AKEventTrack_AkEvents_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Carry_AKEventTrack_ReturnValue_Offset), 0, Carry_AKEventTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocusDistance")]
	public unsafe static void AddKeyframeToCineCameraTrack_FocusDistance(ULevelSequence LevelSequence, ACineCameraActor CineCameraActor, int FrameToKey, float InFocusDistance)
	{
		if (!AddKeyframeToCineCameraTrack_FocusDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocusDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKeyframeToCineCameraTrack_FocusDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKeyframeToCineCameraTrack_FocusDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_Offset), 0, AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_PropertyAddress.Address, LevelSequence);
		UObjectMarshaler<ACineCameraActor>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_Offset), 0, AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_PropertyAddress.Address, CineCameraActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_Offset), 0, AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_PropertyAddress.Address, FrameToKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_Offset), 0, AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_PropertyAddress.Address, InFocusDistance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, intPtr, AddKeyframeToCineCameraTrack_FocusDistance_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocalLength")]
	public unsafe static void AddKeyframeToCineCameraTrack_FocalLength(ULevelSequence LevelSequence, ACineCameraActor CineCameraActor, int FrameToKey, float InFocalLength)
	{
		if (!AddKeyframeToCineCameraTrack_FocalLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocalLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKeyframeToCineCameraTrack_FocalLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKeyframeToCineCameraTrack_FocalLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_Offset), 0, AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_PropertyAddress.Address, LevelSequence);
		UObjectMarshaler<ACineCameraActor>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_Offset), 0, AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_PropertyAddress.Address, CineCameraActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_Offset), 0, AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_PropertyAddress.Address, FrameToKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_Offset), 0, AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_PropertyAddress.Address, InFocalLength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, intPtr, AddKeyframeToCineCameraTrack_FocalLength_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCameraTrack_Transform")]
	public unsafe static void AddKeyframeToCameraTrack_Transform(ULevelSequence LevelSequence, ACameraActor CameraActor, int FrameToKey, FTransform InTransform)
	{
		if (!AddKeyframeToCameraTrack_Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCameraTrack_Transform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKeyframeToCameraTrack_Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKeyframeToCameraTrack_Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCameraTrack_Transform_LevelSequence_Offset), 0, AddKeyframeToCameraTrack_Transform_LevelSequence_PropertyAddress.Address, LevelSequence);
		UObjectMarshaler<ACameraActor>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCameraTrack_Transform_CameraActor_Offset), 0, AddKeyframeToCameraTrack_Transform_CameraActor_PropertyAddress.Address, CameraActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCameraTrack_Transform_FrameToKey_Offset), 0, AddKeyframeToCameraTrack_Transform_FrameToKey_PropertyAddress.Address, FrameToKey);
		NativeReflection.InitializeValue_InContainer(AddKeyframeToCameraTrack_Transform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddKeyframeToCameraTrack_Transform_InTransform_Offset), 0, AddKeyframeToCameraTrack_Transform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddKeyframeToCameraTrack_Transform_FunctionAddress, intPtr, AddKeyframeToCameraTrack_Transform_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToActor_Transform")]
	public unsafe static void AddKeyframeToActor_Transform(ULevelSequence LevelSequence, AActor TargetActor, int FrameToKey, FTransform InTransform)
	{
		if (!AddKeyframeToActor_Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToActor_Transform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddKeyframeToActor_Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddKeyframeToActor_Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, AddKeyframeToActor_Transform_LevelSequence_Offset), 0, AddKeyframeToActor_Transform_LevelSequence_PropertyAddress.Address, LevelSequence);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddKeyframeToActor_Transform_TargetActor_Offset), 0, AddKeyframeToActor_Transform_TargetActor_PropertyAddress.Address, TargetActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddKeyframeToActor_Transform_FrameToKey_Offset), 0, AddKeyframeToActor_Transform_FrameToKey_PropertyAddress.Address, FrameToKey);
		NativeReflection.InitializeValue_InContainer(AddKeyframeToActor_Transform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddKeyframeToActor_Transform_InTransform_Offset), 0, AddKeyframeToActor_Transform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddKeyframeToActor_Transform_FunctionAddress, intPtr, AddKeyframeToActor_Transform_ParamsSize);
	}

	static UGSEditorSequencerLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorSequencerLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorSequencerLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorSequencerLibrary");
		RemoveSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSections");
		RemoveSections_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSections_LevelSequence_PropertyAddress, RemoveSections_FunctionAddress, "LevelSequence");
		RemoveSections_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSections_FunctionAddress, "LevelSequence");
		RemoveSections_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSections_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSections_Sections_PropertyAddress, RemoveSections_FunctionAddress, "Sections");
		RemoveSections_Sections_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSections_FunctionAddress, "Sections");
		RemoveSections_Sections_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSections_FunctionAddress, "Sections", Classes.FArrayProperty);
		RemoveSections_IsValid = RemoveSections_FunctionAddress != IntPtr.Zero && RemoveSections_LevelSequence_IsValid && RemoveSections_Sections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:RemoveSections", RemoveSections_IsValid);
		GetLevelSequenceFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelSequenceFrameRate");
		GetLevelSequenceFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelSequenceFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceFrameRate_LevelSequence_PropertyAddress, GetLevelSequenceFrameRate_FunctionAddress, "LevelSequence");
		GetLevelSequenceFrameRate_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceFrameRate_FunctionAddress, "LevelSequence");
		GetLevelSequenceFrameRate_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceFrameRate_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceFrameRate_ReturnValue_PropertyAddress, GetLevelSequenceFrameRate_FunctionAddress, "ReturnValue");
		GetLevelSequenceFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceFrameRate_FunctionAddress, "ReturnValue");
		GetLevelSequenceFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceFrameRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLevelSequenceFrameRate_IsValid = GetLevelSequenceFrameRate_FunctionAddress != IntPtr.Zero && GetLevelSequenceFrameRate_LevelSequence_IsValid && GetLevelSequenceFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:GetLevelSequenceFrameRate", GetLevelSequenceFrameRate_IsValid);
		ExportSequenceShotInfoToFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportSequenceShotInfoToFile");
		ExportSequenceShotInfoToFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportSequenceShotInfoToFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportSequenceShotInfoToFile_InLevelSequence_PropertyAddress, ExportSequenceShotInfoToFile_FunctionAddress, "InLevelSequence");
		ExportSequenceShotInfoToFile_InLevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExportSequenceShotInfoToFile_FunctionAddress, "InLevelSequence");
		ExportSequenceShotInfoToFile_InLevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportSequenceShotInfoToFile_FunctionAddress, "InLevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportSequenceShotInfoToFile_FilePath_PropertyAddress, ExportSequenceShotInfoToFile_FunctionAddress, "FilePath");
		ExportSequenceShotInfoToFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportSequenceShotInfoToFile_FunctionAddress, "FilePath");
		ExportSequenceShotInfoToFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportSequenceShotInfoToFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		ExportSequenceShotInfoToFile_IsValid = ExportSequenceShotInfoToFile_FunctionAddress != IntPtr.Zero && ExportSequenceShotInfoToFile_InLevelSequence_IsValid && ExportSequenceShotInfoToFile_FilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:ExportSequenceShotInfoToFile", ExportSequenceShotInfoToFile_IsValid);
		ClearActor_Transform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearActor_Transform");
		ClearActor_Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearActor_Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearActor_Transform_LevelSequence_PropertyAddress, ClearActor_Transform_FunctionAddress, "LevelSequence");
		ClearActor_Transform_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(ClearActor_Transform_FunctionAddress, "LevelSequence");
		ClearActor_Transform_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearActor_Transform_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearActor_Transform_TargetActor_PropertyAddress, ClearActor_Transform_FunctionAddress, "TargetActor");
		ClearActor_Transform_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(ClearActor_Transform_FunctionAddress, "TargetActor");
		ClearActor_Transform_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearActor_Transform_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		ClearActor_Transform_IsValid = ClearActor_Transform_FunctionAddress != IntPtr.Zero && ClearActor_Transform_LevelSequence_IsValid && ClearActor_Transform_TargetActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:ClearActor_Transform", ClearActor_Transform_IsValid);
		CheckSectionValid_FindSectionRangeEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckSectionValid_FindSectionRangeEmpty");
		CheckSectionValid_FindSectionRangeEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckSectionValid_FindSectionRangeEmpty_LevelSequence_PropertyAddress, CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "LevelSequence");
		CheckSectionValid_FindSectionRangeEmpty_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "LevelSequence");
		CheckSectionValid_FindSectionRangeEmpty_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckSectionValid_FindSectionRangeEmpty_TrackClass_PropertyAddress, CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "TrackClass");
		CheckSectionValid_FindSectionRangeEmpty_TrackClass_Offset = NativeReflectionCached.GetPropertyOffset(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "TrackClass");
		CheckSectionValid_FindSectionRangeEmpty_TrackClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "TrackClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckSectionValid_FindSectionRangeEmpty_SectionClass_PropertyAddress, CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "SectionClass");
		CheckSectionValid_FindSectionRangeEmpty_SectionClass_Offset = NativeReflectionCached.GetPropertyOffset(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "SectionClass");
		CheckSectionValid_FindSectionRangeEmpty_SectionClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "SectionClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckSectionValid_FindSectionRangeEmpty_WarningSections_PropertyAddress, CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "WarningSections");
		CheckSectionValid_FindSectionRangeEmpty_WarningSections_Offset = NativeReflectionCached.GetPropertyOffset(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "WarningSections");
		CheckSectionValid_FindSectionRangeEmpty_WarningSections_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSectionValid_FindSectionRangeEmpty_FunctionAddress, "WarningSections", Classes.FArrayProperty);
		CheckSectionValid_FindSectionRangeEmpty_IsValid = CheckSectionValid_FindSectionRangeEmpty_FunctionAddress != IntPtr.Zero && CheckSectionValid_FindSectionRangeEmpty_LevelSequence_IsValid && CheckSectionValid_FindSectionRangeEmpty_TrackClass_IsValid && CheckSectionValid_FindSectionRangeEmpty_SectionClass_IsValid && CheckSectionValid_FindSectionRangeEmpty_WarningSections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:CheckSectionValid_FindSectionRangeEmpty", CheckSectionValid_FindSectionRangeEmpty_IsValid);
		Carry_AKEventTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Carry_AKEventTrack");
		Carry_AKEventTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(Carry_AKEventTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_LevelSequence_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "LevelSequence");
		Carry_AKEventTrack_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "LevelSequence");
		Carry_AKEventTrack_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_TrackClass_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "TrackClass");
		Carry_AKEventTrack_TrackClass_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "TrackClass");
		Carry_AKEventTrack_TrackClass_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "TrackClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_SectionType_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "SectionType");
		Carry_AKEventTrack_SectionType_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "SectionType");
		Carry_AKEventTrack_SectionType_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "SectionType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_AddedSections_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "AddedSections");
		Carry_AKEventTrack_AddedSections_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "AddedSections");
		Carry_AKEventTrack_AddedSections_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "AddedSections", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_AkEvents_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "AkEvents");
		Carry_AKEventTrack_AkEvents_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "AkEvents");
		Carry_AKEventTrack_AkEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "AkEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Carry_AKEventTrack_ReturnValue_PropertyAddress, Carry_AKEventTrack_FunctionAddress, "ReturnValue");
		Carry_AKEventTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Carry_AKEventTrack_FunctionAddress, "ReturnValue");
		Carry_AKEventTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Carry_AKEventTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Carry_AKEventTrack_IsValid = Carry_AKEventTrack_FunctionAddress != IntPtr.Zero && Carry_AKEventTrack_LevelSequence_IsValid && Carry_AKEventTrack_TrackClass_IsValid && Carry_AKEventTrack_SectionType_IsValid && Carry_AKEventTrack_AddedSections_IsValid && Carry_AKEventTrack_AkEvents_IsValid && Carry_AKEventTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:Carry_AKEventTrack", Carry_AKEventTrack_IsValid);
		AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddKeyframeToCineCameraTrack_FocusDistance");
		AddKeyframeToCineCameraTrack_FocusDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_PropertyAddress, AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "LevelSequence");
		AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "LevelSequence");
		AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_PropertyAddress, AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "CineCameraActor");
		AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "CineCameraActor");
		AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "CineCameraActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_PropertyAddress, AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "FrameToKey");
		AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "FrameToKey");
		AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "FrameToKey", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_PropertyAddress, AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "InFocusDistance");
		AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "InFocusDistance");
		AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress, "InFocusDistance", Classes.FFloatProperty);
		AddKeyframeToCineCameraTrack_FocusDistance_IsValid = AddKeyframeToCineCameraTrack_FocusDistance_FunctionAddress != IntPtr.Zero && AddKeyframeToCineCameraTrack_FocusDistance_LevelSequence_IsValid && AddKeyframeToCineCameraTrack_FocusDistance_CineCameraActor_IsValid && AddKeyframeToCineCameraTrack_FocusDistance_FrameToKey_IsValid && AddKeyframeToCineCameraTrack_FocusDistance_InFocusDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocusDistance", AddKeyframeToCineCameraTrack_FocusDistance_IsValid);
		AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddKeyframeToCineCameraTrack_FocalLength");
		AddKeyframeToCineCameraTrack_FocalLength_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_PropertyAddress, AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "LevelSequence");
		AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "LevelSequence");
		AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_PropertyAddress, AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "CineCameraActor");
		AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "CineCameraActor");
		AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "CineCameraActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_PropertyAddress, AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "FrameToKey");
		AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "FrameToKey");
		AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "FrameToKey", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_PropertyAddress, AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "InFocalLength");
		AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "InFocalLength");
		AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress, "InFocalLength", Classes.FFloatProperty);
		AddKeyframeToCineCameraTrack_FocalLength_IsValid = AddKeyframeToCineCameraTrack_FocalLength_FunctionAddress != IntPtr.Zero && AddKeyframeToCineCameraTrack_FocalLength_LevelSequence_IsValid && AddKeyframeToCineCameraTrack_FocalLength_CineCameraActor_IsValid && AddKeyframeToCineCameraTrack_FocalLength_FrameToKey_IsValid && AddKeyframeToCineCameraTrack_FocalLength_InFocalLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCineCameraTrack_FocalLength", AddKeyframeToCineCameraTrack_FocalLength_IsValid);
		AddKeyframeToCameraTrack_Transform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddKeyframeToCameraTrack_Transform");
		AddKeyframeToCameraTrack_Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKeyframeToCameraTrack_Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCameraTrack_Transform_LevelSequence_PropertyAddress, AddKeyframeToCameraTrack_Transform_FunctionAddress, "LevelSequence");
		AddKeyframeToCameraTrack_Transform_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCameraTrack_Transform_FunctionAddress, "LevelSequence");
		AddKeyframeToCameraTrack_Transform_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCameraTrack_Transform_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCameraTrack_Transform_CameraActor_PropertyAddress, AddKeyframeToCameraTrack_Transform_FunctionAddress, "CameraActor");
		AddKeyframeToCameraTrack_Transform_CameraActor_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCameraTrack_Transform_FunctionAddress, "CameraActor");
		AddKeyframeToCameraTrack_Transform_CameraActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCameraTrack_Transform_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCameraTrack_Transform_FrameToKey_PropertyAddress, AddKeyframeToCameraTrack_Transform_FunctionAddress, "FrameToKey");
		AddKeyframeToCameraTrack_Transform_FrameToKey_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCameraTrack_Transform_FunctionAddress, "FrameToKey");
		AddKeyframeToCameraTrack_Transform_FrameToKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCameraTrack_Transform_FunctionAddress, "FrameToKey", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToCameraTrack_Transform_InTransform_PropertyAddress, AddKeyframeToCameraTrack_Transform_FunctionAddress, "InTransform");
		AddKeyframeToCameraTrack_Transform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToCameraTrack_Transform_FunctionAddress, "InTransform");
		AddKeyframeToCameraTrack_Transform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToCameraTrack_Transform_FunctionAddress, "InTransform", Classes.FStructProperty);
		AddKeyframeToCameraTrack_Transform_IsValid = AddKeyframeToCameraTrack_Transform_FunctionAddress != IntPtr.Zero && AddKeyframeToCameraTrack_Transform_LevelSequence_IsValid && AddKeyframeToCameraTrack_Transform_CameraActor_IsValid && AddKeyframeToCameraTrack_Transform_FrameToKey_IsValid && AddKeyframeToCameraTrack_Transform_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToCameraTrack_Transform", AddKeyframeToCameraTrack_Transform_IsValid);
		AddKeyframeToActor_Transform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddKeyframeToActor_Transform");
		AddKeyframeToActor_Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddKeyframeToActor_Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToActor_Transform_LevelSequence_PropertyAddress, AddKeyframeToActor_Transform_FunctionAddress, "LevelSequence");
		AddKeyframeToActor_Transform_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToActor_Transform_FunctionAddress, "LevelSequence");
		AddKeyframeToActor_Transform_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToActor_Transform_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToActor_Transform_TargetActor_PropertyAddress, AddKeyframeToActor_Transform_FunctionAddress, "TargetActor");
		AddKeyframeToActor_Transform_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToActor_Transform_FunctionAddress, "TargetActor");
		AddKeyframeToActor_Transform_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToActor_Transform_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToActor_Transform_FrameToKey_PropertyAddress, AddKeyframeToActor_Transform_FunctionAddress, "FrameToKey");
		AddKeyframeToActor_Transform_FrameToKey_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToActor_Transform_FunctionAddress, "FrameToKey");
		AddKeyframeToActor_Transform_FrameToKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToActor_Transform_FunctionAddress, "FrameToKey", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddKeyframeToActor_Transform_InTransform_PropertyAddress, AddKeyframeToActor_Transform_FunctionAddress, "InTransform");
		AddKeyframeToActor_Transform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddKeyframeToActor_Transform_FunctionAddress, "InTransform");
		AddKeyframeToActor_Transform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddKeyframeToActor_Transform_FunctionAddress, "InTransform", Classes.FStructProperty);
		AddKeyframeToActor_Transform_IsValid = AddKeyframeToActor_Transform_FunctionAddress != IntPtr.Zero && AddKeyframeToActor_Transform_LevelSequence_IsValid && AddKeyframeToActor_Transform_TargetActor_IsValid && AddKeyframeToActor_Transform_FrameToKey_IsValid && AddKeyframeToActor_Transform_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorSequencerLibrary:AddKeyframeToActor_Transform", AddKeyframeToActor_Transform_IsValid);
	}
}
