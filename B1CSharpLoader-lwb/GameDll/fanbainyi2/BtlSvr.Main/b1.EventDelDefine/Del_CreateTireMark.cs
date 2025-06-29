using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_CreateTireMark(int NotifyInstID, UMaterialInstance DecalInst, FVector DecalSize, FName SocketName, float DecalLifeSpan, float DelayFadeOutTime, float DecalFadeTime);
