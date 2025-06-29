using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneSequenceExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SortMarkedFrames_IsValid;

	private static IntPtr SortMarkedFrames_FunctionAddress;

	private static int SortMarkedFrames_ParamsSize;

	private static bool SortMarkedFrames_Sequence_IsValid;

	private static FFieldAddress SortMarkedFrames_Sequence_PropertyAddress;

	private static int SortMarkedFrames_Sequence_Offset;

	private static bool SetWorkRangeStart_IsValid;

	private static IntPtr SetWorkRangeStart_FunctionAddress;

	private static int SetWorkRangeStart_ParamsSize;

	private static bool SetWorkRangeStart_InSequence_IsValid;

	private static FFieldAddress SetWorkRangeStart_InSequence_PropertyAddress;

	private static int SetWorkRangeStart_InSequence_Offset;

	private static bool SetWorkRangeStart_StartTimeInSeconds_IsValid;

	private static FFieldAddress SetWorkRangeStart_StartTimeInSeconds_PropertyAddress;

	private static int SetWorkRangeStart_StartTimeInSeconds_Offset;

	private static bool SetWorkRangeEnd_IsValid;

	private static IntPtr SetWorkRangeEnd_FunctionAddress;

	private static int SetWorkRangeEnd_ParamsSize;

	private static bool SetWorkRangeEnd_InSequence_IsValid;

	private static FFieldAddress SetWorkRangeEnd_InSequence_PropertyAddress;

	private static int SetWorkRangeEnd_InSequence_Offset;

	private static bool SetWorkRangeEnd_EndTimeInSeconds_IsValid;

	private static FFieldAddress SetWorkRangeEnd_EndTimeInSeconds_PropertyAddress;

	private static int SetWorkRangeEnd_EndTimeInSeconds_Offset;

	private static bool SetViewRangeStart_IsValid;

	private static IntPtr SetViewRangeStart_FunctionAddress;

	private static int SetViewRangeStart_ParamsSize;

	private static bool SetViewRangeStart_InSequence_IsValid;

	private static FFieldAddress SetViewRangeStart_InSequence_PropertyAddress;

	private static int SetViewRangeStart_InSequence_Offset;

	private static bool SetViewRangeStart_StartTimeInSeconds_IsValid;

	private static FFieldAddress SetViewRangeStart_StartTimeInSeconds_PropertyAddress;

	private static int SetViewRangeStart_StartTimeInSeconds_Offset;

	private static bool SetViewRangeEnd_IsValid;

	private static IntPtr SetViewRangeEnd_FunctionAddress;

	private static int SetViewRangeEnd_ParamsSize;

	private static bool SetViewRangeEnd_InSequence_IsValid;

	private static FFieldAddress SetViewRangeEnd_InSequence_PropertyAddress;

	private static int SetViewRangeEnd_InSequence_Offset;

	private static bool SetViewRangeEnd_EndTimeInSeconds_IsValid;

	private static FFieldAddress SetViewRangeEnd_EndTimeInSeconds_PropertyAddress;

	private static int SetViewRangeEnd_EndTimeInSeconds_Offset;

	private static bool SetTickResolutionDirectly_IsValid;

	private static IntPtr SetTickResolutionDirectly_FunctionAddress;

	private static int SetTickResolutionDirectly_ParamsSize;

	private static bool SetTickResolutionDirectly_Sequence_IsValid;

	private static FFieldAddress SetTickResolutionDirectly_Sequence_PropertyAddress;

	private static int SetTickResolutionDirectly_Sequence_Offset;

	private static bool SetTickResolutionDirectly_TickResolution_IsValid;

	private static FFieldAddress SetTickResolutionDirectly_TickResolution_PropertyAddress;

	private static int SetTickResolutionDirectly_TickResolution_Offset;

	private static bool SetTickResolution_IsValid;

	private static IntPtr SetTickResolution_FunctionAddress;

	private static int SetTickResolution_ParamsSize;

	private static bool SetTickResolution_Sequence_IsValid;

	private static FFieldAddress SetTickResolution_Sequence_PropertyAddress;

	private static int SetTickResolution_Sequence_Offset;

	private static bool SetTickResolution_TickResolution_IsValid;

	private static FFieldAddress SetTickResolution_TickResolution_PropertyAddress;

	private static int SetTickResolution_TickResolution_Offset;

	private static bool SetReadOnly_IsValid;

	private static IntPtr SetReadOnly_FunctionAddress;

	private static int SetReadOnly_ParamsSize;

	private static bool SetReadOnly_Sequence_IsValid;

	private static FFieldAddress SetReadOnly_Sequence_PropertyAddress;

	private static int SetReadOnly_Sequence_Offset;

	private static bool SetReadOnly_bInReadOnly_IsValid;

	private static FFieldAddress SetReadOnly_bInReadOnly_PropertyAddress;

	private static int SetReadOnly_bInReadOnly_Offset;

	private static bool SetPlaybackStartSeconds_IsValid;

	private static IntPtr SetPlaybackStartSeconds_FunctionAddress;

	private static int SetPlaybackStartSeconds_ParamsSize;

	private static bool SetPlaybackStartSeconds_Sequence_IsValid;

	private static FFieldAddress SetPlaybackStartSeconds_Sequence_PropertyAddress;

	private static int SetPlaybackStartSeconds_Sequence_Offset;

	private static bool SetPlaybackStartSeconds_StartTime_IsValid;

	private static FFieldAddress SetPlaybackStartSeconds_StartTime_PropertyAddress;

	private static int SetPlaybackStartSeconds_StartTime_Offset;

	private static bool SetPlaybackStart_IsValid;

	private static IntPtr SetPlaybackStart_FunctionAddress;

	private static int SetPlaybackStart_ParamsSize;

	private static bool SetPlaybackStart_Sequence_IsValid;

	private static FFieldAddress SetPlaybackStart_Sequence_PropertyAddress;

	private static int SetPlaybackStart_Sequence_Offset;

	private static bool SetPlaybackStart_StartFrame_IsValid;

	private static FFieldAddress SetPlaybackStart_StartFrame_PropertyAddress;

	private static int SetPlaybackStart_StartFrame_Offset;

	private static bool SetPlaybackEndSeconds_IsValid;

	private static IntPtr SetPlaybackEndSeconds_FunctionAddress;

	private static int SetPlaybackEndSeconds_ParamsSize;

	private static bool SetPlaybackEndSeconds_Sequence_IsValid;

	private static FFieldAddress SetPlaybackEndSeconds_Sequence_PropertyAddress;

	private static int SetPlaybackEndSeconds_Sequence_Offset;

	private static bool SetPlaybackEndSeconds_EndTime_IsValid;

	private static FFieldAddress SetPlaybackEndSeconds_EndTime_PropertyAddress;

	private static int SetPlaybackEndSeconds_EndTime_Offset;

	private static bool SetPlaybackEnd_IsValid;

	private static IntPtr SetPlaybackEnd_FunctionAddress;

	private static int SetPlaybackEnd_ParamsSize;

	private static bool SetPlaybackEnd_Sequence_IsValid;

	private static FFieldAddress SetPlaybackEnd_Sequence_PropertyAddress;

	private static int SetPlaybackEnd_Sequence_Offset;

	private static bool SetPlaybackEnd_EndFrame_IsValid;

	private static FFieldAddress SetPlaybackEnd_EndFrame_PropertyAddress;

	private static int SetPlaybackEnd_EndFrame_Offset;

	private static bool SetMarkedFrame_IsValid;

	private static IntPtr SetMarkedFrame_FunctionAddress;

	private static int SetMarkedFrame_ParamsSize;

	private static bool SetMarkedFrame_Sequence_IsValid;

	private static FFieldAddress SetMarkedFrame_Sequence_PropertyAddress;

	private static int SetMarkedFrame_Sequence_Offset;

	private static bool SetMarkedFrame_InMarkIndex_IsValid;

	private static FFieldAddress SetMarkedFrame_InMarkIndex_PropertyAddress;

	private static int SetMarkedFrame_InMarkIndex_Offset;

	private static bool SetMarkedFrame_InFrameNumber_IsValid;

	private static FFieldAddress SetMarkedFrame_InFrameNumber_PropertyAddress;

	private static int SetMarkedFrame_InFrameNumber_Offset;

	private static bool SetEvaluationType_IsValid;

	private static IntPtr SetEvaluationType_FunctionAddress;

	private static int SetEvaluationType_ParamsSize;

	private static bool SetEvaluationType_InSequence_IsValid;

	private static FFieldAddress SetEvaluationType_InSequence_PropertyAddress;

	private static int SetEvaluationType_InSequence_Offset;

	private static bool SetEvaluationType_InEvaluationType_IsValid;

	private static FFieldAddress SetEvaluationType_InEvaluationType_PropertyAddress;

	private static int SetEvaluationType_InEvaluationType_Offset;

	private static bool SetDisplayRate_IsValid;

	private static IntPtr SetDisplayRate_FunctionAddress;

	private static int SetDisplayRate_ParamsSize;

	private static bool SetDisplayRate_Sequence_IsValid;

	private static FFieldAddress SetDisplayRate_Sequence_PropertyAddress;

	private static int SetDisplayRate_Sequence_Offset;

	private static bool SetDisplayRate_DisplayRate_IsValid;

	private static FFieldAddress SetDisplayRate_DisplayRate_PropertyAddress;

	private static int SetDisplayRate_DisplayRate_Offset;

	private static bool SetClockSource_IsValid;

	private static IntPtr SetClockSource_FunctionAddress;

	private static int SetClockSource_ParamsSize;

	private static bool SetClockSource_InSequence_IsValid;

	private static FFieldAddress SetClockSource_InSequence_PropertyAddress;

	private static int SetClockSource_InSequence_Offset;

	private static bool SetClockSource_InClockSource_IsValid;

	private static FFieldAddress SetClockSource_InClockSource_PropertyAddress;

	private static int SetClockSource_InClockSource_Offset;

	private static bool ResolveBindingID_IsValid;

	private static IntPtr ResolveBindingID_FunctionAddress;

	private static int ResolveBindingID_ParamsSize;

	private static bool ResolveBindingID_MasterSequence_IsValid;

	private static FFieldAddress ResolveBindingID_MasterSequence_PropertyAddress;

	private static int ResolveBindingID_MasterSequence_Offset;

	private static bool ResolveBindingID_InObjectBindingID_IsValid;

	private static FFieldAddress ResolveBindingID_InObjectBindingID_PropertyAddress;

	private static int ResolveBindingID_InObjectBindingID_Offset;

	private static bool ResolveBindingID_ReturnValue_IsValid;

	private static FFieldAddress ResolveBindingID_ReturnValue_PropertyAddress;

	private static int ResolveBindingID_ReturnValue_Offset;

	private static bool RemoveMasterTrack_IsValid;

	private static IntPtr RemoveMasterTrack_FunctionAddress;

	private static int RemoveMasterTrack_ParamsSize;

	private static bool RemoveMasterTrack_Sequence_IsValid;

	private static FFieldAddress RemoveMasterTrack_Sequence_PropertyAddress;

	private static int RemoveMasterTrack_Sequence_Offset;

	private static bool RemoveMasterTrack_MasterTrack_IsValid;

	private static FFieldAddress RemoveMasterTrack_MasterTrack_PropertyAddress;

	private static int RemoveMasterTrack_MasterTrack_Offset;

	private static bool RemoveMasterTrack_ReturnValue_IsValid;

	private static FFieldAddress RemoveMasterTrack_ReturnValue_PropertyAddress;

	private static int RemoveMasterTrack_ReturnValue_Offset;

	private static bool MakeRangeSeconds_IsValid;

	private static IntPtr MakeRangeSeconds_FunctionAddress;

	private static int MakeRangeSeconds_ParamsSize;

	private static bool MakeRangeSeconds_Sequence_IsValid;

	private static FFieldAddress MakeRangeSeconds_Sequence_PropertyAddress;

	private static int MakeRangeSeconds_Sequence_Offset;

	private static bool MakeRangeSeconds_StartTime_IsValid;

	private static FFieldAddress MakeRangeSeconds_StartTime_PropertyAddress;

	private static int MakeRangeSeconds_StartTime_Offset;

	private static bool MakeRangeSeconds_Duration_IsValid;

	private static FFieldAddress MakeRangeSeconds_Duration_PropertyAddress;

	private static int MakeRangeSeconds_Duration_Offset;

	private static bool MakeRangeSeconds_ReturnValue_IsValid;

	private static FFieldAddress MakeRangeSeconds_ReturnValue_PropertyAddress;

	private static int MakeRangeSeconds_ReturnValue_Offset;

	private static bool MakeRange_IsValid;

	private static IntPtr MakeRange_FunctionAddress;

	private static int MakeRange_ParamsSize;

	private static bool MakeRange_Sequence_IsValid;

	private static FFieldAddress MakeRange_Sequence_PropertyAddress;

	private static int MakeRange_Sequence_Offset;

	private static bool MakeRange_StartFrame_IsValid;

	private static FFieldAddress MakeRange_StartFrame_PropertyAddress;

	private static int MakeRange_StartFrame_Offset;

	private static bool MakeRange_Duration_IsValid;

	private static FFieldAddress MakeRange_Duration_PropertyAddress;

	private static int MakeRange_Duration_Offset;

	private static bool MakeRange_ReturnValue_IsValid;

	private static FFieldAddress MakeRange_ReturnValue_PropertyAddress;

	private static int MakeRange_ReturnValue_Offset;

	private static bool LocateBoundObjects_IsValid;

	private static IntPtr LocateBoundObjects_FunctionAddress;

	private static int LocateBoundObjects_ParamsSize;

	private static bool LocateBoundObjects_Sequence_IsValid;

	private static FFieldAddress LocateBoundObjects_Sequence_PropertyAddress;

	private static int LocateBoundObjects_Sequence_Offset;

	private static bool LocateBoundObjects_InBinding_IsValid;

	private static FFieldAddress LocateBoundObjects_InBinding_PropertyAddress;

	private static int LocateBoundObjects_InBinding_Offset;

	private static bool LocateBoundObjects_Context_IsValid;

	private static FFieldAddress LocateBoundObjects_Context_PropertyAddress;

	private static int LocateBoundObjects_Context_Offset;

	private static bool LocateBoundObjects_ReturnValue_IsValid;

	private static FFieldAddress LocateBoundObjects_ReturnValue_PropertyAddress;

	private static int LocateBoundObjects_ReturnValue_Offset;

	private static bool IsReadOnly_IsValid;

	private static IntPtr IsReadOnly_FunctionAddress;

	private static int IsReadOnly_ParamsSize;

	private static bool IsReadOnly_Sequence_IsValid;

	private static FFieldAddress IsReadOnly_Sequence_PropertyAddress;

	private static int IsReadOnly_Sequence_Offset;

	private static bool IsReadOnly_ReturnValue_IsValid;

	private static FFieldAddress IsReadOnly_ReturnValue_PropertyAddress;

	private static int IsReadOnly_ReturnValue_Offset;

	private static bool GetWorkRangeStart_IsValid;

	private static IntPtr GetWorkRangeStart_FunctionAddress;

	private static int GetWorkRangeStart_ParamsSize;

	private static bool GetWorkRangeStart_InSequence_IsValid;

	private static FFieldAddress GetWorkRangeStart_InSequence_PropertyAddress;

	private static int GetWorkRangeStart_InSequence_Offset;

	private static bool GetWorkRangeStart_ReturnValue_IsValid;

	private static FFieldAddress GetWorkRangeStart_ReturnValue_PropertyAddress;

	private static int GetWorkRangeStart_ReturnValue_Offset;

	private static bool GetWorkRangeEnd_IsValid;

	private static IntPtr GetWorkRangeEnd_FunctionAddress;

	private static int GetWorkRangeEnd_ParamsSize;

	private static bool GetWorkRangeEnd_InSequence_IsValid;

	private static FFieldAddress GetWorkRangeEnd_InSequence_PropertyAddress;

	private static int GetWorkRangeEnd_InSequence_Offset;

	private static bool GetWorkRangeEnd_ReturnValue_IsValid;

	private static FFieldAddress GetWorkRangeEnd_ReturnValue_PropertyAddress;

	private static int GetWorkRangeEnd_ReturnValue_Offset;

	private static bool GetViewRangeStart_IsValid;

	private static IntPtr GetViewRangeStart_FunctionAddress;

	private static int GetViewRangeStart_ParamsSize;

	private static bool GetViewRangeStart_InSequence_IsValid;

	private static FFieldAddress GetViewRangeStart_InSequence_PropertyAddress;

	private static int GetViewRangeStart_InSequence_Offset;

	private static bool GetViewRangeStart_ReturnValue_IsValid;

	private static FFieldAddress GetViewRangeStart_ReturnValue_PropertyAddress;

	private static int GetViewRangeStart_ReturnValue_Offset;

	private static bool GetViewRangeEnd_IsValid;

	private static IntPtr GetViewRangeEnd_FunctionAddress;

	private static int GetViewRangeEnd_ParamsSize;

	private static bool GetViewRangeEnd_InSequence_IsValid;

	private static FFieldAddress GetViewRangeEnd_InSequence_PropertyAddress;

	private static int GetViewRangeEnd_InSequence_Offset;

	private static bool GetViewRangeEnd_ReturnValue_IsValid;

	private static FFieldAddress GetViewRangeEnd_ReturnValue_PropertyAddress;

	private static int GetViewRangeEnd_ReturnValue_Offset;

	private static bool GetTickResolution_IsValid;

	private static IntPtr GetTickResolution_FunctionAddress;

	private static int GetTickResolution_ParamsSize;

	private static bool GetTickResolution_Sequence_IsValid;

	private static FFieldAddress GetTickResolution_Sequence_PropertyAddress;

	private static int GetTickResolution_Sequence_Offset;

	private static bool GetTickResolution_ReturnValue_IsValid;

	private static FFieldAddress GetTickResolution_ReturnValue_PropertyAddress;

	private static int GetTickResolution_ReturnValue_Offset;

	private static bool GetSpawnables_IsValid;

	private static IntPtr GetSpawnables_FunctionAddress;

	private static int GetSpawnables_ParamsSize;

	private static bool GetSpawnables_Sequence_IsValid;

	private static FFieldAddress GetSpawnables_Sequence_PropertyAddress;

	private static int GetSpawnables_Sequence_Offset;

	private static bool GetSpawnables_ReturnValue_IsValid;

	private static FFieldAddress GetSpawnables_ReturnValue_PropertyAddress;

	private static int GetSpawnables_ReturnValue_Offset;

	private static bool GetRootFoldersInSequence_IsValid;

	private static IntPtr GetRootFoldersInSequence_FunctionAddress;

	private static int GetRootFoldersInSequence_ParamsSize;

	private static bool GetRootFoldersInSequence_Sequence_IsValid;

	private static FFieldAddress GetRootFoldersInSequence_Sequence_PropertyAddress;

	private static int GetRootFoldersInSequence_Sequence_Offset;

	private static bool GetRootFoldersInSequence_ReturnValue_IsValid;

	private static FFieldAddress GetRootFoldersInSequence_ReturnValue_PropertyAddress;

	private static int GetRootFoldersInSequence_ReturnValue_Offset;

	private static bool GetPossessables_IsValid;

	private static IntPtr GetPossessables_FunctionAddress;

	private static int GetPossessables_ParamsSize;

	private static bool GetPossessables_Sequence_IsValid;

	private static FFieldAddress GetPossessables_Sequence_PropertyAddress;

	private static int GetPossessables_Sequence_Offset;

	private static bool GetPossessables_ReturnValue_IsValid;

	private static FFieldAddress GetPossessables_ReturnValue_PropertyAddress;

	private static int GetPossessables_ReturnValue_Offset;

	private static bool GetPortableBindingID_IsValid;

	private static IntPtr GetPortableBindingID_FunctionAddress;

	private static int GetPortableBindingID_ParamsSize;

	private static bool GetPortableBindingID_MasterSequence_IsValid;

	private static FFieldAddress GetPortableBindingID_MasterSequence_PropertyAddress;

	private static int GetPortableBindingID_MasterSequence_Offset;

	private static bool GetPortableBindingID_DestinationSequence_IsValid;

	private static FFieldAddress GetPortableBindingID_DestinationSequence_PropertyAddress;

	private static int GetPortableBindingID_DestinationSequence_Offset;

	private static bool GetPortableBindingID_InBinding_IsValid;

	private static FFieldAddress GetPortableBindingID_InBinding_PropertyAddress;

	private static int GetPortableBindingID_InBinding_Offset;

	private static bool GetPortableBindingID_ReturnValue_IsValid;

	private static FFieldAddress GetPortableBindingID_ReturnValue_PropertyAddress;

	private static int GetPortableBindingID_ReturnValue_Offset;

	private static bool GetPlaybackStartSeconds_IsValid;

	private static IntPtr GetPlaybackStartSeconds_FunctionAddress;

	private static int GetPlaybackStartSeconds_ParamsSize;

	private static bool GetPlaybackStartSeconds_Sequence_IsValid;

	private static FFieldAddress GetPlaybackStartSeconds_Sequence_PropertyAddress;

	private static int GetPlaybackStartSeconds_Sequence_Offset;

	private static bool GetPlaybackStartSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackStartSeconds_ReturnValue_PropertyAddress;

	private static int GetPlaybackStartSeconds_ReturnValue_Offset;

	private static bool GetPlaybackStart_IsValid;

	private static IntPtr GetPlaybackStart_FunctionAddress;

	private static int GetPlaybackStart_ParamsSize;

	private static bool GetPlaybackStart_Sequence_IsValid;

	private static FFieldAddress GetPlaybackStart_Sequence_PropertyAddress;

	private static int GetPlaybackStart_Sequence_Offset;

	private static bool GetPlaybackStart_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackStart_ReturnValue_PropertyAddress;

	private static int GetPlaybackStart_ReturnValue_Offset;

	private static bool GetPlaybackRange_IsValid;

	private static IntPtr GetPlaybackRange_FunctionAddress;

	private static int GetPlaybackRange_ParamsSize;

	private static bool GetPlaybackRange_Sequence_IsValid;

	private static FFieldAddress GetPlaybackRange_Sequence_PropertyAddress;

	private static int GetPlaybackRange_Sequence_Offset;

	private static bool GetPlaybackRange_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackRange_ReturnValue_PropertyAddress;

	private static int GetPlaybackRange_ReturnValue_Offset;

	private static bool GetPlaybackEndSeconds_IsValid;

	private static IntPtr GetPlaybackEndSeconds_FunctionAddress;

	private static int GetPlaybackEndSeconds_ParamsSize;

	private static bool GetPlaybackEndSeconds_Sequence_IsValid;

	private static FFieldAddress GetPlaybackEndSeconds_Sequence_PropertyAddress;

	private static int GetPlaybackEndSeconds_Sequence_Offset;

	private static bool GetPlaybackEndSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackEndSeconds_ReturnValue_PropertyAddress;

	private static int GetPlaybackEndSeconds_ReturnValue_Offset;

	private static bool GetPlaybackEnd_IsValid;

	private static IntPtr GetPlaybackEnd_FunctionAddress;

	private static int GetPlaybackEnd_ParamsSize;

	private static bool GetPlaybackEnd_Sequence_IsValid;

	private static FFieldAddress GetPlaybackEnd_Sequence_PropertyAddress;

	private static int GetPlaybackEnd_Sequence_Offset;

	private static bool GetPlaybackEnd_ReturnValue_IsValid;

	private static FFieldAddress GetPlaybackEnd_ReturnValue_PropertyAddress;

	private static int GetPlaybackEnd_ReturnValue_Offset;

	private static bool GetMovieScene_IsValid;

	private static IntPtr GetMovieScene_FunctionAddress;

	private static int GetMovieScene_ParamsSize;

	private static bool GetMovieScene_Sequence_IsValid;

	private static FFieldAddress GetMovieScene_Sequence_PropertyAddress;

	private static int GetMovieScene_Sequence_Offset;

	private static bool GetMovieScene_ReturnValue_IsValid;

	private static FFieldAddress GetMovieScene_ReturnValue_PropertyAddress;

	private static int GetMovieScene_ReturnValue_Offset;

	private static bool GetMasterTracks_IsValid;

	private static IntPtr GetMasterTracks_FunctionAddress;

	private static int GetMasterTracks_ParamsSize;

	private static bool GetMasterTracks_Sequence_IsValid;

	private static FFieldAddress GetMasterTracks_Sequence_PropertyAddress;

	private static int GetMasterTracks_Sequence_Offset;

	private static bool GetMasterTracks_ReturnValue_IsValid;

	private static FFieldAddress GetMasterTracks_ReturnValue_PropertyAddress;

	private static int GetMasterTracks_ReturnValue_Offset;

	private static bool GetMarkedFrames_IsValid;

	private static IntPtr GetMarkedFrames_FunctionAddress;

	private static int GetMarkedFrames_ParamsSize;

	private static bool GetMarkedFrames_Sequence_IsValid;

	private static FFieldAddress GetMarkedFrames_Sequence_PropertyAddress;

	private static int GetMarkedFrames_Sequence_Offset;

	private static bool GetMarkedFrames_ReturnValue_IsValid;

	private static FFieldAddress GetMarkedFrames_ReturnValue_PropertyAddress;

	private static int GetMarkedFrames_ReturnValue_Offset;

	private static bool GetEvaluationType_IsValid;

	private static IntPtr GetEvaluationType_FunctionAddress;

	private static int GetEvaluationType_ParamsSize;

	private static bool GetEvaluationType_InSequence_IsValid;

	private static FFieldAddress GetEvaluationType_InSequence_PropertyAddress;

	private static int GetEvaluationType_InSequence_Offset;

	private static bool GetEvaluationType_ReturnValue_IsValid;

	private static FFieldAddress GetEvaluationType_ReturnValue_PropertyAddress;

	private static int GetEvaluationType_ReturnValue_Offset;

	private static bool GetDisplayRate_IsValid;

	private static IntPtr GetDisplayRate_FunctionAddress;

	private static int GetDisplayRate_ParamsSize;

	private static bool GetDisplayRate_Sequence_IsValid;

	private static FFieldAddress GetDisplayRate_Sequence_PropertyAddress;

	private static int GetDisplayRate_Sequence_Offset;

	private static bool GetDisplayRate_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayRate_ReturnValue_PropertyAddress;

	private static int GetDisplayRate_ReturnValue_Offset;

	private static bool GetClockSource_IsValid;

	private static IntPtr GetClockSource_FunctionAddress;

	private static int GetClockSource_ParamsSize;

	private static bool GetClockSource_InSequence_IsValid;

	private static FFieldAddress GetClockSource_InSequence_PropertyAddress;

	private static int GetClockSource_InSequence_Offset;

	private static bool GetClockSource_ReturnValue_IsValid;

	private static FFieldAddress GetClockSource_ReturnValue_PropertyAddress;

	private static int GetClockSource_ReturnValue_Offset;

	private static bool GetBindings_IsValid;

	private static IntPtr GetBindings_FunctionAddress;

	private static int GetBindings_ParamsSize;

	private static bool GetBindings_Sequence_IsValid;

	private static FFieldAddress GetBindings_Sequence_PropertyAddress;

	private static int GetBindings_Sequence_Offset;

	private static bool GetBindings_ReturnValue_IsValid;

	private static FFieldAddress GetBindings_ReturnValue_PropertyAddress;

	private static int GetBindings_ReturnValue_Offset;

	private static bool GetBindingID_IsValid;

	private static IntPtr GetBindingID_FunctionAddress;

	private static int GetBindingID_ParamsSize;

	private static bool GetBindingID_InBinding_IsValid;

	private static FFieldAddress GetBindingID_InBinding_PropertyAddress;

	private static int GetBindingID_InBinding_Offset;

	private static bool GetBindingID_ReturnValue_IsValid;

	private static FFieldAddress GetBindingID_ReturnValue_PropertyAddress;

	private static int GetBindingID_ReturnValue_Offset;

	private static bool FindNextMarkedFrame_IsValid;

	private static IntPtr FindNextMarkedFrame_FunctionAddress;

	private static int FindNextMarkedFrame_ParamsSize;

	private static bool FindNextMarkedFrame_Sequence_IsValid;

	private static FFieldAddress FindNextMarkedFrame_Sequence_PropertyAddress;

	private static int FindNextMarkedFrame_Sequence_Offset;

	private static bool FindNextMarkedFrame_InFrameNumber_IsValid;

	private static FFieldAddress FindNextMarkedFrame_InFrameNumber_PropertyAddress;

	private static int FindNextMarkedFrame_InFrameNumber_Offset;

	private static bool FindNextMarkedFrame_bForward_IsValid;

	private static FFieldAddress FindNextMarkedFrame_bForward_PropertyAddress;

	private static int FindNextMarkedFrame_bForward_Offset;

	private static bool FindNextMarkedFrame_ReturnValue_IsValid;

	private static FFieldAddress FindNextMarkedFrame_ReturnValue_PropertyAddress;

	private static int FindNextMarkedFrame_ReturnValue_Offset;

	private static bool FindMasterTracksByType_IsValid;

	private static IntPtr FindMasterTracksByType_FunctionAddress;

	private static int FindMasterTracksByType_ParamsSize;

	private static bool FindMasterTracksByType_Sequence_IsValid;

	private static FFieldAddress FindMasterTracksByType_Sequence_PropertyAddress;

	private static int FindMasterTracksByType_Sequence_Offset;

	private static bool FindMasterTracksByType_TrackType_IsValid;

	private static FFieldAddress FindMasterTracksByType_TrackType_PropertyAddress;

	private static int FindMasterTracksByType_TrackType_Offset;

	private static bool FindMasterTracksByType_ReturnValue_IsValid;

	private static FFieldAddress FindMasterTracksByType_ReturnValue_PropertyAddress;

	private static int FindMasterTracksByType_ReturnValue_Offset;

	private static bool FindMasterTracksByExactType_IsValid;

	private static IntPtr FindMasterTracksByExactType_FunctionAddress;

	private static int FindMasterTracksByExactType_ParamsSize;

	private static bool FindMasterTracksByExactType_Sequence_IsValid;

	private static FFieldAddress FindMasterTracksByExactType_Sequence_PropertyAddress;

	private static int FindMasterTracksByExactType_Sequence_Offset;

	private static bool FindMasterTracksByExactType_TrackType_IsValid;

	private static FFieldAddress FindMasterTracksByExactType_TrackType_PropertyAddress;

	private static int FindMasterTracksByExactType_TrackType_Offset;

	private static bool FindMasterTracksByExactType_ReturnValue_IsValid;

	private static FFieldAddress FindMasterTracksByExactType_ReturnValue_PropertyAddress;

	private static int FindMasterTracksByExactType_ReturnValue_Offset;

	private static bool FindMarkedFrameByLabel_IsValid;

	private static IntPtr FindMarkedFrameByLabel_FunctionAddress;

	private static int FindMarkedFrameByLabel_ParamsSize;

	private static bool FindMarkedFrameByLabel_Sequence_IsValid;

	private static FFieldAddress FindMarkedFrameByLabel_Sequence_PropertyAddress;

	private static int FindMarkedFrameByLabel_Sequence_Offset;

	private static bool FindMarkedFrameByLabel_InLabel_IsValid;

	private static FFieldAddress FindMarkedFrameByLabel_InLabel_PropertyAddress;

	private static int FindMarkedFrameByLabel_InLabel_Offset;

	private static bool FindMarkedFrameByLabel_ReturnValue_IsValid;

	private static FFieldAddress FindMarkedFrameByLabel_ReturnValue_PropertyAddress;

	private static int FindMarkedFrameByLabel_ReturnValue_Offset;

	private static bool FindMarkedFrameByFrameNumber_IsValid;

	private static IntPtr FindMarkedFrameByFrameNumber_FunctionAddress;

	private static int FindMarkedFrameByFrameNumber_ParamsSize;

	private static bool FindMarkedFrameByFrameNumber_Sequence_IsValid;

	private static FFieldAddress FindMarkedFrameByFrameNumber_Sequence_PropertyAddress;

	private static int FindMarkedFrameByFrameNumber_Sequence_Offset;

	private static bool FindMarkedFrameByFrameNumber_InFrameNumber_IsValid;

	private static FFieldAddress FindMarkedFrameByFrameNumber_InFrameNumber_PropertyAddress;

	private static int FindMarkedFrameByFrameNumber_InFrameNumber_Offset;

	private static bool FindMarkedFrameByFrameNumber_ReturnValue_IsValid;

	private static FFieldAddress FindMarkedFrameByFrameNumber_ReturnValue_PropertyAddress;

	private static int FindMarkedFrameByFrameNumber_ReturnValue_Offset;

	private static bool FindBindingByName_IsValid;

	private static IntPtr FindBindingByName_FunctionAddress;

	private static int FindBindingByName_ParamsSize;

	private static bool FindBindingByName_Sequence_IsValid;

	private static FFieldAddress FindBindingByName_Sequence_PropertyAddress;

	private static int FindBindingByName_Sequence_Offset;

	private static bool FindBindingByName_Name_IsValid;

	private static FFieldAddress FindBindingByName_Name_PropertyAddress;

	private static int FindBindingByName_Name_Offset;

	private static bool FindBindingByName_ReturnValue_IsValid;

	private static FFieldAddress FindBindingByName_ReturnValue_PropertyAddress;

	private static int FindBindingByName_ReturnValue_Offset;

	private static bool FindBindingById_IsValid;

	private static IntPtr FindBindingById_FunctionAddress;

	private static int FindBindingById_ParamsSize;

	private static bool FindBindingById_Sequence_IsValid;

	private static FFieldAddress FindBindingById_Sequence_PropertyAddress;

	private static int FindBindingById_Sequence_Offset;

	private static bool FindBindingById_BindingId_IsValid;

	private static FFieldAddress FindBindingById_BindingId_PropertyAddress;

	private static int FindBindingById_BindingId_Offset;

	private static bool FindBindingById_ReturnValue_IsValid;

	private static FFieldAddress FindBindingById_ReturnValue_PropertyAddress;

	private static int FindBindingById_ReturnValue_Offset;

	private static bool DeleteMarkedFrames_IsValid;

	private static IntPtr DeleteMarkedFrames_FunctionAddress;

	private static int DeleteMarkedFrames_ParamsSize;

	private static bool DeleteMarkedFrames_Sequence_IsValid;

	private static FFieldAddress DeleteMarkedFrames_Sequence_PropertyAddress;

	private static int DeleteMarkedFrames_Sequence_Offset;

	private static bool DeleteMarkedFrame_IsValid;

	private static IntPtr DeleteMarkedFrame_FunctionAddress;

	private static int DeleteMarkedFrame_ParamsSize;

	private static bool DeleteMarkedFrame_Sequence_IsValid;

	private static FFieldAddress DeleteMarkedFrame_Sequence_PropertyAddress;

	private static int DeleteMarkedFrame_Sequence_Offset;

	private static bool DeleteMarkedFrame_DeleteIndex_IsValid;

	private static FFieldAddress DeleteMarkedFrame_DeleteIndex_PropertyAddress;

	private static int DeleteMarkedFrame_DeleteIndex_Offset;

	private static bool AddSpawnableFromInstance_IsValid;

	private static IntPtr AddSpawnableFromInstance_FunctionAddress;

	private static int AddSpawnableFromInstance_ParamsSize;

	private static bool AddSpawnableFromInstance_Sequence_IsValid;

	private static FFieldAddress AddSpawnableFromInstance_Sequence_PropertyAddress;

	private static int AddSpawnableFromInstance_Sequence_Offset;

	private static bool AddSpawnableFromInstance_ObjectToSpawn_IsValid;

	private static FFieldAddress AddSpawnableFromInstance_ObjectToSpawn_PropertyAddress;

	private static int AddSpawnableFromInstance_ObjectToSpawn_Offset;

	private static bool AddSpawnableFromInstance_ReturnValue_IsValid;

	private static FFieldAddress AddSpawnableFromInstance_ReturnValue_PropertyAddress;

	private static int AddSpawnableFromInstance_ReturnValue_Offset;

	private static bool AddSpawnableFromClass_IsValid;

	private static IntPtr AddSpawnableFromClass_FunctionAddress;

	private static int AddSpawnableFromClass_ParamsSize;

	private static bool AddSpawnableFromClass_Sequence_IsValid;

	private static FFieldAddress AddSpawnableFromClass_Sequence_PropertyAddress;

	private static int AddSpawnableFromClass_Sequence_Offset;

	private static bool AddSpawnableFromClass_ClassToSpawn_IsValid;

	private static FFieldAddress AddSpawnableFromClass_ClassToSpawn_PropertyAddress;

	private static int AddSpawnableFromClass_ClassToSpawn_Offset;

	private static bool AddSpawnableFromClass_ReturnValue_IsValid;

	private static FFieldAddress AddSpawnableFromClass_ReturnValue_PropertyAddress;

	private static int AddSpawnableFromClass_ReturnValue_Offset;

	private static bool AddRootFolderToSequence_IsValid;

	private static IntPtr AddRootFolderToSequence_FunctionAddress;

	private static int AddRootFolderToSequence_ParamsSize;

	private static bool AddRootFolderToSequence_Sequence_IsValid;

	private static FFieldAddress AddRootFolderToSequence_Sequence_PropertyAddress;

	private static int AddRootFolderToSequence_Sequence_Offset;

	private static bool AddRootFolderToSequence_NewFolderName_IsValid;

	private static FFieldAddress AddRootFolderToSequence_NewFolderName_PropertyAddress;

	private static int AddRootFolderToSequence_NewFolderName_Offset;

	private static bool AddRootFolderToSequence_ReturnValue_IsValid;

	private static FFieldAddress AddRootFolderToSequence_ReturnValue_PropertyAddress;

	private static int AddRootFolderToSequence_ReturnValue_Offset;

	private static bool AddPossessable_IsValid;

	private static IntPtr AddPossessable_FunctionAddress;

	private static int AddPossessable_ParamsSize;

	private static bool AddPossessable_Sequence_IsValid;

	private static FFieldAddress AddPossessable_Sequence_PropertyAddress;

	private static int AddPossessable_Sequence_Offset;

	private static bool AddPossessable_ObjectToPossess_IsValid;

	private static FFieldAddress AddPossessable_ObjectToPossess_PropertyAddress;

	private static int AddPossessable_ObjectToPossess_Offset;

	private static bool AddPossessable_ReturnValue_IsValid;

	private static FFieldAddress AddPossessable_ReturnValue_PropertyAddress;

	private static int AddPossessable_ReturnValue_Offset;

	private static bool AddMasterTrack_IsValid;

	private static IntPtr AddMasterTrack_FunctionAddress;

	private static int AddMasterTrack_ParamsSize;

	private static bool AddMasterTrack_Sequence_IsValid;

	private static FFieldAddress AddMasterTrack_Sequence_PropertyAddress;

	private static int AddMasterTrack_Sequence_Offset;

	private static bool AddMasterTrack_TrackType_IsValid;

	private static FFieldAddress AddMasterTrack_TrackType_PropertyAddress;

	private static int AddMasterTrack_TrackType_Offset;

	private static bool AddMasterTrack_ReturnValue_IsValid;

	private static FFieldAddress AddMasterTrack_ReturnValue_PropertyAddress;

	private static int AddMasterTrack_ReturnValue_Offset;

	private static bool AddMarkedFrame_IsValid;

	private static IntPtr AddMarkedFrame_FunctionAddress;

	private static int AddMarkedFrame_ParamsSize;

	private static bool AddMarkedFrame_Sequence_IsValid;

	private static FFieldAddress AddMarkedFrame_Sequence_PropertyAddress;

	private static int AddMarkedFrame_Sequence_Offset;

	private static bool AddMarkedFrame_InMarkedFrame_IsValid;

	private static FFieldAddress AddMarkedFrame_InMarkedFrame_PropertyAddress;

	private static int AddMarkedFrame_InMarkedFrame_Offset;

	private static bool AddMarkedFrame_ReturnValue_IsValid;

	private static FFieldAddress AddMarkedFrame_ReturnValue_PropertyAddress;

	private static int AddMarkedFrame_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SortMarkedFrames")]
	public unsafe static void SortMarkedFrames(UMovieSceneSequence Sequence)
	{
		if (!SortMarkedFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SortMarkedFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortMarkedFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortMarkedFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SortMarkedFrames_Sequence_Offset), 0, SortMarkedFrames_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SortMarkedFrames_FunctionAddress, intPtr, SortMarkedFrames_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeStart")]
	public unsafe static void SetWorkRangeStart(UMovieSceneSequence InSequence, float StartTimeInSeconds)
	{
		if (!SetWorkRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorkRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorkRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetWorkRangeStart_InSequence_Offset), 0, SetWorkRangeStart_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWorkRangeStart_StartTimeInSeconds_Offset), 0, SetWorkRangeStart_StartTimeInSeconds_PropertyAddress.Address, StartTimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWorkRangeStart_FunctionAddress, intPtr, SetWorkRangeStart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeEnd")]
	public unsafe static void SetWorkRangeEnd(UMovieSceneSequence InSequence, float EndTimeInSeconds)
	{
		if (!SetWorkRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorkRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorkRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetWorkRangeEnd_InSequence_Offset), 0, SetWorkRangeEnd_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWorkRangeEnd_EndTimeInSeconds_Offset), 0, SetWorkRangeEnd_EndTimeInSeconds_PropertyAddress.Address, EndTimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWorkRangeEnd_FunctionAddress, intPtr, SetWorkRangeEnd_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeStart")]
	public unsafe static void SetViewRangeStart(UMovieSceneSequence InSequence, float StartTimeInSeconds)
	{
		if (!SetViewRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetViewRangeStart_InSequence_Offset), 0, SetViewRangeStart_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewRangeStart_StartTimeInSeconds_Offset), 0, SetViewRangeStart_StartTimeInSeconds_PropertyAddress.Address, StartTimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewRangeStart_FunctionAddress, intPtr, SetViewRangeStart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeEnd")]
	public unsafe static void SetViewRangeEnd(UMovieSceneSequence InSequence, float EndTimeInSeconds)
	{
		if (!SetViewRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetViewRangeEnd_InSequence_Offset), 0, SetViewRangeEnd_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewRangeEnd_EndTimeInSeconds_Offset), 0, SetViewRangeEnd_EndTimeInSeconds_PropertyAddress.Address, EndTimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewRangeEnd_FunctionAddress, intPtr, SetViewRangeEnd_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolutionDirectly")]
	public unsafe static void SetTickResolutionDirectly(UMovieSceneSequence Sequence, FFrameRate TickResolution)
	{
		if (!SetTickResolutionDirectly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolutionDirectly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickResolutionDirectly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickResolutionDirectly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetTickResolutionDirectly_Sequence_Offset), 0, SetTickResolutionDirectly_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SetTickResolutionDirectly_TickResolution_Offset), 0, SetTickResolutionDirectly_TickResolution_PropertyAddress.Address, TickResolution);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTickResolutionDirectly_FunctionAddress, intPtr, SetTickResolutionDirectly_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolution")]
	public unsafe static void SetTickResolution(UMovieSceneSequence Sequence, FFrameRate TickResolution)
	{
		if (!SetTickResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetTickResolution_Sequence_Offset), 0, SetTickResolution_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SetTickResolution_TickResolution_Offset), 0, SetTickResolution_TickResolution_PropertyAddress.Address, TickResolution);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTickResolution_FunctionAddress, intPtr, SetTickResolution_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetReadOnly")]
	public unsafe static void SetReadOnly(UMovieSceneSequence Sequence, bool bInReadOnly)
	{
		if (!SetReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetReadOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetReadOnly_Sequence_Offset), 0, SetReadOnly_Sequence_PropertyAddress.Address, Sequence);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReadOnly_bInReadOnly_Offset), 0, SetReadOnly_bInReadOnly_PropertyAddress.Address, bInReadOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetReadOnly_FunctionAddress, intPtr, SetReadOnly_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStartSeconds")]
	public unsafe static void SetPlaybackStartSeconds(UMovieSceneSequence Sequence, float StartTime)
	{
		if (!SetPlaybackStartSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStartSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackStartSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackStartSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetPlaybackStartSeconds_Sequence_Offset), 0, SetPlaybackStartSeconds_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackStartSeconds_StartTime_Offset), 0, SetPlaybackStartSeconds_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlaybackStartSeconds_FunctionAddress, intPtr, SetPlaybackStartSeconds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStart")]
	public unsafe static void SetPlaybackStart(UMovieSceneSequence Sequence, int StartFrame)
	{
		if (!SetPlaybackStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetPlaybackStart_Sequence_Offset), 0, SetPlaybackStart_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPlaybackStart_StartFrame_Offset), 0, SetPlaybackStart_StartFrame_PropertyAddress.Address, StartFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlaybackStart_FunctionAddress, intPtr, SetPlaybackStart_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEndSeconds")]
	public unsafe static void SetPlaybackEndSeconds(UMovieSceneSequence Sequence, float EndTime)
	{
		if (!SetPlaybackEndSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEndSeconds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackEndSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackEndSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetPlaybackEndSeconds_Sequence_Offset), 0, SetPlaybackEndSeconds_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackEndSeconds_EndTime_Offset), 0, SetPlaybackEndSeconds_EndTime_PropertyAddress.Address, EndTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlaybackEndSeconds_FunctionAddress, intPtr, SetPlaybackEndSeconds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEnd")]
	public unsafe static void SetPlaybackEnd(UMovieSceneSequence Sequence, int EndFrame)
	{
		if (!SetPlaybackEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetPlaybackEnd_Sequence_Offset), 0, SetPlaybackEnd_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPlaybackEnd_EndFrame_Offset), 0, SetPlaybackEnd_EndFrame_PropertyAddress.Address, EndFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPlaybackEnd_FunctionAddress, intPtr, SetPlaybackEnd_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetMarkedFrame")]
	public unsafe static void SetMarkedFrame(UMovieSceneSequence Sequence, int InMarkIndex, FFrameNumber InFrameNumber)
	{
		if (!SetMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetMarkedFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMarkedFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMarkedFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetMarkedFrame_Sequence_Offset), 0, SetMarkedFrame_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMarkedFrame_InMarkIndex_Offset), 0, SetMarkedFrame_InMarkIndex_PropertyAddress.Address, InMarkIndex);
		NativeReflection.InitializeValue_InContainer(SetMarkedFrame_InFrameNumber_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, SetMarkedFrame_InFrameNumber_Offset), 0, SetMarkedFrame_InFrameNumber_PropertyAddress.Address, InFrameNumber);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMarkedFrame_FunctionAddress, intPtr, SetMarkedFrame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetEvaluationType")]
	public unsafe static void SetEvaluationType(UMovieSceneSequence InSequence, EMovieSceneEvaluationType InEvaluationType)
	{
		if (!SetEvaluationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetEvaluationType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEvaluationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEvaluationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetEvaluationType_InSequence_Offset), 0, SetEvaluationType_InSequence_PropertyAddress.Address, InSequence);
		EnumMarshaler<EMovieSceneEvaluationType>.ToNative(IntPtr.Add(intPtr, SetEvaluationType_InEvaluationType_Offset), 0, SetEvaluationType_InEvaluationType_PropertyAddress.Address, InEvaluationType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEvaluationType_FunctionAddress, intPtr, SetEvaluationType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetDisplayRate")]
	public unsafe static void SetDisplayRate(UMovieSceneSequence Sequence, FFrameRate DisplayRate)
	{
		if (!SetDisplayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetDisplayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetDisplayRate_Sequence_Offset), 0, SetDisplayRate_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SetDisplayRate_DisplayRate_Offset), 0, SetDisplayRate_DisplayRate_PropertyAddress.Address, DisplayRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDisplayRate_FunctionAddress, intPtr, SetDisplayRate_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetClockSource")]
	public unsafe static void SetClockSource(UMovieSceneSequence InSequence, EUpdateClockSource InClockSource)
	{
		if (!SetClockSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetClockSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClockSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClockSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetClockSource_InSequence_Offset), 0, SetClockSource_InSequence_PropertyAddress.Address, InSequence);
		EnumMarshaler<EUpdateClockSource>.ToNative(IntPtr.Add(intPtr, SetClockSource_InClockSource_Offset), 0, SetClockSource_InClockSource_PropertyAddress.Address, InClockSource);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetClockSource_FunctionAddress, intPtr, SetClockSource_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:ResolveBindingID")]
	public unsafe static FSequencerBindingProxy ResolveBindingID(UMovieSceneSequence MasterSequence, FMovieSceneObjectBindingID InObjectBindingID)
	{
		if (!ResolveBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:ResolveBindingID");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, ResolveBindingID_MasterSequence_Offset), 0, ResolveBindingID_MasterSequence_PropertyAddress.Address, MasterSequence);
		NativeReflection.InitializeValue_InContainer(ResolveBindingID_InObjectBindingID_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, ResolveBindingID_InObjectBindingID_Offset), 0, ResolveBindingID_InObjectBindingID_PropertyAddress.Address, InObjectBindingID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResolveBindingID_FunctionAddress, intPtr, ResolveBindingID_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, ResolveBindingID_ReturnValue_Offset), 0, ResolveBindingID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:RemoveMasterTrack")]
	public unsafe static bool RemoveMasterTrack(UMovieSceneSequence Sequence, UMovieSceneTrack MasterTrack)
	{
		if (!RemoveMasterTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:RemoveMasterTrack");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMasterTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMasterTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, RemoveMasterTrack_Sequence_Offset), 0, RemoveMasterTrack_Sequence_PropertyAddress.Address, Sequence);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, RemoveMasterTrack_MasterTrack_Offset), 0, RemoveMasterTrack_MasterTrack_PropertyAddress.Address, MasterTrack);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveMasterTrack_FunctionAddress, intPtr, RemoveMasterTrack_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMasterTrack_ReturnValue_Offset), 0, RemoveMasterTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRangeSeconds")]
	public unsafe static FSequencerScriptingRange MakeRangeSeconds(UMovieSceneSequence Sequence, float StartTime, float Duration)
	{
		if (!MakeRangeSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRangeSeconds");
			return default(FSequencerScriptingRange);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeRangeSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeRangeSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, MakeRangeSeconds_Sequence_Offset), 0, MakeRangeSeconds_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeRangeSeconds_StartTime_Offset), 0, MakeRangeSeconds_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeRangeSeconds_Duration_Offset), 0, MakeRangeSeconds_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeRangeSeconds_FunctionAddress, intPtr, MakeRangeSeconds_ParamsSize);
		return FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, MakeRangeSeconds_ReturnValue_Offset), 0, MakeRangeSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRange")]
	public unsafe static FSequencerScriptingRange MakeRange(UMovieSceneSequence Sequence, int StartFrame, int Duration)
	{
		if (!MakeRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRange");
			return default(FSequencerScriptingRange);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, MakeRange_Sequence_Offset), 0, MakeRange_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeRange_StartFrame_Offset), 0, MakeRange_StartFrame_PropertyAddress.Address, StartFrame);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeRange_Duration_Offset), 0, MakeRange_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeRange_FunctionAddress, intPtr, MakeRange_ParamsSize);
		return FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, MakeRange_ReturnValue_Offset), 0, MakeRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:LocateBoundObjects")]
	public unsafe static List<UObject> LocateBoundObjects(UMovieSceneSequence Sequence, FSequencerBindingProxy InBinding, UObject Context)
	{
		if (!LocateBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:LocateBoundObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocateBoundObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocateBoundObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, LocateBoundObjects_Sequence_Offset), 0, LocateBoundObjects_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InitializeValue_InContainer(LocateBoundObjects_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, LocateBoundObjects_InBinding_Offset), 0, LocateBoundObjects_InBinding_PropertyAddress.Address, InBinding);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LocateBoundObjects_Context_Offset), 0, LocateBoundObjects_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LocateBoundObjects_FunctionAddress, intPtr, LocateBoundObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, LocateBoundObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, LocateBoundObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(LocateBoundObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:IsReadOnly")]
	public unsafe static bool IsReadOnly(UMovieSceneSequence Sequence)
	{
		if (!IsReadOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:IsReadOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReadOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReadOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, IsReadOnly_Sequence_Offset), 0, IsReadOnly_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsReadOnly_FunctionAddress, intPtr, IsReadOnly_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReadOnly_ReturnValue_Offset), 0, IsReadOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeStart")]
	public unsafe static float GetWorkRangeStart(UMovieSceneSequence InSequence)
	{
		if (!GetWorkRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeStart");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorkRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorkRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetWorkRangeStart_InSequence_Offset), 0, GetWorkRangeStart_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorkRangeStart_FunctionAddress, intPtr, GetWorkRangeStart_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWorkRangeStart_ReturnValue_Offset), 0, GetWorkRangeStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeEnd")]
	public unsafe static float GetWorkRangeEnd(UMovieSceneSequence InSequence)
	{
		if (!GetWorkRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeEnd");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorkRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorkRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetWorkRangeEnd_InSequence_Offset), 0, GetWorkRangeEnd_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorkRangeEnd_FunctionAddress, intPtr, GetWorkRangeEnd_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWorkRangeEnd_ReturnValue_Offset), 0, GetWorkRangeEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeStart")]
	public unsafe static float GetViewRangeStart(UMovieSceneSequence InSequence)
	{
		if (!GetViewRangeStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeStart");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRangeStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRangeStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetViewRangeStart_InSequence_Offset), 0, GetViewRangeStart_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewRangeStart_FunctionAddress, intPtr, GetViewRangeStart_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewRangeStart_ReturnValue_Offset), 0, GetViewRangeStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeEnd")]
	public unsafe static float GetViewRangeEnd(UMovieSceneSequence InSequence)
	{
		if (!GetViewRangeEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeEnd");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRangeEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRangeEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetViewRangeEnd_InSequence_Offset), 0, GetViewRangeEnd_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewRangeEnd_FunctionAddress, intPtr, GetViewRangeEnd_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewRangeEnd_ReturnValue_Offset), 0, GetViewRangeEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetTickResolution")]
	public unsafe static FFrameRate GetTickResolution(UMovieSceneSequence Sequence)
	{
		if (!GetTickResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetTickResolution");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTickResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTickResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetTickResolution_Sequence_Offset), 0, GetTickResolution_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTickResolution_FunctionAddress, intPtr, GetTickResolution_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetTickResolution_ReturnValue_Offset), 0, GetTickResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetSpawnables")]
	public unsafe static List<FSequencerBindingProxy> GetSpawnables(UMovieSceneSequence Sequence)
	{
		if (!GetSpawnables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetSpawnables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpawnables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpawnables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetSpawnables_Sequence_Offset), 0, GetSpawnables_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSpawnables_FunctionAddress, intPtr, GetSpawnables_ParamsSize);
		List<FSequencerBindingProxy> result = new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetSpawnables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetSpawnables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSpawnables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetRootFoldersInSequence")]
	public unsafe static List<UMovieSceneFolder> GetRootFoldersInSequence(UMovieSceneSequence Sequence)
	{
		if (!GetRootFoldersInSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetRootFoldersInSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootFoldersInSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootFoldersInSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetRootFoldersInSequence_Sequence_Offset), 0, GetRootFoldersInSequence_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRootFoldersInSequence_FunctionAddress, intPtr, GetRootFoldersInSequence_ParamsSize);
		List<UMovieSceneFolder> result = new TArrayCopyMarshaler<UMovieSceneFolder>(1, GetRootFoldersInSequence_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.FromNative, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRootFoldersInSequence_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRootFoldersInSequence_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPossessables")]
	public unsafe static List<FSequencerBindingProxy> GetPossessables(UMovieSceneSequence Sequence)
	{
		if (!GetPossessables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPossessables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossessables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossessables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPossessables_Sequence_Offset), 0, GetPossessables_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPossessables_FunctionAddress, intPtr, GetPossessables_ParamsSize);
		List<FSequencerBindingProxy> result = new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetPossessables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetPossessables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPossessables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPortableBindingID")]
	public unsafe static FMovieSceneObjectBindingID GetPortableBindingID(UMovieSceneSequence MasterSequence, UMovieSceneSequence DestinationSequence, FSequencerBindingProxy InBinding)
	{
		if (!GetPortableBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPortableBindingID");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPortableBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPortableBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPortableBindingID_MasterSequence_Offset), 0, GetPortableBindingID_MasterSequence_PropertyAddress.Address, MasterSequence);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPortableBindingID_DestinationSequence_Offset), 0, GetPortableBindingID_DestinationSequence_PropertyAddress.Address, DestinationSequence);
		NativeReflection.InitializeValue_InContainer(GetPortableBindingID_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetPortableBindingID_InBinding_Offset), 0, GetPortableBindingID_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPortableBindingID_FunctionAddress, intPtr, GetPortableBindingID_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetPortableBindingID_ReturnValue_Offset), 0, GetPortableBindingID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStartSeconds")]
	public unsafe static float GetPlaybackStartSeconds(UMovieSceneSequence Sequence)
	{
		if (!GetPlaybackStartSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStartSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackStartSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackStartSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPlaybackStartSeconds_Sequence_Offset), 0, GetPlaybackStartSeconds_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlaybackStartSeconds_FunctionAddress, intPtr, GetPlaybackStartSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackStartSeconds_ReturnValue_Offset), 0, GetPlaybackStartSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStart")]
	public unsafe static int GetPlaybackStart(UMovieSceneSequence Sequence)
	{
		if (!GetPlaybackStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStart");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPlaybackStart_Sequence_Offset), 0, GetPlaybackStart_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlaybackStart_FunctionAddress, intPtr, GetPlaybackStart_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPlaybackStart_ReturnValue_Offset), 0, GetPlaybackStart_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackRange")]
	public unsafe static FSequencerScriptingRange GetPlaybackRange(UMovieSceneSequence Sequence)
	{
		if (!GetPlaybackRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackRange");
			return default(FSequencerScriptingRange);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPlaybackRange_Sequence_Offset), 0, GetPlaybackRange_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlaybackRange_FunctionAddress, intPtr, GetPlaybackRange_ParamsSize);
		return FSequencerScriptingRange.FromNative(IntPtr.Add(intPtr, GetPlaybackRange_ReturnValue_Offset), 0, GetPlaybackRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEndSeconds")]
	public unsafe static float GetPlaybackEndSeconds(UMovieSceneSequence Sequence)
	{
		if (!GetPlaybackEndSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEndSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackEndSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackEndSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPlaybackEndSeconds_Sequence_Offset), 0, GetPlaybackEndSeconds_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlaybackEndSeconds_FunctionAddress, intPtr, GetPlaybackEndSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlaybackEndSeconds_ReturnValue_Offset), 0, GetPlaybackEndSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEnd")]
	public unsafe static int GetPlaybackEnd(UMovieSceneSequence Sequence)
	{
		if (!GetPlaybackEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEnd");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaybackEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaybackEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetPlaybackEnd_Sequence_Offset), 0, GetPlaybackEnd_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlaybackEnd_FunctionAddress, intPtr, GetPlaybackEnd_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPlaybackEnd_ReturnValue_Offset), 0, GetPlaybackEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMovieScene")]
	public unsafe static UMovieScene GetMovieScene(UMovieSceneSequence Sequence)
	{
		if (!GetMovieScene_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMovieScene");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMovieScene_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMovieScene_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetMovieScene_Sequence_Offset), 0, GetMovieScene_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMovieScene_FunctionAddress, intPtr, GetMovieScene_ParamsSize);
		return UObjectMarshaler<UMovieScene>.FromNative(IntPtr.Add(intPtr, GetMovieScene_ReturnValue_Offset), 0, GetMovieScene_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMasterTracks")]
	public unsafe static List<UMovieSceneTrack> GetMasterTracks(UMovieSceneSequence Sequence)
	{
		if (!GetMasterTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMasterTracks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMasterTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMasterTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetMasterTracks_Sequence_Offset), 0, GetMasterTracks_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMasterTracks_FunctionAddress, intPtr, GetMasterTracks_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, GetMasterTracks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMasterTracks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMasterTracks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMarkedFrames")]
	public unsafe static List<FMovieSceneMarkedFrame> GetMarkedFrames(UMovieSceneSequence Sequence)
	{
		if (!GetMarkedFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMarkedFrames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMarkedFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMarkedFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetMarkedFrames_Sequence_Offset), 0, GetMarkedFrames_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMarkedFrames_FunctionAddress, intPtr, GetMarkedFrames_ParamsSize);
		List<FMovieSceneMarkedFrame> result = new TArrayCopyMarshaler<FMovieSceneMarkedFrame>(1, GetMarkedFrames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMovieSceneMarkedFrame, FMovieSceneMarkedFrame>.FromNative, CachedMarshalingDelegates<FMovieSceneMarkedFrame, FMovieSceneMarkedFrame>.ToNative).FromNative(IntPtr.Add(intPtr, GetMarkedFrames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMarkedFrames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetEvaluationType")]
	public unsafe static EMovieSceneEvaluationType GetEvaluationType(UMovieSceneSequence InSequence)
	{
		if (!GetEvaluationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetEvaluationType");
			return EMovieSceneEvaluationType.FrameLocked;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEvaluationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEvaluationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetEvaluationType_InSequence_Offset), 0, GetEvaluationType_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEvaluationType_FunctionAddress, intPtr, GetEvaluationType_ParamsSize);
		return EnumMarshaler<EMovieSceneEvaluationType>.FromNative(IntPtr.Add(intPtr, GetEvaluationType_ReturnValue_Offset), 0, GetEvaluationType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetDisplayRate")]
	public unsafe static FFrameRate GetDisplayRate(UMovieSceneSequence Sequence)
	{
		if (!GetDisplayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetDisplayRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetDisplayRate_Sequence_Offset), 0, GetDisplayRate_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayRate_FunctionAddress, intPtr, GetDisplayRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetDisplayRate_ReturnValue_Offset), 0, GetDisplayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetClockSource")]
	public unsafe static EUpdateClockSource GetClockSource(UMovieSceneSequence InSequence)
	{
		if (!GetClockSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetClockSource");
			return EUpdateClockSource.Tick;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClockSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClockSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetClockSource_InSequence_Offset), 0, GetClockSource_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetClockSource_FunctionAddress, intPtr, GetClockSource_ParamsSize);
		return EnumMarshaler<EUpdateClockSource>.FromNative(IntPtr.Add(intPtr, GetClockSource_ReturnValue_Offset), 0, GetClockSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindings")]
	public unsafe static List<FSequencerBindingProxy> GetBindings(UMovieSceneSequence Sequence)
	{
		if (!GetBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, GetBindings_Sequence_Offset), 0, GetBindings_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBindings_FunctionAddress, intPtr, GetBindings_ParamsSize);
		List<FSequencerBindingProxy> result = new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetBindings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetBindings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBindings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindingID")]
	public unsafe static FMovieSceneObjectBindingID GetBindingID(FSequencerBindingProxy InBinding)
	{
		if (!GetBindingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindingID");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBindingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBindingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBindingID_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetBindingID_InBinding_Offset), 0, GetBindingID_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBindingID_FunctionAddress, intPtr, GetBindingID_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetBindingID_ReturnValue_Offset), 0, GetBindingID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindNextMarkedFrame")]
	public unsafe static int FindNextMarkedFrame(UMovieSceneSequence Sequence, FFrameNumber InFrameNumber, bool bForward)
	{
		if (!FindNextMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindNextMarkedFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNextMarkedFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNextMarkedFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindNextMarkedFrame_Sequence_Offset), 0, FindNextMarkedFrame_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InitializeValue_InContainer(FindNextMarkedFrame_InFrameNumber_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, FindNextMarkedFrame_InFrameNumber_Offset), 0, FindNextMarkedFrame_InFrameNumber_PropertyAddress.Address, InFrameNumber);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindNextMarkedFrame_bForward_Offset), 0, FindNextMarkedFrame_bForward_PropertyAddress.Address, bForward);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindNextMarkedFrame_FunctionAddress, intPtr, FindNextMarkedFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindNextMarkedFrame_ReturnValue_Offset), 0, FindNextMarkedFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByType")]
	public unsafe static List<UMovieSceneTrack> FindMasterTracksByType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!FindMasterTracksByType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMasterTracksByType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMasterTracksByType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindMasterTracksByType_Sequence_Offset), 0, FindMasterTracksByType_Sequence_PropertyAddress.Address, Sequence);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, FindMasterTracksByType_TrackType_Offset), 0, FindMasterTracksByType_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindMasterTracksByType_FunctionAddress, intPtr, FindMasterTracksByType_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, FindMasterTracksByType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, FindMasterTracksByType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindMasterTracksByType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByExactType")]
	public unsafe static List<UMovieSceneTrack> FindMasterTracksByExactType(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!FindMasterTracksByExactType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByExactType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMasterTracksByExactType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMasterTracksByExactType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindMasterTracksByExactType_Sequence_Offset), 0, FindMasterTracksByExactType_Sequence_PropertyAddress.Address, Sequence);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, FindMasterTracksByExactType_TrackType_Offset), 0, FindMasterTracksByExactType_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindMasterTracksByExactType_FunctionAddress, intPtr, FindMasterTracksByExactType_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, FindMasterTracksByExactType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, FindMasterTracksByExactType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindMasterTracksByExactType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByLabel")]
	public unsafe static int FindMarkedFrameByLabel(UMovieSceneSequence Sequence, string InLabel)
	{
		if (!FindMarkedFrameByLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByLabel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMarkedFrameByLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMarkedFrameByLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindMarkedFrameByLabel_Sequence_Offset), 0, FindMarkedFrameByLabel_Sequence_PropertyAddress.Address, Sequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindMarkedFrameByLabel_InLabel_Offset), 0, FindMarkedFrameByLabel_InLabel_PropertyAddress.Address, InLabel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindMarkedFrameByLabel_FunctionAddress, intPtr, FindMarkedFrameByLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindMarkedFrameByLabel_InLabel_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindMarkedFrameByLabel_ReturnValue_Offset), 0, FindMarkedFrameByLabel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByFrameNumber")]
	public unsafe static int FindMarkedFrameByFrameNumber(UMovieSceneSequence Sequence, FFrameNumber InFrameNumber)
	{
		if (!FindMarkedFrameByFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByFrameNumber");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMarkedFrameByFrameNumber_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMarkedFrameByFrameNumber_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindMarkedFrameByFrameNumber_Sequence_Offset), 0, FindMarkedFrameByFrameNumber_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InitializeValue_InContainer(FindMarkedFrameByFrameNumber_InFrameNumber_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, FindMarkedFrameByFrameNumber_InFrameNumber_Offset), 0, FindMarkedFrameByFrameNumber_InFrameNumber_PropertyAddress.Address, InFrameNumber);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindMarkedFrameByFrameNumber_FunctionAddress, intPtr, FindMarkedFrameByFrameNumber_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindMarkedFrameByFrameNumber_ReturnValue_Offset), 0, FindMarkedFrameByFrameNumber_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingByName")]
	public unsafe static FSequencerBindingProxy FindBindingByName(UMovieSceneSequence Sequence, string Name)
	{
		if (!FindBindingByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingByName");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBindingByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBindingByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindBindingByName_Sequence_Offset), 0, FindBindingByName_Sequence_PropertyAddress.Address, Sequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindBindingByName_Name_Offset), 0, FindBindingByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindBindingByName_FunctionAddress, intPtr, FindBindingByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindBindingByName_Name_PropertyAddress.Address, intPtr);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, FindBindingByName_ReturnValue_Offset), 0, FindBindingByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingById")]
	public unsafe static FSequencerBindingProxy FindBindingById(UMovieSceneSequence Sequence, Guid BindingId)
	{
		if (!FindBindingById_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingById");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBindingById_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBindingById_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, FindBindingById_Sequence_Offset), 0, FindBindingById_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(intPtr, FindBindingById_BindingId_Offset), 0, FindBindingById_BindingId_PropertyAddress.Address, BindingId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindBindingById_FunctionAddress, intPtr, FindBindingById_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, FindBindingById_ReturnValue_Offset), 0, FindBindingById_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrames")]
	public unsafe static void DeleteMarkedFrames(UMovieSceneSequence Sequence)
	{
		if (!DeleteMarkedFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteMarkedFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteMarkedFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, DeleteMarkedFrames_Sequence_Offset), 0, DeleteMarkedFrames_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteMarkedFrames_FunctionAddress, intPtr, DeleteMarkedFrames_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrame")]
	public unsafe static void DeleteMarkedFrame(UMovieSceneSequence Sequence, int DeleteIndex)
	{
		if (!DeleteMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteMarkedFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteMarkedFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, DeleteMarkedFrame_Sequence_Offset), 0, DeleteMarkedFrame_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DeleteMarkedFrame_DeleteIndex_Offset), 0, DeleteMarkedFrame_DeleteIndex_PropertyAddress.Address, DeleteIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteMarkedFrame_FunctionAddress, intPtr, DeleteMarkedFrame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromInstance")]
	public unsafe static FSequencerBindingProxy AddSpawnableFromInstance(UMovieSceneSequence Sequence, UObject ObjectToSpawn)
	{
		if (!AddSpawnableFromInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromInstance");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSpawnableFromInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSpawnableFromInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddSpawnableFromInstance_Sequence_Offset), 0, AddSpawnableFromInstance_Sequence_PropertyAddress.Address, Sequence);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddSpawnableFromInstance_ObjectToSpawn_Offset), 0, AddSpawnableFromInstance_ObjectToSpawn_PropertyAddress.Address, ObjectToSpawn);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSpawnableFromInstance_FunctionAddress, intPtr, AddSpawnableFromInstance_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, AddSpawnableFromInstance_ReturnValue_Offset), 0, AddSpawnableFromInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromClass")]
	public unsafe static FSequencerBindingProxy AddSpawnableFromClass(UMovieSceneSequence Sequence, TSubclassOf<UObject> ClassToSpawn)
	{
		if (!AddSpawnableFromClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromClass");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSpawnableFromClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSpawnableFromClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddSpawnableFromClass_Sequence_Offset), 0, AddSpawnableFromClass_Sequence_PropertyAddress.Address, Sequence);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddSpawnableFromClass_ClassToSpawn_Offset), 0, AddSpawnableFromClass_ClassToSpawn_PropertyAddress.Address, ClassToSpawn);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSpawnableFromClass_FunctionAddress, intPtr, AddSpawnableFromClass_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, AddSpawnableFromClass_ReturnValue_Offset), 0, AddSpawnableFromClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddRootFolderToSequence")]
	public unsafe static UMovieSceneFolder AddRootFolderToSequence(UMovieSceneSequence Sequence, string NewFolderName)
	{
		if (!AddRootFolderToSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddRootFolderToSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRootFolderToSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRootFolderToSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddRootFolderToSequence_Sequence_Offset), 0, AddRootFolderToSequence_Sequence_PropertyAddress.Address, Sequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRootFolderToSequence_NewFolderName_Offset), 0, AddRootFolderToSequence_NewFolderName_PropertyAddress.Address, NewFolderName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddRootFolderToSequence_FunctionAddress, intPtr, AddRootFolderToSequence_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddRootFolderToSequence_NewFolderName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMovieSceneFolder>.FromNative(IntPtr.Add(intPtr, AddRootFolderToSequence_ReturnValue_Offset), 0, AddRootFolderToSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddPossessable")]
	public unsafe static FSequencerBindingProxy AddPossessable(UMovieSceneSequence Sequence, UObject ObjectToPossess)
	{
		if (!AddPossessable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddPossessable");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPossessable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPossessable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddPossessable_Sequence_Offset), 0, AddPossessable_Sequence_PropertyAddress.Address, Sequence);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddPossessable_ObjectToPossess_Offset), 0, AddPossessable_ObjectToPossess_PropertyAddress.Address, ObjectToPossess);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPossessable_FunctionAddress, intPtr, AddPossessable_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, AddPossessable_ReturnValue_Offset), 0, AddPossessable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMasterTrack")]
	public unsafe static UMovieSceneTrack AddMasterTrack(UMovieSceneSequence Sequence, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!AddMasterTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMasterTrack");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMasterTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMasterTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddMasterTrack_Sequence_Offset), 0, AddMasterTrack_Sequence_PropertyAddress.Address, Sequence);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, AddMasterTrack_TrackType_Offset), 0, AddMasterTrack_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMasterTrack_FunctionAddress, intPtr, AddMasterTrack_ParamsSize);
		return UObjectMarshaler<UMovieSceneTrack>.FromNative(IntPtr.Add(intPtr, AddMasterTrack_ReturnValue_Offset), 0, AddMasterTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMarkedFrame")]
	public unsafe static int AddMarkedFrame(UMovieSceneSequence Sequence, FMovieSceneMarkedFrame InMarkedFrame)
	{
		if (!AddMarkedFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMarkedFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMarkedFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMarkedFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, AddMarkedFrame_Sequence_Offset), 0, AddMarkedFrame_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InitializeValue_InContainer(AddMarkedFrame_InMarkedFrame_PropertyAddress.Address, intPtr);
		FMovieSceneMarkedFrame.ToNative(IntPtr.Add(intPtr, AddMarkedFrame_InMarkedFrame_Offset), 0, AddMarkedFrame_InMarkedFrame_PropertyAddress.Address, InMarkedFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMarkedFrame_FunctionAddress, intPtr, AddMarkedFrame_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMarkedFrame_InMarkedFrame_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddMarkedFrame_ReturnValue_Offset), 0, AddMarkedFrame_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneSequenceExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSequenceExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSequenceExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneSequenceExtensions");
		SortMarkedFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SortMarkedFrames");
		SortMarkedFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(SortMarkedFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortMarkedFrames_Sequence_PropertyAddress, SortMarkedFrames_FunctionAddress, "Sequence");
		SortMarkedFrames_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SortMarkedFrames_FunctionAddress, "Sequence");
		SortMarkedFrames_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SortMarkedFrames_FunctionAddress, "Sequence", Classes.FObjectProperty);
		SortMarkedFrames_IsValid = SortMarkedFrames_FunctionAddress != IntPtr.Zero && SortMarkedFrames_Sequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SortMarkedFrames", SortMarkedFrames_IsValid);
		SetWorkRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWorkRangeStart");
		SetWorkRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorkRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorkRangeStart_InSequence_PropertyAddress, SetWorkRangeStart_FunctionAddress, "InSequence");
		SetWorkRangeStart_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetWorkRangeStart_FunctionAddress, "InSequence");
		SetWorkRangeStart_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorkRangeStart_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorkRangeStart_StartTimeInSeconds_PropertyAddress, SetWorkRangeStart_FunctionAddress, "StartTimeInSeconds");
		SetWorkRangeStart_StartTimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SetWorkRangeStart_FunctionAddress, "StartTimeInSeconds");
		SetWorkRangeStart_StartTimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorkRangeStart_FunctionAddress, "StartTimeInSeconds", Classes.FFloatProperty);
		SetWorkRangeStart_IsValid = SetWorkRangeStart_FunctionAddress != IntPtr.Zero && SetWorkRangeStart_InSequence_IsValid && SetWorkRangeStart_StartTimeInSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeStart", SetWorkRangeStart_IsValid);
		SetWorkRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWorkRangeEnd");
		SetWorkRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorkRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorkRangeEnd_InSequence_PropertyAddress, SetWorkRangeEnd_FunctionAddress, "InSequence");
		SetWorkRangeEnd_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetWorkRangeEnd_FunctionAddress, "InSequence");
		SetWorkRangeEnd_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorkRangeEnd_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorkRangeEnd_EndTimeInSeconds_PropertyAddress, SetWorkRangeEnd_FunctionAddress, "EndTimeInSeconds");
		SetWorkRangeEnd_EndTimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SetWorkRangeEnd_FunctionAddress, "EndTimeInSeconds");
		SetWorkRangeEnd_EndTimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorkRangeEnd_FunctionAddress, "EndTimeInSeconds", Classes.FFloatProperty);
		SetWorkRangeEnd_IsValid = SetWorkRangeEnd_FunctionAddress != IntPtr.Zero && SetWorkRangeEnd_InSequence_IsValid && SetWorkRangeEnd_EndTimeInSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetWorkRangeEnd", SetWorkRangeEnd_IsValid);
		SetViewRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewRangeStart");
		SetViewRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRangeStart_InSequence_PropertyAddress, SetViewRangeStart_FunctionAddress, "InSequence");
		SetViewRangeStart_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRangeStart_FunctionAddress, "InSequence");
		SetViewRangeStart_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRangeStart_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewRangeStart_StartTimeInSeconds_PropertyAddress, SetViewRangeStart_FunctionAddress, "StartTimeInSeconds");
		SetViewRangeStart_StartTimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRangeStart_FunctionAddress, "StartTimeInSeconds");
		SetViewRangeStart_StartTimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRangeStart_FunctionAddress, "StartTimeInSeconds", Classes.FFloatProperty);
		SetViewRangeStart_IsValid = SetViewRangeStart_FunctionAddress != IntPtr.Zero && SetViewRangeStart_InSequence_IsValid && SetViewRangeStart_StartTimeInSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeStart", SetViewRangeStart_IsValid);
		SetViewRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewRangeEnd");
		SetViewRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRangeEnd_InSequence_PropertyAddress, SetViewRangeEnd_FunctionAddress, "InSequence");
		SetViewRangeEnd_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRangeEnd_FunctionAddress, "InSequence");
		SetViewRangeEnd_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRangeEnd_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewRangeEnd_EndTimeInSeconds_PropertyAddress, SetViewRangeEnd_FunctionAddress, "EndTimeInSeconds");
		SetViewRangeEnd_EndTimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRangeEnd_FunctionAddress, "EndTimeInSeconds");
		SetViewRangeEnd_EndTimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRangeEnd_FunctionAddress, "EndTimeInSeconds", Classes.FFloatProperty);
		SetViewRangeEnd_IsValid = SetViewRangeEnd_FunctionAddress != IntPtr.Zero && SetViewRangeEnd_InSequence_IsValid && SetViewRangeEnd_EndTimeInSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetViewRangeEnd", SetViewRangeEnd_IsValid);
		SetTickResolutionDirectly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTickResolutionDirectly");
		SetTickResolutionDirectly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickResolutionDirectly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickResolutionDirectly_Sequence_PropertyAddress, SetTickResolutionDirectly_FunctionAddress, "Sequence");
		SetTickResolutionDirectly_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetTickResolutionDirectly_FunctionAddress, "Sequence");
		SetTickResolutionDirectly_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickResolutionDirectly_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTickResolutionDirectly_TickResolution_PropertyAddress, SetTickResolutionDirectly_FunctionAddress, "TickResolution");
		SetTickResolutionDirectly_TickResolution_Offset = NativeReflectionCached.GetPropertyOffset(SetTickResolutionDirectly_FunctionAddress, "TickResolution");
		SetTickResolutionDirectly_TickResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickResolutionDirectly_FunctionAddress, "TickResolution", Classes.FStructProperty);
		SetTickResolutionDirectly_IsValid = SetTickResolutionDirectly_FunctionAddress != IntPtr.Zero && SetTickResolutionDirectly_Sequence_IsValid && SetTickResolutionDirectly_TickResolution_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolutionDirectly", SetTickResolutionDirectly_IsValid);
		SetTickResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTickResolution");
		SetTickResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickResolution_Sequence_PropertyAddress, SetTickResolution_FunctionAddress, "Sequence");
		SetTickResolution_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetTickResolution_FunctionAddress, "Sequence");
		SetTickResolution_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickResolution_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTickResolution_TickResolution_PropertyAddress, SetTickResolution_FunctionAddress, "TickResolution");
		SetTickResolution_TickResolution_Offset = NativeReflectionCached.GetPropertyOffset(SetTickResolution_FunctionAddress, "TickResolution");
		SetTickResolution_TickResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickResolution_FunctionAddress, "TickResolution", Classes.FStructProperty);
		SetTickResolution_IsValid = SetTickResolution_FunctionAddress != IntPtr.Zero && SetTickResolution_Sequence_IsValid && SetTickResolution_TickResolution_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetTickResolution", SetTickResolution_IsValid);
		SetReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetReadOnly");
		SetReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReadOnly_Sequence_PropertyAddress, SetReadOnly_FunctionAddress, "Sequence");
		SetReadOnly_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetReadOnly_FunctionAddress, "Sequence");
		SetReadOnly_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReadOnly_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetReadOnly_bInReadOnly_PropertyAddress, SetReadOnly_FunctionAddress, "bInReadOnly");
		SetReadOnly_bInReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetReadOnly_FunctionAddress, "bInReadOnly");
		SetReadOnly_bInReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReadOnly_FunctionAddress, "bInReadOnly", Classes.FBoolProperty);
		SetReadOnly_IsValid = SetReadOnly_FunctionAddress != IntPtr.Zero && SetReadOnly_Sequence_IsValid && SetReadOnly_bInReadOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetReadOnly", SetReadOnly_IsValid);
		SetPlaybackStartSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlaybackStartSeconds");
		SetPlaybackStartSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackStartSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackStartSeconds_Sequence_PropertyAddress, SetPlaybackStartSeconds_FunctionAddress, "Sequence");
		SetPlaybackStartSeconds_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackStartSeconds_FunctionAddress, "Sequence");
		SetPlaybackStartSeconds_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackStartSeconds_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackStartSeconds_StartTime_PropertyAddress, SetPlaybackStartSeconds_FunctionAddress, "StartTime");
		SetPlaybackStartSeconds_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackStartSeconds_FunctionAddress, "StartTime");
		SetPlaybackStartSeconds_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackStartSeconds_FunctionAddress, "StartTime", Classes.FFloatProperty);
		SetPlaybackStartSeconds_IsValid = SetPlaybackStartSeconds_FunctionAddress != IntPtr.Zero && SetPlaybackStartSeconds_Sequence_IsValid && SetPlaybackStartSeconds_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStartSeconds", SetPlaybackStartSeconds_IsValid);
		SetPlaybackStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlaybackStart");
		SetPlaybackStart_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackStart_Sequence_PropertyAddress, SetPlaybackStart_FunctionAddress, "Sequence");
		SetPlaybackStart_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackStart_FunctionAddress, "Sequence");
		SetPlaybackStart_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackStart_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackStart_StartFrame_PropertyAddress, SetPlaybackStart_FunctionAddress, "StartFrame");
		SetPlaybackStart_StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackStart_FunctionAddress, "StartFrame");
		SetPlaybackStart_StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackStart_FunctionAddress, "StartFrame", Classes.FIntProperty);
		SetPlaybackStart_IsValid = SetPlaybackStart_FunctionAddress != IntPtr.Zero && SetPlaybackStart_Sequence_IsValid && SetPlaybackStart_StartFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackStart", SetPlaybackStart_IsValid);
		SetPlaybackEndSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlaybackEndSeconds");
		SetPlaybackEndSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackEndSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackEndSeconds_Sequence_PropertyAddress, SetPlaybackEndSeconds_FunctionAddress, "Sequence");
		SetPlaybackEndSeconds_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackEndSeconds_FunctionAddress, "Sequence");
		SetPlaybackEndSeconds_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackEndSeconds_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackEndSeconds_EndTime_PropertyAddress, SetPlaybackEndSeconds_FunctionAddress, "EndTime");
		SetPlaybackEndSeconds_EndTime_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackEndSeconds_FunctionAddress, "EndTime");
		SetPlaybackEndSeconds_EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackEndSeconds_FunctionAddress, "EndTime", Classes.FFloatProperty);
		SetPlaybackEndSeconds_IsValid = SetPlaybackEndSeconds_FunctionAddress != IntPtr.Zero && SetPlaybackEndSeconds_Sequence_IsValid && SetPlaybackEndSeconds_EndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEndSeconds", SetPlaybackEndSeconds_IsValid);
		SetPlaybackEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPlaybackEnd");
		SetPlaybackEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackEnd_Sequence_PropertyAddress, SetPlaybackEnd_FunctionAddress, "Sequence");
		SetPlaybackEnd_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackEnd_FunctionAddress, "Sequence");
		SetPlaybackEnd_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackEnd_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackEnd_EndFrame_PropertyAddress, SetPlaybackEnd_FunctionAddress, "EndFrame");
		SetPlaybackEnd_EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackEnd_FunctionAddress, "EndFrame");
		SetPlaybackEnd_EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackEnd_FunctionAddress, "EndFrame", Classes.FIntProperty);
		SetPlaybackEnd_IsValid = SetPlaybackEnd_FunctionAddress != IntPtr.Zero && SetPlaybackEnd_Sequence_IsValid && SetPlaybackEnd_EndFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetPlaybackEnd", SetPlaybackEnd_IsValid);
		SetMarkedFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMarkedFrame");
		SetMarkedFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMarkedFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMarkedFrame_Sequence_PropertyAddress, SetMarkedFrame_FunctionAddress, "Sequence");
		SetMarkedFrame_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetMarkedFrame_FunctionAddress, "Sequence");
		SetMarkedFrame_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMarkedFrame_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMarkedFrame_InMarkIndex_PropertyAddress, SetMarkedFrame_FunctionAddress, "InMarkIndex");
		SetMarkedFrame_InMarkIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMarkedFrame_FunctionAddress, "InMarkIndex");
		SetMarkedFrame_InMarkIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMarkedFrame_FunctionAddress, "InMarkIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMarkedFrame_InFrameNumber_PropertyAddress, SetMarkedFrame_FunctionAddress, "InFrameNumber");
		SetMarkedFrame_InFrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(SetMarkedFrame_FunctionAddress, "InFrameNumber");
		SetMarkedFrame_InFrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMarkedFrame_FunctionAddress, "InFrameNumber", Classes.FStructProperty);
		SetMarkedFrame_IsValid = SetMarkedFrame_FunctionAddress != IntPtr.Zero && SetMarkedFrame_Sequence_IsValid && SetMarkedFrame_InMarkIndex_IsValid && SetMarkedFrame_InFrameNumber_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetMarkedFrame", SetMarkedFrame_IsValid);
		SetEvaluationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEvaluationType");
		SetEvaluationType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEvaluationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEvaluationType_InSequence_PropertyAddress, SetEvaluationType_FunctionAddress, "InSequence");
		SetEvaluationType_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetEvaluationType_FunctionAddress, "InSequence");
		SetEvaluationType_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEvaluationType_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEvaluationType_InEvaluationType_PropertyAddress, SetEvaluationType_FunctionAddress, "InEvaluationType");
		SetEvaluationType_InEvaluationType_Offset = NativeReflectionCached.GetPropertyOffset(SetEvaluationType_FunctionAddress, "InEvaluationType");
		SetEvaluationType_InEvaluationType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEvaluationType_FunctionAddress, "InEvaluationType", Classes.FEnumProperty);
		SetEvaluationType_IsValid = SetEvaluationType_FunctionAddress != IntPtr.Zero && SetEvaluationType_InSequence_IsValid && SetEvaluationType_InEvaluationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetEvaluationType", SetEvaluationType_IsValid);
		SetDisplayRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDisplayRate");
		SetDisplayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayRate_Sequence_PropertyAddress, SetDisplayRate_FunctionAddress, "Sequence");
		SetDisplayRate_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayRate_FunctionAddress, "Sequence");
		SetDisplayRate_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayRate_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayRate_DisplayRate_PropertyAddress, SetDisplayRate_FunctionAddress, "DisplayRate");
		SetDisplayRate_DisplayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayRate_FunctionAddress, "DisplayRate");
		SetDisplayRate_DisplayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayRate_FunctionAddress, "DisplayRate", Classes.FStructProperty);
		SetDisplayRate_IsValid = SetDisplayRate_FunctionAddress != IntPtr.Zero && SetDisplayRate_Sequence_IsValid && SetDisplayRate_DisplayRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetDisplayRate", SetDisplayRate_IsValid);
		SetClockSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetClockSource");
		SetClockSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClockSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClockSource_InSequence_PropertyAddress, SetClockSource_FunctionAddress, "InSequence");
		SetClockSource_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetClockSource_FunctionAddress, "InSequence");
		SetClockSource_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClockSource_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetClockSource_InClockSource_PropertyAddress, SetClockSource_FunctionAddress, "InClockSource");
		SetClockSource_InClockSource_Offset = NativeReflectionCached.GetPropertyOffset(SetClockSource_FunctionAddress, "InClockSource");
		SetClockSource_InClockSource_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClockSource_FunctionAddress, "InClockSource", Classes.FEnumProperty);
		SetClockSource_IsValid = SetClockSource_FunctionAddress != IntPtr.Zero && SetClockSource_InSequence_IsValid && SetClockSource_InClockSource_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:SetClockSource", SetClockSource_IsValid);
		ResolveBindingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResolveBindingID");
		ResolveBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveBindingID_MasterSequence_PropertyAddress, ResolveBindingID_FunctionAddress, "MasterSequence");
		ResolveBindingID_MasterSequence_Offset = NativeReflectionCached.GetPropertyOffset(ResolveBindingID_FunctionAddress, "MasterSequence");
		ResolveBindingID_MasterSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveBindingID_FunctionAddress, "MasterSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveBindingID_InObjectBindingID_PropertyAddress, ResolveBindingID_FunctionAddress, "InObjectBindingID");
		ResolveBindingID_InObjectBindingID_Offset = NativeReflectionCached.GetPropertyOffset(ResolveBindingID_FunctionAddress, "InObjectBindingID");
		ResolveBindingID_InObjectBindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveBindingID_FunctionAddress, "InObjectBindingID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveBindingID_ReturnValue_PropertyAddress, ResolveBindingID_FunctionAddress, "ReturnValue");
		ResolveBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResolveBindingID_FunctionAddress, "ReturnValue");
		ResolveBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ResolveBindingID_IsValid = ResolveBindingID_FunctionAddress != IntPtr.Zero && ResolveBindingID_MasterSequence_IsValid && ResolveBindingID_InObjectBindingID_IsValid && ResolveBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:ResolveBindingID", ResolveBindingID_IsValid);
		RemoveMasterTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMasterTrack");
		RemoveMasterTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMasterTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMasterTrack_Sequence_PropertyAddress, RemoveMasterTrack_FunctionAddress, "Sequence");
		RemoveMasterTrack_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMasterTrack_FunctionAddress, "Sequence");
		RemoveMasterTrack_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMasterTrack_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMasterTrack_MasterTrack_PropertyAddress, RemoveMasterTrack_FunctionAddress, "MasterTrack");
		RemoveMasterTrack_MasterTrack_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMasterTrack_FunctionAddress, "MasterTrack");
		RemoveMasterTrack_MasterTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMasterTrack_FunctionAddress, "MasterTrack", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMasterTrack_ReturnValue_PropertyAddress, RemoveMasterTrack_FunctionAddress, "ReturnValue");
		RemoveMasterTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMasterTrack_FunctionAddress, "ReturnValue");
		RemoveMasterTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMasterTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMasterTrack_IsValid = RemoveMasterTrack_FunctionAddress != IntPtr.Zero && RemoveMasterTrack_Sequence_IsValid && RemoveMasterTrack_MasterTrack_IsValid && RemoveMasterTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:RemoveMasterTrack", RemoveMasterTrack_IsValid);
		MakeRangeSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeRangeSeconds");
		MakeRangeSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeRangeSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeRangeSeconds_Sequence_PropertyAddress, MakeRangeSeconds_FunctionAddress, "Sequence");
		MakeRangeSeconds_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(MakeRangeSeconds_FunctionAddress, "Sequence");
		MakeRangeSeconds_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRangeSeconds_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRangeSeconds_StartTime_PropertyAddress, MakeRangeSeconds_FunctionAddress, "StartTime");
		MakeRangeSeconds_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(MakeRangeSeconds_FunctionAddress, "StartTime");
		MakeRangeSeconds_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRangeSeconds_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRangeSeconds_Duration_PropertyAddress, MakeRangeSeconds_FunctionAddress, "Duration");
		MakeRangeSeconds_Duration_Offset = NativeReflectionCached.GetPropertyOffset(MakeRangeSeconds_FunctionAddress, "Duration");
		MakeRangeSeconds_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRangeSeconds_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRangeSeconds_ReturnValue_PropertyAddress, MakeRangeSeconds_FunctionAddress, "ReturnValue");
		MakeRangeSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeRangeSeconds_FunctionAddress, "ReturnValue");
		MakeRangeSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRangeSeconds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeRangeSeconds_IsValid = MakeRangeSeconds_FunctionAddress != IntPtr.Zero && MakeRangeSeconds_Sequence_IsValid && MakeRangeSeconds_StartTime_IsValid && MakeRangeSeconds_Duration_IsValid && MakeRangeSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRangeSeconds", MakeRangeSeconds_IsValid);
		MakeRange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeRange");
		MakeRange_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeRange_Sequence_PropertyAddress, MakeRange_FunctionAddress, "Sequence");
		MakeRange_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(MakeRange_FunctionAddress, "Sequence");
		MakeRange_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRange_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRange_StartFrame_PropertyAddress, MakeRange_FunctionAddress, "StartFrame");
		MakeRange_StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(MakeRange_FunctionAddress, "StartFrame");
		MakeRange_StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRange_FunctionAddress, "StartFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRange_Duration_PropertyAddress, MakeRange_FunctionAddress, "Duration");
		MakeRange_Duration_Offset = NativeReflectionCached.GetPropertyOffset(MakeRange_FunctionAddress, "Duration");
		MakeRange_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRange_FunctionAddress, "Duration", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRange_ReturnValue_PropertyAddress, MakeRange_FunctionAddress, "ReturnValue");
		MakeRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeRange_FunctionAddress, "ReturnValue");
		MakeRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRange_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeRange_IsValid = MakeRange_FunctionAddress != IntPtr.Zero && MakeRange_Sequence_IsValid && MakeRange_StartFrame_IsValid && MakeRange_Duration_IsValid && MakeRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:MakeRange", MakeRange_IsValid);
		LocateBoundObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LocateBoundObjects");
		LocateBoundObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(LocateBoundObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocateBoundObjects_Sequence_PropertyAddress, LocateBoundObjects_FunctionAddress, "Sequence");
		LocateBoundObjects_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(LocateBoundObjects_FunctionAddress, "Sequence");
		LocateBoundObjects_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(LocateBoundObjects_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocateBoundObjects_InBinding_PropertyAddress, LocateBoundObjects_FunctionAddress, "InBinding");
		LocateBoundObjects_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(LocateBoundObjects_FunctionAddress, "InBinding");
		LocateBoundObjects_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(LocateBoundObjects_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocateBoundObjects_Context_PropertyAddress, LocateBoundObjects_FunctionAddress, "Context");
		LocateBoundObjects_Context_Offset = NativeReflectionCached.GetPropertyOffset(LocateBoundObjects_FunctionAddress, "Context");
		LocateBoundObjects_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(LocateBoundObjects_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocateBoundObjects_ReturnValue_PropertyAddress, LocateBoundObjects_FunctionAddress, "ReturnValue");
		LocateBoundObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocateBoundObjects_FunctionAddress, "ReturnValue");
		LocateBoundObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocateBoundObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		LocateBoundObjects_IsValid = LocateBoundObjects_FunctionAddress != IntPtr.Zero && LocateBoundObjects_Sequence_IsValid && LocateBoundObjects_InBinding_IsValid && LocateBoundObjects_Context_IsValid && LocateBoundObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:LocateBoundObjects", LocateBoundObjects_IsValid);
		IsReadOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsReadOnly");
		IsReadOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReadOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReadOnly_Sequence_PropertyAddress, IsReadOnly_FunctionAddress, "Sequence");
		IsReadOnly_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(IsReadOnly_FunctionAddress, "Sequence");
		IsReadOnly_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReadOnly_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReadOnly_ReturnValue_PropertyAddress, IsReadOnly_FunctionAddress, "ReturnValue");
		IsReadOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReadOnly_FunctionAddress, "ReturnValue");
		IsReadOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReadOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReadOnly_IsValid = IsReadOnly_FunctionAddress != IntPtr.Zero && IsReadOnly_Sequence_IsValid && IsReadOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:IsReadOnly", IsReadOnly_IsValid);
		GetWorkRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorkRangeStart");
		GetWorkRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorkRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorkRangeStart_InSequence_PropertyAddress, GetWorkRangeStart_FunctionAddress, "InSequence");
		GetWorkRangeStart_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetWorkRangeStart_FunctionAddress, "InSequence");
		GetWorkRangeStart_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorkRangeStart_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorkRangeStart_ReturnValue_PropertyAddress, GetWorkRangeStart_FunctionAddress, "ReturnValue");
		GetWorkRangeStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorkRangeStart_FunctionAddress, "ReturnValue");
		GetWorkRangeStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorkRangeStart_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWorkRangeStart_IsValid = GetWorkRangeStart_FunctionAddress != IntPtr.Zero && GetWorkRangeStart_InSequence_IsValid && GetWorkRangeStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeStart", GetWorkRangeStart_IsValid);
		GetWorkRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorkRangeEnd");
		GetWorkRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorkRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorkRangeEnd_InSequence_PropertyAddress, GetWorkRangeEnd_FunctionAddress, "InSequence");
		GetWorkRangeEnd_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetWorkRangeEnd_FunctionAddress, "InSequence");
		GetWorkRangeEnd_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorkRangeEnd_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorkRangeEnd_ReturnValue_PropertyAddress, GetWorkRangeEnd_FunctionAddress, "ReturnValue");
		GetWorkRangeEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorkRangeEnd_FunctionAddress, "ReturnValue");
		GetWorkRangeEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorkRangeEnd_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWorkRangeEnd_IsValid = GetWorkRangeEnd_FunctionAddress != IntPtr.Zero && GetWorkRangeEnd_InSequence_IsValid && GetWorkRangeEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetWorkRangeEnd", GetWorkRangeEnd_IsValid);
		GetViewRangeStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewRangeStart");
		GetViewRangeStart_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRangeStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeStart_InSequence_PropertyAddress, GetViewRangeStart_FunctionAddress, "InSequence");
		GetViewRangeStart_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeStart_FunctionAddress, "InSequence");
		GetViewRangeStart_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeStart_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeStart_ReturnValue_PropertyAddress, GetViewRangeStart_FunctionAddress, "ReturnValue");
		GetViewRangeStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeStart_FunctionAddress, "ReturnValue");
		GetViewRangeStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeStart_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewRangeStart_IsValid = GetViewRangeStart_FunctionAddress != IntPtr.Zero && GetViewRangeStart_InSequence_IsValid && GetViewRangeStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeStart", GetViewRangeStart_IsValid);
		GetViewRangeEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewRangeEnd");
		GetViewRangeEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRangeEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeEnd_InSequence_PropertyAddress, GetViewRangeEnd_FunctionAddress, "InSequence");
		GetViewRangeEnd_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeEnd_FunctionAddress, "InSequence");
		GetViewRangeEnd_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeEnd_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewRangeEnd_ReturnValue_PropertyAddress, GetViewRangeEnd_FunctionAddress, "ReturnValue");
		GetViewRangeEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRangeEnd_FunctionAddress, "ReturnValue");
		GetViewRangeEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRangeEnd_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewRangeEnd_IsValid = GetViewRangeEnd_FunctionAddress != IntPtr.Zero && GetViewRangeEnd_InSequence_IsValid && GetViewRangeEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetViewRangeEnd", GetViewRangeEnd_IsValid);
		GetTickResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTickResolution");
		GetTickResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTickResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTickResolution_Sequence_PropertyAddress, GetTickResolution_FunctionAddress, "Sequence");
		GetTickResolution_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetTickResolution_FunctionAddress, "Sequence");
		GetTickResolution_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickResolution_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTickResolution_ReturnValue_PropertyAddress, GetTickResolution_FunctionAddress, "ReturnValue");
		GetTickResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTickResolution_FunctionAddress, "ReturnValue");
		GetTickResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTickResolution_IsValid = GetTickResolution_FunctionAddress != IntPtr.Zero && GetTickResolution_Sequence_IsValid && GetTickResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetTickResolution", GetTickResolution_IsValid);
		GetSpawnables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSpawnables");
		GetSpawnables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpawnables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnables_Sequence_PropertyAddress, GetSpawnables_FunctionAddress, "Sequence");
		GetSpawnables_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnables_FunctionAddress, "Sequence");
		GetSpawnables_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnables_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnables_ReturnValue_PropertyAddress, GetSpawnables_FunctionAddress, "ReturnValue");
		GetSpawnables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnables_FunctionAddress, "ReturnValue");
		GetSpawnables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSpawnables_IsValid = GetSpawnables_FunctionAddress != IntPtr.Zero && GetSpawnables_Sequence_IsValid && GetSpawnables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetSpawnables", GetSpawnables_IsValid);
		GetRootFoldersInSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRootFoldersInSequence");
		GetRootFoldersInSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootFoldersInSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootFoldersInSequence_Sequence_PropertyAddress, GetRootFoldersInSequence_FunctionAddress, "Sequence");
		GetRootFoldersInSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetRootFoldersInSequence_FunctionAddress, "Sequence");
		GetRootFoldersInSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootFoldersInSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRootFoldersInSequence_ReturnValue_PropertyAddress, GetRootFoldersInSequence_FunctionAddress, "ReturnValue");
		GetRootFoldersInSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootFoldersInSequence_FunctionAddress, "ReturnValue");
		GetRootFoldersInSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootFoldersInSequence_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetRootFoldersInSequence_IsValid = GetRootFoldersInSequence_FunctionAddress != IntPtr.Zero && GetRootFoldersInSequence_Sequence_IsValid && GetRootFoldersInSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetRootFoldersInSequence", GetRootFoldersInSequence_IsValid);
		GetPossessables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPossessables");
		GetPossessables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossessables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPossessables_Sequence_PropertyAddress, GetPossessables_FunctionAddress, "Sequence");
		GetPossessables_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPossessables_FunctionAddress, "Sequence");
		GetPossessables_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossessables_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossessables_ReturnValue_PropertyAddress, GetPossessables_FunctionAddress, "ReturnValue");
		GetPossessables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPossessables_FunctionAddress, "ReturnValue");
		GetPossessables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossessables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPossessables_IsValid = GetPossessables_FunctionAddress != IntPtr.Zero && GetPossessables_Sequence_IsValid && GetPossessables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPossessables", GetPossessables_IsValid);
		GetPortableBindingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPortableBindingID");
		GetPortableBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPortableBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPortableBindingID_MasterSequence_PropertyAddress, GetPortableBindingID_FunctionAddress, "MasterSequence");
		GetPortableBindingID_MasterSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPortableBindingID_FunctionAddress, "MasterSequence");
		GetPortableBindingID_MasterSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPortableBindingID_FunctionAddress, "MasterSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPortableBindingID_DestinationSequence_PropertyAddress, GetPortableBindingID_FunctionAddress, "DestinationSequence");
		GetPortableBindingID_DestinationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPortableBindingID_FunctionAddress, "DestinationSequence");
		GetPortableBindingID_DestinationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPortableBindingID_FunctionAddress, "DestinationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPortableBindingID_InBinding_PropertyAddress, GetPortableBindingID_FunctionAddress, "InBinding");
		GetPortableBindingID_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetPortableBindingID_FunctionAddress, "InBinding");
		GetPortableBindingID_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPortableBindingID_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPortableBindingID_ReturnValue_PropertyAddress, GetPortableBindingID_FunctionAddress, "ReturnValue");
		GetPortableBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPortableBindingID_FunctionAddress, "ReturnValue");
		GetPortableBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPortableBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPortableBindingID_IsValid = GetPortableBindingID_FunctionAddress != IntPtr.Zero && GetPortableBindingID_MasterSequence_IsValid && GetPortableBindingID_DestinationSequence_IsValid && GetPortableBindingID_InBinding_IsValid && GetPortableBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPortableBindingID", GetPortableBindingID_IsValid);
		GetPlaybackStartSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackStartSeconds");
		GetPlaybackStartSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackStartSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackStartSeconds_Sequence_PropertyAddress, GetPlaybackStartSeconds_FunctionAddress, "Sequence");
		GetPlaybackStartSeconds_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackStartSeconds_FunctionAddress, "Sequence");
		GetPlaybackStartSeconds_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackStartSeconds_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackStartSeconds_ReturnValue_PropertyAddress, GetPlaybackStartSeconds_FunctionAddress, "ReturnValue");
		GetPlaybackStartSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackStartSeconds_FunctionAddress, "ReturnValue");
		GetPlaybackStartSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackStartSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackStartSeconds_IsValid = GetPlaybackStartSeconds_FunctionAddress != IntPtr.Zero && GetPlaybackStartSeconds_Sequence_IsValid && GetPlaybackStartSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStartSeconds", GetPlaybackStartSeconds_IsValid);
		GetPlaybackStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackStart");
		GetPlaybackStart_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackStart_Sequence_PropertyAddress, GetPlaybackStart_FunctionAddress, "Sequence");
		GetPlaybackStart_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackStart_FunctionAddress, "Sequence");
		GetPlaybackStart_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackStart_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackStart_ReturnValue_PropertyAddress, GetPlaybackStart_FunctionAddress, "ReturnValue");
		GetPlaybackStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackStart_FunctionAddress, "ReturnValue");
		GetPlaybackStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackStart_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPlaybackStart_IsValid = GetPlaybackStart_FunctionAddress != IntPtr.Zero && GetPlaybackStart_Sequence_IsValid && GetPlaybackStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackStart", GetPlaybackStart_IsValid);
		GetPlaybackRange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackRange");
		GetPlaybackRange_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackRange_Sequence_PropertyAddress, GetPlaybackRange_FunctionAddress, "Sequence");
		GetPlaybackRange_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackRange_FunctionAddress, "Sequence");
		GetPlaybackRange_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackRange_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackRange_ReturnValue_PropertyAddress, GetPlaybackRange_FunctionAddress, "ReturnValue");
		GetPlaybackRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackRange_FunctionAddress, "ReturnValue");
		GetPlaybackRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackRange_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlaybackRange_IsValid = GetPlaybackRange_FunctionAddress != IntPtr.Zero && GetPlaybackRange_Sequence_IsValid && GetPlaybackRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackRange", GetPlaybackRange_IsValid);
		GetPlaybackEndSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackEndSeconds");
		GetPlaybackEndSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackEndSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackEndSeconds_Sequence_PropertyAddress, GetPlaybackEndSeconds_FunctionAddress, "Sequence");
		GetPlaybackEndSeconds_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackEndSeconds_FunctionAddress, "Sequence");
		GetPlaybackEndSeconds_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackEndSeconds_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackEndSeconds_ReturnValue_PropertyAddress, GetPlaybackEndSeconds_FunctionAddress, "ReturnValue");
		GetPlaybackEndSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackEndSeconds_FunctionAddress, "ReturnValue");
		GetPlaybackEndSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackEndSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlaybackEndSeconds_IsValid = GetPlaybackEndSeconds_FunctionAddress != IntPtr.Zero && GetPlaybackEndSeconds_Sequence_IsValid && GetPlaybackEndSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEndSeconds", GetPlaybackEndSeconds_IsValid);
		GetPlaybackEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlaybackEnd");
		GetPlaybackEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaybackEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackEnd_Sequence_PropertyAddress, GetPlaybackEnd_FunctionAddress, "Sequence");
		GetPlaybackEnd_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackEnd_FunctionAddress, "Sequence");
		GetPlaybackEnd_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackEnd_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlaybackEnd_ReturnValue_PropertyAddress, GetPlaybackEnd_FunctionAddress, "ReturnValue");
		GetPlaybackEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaybackEnd_FunctionAddress, "ReturnValue");
		GetPlaybackEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaybackEnd_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPlaybackEnd_IsValid = GetPlaybackEnd_FunctionAddress != IntPtr.Zero && GetPlaybackEnd_Sequence_IsValid && GetPlaybackEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetPlaybackEnd", GetPlaybackEnd_IsValid);
		GetMovieScene_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMovieScene");
		GetMovieScene_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMovieScene_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMovieScene_Sequence_PropertyAddress, GetMovieScene_FunctionAddress, "Sequence");
		GetMovieScene_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetMovieScene_FunctionAddress, "Sequence");
		GetMovieScene_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovieScene_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMovieScene_ReturnValue_PropertyAddress, GetMovieScene_FunctionAddress, "ReturnValue");
		GetMovieScene_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMovieScene_FunctionAddress, "ReturnValue");
		GetMovieScene_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovieScene_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMovieScene_IsValid = GetMovieScene_FunctionAddress != IntPtr.Zero && GetMovieScene_Sequence_IsValid && GetMovieScene_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMovieScene", GetMovieScene_IsValid);
		GetMasterTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMasterTracks");
		GetMasterTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMasterTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMasterTracks_Sequence_PropertyAddress, GetMasterTracks_FunctionAddress, "Sequence");
		GetMasterTracks_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterTracks_FunctionAddress, "Sequence");
		GetMasterTracks_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterTracks_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMasterTracks_ReturnValue_PropertyAddress, GetMasterTracks_FunctionAddress, "ReturnValue");
		GetMasterTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMasterTracks_FunctionAddress, "ReturnValue");
		GetMasterTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMasterTracks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMasterTracks_IsValid = GetMasterTracks_FunctionAddress != IntPtr.Zero && GetMasterTracks_Sequence_IsValid && GetMasterTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMasterTracks", GetMasterTracks_IsValid);
		GetMarkedFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMarkedFrames");
		GetMarkedFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMarkedFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMarkedFrames_Sequence_PropertyAddress, GetMarkedFrames_FunctionAddress, "Sequence");
		GetMarkedFrames_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetMarkedFrames_FunctionAddress, "Sequence");
		GetMarkedFrames_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMarkedFrames_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMarkedFrames_ReturnValue_PropertyAddress, GetMarkedFrames_FunctionAddress, "ReturnValue");
		GetMarkedFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMarkedFrames_FunctionAddress, "ReturnValue");
		GetMarkedFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMarkedFrames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMarkedFrames_IsValid = GetMarkedFrames_FunctionAddress != IntPtr.Zero && GetMarkedFrames_Sequence_IsValid && GetMarkedFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetMarkedFrames", GetMarkedFrames_IsValid);
		GetEvaluationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEvaluationType");
		GetEvaluationType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEvaluationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEvaluationType_InSequence_PropertyAddress, GetEvaluationType_FunctionAddress, "InSequence");
		GetEvaluationType_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetEvaluationType_FunctionAddress, "InSequence");
		GetEvaluationType_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEvaluationType_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEvaluationType_ReturnValue_PropertyAddress, GetEvaluationType_FunctionAddress, "ReturnValue");
		GetEvaluationType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEvaluationType_FunctionAddress, "ReturnValue");
		GetEvaluationType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEvaluationType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetEvaluationType_IsValid = GetEvaluationType_FunctionAddress != IntPtr.Zero && GetEvaluationType_InSequence_IsValid && GetEvaluationType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetEvaluationType", GetEvaluationType_IsValid);
		GetDisplayRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayRate");
		GetDisplayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayRate_Sequence_PropertyAddress, GetDisplayRate_FunctionAddress, "Sequence");
		GetDisplayRate_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayRate_FunctionAddress, "Sequence");
		GetDisplayRate_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayRate_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayRate_ReturnValue_PropertyAddress, GetDisplayRate_FunctionAddress, "ReturnValue");
		GetDisplayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayRate_FunctionAddress, "ReturnValue");
		GetDisplayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDisplayRate_IsValid = GetDisplayRate_FunctionAddress != IntPtr.Zero && GetDisplayRate_Sequence_IsValid && GetDisplayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetDisplayRate", GetDisplayRate_IsValid);
		GetClockSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetClockSource");
		GetClockSource_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClockSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClockSource_InSequence_PropertyAddress, GetClockSource_FunctionAddress, "InSequence");
		GetClockSource_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetClockSource_FunctionAddress, "InSequence");
		GetClockSource_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClockSource_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClockSource_ReturnValue_PropertyAddress, GetClockSource_FunctionAddress, "ReturnValue");
		GetClockSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClockSource_FunctionAddress, "ReturnValue");
		GetClockSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClockSource_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetClockSource_IsValid = GetClockSource_FunctionAddress != IntPtr.Zero && GetClockSource_InSequence_IsValid && GetClockSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetClockSource", GetClockSource_IsValid);
		GetBindings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBindings");
		GetBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBindings_Sequence_PropertyAddress, GetBindings_FunctionAddress, "Sequence");
		GetBindings_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(GetBindings_FunctionAddress, "Sequence");
		GetBindings_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindings_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBindings_ReturnValue_PropertyAddress, GetBindings_FunctionAddress, "ReturnValue");
		GetBindings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBindings_FunctionAddress, "ReturnValue");
		GetBindings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBindings_IsValid = GetBindings_FunctionAddress != IntPtr.Zero && GetBindings_Sequence_IsValid && GetBindings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindings", GetBindings_IsValid);
		GetBindingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBindingID");
		GetBindingID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBindingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBindingID_InBinding_PropertyAddress, GetBindingID_FunctionAddress, "InBinding");
		GetBindingID_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBindingID_FunctionAddress, "InBinding");
		GetBindingID_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindingID_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBindingID_ReturnValue_PropertyAddress, GetBindingID_FunctionAddress, "ReturnValue");
		GetBindingID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBindingID_FunctionAddress, "ReturnValue");
		GetBindingID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindingID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBindingID_IsValid = GetBindingID_FunctionAddress != IntPtr.Zero && GetBindingID_InBinding_IsValid && GetBindingID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:GetBindingID", GetBindingID_IsValid);
		FindNextMarkedFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNextMarkedFrame");
		FindNextMarkedFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNextMarkedFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNextMarkedFrame_Sequence_PropertyAddress, FindNextMarkedFrame_FunctionAddress, "Sequence");
		FindNextMarkedFrame_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindNextMarkedFrame_FunctionAddress, "Sequence");
		FindNextMarkedFrame_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNextMarkedFrame_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNextMarkedFrame_InFrameNumber_PropertyAddress, FindNextMarkedFrame_FunctionAddress, "InFrameNumber");
		FindNextMarkedFrame_InFrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(FindNextMarkedFrame_FunctionAddress, "InFrameNumber");
		FindNextMarkedFrame_InFrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNextMarkedFrame_FunctionAddress, "InFrameNumber", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNextMarkedFrame_bForward_PropertyAddress, FindNextMarkedFrame_FunctionAddress, "bForward");
		FindNextMarkedFrame_bForward_Offset = NativeReflectionCached.GetPropertyOffset(FindNextMarkedFrame_FunctionAddress, "bForward");
		FindNextMarkedFrame_bForward_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNextMarkedFrame_FunctionAddress, "bForward", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNextMarkedFrame_ReturnValue_PropertyAddress, FindNextMarkedFrame_FunctionAddress, "ReturnValue");
		FindNextMarkedFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNextMarkedFrame_FunctionAddress, "ReturnValue");
		FindNextMarkedFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNextMarkedFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindNextMarkedFrame_IsValid = FindNextMarkedFrame_FunctionAddress != IntPtr.Zero && FindNextMarkedFrame_Sequence_IsValid && FindNextMarkedFrame_InFrameNumber_IsValid && FindNextMarkedFrame_bForward_IsValid && FindNextMarkedFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindNextMarkedFrame", FindNextMarkedFrame_IsValid);
		FindMasterTracksByType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindMasterTracksByType");
		FindMasterTracksByType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMasterTracksByType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByType_Sequence_PropertyAddress, FindMasterTracksByType_FunctionAddress, "Sequence");
		FindMasterTracksByType_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByType_FunctionAddress, "Sequence");
		FindMasterTracksByType_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByType_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByType_TrackType_PropertyAddress, FindMasterTracksByType_FunctionAddress, "TrackType");
		FindMasterTracksByType_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByType_FunctionAddress, "TrackType");
		FindMasterTracksByType_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByType_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByType_ReturnValue_PropertyAddress, FindMasterTracksByType_FunctionAddress, "ReturnValue");
		FindMasterTracksByType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByType_FunctionAddress, "ReturnValue");
		FindMasterTracksByType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindMasterTracksByType_IsValid = FindMasterTracksByType_FunctionAddress != IntPtr.Zero && FindMasterTracksByType_Sequence_IsValid && FindMasterTracksByType_TrackType_IsValid && FindMasterTracksByType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByType", FindMasterTracksByType_IsValid);
		FindMasterTracksByExactType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindMasterTracksByExactType");
		FindMasterTracksByExactType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMasterTracksByExactType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByExactType_Sequence_PropertyAddress, FindMasterTracksByExactType_FunctionAddress, "Sequence");
		FindMasterTracksByExactType_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByExactType_FunctionAddress, "Sequence");
		FindMasterTracksByExactType_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByExactType_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByExactType_TrackType_PropertyAddress, FindMasterTracksByExactType_FunctionAddress, "TrackType");
		FindMasterTracksByExactType_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByExactType_FunctionAddress, "TrackType");
		FindMasterTracksByExactType_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByExactType_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMasterTracksByExactType_ReturnValue_PropertyAddress, FindMasterTracksByExactType_FunctionAddress, "ReturnValue");
		FindMasterTracksByExactType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMasterTracksByExactType_FunctionAddress, "ReturnValue");
		FindMasterTracksByExactType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMasterTracksByExactType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindMasterTracksByExactType_IsValid = FindMasterTracksByExactType_FunctionAddress != IntPtr.Zero && FindMasterTracksByExactType_Sequence_IsValid && FindMasterTracksByExactType_TrackType_IsValid && FindMasterTracksByExactType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMasterTracksByExactType", FindMasterTracksByExactType_IsValid);
		FindMarkedFrameByLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindMarkedFrameByLabel");
		FindMarkedFrameByLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMarkedFrameByLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByLabel_Sequence_PropertyAddress, FindMarkedFrameByLabel_FunctionAddress, "Sequence");
		FindMarkedFrameByLabel_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByLabel_FunctionAddress, "Sequence");
		FindMarkedFrameByLabel_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByLabel_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByLabel_InLabel_PropertyAddress, FindMarkedFrameByLabel_FunctionAddress, "InLabel");
		FindMarkedFrameByLabel_InLabel_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByLabel_FunctionAddress, "InLabel");
		FindMarkedFrameByLabel_InLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByLabel_FunctionAddress, "InLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByLabel_ReturnValue_PropertyAddress, FindMarkedFrameByLabel_FunctionAddress, "ReturnValue");
		FindMarkedFrameByLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByLabel_FunctionAddress, "ReturnValue");
		FindMarkedFrameByLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByLabel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindMarkedFrameByLabel_IsValid = FindMarkedFrameByLabel_FunctionAddress != IntPtr.Zero && FindMarkedFrameByLabel_Sequence_IsValid && FindMarkedFrameByLabel_InLabel_IsValid && FindMarkedFrameByLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByLabel", FindMarkedFrameByLabel_IsValid);
		FindMarkedFrameByFrameNumber_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindMarkedFrameByFrameNumber");
		FindMarkedFrameByFrameNumber_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMarkedFrameByFrameNumber_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByFrameNumber_Sequence_PropertyAddress, FindMarkedFrameByFrameNumber_FunctionAddress, "Sequence");
		FindMarkedFrameByFrameNumber_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByFrameNumber_FunctionAddress, "Sequence");
		FindMarkedFrameByFrameNumber_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByFrameNumber_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByFrameNumber_InFrameNumber_PropertyAddress, FindMarkedFrameByFrameNumber_FunctionAddress, "InFrameNumber");
		FindMarkedFrameByFrameNumber_InFrameNumber_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByFrameNumber_FunctionAddress, "InFrameNumber");
		FindMarkedFrameByFrameNumber_InFrameNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByFrameNumber_FunctionAddress, "InFrameNumber", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMarkedFrameByFrameNumber_ReturnValue_PropertyAddress, FindMarkedFrameByFrameNumber_FunctionAddress, "ReturnValue");
		FindMarkedFrameByFrameNumber_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMarkedFrameByFrameNumber_FunctionAddress, "ReturnValue");
		FindMarkedFrameByFrameNumber_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMarkedFrameByFrameNumber_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindMarkedFrameByFrameNumber_IsValid = FindMarkedFrameByFrameNumber_FunctionAddress != IntPtr.Zero && FindMarkedFrameByFrameNumber_Sequence_IsValid && FindMarkedFrameByFrameNumber_InFrameNumber_IsValid && FindMarkedFrameByFrameNumber_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindMarkedFrameByFrameNumber", FindMarkedFrameByFrameNumber_IsValid);
		FindBindingByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindBindingByName");
		FindBindingByName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBindingByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBindingByName_Sequence_PropertyAddress, FindBindingByName_FunctionAddress, "Sequence");
		FindBindingByName_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingByName_FunctionAddress, "Sequence");
		FindBindingByName_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingByName_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingByName_Name_PropertyAddress, FindBindingByName_FunctionAddress, "Name");
		FindBindingByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingByName_FunctionAddress, "Name");
		FindBindingByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingByName_ReturnValue_PropertyAddress, FindBindingByName_FunctionAddress, "ReturnValue");
		FindBindingByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingByName_FunctionAddress, "ReturnValue");
		FindBindingByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindBindingByName_IsValid = FindBindingByName_FunctionAddress != IntPtr.Zero && FindBindingByName_Sequence_IsValid && FindBindingByName_Name_IsValid && FindBindingByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingByName", FindBindingByName_IsValid);
		FindBindingById_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindBindingById");
		FindBindingById_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBindingById_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBindingById_Sequence_PropertyAddress, FindBindingById_FunctionAddress, "Sequence");
		FindBindingById_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingById_FunctionAddress, "Sequence");
		FindBindingById_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingById_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingById_BindingId_PropertyAddress, FindBindingById_FunctionAddress, "BindingId");
		FindBindingById_BindingId_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingById_FunctionAddress, "BindingId");
		FindBindingById_BindingId_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingById_FunctionAddress, "BindingId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBindingById_ReturnValue_PropertyAddress, FindBindingById_FunctionAddress, "ReturnValue");
		FindBindingById_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBindingById_FunctionAddress, "ReturnValue");
		FindBindingById_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBindingById_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindBindingById_IsValid = FindBindingById_FunctionAddress != IntPtr.Zero && FindBindingById_Sequence_IsValid && FindBindingById_BindingId_IsValid && FindBindingById_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:FindBindingById", FindBindingById_IsValid);
		DeleteMarkedFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteMarkedFrames");
		DeleteMarkedFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteMarkedFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteMarkedFrames_Sequence_PropertyAddress, DeleteMarkedFrames_FunctionAddress, "Sequence");
		DeleteMarkedFrames_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(DeleteMarkedFrames_FunctionAddress, "Sequence");
		DeleteMarkedFrames_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteMarkedFrames_FunctionAddress, "Sequence", Classes.FObjectProperty);
		DeleteMarkedFrames_IsValid = DeleteMarkedFrames_FunctionAddress != IntPtr.Zero && DeleteMarkedFrames_Sequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrames", DeleteMarkedFrames_IsValid);
		DeleteMarkedFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteMarkedFrame");
		DeleteMarkedFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteMarkedFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteMarkedFrame_Sequence_PropertyAddress, DeleteMarkedFrame_FunctionAddress, "Sequence");
		DeleteMarkedFrame_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(DeleteMarkedFrame_FunctionAddress, "Sequence");
		DeleteMarkedFrame_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteMarkedFrame_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteMarkedFrame_DeleteIndex_PropertyAddress, DeleteMarkedFrame_FunctionAddress, "DeleteIndex");
		DeleteMarkedFrame_DeleteIndex_Offset = NativeReflectionCached.GetPropertyOffset(DeleteMarkedFrame_FunctionAddress, "DeleteIndex");
		DeleteMarkedFrame_DeleteIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteMarkedFrame_FunctionAddress, "DeleteIndex", Classes.FIntProperty);
		DeleteMarkedFrame_IsValid = DeleteMarkedFrame_FunctionAddress != IntPtr.Zero && DeleteMarkedFrame_Sequence_IsValid && DeleteMarkedFrame_DeleteIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:DeleteMarkedFrame", DeleteMarkedFrame_IsValid);
		AddSpawnableFromInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSpawnableFromInstance");
		AddSpawnableFromInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSpawnableFromInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromInstance_Sequence_PropertyAddress, AddSpawnableFromInstance_FunctionAddress, "Sequence");
		AddSpawnableFromInstance_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromInstance_FunctionAddress, "Sequence");
		AddSpawnableFromInstance_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromInstance_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromInstance_ObjectToSpawn_PropertyAddress, AddSpawnableFromInstance_FunctionAddress, "ObjectToSpawn");
		AddSpawnableFromInstance_ObjectToSpawn_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromInstance_FunctionAddress, "ObjectToSpawn");
		AddSpawnableFromInstance_ObjectToSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromInstance_FunctionAddress, "ObjectToSpawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromInstance_ReturnValue_PropertyAddress, AddSpawnableFromInstance_FunctionAddress, "ReturnValue");
		AddSpawnableFromInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromInstance_FunctionAddress, "ReturnValue");
		AddSpawnableFromInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromInstance_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddSpawnableFromInstance_IsValid = AddSpawnableFromInstance_FunctionAddress != IntPtr.Zero && AddSpawnableFromInstance_Sequence_IsValid && AddSpawnableFromInstance_ObjectToSpawn_IsValid && AddSpawnableFromInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromInstance", AddSpawnableFromInstance_IsValid);
		AddSpawnableFromClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSpawnableFromClass");
		AddSpawnableFromClass_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSpawnableFromClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromClass_Sequence_PropertyAddress, AddSpawnableFromClass_FunctionAddress, "Sequence");
		AddSpawnableFromClass_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromClass_FunctionAddress, "Sequence");
		AddSpawnableFromClass_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromClass_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromClass_ClassToSpawn_PropertyAddress, AddSpawnableFromClass_FunctionAddress, "ClassToSpawn");
		AddSpawnableFromClass_ClassToSpawn_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromClass_FunctionAddress, "ClassToSpawn");
		AddSpawnableFromClass_ClassToSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromClass_FunctionAddress, "ClassToSpawn", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpawnableFromClass_ReturnValue_PropertyAddress, AddSpawnableFromClass_FunctionAddress, "ReturnValue");
		AddSpawnableFromClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSpawnableFromClass_FunctionAddress, "ReturnValue");
		AddSpawnableFromClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpawnableFromClass_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddSpawnableFromClass_IsValid = AddSpawnableFromClass_FunctionAddress != IntPtr.Zero && AddSpawnableFromClass_Sequence_IsValid && AddSpawnableFromClass_ClassToSpawn_IsValid && AddSpawnableFromClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddSpawnableFromClass", AddSpawnableFromClass_IsValid);
		AddRootFolderToSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddRootFolderToSequence");
		AddRootFolderToSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRootFolderToSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRootFolderToSequence_Sequence_PropertyAddress, AddRootFolderToSequence_FunctionAddress, "Sequence");
		AddRootFolderToSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddRootFolderToSequence_FunctionAddress, "Sequence");
		AddRootFolderToSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRootFolderToSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRootFolderToSequence_NewFolderName_PropertyAddress, AddRootFolderToSequence_FunctionAddress, "NewFolderName");
		AddRootFolderToSequence_NewFolderName_Offset = NativeReflectionCached.GetPropertyOffset(AddRootFolderToSequence_FunctionAddress, "NewFolderName");
		AddRootFolderToSequence_NewFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRootFolderToSequence_FunctionAddress, "NewFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRootFolderToSequence_ReturnValue_PropertyAddress, AddRootFolderToSequence_FunctionAddress, "ReturnValue");
		AddRootFolderToSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRootFolderToSequence_FunctionAddress, "ReturnValue");
		AddRootFolderToSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRootFolderToSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddRootFolderToSequence_IsValid = AddRootFolderToSequence_FunctionAddress != IntPtr.Zero && AddRootFolderToSequence_Sequence_IsValid && AddRootFolderToSequence_NewFolderName_IsValid && AddRootFolderToSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddRootFolderToSequence", AddRootFolderToSequence_IsValid);
		AddPossessable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPossessable");
		AddPossessable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPossessable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPossessable_Sequence_PropertyAddress, AddPossessable_FunctionAddress, "Sequence");
		AddPossessable_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddPossessable_FunctionAddress, "Sequence");
		AddPossessable_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPossessable_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPossessable_ObjectToPossess_PropertyAddress, AddPossessable_FunctionAddress, "ObjectToPossess");
		AddPossessable_ObjectToPossess_Offset = NativeReflectionCached.GetPropertyOffset(AddPossessable_FunctionAddress, "ObjectToPossess");
		AddPossessable_ObjectToPossess_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPossessable_FunctionAddress, "ObjectToPossess", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPossessable_ReturnValue_PropertyAddress, AddPossessable_FunctionAddress, "ReturnValue");
		AddPossessable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddPossessable_FunctionAddress, "ReturnValue");
		AddPossessable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPossessable_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddPossessable_IsValid = AddPossessable_FunctionAddress != IntPtr.Zero && AddPossessable_Sequence_IsValid && AddPossessable_ObjectToPossess_IsValid && AddPossessable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddPossessable", AddPossessable_IsValid);
		AddMasterTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMasterTrack");
		AddMasterTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMasterTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMasterTrack_Sequence_PropertyAddress, AddMasterTrack_FunctionAddress, "Sequence");
		AddMasterTrack_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddMasterTrack_FunctionAddress, "Sequence");
		AddMasterTrack_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMasterTrack_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMasterTrack_TrackType_PropertyAddress, AddMasterTrack_FunctionAddress, "TrackType");
		AddMasterTrack_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(AddMasterTrack_FunctionAddress, "TrackType");
		AddMasterTrack_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMasterTrack_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMasterTrack_ReturnValue_PropertyAddress, AddMasterTrack_FunctionAddress, "ReturnValue");
		AddMasterTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMasterTrack_FunctionAddress, "ReturnValue");
		AddMasterTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMasterTrack_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddMasterTrack_IsValid = AddMasterTrack_FunctionAddress != IntPtr.Zero && AddMasterTrack_Sequence_IsValid && AddMasterTrack_TrackType_IsValid && AddMasterTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMasterTrack", AddMasterTrack_IsValid);
		AddMarkedFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMarkedFrame");
		AddMarkedFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMarkedFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMarkedFrame_Sequence_PropertyAddress, AddMarkedFrame_FunctionAddress, "Sequence");
		AddMarkedFrame_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddMarkedFrame_FunctionAddress, "Sequence");
		AddMarkedFrame_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMarkedFrame_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMarkedFrame_InMarkedFrame_PropertyAddress, AddMarkedFrame_FunctionAddress, "InMarkedFrame");
		AddMarkedFrame_InMarkedFrame_Offset = NativeReflectionCached.GetPropertyOffset(AddMarkedFrame_FunctionAddress, "InMarkedFrame");
		AddMarkedFrame_InMarkedFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMarkedFrame_FunctionAddress, "InMarkedFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMarkedFrame_ReturnValue_PropertyAddress, AddMarkedFrame_FunctionAddress, "ReturnValue");
		AddMarkedFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMarkedFrame_FunctionAddress, "ReturnValue");
		AddMarkedFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMarkedFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddMarkedFrame_IsValid = AddMarkedFrame_FunctionAddress != IntPtr.Zero && AddMarkedFrame_Sequence_IsValid && AddMarkedFrame_InMarkedFrame_IsValid && AddMarkedFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneSequenceExtensions:AddMarkedFrame", AddMarkedFrame_IsValid);
	}
}
