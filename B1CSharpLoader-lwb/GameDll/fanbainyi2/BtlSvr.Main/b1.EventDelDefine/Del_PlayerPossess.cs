using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PlayerPossess(UWorld World, ABGPPlayerController PC, UClass ToReplaceUnitInst, FTransform NewTransform, bool NeedBlend, out APawn NewPlayer, float PossessBlendTime = 0f, int PossessBlendFunc = 0, float PossessBlendExp = 0f, bool EnableBlendViewTarget = false);
