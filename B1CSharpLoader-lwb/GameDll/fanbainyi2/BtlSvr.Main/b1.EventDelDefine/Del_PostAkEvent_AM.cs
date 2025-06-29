using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PostAkEvent_AM(int MontageID, UMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, UAkAudioEvent AkStopEvent, bool Follow, string EventName, bool CanHandleStopRequest, bool bPlaySubtitle = true, string GroupName = "", string SwitchStateName = "");
