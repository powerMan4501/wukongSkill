using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PostAkEvent_Follow(USceneComponent SceneComp, FName AttachPointName, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "");
