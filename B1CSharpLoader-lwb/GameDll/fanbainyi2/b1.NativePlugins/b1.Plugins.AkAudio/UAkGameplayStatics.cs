using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.WwiseObjectUtils;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkGameplayStatics", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkGameplayStatics : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UseReverbVolumes_IsValid;

	private static IntPtr UseReverbVolumes_FunctionAddress;

	private static int UseReverbVolumes_ParamsSize;

	private static bool UseReverbVolumes_inUseReverbVolumes_IsValid;

	private static FFieldAddress UseReverbVolumes_inUseReverbVolumes_PropertyAddress;

	private static int UseReverbVolumes_inUseReverbVolumes_Offset;

	private static bool UseReverbVolumes_Actor_IsValid;

	private static FFieldAddress UseReverbVolumes_Actor_PropertyAddress;

	private static int UseReverbVolumes_Actor_Offset;

	private static bool UnloadInitBank_IsValid;

	private static IntPtr UnloadInitBank_FunctionAddress;

	private static int UnloadInitBank_ParamsSize;

	private static bool StopProfilerCapture_IsValid;

	private static IntPtr StopProfilerCapture_FunctionAddress;

	private static int StopProfilerCapture_ParamsSize;

	private static bool StopOutputCapture_IsValid;

	private static IntPtr StopOutputCapture_FunctionAddress;

	private static int StopOutputCapture_ParamsSize;

	private static bool StopAllAmbientSounds_IsValid;

	private static IntPtr StopAllAmbientSounds_FunctionAddress;

	private static int StopAllAmbientSounds_ParamsSize;

	private static bool StopAllAmbientSounds_WorldContextObject_IsValid;

	private static FFieldAddress StopAllAmbientSounds_WorldContextObject_PropertyAddress;

	private static int StopAllAmbientSounds_WorldContextObject_Offset;

	private static bool StopAll_IsValid;

	private static IntPtr StopAll_FunctionAddress;

	private static int StopAll_ParamsSize;

	private static bool StopActor_IsValid;

	private static IntPtr StopActor_FunctionAddress;

	private static int StopActor_ParamsSize;

	private static bool StopActor_Actor_IsValid;

	private static FFieldAddress StopActor_Actor_PropertyAddress;

	private static int StopActor_Actor_Offset;

	private static bool StartProfilerCapture_IsValid;

	private static IntPtr StartProfilerCapture_FunctionAddress;

	private static int StartProfilerCapture_ParamsSize;

	private static bool StartProfilerCapture_Filename_IsValid;

	private static FFieldAddress StartProfilerCapture_Filename_PropertyAddress;

	private static int StartProfilerCapture_Filename_Offset;

	private static bool StartOutputCapture_IsValid;

	private static IntPtr StartOutputCapture_FunctionAddress;

	private static int StartOutputCapture_ParamsSize;

	private static bool StartOutputCapture_Filename_IsValid;

	private static FFieldAddress StartOutputCapture_Filename_PropertyAddress;

	private static int StartOutputCapture_Filename_Offset;

	private static bool StartAllAmbientSounds_IsValid;

	private static IntPtr StartAllAmbientSounds_FunctionAddress;

	private static int StartAllAmbientSounds_ParamsSize;

	private static bool StartAllAmbientSounds_WorldContextObject_IsValid;

	private static FFieldAddress StartAllAmbientSounds_WorldContextObject_PropertyAddress;

	private static int StartAllAmbientSounds_WorldContextObject_Offset;

	private static bool SpawnAkComponentAtLocation_IsValid;

	private static IntPtr SpawnAkComponentAtLocation_FunctionAddress;

	private static int SpawnAkComponentAtLocation_ParamsSize;

	private static bool SpawnAkComponentAtLocation_WorldContextObject_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_WorldContextObject_PropertyAddress;

	private static int SpawnAkComponentAtLocation_WorldContextObject_Offset;

	private static bool SpawnAkComponentAtLocation_AkEvent_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_AkEvent_PropertyAddress;

	private static int SpawnAkComponentAtLocation_AkEvent_Offset;

	private static bool SpawnAkComponentAtLocation_Location_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_Location_PropertyAddress;

	private static int SpawnAkComponentAtLocation_Location_Offset;

	private static bool SpawnAkComponentAtLocation_Orientation_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_Orientation_PropertyAddress;

	private static int SpawnAkComponentAtLocation_Orientation_Offset;

	private static bool SpawnAkComponentAtLocation_AutoPost_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_AutoPost_PropertyAddress;

	private static int SpawnAkComponentAtLocation_AutoPost_Offset;

	private static bool SpawnAkComponentAtLocation_EventName_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_EventName_PropertyAddress;

	private static int SpawnAkComponentAtLocation_EventName_Offset;

	private static bool SpawnAkComponentAtLocation_AutoDestroy_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_AutoDestroy_PropertyAddress;

	private static int SpawnAkComponentAtLocation_AutoDestroy_Offset;

	private static bool SpawnAkComponentAtLocation_ReturnValue_IsValid;

	private static FFieldAddress SpawnAkComponentAtLocation_ReturnValue_PropertyAddress;

	private static int SpawnAkComponentAtLocation_ReturnValue_Offset;

	private static bool SetSwitch_IsValid;

	private static IntPtr SetSwitch_FunctionAddress;

	private static int SetSwitch_ParamsSize;

	private static bool SetSwitch_SwitchValue_IsValid;

	private static FFieldAddress SetSwitch_SwitchValue_PropertyAddress;

	private static int SetSwitch_SwitchValue_Offset;

	private static bool SetSwitch_Actor_IsValid;

	private static FFieldAddress SetSwitch_Actor_PropertyAddress;

	private static int SetSwitch_Actor_Offset;

	private static bool SetSwitch_SwitchGroup_IsValid;

	private static FFieldAddress SetSwitch_SwitchGroup_PropertyAddress;

	private static int SetSwitch_SwitchGroup_Offset;

	private static bool SetSwitch_SwitchState_IsValid;

	private static FFieldAddress SetSwitch_SwitchState_PropertyAddress;

	private static int SetSwitch_SwitchState_Offset;

	private static bool SetState_IsValid;

	private static IntPtr SetState_FunctionAddress;

	private static int SetState_ParamsSize;

	private static bool SetState_StateValue_IsValid;

	private static FFieldAddress SetState_StateValue_PropertyAddress;

	private static int SetState_StateValue_Offset;

	private static bool SetState_StateGroup_IsValid;

	private static FFieldAddress SetState_StateGroup_PropertyAddress;

	private static int SetState_StateGroup_Offset;

	private static bool SetState_State_IsValid;

	private static FFieldAddress SetState_State_PropertyAddress;

	private static int SetState_State_Offset;

	private static bool SetSpeakerAngles_IsValid;

	private static IntPtr SetSpeakerAngles_FunctionAddress;

	private static int SetSpeakerAngles_ParamsSize;

	private static bool SetSpeakerAngles_SpeakerAngles_IsValid;

	private static FFieldAddress SetSpeakerAngles_SpeakerAngles_PropertyAddress;

	private static int SetSpeakerAngles_SpeakerAngles_Offset;

	private static bool SetSpeakerAngles_HeightAngle_IsValid;

	private static FFieldAddress SetSpeakerAngles_HeightAngle_PropertyAddress;

	private static int SetSpeakerAngles_HeightAngle_Offset;

	private static bool SetSpeakerAngles_DeviceShareSet_IsValid;

	private static FFieldAddress SetSpeakerAngles_DeviceShareSet_PropertyAddress;

	private static int SetSpeakerAngles_DeviceShareSet_Offset;

	private static bool SetRTPCValueByPlayingID_IsValid;

	private static IntPtr SetRTPCValueByPlayingID_FunctionAddress;

	private static int SetRTPCValueByPlayingID_ParamsSize;

	private static bool SetRTPCValueByPlayingID_PlayingID_IsValid;

	private static FFieldAddress SetRTPCValueByPlayingID_PlayingID_PropertyAddress;

	private static int SetRTPCValueByPlayingID_PlayingID_Offset;

	private static bool SetRTPCValueByPlayingID_Value_IsValid;

	private static FFieldAddress SetRTPCValueByPlayingID_Value_PropertyAddress;

	private static int SetRTPCValueByPlayingID_Value_Offset;

	private static bool SetRTPCValueByPlayingID_RTPC_IsValid;

	private static FFieldAddress SetRTPCValueByPlayingID_RTPC_PropertyAddress;

	private static int SetRTPCValueByPlayingID_RTPC_Offset;

	private static bool SetRTPCValue_IsValid;

	private static IntPtr SetRTPCValue_FunctionAddress;

	private static int SetRTPCValue_ParamsSize;

	private static bool SetRTPCValue_RTPCValue_IsValid;

	private static FFieldAddress SetRTPCValue_RTPCValue_PropertyAddress;

	private static int SetRTPCValue_RTPCValue_Offset;

	private static bool SetRTPCValue_Value_IsValid;

	private static FFieldAddress SetRTPCValue_Value_PropertyAddress;

	private static int SetRTPCValue_Value_Offset;

	private static bool SetRTPCValue_InterpolationTimeMs_IsValid;

	private static FFieldAddress SetRTPCValue_InterpolationTimeMs_PropertyAddress;

	private static int SetRTPCValue_InterpolationTimeMs_Offset;

	private static bool SetRTPCValue_Actor_IsValid;

	private static FFieldAddress SetRTPCValue_Actor_PropertyAddress;

	private static int SetRTPCValue_Actor_Offset;

	private static bool SetRTPCValue_RTPC_IsValid;

	private static FFieldAddress SetRTPCValue_RTPC_PropertyAddress;

	private static int SetRTPCValue_RTPC_Offset;

	private static bool SetReflectionsOrder_IsValid;

	private static IntPtr SetReflectionsOrder_FunctionAddress;

	private static int SetReflectionsOrder_ParamsSize;

	private static bool SetReflectionsOrder_Order_IsValid;

	private static FFieldAddress SetReflectionsOrder_Order_PropertyAddress;

	private static int SetReflectionsOrder_Order_Offset;

	private static bool SetReflectionsOrder_RefreshPaths_IsValid;

	private static FFieldAddress SetReflectionsOrder_RefreshPaths_PropertyAddress;

	private static int SetReflectionsOrder_RefreshPaths_Offset;

	private static bool SetPortalToPortalObstruction_IsValid;

	private static IntPtr SetPortalToPortalObstruction_FunctionAddress;

	private static int SetPortalToPortalObstruction_ParamsSize;

	private static bool SetPortalToPortalObstruction_PortalComponent0_IsValid;

	private static FFieldAddress SetPortalToPortalObstruction_PortalComponent0_PropertyAddress;

	private static int SetPortalToPortalObstruction_PortalComponent0_Offset;

	private static bool SetPortalToPortalObstruction_PortalComponent1_IsValid;

	private static FFieldAddress SetPortalToPortalObstruction_PortalComponent1_PropertyAddress;

	private static int SetPortalToPortalObstruction_PortalComponent1_Offset;

	private static bool SetPortalToPortalObstruction_ObstructionValue_IsValid;

	private static FFieldAddress SetPortalToPortalObstruction_ObstructionValue_PropertyAddress;

	private static int SetPortalToPortalObstruction_ObstructionValue_Offset;

	private static bool SetPortalObstructionAndOcclusion_IsValid;

	private static IntPtr SetPortalObstructionAndOcclusion_FunctionAddress;

	private static int SetPortalObstructionAndOcclusion_ParamsSize;

	private static bool SetPortalObstructionAndOcclusion_PortalComponent_IsValid;

	private static FFieldAddress SetPortalObstructionAndOcclusion_PortalComponent_PropertyAddress;

	private static int SetPortalObstructionAndOcclusion_PortalComponent_Offset;

	private static bool SetPortalObstructionAndOcclusion_ObstructionValue_IsValid;

	private static FFieldAddress SetPortalObstructionAndOcclusion_ObstructionValue_PropertyAddress;

	private static int SetPortalObstructionAndOcclusion_ObstructionValue_Offset;

	private static bool SetPortalObstructionAndOcclusion_OcclusionValue_IsValid;

	private static FFieldAddress SetPortalObstructionAndOcclusion_OcclusionValue_PropertyAddress;

	private static int SetPortalObstructionAndOcclusion_OcclusionValue_Offset;

	private static bool SetPanningRule_IsValid;

	private static IntPtr SetPanningRule_FunctionAddress;

	private static int SetPanningRule_ParamsSize;

	private static bool SetPanningRule_PanRule_IsValid;

	private static FFieldAddress SetPanningRule_PanRule_PropertyAddress;

	private static int SetPanningRule_PanRule_Offset;

	private static bool SetOutputDeviceEffect_IsValid;

	private static IntPtr SetOutputDeviceEffect_FunctionAddress;

	private static int SetOutputDeviceEffect_ParamsSize;

	private static bool SetOutputDeviceEffect_InDeviceID_IsValid;

	private static FFieldAddress SetOutputDeviceEffect_InDeviceID_PropertyAddress;

	private static int SetOutputDeviceEffect_InDeviceID_Offset;

	private static bool SetOutputDeviceEffect_InEffectIndex_IsValid;

	private static FFieldAddress SetOutputDeviceEffect_InEffectIndex_PropertyAddress;

	private static int SetOutputDeviceEffect_InEffectIndex_Offset;

	private static bool SetOutputDeviceEffect_InEffectShareSet_IsValid;

	private static FFieldAddress SetOutputDeviceEffect_InEffectShareSet_PropertyAddress;

	private static int SetOutputDeviceEffect_InEffectShareSet_Offset;

	private static bool SetOutputDeviceEffect_ReturnValue_IsValid;

	private static FFieldAddress SetOutputDeviceEffect_ReturnValue_PropertyAddress;

	private static int SetOutputDeviceEffect_ReturnValue_Offset;

	private static bool SetOutputBusVolume_IsValid;

	private static IntPtr SetOutputBusVolume_FunctionAddress;

	private static int SetOutputBusVolume_ParamsSize;

	private static bool SetOutputBusVolume_BusVolume_IsValid;

	private static FFieldAddress SetOutputBusVolume_BusVolume_PropertyAddress;

	private static int SetOutputBusVolume_BusVolume_Offset;

	private static bool SetOutputBusVolume_Actor_IsValid;

	private static FFieldAddress SetOutputBusVolume_Actor_PropertyAddress;

	private static int SetOutputBusVolume_Actor_Offset;

	private static bool SetOcclusionRefreshInterval_IsValid;

	private static IntPtr SetOcclusionRefreshInterval_FunctionAddress;

	private static int SetOcclusionRefreshInterval_ParamsSize;

	private static bool SetOcclusionRefreshInterval_RefreshInterval_IsValid;

	private static FFieldAddress SetOcclusionRefreshInterval_RefreshInterval_PropertyAddress;

	private static int SetOcclusionRefreshInterval_RefreshInterval_Offset;

	private static bool SetOcclusionRefreshInterval_Actor_IsValid;

	private static FFieldAddress SetOcclusionRefreshInterval_Actor_PropertyAddress;

	private static int SetOcclusionRefreshInterval_Actor_Offset;

	private static bool SetMultiplePositions_IsValid;

	private static IntPtr SetMultiplePositions_FunctionAddress;

	private static int SetMultiplePositions_ParamsSize;

	private static bool SetMultiplePositions_GameObjectAkComponent_IsValid;

	private static FFieldAddress SetMultiplePositions_GameObjectAkComponent_PropertyAddress;

	private static int SetMultiplePositions_GameObjectAkComponent_Offset;

	private static bool SetMultiplePositions_Positions_IsValid;

	private static FFieldAddress SetMultiplePositions_Positions_PropertyAddress;

	private static int SetMultiplePositions_Positions_Offset;

	private static bool SetMultiplePositions_MultiPositionType_IsValid;

	private static FFieldAddress SetMultiplePositions_MultiPositionType_PropertyAddress;

	private static int SetMultiplePositions_MultiPositionType_Offset;

	private static bool SetMultipleChannelMaskEmitterPositions_IsValid;

	private static IntPtr SetMultipleChannelMaskEmitterPositions_FunctionAddress;

	private static int SetMultipleChannelMaskEmitterPositions_ParamsSize;

	private static bool SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_IsValid;

	private static FFieldAddress SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_PropertyAddress;

	private static int SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_Offset;

	private static bool SetMultipleChannelMaskEmitterPositions_ChannelMasks_IsValid;

	private static FFieldAddress SetMultipleChannelMaskEmitterPositions_ChannelMasks_PropertyAddress;

	private static int SetMultipleChannelMaskEmitterPositions_ChannelMasks_Offset;

	private static bool SetMultipleChannelMaskEmitterPositions_Positions_IsValid;

	private static FFieldAddress SetMultipleChannelMaskEmitterPositions_Positions_PropertyAddress;

	private static int SetMultipleChannelMaskEmitterPositions_Positions_Offset;

	private static bool SetMultipleChannelMaskEmitterPositions_MultiPositionType_IsValid;

	private static FFieldAddress SetMultipleChannelMaskEmitterPositions_MultiPositionType_PropertyAddress;

	private static int SetMultipleChannelMaskEmitterPositions_MultiPositionType_Offset;

	private static bool SetMultipleChannelEmitterPositions_IsValid;

	private static IntPtr SetMultipleChannelEmitterPositions_FunctionAddress;

	private static int SetMultipleChannelEmitterPositions_ParamsSize;

	private static bool SetMultipleChannelEmitterPositions_GameObjectAkComponent_IsValid;

	private static FFieldAddress SetMultipleChannelEmitterPositions_GameObjectAkComponent_PropertyAddress;

	private static int SetMultipleChannelEmitterPositions_GameObjectAkComponent_Offset;

	private static bool SetMultipleChannelEmitterPositions_ChannelMasks_IsValid;

	private static FFieldAddress SetMultipleChannelEmitterPositions_ChannelMasks_PropertyAddress;

	private static int SetMultipleChannelEmitterPositions_ChannelMasks_Offset;

	private static bool SetMultipleChannelEmitterPositions_Positions_IsValid;

	private static FFieldAddress SetMultipleChannelEmitterPositions_Positions_PropertyAddress;

	private static int SetMultipleChannelEmitterPositions_Positions_Offset;

	private static bool SetMultipleChannelEmitterPositions_MultiPositionType_IsValid;

	private static FFieldAddress SetMultipleChannelEmitterPositions_MultiPositionType_PropertyAddress;

	private static int SetMultipleChannelEmitterPositions_MultiPositionType_Offset;

	private static bool SetGameObjectToPortalObstruction_IsValid;

	private static IntPtr SetGameObjectToPortalObstruction_FunctionAddress;

	private static int SetGameObjectToPortalObstruction_ParamsSize;

	private static bool SetGameObjectToPortalObstruction_GameObjectAkComponent_IsValid;

	private static FFieldAddress SetGameObjectToPortalObstruction_GameObjectAkComponent_PropertyAddress;

	private static int SetGameObjectToPortalObstruction_GameObjectAkComponent_Offset;

	private static bool SetGameObjectToPortalObstruction_PortalComponent_IsValid;

	private static FFieldAddress SetGameObjectToPortalObstruction_PortalComponent_PropertyAddress;

	private static int SetGameObjectToPortalObstruction_PortalComponent_Offset;

	private static bool SetGameObjectToPortalObstruction_ObstructionValue_IsValid;

	private static FFieldAddress SetGameObjectToPortalObstruction_ObstructionValue_PropertyAddress;

	private static int SetGameObjectToPortalObstruction_ObstructionValue_Offset;

	private static bool SetDummyObjListener_IsValid;

	private static IntPtr SetDummyObjListener_FunctionAddress;

	private static int SetDummyObjListener_ParamsSize;

	private static bool SetDistanceProbe_IsValid;

	private static IntPtr SetDistanceProbe_FunctionAddress;

	private static int SetDistanceProbe_ParamsSize;

	private static bool SetDistanceProbe_Listener_IsValid;

	private static FFieldAddress SetDistanceProbe_Listener_PropertyAddress;

	private static int SetDistanceProbe_Listener_Offset;

	private static bool SetDistanceProbe_DistanceProbe_IsValid;

	private static FFieldAddress SetDistanceProbe_DistanceProbe_PropertyAddress;

	private static int SetDistanceProbe_DistanceProbe_Offset;

	private static bool SetCurrentAudioCultureAsync_IsValid;

	private static IntPtr SetCurrentAudioCultureAsync_FunctionAddress;

	private static int SetCurrentAudioCultureAsync_ParamsSize;

	private static bool SetCurrentAudioCultureAsync_AudioCulture_IsValid;

	private static FFieldAddress SetCurrentAudioCultureAsync_AudioCulture_PropertyAddress;

	private static int SetCurrentAudioCultureAsync_AudioCulture_Offset;

	private static bool SetCurrentAudioCultureAsync_Completed_IsValid;

	private static FFieldAddress SetCurrentAudioCultureAsync_Completed_PropertyAddress;

	private static int SetCurrentAudioCultureAsync_Completed_Offset;

	private static bool SetCurrentAudioCulture_IsValid;

	private static IntPtr SetCurrentAudioCulture_FunctionAddress;

	private static int SetCurrentAudioCulture_ParamsSize;

	private static bool SetCurrentAudioCulture_AudioCulture_IsValid;

	private static FFieldAddress SetCurrentAudioCulture_AudioCulture_PropertyAddress;

	private static int SetCurrentAudioCulture_AudioCulture_Offset;

	private static bool SetCurrentAudioCulture_LatentInfo_IsValid;

	private static FFieldAddress SetCurrentAudioCulture_LatentInfo_PropertyAddress;

	private static int SetCurrentAudioCulture_LatentInfo_Offset;

	private static bool SetCurrentAudioCulture_WorldContextObject_IsValid;

	private static FFieldAddress SetCurrentAudioCulture_WorldContextObject_PropertyAddress;

	private static int SetCurrentAudioCulture_WorldContextObject_Offset;

	private static bool SetBusEffectByName_IsValid;

	private static IntPtr SetBusEffectByName_FunctionAddress;

	private static int SetBusEffectByName_ParamsSize;

	private static bool SetBusEffectByName_InBusName_IsValid;

	private static FFieldAddress SetBusEffectByName_InBusName_PropertyAddress;

	private static int SetBusEffectByName_InBusName_Offset;

	private static bool SetBusEffectByName_InEffectIndex_IsValid;

	private static FFieldAddress SetBusEffectByName_InEffectIndex_PropertyAddress;

	private static int SetBusEffectByName_InEffectIndex_Offset;

	private static bool SetBusEffectByName_InEffectShareSet_IsValid;

	private static FFieldAddress SetBusEffectByName_InEffectShareSet_PropertyAddress;

	private static int SetBusEffectByName_InEffectShareSet_Offset;

	private static bool SetBusEffectByName_ReturnValue_IsValid;

	private static FFieldAddress SetBusEffectByName_ReturnValue_PropertyAddress;

	private static int SetBusEffectByName_ReturnValue_Offset;

	private static bool SetBusEffectByID_IsValid;

	private static IntPtr SetBusEffectByID_FunctionAddress;

	private static int SetBusEffectByID_ParamsSize;

	private static bool SetBusEffectByID_InBusID_IsValid;

	private static FFieldAddress SetBusEffectByID_InBusID_PropertyAddress;

	private static int SetBusEffectByID_InBusID_Offset;

	private static bool SetBusEffectByID_InEffectIndex_IsValid;

	private static FFieldAddress SetBusEffectByID_InEffectIndex_PropertyAddress;

	private static int SetBusEffectByID_InEffectIndex_Offset;

	private static bool SetBusEffectByID_InEffectShareSet_IsValid;

	private static FFieldAddress SetBusEffectByID_InEffectShareSet_PropertyAddress;

	private static int SetBusEffectByID_InEffectShareSet_Offset;

	private static bool SetBusEffectByID_ReturnValue_IsValid;

	private static FFieldAddress SetBusEffectByID_ReturnValue_PropertyAddress;

	private static int SetBusEffectByID_ReturnValue_Offset;

	private static bool SetBusConfig_IsValid;

	private static IntPtr SetBusConfig_FunctionAddress;

	private static int SetBusConfig_ParamsSize;

	private static bool SetBusConfig_BusName_IsValid;

	private static FFieldAddress SetBusConfig_BusName_PropertyAddress;

	private static int SetBusConfig_BusName_Offset;

	private static bool SetBusConfig_ChannelConfiguration_IsValid;

	private static FFieldAddress SetBusConfig_ChannelConfiguration_PropertyAddress;

	private static int SetBusConfig_ChannelConfiguration_Offset;

	private static bool SetAuxBusEffect_IsValid;

	private static IntPtr SetAuxBusEffect_FunctionAddress;

	private static int SetAuxBusEffect_ParamsSize;

	private static bool SetAuxBusEffect_InAuxBus_IsValid;

	private static FFieldAddress SetAuxBusEffect_InAuxBus_PropertyAddress;

	private static int SetAuxBusEffect_InAuxBus_Offset;

	private static bool SetAuxBusEffect_InEffectIndex_IsValid;

	private static FFieldAddress SetAuxBusEffect_InEffectIndex_PropertyAddress;

	private static int SetAuxBusEffect_InEffectIndex_Offset;

	private static bool SetAuxBusEffect_InEffectShareSet_IsValid;

	private static FFieldAddress SetAuxBusEffect_InEffectShareSet_PropertyAddress;

	private static int SetAuxBusEffect_InEffectShareSet_Offset;

	private static bool SetAuxBusEffect_ReturnValue_IsValid;

	private static FFieldAddress SetAuxBusEffect_ReturnValue_PropertyAddress;

	private static int SetAuxBusEffect_ReturnValue_Offset;

	private static bool SetActorMixerEffect_IsValid;

	private static IntPtr SetActorMixerEffect_FunctionAddress;

	private static int SetActorMixerEffect_ParamsSize;

	private static bool SetActorMixerEffect_InAudioNodeID_IsValid;

	private static FFieldAddress SetActorMixerEffect_InAudioNodeID_PropertyAddress;

	private static int SetActorMixerEffect_InAudioNodeID_Offset;

	private static bool SetActorMixerEffect_InEffectIndex_IsValid;

	private static FFieldAddress SetActorMixerEffect_InEffectIndex_PropertyAddress;

	private static int SetActorMixerEffect_InEffectIndex_Offset;

	private static bool SetActorMixerEffect_InEffectShareSet_IsValid;

	private static FFieldAddress SetActorMixerEffect_InEffectShareSet_PropertyAddress;

	private static int SetActorMixerEffect_InEffectShareSet_Offset;

	private static bool SetActorMixerEffect_ReturnValue_IsValid;

	private static FFieldAddress SetActorMixerEffect_ReturnValue_PropertyAddress;

	private static int SetActorMixerEffect_ReturnValue_Offset;

	private static bool ResetRTPCValue_IsValid;

	private static IntPtr ResetRTPCValue_FunctionAddress;

	private static int ResetRTPCValue_ParamsSize;

	private static bool ResetRTPCValue_RTPCValue_IsValid;

	private static FFieldAddress ResetRTPCValue_RTPCValue_PropertyAddress;

	private static int ResetRTPCValue_RTPCValue_Offset;

	private static bool ResetRTPCValue_InterpolationTimeMs_IsValid;

	private static FFieldAddress ResetRTPCValue_InterpolationTimeMs_PropertyAddress;

	private static int ResetRTPCValue_InterpolationTimeMs_Offset;

	private static bool ResetRTPCValue_Actor_IsValid;

	private static FFieldAddress ResetRTPCValue_Actor_PropertyAddress;

	private static int ResetRTPCValue_Actor_Offset;

	private static bool ResetRTPCValue_RTPC_IsValid;

	private static FFieldAddress ResetRTPCValue_RTPC_PropertyAddress;

	private static int ResetRTPCValue_RTPC_Offset;

	private static bool ReplaceMainOutput_IsValid;

	private static IntPtr ReplaceMainOutput_FunctionAddress;

	private static int ReplaceMainOutput_ParamsSize;

	private static bool ReplaceMainOutput_MainOutputSettings_IsValid;

	private static FFieldAddress ReplaceMainOutput_MainOutputSettings_PropertyAddress;

	private static int ReplaceMainOutput_MainOutputSettings_Offset;

	private static bool RemoveOutput_IsValid;

	private static IntPtr RemoveOutput_FunctionAddress;

	private static int RemoveOutput_ParamsSize;

	private static bool RemoveOutput_in_OutputDeviceId_IsValid;

	private static FFieldAddress RemoveOutput_in_OutputDeviceId_PropertyAddress;

	private static int RemoveOutput_in_OutputDeviceId_Offset;

	private static bool RemoveMotionOutput_IsValid;

	private static IntPtr RemoveMotionOutput_FunctionAddress;

	private static int RemoveMotionOutput_ParamsSize;

	private static bool PostTrigger_IsValid;

	private static IntPtr PostTrigger_FunctionAddress;

	private static int PostTrigger_ParamsSize;

	private static bool PostTrigger_TriggerValue_IsValid;

	private static FFieldAddress PostTrigger_TriggerValue_PropertyAddress;

	private static int PostTrigger_TriggerValue_Offset;

	private static bool PostTrigger_Actor_IsValid;

	private static FFieldAddress PostTrigger_Actor_PropertyAddress;

	private static int PostTrigger_Actor_Offset;

	private static bool PostTrigger_Trigger_IsValid;

	private static FFieldAddress PostTrigger_Trigger_PropertyAddress;

	private static int PostTrigger_Trigger_Offset;

	private static bool PostEventOnDummyObj_IsValid;

	private static IntPtr PostEventOnDummyObj_FunctionAddress;

	private static int PostEventOnDummyObj_ParamsSize;

	private static bool PostEventOnDummyObj_AkEvent_IsValid;

	private static FFieldAddress PostEventOnDummyObj_AkEvent_PropertyAddress;

	private static int PostEventOnDummyObj_AkEvent_Offset;

	private static bool PostEventOnDummyObj_EventName_IsValid;

	private static FFieldAddress PostEventOnDummyObj_EventName_PropertyAddress;

	private static int PostEventOnDummyObj_EventName_Offset;

	private static bool PostEventOnDummyObj_ReturnValue_IsValid;

	private static FFieldAddress PostEventOnDummyObj_ReturnValue_PropertyAddress;

	private static int PostEventOnDummyObj_ReturnValue_Offset;

	private static bool PostEventAtLocation_IsValid;

	private static IntPtr PostEventAtLocation_FunctionAddress;

	private static int PostEventAtLocation_ParamsSize;

	private static bool PostEventAtLocation_AkEvent_IsValid;

	private static FFieldAddress PostEventAtLocation_AkEvent_PropertyAddress;

	private static int PostEventAtLocation_AkEvent_Offset;

	private static bool PostEventAtLocation_Location_IsValid;

	private static FFieldAddress PostEventAtLocation_Location_PropertyAddress;

	private static int PostEventAtLocation_Location_Offset;

	private static bool PostEventAtLocation_Orientation_IsValid;

	private static FFieldAddress PostEventAtLocation_Orientation_PropertyAddress;

	private static int PostEventAtLocation_Orientation_Offset;

	private static bool PostEventAtLocation_EventName_IsValid;

	private static FFieldAddress PostEventAtLocation_EventName_PropertyAddress;

	private static int PostEventAtLocation_EventName_Offset;

	private static bool PostEventAtLocation_WorldContextObject_IsValid;

	private static FFieldAddress PostEventAtLocation_WorldContextObject_PropertyAddress;

	private static int PostEventAtLocation_WorldContextObject_Offset;

	private static bool PostEventAtLocation_ReturnValue_IsValid;

	private static FFieldAddress PostEventAtLocation_ReturnValue_PropertyAddress;

	private static int PostEventAtLocation_ReturnValue_Offset;

	private static bool PostEvent_IsValid;

	private static IntPtr PostEvent_FunctionAddress;

	private static int PostEvent_ParamsSize;

	private static bool PostEvent_AkEvent_IsValid;

	private static FFieldAddress PostEvent_AkEvent_PropertyAddress;

	private static int PostEvent_AkEvent_Offset;

	private static bool PostEvent_Actor_IsValid;

	private static FFieldAddress PostEvent_Actor_PropertyAddress;

	private static int PostEvent_Actor_Offset;

	private static bool PostEvent_CallbackMask_IsValid;

	private static FFieldAddress PostEvent_CallbackMask_PropertyAddress;

	private static int PostEvent_CallbackMask_Offset;

	private static bool PostEvent_PostEventCallback_IsValid;

	private static FFieldAddress PostEvent_PostEventCallback_PropertyAddress;

	private static int PostEvent_PostEventCallback_Offset;

	private static bool PostEvent_bStopWhenAttachedToDestroyed_IsValid;

	private static FFieldAddress PostEvent_bStopWhenAttachedToDestroyed_PropertyAddress;

	private static int PostEvent_bStopWhenAttachedToDestroyed_Offset;

	private static bool PostEvent_EventName_IsValid;

	private static FFieldAddress PostEvent_EventName_PropertyAddress;

	private static int PostEvent_EventName_Offset;

	private static bool PostEvent_ReturnValue_IsValid;

	private static FFieldAddress PostEvent_ReturnValue_PropertyAddress;

	private static int PostEvent_ReturnValue_Offset;

	private static bool PostAndWaitForEndOfEvent_IsValid;

	private static IntPtr PostAndWaitForEndOfEvent_FunctionAddress;

	private static int PostAndWaitForEndOfEvent_ParamsSize;

	private static bool PostAndWaitForEndOfEvent_AkEvent_IsValid;

	private static FFieldAddress PostAndWaitForEndOfEvent_AkEvent_PropertyAddress;

	private static int PostAndWaitForEndOfEvent_AkEvent_Offset;

	private static bool PostAndWaitForEndOfEvent_Actor_IsValid;

	private static FFieldAddress PostAndWaitForEndOfEvent_Actor_PropertyAddress;

	private static int PostAndWaitForEndOfEvent_Actor_Offset;

	private static bool PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_IsValid;

	private static FFieldAddress PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_PropertyAddress;

	private static int PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_Offset;

	private static bool PostAndWaitForEndOfEvent_LatentInfo_IsValid;

	private static FFieldAddress PostAndWaitForEndOfEvent_LatentInfo_PropertyAddress;

	private static int PostAndWaitForEndOfEvent_LatentInfo_Offset;

	private static bool PostAndWaitForEndOfEvent_ReturnValue_IsValid;

	private static FFieldAddress PostAndWaitForEndOfEvent_ReturnValue_PropertyAddress;

	private static int PostAndWaitForEndOfEvent_ReturnValue_Offset;

	private static bool LoadInitBank_IsValid;

	private static IntPtr LoadInitBank_FunctionAddress;

	private static int LoadInitBank_ParamsSize;

	private static bool IsGame_IsValid;

	private static IntPtr IsGame_FunctionAddress;

	private static int IsGame_ParamsSize;

	private static bool IsGame_WorldContextObject_IsValid;

	private static FFieldAddress IsGame_WorldContextObject_PropertyAddress;

	private static int IsGame_WorldContextObject_Offset;

	private static bool IsGame_ReturnValue_IsValid;

	private static FFieldAddress IsGame_ReturnValue_PropertyAddress;

	private static int IsGame_ReturnValue_Offset;

	private static bool IsEditor_IsValid;

	private static IntPtr IsEditor_FunctionAddress;

	private static int IsEditor_ParamsSize;

	private static bool IsEditor_ReturnValue_IsValid;

	private static FFieldAddress IsEditor_ReturnValue_PropertyAddress;

	private static int IsEditor_ReturnValue_Offset;

	private static bool GetSpeakerAngles_IsValid;

	private static IntPtr GetSpeakerAngles_FunctionAddress;

	private static int GetSpeakerAngles_ParamsSize;

	private static bool GetSpeakerAngles_SpeakerAngles_IsValid;

	private static FFieldAddress GetSpeakerAngles_SpeakerAngles_PropertyAddress;

	private static int GetSpeakerAngles_SpeakerAngles_Offset;

	private static bool GetSpeakerAngles_HeightAngle_IsValid;

	private static FFieldAddress GetSpeakerAngles_HeightAngle_PropertyAddress;

	private static int GetSpeakerAngles_HeightAngle_Offset;

	private static bool GetSpeakerAngles_DeviceShareSet_IsValid;

	private static FFieldAddress GetSpeakerAngles_DeviceShareSet_PropertyAddress;

	private static int GetSpeakerAngles_DeviceShareSet_Offset;

	private static bool GetRTPCValue_IsValid;

	private static IntPtr GetRTPCValue_FunctionAddress;

	private static int GetRTPCValue_ParamsSize;

	private static bool GetRTPCValue_RTPCValue_IsValid;

	private static FFieldAddress GetRTPCValue_RTPCValue_PropertyAddress;

	private static int GetRTPCValue_RTPCValue_Offset;

	private static bool GetRTPCValue_PlayingID_IsValid;

	private static FFieldAddress GetRTPCValue_PlayingID_PropertyAddress;

	private static int GetRTPCValue_PlayingID_Offset;

	private static bool GetRTPCValue_InputValueType_IsValid;

	private static FFieldAddress GetRTPCValue_InputValueType_PropertyAddress;

	private static int GetRTPCValue_InputValueType_Offset;

	private static bool GetRTPCValue_Value_IsValid;

	private static FFieldAddress GetRTPCValue_Value_PropertyAddress;

	private static int GetRTPCValue_Value_Offset;

	private static bool GetRTPCValue_OutputValueType_IsValid;

	private static FFieldAddress GetRTPCValue_OutputValueType_PropertyAddress;

	private static int GetRTPCValue_OutputValueType_Offset;

	private static bool GetRTPCValue_Actor_IsValid;

	private static FFieldAddress GetRTPCValue_Actor_PropertyAddress;

	private static int GetRTPCValue_Actor_Offset;

	private static bool GetRTPCValue_RTPC_IsValid;

	private static FFieldAddress GetRTPCValue_RTPC_PropertyAddress;

	private static int GetRTPCValue_RTPC_Offset;

	private static bool GetCurrentAudioCulture_IsValid;

	private static IntPtr GetCurrentAudioCulture_FunctionAddress;

	private static int GetCurrentAudioCulture_ParamsSize;

	private static bool GetCurrentAudioCulture_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentAudioCulture_ReturnValue_PropertyAddress;

	private static int GetCurrentAudioCulture_ReturnValue_Offset;

	private static bool GetAvailableAudioCultures_IsValid;

	private static IntPtr GetAvailableAudioCultures_FunctionAddress;

	private static int GetAvailableAudioCultures_ParamsSize;

	private static bool GetAvailableAudioCultures_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableAudioCultures_ReturnValue_PropertyAddress;

	private static int GetAvailableAudioCultures_ReturnValue_Offset;

	private static bool GetAkComponent_IsValid;

	private static IntPtr GetAkComponent_FunctionAddress;

	private static int GetAkComponent_ParamsSize;

	private static bool GetAkComponent_AttachToComponent_IsValid;

	private static FFieldAddress GetAkComponent_AttachToComponent_PropertyAddress;

	private static int GetAkComponent_AttachToComponent_Offset;

	private static bool GetAkComponent_ComponentCreated_IsValid;

	private static FFieldAddress GetAkComponent_ComponentCreated_PropertyAddress;

	private static int GetAkComponent_ComponentCreated_Offset;

	private static bool GetAkComponent_AttachPointName_IsValid;

	private static FFieldAddress GetAkComponent_AttachPointName_PropertyAddress;

	private static int GetAkComponent_AttachPointName_Offset;

	private static bool GetAkComponent_Location_IsValid;

	private static FFieldAddress GetAkComponent_Location_PropertyAddress;

	private static int GetAkComponent_Location_Offset;

	private static bool GetAkComponent_LocationType_IsValid;

	private static FFieldAddress GetAkComponent_LocationType_PropertyAddress;

	private static int GetAkComponent_LocationType_Offset;

	private static bool GetAkComponent_ReturnValue_IsValid;

	private static FFieldAddress GetAkComponent_ReturnValue_PropertyAddress;

	private static int GetAkComponent_ReturnValue_Offset;

	private static bool GetAkAudioTypeUserData_IsValid;

	private static IntPtr GetAkAudioTypeUserData_FunctionAddress;

	private static int GetAkAudioTypeUserData_ParamsSize;

	private static bool GetAkAudioTypeUserData_Instance_IsValid;

	private static FFieldAddress GetAkAudioTypeUserData_Instance_PropertyAddress;

	private static int GetAkAudioTypeUserData_Instance_Offset;

	private static bool GetAkAudioTypeUserData_Type_IsValid;

	private static FFieldAddress GetAkAudioTypeUserData_Type_PropertyAddress;

	private static int GetAkAudioTypeUserData_Type_Offset;

	private static bool GetAkAudioTypeUserData_ReturnValue_IsValid;

	private static FFieldAddress GetAkAudioTypeUserData_ReturnValue_PropertyAddress;

	private static int GetAkAudioTypeUserData_ReturnValue_Offset;

	private static bool ClearSoundBanksAndMedia_IsValid;

	private static IntPtr ClearSoundBanksAndMedia_FunctionAddress;

	private static int ClearSoundBanksAndMedia_ParamsSize;

	private static bool CancelEventCallback_IsValid;

	private static IntPtr CancelEventCallback_FunctionAddress;

	private static int CancelEventCallback_ParamsSize;

	private static bool CancelEventCallback_PostEventCallback_IsValid;

	private static FFieldAddress CancelEventCallback_PostEventCallback_PropertyAddress;

	private static int CancelEventCallback_PostEventCallback_Offset;

	private static bool AddOutputCaptureMarker_IsValid;

	private static IntPtr AddOutputCaptureMarker_FunctionAddress;

	private static int AddOutputCaptureMarker_ParamsSize;

	private static bool AddOutputCaptureMarker_MarkerText_IsValid;

	private static FFieldAddress AddOutputCaptureMarker_MarkerText_PropertyAddress;

	private static int AddOutputCaptureMarker_MarkerText_Offset;

	private static bool AddOutput_IsValid;

	private static IntPtr AddOutput_FunctionAddress;

	private static int AddOutput_ParamsSize;

	private static bool AddOutput_in_Settings_IsValid;

	private static FFieldAddress AddOutput_in_Settings_PropertyAddress;

	private static int AddOutput_in_Settings_Offset;

	private static bool AddOutput_out_DeviceID_IsValid;

	private static FFieldAddress AddOutput_out_DeviceID_PropertyAddress;

	private static int AddOutput_out_DeviceID_Offset;

	private static bool AddOutput_in_ListenerIDs_IsValid;

	private static FFieldAddress AddOutput_in_ListenerIDs_PropertyAddress;

	private static int AddOutput_in_ListenerIDs_Offset;

	private static bool AddMotionOutput_IsValid;

	private static IntPtr AddMotionOutput_FunctionAddress;

	private static int AddMotionOutput_ParamsSize;

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:UseReverbVolumes")]
	public unsafe static void UseReverbVolumes(bool inUseReverbVolumes, AActor Actor)
	{
		if (!UseReverbVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:UseReverbVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UseReverbVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UseReverbVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UseReverbVolumes_inUseReverbVolumes_Offset), 0, UseReverbVolumes_inUseReverbVolumes_PropertyAddress.Address, inUseReverbVolumes);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UseReverbVolumes_Actor_Offset), 0, UseReverbVolumes_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UseReverbVolumes_FunctionAddress, intPtr, UseReverbVolumes_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:UnloadInitBank")]
	public unsafe static void UnloadInitBank()
	{
		if (!UnloadInitBank_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:UnloadInitBank");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnloadInitBank_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnloadInitBank_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: UnloadInitBank_FunctionAddress, argsSize: UnloadInitBank_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StopProfilerCapture")]
	public unsafe static void StopProfilerCapture()
	{
		if (!StopProfilerCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StopProfilerCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopProfilerCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopProfilerCapture_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopProfilerCapture_FunctionAddress, argsSize: StopProfilerCapture_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StopOutputCapture")]
	public unsafe static void StopOutputCapture()
	{
		if (!StopOutputCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StopOutputCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopOutputCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopOutputCapture_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopOutputCapture_FunctionAddress, argsSize: StopOutputCapture_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StopAllAmbientSounds")]
	public unsafe static void StopAllAmbientSounds(UObject WorldContextObject)
	{
		if (!StopAllAmbientSounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StopAllAmbientSounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllAmbientSounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllAmbientSounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopAllAmbientSounds_WorldContextObject_Offset), 0, StopAllAmbientSounds_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopAllAmbientSounds_FunctionAddress, intPtr, StopAllAmbientSounds_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StopAll")]
	public unsafe static void StopAll()
	{
		if (!StopAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StopAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAll_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StopAll_FunctionAddress, argsSize: StopAll_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StopActor")]
	public unsafe static void StopActor(AActor Actor)
	{
		if (!StopActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StopActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, StopActor_Actor_Offset), 0, StopActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopActor_FunctionAddress, intPtr, StopActor_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StartProfilerCapture")]
	public unsafe static void StartProfilerCapture(string Filename)
	{
		if (!StartProfilerCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StartProfilerCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartProfilerCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartProfilerCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartProfilerCapture_Filename_Offset), 0, StartProfilerCapture_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartProfilerCapture_FunctionAddress, intPtr, StartProfilerCapture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartProfilerCapture_Filename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StartOutputCapture")]
	public unsafe static void StartOutputCapture(string Filename)
	{
		if (!StartOutputCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StartOutputCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartOutputCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartOutputCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartOutputCapture_Filename_Offset), 0, StartOutputCapture_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartOutputCapture_FunctionAddress, intPtr, StartOutputCapture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartOutputCapture_Filename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:StartAllAmbientSounds")]
	public unsafe static void StartAllAmbientSounds(UObject WorldContextObject)
	{
		if (!StartAllAmbientSounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:StartAllAmbientSounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAllAmbientSounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAllAmbientSounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartAllAmbientSounds_WorldContextObject_Offset), 0, StartAllAmbientSounds_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartAllAmbientSounds_FunctionAddress, intPtr, StartAllAmbientSounds_ParamsSize);
	}

	[UFunction(Flags = 75637769u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SpawnAkComponentAtLocation")]
	public unsafe static UAkComponent SpawnAkComponentAtLocation(UObject WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, bool AutoPost, string EventName, bool AutoDestroy = true)
	{
		if (!SpawnAkComponentAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SpawnAkComponentAtLocation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnAkComponentAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnAkComponentAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_WorldContextObject_Offset), 0, SpawnAkComponentAtLocation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_AkEvent_Offset), 0, SpawnAkComponentAtLocation_AkEvent_PropertyAddress.Address, AkEvent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_Location_Offset), 0, SpawnAkComponentAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_Orientation_Offset), 0, SpawnAkComponentAtLocation_Orientation_PropertyAddress.Address, Orientation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_AutoPost_Offset), 0, SpawnAkComponentAtLocation_AutoPost_PropertyAddress.Address, AutoPost);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_EventName_Offset), 0, SpawnAkComponentAtLocation_EventName_PropertyAddress.Address, EventName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_AutoDestroy_Offset), 0, SpawnAkComponentAtLocation_AutoDestroy_PropertyAddress.Address, AutoDestroy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnAkComponentAtLocation_FunctionAddress, intPtr, SpawnAkComponentAtLocation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SpawnAkComponentAtLocation_EventName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(intPtr, SpawnAkComponentAtLocation_ReturnValue_Offset), 0, SpawnAkComponentAtLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetSwitch")]
	public unsafe static void SetSwitch(UAkSwitchValue SwitchValue, AActor Actor, FName SwitchGroup, FName SwitchState)
	{
		if (!SetSwitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetSwitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSwitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSwitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkSwitchValue>.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchValue_Offset), 0, SetSwitch_SwitchValue_PropertyAddress.Address, SwitchValue);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetSwitch_Actor_Offset), 0, SetSwitch_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchGroup_Offset), 0, SetSwitch_SwitchGroup_PropertyAddress.Address, SwitchGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSwitch_SwitchState_Offset), 0, SetSwitch_SwitchState_PropertyAddress.Address, SwitchState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSwitch_FunctionAddress, intPtr, SetSwitch_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetState")]
	public unsafe static void SetState(UAkStateValue StateValue, FName StateGroup, FName State)
	{
		if (!SetState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkStateValue>.ToNative(IntPtr.Add(intPtr, SetState_StateValue_Offset), 0, SetState_StateValue_PropertyAddress.Address, StateValue);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetState_StateGroup_Offset), 0, SetState_StateGroup_PropertyAddress.Address, StateGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetState_State_Offset), 0, SetState_State_PropertyAddress.Address, State);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetState_FunctionAddress, intPtr, SetState_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetSpeakerAngles")]
	public unsafe static void SetSpeakerAngles(List<float> SpeakerAngles, float HeightAngle, string DeviceShareSet)
	{
		if (!SetSpeakerAngles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetSpeakerAngles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpeakerAngles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpeakerAngles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, SetSpeakerAngles_SpeakerAngles_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSpeakerAngles_SpeakerAngles_Offset), SpeakerAngles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSpeakerAngles_HeightAngle_Offset), 0, SetSpeakerAngles_HeightAngle_PropertyAddress.Address, HeightAngle);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSpeakerAngles_DeviceShareSet_Offset), 0, SetSpeakerAngles_DeviceShareSet_PropertyAddress.Address, DeviceShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSpeakerAngles_FunctionAddress, intPtr, SetSpeakerAngles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSpeakerAngles_SpeakerAngles_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetSpeakerAngles_DeviceShareSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetRTPCValueByPlayingID")]
	public unsafe static void SetRTPCValueByPlayingID(int PlayingID, float Value, FName RTPC)
	{
		if (!SetRTPCValueByPlayingID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetRTPCValueByPlayingID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRTPCValueByPlayingID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRTPCValueByPlayingID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRTPCValueByPlayingID_PlayingID_Offset), 0, SetRTPCValueByPlayingID_PlayingID_PropertyAddress.Address, PlayingID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRTPCValueByPlayingID_Value_Offset), 0, SetRTPCValueByPlayingID_Value_PropertyAddress.Address, Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRTPCValueByPlayingID_RTPC_Offset), 0, SetRTPCValueByPlayingID_RTPC_PropertyAddress.Address, RTPC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRTPCValueByPlayingID_FunctionAddress, intPtr, SetRTPCValueByPlayingID_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetRTPCValue")]
	public unsafe static void SetRTPCValue(UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, AActor Actor, FName RTPC)
	{
		if (!SetRTPCValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetRTPCValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRTPCValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRTPCValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkRtpc>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_RTPCValue_Offset), 0, SetRTPCValue_RTPCValue_PropertyAddress.Address, RTPCValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_Value_Offset), 0, SetRTPCValue_Value_PropertyAddress.Address, Value);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_InterpolationTimeMs_Offset), 0, SetRTPCValue_InterpolationTimeMs_PropertyAddress.Address, InterpolationTimeMs);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_Actor_Offset), 0, SetRTPCValue_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRTPCValue_RTPC_Offset), 0, SetRTPCValue_RTPC_PropertyAddress.Address, RTPC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRTPCValue_FunctionAddress, intPtr, SetRTPCValue_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetReflectionsOrder")]
	public unsafe static void SetReflectionsOrder(int Order, bool RefreshPaths)
	{
		if (!SetReflectionsOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetReflectionsOrder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflectionsOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflectionsOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetReflectionsOrder_Order_Offset), 0, SetReflectionsOrder_Order_PropertyAddress.Address, Order);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReflectionsOrder_RefreshPaths_Offset), 0, SetReflectionsOrder_RefreshPaths_PropertyAddress.Address, RefreshPaths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetReflectionsOrder_FunctionAddress, intPtr, SetReflectionsOrder_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetPortalToPortalObstruction")]
	public unsafe static void SetPortalToPortalObstruction(UAkPortalComponent PortalComponent0, UAkPortalComponent PortalComponent1, float ObstructionValue)
	{
		if (!SetPortalToPortalObstruction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetPortalToPortalObstruction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPortalToPortalObstruction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPortalToPortalObstruction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkPortalComponent>.ToNative(IntPtr.Add(intPtr, SetPortalToPortalObstruction_PortalComponent0_Offset), 0, SetPortalToPortalObstruction_PortalComponent0_PropertyAddress.Address, PortalComponent0);
		UObjectMarshaler<UAkPortalComponent>.ToNative(IntPtr.Add(intPtr, SetPortalToPortalObstruction_PortalComponent1_Offset), 0, SetPortalToPortalObstruction_PortalComponent1_PropertyAddress.Address, PortalComponent1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPortalToPortalObstruction_ObstructionValue_Offset), 0, SetPortalToPortalObstruction_ObstructionValue_PropertyAddress.Address, ObstructionValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPortalToPortalObstruction_FunctionAddress, intPtr, SetPortalToPortalObstruction_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetPortalObstructionAndOcclusion")]
	public unsafe static void SetPortalObstructionAndOcclusion(UAkPortalComponent PortalComponent, float ObstructionValue, float OcclusionValue)
	{
		if (!SetPortalObstructionAndOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetPortalObstructionAndOcclusion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPortalObstructionAndOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPortalObstructionAndOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkPortalComponent>.ToNative(IntPtr.Add(intPtr, SetPortalObstructionAndOcclusion_PortalComponent_Offset), 0, SetPortalObstructionAndOcclusion_PortalComponent_PropertyAddress.Address, PortalComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPortalObstructionAndOcclusion_ObstructionValue_Offset), 0, SetPortalObstructionAndOcclusion_ObstructionValue_PropertyAddress.Address, ObstructionValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPortalObstructionAndOcclusion_OcclusionValue_Offset), 0, SetPortalObstructionAndOcclusion_OcclusionValue_PropertyAddress.Address, OcclusionValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPortalObstructionAndOcclusion_FunctionAddress, intPtr, SetPortalObstructionAndOcclusion_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetPanningRule")]
	public unsafe static void SetPanningRule(EPanningRule PanRule)
	{
		if (!SetPanningRule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetPanningRule");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPanningRule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPanningRule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPanningRule>.ToNative(IntPtr.Add(intPtr, SetPanningRule_PanRule_Offset), 0, SetPanningRule_PanRule_PropertyAddress.Address, PanRule);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPanningRule_FunctionAddress, intPtr, SetPanningRule_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetOutputDeviceEffect")]
	public unsafe static bool SetOutputDeviceEffect(FAkOutputDeviceID InDeviceID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
	{
		if (!SetOutputDeviceEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetOutputDeviceEffect");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputDeviceEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputDeviceEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOutputDeviceEffect_InDeviceID_PropertyAddress.Address, intPtr);
		FAkOutputDeviceID.ToNative(IntPtr.Add(intPtr, SetOutputDeviceEffect_InDeviceID_Offset), 0, SetOutputDeviceEffect_InDeviceID_PropertyAddress.Address, InDeviceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOutputDeviceEffect_InEffectIndex_Offset), 0, SetOutputDeviceEffect_InEffectIndex_PropertyAddress.Address, InEffectIndex);
		UObjectMarshaler<UAkEffectShareSet>.ToNative(IntPtr.Add(intPtr, SetOutputDeviceEffect_InEffectShareSet_Offset), 0, SetOutputDeviceEffect_InEffectShareSet_PropertyAddress.Address, InEffectShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOutputDeviceEffect_FunctionAddress, intPtr, SetOutputDeviceEffect_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetOutputDeviceEffect_ReturnValue_Offset), 0, SetOutputDeviceEffect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetOutputBusVolume")]
	public unsafe static void SetOutputBusVolume(float BusVolume, AActor Actor)
	{
		if (!SetOutputBusVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetOutputBusVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputBusVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputBusVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOutputBusVolume_BusVolume_Offset), 0, SetOutputBusVolume_BusVolume_PropertyAddress.Address, BusVolume);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetOutputBusVolume_Actor_Offset), 0, SetOutputBusVolume_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOutputBusVolume_FunctionAddress, intPtr, SetOutputBusVolume_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetOcclusionRefreshInterval")]
	public unsafe static void SetOcclusionRefreshInterval(float RefreshInterval, AActor Actor)
	{
		if (!SetOcclusionRefreshInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetOcclusionRefreshInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionRefreshInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionRefreshInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOcclusionRefreshInterval_RefreshInterval_Offset), 0, SetOcclusionRefreshInterval_RefreshInterval_PropertyAddress.Address, RefreshInterval);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetOcclusionRefreshInterval_Actor_Offset), 0, SetOcclusionRefreshInterval_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOcclusionRefreshInterval_FunctionAddress, intPtr, SetOcclusionRefreshInterval_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetMultiplePositions")]
	public unsafe static void SetMultiplePositions(UAkComponent GameObjectAkComponent, List<FTransform> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
	{
		if (!SetMultiplePositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetMultiplePositions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMultiplePositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMultiplePositions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, SetMultiplePositions_GameObjectAkComponent_Offset), 0, SetMultiplePositions_GameObjectAkComponent_PropertyAddress.Address, GameObjectAkComponent);
		new TArrayCopyMarshaler<FTransform>(1, SetMultiplePositions_Positions_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMultiplePositions_Positions_Offset), Positions);
		EnumMarshaler<EAkMultiPositionType>.ToNative(IntPtr.Add(intPtr, SetMultiplePositions_MultiPositionType_Offset), 0, SetMultiplePositions_MultiPositionType_PropertyAddress.Address, MultiPositionType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMultiplePositions_FunctionAddress, intPtr, SetMultiplePositions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMultiplePositions_Positions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelMaskEmitterPositions")]
	public unsafe static void SetMultipleChannelMaskEmitterPositions(UAkComponent GameObjectAkComponent, List<FAkChannelMask> ChannelMasks, List<FTransform> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
	{
		if (!SetMultipleChannelMaskEmitterPositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelMaskEmitterPositions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMultipleChannelMaskEmitterPositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMultipleChannelMaskEmitterPositions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_Offset), 0, SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_PropertyAddress.Address, GameObjectAkComponent);
		new TArrayCopyMarshaler<FAkChannelMask>(1, SetMultipleChannelMaskEmitterPositions_ChannelMasks_PropertyAddress, CachedMarshalingDelegates<FAkChannelMask, FAkChannelMask>.FromNative, CachedMarshalingDelegates<FAkChannelMask, FAkChannelMask>.ToNative).ToNative(IntPtr.Add(intPtr, SetMultipleChannelMaskEmitterPositions_ChannelMasks_Offset), ChannelMasks);
		new TArrayCopyMarshaler<FTransform>(1, SetMultipleChannelMaskEmitterPositions_Positions_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMultipleChannelMaskEmitterPositions_Positions_Offset), Positions);
		EnumMarshaler<EAkMultiPositionType>.ToNative(IntPtr.Add(intPtr, SetMultipleChannelMaskEmitterPositions_MultiPositionType_Offset), 0, SetMultipleChannelMaskEmitterPositions_MultiPositionType_PropertyAddress.Address, MultiPositionType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMultipleChannelMaskEmitterPositions_FunctionAddress, intPtr, SetMultipleChannelMaskEmitterPositions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMultipleChannelMaskEmitterPositions_ChannelMasks_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetMultipleChannelMaskEmitterPositions_Positions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelEmitterPositions")]
	public unsafe static void SetMultipleChannelEmitterPositions(UAkComponent GameObjectAkComponent, List<EAkChannelConfiguration> ChannelMasks, List<FTransform> Positions, EAkMultiPositionType MultiPositionType = EAkMultiPositionType.MultiDirections)
	{
		if (!SetMultipleChannelEmitterPositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelEmitterPositions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMultipleChannelEmitterPositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMultipleChannelEmitterPositions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, SetMultipleChannelEmitterPositions_GameObjectAkComponent_Offset), 0, SetMultipleChannelEmitterPositions_GameObjectAkComponent_PropertyAddress.Address, GameObjectAkComponent);
		new TArrayCopyMarshaler<EAkChannelConfiguration>(1, SetMultipleChannelEmitterPositions_ChannelMasks_PropertyAddress, CachedMarshalingDelegates<EAkChannelConfiguration, EnumMarshaler<EAkChannelConfiguration>>.FromNative, CachedMarshalingDelegates<EAkChannelConfiguration, EnumMarshaler<EAkChannelConfiguration>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMultipleChannelEmitterPositions_ChannelMasks_Offset), ChannelMasks);
		new TArrayCopyMarshaler<FTransform>(1, SetMultipleChannelEmitterPositions_Positions_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMultipleChannelEmitterPositions_Positions_Offset), Positions);
		EnumMarshaler<EAkMultiPositionType>.ToNative(IntPtr.Add(intPtr, SetMultipleChannelEmitterPositions_MultiPositionType_Offset), 0, SetMultipleChannelEmitterPositions_MultiPositionType_PropertyAddress.Address, MultiPositionType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMultipleChannelEmitterPositions_FunctionAddress, intPtr, SetMultipleChannelEmitterPositions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMultipleChannelEmitterPositions_ChannelMasks_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetMultipleChannelEmitterPositions_Positions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetGameObjectToPortalObstruction")]
	public unsafe static void SetGameObjectToPortalObstruction(UAkComponent GameObjectAkComponent, UAkPortalComponent PortalComponent, float ObstructionValue)
	{
		if (!SetGameObjectToPortalObstruction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetGameObjectToPortalObstruction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGameObjectToPortalObstruction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGameObjectToPortalObstruction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(intPtr, SetGameObjectToPortalObstruction_GameObjectAkComponent_Offset), 0, SetGameObjectToPortalObstruction_GameObjectAkComponent_PropertyAddress.Address, GameObjectAkComponent);
		UObjectMarshaler<UAkPortalComponent>.ToNative(IntPtr.Add(intPtr, SetGameObjectToPortalObstruction_PortalComponent_Offset), 0, SetGameObjectToPortalObstruction_PortalComponent_PropertyAddress.Address, PortalComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGameObjectToPortalObstruction_ObstructionValue_Offset), 0, SetGameObjectToPortalObstruction_ObstructionValue_PropertyAddress.Address, ObstructionValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGameObjectToPortalObstruction_FunctionAddress, intPtr, SetGameObjectToPortalObstruction_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetDummyObjListener")]
	public unsafe static void SetDummyObjListener()
	{
		if (!SetDummyObjListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetDummyObjListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDummyObjListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDummyObjListener_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: SetDummyObjListener_FunctionAddress, argsSize: SetDummyObjListener_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetDistanceProbe")]
	public unsafe static void SetDistanceProbe(AActor Listener, AActor DistanceProbe)
	{
		if (!SetDistanceProbe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetDistanceProbe");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDistanceProbe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDistanceProbe_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetDistanceProbe_Listener_Offset), 0, SetDistanceProbe_Listener_PropertyAddress.Address, Listener);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetDistanceProbe_DistanceProbe_Offset), 0, SetDistanceProbe_DistanceProbe_PropertyAddress.Address, DistanceProbe);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDistanceProbe_FunctionAddress, intPtr, SetDistanceProbe_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCultureAsync")]
	public unsafe static void SetCurrentAudioCultureAsync(string AudioCulture, FOnSetCurrentAudioCultureCallback Completed)
	{
		if (!SetCurrentAudioCultureAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCultureAsync");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentAudioCultureAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentAudioCultureAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentAudioCultureAsync_AudioCulture_Offset), 0, SetCurrentAudioCultureAsync_AudioCulture_PropertyAddress.Address, AudioCulture);
		FDelegateMarshaler<FOnSetCurrentAudioCultureCallback>.ToNative(IntPtr.Add(intPtr, SetCurrentAudioCultureAsync_Completed_Offset), 0, SetCurrentAudioCultureAsync_Completed_PropertyAddress.Address, Completed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentAudioCultureAsync_FunctionAddress, intPtr, SetCurrentAudioCultureAsync_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentAudioCultureAsync_AudioCulture_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCulture")]
	public unsafe static void SetCurrentAudioCulture(string AudioCulture, FLatentActionInfo LatentInfo, UObject WorldContextObject)
	{
		if (!SetCurrentAudioCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCulture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentAudioCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentAudioCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentAudioCulture_AudioCulture_Offset), 0, SetCurrentAudioCulture_AudioCulture_PropertyAddress.Address, AudioCulture);
		NativeReflection.InitializeValue_InContainer(SetCurrentAudioCulture_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, SetCurrentAudioCulture_LatentInfo_Offset), 0, SetCurrentAudioCulture_LatentInfo_PropertyAddress.Address, LatentInfo);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetCurrentAudioCulture_WorldContextObject_Offset), 0, SetCurrentAudioCulture_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentAudioCulture_FunctionAddress, intPtr, SetCurrentAudioCulture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentAudioCulture_AudioCulture_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetBusEffectByName")]
	public unsafe static bool SetBusEffectByName(string InBusName, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
	{
		if (!SetBusEffectByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetBusEffectByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBusEffectByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBusEffectByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBusEffectByName_InBusName_Offset), 0, SetBusEffectByName_InBusName_PropertyAddress.Address, InBusName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBusEffectByName_InEffectIndex_Offset), 0, SetBusEffectByName_InEffectIndex_PropertyAddress.Address, InEffectIndex);
		UObjectMarshaler<UAkEffectShareSet>.ToNative(IntPtr.Add(intPtr, SetBusEffectByName_InEffectShareSet_Offset), 0, SetBusEffectByName_InEffectShareSet_PropertyAddress.Address, InEffectShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBusEffectByName_FunctionAddress, intPtr, SetBusEffectByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBusEffectByName_InBusName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBusEffectByName_ReturnValue_Offset), 0, SetBusEffectByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetBusEffectByID")]
	public unsafe static bool SetBusEffectByID(FAkUniqueID InBusID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
	{
		if (!SetBusEffectByID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetBusEffectByID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBusEffectByID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBusEffectByID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBusEffectByID_InBusID_PropertyAddress.Address, intPtr);
		FAkUniqueID.ToNative(IntPtr.Add(intPtr, SetBusEffectByID_InBusID_Offset), 0, SetBusEffectByID_InBusID_PropertyAddress.Address, InBusID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBusEffectByID_InEffectIndex_Offset), 0, SetBusEffectByID_InEffectIndex_PropertyAddress.Address, InEffectIndex);
		UObjectMarshaler<UAkEffectShareSet>.ToNative(IntPtr.Add(intPtr, SetBusEffectByID_InEffectShareSet_Offset), 0, SetBusEffectByID_InEffectShareSet_PropertyAddress.Address, InEffectShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBusEffectByID_FunctionAddress, intPtr, SetBusEffectByID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBusEffectByID_ReturnValue_Offset), 0, SetBusEffectByID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetBusConfig")]
	public unsafe static void SetBusConfig(string BusName, EAkChannelConfiguration ChannelConfiguration)
	{
		if (!SetBusConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetBusConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBusConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBusConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBusConfig_BusName_Offset), 0, SetBusConfig_BusName_PropertyAddress.Address, BusName);
		EnumMarshaler<EAkChannelConfiguration>.ToNative(IntPtr.Add(intPtr, SetBusConfig_ChannelConfiguration_Offset), 0, SetBusConfig_ChannelConfiguration_PropertyAddress.Address, ChannelConfiguration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBusConfig_FunctionAddress, intPtr, SetBusConfig_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBusConfig_BusName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetAuxBusEffect")]
	public unsafe static bool SetAuxBusEffect(UAkAuxBus InAuxBus, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
	{
		if (!SetAuxBusEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetAuxBusEffect");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAuxBusEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAuxBusEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAuxBus>.ToNative(IntPtr.Add(intPtr, SetAuxBusEffect_InAuxBus_Offset), 0, SetAuxBusEffect_InAuxBus_PropertyAddress.Address, InAuxBus);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAuxBusEffect_InEffectIndex_Offset), 0, SetAuxBusEffect_InEffectIndex_PropertyAddress.Address, InEffectIndex);
		UObjectMarshaler<UAkEffectShareSet>.ToNative(IntPtr.Add(intPtr, SetAuxBusEffect_InEffectShareSet_Offset), 0, SetAuxBusEffect_InEffectShareSet_PropertyAddress.Address, InEffectShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAuxBusEffect_FunctionAddress, intPtr, SetAuxBusEffect_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAuxBusEffect_ReturnValue_Offset), 0, SetAuxBusEffect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:SetActorMixerEffect")]
	public unsafe static bool SetActorMixerEffect(FAkUniqueID InAudioNodeID, int InEffectIndex, UAkEffectShareSet InEffectShareSet)
	{
		if (!SetActorMixerEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:SetActorMixerEffect");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorMixerEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorMixerEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetActorMixerEffect_InAudioNodeID_PropertyAddress.Address, intPtr);
		FAkUniqueID.ToNative(IntPtr.Add(intPtr, SetActorMixerEffect_InAudioNodeID_Offset), 0, SetActorMixerEffect_InAudioNodeID_PropertyAddress.Address, InAudioNodeID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorMixerEffect_InEffectIndex_Offset), 0, SetActorMixerEffect_InEffectIndex_PropertyAddress.Address, InEffectIndex);
		UObjectMarshaler<UAkEffectShareSet>.ToNative(IntPtr.Add(intPtr, SetActorMixerEffect_InEffectShareSet_Offset), 0, SetActorMixerEffect_InEffectShareSet_PropertyAddress.Address, InEffectShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorMixerEffect_FunctionAddress, intPtr, SetActorMixerEffect_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorMixerEffect_ReturnValue_Offset), 0, SetActorMixerEffect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:ResetRTPCValue")]
	public unsafe static void ResetRTPCValue(UAkRtpc RTPCValue, int InterpolationTimeMs, AActor Actor, FName RTPC)
	{
		if (!ResetRTPCValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:ResetRTPCValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetRTPCValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetRTPCValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkRtpc>.ToNative(IntPtr.Add(intPtr, ResetRTPCValue_RTPCValue_Offset), 0, ResetRTPCValue_RTPCValue_PropertyAddress.Address, RTPCValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ResetRTPCValue_InterpolationTimeMs_Offset), 0, ResetRTPCValue_InterpolationTimeMs_PropertyAddress.Address, InterpolationTimeMs);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ResetRTPCValue_Actor_Offset), 0, ResetRTPCValue_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ResetRTPCValue_RTPC_Offset), 0, ResetRTPCValue_RTPC_PropertyAddress.Address, RTPC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetRTPCValue_FunctionAddress, intPtr, ResetRTPCValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:ReplaceMainOutput")]
	public unsafe static void ReplaceMainOutput(FAkOutputSettings MainOutputSettings)
	{
		if (!ReplaceMainOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:ReplaceMainOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceMainOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceMainOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReplaceMainOutput_MainOutputSettings_PropertyAddress.Address, intPtr);
		FAkOutputSettings.ToNative(IntPtr.Add(intPtr, ReplaceMainOutput_MainOutputSettings_Offset), 0, ReplaceMainOutput_MainOutputSettings_PropertyAddress.Address, MainOutputSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceMainOutput_FunctionAddress, intPtr, ReplaceMainOutput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceMainOutput_MainOutputSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:RemoveOutput")]
	public unsafe static void RemoveOutput(FAkOutputDeviceID in_OutputDeviceId)
	{
		if (!RemoveOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:RemoveOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveOutput_in_OutputDeviceId_PropertyAddress.Address, intPtr);
		FAkOutputDeviceID.ToNative(IntPtr.Add(intPtr, RemoveOutput_in_OutputDeviceId_Offset), 0, RemoveOutput_in_OutputDeviceId_PropertyAddress.Address, in_OutputDeviceId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveOutput_FunctionAddress, intPtr, RemoveOutput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:RemoveMotionOutput")]
	public unsafe static void RemoveMotionOutput()
	{
		if (!RemoveMotionOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:RemoveMotionOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMotionOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMotionOutput_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RemoveMotionOutput_FunctionAddress, argsSize: RemoveMotionOutput_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:PostTrigger")]
	public unsafe static void PostTrigger(UAkTrigger TriggerValue, AActor Actor, FName Trigger)
	{
		if (!PostTrigger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:PostTrigger");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostTrigger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostTrigger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkTrigger>.ToNative(IntPtr.Add(intPtr, PostTrigger_TriggerValue_Offset), 0, PostTrigger_TriggerValue_PropertyAddress.Address, TriggerValue);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PostTrigger_Actor_Offset), 0, PostTrigger_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PostTrigger_Trigger_Offset), 0, PostTrigger_Trigger_PropertyAddress.Address, Trigger);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostTrigger_FunctionAddress, intPtr, PostTrigger_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:PostEventOnDummyObj")]
	public unsafe static int PostEventOnDummyObj(UAkAudioEvent AkEvent, string EventName)
	{
		if (!PostEventOnDummyObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:PostEventOnDummyObj");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostEventOnDummyObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEventOnDummyObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostEventOnDummyObj_AkEvent_Offset), 0, PostEventOnDummyObj_AkEvent_PropertyAddress.Address, AkEvent);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostEventOnDummyObj_EventName_Offset), 0, PostEventOnDummyObj_EventName_PropertyAddress.Address, EventName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostEventOnDummyObj_FunctionAddress, intPtr, PostEventOnDummyObj_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostEventOnDummyObj_EventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostEventOnDummyObj_ReturnValue_Offset), 0, PostEventOnDummyObj_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637769u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:PostEventAtLocation")]
	public unsafe static int PostEventAtLocation(UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, string EventName, UObject WorldContextObject)
	{
		if (!PostEventAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:PostEventAtLocation");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostEventAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEventAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostEventAtLocation_AkEvent_Offset), 0, PostEventAtLocation_AkEvent_PropertyAddress.Address, AkEvent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PostEventAtLocation_Location_Offset), 0, PostEventAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, PostEventAtLocation_Orientation_Offset), 0, PostEventAtLocation_Orientation_PropertyAddress.Address, Orientation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostEventAtLocation_EventName_Offset), 0, PostEventAtLocation_EventName_PropertyAddress.Address, EventName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PostEventAtLocation_WorldContextObject_Offset), 0, PostEventAtLocation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostEventAtLocation_FunctionAddress, intPtr, PostEventAtLocation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostEventAtLocation_EventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostEventAtLocation_ReturnValue_Offset), 0, PostEventAtLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:PostEvent")]
	public unsafe static int PostEvent(UAkAudioEvent AkEvent, AActor Actor, int CallbackMask, FOnAkPostEventCallback PostEventCallback, bool bStopWhenAttachedToDestroyed = false, string EventName = null)
	{
		if (!PostEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:PostEvent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostEvent_AkEvent_Offset), 0, PostEvent_AkEvent_PropertyAddress.Address, AkEvent);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PostEvent_Actor_Offset), 0, PostEvent_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostEvent_CallbackMask_Offset), 0, PostEvent_CallbackMask_PropertyAddress.Address, CallbackMask);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, PostEvent_PostEventCallback_Offset), 0, PostEvent_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostEvent_bStopWhenAttachedToDestroyed_Offset), 0, PostEvent_bStopWhenAttachedToDestroyed_PropertyAddress.Address, bStopWhenAttachedToDestroyed);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostEvent_EventName_Offset), 0, PostEvent_EventName_PropertyAddress.Address, EventName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostEvent_FunctionAddress, intPtr, PostEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostEvent_EventName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostEvent_ReturnValue_Offset), 0, PostEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:PostAndWaitForEndOfEvent")]
	public unsafe static int PostAndWaitForEndOfEvent(UAkAudioEvent AkEvent, AActor Actor, bool bStopWhenAttachedToDestroyed, FLatentActionInfo LatentInfo)
	{
		if (!PostAndWaitForEndOfEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:PostAndWaitForEndOfEvent");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAndWaitForEndOfEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAndWaitForEndOfEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, PostAndWaitForEndOfEvent_AkEvent_Offset), 0, PostAndWaitForEndOfEvent_AkEvent_PropertyAddress.Address, AkEvent);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PostAndWaitForEndOfEvent_Actor_Offset), 0, PostAndWaitForEndOfEvent_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_Offset), 0, PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_PropertyAddress.Address, bStopWhenAttachedToDestroyed);
		NativeReflection.InitializeValue_InContainer(PostAndWaitForEndOfEvent_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PostAndWaitForEndOfEvent_LatentInfo_Offset), 0, PostAndWaitForEndOfEvent_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostAndWaitForEndOfEvent_FunctionAddress, intPtr, PostAndWaitForEndOfEvent_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PostAndWaitForEndOfEvent_ReturnValue_Offset), 0, PostAndWaitForEndOfEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:LoadInitBank")]
	public unsafe static void LoadInitBank()
	{
		if (!LoadInitBank_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:LoadInitBank");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadInitBank_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadInitBank_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: LoadInitBank_FunctionAddress, argsSize: LoadInitBank_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:IsGame")]
	public unsafe static bool IsGame(UObject WorldContextObject)
	{
		if (!IsGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:IsGame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsGame_WorldContextObject_Offset), 0, IsGame_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsGame_FunctionAddress, intPtr, IsGame_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGame_ReturnValue_Offset), 0, IsGame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:IsEditor")]
	public unsafe static bool IsEditor()
	{
		if (!IsEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:IsEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsEditor_FunctionAddress, intPtr, IsEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditor_ReturnValue_Offset), 0, IsEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetSpeakerAngles")]
	public unsafe static void GetSpeakerAngles(out List<float> SpeakerAngles, out float HeightAngle, string DeviceShareSet)
	{
		if (!GetSpeakerAngles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetSpeakerAngles");
			SpeakerAngles = null;
			HeightAngle = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpeakerAngles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpeakerAngles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSpeakerAngles_DeviceShareSet_Offset), 0, GetSpeakerAngles_DeviceShareSet_PropertyAddress.Address, DeviceShareSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSpeakerAngles_FunctionAddress, intPtr, GetSpeakerAngles_ParamsSize);
		SpeakerAngles = new TArrayCopyMarshaler<float>(1, GetSpeakerAngles_SpeakerAngles_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSpeakerAngles_SpeakerAngles_Offset));
		NativeReflection.DestroyValue_InContainer(GetSpeakerAngles_SpeakerAngles_PropertyAddress.Address, intPtr);
		HeightAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSpeakerAngles_HeightAngle_Offset), 0, GetSpeakerAngles_HeightAngle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSpeakerAngles_DeviceShareSet_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetRTPCValue")]
	public unsafe static void GetRTPCValue(UAkRtpc RTPCValue, int PlayingID, ERTPCValueType InputValueType, out float Value, out ERTPCValueType OutputValueType, AActor Actor, FName RTPC)
	{
		if (!GetRTPCValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetRTPCValue");
			Value = 0f;
			OutputValueType = ERTPCValueType.Default;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRTPCValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRTPCValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkRtpc>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_RTPCValue_Offset), 0, GetRTPCValue_RTPCValue_PropertyAddress.Address, RTPCValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_PlayingID_Offset), 0, GetRTPCValue_PlayingID_PropertyAddress.Address, PlayingID);
		EnumMarshaler<ERTPCValueType>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_InputValueType_Offset), 0, GetRTPCValue_InputValueType_PropertyAddress.Address, InputValueType);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_Actor_Offset), 0, GetRTPCValue_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRTPCValue_RTPC_Offset), 0, GetRTPCValue_RTPC_PropertyAddress.Address, RTPC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRTPCValue_FunctionAddress, intPtr, GetRTPCValue_ParamsSize);
		Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRTPCValue_Value_Offset), 0, GetRTPCValue_Value_PropertyAddress.Address);
		OutputValueType = EnumMarshaler<ERTPCValueType>.FromNative(IntPtr.Add(intPtr, GetRTPCValue_OutputValueType_Offset), 0, GetRTPCValue_OutputValueType_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetCurrentAudioCulture")]
	public unsafe static string GetCurrentAudioCulture()
	{
		if (!GetCurrentAudioCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetCurrentAudioCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAudioCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAudioCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentAudioCulture_FunctionAddress, intPtr, GetCurrentAudioCulture_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentAudioCulture_ReturnValue_Offset), 0, GetCurrentAudioCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentAudioCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetAvailableAudioCultures")]
	public unsafe static List<string> GetAvailableAudioCultures()
	{
		if (!GetAvailableAudioCultures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetAvailableAudioCultures");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableAudioCultures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableAudioCultures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableAudioCultures_FunctionAddress, intPtr, GetAvailableAudioCultures_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAvailableAudioCultures_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAvailableAudioCultures_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAvailableAudioCultures_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetAkComponent")]
	public unsafe static UAkComponent GetAkComponent(USceneComponent AttachToComponent, out bool ComponentCreated, FName AttachPointName, FVector Location, EAttachLocation LocationType)
	{
		if (!GetAkComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetAkComponent");
			ComponentCreated = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GetAkComponent_AttachToComponent_Offset), 0, GetAkComponent_AttachToComponent_PropertyAddress.Address, AttachToComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAkComponent_AttachPointName_Offset), 0, GetAkComponent_AttachPointName_PropertyAddress.Address, AttachPointName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetAkComponent_Location_Offset), 0, GetAkComponent_Location_PropertyAddress.Address, Location);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, GetAkComponent_LocationType_Offset), 0, GetAkComponent_LocationType_PropertyAddress.Address, LocationType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAkComponent_FunctionAddress, intPtr, GetAkComponent_ParamsSize);
		ComponentCreated = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAkComponent_ComponentCreated_Offset), 0, GetAkComponent_ComponentCreated_PropertyAddress.Address);
		return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(intPtr, GetAkComponent_ReturnValue_Offset), 0, GetAkComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:GetAkAudioTypeUserData")]
	public unsafe static UObject GetAkAudioTypeUserData(UAkAudioType Instance, TSubclassOf<UObject> Type)
	{
		if (!GetAkAudioTypeUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:GetAkAudioTypeUserData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAkAudioTypeUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAkAudioTypeUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAkAudioType>.ToNative(IntPtr.Add(intPtr, GetAkAudioTypeUserData_Instance_Offset), 0, GetAkAudioTypeUserData_Instance_PropertyAddress.Address, Instance);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAkAudioTypeUserData_Type_Offset), 0, GetAkAudioTypeUserData_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAkAudioTypeUserData_FunctionAddress, intPtr, GetAkAudioTypeUserData_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAkAudioTypeUserData_ReturnValue_Offset), 0, GetAkAudioTypeUserData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:ClearSoundBanksAndMedia")]
	public unsafe static void ClearSoundBanksAndMedia()
	{
		if (!ClearSoundBanksAndMedia_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:ClearSoundBanksAndMedia");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSoundBanksAndMedia_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSoundBanksAndMedia_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClearSoundBanksAndMedia_FunctionAddress, argsSize: ClearSoundBanksAndMedia_ParamsSize);
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:CancelEventCallback")]
	public unsafe static void CancelEventCallback(FOnAkPostEventCallback PostEventCallback)
	{
		if (!CancelEventCallback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:CancelEventCallback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelEventCallback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelEventCallback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FOnAkPostEventCallback>.ToNative(IntPtr.Add(intPtr, CancelEventCallback_PostEventCallback_Offset), 0, CancelEventCallback_PostEventCallback_PropertyAddress.Address, PostEventCallback);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CancelEventCallback_FunctionAddress, intPtr, CancelEventCallback_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:AddOutputCaptureMarker")]
	public unsafe static void AddOutputCaptureMarker(string MarkerText)
	{
		if (!AddOutputCaptureMarker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:AddOutputCaptureMarker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOutputCaptureMarker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOutputCaptureMarker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddOutputCaptureMarker_MarkerText_Offset), 0, AddOutputCaptureMarker_MarkerText_PropertyAddress.Address, MarkerText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddOutputCaptureMarker_FunctionAddress, intPtr, AddOutputCaptureMarker_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddOutputCaptureMarker_MarkerText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:AddOutput")]
	public unsafe static void AddOutput(FAkOutputSettings in_Settings, out FAkOutputDeviceID out_DeviceID, ref List<UAkComponent> in_ListenerIDs)
	{
		if (!AddOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:AddOutput");
			out_DeviceID = default(FAkOutputDeviceID);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddOutput_in_Settings_PropertyAddress.Address, intPtr);
		FAkOutputSettings.ToNative(IntPtr.Add(intPtr, AddOutput_in_Settings_Offset), 0, AddOutput_in_Settings_PropertyAddress.Address, in_Settings);
		NativeReflection.InitializeValue_InContainer(AddOutput_out_DeviceID_PropertyAddress.Address, intPtr);
		TArrayCopyMarshaler<UAkComponent> tArrayCopyMarshaler = new TArrayCopyMarshaler<UAkComponent>(1, AddOutput_in_ListenerIDs_PropertyAddress, CachedMarshalingDelegates<UAkComponent, UObjectMarshaler<UAkComponent>>.FromNative, CachedMarshalingDelegates<UAkComponent, UObjectMarshaler<UAkComponent>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, AddOutput_in_ListenerIDs_Offset), in_ListenerIDs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddOutput_FunctionAddress, intPtr, AddOutput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddOutput_in_Settings_PropertyAddress.Address, intPtr);
		out_DeviceID = FAkOutputDeviceID.FromNative(IntPtr.Add(intPtr, AddOutput_out_DeviceID_Offset), 0, AddOutput_out_DeviceID_PropertyAddress.Address);
		in_ListenerIDs = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, AddOutput_in_ListenerIDs_Offset));
		NativeReflection.DestroyValue_InContainer(AddOutput_in_ListenerIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AkAudio.AkGameplayStatics:AddMotionOutput")]
	public unsafe static void AddMotionOutput()
	{
		if (!AddMotionOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkGameplayStatics:AddMotionOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMotionOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMotionOutput_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: AddMotionOutput_FunctionAddress, argsSize: AddMotionOutput_ParamsSize);
	}

	static UAkGameplayStatics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkGameplayStatics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkGameplayStatics));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkGameplayStatics");
		UseReverbVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UseReverbVolumes");
		UseReverbVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(UseReverbVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UseReverbVolumes_inUseReverbVolumes_PropertyAddress, UseReverbVolumes_FunctionAddress, "inUseReverbVolumes");
		UseReverbVolumes_inUseReverbVolumes_Offset = NativeReflectionCached.GetPropertyOffset(UseReverbVolumes_FunctionAddress, "inUseReverbVolumes");
		UseReverbVolumes_inUseReverbVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(UseReverbVolumes_FunctionAddress, "inUseReverbVolumes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseReverbVolumes_Actor_PropertyAddress, UseReverbVolumes_FunctionAddress, "Actor");
		UseReverbVolumes_Actor_Offset = NativeReflectionCached.GetPropertyOffset(UseReverbVolumes_FunctionAddress, "Actor");
		UseReverbVolumes_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(UseReverbVolumes_FunctionAddress, "Actor", Classes.FObjectProperty);
		UseReverbVolumes_IsValid = UseReverbVolumes_FunctionAddress != IntPtr.Zero && UseReverbVolumes_inUseReverbVolumes_IsValid && UseReverbVolumes_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:UseReverbVolumes", UseReverbVolumes_IsValid);
		UnloadInitBank_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnloadInitBank");
		UnloadInitBank_ParamsSize = NativeReflection.GetFunctionParamsSize(UnloadInitBank_FunctionAddress);
		UnloadInitBank_IsValid = UnloadInitBank_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:UnloadInitBank", UnloadInitBank_IsValid);
		StopProfilerCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopProfilerCapture");
		StopProfilerCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(StopProfilerCapture_FunctionAddress);
		StopProfilerCapture_IsValid = StopProfilerCapture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StopProfilerCapture", StopProfilerCapture_IsValid);
		StopOutputCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopOutputCapture");
		StopOutputCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(StopOutputCapture_FunctionAddress);
		StopOutputCapture_IsValid = StopOutputCapture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StopOutputCapture", StopOutputCapture_IsValid);
		StopAllAmbientSounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAllAmbientSounds");
		StopAllAmbientSounds_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllAmbientSounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllAmbientSounds_WorldContextObject_PropertyAddress, StopAllAmbientSounds_FunctionAddress, "WorldContextObject");
		StopAllAmbientSounds_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopAllAmbientSounds_FunctionAddress, "WorldContextObject");
		StopAllAmbientSounds_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllAmbientSounds_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StopAllAmbientSounds_IsValid = StopAllAmbientSounds_FunctionAddress != IntPtr.Zero && StopAllAmbientSounds_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StopAllAmbientSounds", StopAllAmbientSounds_IsValid);
		StopAll_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAll");
		StopAll_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAll_FunctionAddress);
		StopAll_IsValid = StopAll_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StopAll", StopAll_IsValid);
		StopActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopActor");
		StopActor_ParamsSize = NativeReflection.GetFunctionParamsSize(StopActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopActor_Actor_PropertyAddress, StopActor_FunctionAddress, "Actor");
		StopActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(StopActor_FunctionAddress, "Actor");
		StopActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(StopActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		StopActor_IsValid = StopActor_FunctionAddress != IntPtr.Zero && StopActor_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StopActor", StopActor_IsValid);
		StartProfilerCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartProfilerCapture");
		StartProfilerCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(StartProfilerCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartProfilerCapture_Filename_PropertyAddress, StartProfilerCapture_FunctionAddress, "Filename");
		StartProfilerCapture_Filename_Offset = NativeReflectionCached.GetPropertyOffset(StartProfilerCapture_FunctionAddress, "Filename");
		StartProfilerCapture_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(StartProfilerCapture_FunctionAddress, "Filename", Classes.FStrProperty);
		StartProfilerCapture_IsValid = StartProfilerCapture_FunctionAddress != IntPtr.Zero && StartProfilerCapture_Filename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StartProfilerCapture", StartProfilerCapture_IsValid);
		StartOutputCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartOutputCapture");
		StartOutputCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(StartOutputCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartOutputCapture_Filename_PropertyAddress, StartOutputCapture_FunctionAddress, "Filename");
		StartOutputCapture_Filename_Offset = NativeReflectionCached.GetPropertyOffset(StartOutputCapture_FunctionAddress, "Filename");
		StartOutputCapture_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOutputCapture_FunctionAddress, "Filename", Classes.FStrProperty);
		StartOutputCapture_IsValid = StartOutputCapture_FunctionAddress != IntPtr.Zero && StartOutputCapture_Filename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StartOutputCapture", StartOutputCapture_IsValid);
		StartAllAmbientSounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartAllAmbientSounds");
		StartAllAmbientSounds_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAllAmbientSounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAllAmbientSounds_WorldContextObject_PropertyAddress, StartAllAmbientSounds_FunctionAddress, "WorldContextObject");
		StartAllAmbientSounds_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartAllAmbientSounds_FunctionAddress, "WorldContextObject");
		StartAllAmbientSounds_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAllAmbientSounds_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StartAllAmbientSounds_IsValid = StartAllAmbientSounds_FunctionAddress != IntPtr.Zero && StartAllAmbientSounds_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:StartAllAmbientSounds", StartAllAmbientSounds_IsValid);
		SpawnAkComponentAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnAkComponentAtLocation");
		SpawnAkComponentAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnAkComponentAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_WorldContextObject_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "WorldContextObject");
		SpawnAkComponentAtLocation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "WorldContextObject");
		SpawnAkComponentAtLocation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_AkEvent_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "AkEvent");
		SpawnAkComponentAtLocation_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "AkEvent");
		SpawnAkComponentAtLocation_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_Location_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "Location");
		SpawnAkComponentAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "Location");
		SpawnAkComponentAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_Orientation_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "Orientation");
		SpawnAkComponentAtLocation_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "Orientation");
		SpawnAkComponentAtLocation_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_AutoPost_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "AutoPost");
		SpawnAkComponentAtLocation_AutoPost_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "AutoPost");
		SpawnAkComponentAtLocation_AutoPost_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "AutoPost", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_EventName_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "EventName");
		SpawnAkComponentAtLocation_EventName_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "EventName");
		SpawnAkComponentAtLocation_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_AutoDestroy_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "AutoDestroy");
		SpawnAkComponentAtLocation_AutoDestroy_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "AutoDestroy");
		SpawnAkComponentAtLocation_AutoDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "AutoDestroy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAkComponentAtLocation_ReturnValue_PropertyAddress, SpawnAkComponentAtLocation_FunctionAddress, "ReturnValue");
		SpawnAkComponentAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAkComponentAtLocation_FunctionAddress, "ReturnValue");
		SpawnAkComponentAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAkComponentAtLocation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnAkComponentAtLocation_IsValid = SpawnAkComponentAtLocation_FunctionAddress != IntPtr.Zero && SpawnAkComponentAtLocation_WorldContextObject_IsValid && SpawnAkComponentAtLocation_AkEvent_IsValid && SpawnAkComponentAtLocation_Location_IsValid && SpawnAkComponentAtLocation_Orientation_IsValid && SpawnAkComponentAtLocation_AutoPost_IsValid && SpawnAkComponentAtLocation_EventName_IsValid && SpawnAkComponentAtLocation_AutoDestroy_IsValid && SpawnAkComponentAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SpawnAkComponentAtLocation", SpawnAkComponentAtLocation_IsValid);
		SetSwitch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSwitch");
		SetSwitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSwitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchValue_PropertyAddress, SetSwitch_FunctionAddress, "SwitchValue");
		SetSwitch_SwitchValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchValue");
		SetSwitch_SwitchValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_Actor_PropertyAddress, SetSwitch_FunctionAddress, "Actor");
		SetSwitch_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "Actor");
		SetSwitch_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchGroup_PropertyAddress, SetSwitch_FunctionAddress, "SwitchGroup");
		SetSwitch_SwitchGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchGroup");
		SetSwitch_SwitchGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSwitch_SwitchState_PropertyAddress, SetSwitch_FunctionAddress, "SwitchState");
		SetSwitch_SwitchState_Offset = NativeReflectionCached.GetPropertyOffset(SetSwitch_FunctionAddress, "SwitchState");
		SetSwitch_SwitchState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSwitch_FunctionAddress, "SwitchState", Classes.FNameProperty);
		SetSwitch_IsValid = SetSwitch_FunctionAddress != IntPtr.Zero && SetSwitch_SwitchValue_IsValid && SetSwitch_Actor_IsValid && SetSwitch_SwitchGroup_IsValid && SetSwitch_SwitchState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetSwitch", SetSwitch_IsValid);
		SetState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetState");
		SetState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetState_StateValue_PropertyAddress, SetState_FunctionAddress, "StateValue");
		SetState_StateValue_Offset = NativeReflectionCached.GetPropertyOffset(SetState_FunctionAddress, "StateValue");
		SetState_StateValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetState_FunctionAddress, "StateValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetState_StateGroup_PropertyAddress, SetState_FunctionAddress, "StateGroup");
		SetState_StateGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetState_FunctionAddress, "StateGroup");
		SetState_StateGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetState_FunctionAddress, "StateGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetState_State_PropertyAddress, SetState_FunctionAddress, "State");
		SetState_State_Offset = NativeReflectionCached.GetPropertyOffset(SetState_FunctionAddress, "State");
		SetState_State_IsValid = NativeReflectionCached.ValidatePropertyClass(SetState_FunctionAddress, "State", Classes.FNameProperty);
		SetState_IsValid = SetState_FunctionAddress != IntPtr.Zero && SetState_StateValue_IsValid && SetState_StateGroup_IsValid && SetState_State_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetState", SetState_IsValid);
		SetSpeakerAngles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSpeakerAngles");
		SetSpeakerAngles_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpeakerAngles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpeakerAngles_SpeakerAngles_PropertyAddress, SetSpeakerAngles_FunctionAddress, "SpeakerAngles");
		SetSpeakerAngles_SpeakerAngles_Offset = NativeReflectionCached.GetPropertyOffset(SetSpeakerAngles_FunctionAddress, "SpeakerAngles");
		SetSpeakerAngles_SpeakerAngles_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpeakerAngles_FunctionAddress, "SpeakerAngles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpeakerAngles_HeightAngle_PropertyAddress, SetSpeakerAngles_FunctionAddress, "HeightAngle");
		SetSpeakerAngles_HeightAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetSpeakerAngles_FunctionAddress, "HeightAngle");
		SetSpeakerAngles_HeightAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpeakerAngles_FunctionAddress, "HeightAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSpeakerAngles_DeviceShareSet_PropertyAddress, SetSpeakerAngles_FunctionAddress, "DeviceShareSet");
		SetSpeakerAngles_DeviceShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetSpeakerAngles_FunctionAddress, "DeviceShareSet");
		SetSpeakerAngles_DeviceShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpeakerAngles_FunctionAddress, "DeviceShareSet", Classes.FStrProperty);
		SetSpeakerAngles_IsValid = SetSpeakerAngles_FunctionAddress != IntPtr.Zero && SetSpeakerAngles_SpeakerAngles_IsValid && SetSpeakerAngles_HeightAngle_IsValid && SetSpeakerAngles_DeviceShareSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetSpeakerAngles", SetSpeakerAngles_IsValid);
		SetRTPCValueByPlayingID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRTPCValueByPlayingID");
		SetRTPCValueByPlayingID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRTPCValueByPlayingID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValueByPlayingID_PlayingID_PropertyAddress, SetRTPCValueByPlayingID_FunctionAddress, "PlayingID");
		SetRTPCValueByPlayingID_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValueByPlayingID_FunctionAddress, "PlayingID");
		SetRTPCValueByPlayingID_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValueByPlayingID_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValueByPlayingID_Value_PropertyAddress, SetRTPCValueByPlayingID_FunctionAddress, "Value");
		SetRTPCValueByPlayingID_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValueByPlayingID_FunctionAddress, "Value");
		SetRTPCValueByPlayingID_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValueByPlayingID_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValueByPlayingID_RTPC_PropertyAddress, SetRTPCValueByPlayingID_FunctionAddress, "RTPC");
		SetRTPCValueByPlayingID_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValueByPlayingID_FunctionAddress, "RTPC");
		SetRTPCValueByPlayingID_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValueByPlayingID_FunctionAddress, "RTPC", Classes.FNameProperty);
		SetRTPCValueByPlayingID_IsValid = SetRTPCValueByPlayingID_FunctionAddress != IntPtr.Zero && SetRTPCValueByPlayingID_PlayingID_IsValid && SetRTPCValueByPlayingID_Value_IsValid && SetRTPCValueByPlayingID_RTPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetRTPCValueByPlayingID", SetRTPCValueByPlayingID_IsValid);
		SetRTPCValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRTPCValue");
		SetRTPCValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRTPCValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_RTPCValue_PropertyAddress, SetRTPCValue_FunctionAddress, "RTPCValue");
		SetRTPCValue_RTPCValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "RTPCValue");
		SetRTPCValue_RTPCValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "RTPCValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_Value_PropertyAddress, SetRTPCValue_FunctionAddress, "Value");
		SetRTPCValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "Value");
		SetRTPCValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_InterpolationTimeMs_PropertyAddress, SetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		SetRTPCValue_InterpolationTimeMs_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		SetRTPCValue_InterpolationTimeMs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "InterpolationTimeMs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_Actor_PropertyAddress, SetRTPCValue_FunctionAddress, "Actor");
		SetRTPCValue_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "Actor");
		SetRTPCValue_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRTPCValue_RTPC_PropertyAddress, SetRTPCValue_FunctionAddress, "RTPC");
		SetRTPCValue_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(SetRTPCValue_FunctionAddress, "RTPC");
		SetRTPCValue_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTPCValue_FunctionAddress, "RTPC", Classes.FNameProperty);
		SetRTPCValue_IsValid = SetRTPCValue_FunctionAddress != IntPtr.Zero && SetRTPCValue_RTPCValue_IsValid && SetRTPCValue_Value_IsValid && SetRTPCValue_InterpolationTimeMs_IsValid && SetRTPCValue_Actor_IsValid && SetRTPCValue_RTPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetRTPCValue", SetRTPCValue_IsValid);
		SetReflectionsOrder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetReflectionsOrder");
		SetReflectionsOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflectionsOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionsOrder_Order_PropertyAddress, SetReflectionsOrder_FunctionAddress, "Order");
		SetReflectionsOrder_Order_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionsOrder_FunctionAddress, "Order");
		SetReflectionsOrder_Order_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionsOrder_FunctionAddress, "Order", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionsOrder_RefreshPaths_PropertyAddress, SetReflectionsOrder_FunctionAddress, "RefreshPaths");
		SetReflectionsOrder_RefreshPaths_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionsOrder_FunctionAddress, "RefreshPaths");
		SetReflectionsOrder_RefreshPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionsOrder_FunctionAddress, "RefreshPaths", Classes.FBoolProperty);
		SetReflectionsOrder_IsValid = SetReflectionsOrder_FunctionAddress != IntPtr.Zero && SetReflectionsOrder_Order_IsValid && SetReflectionsOrder_RefreshPaths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetReflectionsOrder", SetReflectionsOrder_IsValid);
		SetPortalToPortalObstruction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPortalToPortalObstruction");
		SetPortalToPortalObstruction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPortalToPortalObstruction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPortalToPortalObstruction_PortalComponent0_PropertyAddress, SetPortalToPortalObstruction_FunctionAddress, "PortalComponent0");
		SetPortalToPortalObstruction_PortalComponent0_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalToPortalObstruction_FunctionAddress, "PortalComponent0");
		SetPortalToPortalObstruction_PortalComponent0_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalToPortalObstruction_FunctionAddress, "PortalComponent0", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPortalToPortalObstruction_PortalComponent1_PropertyAddress, SetPortalToPortalObstruction_FunctionAddress, "PortalComponent1");
		SetPortalToPortalObstruction_PortalComponent1_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalToPortalObstruction_FunctionAddress, "PortalComponent1");
		SetPortalToPortalObstruction_PortalComponent1_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalToPortalObstruction_FunctionAddress, "PortalComponent1", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPortalToPortalObstruction_ObstructionValue_PropertyAddress, SetPortalToPortalObstruction_FunctionAddress, "ObstructionValue");
		SetPortalToPortalObstruction_ObstructionValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalToPortalObstruction_FunctionAddress, "ObstructionValue");
		SetPortalToPortalObstruction_ObstructionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalToPortalObstruction_FunctionAddress, "ObstructionValue", Classes.FFloatProperty);
		SetPortalToPortalObstruction_IsValid = SetPortalToPortalObstruction_FunctionAddress != IntPtr.Zero && SetPortalToPortalObstruction_PortalComponent0_IsValid && SetPortalToPortalObstruction_PortalComponent1_IsValid && SetPortalToPortalObstruction_ObstructionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetPortalToPortalObstruction", SetPortalToPortalObstruction_IsValid);
		SetPortalObstructionAndOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPortalObstructionAndOcclusion");
		SetPortalObstructionAndOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPortalObstructionAndOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPortalObstructionAndOcclusion_PortalComponent_PropertyAddress, SetPortalObstructionAndOcclusion_FunctionAddress, "PortalComponent");
		SetPortalObstructionAndOcclusion_PortalComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalObstructionAndOcclusion_FunctionAddress, "PortalComponent");
		SetPortalObstructionAndOcclusion_PortalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalObstructionAndOcclusion_FunctionAddress, "PortalComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPortalObstructionAndOcclusion_ObstructionValue_PropertyAddress, SetPortalObstructionAndOcclusion_FunctionAddress, "ObstructionValue");
		SetPortalObstructionAndOcclusion_ObstructionValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalObstructionAndOcclusion_FunctionAddress, "ObstructionValue");
		SetPortalObstructionAndOcclusion_ObstructionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalObstructionAndOcclusion_FunctionAddress, "ObstructionValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPortalObstructionAndOcclusion_OcclusionValue_PropertyAddress, SetPortalObstructionAndOcclusion_FunctionAddress, "OcclusionValue");
		SetPortalObstructionAndOcclusion_OcclusionValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPortalObstructionAndOcclusion_FunctionAddress, "OcclusionValue");
		SetPortalObstructionAndOcclusion_OcclusionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortalObstructionAndOcclusion_FunctionAddress, "OcclusionValue", Classes.FFloatProperty);
		SetPortalObstructionAndOcclusion_IsValid = SetPortalObstructionAndOcclusion_FunctionAddress != IntPtr.Zero && SetPortalObstructionAndOcclusion_PortalComponent_IsValid && SetPortalObstructionAndOcclusion_ObstructionValue_IsValid && SetPortalObstructionAndOcclusion_OcclusionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetPortalObstructionAndOcclusion", SetPortalObstructionAndOcclusion_IsValid);
		SetPanningRule_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPanningRule");
		SetPanningRule_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPanningRule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPanningRule_PanRule_PropertyAddress, SetPanningRule_FunctionAddress, "PanRule");
		SetPanningRule_PanRule_Offset = NativeReflectionCached.GetPropertyOffset(SetPanningRule_FunctionAddress, "PanRule");
		SetPanningRule_PanRule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPanningRule_FunctionAddress, "PanRule", Classes.FEnumProperty);
		SetPanningRule_IsValid = SetPanningRule_FunctionAddress != IntPtr.Zero && SetPanningRule_PanRule_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetPanningRule", SetPanningRule_IsValid);
		SetOutputDeviceEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOutputDeviceEffect");
		SetOutputDeviceEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputDeviceEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputDeviceEffect_InDeviceID_PropertyAddress, SetOutputDeviceEffect_FunctionAddress, "InDeviceID");
		SetOutputDeviceEffect_InDeviceID_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputDeviceEffect_FunctionAddress, "InDeviceID");
		SetOutputDeviceEffect_InDeviceID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputDeviceEffect_FunctionAddress, "InDeviceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOutputDeviceEffect_InEffectIndex_PropertyAddress, SetOutputDeviceEffect_FunctionAddress, "InEffectIndex");
		SetOutputDeviceEffect_InEffectIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputDeviceEffect_FunctionAddress, "InEffectIndex");
		SetOutputDeviceEffect_InEffectIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputDeviceEffect_FunctionAddress, "InEffectIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOutputDeviceEffect_InEffectShareSet_PropertyAddress, SetOutputDeviceEffect_FunctionAddress, "InEffectShareSet");
		SetOutputDeviceEffect_InEffectShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputDeviceEffect_FunctionAddress, "InEffectShareSet");
		SetOutputDeviceEffect_InEffectShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputDeviceEffect_FunctionAddress, "InEffectShareSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOutputDeviceEffect_ReturnValue_PropertyAddress, SetOutputDeviceEffect_FunctionAddress, "ReturnValue");
		SetOutputDeviceEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputDeviceEffect_FunctionAddress, "ReturnValue");
		SetOutputDeviceEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputDeviceEffect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetOutputDeviceEffect_IsValid = SetOutputDeviceEffect_FunctionAddress != IntPtr.Zero && SetOutputDeviceEffect_InDeviceID_IsValid && SetOutputDeviceEffect_InEffectIndex_IsValid && SetOutputDeviceEffect_InEffectShareSet_IsValid && SetOutputDeviceEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetOutputDeviceEffect", SetOutputDeviceEffect_IsValid);
		SetOutputBusVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOutputBusVolume");
		SetOutputBusVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputBusVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputBusVolume_BusVolume_PropertyAddress, SetOutputBusVolume_FunctionAddress, "BusVolume");
		SetOutputBusVolume_BusVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputBusVolume_FunctionAddress, "BusVolume");
		SetOutputBusVolume_BusVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputBusVolume_FunctionAddress, "BusVolume", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOutputBusVolume_Actor_PropertyAddress, SetOutputBusVolume_FunctionAddress, "Actor");
		SetOutputBusVolume_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputBusVolume_FunctionAddress, "Actor");
		SetOutputBusVolume_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputBusVolume_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetOutputBusVolume_IsValid = SetOutputBusVolume_FunctionAddress != IntPtr.Zero && SetOutputBusVolume_BusVolume_IsValid && SetOutputBusVolume_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetOutputBusVolume", SetOutputBusVolume_IsValid);
		SetOcclusionRefreshInterval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOcclusionRefreshInterval");
		SetOcclusionRefreshInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionRefreshInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionRefreshInterval_RefreshInterval_PropertyAddress, SetOcclusionRefreshInterval_FunctionAddress, "RefreshInterval");
		SetOcclusionRefreshInterval_RefreshInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionRefreshInterval_FunctionAddress, "RefreshInterval");
		SetOcclusionRefreshInterval_RefreshInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionRefreshInterval_FunctionAddress, "RefreshInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionRefreshInterval_Actor_PropertyAddress, SetOcclusionRefreshInterval_FunctionAddress, "Actor");
		SetOcclusionRefreshInterval_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionRefreshInterval_FunctionAddress, "Actor");
		SetOcclusionRefreshInterval_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionRefreshInterval_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetOcclusionRefreshInterval_IsValid = SetOcclusionRefreshInterval_FunctionAddress != IntPtr.Zero && SetOcclusionRefreshInterval_RefreshInterval_IsValid && SetOcclusionRefreshInterval_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetOcclusionRefreshInterval", SetOcclusionRefreshInterval_IsValid);
		SetMultiplePositions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMultiplePositions");
		SetMultiplePositions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMultiplePositions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMultiplePositions_GameObjectAkComponent_PropertyAddress, SetMultiplePositions_FunctionAddress, "GameObjectAkComponent");
		SetMultiplePositions_GameObjectAkComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetMultiplePositions_FunctionAddress, "GameObjectAkComponent");
		SetMultiplePositions_GameObjectAkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultiplePositions_FunctionAddress, "GameObjectAkComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultiplePositions_Positions_PropertyAddress, SetMultiplePositions_FunctionAddress, "Positions");
		SetMultiplePositions_Positions_Offset = NativeReflectionCached.GetPropertyOffset(SetMultiplePositions_FunctionAddress, "Positions");
		SetMultiplePositions_Positions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultiplePositions_FunctionAddress, "Positions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultiplePositions_MultiPositionType_PropertyAddress, SetMultiplePositions_FunctionAddress, "MultiPositionType");
		SetMultiplePositions_MultiPositionType_Offset = NativeReflectionCached.GetPropertyOffset(SetMultiplePositions_FunctionAddress, "MultiPositionType");
		SetMultiplePositions_MultiPositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultiplePositions_FunctionAddress, "MultiPositionType", Classes.FEnumProperty);
		SetMultiplePositions_IsValid = SetMultiplePositions_FunctionAddress != IntPtr.Zero && SetMultiplePositions_GameObjectAkComponent_IsValid && SetMultiplePositions_Positions_IsValid && SetMultiplePositions_MultiPositionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetMultiplePositions", SetMultiplePositions_IsValid);
		SetMultipleChannelMaskEmitterPositions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMultipleChannelMaskEmitterPositions");
		SetMultipleChannelMaskEmitterPositions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMultipleChannelMaskEmitterPositions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_PropertyAddress, SetMultipleChannelMaskEmitterPositions_FunctionAddress, "GameObjectAkComponent");
		SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "GameObjectAkComponent");
		SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "GameObjectAkComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelMaskEmitterPositions_ChannelMasks_PropertyAddress, SetMultipleChannelMaskEmitterPositions_FunctionAddress, "ChannelMasks");
		SetMultipleChannelMaskEmitterPositions_ChannelMasks_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "ChannelMasks");
		SetMultipleChannelMaskEmitterPositions_ChannelMasks_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "ChannelMasks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelMaskEmitterPositions_Positions_PropertyAddress, SetMultipleChannelMaskEmitterPositions_FunctionAddress, "Positions");
		SetMultipleChannelMaskEmitterPositions_Positions_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "Positions");
		SetMultipleChannelMaskEmitterPositions_Positions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "Positions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelMaskEmitterPositions_MultiPositionType_PropertyAddress, SetMultipleChannelMaskEmitterPositions_FunctionAddress, "MultiPositionType");
		SetMultipleChannelMaskEmitterPositions_MultiPositionType_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "MultiPositionType");
		SetMultipleChannelMaskEmitterPositions_MultiPositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelMaskEmitterPositions_FunctionAddress, "MultiPositionType", Classes.FEnumProperty);
		SetMultipleChannelMaskEmitterPositions_IsValid = SetMultipleChannelMaskEmitterPositions_FunctionAddress != IntPtr.Zero && SetMultipleChannelMaskEmitterPositions_GameObjectAkComponent_IsValid && SetMultipleChannelMaskEmitterPositions_ChannelMasks_IsValid && SetMultipleChannelMaskEmitterPositions_Positions_IsValid && SetMultipleChannelMaskEmitterPositions_MultiPositionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelMaskEmitterPositions", SetMultipleChannelMaskEmitterPositions_IsValid);
		SetMultipleChannelEmitterPositions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMultipleChannelEmitterPositions");
		SetMultipleChannelEmitterPositions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMultipleChannelEmitterPositions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelEmitterPositions_GameObjectAkComponent_PropertyAddress, SetMultipleChannelEmitterPositions_FunctionAddress, "GameObjectAkComponent");
		SetMultipleChannelEmitterPositions_GameObjectAkComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelEmitterPositions_FunctionAddress, "GameObjectAkComponent");
		SetMultipleChannelEmitterPositions_GameObjectAkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelEmitterPositions_FunctionAddress, "GameObjectAkComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelEmitterPositions_ChannelMasks_PropertyAddress, SetMultipleChannelEmitterPositions_FunctionAddress, "ChannelMasks");
		SetMultipleChannelEmitterPositions_ChannelMasks_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelEmitterPositions_FunctionAddress, "ChannelMasks");
		SetMultipleChannelEmitterPositions_ChannelMasks_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelEmitterPositions_FunctionAddress, "ChannelMasks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelEmitterPositions_Positions_PropertyAddress, SetMultipleChannelEmitterPositions_FunctionAddress, "Positions");
		SetMultipleChannelEmitterPositions_Positions_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelEmitterPositions_FunctionAddress, "Positions");
		SetMultipleChannelEmitterPositions_Positions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelEmitterPositions_FunctionAddress, "Positions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMultipleChannelEmitterPositions_MultiPositionType_PropertyAddress, SetMultipleChannelEmitterPositions_FunctionAddress, "MultiPositionType");
		SetMultipleChannelEmitterPositions_MultiPositionType_Offset = NativeReflectionCached.GetPropertyOffset(SetMultipleChannelEmitterPositions_FunctionAddress, "MultiPositionType");
		SetMultipleChannelEmitterPositions_MultiPositionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMultipleChannelEmitterPositions_FunctionAddress, "MultiPositionType", Classes.FEnumProperty);
		SetMultipleChannelEmitterPositions_IsValid = SetMultipleChannelEmitterPositions_FunctionAddress != IntPtr.Zero && SetMultipleChannelEmitterPositions_GameObjectAkComponent_IsValid && SetMultipleChannelEmitterPositions_ChannelMasks_IsValid && SetMultipleChannelEmitterPositions_Positions_IsValid && SetMultipleChannelEmitterPositions_MultiPositionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetMultipleChannelEmitterPositions", SetMultipleChannelEmitterPositions_IsValid);
		SetGameObjectToPortalObstruction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGameObjectToPortalObstruction");
		SetGameObjectToPortalObstruction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGameObjectToPortalObstruction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGameObjectToPortalObstruction_GameObjectAkComponent_PropertyAddress, SetGameObjectToPortalObstruction_FunctionAddress, "GameObjectAkComponent");
		SetGameObjectToPortalObstruction_GameObjectAkComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetGameObjectToPortalObstruction_FunctionAddress, "GameObjectAkComponent");
		SetGameObjectToPortalObstruction_GameObjectAkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameObjectToPortalObstruction_FunctionAddress, "GameObjectAkComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGameObjectToPortalObstruction_PortalComponent_PropertyAddress, SetGameObjectToPortalObstruction_FunctionAddress, "PortalComponent");
		SetGameObjectToPortalObstruction_PortalComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetGameObjectToPortalObstruction_FunctionAddress, "PortalComponent");
		SetGameObjectToPortalObstruction_PortalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameObjectToPortalObstruction_FunctionAddress, "PortalComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGameObjectToPortalObstruction_ObstructionValue_PropertyAddress, SetGameObjectToPortalObstruction_FunctionAddress, "ObstructionValue");
		SetGameObjectToPortalObstruction_ObstructionValue_Offset = NativeReflectionCached.GetPropertyOffset(SetGameObjectToPortalObstruction_FunctionAddress, "ObstructionValue");
		SetGameObjectToPortalObstruction_ObstructionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameObjectToPortalObstruction_FunctionAddress, "ObstructionValue", Classes.FFloatProperty);
		SetGameObjectToPortalObstruction_IsValid = SetGameObjectToPortalObstruction_FunctionAddress != IntPtr.Zero && SetGameObjectToPortalObstruction_GameObjectAkComponent_IsValid && SetGameObjectToPortalObstruction_PortalComponent_IsValid && SetGameObjectToPortalObstruction_ObstructionValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetGameObjectToPortalObstruction", SetGameObjectToPortalObstruction_IsValid);
		SetDummyObjListener_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDummyObjListener");
		SetDummyObjListener_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDummyObjListener_FunctionAddress);
		SetDummyObjListener_IsValid = SetDummyObjListener_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetDummyObjListener", SetDummyObjListener_IsValid);
		SetDistanceProbe_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDistanceProbe");
		SetDistanceProbe_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDistanceProbe_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDistanceProbe_Listener_PropertyAddress, SetDistanceProbe_FunctionAddress, "Listener");
		SetDistanceProbe_Listener_Offset = NativeReflectionCached.GetPropertyOffset(SetDistanceProbe_FunctionAddress, "Listener");
		SetDistanceProbe_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDistanceProbe_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDistanceProbe_DistanceProbe_PropertyAddress, SetDistanceProbe_FunctionAddress, "DistanceProbe");
		SetDistanceProbe_DistanceProbe_Offset = NativeReflectionCached.GetPropertyOffset(SetDistanceProbe_FunctionAddress, "DistanceProbe");
		SetDistanceProbe_DistanceProbe_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDistanceProbe_FunctionAddress, "DistanceProbe", Classes.FObjectProperty);
		SetDistanceProbe_IsValid = SetDistanceProbe_FunctionAddress != IntPtr.Zero && SetDistanceProbe_Listener_IsValid && SetDistanceProbe_DistanceProbe_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetDistanceProbe", SetDistanceProbe_IsValid);
		SetCurrentAudioCultureAsync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentAudioCultureAsync");
		SetCurrentAudioCultureAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentAudioCultureAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAudioCultureAsync_AudioCulture_PropertyAddress, SetCurrentAudioCultureAsync_FunctionAddress, "AudioCulture");
		SetCurrentAudioCultureAsync_AudioCulture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAudioCultureAsync_FunctionAddress, "AudioCulture");
		SetCurrentAudioCultureAsync_AudioCulture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAudioCultureAsync_FunctionAddress, "AudioCulture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAudioCultureAsync_Completed_PropertyAddress, SetCurrentAudioCultureAsync_FunctionAddress, "Completed");
		SetCurrentAudioCultureAsync_Completed_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAudioCultureAsync_FunctionAddress, "Completed");
		SetCurrentAudioCultureAsync_Completed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAudioCultureAsync_FunctionAddress, "Completed", Classes.FDelegateProperty);
		SetCurrentAudioCultureAsync_IsValid = SetCurrentAudioCultureAsync_FunctionAddress != IntPtr.Zero && SetCurrentAudioCultureAsync_AudioCulture_IsValid && SetCurrentAudioCultureAsync_Completed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCultureAsync", SetCurrentAudioCultureAsync_IsValid);
		SetCurrentAudioCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentAudioCulture");
		SetCurrentAudioCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentAudioCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAudioCulture_AudioCulture_PropertyAddress, SetCurrentAudioCulture_FunctionAddress, "AudioCulture");
		SetCurrentAudioCulture_AudioCulture_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAudioCulture_FunctionAddress, "AudioCulture");
		SetCurrentAudioCulture_AudioCulture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAudioCulture_FunctionAddress, "AudioCulture", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAudioCulture_LatentInfo_PropertyAddress, SetCurrentAudioCulture_FunctionAddress, "LatentInfo");
		SetCurrentAudioCulture_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAudioCulture_FunctionAddress, "LatentInfo");
		SetCurrentAudioCulture_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAudioCulture_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentAudioCulture_WorldContextObject_PropertyAddress, SetCurrentAudioCulture_FunctionAddress, "WorldContextObject");
		SetCurrentAudioCulture_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentAudioCulture_FunctionAddress, "WorldContextObject");
		SetCurrentAudioCulture_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentAudioCulture_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		SetCurrentAudioCulture_IsValid = SetCurrentAudioCulture_FunctionAddress != IntPtr.Zero && SetCurrentAudioCulture_AudioCulture_IsValid && SetCurrentAudioCulture_LatentInfo_IsValid && SetCurrentAudioCulture_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetCurrentAudioCulture", SetCurrentAudioCulture_IsValid);
		SetBusEffectByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBusEffectByName");
		SetBusEffectByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBusEffectByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByName_InBusName_PropertyAddress, SetBusEffectByName_FunctionAddress, "InBusName");
		SetBusEffectByName_InBusName_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByName_FunctionAddress, "InBusName");
		SetBusEffectByName_InBusName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByName_FunctionAddress, "InBusName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByName_InEffectIndex_PropertyAddress, SetBusEffectByName_FunctionAddress, "InEffectIndex");
		SetBusEffectByName_InEffectIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByName_FunctionAddress, "InEffectIndex");
		SetBusEffectByName_InEffectIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByName_FunctionAddress, "InEffectIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByName_InEffectShareSet_PropertyAddress, SetBusEffectByName_FunctionAddress, "InEffectShareSet");
		SetBusEffectByName_InEffectShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByName_FunctionAddress, "InEffectShareSet");
		SetBusEffectByName_InEffectShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByName_FunctionAddress, "InEffectShareSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByName_ReturnValue_PropertyAddress, SetBusEffectByName_FunctionAddress, "ReturnValue");
		SetBusEffectByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByName_FunctionAddress, "ReturnValue");
		SetBusEffectByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBusEffectByName_IsValid = SetBusEffectByName_FunctionAddress != IntPtr.Zero && SetBusEffectByName_InBusName_IsValid && SetBusEffectByName_InEffectIndex_IsValid && SetBusEffectByName_InEffectShareSet_IsValid && SetBusEffectByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetBusEffectByName", SetBusEffectByName_IsValid);
		SetBusEffectByID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBusEffectByID");
		SetBusEffectByID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBusEffectByID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByID_InBusID_PropertyAddress, SetBusEffectByID_FunctionAddress, "InBusID");
		SetBusEffectByID_InBusID_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByID_FunctionAddress, "InBusID");
		SetBusEffectByID_InBusID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByID_FunctionAddress, "InBusID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByID_InEffectIndex_PropertyAddress, SetBusEffectByID_FunctionAddress, "InEffectIndex");
		SetBusEffectByID_InEffectIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByID_FunctionAddress, "InEffectIndex");
		SetBusEffectByID_InEffectIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByID_FunctionAddress, "InEffectIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByID_InEffectShareSet_PropertyAddress, SetBusEffectByID_FunctionAddress, "InEffectShareSet");
		SetBusEffectByID_InEffectShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByID_FunctionAddress, "InEffectShareSet");
		SetBusEffectByID_InEffectShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByID_FunctionAddress, "InEffectShareSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusEffectByID_ReturnValue_PropertyAddress, SetBusEffectByID_FunctionAddress, "ReturnValue");
		SetBusEffectByID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBusEffectByID_FunctionAddress, "ReturnValue");
		SetBusEffectByID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusEffectByID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBusEffectByID_IsValid = SetBusEffectByID_FunctionAddress != IntPtr.Zero && SetBusEffectByID_InBusID_IsValid && SetBusEffectByID_InEffectIndex_IsValid && SetBusEffectByID_InEffectShareSet_IsValid && SetBusEffectByID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetBusEffectByID", SetBusEffectByID_IsValid);
		SetBusConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBusConfig");
		SetBusConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBusConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBusConfig_BusName_PropertyAddress, SetBusConfig_FunctionAddress, "BusName");
		SetBusConfig_BusName_Offset = NativeReflectionCached.GetPropertyOffset(SetBusConfig_FunctionAddress, "BusName");
		SetBusConfig_BusName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusConfig_FunctionAddress, "BusName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBusConfig_ChannelConfiguration_PropertyAddress, SetBusConfig_FunctionAddress, "ChannelConfiguration");
		SetBusConfig_ChannelConfiguration_Offset = NativeReflectionCached.GetPropertyOffset(SetBusConfig_FunctionAddress, "ChannelConfiguration");
		SetBusConfig_ChannelConfiguration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBusConfig_FunctionAddress, "ChannelConfiguration", Classes.FEnumProperty);
		SetBusConfig_IsValid = SetBusConfig_FunctionAddress != IntPtr.Zero && SetBusConfig_BusName_IsValid && SetBusConfig_ChannelConfiguration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetBusConfig", SetBusConfig_IsValid);
		SetAuxBusEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAuxBusEffect");
		SetAuxBusEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAuxBusEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAuxBusEffect_InAuxBus_PropertyAddress, SetAuxBusEffect_FunctionAddress, "InAuxBus");
		SetAuxBusEffect_InAuxBus_Offset = NativeReflectionCached.GetPropertyOffset(SetAuxBusEffect_FunctionAddress, "InAuxBus");
		SetAuxBusEffect_InAuxBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAuxBusEffect_FunctionAddress, "InAuxBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAuxBusEffect_InEffectIndex_PropertyAddress, SetAuxBusEffect_FunctionAddress, "InEffectIndex");
		SetAuxBusEffect_InEffectIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetAuxBusEffect_FunctionAddress, "InEffectIndex");
		SetAuxBusEffect_InEffectIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAuxBusEffect_FunctionAddress, "InEffectIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAuxBusEffect_InEffectShareSet_PropertyAddress, SetAuxBusEffect_FunctionAddress, "InEffectShareSet");
		SetAuxBusEffect_InEffectShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetAuxBusEffect_FunctionAddress, "InEffectShareSet");
		SetAuxBusEffect_InEffectShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAuxBusEffect_FunctionAddress, "InEffectShareSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAuxBusEffect_ReturnValue_PropertyAddress, SetAuxBusEffect_FunctionAddress, "ReturnValue");
		SetAuxBusEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAuxBusEffect_FunctionAddress, "ReturnValue");
		SetAuxBusEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAuxBusEffect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAuxBusEffect_IsValid = SetAuxBusEffect_FunctionAddress != IntPtr.Zero && SetAuxBusEffect_InAuxBus_IsValid && SetAuxBusEffect_InEffectIndex_IsValid && SetAuxBusEffect_InEffectShareSet_IsValid && SetAuxBusEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetAuxBusEffect", SetAuxBusEffect_IsValid);
		SetActorMixerEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorMixerEffect");
		SetActorMixerEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorMixerEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorMixerEffect_InAudioNodeID_PropertyAddress, SetActorMixerEffect_FunctionAddress, "InAudioNodeID");
		SetActorMixerEffect_InAudioNodeID_Offset = NativeReflectionCached.GetPropertyOffset(SetActorMixerEffect_FunctionAddress, "InAudioNodeID");
		SetActorMixerEffect_InAudioNodeID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorMixerEffect_FunctionAddress, "InAudioNodeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorMixerEffect_InEffectIndex_PropertyAddress, SetActorMixerEffect_FunctionAddress, "InEffectIndex");
		SetActorMixerEffect_InEffectIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetActorMixerEffect_FunctionAddress, "InEffectIndex");
		SetActorMixerEffect_InEffectIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorMixerEffect_FunctionAddress, "InEffectIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorMixerEffect_InEffectShareSet_PropertyAddress, SetActorMixerEffect_FunctionAddress, "InEffectShareSet");
		SetActorMixerEffect_InEffectShareSet_Offset = NativeReflectionCached.GetPropertyOffset(SetActorMixerEffect_FunctionAddress, "InEffectShareSet");
		SetActorMixerEffect_InEffectShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorMixerEffect_FunctionAddress, "InEffectShareSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorMixerEffect_ReturnValue_PropertyAddress, SetActorMixerEffect_FunctionAddress, "ReturnValue");
		SetActorMixerEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorMixerEffect_FunctionAddress, "ReturnValue");
		SetActorMixerEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorMixerEffect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorMixerEffect_IsValid = SetActorMixerEffect_FunctionAddress != IntPtr.Zero && SetActorMixerEffect_InAudioNodeID_IsValid && SetActorMixerEffect_InEffectIndex_IsValid && SetActorMixerEffect_InEffectShareSet_IsValid && SetActorMixerEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:SetActorMixerEffect", SetActorMixerEffect_IsValid);
		ResetRTPCValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetRTPCValue");
		ResetRTPCValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetRTPCValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetRTPCValue_RTPCValue_PropertyAddress, ResetRTPCValue_FunctionAddress, "RTPCValue");
		ResetRTPCValue_RTPCValue_Offset = NativeReflectionCached.GetPropertyOffset(ResetRTPCValue_FunctionAddress, "RTPCValue");
		ResetRTPCValue_RTPCValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetRTPCValue_FunctionAddress, "RTPCValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetRTPCValue_InterpolationTimeMs_PropertyAddress, ResetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		ResetRTPCValue_InterpolationTimeMs_Offset = NativeReflectionCached.GetPropertyOffset(ResetRTPCValue_FunctionAddress, "InterpolationTimeMs");
		ResetRTPCValue_InterpolationTimeMs_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetRTPCValue_FunctionAddress, "InterpolationTimeMs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetRTPCValue_Actor_PropertyAddress, ResetRTPCValue_FunctionAddress, "Actor");
		ResetRTPCValue_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ResetRTPCValue_FunctionAddress, "Actor");
		ResetRTPCValue_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetRTPCValue_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetRTPCValue_RTPC_PropertyAddress, ResetRTPCValue_FunctionAddress, "RTPC");
		ResetRTPCValue_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(ResetRTPCValue_FunctionAddress, "RTPC");
		ResetRTPCValue_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetRTPCValue_FunctionAddress, "RTPC", Classes.FNameProperty);
		ResetRTPCValue_IsValid = ResetRTPCValue_FunctionAddress != IntPtr.Zero && ResetRTPCValue_RTPCValue_IsValid && ResetRTPCValue_InterpolationTimeMs_IsValid && ResetRTPCValue_Actor_IsValid && ResetRTPCValue_RTPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:ResetRTPCValue", ResetRTPCValue_IsValid);
		ReplaceMainOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceMainOutput");
		ReplaceMainOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceMainOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceMainOutput_MainOutputSettings_PropertyAddress, ReplaceMainOutput_FunctionAddress, "MainOutputSettings");
		ReplaceMainOutput_MainOutputSettings_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceMainOutput_FunctionAddress, "MainOutputSettings");
		ReplaceMainOutput_MainOutputSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceMainOutput_FunctionAddress, "MainOutputSettings", Classes.FStructProperty);
		ReplaceMainOutput_IsValid = ReplaceMainOutput_FunctionAddress != IntPtr.Zero && ReplaceMainOutput_MainOutputSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:ReplaceMainOutput", ReplaceMainOutput_IsValid);
		RemoveOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveOutput");
		RemoveOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveOutput_in_OutputDeviceId_PropertyAddress, RemoveOutput_FunctionAddress, "in_OutputDeviceId");
		RemoveOutput_in_OutputDeviceId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveOutput_FunctionAddress, "in_OutputDeviceId");
		RemoveOutput_in_OutputDeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveOutput_FunctionAddress, "in_OutputDeviceId", Classes.FStructProperty);
		RemoveOutput_IsValid = RemoveOutput_FunctionAddress != IntPtr.Zero && RemoveOutput_in_OutputDeviceId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:RemoveOutput", RemoveOutput_IsValid);
		RemoveMotionOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMotionOutput");
		RemoveMotionOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMotionOutput_FunctionAddress);
		RemoveMotionOutput_IsValid = RemoveMotionOutput_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:RemoveMotionOutput", RemoveMotionOutput_IsValid);
		PostTrigger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostTrigger");
		PostTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(PostTrigger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostTrigger_TriggerValue_PropertyAddress, PostTrigger_FunctionAddress, "TriggerValue");
		PostTrigger_TriggerValue_Offset = NativeReflectionCached.GetPropertyOffset(PostTrigger_FunctionAddress, "TriggerValue");
		PostTrigger_TriggerValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostTrigger_FunctionAddress, "TriggerValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostTrigger_Actor_PropertyAddress, PostTrigger_FunctionAddress, "Actor");
		PostTrigger_Actor_Offset = NativeReflectionCached.GetPropertyOffset(PostTrigger_FunctionAddress, "Actor");
		PostTrigger_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(PostTrigger_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostTrigger_Trigger_PropertyAddress, PostTrigger_FunctionAddress, "Trigger");
		PostTrigger_Trigger_Offset = NativeReflectionCached.GetPropertyOffset(PostTrigger_FunctionAddress, "Trigger");
		PostTrigger_Trigger_IsValid = NativeReflectionCached.ValidatePropertyClass(PostTrigger_FunctionAddress, "Trigger", Classes.FNameProperty);
		PostTrigger_IsValid = PostTrigger_FunctionAddress != IntPtr.Zero && PostTrigger_TriggerValue_IsValid && PostTrigger_Actor_IsValid && PostTrigger_Trigger_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:PostTrigger", PostTrigger_IsValid);
		PostEventOnDummyObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostEventOnDummyObj");
		PostEventOnDummyObj_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEventOnDummyObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEventOnDummyObj_AkEvent_PropertyAddress, PostEventOnDummyObj_FunctionAddress, "AkEvent");
		PostEventOnDummyObj_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostEventOnDummyObj_FunctionAddress, "AkEvent");
		PostEventOnDummyObj_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventOnDummyObj_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventOnDummyObj_EventName_PropertyAddress, PostEventOnDummyObj_FunctionAddress, "EventName");
		PostEventOnDummyObj_EventName_Offset = NativeReflectionCached.GetPropertyOffset(PostEventOnDummyObj_FunctionAddress, "EventName");
		PostEventOnDummyObj_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventOnDummyObj_FunctionAddress, "EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventOnDummyObj_ReturnValue_PropertyAddress, PostEventOnDummyObj_FunctionAddress, "ReturnValue");
		PostEventOnDummyObj_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostEventOnDummyObj_FunctionAddress, "ReturnValue");
		PostEventOnDummyObj_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventOnDummyObj_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostEventOnDummyObj_IsValid = PostEventOnDummyObj_FunctionAddress != IntPtr.Zero && PostEventOnDummyObj_AkEvent_IsValid && PostEventOnDummyObj_EventName_IsValid && PostEventOnDummyObj_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:PostEventOnDummyObj", PostEventOnDummyObj_IsValid);
		PostEventAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostEventAtLocation");
		PostEventAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEventAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_AkEvent_PropertyAddress, PostEventAtLocation_FunctionAddress, "AkEvent");
		PostEventAtLocation_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "AkEvent");
		PostEventAtLocation_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_Location_PropertyAddress, PostEventAtLocation_FunctionAddress, "Location");
		PostEventAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "Location");
		PostEventAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_Orientation_PropertyAddress, PostEventAtLocation_FunctionAddress, "Orientation");
		PostEventAtLocation_Orientation_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "Orientation");
		PostEventAtLocation_Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "Orientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_EventName_PropertyAddress, PostEventAtLocation_FunctionAddress, "EventName");
		PostEventAtLocation_EventName_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "EventName");
		PostEventAtLocation_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_WorldContextObject_PropertyAddress, PostEventAtLocation_FunctionAddress, "WorldContextObject");
		PostEventAtLocation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "WorldContextObject");
		PostEventAtLocation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEventAtLocation_ReturnValue_PropertyAddress, PostEventAtLocation_FunctionAddress, "ReturnValue");
		PostEventAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostEventAtLocation_FunctionAddress, "ReturnValue");
		PostEventAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEventAtLocation_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostEventAtLocation_IsValid = PostEventAtLocation_FunctionAddress != IntPtr.Zero && PostEventAtLocation_AkEvent_IsValid && PostEventAtLocation_Location_IsValid && PostEventAtLocation_Orientation_IsValid && PostEventAtLocation_EventName_IsValid && PostEventAtLocation_WorldContextObject_IsValid && PostEventAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:PostEventAtLocation", PostEventAtLocation_IsValid);
		PostEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostEvent");
		PostEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_AkEvent_PropertyAddress, PostEvent_FunctionAddress, "AkEvent");
		PostEvent_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "AkEvent");
		PostEvent_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_Actor_PropertyAddress, PostEvent_FunctionAddress, "Actor");
		PostEvent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "Actor");
		PostEvent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_CallbackMask_PropertyAddress, PostEvent_FunctionAddress, "CallbackMask");
		PostEvent_CallbackMask_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "CallbackMask");
		PostEvent_CallbackMask_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "CallbackMask", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_PostEventCallback_PropertyAddress, PostEvent_FunctionAddress, "PostEventCallback");
		PostEvent_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "PostEventCallback");
		PostEvent_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_bStopWhenAttachedToDestroyed_PropertyAddress, PostEvent_FunctionAddress, "bStopWhenAttachedToDestroyed");
		PostEvent_bStopWhenAttachedToDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "bStopWhenAttachedToDestroyed");
		PostEvent_bStopWhenAttachedToDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "bStopWhenAttachedToDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_EventName_PropertyAddress, PostEvent_FunctionAddress, "EventName");
		PostEvent_EventName_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "EventName");
		PostEvent_EventName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "EventName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostEvent_ReturnValue_PropertyAddress, PostEvent_FunctionAddress, "ReturnValue");
		PostEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostEvent_FunctionAddress, "ReturnValue");
		PostEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEvent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostEvent_IsValid = PostEvent_FunctionAddress != IntPtr.Zero && PostEvent_AkEvent_IsValid && PostEvent_Actor_IsValid && PostEvent_CallbackMask_IsValid && PostEvent_PostEventCallback_IsValid && PostEvent_bStopWhenAttachedToDestroyed_IsValid && PostEvent_EventName_IsValid && PostEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:PostEvent", PostEvent_IsValid);
		PostAndWaitForEndOfEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostAndWaitForEndOfEvent");
		PostAndWaitForEndOfEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAndWaitForEndOfEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostAndWaitForEndOfEvent_AkEvent_PropertyAddress, PostAndWaitForEndOfEvent_FunctionAddress, "AkEvent");
		PostAndWaitForEndOfEvent_AkEvent_Offset = NativeReflectionCached.GetPropertyOffset(PostAndWaitForEndOfEvent_FunctionAddress, "AkEvent");
		PostAndWaitForEndOfEvent_AkEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAndWaitForEndOfEvent_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAndWaitForEndOfEvent_Actor_PropertyAddress, PostAndWaitForEndOfEvent_FunctionAddress, "Actor");
		PostAndWaitForEndOfEvent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(PostAndWaitForEndOfEvent_FunctionAddress, "Actor");
		PostAndWaitForEndOfEvent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAndWaitForEndOfEvent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_PropertyAddress, PostAndWaitForEndOfEvent_FunctionAddress, "bStopWhenAttachedToDestroyed");
		PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(PostAndWaitForEndOfEvent_FunctionAddress, "bStopWhenAttachedToDestroyed");
		PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAndWaitForEndOfEvent_FunctionAddress, "bStopWhenAttachedToDestroyed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAndWaitForEndOfEvent_LatentInfo_PropertyAddress, PostAndWaitForEndOfEvent_FunctionAddress, "LatentInfo");
		PostAndWaitForEndOfEvent_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PostAndWaitForEndOfEvent_FunctionAddress, "LatentInfo");
		PostAndWaitForEndOfEvent_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAndWaitForEndOfEvent_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PostAndWaitForEndOfEvent_ReturnValue_PropertyAddress, PostAndWaitForEndOfEvent_FunctionAddress, "ReturnValue");
		PostAndWaitForEndOfEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostAndWaitForEndOfEvent_FunctionAddress, "ReturnValue");
		PostAndWaitForEndOfEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostAndWaitForEndOfEvent_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PostAndWaitForEndOfEvent_IsValid = PostAndWaitForEndOfEvent_FunctionAddress != IntPtr.Zero && PostAndWaitForEndOfEvent_AkEvent_IsValid && PostAndWaitForEndOfEvent_Actor_IsValid && PostAndWaitForEndOfEvent_bStopWhenAttachedToDestroyed_IsValid && PostAndWaitForEndOfEvent_LatentInfo_IsValid && PostAndWaitForEndOfEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:PostAndWaitForEndOfEvent", PostAndWaitForEndOfEvent_IsValid);
		LoadInitBank_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadInitBank");
		LoadInitBank_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadInitBank_FunctionAddress);
		LoadInitBank_IsValid = LoadInitBank_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:LoadInitBank", LoadInitBank_IsValid);
		IsGame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsGame");
		IsGame_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGame_WorldContextObject_PropertyAddress, IsGame_FunctionAddress, "WorldContextObject");
		IsGame_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsGame_FunctionAddress, "WorldContextObject");
		IsGame_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGame_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsGame_ReturnValue_PropertyAddress, IsGame_FunctionAddress, "ReturnValue");
		IsGame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGame_FunctionAddress, "ReturnValue");
		IsGame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGame_IsValid = IsGame_FunctionAddress != IntPtr.Zero && IsGame_WorldContextObject_IsValid && IsGame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:IsGame", IsGame_IsValid);
		IsEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEditor");
		IsEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEditor_ReturnValue_PropertyAddress, IsEditor_FunctionAddress, "ReturnValue");
		IsEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEditor_FunctionAddress, "ReturnValue");
		IsEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditor_IsValid = IsEditor_FunctionAddress != IntPtr.Zero && IsEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:IsEditor", IsEditor_IsValid);
		GetSpeakerAngles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSpeakerAngles");
		GetSpeakerAngles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpeakerAngles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpeakerAngles_SpeakerAngles_PropertyAddress, GetSpeakerAngles_FunctionAddress, "SpeakerAngles");
		GetSpeakerAngles_SpeakerAngles_Offset = NativeReflectionCached.GetPropertyOffset(GetSpeakerAngles_FunctionAddress, "SpeakerAngles");
		GetSpeakerAngles_SpeakerAngles_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpeakerAngles_FunctionAddress, "SpeakerAngles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpeakerAngles_HeightAngle_PropertyAddress, GetSpeakerAngles_FunctionAddress, "HeightAngle");
		GetSpeakerAngles_HeightAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetSpeakerAngles_FunctionAddress, "HeightAngle");
		GetSpeakerAngles_HeightAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpeakerAngles_FunctionAddress, "HeightAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpeakerAngles_DeviceShareSet_PropertyAddress, GetSpeakerAngles_FunctionAddress, "DeviceShareSet");
		GetSpeakerAngles_DeviceShareSet_Offset = NativeReflectionCached.GetPropertyOffset(GetSpeakerAngles_FunctionAddress, "DeviceShareSet");
		GetSpeakerAngles_DeviceShareSet_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpeakerAngles_FunctionAddress, "DeviceShareSet", Classes.FStrProperty);
		GetSpeakerAngles_IsValid = GetSpeakerAngles_FunctionAddress != IntPtr.Zero && GetSpeakerAngles_SpeakerAngles_IsValid && GetSpeakerAngles_HeightAngle_IsValid && GetSpeakerAngles_DeviceShareSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetSpeakerAngles", GetSpeakerAngles_IsValid);
		GetRTPCValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRTPCValue");
		GetRTPCValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRTPCValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_RTPCValue_PropertyAddress, GetRTPCValue_FunctionAddress, "RTPCValue");
		GetRTPCValue_RTPCValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "RTPCValue");
		GetRTPCValue_RTPCValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "RTPCValue", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_PlayingID_PropertyAddress, GetRTPCValue_FunctionAddress, "PlayingID");
		GetRTPCValue_PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "PlayingID");
		GetRTPCValue_PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "PlayingID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_InputValueType_PropertyAddress, GetRTPCValue_FunctionAddress, "InputValueType");
		GetRTPCValue_InputValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "InputValueType");
		GetRTPCValue_InputValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "InputValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_Value_PropertyAddress, GetRTPCValue_FunctionAddress, "Value");
		GetRTPCValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "Value");
		GetRTPCValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_OutputValueType_PropertyAddress, GetRTPCValue_FunctionAddress, "OutputValueType");
		GetRTPCValue_OutputValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "OutputValueType");
		GetRTPCValue_OutputValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "OutputValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_Actor_PropertyAddress, GetRTPCValue_FunctionAddress, "Actor");
		GetRTPCValue_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "Actor");
		GetRTPCValue_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRTPCValue_RTPC_PropertyAddress, GetRTPCValue_FunctionAddress, "RTPC");
		GetRTPCValue_RTPC_Offset = NativeReflectionCached.GetPropertyOffset(GetRTPCValue_FunctionAddress, "RTPC");
		GetRTPCValue_RTPC_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTPCValue_FunctionAddress, "RTPC", Classes.FNameProperty);
		GetRTPCValue_IsValid = GetRTPCValue_FunctionAddress != IntPtr.Zero && GetRTPCValue_RTPCValue_IsValid && GetRTPCValue_PlayingID_IsValid && GetRTPCValue_InputValueType_IsValid && GetRTPCValue_Value_IsValid && GetRTPCValue_OutputValueType_IsValid && GetRTPCValue_Actor_IsValid && GetRTPCValue_RTPC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetRTPCValue", GetRTPCValue_IsValid);
		GetCurrentAudioCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentAudioCulture");
		GetCurrentAudioCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAudioCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAudioCulture_ReturnValue_PropertyAddress, GetCurrentAudioCulture_FunctionAddress, "ReturnValue");
		GetCurrentAudioCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAudioCulture_FunctionAddress, "ReturnValue");
		GetCurrentAudioCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAudioCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentAudioCulture_IsValid = GetCurrentAudioCulture_FunctionAddress != IntPtr.Zero && GetCurrentAudioCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetCurrentAudioCulture", GetCurrentAudioCulture_IsValid);
		GetAvailableAudioCultures_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableAudioCultures");
		GetAvailableAudioCultures_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableAudioCultures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableAudioCultures_ReturnValue_PropertyAddress, GetAvailableAudioCultures_FunctionAddress, "ReturnValue");
		GetAvailableAudioCultures_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableAudioCultures_FunctionAddress, "ReturnValue");
		GetAvailableAudioCultures_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableAudioCultures_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAvailableAudioCultures_IsValid = GetAvailableAudioCultures_FunctionAddress != IntPtr.Zero && GetAvailableAudioCultures_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetAvailableAudioCultures", GetAvailableAudioCultures_IsValid);
		GetAkComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAkComponent");
		GetAkComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_AttachToComponent_PropertyAddress, GetAkComponent_FunctionAddress, "AttachToComponent");
		GetAkComponent_AttachToComponent_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "AttachToComponent");
		GetAkComponent_AttachToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "AttachToComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_ComponentCreated_PropertyAddress, GetAkComponent_FunctionAddress, "ComponentCreated");
		GetAkComponent_ComponentCreated_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "ComponentCreated");
		GetAkComponent_ComponentCreated_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "ComponentCreated", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_AttachPointName_PropertyAddress, GetAkComponent_FunctionAddress, "AttachPointName");
		GetAkComponent_AttachPointName_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "AttachPointName");
		GetAkComponent_AttachPointName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "AttachPointName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_Location_PropertyAddress, GetAkComponent_FunctionAddress, "Location");
		GetAkComponent_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "Location");
		GetAkComponent_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_LocationType_PropertyAddress, GetAkComponent_FunctionAddress, "LocationType");
		GetAkComponent_LocationType_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "LocationType");
		GetAkComponent_LocationType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "LocationType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkComponent_ReturnValue_PropertyAddress, GetAkComponent_FunctionAddress, "ReturnValue");
		GetAkComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkComponent_FunctionAddress, "ReturnValue");
		GetAkComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAkComponent_IsValid = GetAkComponent_FunctionAddress != IntPtr.Zero && GetAkComponent_AttachToComponent_IsValid && GetAkComponent_ComponentCreated_IsValid && GetAkComponent_AttachPointName_IsValid && GetAkComponent_Location_IsValid && GetAkComponent_LocationType_IsValid && GetAkComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetAkComponent", GetAkComponent_IsValid);
		GetAkAudioTypeUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAkAudioTypeUserData");
		GetAkAudioTypeUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAkAudioTypeUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAkAudioTypeUserData_Instance_PropertyAddress, GetAkAudioTypeUserData_FunctionAddress, "Instance");
		GetAkAudioTypeUserData_Instance_Offset = NativeReflectionCached.GetPropertyOffset(GetAkAudioTypeUserData_FunctionAddress, "Instance");
		GetAkAudioTypeUserData_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkAudioTypeUserData_FunctionAddress, "Instance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkAudioTypeUserData_Type_PropertyAddress, GetAkAudioTypeUserData_FunctionAddress, "Type");
		GetAkAudioTypeUserData_Type_Offset = NativeReflectionCached.GetPropertyOffset(GetAkAudioTypeUserData_FunctionAddress, "Type");
		GetAkAudioTypeUserData_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkAudioTypeUserData_FunctionAddress, "Type", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAkAudioTypeUserData_ReturnValue_PropertyAddress, GetAkAudioTypeUserData_FunctionAddress, "ReturnValue");
		GetAkAudioTypeUserData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAkAudioTypeUserData_FunctionAddress, "ReturnValue");
		GetAkAudioTypeUserData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAkAudioTypeUserData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAkAudioTypeUserData_IsValid = GetAkAudioTypeUserData_FunctionAddress != IntPtr.Zero && GetAkAudioTypeUserData_Instance_IsValid && GetAkAudioTypeUserData_Type_IsValid && GetAkAudioTypeUserData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:GetAkAudioTypeUserData", GetAkAudioTypeUserData_IsValid);
		ClearSoundBanksAndMedia_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearSoundBanksAndMedia");
		ClearSoundBanksAndMedia_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSoundBanksAndMedia_FunctionAddress);
		ClearSoundBanksAndMedia_IsValid = ClearSoundBanksAndMedia_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:ClearSoundBanksAndMedia", ClearSoundBanksAndMedia_IsValid);
		CancelEventCallback_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelEventCallback");
		CancelEventCallback_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelEventCallback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CancelEventCallback_PostEventCallback_PropertyAddress, CancelEventCallback_FunctionAddress, "PostEventCallback");
		CancelEventCallback_PostEventCallback_Offset = NativeReflectionCached.GetPropertyOffset(CancelEventCallback_FunctionAddress, "PostEventCallback");
		CancelEventCallback_PostEventCallback_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelEventCallback_FunctionAddress, "PostEventCallback", Classes.FDelegateProperty);
		CancelEventCallback_IsValid = CancelEventCallback_FunctionAddress != IntPtr.Zero && CancelEventCallback_PostEventCallback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:CancelEventCallback", CancelEventCallback_IsValid);
		AddOutputCaptureMarker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddOutputCaptureMarker");
		AddOutputCaptureMarker_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOutputCaptureMarker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOutputCaptureMarker_MarkerText_PropertyAddress, AddOutputCaptureMarker_FunctionAddress, "MarkerText");
		AddOutputCaptureMarker_MarkerText_Offset = NativeReflectionCached.GetPropertyOffset(AddOutputCaptureMarker_FunctionAddress, "MarkerText");
		AddOutputCaptureMarker_MarkerText_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOutputCaptureMarker_FunctionAddress, "MarkerText", Classes.FStrProperty);
		AddOutputCaptureMarker_IsValid = AddOutputCaptureMarker_FunctionAddress != IntPtr.Zero && AddOutputCaptureMarker_MarkerText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:AddOutputCaptureMarker", AddOutputCaptureMarker_IsValid);
		AddOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddOutput");
		AddOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOutput_in_Settings_PropertyAddress, AddOutput_FunctionAddress, "in_Settings");
		AddOutput_in_Settings_Offset = NativeReflectionCached.GetPropertyOffset(AddOutput_FunctionAddress, "in_Settings");
		AddOutput_in_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOutput_FunctionAddress, "in_Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOutput_out_DeviceID_PropertyAddress, AddOutput_FunctionAddress, "out_DeviceID");
		AddOutput_out_DeviceID_Offset = NativeReflectionCached.GetPropertyOffset(AddOutput_FunctionAddress, "out_DeviceID");
		AddOutput_out_DeviceID_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOutput_FunctionAddress, "out_DeviceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOutput_in_ListenerIDs_PropertyAddress, AddOutput_FunctionAddress, "in_ListenerIDs");
		AddOutput_in_ListenerIDs_Offset = NativeReflectionCached.GetPropertyOffset(AddOutput_FunctionAddress, "in_ListenerIDs");
		AddOutput_in_ListenerIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOutput_FunctionAddress, "in_ListenerIDs", Classes.FArrayProperty);
		AddOutput_IsValid = AddOutput_FunctionAddress != IntPtr.Zero && AddOutput_in_Settings_IsValid && AddOutput_out_DeviceID_IsValid && AddOutput_in_ListenerIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:AddOutput", AddOutput_IsValid);
		AddMotionOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMotionOutput");
		AddMotionOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMotionOutput_FunctionAddress);
		AddMotionOutput_IsValid = AddMotionOutput_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkGameplayStatics:AddMotionOutput", AddMotionOutput_IsValid);
	}
}
