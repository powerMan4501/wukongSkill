using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public delegate void Del_PostAkEvent_OnAkComp(UAkComponent AkComp, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "", bool bAkCompIsAutoDestroy = false);
