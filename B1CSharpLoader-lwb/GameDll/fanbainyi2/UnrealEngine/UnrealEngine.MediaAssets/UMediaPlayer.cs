using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MediaUtils;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaPlayer", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaPlayer : UObject
{
	private static bool OnEndReached_IsValid;

	private static int OnEndReached_Offset;

	private FOnMediaPlayerMediaEvent OnEndReached_DelegateCached;

	private static bool OnMediaClosed_IsValid;

	private static int OnMediaClosed_Offset;

	private FOnMediaPlayerMediaEvent OnMediaClosed_DelegateCached;

	private static bool OnMediaOpened_IsValid;

	private static int OnMediaOpened_Offset;

	private FOnMediaPlayerMediaOpened OnMediaOpened_DelegateCached;

	private static bool OnMediaOpenFailed_IsValid;

	private static int OnMediaOpenFailed_Offset;

	private FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed_DelegateCached;

	private static bool OnPlaybackResumed_IsValid;

	private static int OnPlaybackResumed_Offset;

	private FOnMediaPlayerMediaEvent OnPlaybackResumed_DelegateCached;

	private static bool OnPlaybackSuspended_IsValid;

	private static int OnPlaybackSuspended_Offset;

	private FOnMediaPlayerMediaEvent OnPlaybackSuspended_DelegateCached;

	private static bool OnSeekCompleted_IsValid;

	private static int OnSeekCompleted_Offset;

	private FOnMediaPlayerMediaEvent OnSeekCompleted_DelegateCached;

	private static bool OnTracksChanged_IsValid;

	private static int OnTracksChanged_Offset;

	private FOnMediaPlayerMediaEvent OnTracksChanged_DelegateCached;

	private static bool CacheAhead_IsValid;

	private static int CacheAhead_Offset;

	private static bool CacheBehind_IsValid;

	private static int CacheBehind_Offset;

	private static bool CacheBehindGame_IsValid;

	private static int CacheBehindGame_Offset;

	private static bool NativeAudioOut_IsValid;

	private static FFieldAddress NativeAudioOut_PropertyAddress;

	private static int NativeAudioOut_Offset;

	private static bool PlayOnOpen_IsValid;

	private static FFieldAddress PlayOnOpen_PropertyAddress;

	private static int PlayOnOpen_Offset;

	private static bool Shuffle_IsValid;

	private static FFieldAddress Shuffle_PropertyAddress;

	private static int Shuffle_Offset;

	private static bool Loop_IsValid;

	private static FFieldAddress Loop_PropertyAddress;

	private static int Loop_Offset;

	private static bool Playlist_IsValid;

	private static int Playlist_Offset;

	private static bool PlaylistIndex_IsValid;

	private static int PlaylistIndex_Offset;

	private static bool TimeDelay_IsValid;

	private static int TimeDelay_Offset;

	private static bool AffectedByPIEHandling_IsValid;

	private static FFieldAddress AffectedByPIEHandling_PropertyAddress;

	private static int AffectedByPIEHandling_Offset;

	private static bool SupportsSeeking_IsValid;

	private static IntPtr SupportsSeeking_FunctionAddress;

	private static int SupportsSeeking_ParamsSize;

	private static bool SupportsSeeking_ReturnValue_IsValid;

	private static FFieldAddress SupportsSeeking_ReturnValue_PropertyAddress;

	private static int SupportsSeeking_ReturnValue_Offset;

	private static bool SupportsScrubbing_IsValid;

	private static IntPtr SupportsScrubbing_FunctionAddress;

	private static int SupportsScrubbing_ParamsSize;

	private static bool SupportsScrubbing_ReturnValue_IsValid;

	private static FFieldAddress SupportsScrubbing_ReturnValue_PropertyAddress;

	private static int SupportsScrubbing_ReturnValue_Offset;

	private static bool SupportsRate_IsValid;

	private static IntPtr SupportsRate_FunctionAddress;

	private static int SupportsRate_ParamsSize;

	private static bool SupportsRate_Rate_IsValid;

	private static FFieldAddress SupportsRate_Rate_PropertyAddress;

	private static int SupportsRate_Rate_Offset;

	private static bool SupportsRate_Unthinned_IsValid;

	private static FFieldAddress SupportsRate_Unthinned_PropertyAddress;

	private static int SupportsRate_Unthinned_Offset;

	private static bool SupportsRate_ReturnValue_IsValid;

	private static FFieldAddress SupportsRate_ReturnValue_PropertyAddress;

	private static int SupportsRate_ReturnValue_Offset;

	private static bool SetViewRotation_IsValid;

	private static IntPtr SetViewRotation_FunctionAddress;

	private static int SetViewRotation_ParamsSize;

	private static bool SetViewRotation_Rotation_IsValid;

	private static FFieldAddress SetViewRotation_Rotation_PropertyAddress;

	private static int SetViewRotation_Rotation_Offset;

	private static bool SetViewRotation_Absolute_IsValid;

	private static FFieldAddress SetViewRotation_Absolute_PropertyAddress;

	private static int SetViewRotation_Absolute_Offset;

	private static bool SetViewRotation_ReturnValue_IsValid;

	private static FFieldAddress SetViewRotation_ReturnValue_PropertyAddress;

	private static int SetViewRotation_ReturnValue_Offset;

	private static bool SetViewField_IsValid;

	private static IntPtr SetViewField_FunctionAddress;

	private static int SetViewField_ParamsSize;

	private static bool SetViewField_Horizontal_IsValid;

	private static FFieldAddress SetViewField_Horizontal_PropertyAddress;

	private static int SetViewField_Horizontal_Offset;

	private static bool SetViewField_Vertical_IsValid;

	private static FFieldAddress SetViewField_Vertical_PropertyAddress;

	private static int SetViewField_Vertical_Offset;

	private static bool SetViewField_Absolute_IsValid;

	private static FFieldAddress SetViewField_Absolute_PropertyAddress;

	private static int SetViewField_Absolute_Offset;

	private static bool SetViewField_ReturnValue_IsValid;

	private static FFieldAddress SetViewField_ReturnValue_PropertyAddress;

	private static int SetViewField_ReturnValue_Offset;

	private static bool SetVideoTrackFrameRate_IsValid;

	private static IntPtr SetVideoTrackFrameRate_FunctionAddress;

	private static int SetVideoTrackFrameRate_ParamsSize;

	private static bool SetVideoTrackFrameRate_TrackIndex_IsValid;

	private static FFieldAddress SetVideoTrackFrameRate_TrackIndex_PropertyAddress;

	private static int SetVideoTrackFrameRate_TrackIndex_Offset;

	private static bool SetVideoTrackFrameRate_FormatIndex_IsValid;

	private static FFieldAddress SetVideoTrackFrameRate_FormatIndex_PropertyAddress;

	private static int SetVideoTrackFrameRate_FormatIndex_Offset;

	private static bool SetVideoTrackFrameRate_FrameRate_IsValid;

	private static FFieldAddress SetVideoTrackFrameRate_FrameRate_PropertyAddress;

	private static int SetVideoTrackFrameRate_FrameRate_Offset;

	private static bool SetVideoTrackFrameRate_ReturnValue_IsValid;

	private static FFieldAddress SetVideoTrackFrameRate_ReturnValue_PropertyAddress;

	private static int SetVideoTrackFrameRate_ReturnValue_Offset;

	private static bool SetTrackFormat_IsValid;

	private static IntPtr SetTrackFormat_FunctionAddress;

	private static int SetTrackFormat_ParamsSize;

	private static bool SetTrackFormat_TrackType_IsValid;

	private static FFieldAddress SetTrackFormat_TrackType_PropertyAddress;

	private static int SetTrackFormat_TrackType_Offset;

	private static bool SetTrackFormat_TrackIndex_IsValid;

	private static FFieldAddress SetTrackFormat_TrackIndex_PropertyAddress;

	private static int SetTrackFormat_TrackIndex_Offset;

	private static bool SetTrackFormat_FormatIndex_IsValid;

	private static FFieldAddress SetTrackFormat_FormatIndex_PropertyAddress;

	private static int SetTrackFormat_FormatIndex_Offset;

	private static bool SetTrackFormat_ReturnValue_IsValid;

	private static FFieldAddress SetTrackFormat_ReturnValue_PropertyAddress;

	private static int SetTrackFormat_ReturnValue_Offset;

	private static bool SetTimeDelay_IsValid;

	private static IntPtr SetTimeDelay_FunctionAddress;

	private static int SetTimeDelay_ParamsSize;

	private static bool SetTimeDelay_TimeDelay_IsValid;

	private static FFieldAddress SetTimeDelay_TimeDelay_PropertyAddress;

	private static int SetTimeDelay_TimeDelay_Offset;

	private static bool SetRate_IsValid;

	private static IntPtr SetRate_FunctionAddress;

	private static int SetRate_ParamsSize;

	private static bool SetRate_Rate_IsValid;

	private static FFieldAddress SetRate_Rate_PropertyAddress;

	private static int SetRate_Rate_Offset;

	private static bool SetRate_ReturnValue_IsValid;

	private static FFieldAddress SetRate_ReturnValue_PropertyAddress;

	private static int SetRate_ReturnValue_Offset;

	private static bool SetNativeVolume_IsValid;

	private static IntPtr SetNativeVolume_FunctionAddress;

	private static int SetNativeVolume_ParamsSize;

	private static bool SetNativeVolume_Volume_IsValid;

	private static FFieldAddress SetNativeVolume_Volume_PropertyAddress;

	private static int SetNativeVolume_Volume_Offset;

	private static bool SetNativeVolume_ReturnValue_IsValid;

	private static FFieldAddress SetNativeVolume_ReturnValue_PropertyAddress;

	private static int SetNativeVolume_ReturnValue_Offset;

	private static bool SetMediaOptions_IsValid;

	private static IntPtr SetMediaOptions_FunctionAddress;

	private static int SetMediaOptions_ParamsSize;

	private static bool SetMediaOptions_Options_IsValid;

	private static FFieldAddress SetMediaOptions_Options_PropertyAddress;

	private static int SetMediaOptions_Options_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_Looping_IsValid;

	private static FFieldAddress SetLooping_Looping_PropertyAddress;

	private static int SetLooping_Looping_Offset;

	private static bool SetLooping_ReturnValue_IsValid;

	private static FFieldAddress SetLooping_ReturnValue_PropertyAddress;

	private static int SetLooping_ReturnValue_Offset;

	private static bool SetDesiredPlayerName_IsValid;

	private static IntPtr SetDesiredPlayerName_FunctionAddress;

	private static int SetDesiredPlayerName_ParamsSize;

	private static bool SetDesiredPlayerName_PlayerName_IsValid;

	private static FFieldAddress SetDesiredPlayerName_PlayerName_PropertyAddress;

	private static int SetDesiredPlayerName_PlayerName_Offset;

	private static bool SetBlockOnTime_IsValid;

	private static IntPtr SetBlockOnTime_FunctionAddress;

	private static int SetBlockOnTime_ParamsSize;

	private static bool SetBlockOnTime_Time_IsValid;

	private static FFieldAddress SetBlockOnTime_Time_PropertyAddress;

	private static int SetBlockOnTime_Time_Offset;

	private static bool SelectTrack_IsValid;

	private static IntPtr SelectTrack_FunctionAddress;

	private static int SelectTrack_ParamsSize;

	private static bool SelectTrack_TrackType_IsValid;

	private static FFieldAddress SelectTrack_TrackType_PropertyAddress;

	private static int SelectTrack_TrackType_Offset;

	private static bool SelectTrack_TrackIndex_IsValid;

	private static FFieldAddress SelectTrack_TrackIndex_PropertyAddress;

	private static int SelectTrack_TrackIndex_Offset;

	private static bool SelectTrack_ReturnValue_IsValid;

	private static FFieldAddress SelectTrack_ReturnValue_PropertyAddress;

	private static int SelectTrack_ReturnValue_Offset;

	private static bool Seek_IsValid;

	private static IntPtr Seek_FunctionAddress;

	private static int Seek_ParamsSize;

	private static bool Seek_Time_IsValid;

	private static FFieldAddress Seek_Time_PropertyAddress;

	private static int Seek_Time_Offset;

	private static bool Seek_ReturnValue_IsValid;

	private static FFieldAddress Seek_ReturnValue_PropertyAddress;

	private static int Seek_ReturnValue_Offset;

	private static bool Rewind_IsValid;

	private static IntPtr Rewind_FunctionAddress;

	private static int Rewind_ParamsSize;

	private static bool Rewind_ReturnValue_IsValid;

	private static FFieldAddress Rewind_ReturnValue_PropertyAddress;

	private static int Rewind_ReturnValue_Offset;

	private static bool Reopen_IsValid;

	private static IntPtr Reopen_FunctionAddress;

	private static int Reopen_ParamsSize;

	private static bool Reopen_ReturnValue_IsValid;

	private static FFieldAddress Reopen_ReturnValue_PropertyAddress;

	private static int Reopen_ReturnValue_Offset;

	private static bool Previous_IsValid;

	private static IntPtr Previous_FunctionAddress;

	private static int Previous_ParamsSize;

	private static bool Previous_ReturnValue_IsValid;

	private static FFieldAddress Previous_ReturnValue_PropertyAddress;

	private static int Previous_ReturnValue_Offset;

	private static bool PlayAndSeek_IsValid;

	private static IntPtr PlayAndSeek_FunctionAddress;

	private static int PlayAndSeek_ParamsSize;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Play_ReturnValue_IsValid;

	private static FFieldAddress Play_ReturnValue_PropertyAddress;

	private static int Play_ReturnValue_Offset;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool Pause_ReturnValue_IsValid;

	private static FFieldAddress Pause_ReturnValue_PropertyAddress;

	private static int Pause_ReturnValue_Offset;

	private static bool OpenUrl_IsValid;

	private static IntPtr OpenUrl_FunctionAddress;

	private static int OpenUrl_ParamsSize;

	private static bool OpenUrl_Url_IsValid;

	private static FFieldAddress OpenUrl_Url_PropertyAddress;

	private static int OpenUrl_Url_Offset;

	private static bool OpenUrl_ReturnValue_IsValid;

	private static FFieldAddress OpenUrl_ReturnValue_PropertyAddress;

	private static int OpenUrl_ReturnValue_Offset;

	private static bool OpenSourceWithOptions_IsValid;

	private static IntPtr OpenSourceWithOptions_FunctionAddress;

	private static int OpenSourceWithOptions_ParamsSize;

	private static bool OpenSourceWithOptions_MediaSource_IsValid;

	private static FFieldAddress OpenSourceWithOptions_MediaSource_PropertyAddress;

	private static int OpenSourceWithOptions_MediaSource_Offset;

	private static bool OpenSourceWithOptions_Options_IsValid;

	private static FFieldAddress OpenSourceWithOptions_Options_PropertyAddress;

	private static int OpenSourceWithOptions_Options_Offset;

	private static bool OpenSourceWithOptions_ReturnValue_IsValid;

	private static FFieldAddress OpenSourceWithOptions_ReturnValue_PropertyAddress;

	private static int OpenSourceWithOptions_ReturnValue_Offset;

	private static bool OpenSourceLatent_IsValid;

	private static IntPtr OpenSourceLatent_FunctionAddress;

	private static int OpenSourceLatent_ParamsSize;

	private static bool OpenSourceLatent_WorldContextObject_IsValid;

	private static FFieldAddress OpenSourceLatent_WorldContextObject_PropertyAddress;

	private static int OpenSourceLatent_WorldContextObject_Offset;

	private static bool OpenSourceLatent_LatentInfo_IsValid;

	private static FFieldAddress OpenSourceLatent_LatentInfo_PropertyAddress;

	private static int OpenSourceLatent_LatentInfo_Offset;

	private static bool OpenSourceLatent_MediaSource_IsValid;

	private static FFieldAddress OpenSourceLatent_MediaSource_PropertyAddress;

	private static int OpenSourceLatent_MediaSource_Offset;

	private static bool OpenSourceLatent_Options_IsValid;

	private static FFieldAddress OpenSourceLatent_Options_PropertyAddress;

	private static int OpenSourceLatent_Options_Offset;

	private static bool OpenSourceLatent_bSuccess_IsValid;

	private static FFieldAddress OpenSourceLatent_bSuccess_PropertyAddress;

	private static int OpenSourceLatent_bSuccess_Offset;

	private static bool OpenSource_IsValid;

	private static IntPtr OpenSource_FunctionAddress;

	private static int OpenSource_ParamsSize;

	private static bool OpenSource_MediaSource_IsValid;

	private static FFieldAddress OpenSource_MediaSource_PropertyAddress;

	private static int OpenSource_MediaSource_Offset;

	private static bool OpenSource_ReturnValue_IsValid;

	private static FFieldAddress OpenSource_ReturnValue_PropertyAddress;

	private static int OpenSource_ReturnValue_Offset;

	private static bool OpenPlaylistIndex_IsValid;

	private static IntPtr OpenPlaylistIndex_FunctionAddress;

	private static int OpenPlaylistIndex_ParamsSize;

	private static bool OpenPlaylistIndex_InPlaylist_IsValid;

	private static FFieldAddress OpenPlaylistIndex_InPlaylist_PropertyAddress;

	private static int OpenPlaylistIndex_InPlaylist_Offset;

	private static bool OpenPlaylistIndex_Index_IsValid;

	private static FFieldAddress OpenPlaylistIndex_Index_PropertyAddress;

	private static int OpenPlaylistIndex_Index_Offset;

	private static bool OpenPlaylistIndex_ReturnValue_IsValid;

	private static FFieldAddress OpenPlaylistIndex_ReturnValue_PropertyAddress;

	private static int OpenPlaylistIndex_ReturnValue_Offset;

	private static bool OpenPlaylist_IsValid;

	private static IntPtr OpenPlaylist_FunctionAddress;

	private static int OpenPlaylist_ParamsSize;

	private static bool OpenPlaylist_InPlaylist_IsValid;

	private static FFieldAddress OpenPlaylist_InPlaylist_PropertyAddress;

	private static int OpenPlaylist_InPlaylist_Offset;

	private static bool OpenPlaylist_ReturnValue_IsValid;

	private static FFieldAddress OpenPlaylist_ReturnValue_PropertyAddress;

	private static int OpenPlaylist_ReturnValue_Offset;

	private static bool OpenFile_IsValid;

	private static IntPtr OpenFile_FunctionAddress;

	private static int OpenFile_ParamsSize;

	private static bool OpenFile_FilePath_IsValid;

	private static FFieldAddress OpenFile_FilePath_PropertyAddress;

	private static int OpenFile_FilePath_Offset;

	private static bool OpenFile_ReturnValue_IsValid;

	private static FFieldAddress OpenFile_ReturnValue_PropertyAddress;

	private static int OpenFile_ReturnValue_Offset;

	private static bool Next_IsValid;

	private static IntPtr Next_FunctionAddress;

	private static int Next_ParamsSize;

	private static bool Next_ReturnValue_IsValid;

	private static FFieldAddress Next_ReturnValue_PropertyAddress;

	private static int Next_ReturnValue_Offset;

	private static bool IsReady_IsValid;

	private static IntPtr IsReady_FunctionAddress;

	private static int IsReady_ParamsSize;

	private static bool IsReady_ReturnValue_IsValid;

	private static FFieldAddress IsReady_ReturnValue_PropertyAddress;

	private static int IsReady_ReturnValue_Offset;

	private static bool IsPreparing_IsValid;

	private static IntPtr IsPreparing_FunctionAddress;

	private static int IsPreparing_ParamsSize;

	private static bool IsPreparing_ReturnValue_IsValid;

	private static FFieldAddress IsPreparing_ReturnValue_PropertyAddress;

	private static int IsPreparing_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsPaused_IsValid;

	private static IntPtr IsPaused_FunctionAddress;

	private static int IsPaused_ParamsSize;

	private static bool IsPaused_ReturnValue_IsValid;

	private static FFieldAddress IsPaused_ReturnValue_PropertyAddress;

	private static int IsPaused_ReturnValue_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool IsConnecting_IsValid;

	private static IntPtr IsConnecting_FunctionAddress;

	private static int IsConnecting_ParamsSize;

	private static bool IsConnecting_ReturnValue_IsValid;

	private static FFieldAddress IsConnecting_ReturnValue_PropertyAddress;

	private static int IsConnecting_ReturnValue_Offset;

	private static bool IsClosed_IsValid;

	private static IntPtr IsClosed_FunctionAddress;

	private static int IsClosed_ParamsSize;

	private static bool IsClosed_ReturnValue_IsValid;

	private static FFieldAddress IsClosed_ReturnValue_PropertyAddress;

	private static int IsClosed_ReturnValue_Offset;

	private static bool IsBuffering_IsValid;

	private static IntPtr IsBuffering_FunctionAddress;

	private static int IsBuffering_ParamsSize;

	private static bool IsBuffering_ReturnValue_IsValid;

	private static FFieldAddress IsBuffering_ReturnValue_PropertyAddress;

	private static int IsBuffering_ReturnValue_Offset;

	private static bool HasError_IsValid;

	private static IntPtr HasError_FunctionAddress;

	private static int HasError_ParamsSize;

	private static bool HasError_ReturnValue_IsValid;

	private static FFieldAddress HasError_ReturnValue_PropertyAddress;

	private static int HasError_ReturnValue_Offset;

	private static bool GetViewRotation_IsValid;

	private static IntPtr GetViewRotation_FunctionAddress;

	private static int GetViewRotation_ParamsSize;

	private static bool GetViewRotation_ReturnValue_IsValid;

	private static FFieldAddress GetViewRotation_ReturnValue_PropertyAddress;

	private static int GetViewRotation_ReturnValue_Offset;

	private static bool GetVideoTrackType_IsValid;

	private static IntPtr GetVideoTrackType_FunctionAddress;

	private static int GetVideoTrackType_ParamsSize;

	private static bool GetVideoTrackType_TrackIndex_IsValid;

	private static FFieldAddress GetVideoTrackType_TrackIndex_PropertyAddress;

	private static int GetVideoTrackType_TrackIndex_Offset;

	private static bool GetVideoTrackType_FormatIndex_IsValid;

	private static FFieldAddress GetVideoTrackType_FormatIndex_PropertyAddress;

	private static int GetVideoTrackType_FormatIndex_Offset;

	private static bool GetVideoTrackType_ReturnValue_IsValid;

	private static FFieldAddress GetVideoTrackType_ReturnValue_PropertyAddress;

	private static int GetVideoTrackType_ReturnValue_Offset;

	private static bool GetVideoTrackFrameRates_IsValid;

	private static IntPtr GetVideoTrackFrameRates_FunctionAddress;

	private static int GetVideoTrackFrameRates_ParamsSize;

	private static bool GetVideoTrackFrameRates_TrackIndex_IsValid;

	private static FFieldAddress GetVideoTrackFrameRates_TrackIndex_PropertyAddress;

	private static int GetVideoTrackFrameRates_TrackIndex_Offset;

	private static bool GetVideoTrackFrameRates_FormatIndex_IsValid;

	private static FFieldAddress GetVideoTrackFrameRates_FormatIndex_PropertyAddress;

	private static int GetVideoTrackFrameRates_FormatIndex_Offset;

	private static bool GetVideoTrackFrameRates_ReturnValue_IsValid;

	private static FFieldAddress GetVideoTrackFrameRates_ReturnValue_PropertyAddress;

	private static int GetVideoTrackFrameRates_ReturnValue_Offset;

	private static bool GetVideoTrackFrameRate_IsValid;

	private static IntPtr GetVideoTrackFrameRate_FunctionAddress;

	private static int GetVideoTrackFrameRate_ParamsSize;

	private static bool GetVideoTrackFrameRate_TrackIndex_IsValid;

	private static FFieldAddress GetVideoTrackFrameRate_TrackIndex_PropertyAddress;

	private static int GetVideoTrackFrameRate_TrackIndex_Offset;

	private static bool GetVideoTrackFrameRate_FormatIndex_IsValid;

	private static FFieldAddress GetVideoTrackFrameRate_FormatIndex_PropertyAddress;

	private static int GetVideoTrackFrameRate_FormatIndex_Offset;

	private static bool GetVideoTrackFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetVideoTrackFrameRate_ReturnValue_PropertyAddress;

	private static int GetVideoTrackFrameRate_ReturnValue_Offset;

	private static bool GetVideoTrackDimensions_IsValid;

	private static IntPtr GetVideoTrackDimensions_FunctionAddress;

	private static int GetVideoTrackDimensions_ParamsSize;

	private static bool GetVideoTrackDimensions_TrackIndex_IsValid;

	private static FFieldAddress GetVideoTrackDimensions_TrackIndex_PropertyAddress;

	private static int GetVideoTrackDimensions_TrackIndex_Offset;

	private static bool GetVideoTrackDimensions_FormatIndex_IsValid;

	private static FFieldAddress GetVideoTrackDimensions_FormatIndex_PropertyAddress;

	private static int GetVideoTrackDimensions_FormatIndex_Offset;

	private static bool GetVideoTrackDimensions_ReturnValue_IsValid;

	private static FFieldAddress GetVideoTrackDimensions_ReturnValue_PropertyAddress;

	private static int GetVideoTrackDimensions_ReturnValue_Offset;

	private static bool GetVideoTrackAspectRatio_IsValid;

	private static IntPtr GetVideoTrackAspectRatio_FunctionAddress;

	private static int GetVideoTrackAspectRatio_ParamsSize;

	private static bool GetVideoTrackAspectRatio_TrackIndex_IsValid;

	private static FFieldAddress GetVideoTrackAspectRatio_TrackIndex_PropertyAddress;

	private static int GetVideoTrackAspectRatio_TrackIndex_Offset;

	private static bool GetVideoTrackAspectRatio_FormatIndex_IsValid;

	private static FFieldAddress GetVideoTrackAspectRatio_FormatIndex_PropertyAddress;

	private static int GetVideoTrackAspectRatio_FormatIndex_Offset;

	private static bool GetVideoTrackAspectRatio_ReturnValue_IsValid;

	private static FFieldAddress GetVideoTrackAspectRatio_ReturnValue_PropertyAddress;

	private static int GetVideoTrackAspectRatio_ReturnValue_Offset;

	private static bool GetVerticalFieldOfView_IsValid;

	private static IntPtr GetVerticalFieldOfView_FunctionAddress;

	private static int GetVerticalFieldOfView_ParamsSize;

	private static bool GetVerticalFieldOfView_ReturnValue_IsValid;

	private static FFieldAddress GetVerticalFieldOfView_ReturnValue_PropertyAddress;

	private static int GetVerticalFieldOfView_ReturnValue_Offset;

	private static bool GetUrl_IsValid;

	private static IntPtr GetUrl_FunctionAddress;

	private static int GetUrl_ParamsSize;

	private static bool GetUrl_ReturnValue_IsValid;

	private static FFieldAddress GetUrl_ReturnValue_PropertyAddress;

	private static int GetUrl_ReturnValue_Offset;

	private static bool GetTrackLanguage_IsValid;

	private static IntPtr GetTrackLanguage_FunctionAddress;

	private static int GetTrackLanguage_ParamsSize;

	private static bool GetTrackLanguage_TrackType_IsValid;

	private static FFieldAddress GetTrackLanguage_TrackType_PropertyAddress;

	private static int GetTrackLanguage_TrackType_Offset;

	private static bool GetTrackLanguage_TrackIndex_IsValid;

	private static FFieldAddress GetTrackLanguage_TrackIndex_PropertyAddress;

	private static int GetTrackLanguage_TrackIndex_Offset;

	private static bool GetTrackLanguage_ReturnValue_IsValid;

	private static FFieldAddress GetTrackLanguage_ReturnValue_PropertyAddress;

	private static int GetTrackLanguage_ReturnValue_Offset;

	private static bool GetTrackFormat_IsValid;

	private static IntPtr GetTrackFormat_FunctionAddress;

	private static int GetTrackFormat_ParamsSize;

	private static bool GetTrackFormat_TrackType_IsValid;

	private static FFieldAddress GetTrackFormat_TrackType_PropertyAddress;

	private static int GetTrackFormat_TrackType_Offset;

	private static bool GetTrackFormat_TrackIndex_IsValid;

	private static FFieldAddress GetTrackFormat_TrackIndex_PropertyAddress;

	private static int GetTrackFormat_TrackIndex_Offset;

	private static bool GetTrackFormat_ReturnValue_IsValid;

	private static FFieldAddress GetTrackFormat_ReturnValue_PropertyAddress;

	private static int GetTrackFormat_ReturnValue_Offset;

	private static bool GetTrackDisplayName_IsValid;

	private static IntPtr GetTrackDisplayName_FunctionAddress;

	private static int GetTrackDisplayName_ParamsSize;

	private static bool GetTrackDisplayName_TrackType_IsValid;

	private static FFieldAddress GetTrackDisplayName_TrackType_PropertyAddress;

	private static int GetTrackDisplayName_TrackType_Offset;

	private static bool GetTrackDisplayName_TrackIndex_IsValid;

	private static FFieldAddress GetTrackDisplayName_TrackIndex_PropertyAddress;

	private static int GetTrackDisplayName_TrackIndex_Offset;

	private static bool GetTrackDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetTrackDisplayName_ReturnValue_PropertyAddress;

	private static int GetTrackDisplayName_ReturnValue_Offset;

	private static bool GetTimeStamp_IsValid;

	private static IntPtr GetTimeStamp_FunctionAddress;

	private static int GetTimeStamp_ParamsSize;

	private static bool GetTimeStamp_ReturnValue_IsValid;

	private static FFieldAddress GetTimeStamp_ReturnValue_PropertyAddress;

	private static int GetTimeStamp_ReturnValue_Offset;

	private static bool GetTimeDelay_IsValid;

	private static IntPtr GetTimeDelay_FunctionAddress;

	private static int GetTimeDelay_ParamsSize;

	private static bool GetTimeDelay_ReturnValue_IsValid;

	private static FFieldAddress GetTimeDelay_ReturnValue_PropertyAddress;

	private static int GetTimeDelay_ReturnValue_Offset;

	private static bool GetTime_IsValid;

	private static IntPtr GetTime_FunctionAddress;

	private static int GetTime_ParamsSize;

	private static bool GetTime_ReturnValue_IsValid;

	private static FFieldAddress GetTime_ReturnValue_PropertyAddress;

	private static int GetTime_ReturnValue_Offset;

	private static bool GetSupportedRates_IsValid;

	private static IntPtr GetSupportedRates_FunctionAddress;

	private static int GetSupportedRates_ParamsSize;

	private static bool GetSupportedRates_OutRates_IsValid;

	private static FFieldAddress GetSupportedRates_OutRates_PropertyAddress;

	private static int GetSupportedRates_OutRates_Offset;

	private static bool GetSupportedRates_Unthinned_IsValid;

	private static FFieldAddress GetSupportedRates_Unthinned_PropertyAddress;

	private static int GetSupportedRates_Unthinned_Offset;

	private static bool GetSelectedTrack_IsValid;

	private static IntPtr GetSelectedTrack_FunctionAddress;

	private static int GetSelectedTrack_ParamsSize;

	private static bool GetSelectedTrack_TrackType_IsValid;

	private static FFieldAddress GetSelectedTrack_TrackType_PropertyAddress;

	private static int GetSelectedTrack_TrackType_Offset;

	private static bool GetSelectedTrack_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedTrack_ReturnValue_PropertyAddress;

	private static int GetSelectedTrack_ReturnValue_Offset;

	private static bool GetRate_IsValid;

	private static IntPtr GetRate_FunctionAddress;

	private static int GetRate_ParamsSize;

	private static bool GetRate_ReturnValue_IsValid;

	private static FFieldAddress GetRate_ReturnValue_PropertyAddress;

	private static int GetRate_ReturnValue_Offset;

	private static bool GetPlaylistIndex_IsValid;

	private static IntPtr GetPlaylistIndex_FunctionAddress;

	private static int GetPlaylistIndex_ParamsSize;

	private static bool GetPlaylistIndex_ReturnValue_IsValid;

	private static FFieldAddress GetPlaylistIndex_ReturnValue_PropertyAddress;

	private static int GetPlaylistIndex_ReturnValue_Offset;

	private static bool GetPlaylist_IsValid;

	private static IntPtr GetPlaylist_FunctionAddress;

	private static int GetPlaylist_ParamsSize;

	private static bool GetPlaylist_ReturnValue_IsValid;

	private static FFieldAddress GetPlaylist_ReturnValue_PropertyAddress;

	private static int GetPlaylist_ReturnValue_Offset;

	private static bool GetPlayerName_IsValid;

	private static IntPtr GetPlayerName_FunctionAddress;

	private static int GetPlayerName_ParamsSize;

	private static bool GetPlayerName_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerName_ReturnValue_PropertyAddress;

	private static int GetPlayerName_ReturnValue_Offset;

	private static bool GetNumTracks_IsValid;

	private static IntPtr GetNumTracks_FunctionAddress;

	private static int GetNumTracks_ParamsSize;

	private static bool GetNumTracks_TrackType_IsValid;

	private static FFieldAddress GetNumTracks_TrackType_PropertyAddress;

	private static int GetNumTracks_TrackType_Offset;

	private static bool GetNumTracks_ReturnValue_IsValid;

	private static FFieldAddress GetNumTracks_ReturnValue_PropertyAddress;

	private static int GetNumTracks_ReturnValue_Offset;

	private static bool GetNumTrackFormats_IsValid;

	private static IntPtr GetNumTrackFormats_FunctionAddress;

	private static int GetNumTrackFormats_ParamsSize;

	private static bool GetNumTrackFormats_TrackType_IsValid;

	private static FFieldAddress GetNumTrackFormats_TrackType_PropertyAddress;

	private static int GetNumTrackFormats_TrackType_Offset;

	private static bool GetNumTrackFormats_TrackIndex_IsValid;

	private static FFieldAddress GetNumTrackFormats_TrackIndex_PropertyAddress;

	private static int GetNumTrackFormats_TrackIndex_Offset;

	private static bool GetNumTrackFormats_ReturnValue_IsValid;

	private static FFieldAddress GetNumTrackFormats_ReturnValue_PropertyAddress;

	private static int GetNumTrackFormats_ReturnValue_Offset;

	private static bool GetMediaName_IsValid;

	private static IntPtr GetMediaName_FunctionAddress;

	private static int GetMediaName_ParamsSize;

	private static bool GetMediaName_ReturnValue_IsValid;

	private static FFieldAddress GetMediaName_ReturnValue_PropertyAddress;

	private static int GetMediaName_ReturnValue_Offset;

	private static bool GetHorizontalFieldOfView_IsValid;

	private static IntPtr GetHorizontalFieldOfView_FunctionAddress;

	private static int GetHorizontalFieldOfView_ParamsSize;

	private static bool GetHorizontalFieldOfView_ReturnValue_IsValid;

	private static FFieldAddress GetHorizontalFieldOfView_ReturnValue_PropertyAddress;

	private static int GetHorizontalFieldOfView_ReturnValue_Offset;

	private static bool GetDuration_IsValid;

	private static IntPtr GetDuration_FunctionAddress;

	private static int GetDuration_ParamsSize;

	private static bool GetDuration_ReturnValue_IsValid;

	private static FFieldAddress GetDuration_ReturnValue_PropertyAddress;

	private static int GetDuration_ReturnValue_Offset;

	private static bool GetDesiredPlayerName_IsValid;

	private static IntPtr GetDesiredPlayerName_FunctionAddress;

	private static int GetDesiredPlayerName_ParamsSize;

	private static bool GetDesiredPlayerName_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredPlayerName_ReturnValue_PropertyAddress;

	private static int GetDesiredPlayerName_ReturnValue_Offset;

	private static bool GetAudioTrackType_IsValid;

	private static IntPtr GetAudioTrackType_FunctionAddress;

	private static int GetAudioTrackType_ParamsSize;

	private static bool GetAudioTrackType_TrackIndex_IsValid;

	private static FFieldAddress GetAudioTrackType_TrackIndex_PropertyAddress;

	private static int GetAudioTrackType_TrackIndex_Offset;

	private static bool GetAudioTrackType_FormatIndex_IsValid;

	private static FFieldAddress GetAudioTrackType_FormatIndex_PropertyAddress;

	private static int GetAudioTrackType_FormatIndex_Offset;

	private static bool GetAudioTrackType_ReturnValue_IsValid;

	private static FFieldAddress GetAudioTrackType_ReturnValue_PropertyAddress;

	private static int GetAudioTrackType_ReturnValue_Offset;

	private static bool GetAudioTrackSampleRate_IsValid;

	private static IntPtr GetAudioTrackSampleRate_FunctionAddress;

	private static int GetAudioTrackSampleRate_ParamsSize;

	private static bool GetAudioTrackSampleRate_TrackIndex_IsValid;

	private static FFieldAddress GetAudioTrackSampleRate_TrackIndex_PropertyAddress;

	private static int GetAudioTrackSampleRate_TrackIndex_Offset;

	private static bool GetAudioTrackSampleRate_FormatIndex_IsValid;

	private static FFieldAddress GetAudioTrackSampleRate_FormatIndex_PropertyAddress;

	private static int GetAudioTrackSampleRate_FormatIndex_Offset;

	private static bool GetAudioTrackSampleRate_ReturnValue_IsValid;

	private static FFieldAddress GetAudioTrackSampleRate_ReturnValue_PropertyAddress;

	private static int GetAudioTrackSampleRate_ReturnValue_Offset;

	private static bool GetAudioTrackChannels_IsValid;

	private static IntPtr GetAudioTrackChannels_FunctionAddress;

	private static int GetAudioTrackChannels_ParamsSize;

	private static bool GetAudioTrackChannels_TrackIndex_IsValid;

	private static FFieldAddress GetAudioTrackChannels_TrackIndex_PropertyAddress;

	private static int GetAudioTrackChannels_TrackIndex_Offset;

	private static bool GetAudioTrackChannels_FormatIndex_IsValid;

	private static FFieldAddress GetAudioTrackChannels_FormatIndex_PropertyAddress;

	private static int GetAudioTrackChannels_FormatIndex_Offset;

	private static bool GetAudioTrackChannels_ReturnValue_IsValid;

	private static FFieldAddress GetAudioTrackChannels_ReturnValue_PropertyAddress;

	private static int GetAudioTrackChannels_ReturnValue_Offset;

	private static bool Close_IsValid;

	private static IntPtr Close_FunctionAddress;

	private static int Close_ParamsSize;

	private static bool CanPlayUrl_IsValid;

	private static IntPtr CanPlayUrl_FunctionAddress;

	private static int CanPlayUrl_ParamsSize;

	private static bool CanPlayUrl_Url_IsValid;

	private static FFieldAddress CanPlayUrl_Url_PropertyAddress;

	private static int CanPlayUrl_Url_Offset;

	private static bool CanPlayUrl_ReturnValue_IsValid;

	private static FFieldAddress CanPlayUrl_ReturnValue_PropertyAddress;

	private static int CanPlayUrl_ReturnValue_Offset;

	private static bool CanPlaySource_IsValid;

	private static IntPtr CanPlaySource_FunctionAddress;

	private static int CanPlaySource_ParamsSize;

	private static bool CanPlaySource_MediaSource_IsValid;

	private static FFieldAddress CanPlaySource_MediaSource_PropertyAddress;

	private static int CanPlaySource_MediaSource_Offset;

	private static bool CanPlaySource_ReturnValue_IsValid;

	private static FFieldAddress CanPlaySource_ReturnValue_PropertyAddress;

	private static int CanPlaySource_ReturnValue_Offset;

	private static bool CanPause_IsValid;

	private static IntPtr CanPause_FunctionAddress;

	private static int CanPause_ParamsSize;

	private static bool CanPause_ReturnValue_IsValid;

	private static FFieldAddress CanPause_ReturnValue_PropertyAddress;

	private static int CanPause_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnEndReached")]
	public FOnMediaPlayerMediaEvent OnEndReached
	{
		get
		{
			CheckDestroyed();
			if (!OnEndReached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnEndReached");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnEndReached_DelegateCached == null)
			{
				OnEndReached_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnEndReached_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndReached_Offset));
			}
			return OnEndReached_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnMediaClosed")]
	public FOnMediaPlayerMediaEvent OnMediaClosed
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaClosed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnMediaClosed");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnMediaClosed_DelegateCached == null)
			{
				OnMediaClosed_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnMediaClosed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaClosed_Offset));
			}
			return OnMediaClosed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnMediaOpened")]
	public FOnMediaPlayerMediaOpened OnMediaOpened
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaOpened_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnMediaOpened");
				return new FOnMediaPlayerMediaOpened();
			}
			if (OnMediaOpened_DelegateCached == null)
			{
				OnMediaOpened_DelegateCached = new FOnMediaPlayerMediaOpened();
				OnMediaOpened_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaOpened_Offset));
			}
			return OnMediaOpened_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnMediaOpenFailed")]
	public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaOpenFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnMediaOpenFailed");
				return new FOnMediaPlayerMediaOpenFailed();
			}
			if (OnMediaOpenFailed_DelegateCached == null)
			{
				OnMediaOpenFailed_DelegateCached = new FOnMediaPlayerMediaOpenFailed();
				OnMediaOpenFailed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaOpenFailed_Offset));
			}
			return OnMediaOpenFailed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnPlaybackResumed")]
	public FOnMediaPlayerMediaEvent OnPlaybackResumed
	{
		get
		{
			CheckDestroyed();
			if (!OnPlaybackResumed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnPlaybackResumed");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnPlaybackResumed_DelegateCached == null)
			{
				OnPlaybackResumed_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnPlaybackResumed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlaybackResumed_Offset));
			}
			return OnPlaybackResumed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnPlaybackSuspended")]
	public FOnMediaPlayerMediaEvent OnPlaybackSuspended
	{
		get
		{
			CheckDestroyed();
			if (!OnPlaybackSuspended_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnPlaybackSuspended");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnPlaybackSuspended_DelegateCached == null)
			{
				OnPlaybackSuspended_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnPlaybackSuspended_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlaybackSuspended_Offset));
			}
			return OnPlaybackSuspended_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnSeekCompleted")]
	public FOnMediaPlayerMediaEvent OnSeekCompleted
	{
		get
		{
			CheckDestroyed();
			if (!OnSeekCompleted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnSeekCompleted");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnSeekCompleted_DelegateCached == null)
			{
				OnSeekCompleted_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnSeekCompleted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSeekCompleted_Offset));
			}
			return OnSeekCompleted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OnTracksChanged")]
	public FOnMediaPlayerMediaEvent OnTracksChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnTracksChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:OnTracksChanged");
				return new FOnMediaPlayerMediaEvent();
			}
			if (OnTracksChanged_DelegateCached == null)
			{
				OnTracksChanged_DelegateCached = new FOnMediaPlayerMediaEvent();
				OnTracksChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTracksChanged_Offset));
			}
			return OnTracksChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532996uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CacheAhead")]
	public FTimespan CacheAhead
	{
		get
		{
			CheckDestroyed();
			if (!CacheAhead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheAhead");
				return default(FTimespan);
			}
			return FTimespan.FromNative(IntPtr.Add(base.Address, CacheAhead_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheAhead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheAhead");
			}
			else
			{
				FTimespan.ToNative(IntPtr.Add(base.Address, CacheAhead_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532996uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CacheBehind")]
	public FTimespan CacheBehind
	{
		get
		{
			CheckDestroyed();
			if (!CacheBehind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheBehind");
				return default(FTimespan);
			}
			return FTimespan.FromNative(IntPtr.Add(base.Address, CacheBehind_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheBehind_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheBehind");
			}
			else
			{
				FTimespan.ToNative(IntPtr.Add(base.Address, CacheBehind_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532996uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CacheBehindGame")]
	public FTimespan CacheBehindGame
	{
		get
		{
			CheckDestroyed();
			if (!CacheBehindGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheBehindGame");
				return default(FTimespan);
			}
			return FTimespan.FromNative(IntPtr.Add(base.Address, CacheBehindGame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheBehindGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:CacheBehindGame");
			}
			else
			{
				FTimespan.ToNative(IntPtr.Add(base.Address, CacheBehindGame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785924uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:NativeAudioOut")]
	public bool NativeAudioOut
	{
		get
		{
			CheckDestroyed();
			if (!NativeAudioOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:NativeAudioOut");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NativeAudioOut_Offset), 0, NativeAudioOut_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NativeAudioOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:NativeAudioOut");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NativeAudioOut_Offset), 0, NativeAudioOut_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:PlayOnOpen")]
	public bool PlayOnOpen
	{
		get
		{
			CheckDestroyed();
			if (!PlayOnOpen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:PlayOnOpen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayOnOpen_Offset), 0, PlayOnOpen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayOnOpen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:PlayOnOpen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayOnOpen_Offset), 0, PlayOnOpen_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Shuffle")]
	public bool Shuffle
	{
		get
		{
			CheckDestroyed();
			if (!Shuffle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Shuffle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Shuffle_Offset), 0, Shuffle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Shuffle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Shuffle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Shuffle_Offset), 0, Shuffle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Loop")]
	protected bool Loop
	{
		get
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Loop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Loop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861518356uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Playlist")]
	protected UMediaPlaylist Playlist
	{
		get
		{
			CheckDestroyed();
			if (!Playlist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Playlist");
				return null;
			}
			return UObjectMarshaler<UMediaPlaylist>.FromNative(IntPtr.Add(base.Address, Playlist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Playlist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:Playlist");
			}
			else
			{
				UObjectMarshaler<UMediaPlaylist>.ToNative(IntPtr.Add(base.Address, Playlist_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:PlaylistIndex")]
	protected int PlaylistIndex
	{
		get
		{
			CheckDestroyed();
			if (!PlaylistIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:PlaylistIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlaylistIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaylistIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:PlaylistIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlaylistIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925716uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:TimeDelay")]
	protected FTimespan TimeDelay
	{
		get
		{
			CheckDestroyed();
			if (!TimeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:TimeDelay");
				return default(FTimespan);
			}
			return FTimespan.FromNative(IntPtr.Add(base.Address, TimeDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:TimeDelay");
			}
			else
			{
				FTimespan.ToNative(IntPtr.Add(base.Address, TimeDelay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:AffectedByPIEHandling")]
	public bool AffectedByPIEHandling
	{
		get
		{
			CheckDestroyed();
			if (!AffectedByPIEHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:AffectedByPIEHandling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectedByPIEHandling_Offset), 0, AffectedByPIEHandling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectedByPIEHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaPlayer:AffectedByPIEHandling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectedByPIEHandling_Offset), 0, AffectedByPIEHandling_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SupportsSeeking")]
	public unsafe bool SupportsSeeking()
	{
		CheckDestroyed();
		if (!SupportsSeeking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SupportsSeeking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsSeeking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsSeeking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsSeeking_FunctionAddress, intPtr, SupportsSeeking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsSeeking_ReturnValue_Offset), 0, SupportsSeeking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SupportsScrubbing")]
	public unsafe bool SupportsScrubbing()
	{
		CheckDestroyed();
		if (!SupportsScrubbing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SupportsScrubbing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsScrubbing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsScrubbing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsScrubbing_FunctionAddress, intPtr, SupportsScrubbing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsScrubbing_ReturnValue_Offset), 0, SupportsScrubbing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SupportsRate")]
	public unsafe bool SupportsRate(float Rate, bool Unthinned)
	{
		CheckDestroyed();
		if (!SupportsRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SupportsRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SupportsRate_Rate_Offset), 0, SupportsRate_Rate_PropertyAddress.Address, Rate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SupportsRate_Unthinned_Offset), 0, SupportsRate_Unthinned_PropertyAddress.Address, Unthinned);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsRate_FunctionAddress, intPtr, SupportsRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsRate_ReturnValue_Offset), 0, SupportsRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetViewRotation")]
	public unsafe bool SetViewRotation(FRotator Rotation, bool Absolute)
	{
		CheckDestroyed();
		if (!SetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetViewRotation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetViewRotation_Rotation_Offset), 0, SetViewRotation_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetViewRotation_Absolute_Offset), 0, SetViewRotation_Absolute_PropertyAddress.Address, Absolute);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewRotation_FunctionAddress, intPtr, SetViewRotation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetViewRotation_ReturnValue_Offset), 0, SetViewRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetViewField")]
	public unsafe bool SetViewField(float Horizontal, float Vertical, bool Absolute)
	{
		CheckDestroyed();
		if (!SetViewField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetViewField");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewField_Horizontal_Offset), 0, SetViewField_Horizontal_PropertyAddress.Address, Horizontal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewField_Vertical_Offset), 0, SetViewField_Vertical_PropertyAddress.Address, Vertical);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetViewField_Absolute_Offset), 0, SetViewField_Absolute_PropertyAddress.Address, Absolute);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewField_FunctionAddress, intPtr, SetViewField_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetViewField_ReturnValue_Offset), 0, SetViewField_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetVideoTrackFrameRate")]
	public unsafe bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)
	{
		CheckDestroyed();
		if (!SetVideoTrackFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetVideoTrackFrameRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVideoTrackFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVideoTrackFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVideoTrackFrameRate_TrackIndex_Offset), 0, SetVideoTrackFrameRate_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVideoTrackFrameRate_FormatIndex_Offset), 0, SetVideoTrackFrameRate_FormatIndex_PropertyAddress.Address, FormatIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVideoTrackFrameRate_FrameRate_Offset), 0, SetVideoTrackFrameRate_FrameRate_PropertyAddress.Address, FrameRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVideoTrackFrameRate_FunctionAddress, intPtr, SetVideoTrackFrameRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetVideoTrackFrameRate_ReturnValue_Offset), 0, SetVideoTrackFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetTrackFormat")]
	public unsafe bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!SetTrackFormat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetTrackFormat");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrackFormat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrackFormat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, SetTrackFormat_TrackType_Offset), 0, SetTrackFormat_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTrackFormat_TrackIndex_Offset), 0, SetTrackFormat_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTrackFormat_FormatIndex_Offset), 0, SetTrackFormat_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTrackFormat_FunctionAddress, intPtr, SetTrackFormat_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTrackFormat_ReturnValue_Offset), 0, SetTrackFormat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetTimeDelay")]
	public unsafe void SetTimeDelay(FTimespan TimeDelay)
	{
		CheckDestroyed();
		if (!SetTimeDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetTimeDelay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTimeDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTimeDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimespan.ToNative(IntPtr.Add(intPtr, SetTimeDelay_TimeDelay_Offset), 0, SetTimeDelay_TimeDelay_PropertyAddress.Address, TimeDelay);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTimeDelay_FunctionAddress, intPtr, SetTimeDelay_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetRate")]
	public unsafe bool SetRate(float Rate)
	{
		CheckDestroyed();
		if (!SetRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRate_Rate_Offset), 0, SetRate_Rate_PropertyAddress.Address, Rate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRate_FunctionAddress, intPtr, SetRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRate_ReturnValue_Offset), 0, SetRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetNativeVolume")]
	public unsafe bool SetNativeVolume(float Volume)
	{
		CheckDestroyed();
		if (!SetNativeVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetNativeVolume");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNativeVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNativeVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNativeVolume_Volume_Offset), 0, SetNativeVolume_Volume_PropertyAddress.Address, Volume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNativeVolume_FunctionAddress, intPtr, SetNativeVolume_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNativeVolume_ReturnValue_Offset), 0, SetNativeVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetMediaOptions")]
	public unsafe void SetMediaOptions(UMediaSource Options)
	{
		CheckDestroyed();
		if (!SetMediaOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetMediaOptions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaOptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, SetMediaOptions_Options_Offset), 0, SetMediaOptions_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaOptions_FunctionAddress, intPtr, SetMediaOptions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetLooping")]
	public unsafe bool SetLooping(bool Looping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_Looping_Offset), 0, SetLooping_Looping_PropertyAddress.Address, Looping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLooping_ReturnValue_Offset), 0, SetLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetDesiredPlayerName")]
	public unsafe void SetDesiredPlayerName(FName PlayerName)
	{
		CheckDestroyed();
		if (!SetDesiredPlayerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetDesiredPlayerName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredPlayerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredPlayerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDesiredPlayerName_PlayerName_Offset), 0, SetDesiredPlayerName_PlayerName_PropertyAddress.Address, PlayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredPlayerName_FunctionAddress, intPtr, SetDesiredPlayerName_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SetBlockOnTime")]
	public unsafe void SetBlockOnTime(FTimespan Time)
	{
		CheckDestroyed();
		if (!SetBlockOnTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SetBlockOnTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlockOnTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlockOnTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimespan.ToNative(IntPtr.Add(intPtr, SetBlockOnTime_Time_Offset), 0, SetBlockOnTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlockOnTime_FunctionAddress, intPtr, SetBlockOnTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:SelectTrack")]
	public unsafe bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex)
	{
		CheckDestroyed();
		if (!SelectTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:SelectTrack");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, SelectTrack_TrackType_Offset), 0, SelectTrack_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectTrack_TrackIndex_Offset), 0, SelectTrack_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectTrack_FunctionAddress, intPtr, SelectTrack_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectTrack_ReturnValue_Offset), 0, SelectTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Seek")]
	public unsafe bool Seek(FTimespan Time)
	{
		CheckDestroyed();
		if (!Seek_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Seek");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Seek_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Seek_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimespan.ToNative(IntPtr.Add(intPtr, Seek_Time_Offset), 0, Seek_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeFunctionOptimized(base.Address, Seek_FunctionAddress, intPtr, Seek_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Seek_ReturnValue_Offset), 0, Seek_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Rewind")]
	public unsafe bool Rewind()
	{
		CheckDestroyed();
		if (!Rewind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Rewind");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Rewind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Rewind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Rewind_FunctionAddress, intPtr, Rewind_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Rewind_ReturnValue_Offset), 0, Rewind_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Reopen")]
	public unsafe bool Reopen()
	{
		CheckDestroyed();
		if (!Reopen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Reopen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reopen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reopen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Reopen_FunctionAddress, intPtr, Reopen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Reopen_ReturnValue_Offset), 0, Reopen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Previous")]
	public unsafe bool Previous()
	{
		CheckDestroyed();
		if (!Previous_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Previous");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Previous_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Previous_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Previous_FunctionAddress, intPtr, Previous_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Previous_ReturnValue_Offset), 0, Previous_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:PlayAndSeek")]
	public unsafe void PlayAndSeek()
	{
		CheckDestroyed();
		if (!PlayAndSeek_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:PlayAndSeek");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAndSeek_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAndSeek_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayAndSeek_FunctionAddress, argsSize: PlayAndSeek_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Play")]
	public unsafe bool Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Play");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Play_FunctionAddress, intPtr, Play_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Play_ReturnValue_Offset), 0, Play_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Pause")]
	public unsafe bool Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Pause");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Pause_FunctionAddress, intPtr, Pause_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Pause_ReturnValue_Offset), 0, Pause_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenUrl")]
	public unsafe bool OpenUrl(string Url)
	{
		CheckDestroyed();
		if (!OpenUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenUrl");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenUrl_Url_Offset), 0, OpenUrl_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenUrl_FunctionAddress, intPtr, OpenUrl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenUrl_Url_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenUrl_ReturnValue_Offset), 0, OpenUrl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenSourceWithOptions")]
	public unsafe bool OpenSourceWithOptions(UMediaSource MediaSource, FMediaPlayerOptions Options)
	{
		CheckDestroyed();
		if (!OpenSourceWithOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenSourceWithOptions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenSourceWithOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenSourceWithOptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, OpenSourceWithOptions_MediaSource_Offset), 0, OpenSourceWithOptions_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InitializeValue_InContainer(OpenSourceWithOptions_Options_PropertyAddress.Address, intPtr);
		FMediaPlayerOptions.ToNative(IntPtr.Add(intPtr, OpenSourceWithOptions_Options_Offset), 0, OpenSourceWithOptions_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenSourceWithOptions_FunctionAddress, intPtr, OpenSourceWithOptions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenSourceWithOptions_ReturnValue_Offset), 0, OpenSourceWithOptions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenSourceLatent")]
	public unsafe void OpenSourceLatent(UObject WorldContextObject, FLatentActionInfo LatentInfo, UMediaSource MediaSource, FMediaPlayerOptions Options, out bool bSuccess)
	{
		CheckDestroyed();
		if (!OpenSourceLatent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenSourceLatent");
			bSuccess = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenSourceLatent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenSourceLatent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OpenSourceLatent_WorldContextObject_Offset), 0, OpenSourceLatent_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(OpenSourceLatent_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, OpenSourceLatent_LatentInfo_Offset), 0, OpenSourceLatent_LatentInfo_PropertyAddress.Address, LatentInfo);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, OpenSourceLatent_MediaSource_Offset), 0, OpenSourceLatent_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InitializeValue_InContainer(OpenSourceLatent_Options_PropertyAddress.Address, intPtr);
		FMediaPlayerOptions.ToNative(IntPtr.Add(intPtr, OpenSourceLatent_Options_Offset), 0, OpenSourceLatent_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenSourceLatent_FunctionAddress, intPtr, OpenSourceLatent_ParamsSize);
		bSuccess = BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenSourceLatent_bSuccess_Offset), 0, OpenSourceLatent_bSuccess_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenSource")]
	public unsafe bool OpenSource(UMediaSource MediaSource)
	{
		CheckDestroyed();
		if (!OpenSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenSource");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, OpenSource_MediaSource_Offset), 0, OpenSource_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenSource_FunctionAddress, intPtr, OpenSource_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenSource_ReturnValue_Offset), 0, OpenSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenPlaylistIndex")]
	public unsafe bool OpenPlaylistIndex(UMediaPlaylist InPlaylist, int Index)
	{
		CheckDestroyed();
		if (!OpenPlaylistIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenPlaylistIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPlaylistIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPlaylistIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlaylist>.ToNative(IntPtr.Add(intPtr, OpenPlaylistIndex_InPlaylist_Offset), 0, OpenPlaylistIndex_InPlaylist_PropertyAddress.Address, InPlaylist);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OpenPlaylistIndex_Index_Offset), 0, OpenPlaylistIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenPlaylistIndex_FunctionAddress, intPtr, OpenPlaylistIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenPlaylistIndex_ReturnValue_Offset), 0, OpenPlaylistIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenPlaylist")]
	public unsafe bool OpenPlaylist(UMediaPlaylist InPlaylist)
	{
		CheckDestroyed();
		if (!OpenPlaylist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenPlaylist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPlaylist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPlaylist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlaylist>.ToNative(IntPtr.Add(intPtr, OpenPlaylist_InPlaylist_Offset), 0, OpenPlaylist_InPlaylist_PropertyAddress.Address, InPlaylist);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenPlaylist_FunctionAddress, intPtr, OpenPlaylist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenPlaylist_ReturnValue_Offset), 0, OpenPlaylist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:OpenFile")]
	public unsafe bool OpenFile(string FilePath)
	{
		CheckDestroyed();
		if (!OpenFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:OpenFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFile_FilePath_Offset), 0, OpenFile_FilePath_PropertyAddress.Address, FilePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenFile_FunctionAddress, intPtr, OpenFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenFile_FilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenFile_ReturnValue_Offset), 0, OpenFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Next")]
	public unsafe bool Next()
	{
		CheckDestroyed();
		if (!Next_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Next");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Next_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Next_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Next_FunctionAddress, intPtr, Next_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Next_ReturnValue_Offset), 0, Next_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsReady")]
	public unsafe bool IsReady()
	{
		CheckDestroyed();
		if (!IsReady_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsReady");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReady_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReady_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReady_FunctionAddress, intPtr, IsReady_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReady_ReturnValue_Offset), 0, IsReady_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsPreparing")]
	public unsafe bool IsPreparing()
	{
		CheckDestroyed();
		if (!IsPreparing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsPreparing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPreparing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPreparing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPreparing_FunctionAddress, intPtr, IsPreparing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPreparing_ReturnValue_Offset), 0, IsPreparing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsPaused")]
	public unsafe bool IsPaused()
	{
		CheckDestroyed();
		if (!IsPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPaused_FunctionAddress, intPtr, IsPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPaused_ReturnValue_Offset), 0, IsPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsConnecting")]
	public unsafe bool IsConnecting()
	{
		CheckDestroyed();
		if (!IsConnecting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsConnecting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsConnecting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsConnecting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsConnecting_FunctionAddress, intPtr, IsConnecting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsConnecting_ReturnValue_Offset), 0, IsConnecting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsClosed")]
	public unsafe bool IsClosed()
	{
		CheckDestroyed();
		if (!IsClosed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsClosed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsClosed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsClosed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsClosed_FunctionAddress, intPtr, IsClosed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsClosed_ReturnValue_Offset), 0, IsClosed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:IsBuffering")]
	public unsafe bool IsBuffering()
	{
		CheckDestroyed();
		if (!IsBuffering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:IsBuffering");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBuffering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBuffering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBuffering_FunctionAddress, intPtr, IsBuffering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBuffering_ReturnValue_Offset), 0, IsBuffering_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:HasError")]
	public unsafe bool HasError()
	{
		CheckDestroyed();
		if (!HasError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:HasError");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasError_FunctionAddress, intPtr, HasError_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasError_ReturnValue_Offset), 0, HasError_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetViewRotation")]
	public unsafe FRotator GetViewRotation()
	{
		CheckDestroyed();
		if (!GetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetViewRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRotation_FunctionAddress, intPtr, GetViewRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetViewRotation_ReturnValue_Offset), 0, GetViewRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVideoTrackType")]
	public unsafe string GetVideoTrackType(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetVideoTrackType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVideoTrackType");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVideoTrackType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVideoTrackType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackType_TrackIndex_Offset), 0, GetVideoTrackType_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackType_FormatIndex_Offset), 0, GetVideoTrackType_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVideoTrackType_FunctionAddress, intPtr, GetVideoTrackType_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetVideoTrackType_ReturnValue_Offset), 0, GetVideoTrackType_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetVideoTrackType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRates")]
	public unsafe FFloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetVideoTrackFrameRates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRates");
			return default(FFloatRange);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVideoTrackFrameRates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVideoTrackFrameRates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackFrameRates_TrackIndex_Offset), 0, GetVideoTrackFrameRates_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackFrameRates_FormatIndex_Offset), 0, GetVideoTrackFrameRates_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVideoTrackFrameRates_FunctionAddress, intPtr, GetVideoTrackFrameRates_ParamsSize);
		return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(intPtr, GetVideoTrackFrameRates_ReturnValue_Offset), 0, GetVideoTrackFrameRates_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRate")]
	public unsafe float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetVideoTrackFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVideoTrackFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVideoTrackFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackFrameRate_TrackIndex_Offset), 0, GetVideoTrackFrameRate_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackFrameRate_FormatIndex_Offset), 0, GetVideoTrackFrameRate_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVideoTrackFrameRate_FunctionAddress, intPtr, GetVideoTrackFrameRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVideoTrackFrameRate_ReturnValue_Offset), 0, GetVideoTrackFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVideoTrackDimensions")]
	public unsafe FIntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetVideoTrackDimensions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVideoTrackDimensions");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVideoTrackDimensions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVideoTrackDimensions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackDimensions_TrackIndex_Offset), 0, GetVideoTrackDimensions_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackDimensions_FormatIndex_Offset), 0, GetVideoTrackDimensions_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVideoTrackDimensions_FunctionAddress, intPtr, GetVideoTrackDimensions_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetVideoTrackDimensions_ReturnValue_Offset), 0, GetVideoTrackDimensions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVideoTrackAspectRatio")]
	public unsafe float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetVideoTrackAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVideoTrackAspectRatio");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVideoTrackAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVideoTrackAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackAspectRatio_TrackIndex_Offset), 0, GetVideoTrackAspectRatio_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVideoTrackAspectRatio_FormatIndex_Offset), 0, GetVideoTrackAspectRatio_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVideoTrackAspectRatio_FunctionAddress, intPtr, GetVideoTrackAspectRatio_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVideoTrackAspectRatio_ReturnValue_Offset), 0, GetVideoTrackAspectRatio_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetVerticalFieldOfView")]
	public unsafe float GetVerticalFieldOfView()
	{
		CheckDestroyed();
		if (!GetVerticalFieldOfView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetVerticalFieldOfView");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVerticalFieldOfView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVerticalFieldOfView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVerticalFieldOfView_FunctionAddress, intPtr, GetVerticalFieldOfView_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVerticalFieldOfView_ReturnValue_Offset), 0, GetVerticalFieldOfView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetUrl")]
	public unsafe string GetUrl()
	{
		CheckDestroyed();
		if (!GetUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetUrl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUrl_FunctionAddress, intPtr, GetUrl_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUrl_ReturnValue_Offset), 0, GetUrl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUrl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTrackLanguage")]
	public unsafe string GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex)
	{
		CheckDestroyed();
		if (!GetTrackLanguage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTrackLanguage");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackLanguage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackLanguage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetTrackLanguage_TrackType_Offset), 0, GetTrackLanguage_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrackLanguage_TrackIndex_Offset), 0, GetTrackLanguage_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTrackLanguage_FunctionAddress, intPtr, GetTrackLanguage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTrackLanguage_ReturnValue_Offset), 0, GetTrackLanguage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTrackLanguage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTrackFormat")]
	public unsafe int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex)
	{
		CheckDestroyed();
		if (!GetTrackFormat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTrackFormat");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackFormat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackFormat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetTrackFormat_TrackType_Offset), 0, GetTrackFormat_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrackFormat_TrackIndex_Offset), 0, GetTrackFormat_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTrackFormat_FunctionAddress, intPtr, GetTrackFormat_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTrackFormat_ReturnValue_Offset), 0, GetTrackFormat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTrackDisplayName")]
	public unsafe string GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex)
	{
		CheckDestroyed();
		if (!GetTrackDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTrackDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetTrackDisplayName_TrackType_Offset), 0, GetTrackDisplayName_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrackDisplayName_TrackIndex_Offset), 0, GetTrackDisplayName_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTrackDisplayName_FunctionAddress, intPtr, GetTrackDisplayName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTrackDisplayName_ReturnValue_Offset), 0, GetTrackDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTrackDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTimeStamp")]
	public unsafe UMediaTimeStampInfo GetTimeStamp()
	{
		CheckDestroyed();
		if (!GetTimeStamp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTimeStamp");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeStamp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeStamp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimeStamp_FunctionAddress, intPtr, GetTimeStamp_ParamsSize);
		return UObjectMarshaler<UMediaTimeStampInfo>.FromNative(IntPtr.Add(intPtr, GetTimeStamp_ReturnValue_Offset), 0, GetTimeStamp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTimeDelay")]
	public unsafe FTimespan GetTimeDelay()
	{
		CheckDestroyed();
		if (!GetTimeDelay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTimeDelay");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeDelay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeDelay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimeDelay_FunctionAddress, intPtr, GetTimeDelay_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetTimeDelay_ReturnValue_Offset), 0, GetTimeDelay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetTime")]
	public unsafe FTimespan GetTime()
	{
		CheckDestroyed();
		if (!GetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetTime");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTime_FunctionAddress, intPtr, GetTime_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetTime_ReturnValue_Offset), 0, GetTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetSupportedRates")]
	public unsafe void GetSupportedRates(out List<FFloatRange> OutRates, bool Unthinned)
	{
		CheckDestroyed();
		if (!GetSupportedRates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetSupportedRates");
			OutRates = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedRates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedRates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSupportedRates_Unthinned_Offset), 0, GetSupportedRates_Unthinned_PropertyAddress.Address, Unthinned);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSupportedRates_FunctionAddress, intPtr, GetSupportedRates_ParamsSize);
		OutRates = new TArrayCopyMarshaler<FFloatRange>(1, GetSupportedRates_OutRates_PropertyAddress, CachedMarshalingDelegates<FFloatRange, BlittableTypeMarshaler<FFloatRange>>.FromNative, CachedMarshalingDelegates<FFloatRange, BlittableTypeMarshaler<FFloatRange>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportedRates_OutRates_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportedRates_OutRates_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetSelectedTrack")]
	public unsafe int GetSelectedTrack(EMediaPlayerTrack TrackType)
	{
		CheckDestroyed();
		if (!GetSelectedTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetSelectedTrack");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetSelectedTrack_TrackType_Offset), 0, GetSelectedTrack_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedTrack_FunctionAddress, intPtr, GetSelectedTrack_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectedTrack_ReturnValue_Offset), 0, GetSelectedTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetRate")]
	public unsafe float GetRate()
	{
		CheckDestroyed();
		if (!GetRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRate_FunctionAddress, intPtr, GetRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRate_ReturnValue_Offset), 0, GetRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetPlaylistIndex")]
	public unsafe int GetPlaylistIndex()
	{
		CheckDestroyed();
		if (!GetPlaylistIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetPlaylistIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaylistIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaylistIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaylistIndex_FunctionAddress, intPtr, GetPlaylistIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPlaylistIndex_ReturnValue_Offset), 0, GetPlaylistIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetPlaylist")]
	public unsafe UMediaPlaylist GetPlaylist()
	{
		CheckDestroyed();
		if (!GetPlaylist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetPlaylist");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaylist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaylist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaylist_FunctionAddress, intPtr, GetPlaylist_ParamsSize);
		return UObjectMarshaler<UMediaPlaylist>.FromNative(IntPtr.Add(intPtr, GetPlaylist_ReturnValue_Offset), 0, GetPlaylist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetPlayerName")]
	public unsafe FName GetPlayerName()
	{
		CheckDestroyed();
		if (!GetPlayerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetPlayerName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerName_FunctionAddress, intPtr, GetPlayerName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPlayerName_ReturnValue_Offset), 0, GetPlayerName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetNumTracks")]
	public unsafe int GetNumTracks(EMediaPlayerTrack TrackType)
	{
		CheckDestroyed();
		if (!GetNumTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetNumTracks");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetNumTracks_TrackType_Offset), 0, GetNumTracks_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumTracks_FunctionAddress, intPtr, GetNumTracks_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTracks_ReturnValue_Offset), 0, GetNumTracks_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetNumTrackFormats")]
	public unsafe int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex)
	{
		CheckDestroyed();
		if (!GetNumTrackFormats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetNumTrackFormats");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTrackFormats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTrackFormats_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMediaPlayerTrack>.ToNative(IntPtr.Add(intPtr, GetNumTrackFormats_TrackType_Offset), 0, GetNumTrackFormats_TrackType_PropertyAddress.Address, TrackType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumTrackFormats_TrackIndex_Offset), 0, GetNumTrackFormats_TrackIndex_PropertyAddress.Address, TrackIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumTrackFormats_FunctionAddress, intPtr, GetNumTrackFormats_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTrackFormats_ReturnValue_Offset), 0, GetNumTrackFormats_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetMediaName")]
	public unsafe string GetMediaName()
	{
		CheckDestroyed();
		if (!GetMediaName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetMediaName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaName_FunctionAddress, intPtr, GetMediaName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetMediaName_ReturnValue_Offset), 0, GetMediaName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetMediaName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetHorizontalFieldOfView")]
	public unsafe float GetHorizontalFieldOfView()
	{
		CheckDestroyed();
		if (!GetHorizontalFieldOfView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetHorizontalFieldOfView");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHorizontalFieldOfView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHorizontalFieldOfView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHorizontalFieldOfView_FunctionAddress, intPtr, GetHorizontalFieldOfView_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetHorizontalFieldOfView_ReturnValue_Offset), 0, GetHorizontalFieldOfView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetDuration")]
	public unsafe FTimespan GetDuration()
	{
		CheckDestroyed();
		if (!GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetDuration");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDuration_FunctionAddress, intPtr, GetDuration_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetDuration_ReturnValue_Offset), 0, GetDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetDesiredPlayerName")]
	public unsafe FName GetDesiredPlayerName()
	{
		CheckDestroyed();
		if (!GetDesiredPlayerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetDesiredPlayerName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredPlayerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredPlayerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredPlayerName_FunctionAddress, intPtr, GetDesiredPlayerName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetDesiredPlayerName_ReturnValue_Offset), 0, GetDesiredPlayerName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetAudioTrackType")]
	public unsafe string GetAudioTrackType(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetAudioTrackType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetAudioTrackType");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioTrackType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioTrackType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackType_TrackIndex_Offset), 0, GetAudioTrackType_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackType_FormatIndex_Offset), 0, GetAudioTrackType_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioTrackType_FunctionAddress, intPtr, GetAudioTrackType_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAudioTrackType_ReturnValue_Offset), 0, GetAudioTrackType_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAudioTrackType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetAudioTrackSampleRate")]
	public unsafe int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetAudioTrackSampleRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetAudioTrackSampleRate");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioTrackSampleRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioTrackSampleRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackSampleRate_TrackIndex_Offset), 0, GetAudioTrackSampleRate_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackSampleRate_FormatIndex_Offset), 0, GetAudioTrackSampleRate_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioTrackSampleRate_FunctionAddress, intPtr, GetAudioTrackSampleRate_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAudioTrackSampleRate_ReturnValue_Offset), 0, GetAudioTrackSampleRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:GetAudioTrackChannels")]
	public unsafe int GetAudioTrackChannels(int TrackIndex, int FormatIndex)
	{
		CheckDestroyed();
		if (!GetAudioTrackChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:GetAudioTrackChannels");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioTrackChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioTrackChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackChannels_TrackIndex_Offset), 0, GetAudioTrackChannels_TrackIndex_PropertyAddress.Address, TrackIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAudioTrackChannels_FormatIndex_Offset), 0, GetAudioTrackChannels_FormatIndex_PropertyAddress.Address, FormatIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioTrackChannels_FunctionAddress, intPtr, GetAudioTrackChannels_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAudioTrackChannels_ReturnValue_Offset), 0, GetAudioTrackChannels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:Close")]
	public unsafe void Close()
	{
		CheckDestroyed();
		if (!Close_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:Close");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Close_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Close_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Close_FunctionAddress, argsSize: Close_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CanPlayUrl")]
	public unsafe bool CanPlayUrl(string Url)
	{
		CheckDestroyed();
		if (!CanPlayUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:CanPlayUrl");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanPlayUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanPlayUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CanPlayUrl_Url_Offset), 0, CanPlayUrl_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanPlayUrl_FunctionAddress, intPtr, CanPlayUrl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanPlayUrl_Url_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanPlayUrl_ReturnValue_Offset), 0, CanPlayUrl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CanPlaySource")]
	public unsafe bool CanPlaySource(UMediaSource MediaSource)
	{
		CheckDestroyed();
		if (!CanPlaySource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:CanPlaySource");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanPlaySource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanPlaySource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, CanPlaySource_MediaSource_Offset), 0, CanPlaySource_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanPlaySource_FunctionAddress, intPtr, CanPlaySource_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanPlaySource_ReturnValue_Offset), 0, CanPlaySource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaPlayer:CanPause")]
	public unsafe bool CanPause()
	{
		CheckDestroyed();
		if (!CanPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlayer:CanPause");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanPause_FunctionAddress, intPtr, CanPause_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanPause_ReturnValue_Offset), 0, CanPause_ReturnValue_PropertyAddress.Address);
	}

	static UMediaPlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaPlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MediaAssets.MediaPlayer");
		OnEndReached_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEndReached");
		OnEndReached_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEndReached", Classes.FMulticastDelegateProperty);
		OnMediaClosed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaClosed");
		OnMediaClosed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaClosed", Classes.FMulticastDelegateProperty);
		OnMediaOpened_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaOpened");
		OnMediaOpened_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaOpened", Classes.FMulticastDelegateProperty);
		OnMediaOpenFailed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaOpenFailed");
		OnMediaOpenFailed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaOpenFailed", Classes.FMulticastDelegateProperty);
		OnPlaybackResumed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlaybackResumed");
		OnPlaybackResumed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlaybackResumed", Classes.FMulticastDelegateProperty);
		OnPlaybackSuspended_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlaybackSuspended");
		OnPlaybackSuspended_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlaybackSuspended", Classes.FMulticastDelegateProperty);
		OnSeekCompleted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSeekCompleted");
		OnSeekCompleted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSeekCompleted", Classes.FMulticastDelegateProperty);
		OnTracksChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTracksChanged");
		OnTracksChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTracksChanged", Classes.FMulticastDelegateProperty);
		CacheAhead_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CacheAhead");
		CacheAhead_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CacheAhead", Classes.FStructProperty);
		CacheBehind_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CacheBehind");
		CacheBehind_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CacheBehind", Classes.FStructProperty);
		CacheBehindGame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CacheBehindGame");
		CacheBehindGame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CacheBehindGame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NativeAudioOut_PropertyAddress, intPtr, "NativeAudioOut");
		NativeAudioOut_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NativeAudioOut");
		NativeAudioOut_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NativeAudioOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayOnOpen_PropertyAddress, intPtr, "PlayOnOpen");
		PlayOnOpen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayOnOpen");
		PlayOnOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayOnOpen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Shuffle_PropertyAddress, intPtr, "Shuffle");
		Shuffle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shuffle");
		Shuffle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shuffle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "Loop");
		Loop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Loop", Classes.FBoolProperty);
		Playlist_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Playlist");
		Playlist_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Playlist", Classes.FObjectProperty);
		PlaylistIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaylistIndex");
		PlaylistIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaylistIndex", Classes.FIntProperty);
		TimeDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeDelay");
		TimeDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeDelay", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectedByPIEHandling_PropertyAddress, intPtr, "AffectedByPIEHandling");
		AffectedByPIEHandling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AffectedByPIEHandling");
		AffectedByPIEHandling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AffectedByPIEHandling", Classes.FBoolProperty);
		SupportsSeeking_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsSeeking");
		SupportsSeeking_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsSeeking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsSeeking_ReturnValue_PropertyAddress, SupportsSeeking_FunctionAddress, "ReturnValue");
		SupportsSeeking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsSeeking_FunctionAddress, "ReturnValue");
		SupportsSeeking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsSeeking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsSeeking_IsValid = SupportsSeeking_FunctionAddress != IntPtr.Zero && SupportsSeeking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SupportsSeeking", SupportsSeeking_IsValid);
		SupportsScrubbing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsScrubbing");
		SupportsScrubbing_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsScrubbing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsScrubbing_ReturnValue_PropertyAddress, SupportsScrubbing_FunctionAddress, "ReturnValue");
		SupportsScrubbing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsScrubbing_FunctionAddress, "ReturnValue");
		SupportsScrubbing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsScrubbing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsScrubbing_IsValid = SupportsScrubbing_FunctionAddress != IntPtr.Zero && SupportsScrubbing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SupportsScrubbing", SupportsScrubbing_IsValid);
		SupportsRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsRate");
		SupportsRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_Rate_PropertyAddress, SupportsRate_FunctionAddress, "Rate");
		SupportsRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "Rate");
		SupportsRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_Unthinned_PropertyAddress, SupportsRate_FunctionAddress, "Unthinned");
		SupportsRate_Unthinned_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "Unthinned");
		SupportsRate_Unthinned_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "Unthinned", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_ReturnValue_PropertyAddress, SupportsRate_FunctionAddress, "ReturnValue");
		SupportsRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "ReturnValue");
		SupportsRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsRate_IsValid = SupportsRate_FunctionAddress != IntPtr.Zero && SupportsRate_Rate_IsValid && SupportsRate_Unthinned_IsValid && SupportsRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SupportsRate", SupportsRate_IsValid);
		SetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewRotation");
		SetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_Rotation_PropertyAddress, SetViewRotation_FunctionAddress, "Rotation");
		SetViewRotation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "Rotation");
		SetViewRotation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_Absolute_PropertyAddress, SetViewRotation_FunctionAddress, "Absolute");
		SetViewRotation_Absolute_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "Absolute");
		SetViewRotation_Absolute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "Absolute", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_ReturnValue_PropertyAddress, SetViewRotation_FunctionAddress, "ReturnValue");
		SetViewRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "ReturnValue");
		SetViewRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetViewRotation_IsValid = SetViewRotation_FunctionAddress != IntPtr.Zero && SetViewRotation_Rotation_IsValid && SetViewRotation_Absolute_IsValid && SetViewRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetViewRotation", SetViewRotation_IsValid);
		SetViewField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewField");
		SetViewField_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewField_Horizontal_PropertyAddress, SetViewField_FunctionAddress, "Horizontal");
		SetViewField_Horizontal_Offset = NativeReflectionCached.GetPropertyOffset(SetViewField_FunctionAddress, "Horizontal");
		SetViewField_Horizontal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewField_FunctionAddress, "Horizontal", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewField_Vertical_PropertyAddress, SetViewField_FunctionAddress, "Vertical");
		SetViewField_Vertical_Offset = NativeReflectionCached.GetPropertyOffset(SetViewField_FunctionAddress, "Vertical");
		SetViewField_Vertical_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewField_FunctionAddress, "Vertical", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewField_Absolute_PropertyAddress, SetViewField_FunctionAddress, "Absolute");
		SetViewField_Absolute_Offset = NativeReflectionCached.GetPropertyOffset(SetViewField_FunctionAddress, "Absolute");
		SetViewField_Absolute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewField_FunctionAddress, "Absolute", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewField_ReturnValue_PropertyAddress, SetViewField_FunctionAddress, "ReturnValue");
		SetViewField_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetViewField_FunctionAddress, "ReturnValue");
		SetViewField_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewField_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetViewField_IsValid = SetViewField_FunctionAddress != IntPtr.Zero && SetViewField_Horizontal_IsValid && SetViewField_Vertical_IsValid && SetViewField_Absolute_IsValid && SetViewField_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetViewField", SetViewField_IsValid);
		SetVideoTrackFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVideoTrackFrameRate");
		SetVideoTrackFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVideoTrackFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVideoTrackFrameRate_TrackIndex_PropertyAddress, SetVideoTrackFrameRate_FunctionAddress, "TrackIndex");
		SetVideoTrackFrameRate_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetVideoTrackFrameRate_FunctionAddress, "TrackIndex");
		SetVideoTrackFrameRate_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVideoTrackFrameRate_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVideoTrackFrameRate_FormatIndex_PropertyAddress, SetVideoTrackFrameRate_FunctionAddress, "FormatIndex");
		SetVideoTrackFrameRate_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetVideoTrackFrameRate_FunctionAddress, "FormatIndex");
		SetVideoTrackFrameRate_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVideoTrackFrameRate_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVideoTrackFrameRate_FrameRate_PropertyAddress, SetVideoTrackFrameRate_FunctionAddress, "FrameRate");
		SetVideoTrackFrameRate_FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(SetVideoTrackFrameRate_FunctionAddress, "FrameRate");
		SetVideoTrackFrameRate_FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVideoTrackFrameRate_FunctionAddress, "FrameRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVideoTrackFrameRate_ReturnValue_PropertyAddress, SetVideoTrackFrameRate_FunctionAddress, "ReturnValue");
		SetVideoTrackFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVideoTrackFrameRate_FunctionAddress, "ReturnValue");
		SetVideoTrackFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVideoTrackFrameRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetVideoTrackFrameRate_IsValid = SetVideoTrackFrameRate_FunctionAddress != IntPtr.Zero && SetVideoTrackFrameRate_TrackIndex_IsValid && SetVideoTrackFrameRate_FormatIndex_IsValid && SetVideoTrackFrameRate_FrameRate_IsValid && SetVideoTrackFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetVideoTrackFrameRate", SetVideoTrackFrameRate_IsValid);
		SetTrackFormat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTrackFormat");
		SetTrackFormat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrackFormat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFormat_TrackType_PropertyAddress, SetTrackFormat_FunctionAddress, "TrackType");
		SetTrackFormat_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFormat_FunctionAddress, "TrackType");
		SetTrackFormat_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFormat_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFormat_TrackIndex_PropertyAddress, SetTrackFormat_FunctionAddress, "TrackIndex");
		SetTrackFormat_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFormat_FunctionAddress, "TrackIndex");
		SetTrackFormat_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFormat_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFormat_FormatIndex_PropertyAddress, SetTrackFormat_FunctionAddress, "FormatIndex");
		SetTrackFormat_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFormat_FunctionAddress, "FormatIndex");
		SetTrackFormat_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFormat_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackFormat_ReturnValue_PropertyAddress, SetTrackFormat_FunctionAddress, "ReturnValue");
		SetTrackFormat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackFormat_FunctionAddress, "ReturnValue");
		SetTrackFormat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackFormat_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTrackFormat_IsValid = SetTrackFormat_FunctionAddress != IntPtr.Zero && SetTrackFormat_TrackType_IsValid && SetTrackFormat_TrackIndex_IsValid && SetTrackFormat_FormatIndex_IsValid && SetTrackFormat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetTrackFormat", SetTrackFormat_IsValid);
		SetTimeDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTimeDelay");
		SetTimeDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTimeDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTimeDelay_TimeDelay_PropertyAddress, SetTimeDelay_FunctionAddress, "TimeDelay");
		SetTimeDelay_TimeDelay_Offset = NativeReflectionCached.GetPropertyOffset(SetTimeDelay_FunctionAddress, "TimeDelay");
		SetTimeDelay_TimeDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimeDelay_FunctionAddress, "TimeDelay", Classes.FStructProperty);
		SetTimeDelay_IsValid = SetTimeDelay_FunctionAddress != IntPtr.Zero && SetTimeDelay_TimeDelay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetTimeDelay", SetTimeDelay_IsValid);
		SetRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRate");
		SetRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRate_Rate_PropertyAddress, SetRate_FunctionAddress, "Rate");
		SetRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(SetRate_FunctionAddress, "Rate");
		SetRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRate_ReturnValue_PropertyAddress, SetRate_FunctionAddress, "ReturnValue");
		SetRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRate_FunctionAddress, "ReturnValue");
		SetRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRate_IsValid = SetRate_FunctionAddress != IntPtr.Zero && SetRate_Rate_IsValid && SetRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetRate", SetRate_IsValid);
		SetNativeVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNativeVolume");
		SetNativeVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNativeVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNativeVolume_Volume_PropertyAddress, SetNativeVolume_FunctionAddress, "Volume");
		SetNativeVolume_Volume_Offset = NativeReflectionCached.GetPropertyOffset(SetNativeVolume_FunctionAddress, "Volume");
		SetNativeVolume_Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNativeVolume_FunctionAddress, "Volume", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNativeVolume_ReturnValue_PropertyAddress, SetNativeVolume_FunctionAddress, "ReturnValue");
		SetNativeVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNativeVolume_FunctionAddress, "ReturnValue");
		SetNativeVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNativeVolume_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNativeVolume_IsValid = SetNativeVolume_FunctionAddress != IntPtr.Zero && SetNativeVolume_Volume_IsValid && SetNativeVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetNativeVolume", SetNativeVolume_IsValid);
		SetMediaOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMediaOptions");
		SetMediaOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaOptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptions_Options_PropertyAddress, SetMediaOptions_FunctionAddress, "Options");
		SetMediaOptions_Options_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptions_FunctionAddress, "Options");
		SetMediaOptions_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptions_FunctionAddress, "Options", Classes.FObjectProperty);
		SetMediaOptions_IsValid = SetMediaOptions_FunctionAddress != IntPtr.Zero && SetMediaOptions_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetMediaOptions", SetMediaOptions_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_Looping_PropertyAddress, SetLooping_FunctionAddress, "Looping");
		SetLooping_Looping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "Looping");
		SetLooping_Looping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "Looping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_ReturnValue_PropertyAddress, SetLooping_FunctionAddress, "ReturnValue");
		SetLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "ReturnValue");
		SetLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_Looping_IsValid && SetLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetLooping", SetLooping_IsValid);
		SetDesiredPlayerName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDesiredPlayerName");
		SetDesiredPlayerName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredPlayerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredPlayerName_PlayerName_PropertyAddress, SetDesiredPlayerName_FunctionAddress, "PlayerName");
		SetDesiredPlayerName_PlayerName_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredPlayerName_FunctionAddress, "PlayerName");
		SetDesiredPlayerName_PlayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredPlayerName_FunctionAddress, "PlayerName", Classes.FNameProperty);
		SetDesiredPlayerName_IsValid = SetDesiredPlayerName_FunctionAddress != IntPtr.Zero && SetDesiredPlayerName_PlayerName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetDesiredPlayerName", SetDesiredPlayerName_IsValid);
		SetBlockOnTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBlockOnTime");
		SetBlockOnTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlockOnTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlockOnTime_Time_PropertyAddress, SetBlockOnTime_FunctionAddress, "Time");
		SetBlockOnTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetBlockOnTime_FunctionAddress, "Time");
		SetBlockOnTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlockOnTime_FunctionAddress, "Time", Classes.FStructProperty);
		SetBlockOnTime_IsValid = SetBlockOnTime_FunctionAddress != IntPtr.Zero && SetBlockOnTime_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SetBlockOnTime", SetBlockOnTime_IsValid);
		SelectTrack_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectTrack");
		SelectTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectTrack_TrackType_PropertyAddress, SelectTrack_FunctionAddress, "TrackType");
		SelectTrack_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(SelectTrack_FunctionAddress, "TrackType");
		SelectTrack_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectTrack_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectTrack_TrackIndex_PropertyAddress, SelectTrack_FunctionAddress, "TrackIndex");
		SelectTrack_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(SelectTrack_FunctionAddress, "TrackIndex");
		SelectTrack_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectTrack_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectTrack_ReturnValue_PropertyAddress, SelectTrack_FunctionAddress, "ReturnValue");
		SelectTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectTrack_FunctionAddress, "ReturnValue");
		SelectTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectTrack_IsValid = SelectTrack_FunctionAddress != IntPtr.Zero && SelectTrack_TrackType_IsValid && SelectTrack_TrackIndex_IsValid && SelectTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:SelectTrack", SelectTrack_IsValid);
		Seek_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Seek");
		Seek_ParamsSize = NativeReflection.GetFunctionParamsSize(Seek_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Seek_Time_PropertyAddress, Seek_FunctionAddress, "Time");
		Seek_Time_Offset = NativeReflectionCached.GetPropertyOffset(Seek_FunctionAddress, "Time");
		Seek_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(Seek_FunctionAddress, "Time", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Seek_ReturnValue_PropertyAddress, Seek_FunctionAddress, "ReturnValue");
		Seek_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Seek_FunctionAddress, "ReturnValue");
		Seek_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Seek_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Seek_IsValid = Seek_FunctionAddress != IntPtr.Zero && Seek_Time_IsValid && Seek_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Seek", Seek_IsValid);
		Rewind_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Rewind");
		Rewind_ParamsSize = NativeReflection.GetFunctionParamsSize(Rewind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Rewind_ReturnValue_PropertyAddress, Rewind_FunctionAddress, "ReturnValue");
		Rewind_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Rewind_FunctionAddress, "ReturnValue");
		Rewind_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Rewind_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Rewind_IsValid = Rewind_FunctionAddress != IntPtr.Zero && Rewind_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Rewind", Rewind_IsValid);
		Reopen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reopen");
		Reopen_ParamsSize = NativeReflection.GetFunctionParamsSize(Reopen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Reopen_ReturnValue_PropertyAddress, Reopen_FunctionAddress, "ReturnValue");
		Reopen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Reopen_FunctionAddress, "ReturnValue");
		Reopen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Reopen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Reopen_IsValid = Reopen_FunctionAddress != IntPtr.Zero && Reopen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Reopen", Reopen_IsValid);
		Previous_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Previous");
		Previous_ParamsSize = NativeReflection.GetFunctionParamsSize(Previous_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Previous_ReturnValue_PropertyAddress, Previous_FunctionAddress, "ReturnValue");
		Previous_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Previous_FunctionAddress, "ReturnValue");
		Previous_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Previous_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Previous_IsValid = Previous_FunctionAddress != IntPtr.Zero && Previous_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Previous", Previous_IsValid);
		PlayAndSeek_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAndSeek");
		PlayAndSeek_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAndSeek_FunctionAddress);
		PlayAndSeek_IsValid = PlayAndSeek_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:PlayAndSeek", PlayAndSeek_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Play_ReturnValue_PropertyAddress, Play_FunctionAddress, "ReturnValue");
		Play_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Play_FunctionAddress, "ReturnValue");
		Play_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Play_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero && Play_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Pause_ReturnValue_PropertyAddress, Pause_FunctionAddress, "ReturnValue");
		Pause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Pause_FunctionAddress, "ReturnValue");
		Pause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Pause_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero && Pause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Pause", Pause_IsValid);
		OpenUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenUrl");
		OpenUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenUrl_Url_PropertyAddress, OpenUrl_FunctionAddress, "Url");
		OpenUrl_Url_Offset = NativeReflectionCached.GetPropertyOffset(OpenUrl_FunctionAddress, "Url");
		OpenUrl_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUrl_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenUrl_ReturnValue_PropertyAddress, OpenUrl_FunctionAddress, "ReturnValue");
		OpenUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenUrl_FunctionAddress, "ReturnValue");
		OpenUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUrl_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenUrl_IsValid = OpenUrl_FunctionAddress != IntPtr.Zero && OpenUrl_Url_IsValid && OpenUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenUrl", OpenUrl_IsValid);
		OpenSourceWithOptions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenSourceWithOptions");
		OpenSourceWithOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenSourceWithOptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceWithOptions_MediaSource_PropertyAddress, OpenSourceWithOptions_FunctionAddress, "MediaSource");
		OpenSourceWithOptions_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceWithOptions_FunctionAddress, "MediaSource");
		OpenSourceWithOptions_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceWithOptions_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceWithOptions_Options_PropertyAddress, OpenSourceWithOptions_FunctionAddress, "Options");
		OpenSourceWithOptions_Options_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceWithOptions_FunctionAddress, "Options");
		OpenSourceWithOptions_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceWithOptions_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceWithOptions_ReturnValue_PropertyAddress, OpenSourceWithOptions_FunctionAddress, "ReturnValue");
		OpenSourceWithOptions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceWithOptions_FunctionAddress, "ReturnValue");
		OpenSourceWithOptions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceWithOptions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenSourceWithOptions_IsValid = OpenSourceWithOptions_FunctionAddress != IntPtr.Zero && OpenSourceWithOptions_MediaSource_IsValid && OpenSourceWithOptions_Options_IsValid && OpenSourceWithOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenSourceWithOptions", OpenSourceWithOptions_IsValid);
		OpenSourceLatent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenSourceLatent");
		OpenSourceLatent_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenSourceLatent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceLatent_WorldContextObject_PropertyAddress, OpenSourceLatent_FunctionAddress, "WorldContextObject");
		OpenSourceLatent_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceLatent_FunctionAddress, "WorldContextObject");
		OpenSourceLatent_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceLatent_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceLatent_LatentInfo_PropertyAddress, OpenSourceLatent_FunctionAddress, "LatentInfo");
		OpenSourceLatent_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceLatent_FunctionAddress, "LatentInfo");
		OpenSourceLatent_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceLatent_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceLatent_MediaSource_PropertyAddress, OpenSourceLatent_FunctionAddress, "MediaSource");
		OpenSourceLatent_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceLatent_FunctionAddress, "MediaSource");
		OpenSourceLatent_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceLatent_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceLatent_Options_PropertyAddress, OpenSourceLatent_FunctionAddress, "Options");
		OpenSourceLatent_Options_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceLatent_FunctionAddress, "Options");
		OpenSourceLatent_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceLatent_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceLatent_bSuccess_PropertyAddress, OpenSourceLatent_FunctionAddress, "bSuccess");
		OpenSourceLatent_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceLatent_FunctionAddress, "bSuccess");
		OpenSourceLatent_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceLatent_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		OpenSourceLatent_IsValid = OpenSourceLatent_FunctionAddress != IntPtr.Zero && OpenSourceLatent_WorldContextObject_IsValid && OpenSourceLatent_LatentInfo_IsValid && OpenSourceLatent_MediaSource_IsValid && OpenSourceLatent_Options_IsValid && OpenSourceLatent_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenSourceLatent", OpenSourceLatent_IsValid);
		OpenSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenSource");
		OpenSource_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenSource_MediaSource_PropertyAddress, OpenSource_FunctionAddress, "MediaSource");
		OpenSource_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(OpenSource_FunctionAddress, "MediaSource");
		OpenSource_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSource_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSource_ReturnValue_PropertyAddress, OpenSource_FunctionAddress, "ReturnValue");
		OpenSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenSource_FunctionAddress, "ReturnValue");
		OpenSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSource_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenSource_IsValid = OpenSource_FunctionAddress != IntPtr.Zero && OpenSource_MediaSource_IsValid && OpenSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenSource", OpenSource_IsValid);
		OpenPlaylistIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenPlaylistIndex");
		OpenPlaylistIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPlaylistIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenPlaylistIndex_InPlaylist_PropertyAddress, OpenPlaylistIndex_FunctionAddress, "InPlaylist");
		OpenPlaylistIndex_InPlaylist_Offset = NativeReflectionCached.GetPropertyOffset(OpenPlaylistIndex_FunctionAddress, "InPlaylist");
		OpenPlaylistIndex_InPlaylist_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPlaylistIndex_FunctionAddress, "InPlaylist", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenPlaylistIndex_Index_PropertyAddress, OpenPlaylistIndex_FunctionAddress, "Index");
		OpenPlaylistIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(OpenPlaylistIndex_FunctionAddress, "Index");
		OpenPlaylistIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPlaylistIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenPlaylistIndex_ReturnValue_PropertyAddress, OpenPlaylistIndex_FunctionAddress, "ReturnValue");
		OpenPlaylistIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenPlaylistIndex_FunctionAddress, "ReturnValue");
		OpenPlaylistIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPlaylistIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenPlaylistIndex_IsValid = OpenPlaylistIndex_FunctionAddress != IntPtr.Zero && OpenPlaylistIndex_InPlaylist_IsValid && OpenPlaylistIndex_Index_IsValid && OpenPlaylistIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenPlaylistIndex", OpenPlaylistIndex_IsValid);
		OpenPlaylist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenPlaylist");
		OpenPlaylist_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPlaylist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenPlaylist_InPlaylist_PropertyAddress, OpenPlaylist_FunctionAddress, "InPlaylist");
		OpenPlaylist_InPlaylist_Offset = NativeReflectionCached.GetPropertyOffset(OpenPlaylist_FunctionAddress, "InPlaylist");
		OpenPlaylist_InPlaylist_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPlaylist_FunctionAddress, "InPlaylist", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenPlaylist_ReturnValue_PropertyAddress, OpenPlaylist_FunctionAddress, "ReturnValue");
		OpenPlaylist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenPlaylist_FunctionAddress, "ReturnValue");
		OpenPlaylist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPlaylist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenPlaylist_IsValid = OpenPlaylist_FunctionAddress != IntPtr.Zero && OpenPlaylist_InPlaylist_IsValid && OpenPlaylist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenPlaylist", OpenPlaylist_IsValid);
		OpenFile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenFile");
		OpenFile_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenFile_FilePath_PropertyAddress, OpenFile_FunctionAddress, "FilePath");
		OpenFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(OpenFile_FunctionAddress, "FilePath");
		OpenFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFile_ReturnValue_PropertyAddress, OpenFile_FunctionAddress, "ReturnValue");
		OpenFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenFile_FunctionAddress, "ReturnValue");
		OpenFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenFile_IsValid = OpenFile_FunctionAddress != IntPtr.Zero && OpenFile_FilePath_IsValid && OpenFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:OpenFile", OpenFile_IsValid);
		Next_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Next");
		Next_ParamsSize = NativeReflection.GetFunctionParamsSize(Next_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Next_ReturnValue_PropertyAddress, Next_FunctionAddress, "ReturnValue");
		Next_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Next_FunctionAddress, "ReturnValue");
		Next_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Next_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Next_IsValid = Next_FunctionAddress != IntPtr.Zero && Next_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Next", Next_IsValid);
		IsReady_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsReady");
		IsReady_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReady_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReady_ReturnValue_PropertyAddress, IsReady_FunctionAddress, "ReturnValue");
		IsReady_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReady_FunctionAddress, "ReturnValue");
		IsReady_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReady_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReady_IsValid = IsReady_FunctionAddress != IntPtr.Zero && IsReady_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsReady", IsReady_IsValid);
		IsPreparing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPreparing");
		IsPreparing_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPreparing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPreparing_ReturnValue_PropertyAddress, IsPreparing_FunctionAddress, "ReturnValue");
		IsPreparing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPreparing_FunctionAddress, "ReturnValue");
		IsPreparing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPreparing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPreparing_IsValid = IsPreparing_FunctionAddress != IntPtr.Zero && IsPreparing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsPreparing", IsPreparing_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsPlaying", IsPlaying_IsValid);
		IsPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPaused");
		IsPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPaused_ReturnValue_PropertyAddress, IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPaused_IsValid = IsPaused_FunctionAddress != IntPtr.Zero && IsPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsPaused", IsPaused_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsLooping", IsLooping_IsValid);
		IsConnecting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsConnecting");
		IsConnecting_ParamsSize = NativeReflection.GetFunctionParamsSize(IsConnecting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsConnecting_ReturnValue_PropertyAddress, IsConnecting_FunctionAddress, "ReturnValue");
		IsConnecting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsConnecting_FunctionAddress, "ReturnValue");
		IsConnecting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsConnecting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsConnecting_IsValid = IsConnecting_FunctionAddress != IntPtr.Zero && IsConnecting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsConnecting", IsConnecting_IsValid);
		IsClosed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsClosed");
		IsClosed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsClosed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsClosed_ReturnValue_PropertyAddress, IsClosed_FunctionAddress, "ReturnValue");
		IsClosed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsClosed_FunctionAddress, "ReturnValue");
		IsClosed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClosed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsClosed_IsValid = IsClosed_FunctionAddress != IntPtr.Zero && IsClosed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsClosed", IsClosed_IsValid);
		IsBuffering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBuffering");
		IsBuffering_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBuffering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBuffering_ReturnValue_PropertyAddress, IsBuffering_FunctionAddress, "ReturnValue");
		IsBuffering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBuffering_FunctionAddress, "ReturnValue");
		IsBuffering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBuffering_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBuffering_IsValid = IsBuffering_FunctionAddress != IntPtr.Zero && IsBuffering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:IsBuffering", IsBuffering_IsValid);
		HasError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasError");
		HasError_ParamsSize = NativeReflection.GetFunctionParamsSize(HasError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasError_ReturnValue_PropertyAddress, HasError_FunctionAddress, "ReturnValue");
		HasError_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasError_FunctionAddress, "ReturnValue");
		HasError_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasError_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasError_IsValid = HasError_FunctionAddress != IntPtr.Zero && HasError_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:HasError", HasError_IsValid);
		GetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewRotation");
		GetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRotation_ReturnValue_PropertyAddress, GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewRotation_IsValid = GetViewRotation_FunctionAddress != IntPtr.Zero && GetViewRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetViewRotation", GetViewRotation_IsValid);
		GetVideoTrackType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVideoTrackType");
		GetVideoTrackType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVideoTrackType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackType_TrackIndex_PropertyAddress, GetVideoTrackType_FunctionAddress, "TrackIndex");
		GetVideoTrackType_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackType_FunctionAddress, "TrackIndex");
		GetVideoTrackType_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackType_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackType_FormatIndex_PropertyAddress, GetVideoTrackType_FunctionAddress, "FormatIndex");
		GetVideoTrackType_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackType_FunctionAddress, "FormatIndex");
		GetVideoTrackType_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackType_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackType_ReturnValue_PropertyAddress, GetVideoTrackType_FunctionAddress, "ReturnValue");
		GetVideoTrackType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackType_FunctionAddress, "ReturnValue");
		GetVideoTrackType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackType_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetVideoTrackType_IsValid = GetVideoTrackType_FunctionAddress != IntPtr.Zero && GetVideoTrackType_TrackIndex_IsValid && GetVideoTrackType_FormatIndex_IsValid && GetVideoTrackType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVideoTrackType", GetVideoTrackType_IsValid);
		GetVideoTrackFrameRates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVideoTrackFrameRates");
		GetVideoTrackFrameRates_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVideoTrackFrameRates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRates_TrackIndex_PropertyAddress, GetVideoTrackFrameRates_FunctionAddress, "TrackIndex");
		GetVideoTrackFrameRates_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRates_FunctionAddress, "TrackIndex");
		GetVideoTrackFrameRates_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRates_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRates_FormatIndex_PropertyAddress, GetVideoTrackFrameRates_FunctionAddress, "FormatIndex");
		GetVideoTrackFrameRates_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRates_FunctionAddress, "FormatIndex");
		GetVideoTrackFrameRates_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRates_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRates_ReturnValue_PropertyAddress, GetVideoTrackFrameRates_FunctionAddress, "ReturnValue");
		GetVideoTrackFrameRates_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRates_FunctionAddress, "ReturnValue");
		GetVideoTrackFrameRates_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRates_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVideoTrackFrameRates_IsValid = GetVideoTrackFrameRates_FunctionAddress != IntPtr.Zero && GetVideoTrackFrameRates_TrackIndex_IsValid && GetVideoTrackFrameRates_FormatIndex_IsValid && GetVideoTrackFrameRates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRates", GetVideoTrackFrameRates_IsValid);
		GetVideoTrackFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVideoTrackFrameRate");
		GetVideoTrackFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVideoTrackFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRate_TrackIndex_PropertyAddress, GetVideoTrackFrameRate_FunctionAddress, "TrackIndex");
		GetVideoTrackFrameRate_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRate_FunctionAddress, "TrackIndex");
		GetVideoTrackFrameRate_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRate_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRate_FormatIndex_PropertyAddress, GetVideoTrackFrameRate_FunctionAddress, "FormatIndex");
		GetVideoTrackFrameRate_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRate_FunctionAddress, "FormatIndex");
		GetVideoTrackFrameRate_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRate_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackFrameRate_ReturnValue_PropertyAddress, GetVideoTrackFrameRate_FunctionAddress, "ReturnValue");
		GetVideoTrackFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackFrameRate_FunctionAddress, "ReturnValue");
		GetVideoTrackFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackFrameRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVideoTrackFrameRate_IsValid = GetVideoTrackFrameRate_FunctionAddress != IntPtr.Zero && GetVideoTrackFrameRate_TrackIndex_IsValid && GetVideoTrackFrameRate_FormatIndex_IsValid && GetVideoTrackFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVideoTrackFrameRate", GetVideoTrackFrameRate_IsValid);
		GetVideoTrackDimensions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVideoTrackDimensions");
		GetVideoTrackDimensions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVideoTrackDimensions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackDimensions_TrackIndex_PropertyAddress, GetVideoTrackDimensions_FunctionAddress, "TrackIndex");
		GetVideoTrackDimensions_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackDimensions_FunctionAddress, "TrackIndex");
		GetVideoTrackDimensions_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackDimensions_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackDimensions_FormatIndex_PropertyAddress, GetVideoTrackDimensions_FunctionAddress, "FormatIndex");
		GetVideoTrackDimensions_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackDimensions_FunctionAddress, "FormatIndex");
		GetVideoTrackDimensions_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackDimensions_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackDimensions_ReturnValue_PropertyAddress, GetVideoTrackDimensions_FunctionAddress, "ReturnValue");
		GetVideoTrackDimensions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackDimensions_FunctionAddress, "ReturnValue");
		GetVideoTrackDimensions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackDimensions_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVideoTrackDimensions_IsValid = GetVideoTrackDimensions_FunctionAddress != IntPtr.Zero && GetVideoTrackDimensions_TrackIndex_IsValid && GetVideoTrackDimensions_FormatIndex_IsValid && GetVideoTrackDimensions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVideoTrackDimensions", GetVideoTrackDimensions_IsValid);
		GetVideoTrackAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVideoTrackAspectRatio");
		GetVideoTrackAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVideoTrackAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackAspectRatio_TrackIndex_PropertyAddress, GetVideoTrackAspectRatio_FunctionAddress, "TrackIndex");
		GetVideoTrackAspectRatio_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackAspectRatio_FunctionAddress, "TrackIndex");
		GetVideoTrackAspectRatio_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackAspectRatio_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackAspectRatio_FormatIndex_PropertyAddress, GetVideoTrackAspectRatio_FunctionAddress, "FormatIndex");
		GetVideoTrackAspectRatio_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackAspectRatio_FunctionAddress, "FormatIndex");
		GetVideoTrackAspectRatio_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackAspectRatio_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVideoTrackAspectRatio_ReturnValue_PropertyAddress, GetVideoTrackAspectRatio_FunctionAddress, "ReturnValue");
		GetVideoTrackAspectRatio_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVideoTrackAspectRatio_FunctionAddress, "ReturnValue");
		GetVideoTrackAspectRatio_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVideoTrackAspectRatio_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVideoTrackAspectRatio_IsValid = GetVideoTrackAspectRatio_FunctionAddress != IntPtr.Zero && GetVideoTrackAspectRatio_TrackIndex_IsValid && GetVideoTrackAspectRatio_FormatIndex_IsValid && GetVideoTrackAspectRatio_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVideoTrackAspectRatio", GetVideoTrackAspectRatio_IsValid);
		GetVerticalFieldOfView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVerticalFieldOfView");
		GetVerticalFieldOfView_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVerticalFieldOfView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVerticalFieldOfView_ReturnValue_PropertyAddress, GetVerticalFieldOfView_FunctionAddress, "ReturnValue");
		GetVerticalFieldOfView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVerticalFieldOfView_FunctionAddress, "ReturnValue");
		GetVerticalFieldOfView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVerticalFieldOfView_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVerticalFieldOfView_IsValid = GetVerticalFieldOfView_FunctionAddress != IntPtr.Zero && GetVerticalFieldOfView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetVerticalFieldOfView", GetVerticalFieldOfView_IsValid);
		GetUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUrl");
		GetUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUrl_ReturnValue_PropertyAddress, GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUrl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUrl_IsValid = GetUrl_FunctionAddress != IntPtr.Zero && GetUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetUrl", GetUrl_IsValid);
		GetTrackLanguage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTrackLanguage");
		GetTrackLanguage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackLanguage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackLanguage_TrackType_PropertyAddress, GetTrackLanguage_FunctionAddress, "TrackType");
		GetTrackLanguage_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackLanguage_FunctionAddress, "TrackType");
		GetTrackLanguage_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackLanguage_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackLanguage_TrackIndex_PropertyAddress, GetTrackLanguage_FunctionAddress, "TrackIndex");
		GetTrackLanguage_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackLanguage_FunctionAddress, "TrackIndex");
		GetTrackLanguage_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackLanguage_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackLanguage_ReturnValue_PropertyAddress, GetTrackLanguage_FunctionAddress, "ReturnValue");
		GetTrackLanguage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackLanguage_FunctionAddress, "ReturnValue");
		GetTrackLanguage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackLanguage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTrackLanguage_IsValid = GetTrackLanguage_FunctionAddress != IntPtr.Zero && GetTrackLanguage_TrackType_IsValid && GetTrackLanguage_TrackIndex_IsValid && GetTrackLanguage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTrackLanguage", GetTrackLanguage_IsValid);
		GetTrackFormat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTrackFormat");
		GetTrackFormat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackFormat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackFormat_TrackType_PropertyAddress, GetTrackFormat_FunctionAddress, "TrackType");
		GetTrackFormat_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackFormat_FunctionAddress, "TrackType");
		GetTrackFormat_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackFormat_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackFormat_TrackIndex_PropertyAddress, GetTrackFormat_FunctionAddress, "TrackIndex");
		GetTrackFormat_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackFormat_FunctionAddress, "TrackIndex");
		GetTrackFormat_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackFormat_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackFormat_ReturnValue_PropertyAddress, GetTrackFormat_FunctionAddress, "ReturnValue");
		GetTrackFormat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackFormat_FunctionAddress, "ReturnValue");
		GetTrackFormat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackFormat_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTrackFormat_IsValid = GetTrackFormat_FunctionAddress != IntPtr.Zero && GetTrackFormat_TrackType_IsValid && GetTrackFormat_TrackIndex_IsValid && GetTrackFormat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTrackFormat", GetTrackFormat_IsValid);
		GetTrackDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTrackDisplayName");
		GetTrackDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackDisplayName_TrackType_PropertyAddress, GetTrackDisplayName_FunctionAddress, "TrackType");
		GetTrackDisplayName_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackDisplayName_FunctionAddress, "TrackType");
		GetTrackDisplayName_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackDisplayName_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackDisplayName_TrackIndex_PropertyAddress, GetTrackDisplayName_FunctionAddress, "TrackIndex");
		GetTrackDisplayName_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackDisplayName_FunctionAddress, "TrackIndex");
		GetTrackDisplayName_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackDisplayName_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackDisplayName_ReturnValue_PropertyAddress, GetTrackDisplayName_FunctionAddress, "ReturnValue");
		GetTrackDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackDisplayName_FunctionAddress, "ReturnValue");
		GetTrackDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTrackDisplayName_IsValid = GetTrackDisplayName_FunctionAddress != IntPtr.Zero && GetTrackDisplayName_TrackType_IsValid && GetTrackDisplayName_TrackIndex_IsValid && GetTrackDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTrackDisplayName", GetTrackDisplayName_IsValid);
		GetTimeStamp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTimeStamp");
		GetTimeStamp_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeStamp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeStamp_ReturnValue_PropertyAddress, GetTimeStamp_FunctionAddress, "ReturnValue");
		GetTimeStamp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeStamp_FunctionAddress, "ReturnValue");
		GetTimeStamp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeStamp_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTimeStamp_IsValid = GetTimeStamp_FunctionAddress != IntPtr.Zero && GetTimeStamp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTimeStamp", GetTimeStamp_IsValid);
		GetTimeDelay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTimeDelay");
		GetTimeDelay_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeDelay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeDelay_ReturnValue_PropertyAddress, GetTimeDelay_FunctionAddress, "ReturnValue");
		GetTimeDelay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeDelay_FunctionAddress, "ReturnValue");
		GetTimeDelay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeDelay_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTimeDelay_IsValid = GetTimeDelay_FunctionAddress != IntPtr.Zero && GetTimeDelay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTimeDelay", GetTimeDelay_IsValid);
		GetTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTime");
		GetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTime_ReturnValue_PropertyAddress, GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTime_IsValid = GetTime_FunctionAddress != IntPtr.Zero && GetTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetTime", GetTime_IsValid);
		GetSupportedRates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSupportedRates");
		GetSupportedRates_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedRates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedRates_OutRates_PropertyAddress, GetSupportedRates_FunctionAddress, "OutRates");
		GetSupportedRates_OutRates_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedRates_FunctionAddress, "OutRates");
		GetSupportedRates_OutRates_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedRates_FunctionAddress, "OutRates", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedRates_Unthinned_PropertyAddress, GetSupportedRates_FunctionAddress, "Unthinned");
		GetSupportedRates_Unthinned_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedRates_FunctionAddress, "Unthinned");
		GetSupportedRates_Unthinned_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedRates_FunctionAddress, "Unthinned", Classes.FBoolProperty);
		GetSupportedRates_IsValid = GetSupportedRates_FunctionAddress != IntPtr.Zero && GetSupportedRates_OutRates_IsValid && GetSupportedRates_Unthinned_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetSupportedRates", GetSupportedRates_IsValid);
		GetSelectedTrack_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedTrack");
		GetSelectedTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedTrack_TrackType_PropertyAddress, GetSelectedTrack_FunctionAddress, "TrackType");
		GetSelectedTrack_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedTrack_FunctionAddress, "TrackType");
		GetSelectedTrack_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedTrack_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedTrack_ReturnValue_PropertyAddress, GetSelectedTrack_FunctionAddress, "ReturnValue");
		GetSelectedTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedTrack_FunctionAddress, "ReturnValue");
		GetSelectedTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedTrack_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectedTrack_IsValid = GetSelectedTrack_FunctionAddress != IntPtr.Zero && GetSelectedTrack_TrackType_IsValid && GetSelectedTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetSelectedTrack", GetSelectedTrack_IsValid);
		GetRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRate");
		GetRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRate_ReturnValue_PropertyAddress, GetRate_FunctionAddress, "ReturnValue");
		GetRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRate_FunctionAddress, "ReturnValue");
		GetRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRate_IsValid = GetRate_FunctionAddress != IntPtr.Zero && GetRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetRate", GetRate_IsValid);
		GetPlaylistIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaylistIndex");
		GetPlaylistIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaylistIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaylistIndex_ReturnValue_PropertyAddress, GetPlaylistIndex_FunctionAddress, "ReturnValue");
		GetPlaylistIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaylistIndex_FunctionAddress, "ReturnValue");
		GetPlaylistIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaylistIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPlaylistIndex_IsValid = GetPlaylistIndex_FunctionAddress != IntPtr.Zero && GetPlaylistIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetPlaylistIndex", GetPlaylistIndex_IsValid);
		GetPlaylist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaylist");
		GetPlaylist_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaylist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaylist_ReturnValue_PropertyAddress, GetPlaylist_FunctionAddress, "ReturnValue");
		GetPlaylist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaylist_FunctionAddress, "ReturnValue");
		GetPlaylist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaylist_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlaylist_IsValid = GetPlaylist_FunctionAddress != IntPtr.Zero && GetPlaylist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetPlaylist", GetPlaylist_IsValid);
		GetPlayerName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerName");
		GetPlayerName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerName_ReturnValue_PropertyAddress, GetPlayerName_FunctionAddress, "ReturnValue");
		GetPlayerName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerName_FunctionAddress, "ReturnValue");
		GetPlayerName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPlayerName_IsValid = GetPlayerName_FunctionAddress != IntPtr.Zero && GetPlayerName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetPlayerName", GetPlayerName_IsValid);
		GetNumTracks_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumTracks");
		GetNumTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTracks_TrackType_PropertyAddress, GetNumTracks_FunctionAddress, "TrackType");
		GetNumTracks_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTracks_FunctionAddress, "TrackType");
		GetNumTracks_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTracks_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTracks_ReturnValue_PropertyAddress, GetNumTracks_FunctionAddress, "ReturnValue");
		GetNumTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTracks_FunctionAddress, "ReturnValue");
		GetNumTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTracks_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTracks_IsValid = GetNumTracks_FunctionAddress != IntPtr.Zero && GetNumTracks_TrackType_IsValid && GetNumTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetNumTracks", GetNumTracks_IsValid);
		GetNumTrackFormats_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumTrackFormats");
		GetNumTrackFormats_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTrackFormats_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTrackFormats_TrackType_PropertyAddress, GetNumTrackFormats_FunctionAddress, "TrackType");
		GetNumTrackFormats_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTrackFormats_FunctionAddress, "TrackType");
		GetNumTrackFormats_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTrackFormats_FunctionAddress, "TrackType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTrackFormats_TrackIndex_PropertyAddress, GetNumTrackFormats_FunctionAddress, "TrackIndex");
		GetNumTrackFormats_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTrackFormats_FunctionAddress, "TrackIndex");
		GetNumTrackFormats_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTrackFormats_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTrackFormats_ReturnValue_PropertyAddress, GetNumTrackFormats_FunctionAddress, "ReturnValue");
		GetNumTrackFormats_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTrackFormats_FunctionAddress, "ReturnValue");
		GetNumTrackFormats_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTrackFormats_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTrackFormats_IsValid = GetNumTrackFormats_FunctionAddress != IntPtr.Zero && GetNumTrackFormats_TrackType_IsValid && GetNumTrackFormats_TrackIndex_IsValid && GetNumTrackFormats_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetNumTrackFormats", GetNumTrackFormats_IsValid);
		GetMediaName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMediaName");
		GetMediaName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaName_ReturnValue_PropertyAddress, GetMediaName_FunctionAddress, "ReturnValue");
		GetMediaName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaName_FunctionAddress, "ReturnValue");
		GetMediaName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetMediaName_IsValid = GetMediaName_FunctionAddress != IntPtr.Zero && GetMediaName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetMediaName", GetMediaName_IsValid);
		GetHorizontalFieldOfView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHorizontalFieldOfView");
		GetHorizontalFieldOfView_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHorizontalFieldOfView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalFieldOfView_ReturnValue_PropertyAddress, GetHorizontalFieldOfView_FunctionAddress, "ReturnValue");
		GetHorizontalFieldOfView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalFieldOfView_FunctionAddress, "ReturnValue");
		GetHorizontalFieldOfView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalFieldOfView_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetHorizontalFieldOfView_IsValid = GetHorizontalFieldOfView_FunctionAddress != IntPtr.Zero && GetHorizontalFieldOfView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetHorizontalFieldOfView", GetHorizontalFieldOfView_IsValid);
		GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDuration");
		GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDuration_ReturnValue_PropertyAddress, GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDuration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDuration_IsValid = GetDuration_FunctionAddress != IntPtr.Zero && GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetDuration", GetDuration_IsValid);
		GetDesiredPlayerName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredPlayerName");
		GetDesiredPlayerName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredPlayerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredPlayerName_ReturnValue_PropertyAddress, GetDesiredPlayerName_FunctionAddress, "ReturnValue");
		GetDesiredPlayerName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredPlayerName_FunctionAddress, "ReturnValue");
		GetDesiredPlayerName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredPlayerName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetDesiredPlayerName_IsValid = GetDesiredPlayerName_FunctionAddress != IntPtr.Zero && GetDesiredPlayerName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetDesiredPlayerName", GetDesiredPlayerName_IsValid);
		GetAudioTrackType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAudioTrackType");
		GetAudioTrackType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioTrackType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackType_TrackIndex_PropertyAddress, GetAudioTrackType_FunctionAddress, "TrackIndex");
		GetAudioTrackType_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackType_FunctionAddress, "TrackIndex");
		GetAudioTrackType_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackType_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackType_FormatIndex_PropertyAddress, GetAudioTrackType_FunctionAddress, "FormatIndex");
		GetAudioTrackType_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackType_FunctionAddress, "FormatIndex");
		GetAudioTrackType_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackType_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackType_ReturnValue_PropertyAddress, GetAudioTrackType_FunctionAddress, "ReturnValue");
		GetAudioTrackType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackType_FunctionAddress, "ReturnValue");
		GetAudioTrackType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackType_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAudioTrackType_IsValid = GetAudioTrackType_FunctionAddress != IntPtr.Zero && GetAudioTrackType_TrackIndex_IsValid && GetAudioTrackType_FormatIndex_IsValid && GetAudioTrackType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetAudioTrackType", GetAudioTrackType_IsValid);
		GetAudioTrackSampleRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAudioTrackSampleRate");
		GetAudioTrackSampleRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioTrackSampleRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackSampleRate_TrackIndex_PropertyAddress, GetAudioTrackSampleRate_FunctionAddress, "TrackIndex");
		GetAudioTrackSampleRate_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackSampleRate_FunctionAddress, "TrackIndex");
		GetAudioTrackSampleRate_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackSampleRate_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackSampleRate_FormatIndex_PropertyAddress, GetAudioTrackSampleRate_FunctionAddress, "FormatIndex");
		GetAudioTrackSampleRate_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackSampleRate_FunctionAddress, "FormatIndex");
		GetAudioTrackSampleRate_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackSampleRate_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackSampleRate_ReturnValue_PropertyAddress, GetAudioTrackSampleRate_FunctionAddress, "ReturnValue");
		GetAudioTrackSampleRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackSampleRate_FunctionAddress, "ReturnValue");
		GetAudioTrackSampleRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackSampleRate_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAudioTrackSampleRate_IsValid = GetAudioTrackSampleRate_FunctionAddress != IntPtr.Zero && GetAudioTrackSampleRate_TrackIndex_IsValid && GetAudioTrackSampleRate_FormatIndex_IsValid && GetAudioTrackSampleRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetAudioTrackSampleRate", GetAudioTrackSampleRate_IsValid);
		GetAudioTrackChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAudioTrackChannels");
		GetAudioTrackChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioTrackChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackChannels_TrackIndex_PropertyAddress, GetAudioTrackChannels_FunctionAddress, "TrackIndex");
		GetAudioTrackChannels_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackChannels_FunctionAddress, "TrackIndex");
		GetAudioTrackChannels_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackChannels_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackChannels_FormatIndex_PropertyAddress, GetAudioTrackChannels_FunctionAddress, "FormatIndex");
		GetAudioTrackChannels_FormatIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackChannels_FunctionAddress, "FormatIndex");
		GetAudioTrackChannels_FormatIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackChannels_FunctionAddress, "FormatIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioTrackChannels_ReturnValue_PropertyAddress, GetAudioTrackChannels_FunctionAddress, "ReturnValue");
		GetAudioTrackChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioTrackChannels_FunctionAddress, "ReturnValue");
		GetAudioTrackChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioTrackChannels_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAudioTrackChannels_IsValid = GetAudioTrackChannels_FunctionAddress != IntPtr.Zero && GetAudioTrackChannels_TrackIndex_IsValid && GetAudioTrackChannels_FormatIndex_IsValid && GetAudioTrackChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:GetAudioTrackChannels", GetAudioTrackChannels_IsValid);
		Close_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Close");
		Close_ParamsSize = NativeReflection.GetFunctionParamsSize(Close_FunctionAddress);
		Close_IsValid = Close_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:Close", Close_IsValid);
		CanPlayUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanPlayUrl");
		CanPlayUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(CanPlayUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanPlayUrl_Url_PropertyAddress, CanPlayUrl_FunctionAddress, "Url");
		CanPlayUrl_Url_Offset = NativeReflectionCached.GetPropertyOffset(CanPlayUrl_FunctionAddress, "Url");
		CanPlayUrl_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPlayUrl_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CanPlayUrl_ReturnValue_PropertyAddress, CanPlayUrl_FunctionAddress, "ReturnValue");
		CanPlayUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanPlayUrl_FunctionAddress, "ReturnValue");
		CanPlayUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPlayUrl_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanPlayUrl_IsValid = CanPlayUrl_FunctionAddress != IntPtr.Zero && CanPlayUrl_Url_IsValid && CanPlayUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:CanPlayUrl", CanPlayUrl_IsValid);
		CanPlaySource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanPlaySource");
		CanPlaySource_ParamsSize = NativeReflection.GetFunctionParamsSize(CanPlaySource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanPlaySource_MediaSource_PropertyAddress, CanPlaySource_FunctionAddress, "MediaSource");
		CanPlaySource_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(CanPlaySource_FunctionAddress, "MediaSource");
		CanPlaySource_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPlaySource_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanPlaySource_ReturnValue_PropertyAddress, CanPlaySource_FunctionAddress, "ReturnValue");
		CanPlaySource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanPlaySource_FunctionAddress, "ReturnValue");
		CanPlaySource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPlaySource_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanPlaySource_IsValid = CanPlaySource_FunctionAddress != IntPtr.Zero && CanPlaySource_MediaSource_IsValid && CanPlaySource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:CanPlaySource", CanPlaySource_IsValid);
		CanPause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanPause");
		CanPause_ParamsSize = NativeReflection.GetFunctionParamsSize(CanPause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanPause_ReturnValue_PropertyAddress, CanPause_FunctionAddress, "ReturnValue");
		CanPause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanPause_FunctionAddress, "ReturnValue");
		CanPause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPause_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanPause_IsValid = CanPause_FunctionAddress != IntPtr.Zero && CanPause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlayer:CanPause", CanPause_IsValid);
	}
}
