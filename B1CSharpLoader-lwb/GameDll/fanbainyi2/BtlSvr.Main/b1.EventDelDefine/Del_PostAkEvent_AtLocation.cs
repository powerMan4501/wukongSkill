using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PostAkEvent_AtLocation(FVector WorldPosistion, FRotator WorldRotator, UAkAudioEvent AkEvent);
